namespace JogoDaMemoria;

public partial class FormularioJogo : Form
{
    private readonly Random sorteador = new Random();
    private Label? primeiraCarta;
    private Label? segundaCarta;

    public FormularioJogo()
    {
        InitializeComponent();
        AtribuirIconesAsCartas();
    }

    private void AtribuirIconesAsCartas()
    {
        // Cada caractere representa um símbolo da fonte Webdings, como nos slides.
        List<string> icones = new List<string>
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        foreach (Control controle in tabuleiro.Controls)
        {
            if (controle is Label carta)
            {
                int indice = sorteador.Next(icones.Count);
                carta.Text = icones[indice];
                carta.ForeColor = carta.BackColor;
                carta.AccessibleName = "Carta escondida";
                icones.RemoveAt(indice);
            }
        }
    }

    private void Carta_Click(object? sender, EventArgs e)
    {
        if (temporizador.Enabled)
            return;

        if (sender is not Label cartaClicada)
            return;

        // Uma carta aberta não pode ser escolhida novamente.
        if (cartaClicada.ForeColor == Color.Black)
            return;

        cartaClicada.ForeColor = Color.Black;
        cartaClicada.AccessibleName = "Carta revelada: " + cartaClicada.Text;

        if (primeiraCarta == null)
        {
            primeiraCarta = cartaClicada;
            return;
        }

        segundaCarta = cartaClicada;

        if (primeiraCarta.Text == segundaCarta.Text)
        {
            LimparSelecao();
            VerificarVitoria();
            return;
        }

        temporizador.Start();
    }

    private void Temporizador_Tick(object? sender, EventArgs e)
    {
        temporizador.Stop();

        if (primeiraCarta != null && segundaCarta != null)
        {
            primeiraCarta.ForeColor = primeiraCarta.BackColor;
            segundaCarta.ForeColor = segundaCarta.BackColor;
            primeiraCarta.AccessibleName = "Carta escondida";
            segundaCarta.AccessibleName = "Carta escondida";
        }

        LimparSelecao();
    }

    private void LimparSelecao()
    {
        primeiraCarta = null;
        segundaCarta = null;
    }

    private void VerificarVitoria()
    {
        foreach (Control controle in tabuleiro.Controls)
        {
            if (controle is Label carta && carta.ForeColor == carta.BackColor)
                return;
        }

        MessageBox.Show(this, "Você encontrou todos os pares!", "Parabéns!",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        Close();
    }
}
