namespace JogoDaMemoria;

public partial class FormularioJogo : Form
{
    private readonly Random sorteador = new Random();
    private readonly List<Fase> fases = CatalogoFases.Criar();
    private readonly Font fonteEscondida = new Font("Segoe UI", 22, FontStyle.Bold);
    private readonly Font fonteRevelada = new Font("Segoe UI", 9, FontStyle.Bold);
    private Label? primeiraCarta;
    private Label? segundaCarta;
    private int faseAtual;
    private int paresEncontrados;

    public FormularioJogo()
    {
        InitializeComponent();
    }

    private void FormularioJogo_Load(object? sender, EventArgs e)
    {
        CarregarFase();
    }

    private void CarregarFase()
    {
        temporizador.Stop();
        LimparSelecao();
        paresEncontrados = 0;
        Fase fase = fases[faseAtual];
        tituloFase.Text = $"Fase {faseAtual + 1} de {fases.Count} — {fase.Tema}";
        instrucao.Text = "Encontre as figuras que combinam!";
        AtualizarPlacar();

        tabuleiro.SuspendLayout();
        LimparTabuleiro();

        tabuleiro.ColumnStyles.Clear();
        tabuleiro.RowStyles.Clear();
        tabuleiro.ColumnCount = fase.Tamanho;
        tabuleiro.RowCount = fase.Tamanho;
        for (int i = 0; i < fase.Tamanho; i++)
        {
            tabuleiro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / fase.Tamanho));
            tabuleiro.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / fase.Tamanho));
        }

        List<Carta> cartas = CriarCartas(fase);
        int quantidade = cartas.Count;
        for (int i = 0; i < quantidade; i++)
        {
            // Mesma ideia do slide: sorteia uma carta e a retira da lista.
            int indice = sorteador.Next(cartas.Count);
            Label controle = CriarControleCarta(cartas[indice]);
            tabuleiro.Controls.Add(controle, i % fase.Tamanho, i / fase.Tamanho);
            cartas.RemoveAt(indice);
        }
        tabuleiro.ResumeLayout();
        RedimensionarTabuleiro(this, EventArgs.Empty);
    }

    private void RedimensionarTabuleiro(object? sender, EventArgs e)
    {
        // Usa um quadrado centralizado para manter as linhas e colunas do mesmo tamanho.
        int lado = Math.Min(areaTabuleiro.ClientSize.Width, areaTabuleiro.ClientSize.Height);
        // Cada borda Inset ocupa dois pixels; o espaço restante é dividido entre as cartas.
        int bordas = 2 * (tabuleiro.ColumnCount + 1);
        int tamanhoCelula = (lado - bordas) / tabuleiro.ColumnCount;
        if (tamanhoCelula <= 0)
            return;
        lado = tamanhoCelula * tabuleiro.ColumnCount + bordas;
        int espacoHorizontal = areaTabuleiro.ClientSize.Width - lado;
        int espacoVertical = areaTabuleiro.ClientSize.Height - lado;
        // O Dock posiciona o tabuleiro depois da escala da tela, respeitando estas margens.
        areaTabuleiro.Padding = new Padding(
            espacoHorizontal / 2,
            espacoVertical / 2,
            espacoHorizontal - espacoHorizontal / 2,
            espacoVertical - espacoVertical / 2);
    }

    private void LimparTabuleiro()
    {
        while (tabuleiro.Controls.Count > 0)
        {
            Label controle = (Label)tabuleiro.Controls[0];
            controle.Image?.Dispose();
            controle.Dispose();
        }
    }

    private List<Carta> CriarCartas(Fase fase)
    {
        List<Carta> cartas = new List<Carta>();
        foreach (ParEducativo par in fase.Pares)
        {
            cartas.Add(new Carta(par, par.PrimeiraDescricao, par.Codigo + "_a"));
            cartas.Add(new Carta(par, par.SegundaDescricao, par.Codigo + "_b"));
        }
        return cartas;
    }

    private Label CriarControleCarta(Carta carta)
    {
        Label controle = new Label
        {
            Dock = DockStyle.Fill,
            AutoSize = false,
            Margin = new Padding(2),
            Padding = new Padding(1),
            BackColor = Color.FromArgb(35, 108, 77),
            ForeColor = Color.White,
            Text = "?",
            Font = fonteEscondida,
            TextAlign = ContentAlignment.MiddleCenter,
            ImageAlign = ContentAlignment.TopCenter,
            Cursor = Cursors.Hand,
            AccessibleName = "Carta escondida",
            Tag = carta // Associa os dados da carta ao Label que recebe o clique.
        };
        controle.Click += Carta_Click;
        return controle;
    }

    private void RevelarCarta(Label controle)
    {
        Carta carta = (Carta)controle.Tag!;
        carta.Revelada = true;
        controle.BackColor = Color.White;
        controle.ForeColor = Color.FromArgb(24, 60, 45);
        controle.Font = fonteRevelada;
        controle.TextAlign = ContentAlignment.BottomCenter;
        controle.Text = carta.Descricao;
        controle.Image = RecursosImagens.Carregar(carta.Imagem);
        controle.AccessibleName = carta.Descricao;
    }

    private void EsconderCarta(Label controle)
    {
        Carta carta = (Carta)controle.Tag!;
        carta.Revelada = false;
        controle.Image?.Dispose();
        controle.Image = null;
        controle.Text = "?";
        controle.Font = fonteEscondida;
        controle.TextAlign = ContentAlignment.MiddleCenter;
        controle.BackColor = Color.FromArgb(35, 108, 77);
        controle.ForeColor = Color.White;
        controle.AccessibleName = "Carta escondida";
    }

    private void Carta_Click(object? sender, EventArgs e)
    {
        Label? controle = sender as Label;
        if (temporizador.Enabled || controle == null)
            return;

        Carta carta = (Carta)controle.Tag!;
        if (carta.Revelada || carta.Encontrada)
            return;

        RevelarCarta(controle);
        if (primeiraCarta == null)
        {
            primeiraCarta = controle;
            return;
        }

        segundaCarta = controle;
        Carta primeira = (Carta)primeiraCarta.Tag!;
        // Compara o par, pois figuras diferentes podem combinar, como papel e lixeira azul.
        if (primeira.Par.Codigo == carta.Par.Codigo)
        {
            primeira.Encontrada = true;
            carta.Encontrada = true;
            primeiraCarta.BackColor = Color.FromArgb(219, 244, 192);
            segundaCarta.BackColor = primeiraCarta.BackColor;
            paresEncontrados++;
            AtualizarPlacar();
            LimparSelecao();
            MessageBox.Show(this, carta.Par.Mensagem, "Muito bem!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Só verifica a conclusão depois de confirmar o acerto.
            VerificarVitoria();
            return;
        }

        instrucao.Text = "Essas figuras não combinam. Tente de novo!";
        temporizador.Start();
    }

    private void Temporizador_Tick(object? sender, EventArgs e)
    {
        temporizador.Stop();
        if (primeiraCarta != null && segundaCarta != null)
        {
            EsconderCarta(primeiraCarta);
            EsconderCarta(segundaCarta);
        }
        LimparSelecao();
        instrucao.Text = "Encontre as figuras que combinam!";
    }

    private void LimparSelecao()
    {
        primeiraCarta = null;
        segundaCarta = null;
    }

    private void AtualizarPlacar()
    {
        placar.Text = $"Pares encontrados: {paresEncontrados} de {fases[faseAtual].Pares.Count}";
    }

    private void VerificarVitoria()
    {
        if (paresEncontrados != fases[faseAtual].Pares.Count)
            return;

        if (faseAtual < fases.Count - 1)
        {
            MessageBox.Show(this, "Parabéns! Você completou esta fase. Vamos para a próxima!",
                "Fase concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
            faseAtual++;
            CarregarFase();
            return;
        }

        DialogResult resposta = MessageBox.Show(this,
            "Parabéns! Você completou as 3 fases e aprendeu a cuidar da cidade!\n\nQuer jogar novamente?",
            "Você venceu!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        if (resposta == DialogResult.Yes)
        {
            faseAtual = 0;
            CarregarFase();
        }
        else
        {
            Close();
        }
    }
}
