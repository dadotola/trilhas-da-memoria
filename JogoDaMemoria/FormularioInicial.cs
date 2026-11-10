namespace JogoDaMemoria;

public class FormularioInicial : Form
{
    public FormularioInicial()
    {
        Text = "Trilhas da Memória";
        ClientSize = new Size(900, 650);
        MinimumSize = new Size(720, 560);
        StartPosition = FormStartPosition.CenterScreen;
        BackgroundImage = RecursosImagens.Carregar("inicio");
        BackgroundImageLayout = ImageLayout.Stretch;

        Label titulo = new Label
        {
            Text = "Trilhas da Memória",
            Font = new Font("Segoe UI", 30, FontStyle.Bold),
            ForeColor = Color.FromArgb(24, 83, 63),
            BackColor = Color.Transparent,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Top,
            Height = 120
        };
        Label instrucoes = new Label
        {
            Text = "Encontre os pares e cuide do planeta!\n\n" +
                "Escolha duas cartas.\nCombine cada figura com a sua amiga.\n" +
                "São 3 fases para aprender e brincar!",
            Font = new Font("Segoe UI", 17),
            ForeColor = Color.FromArgb(24, 83, 63),
            BackColor = Color.FromArgb(240, 250, 231),
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Fill
        };
        Button comecar = new Button
        {
            Text = "Começar",
            Font = new Font("Segoe UI", 22, FontStyle.Bold),
            BackColor = Color.FromArgb(30, 110, 73),
            ForeColor = Color.White,
            Dock = DockStyle.Bottom,
            Height = 80,
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand
        };
        comecar.Click += Comecar_Click;
        Panel conteudo = new Panel
        {
            Dock = DockStyle.Top,
            Height = 420,
            Padding = new Padding(40, 0, 40, 20),
            BackColor = Color.Transparent
        };
        conteudo.Controls.Add(instrucoes);
        conteudo.Controls.Add(comecar);
        conteudo.Controls.Add(titulo);
        Controls.Add(conteudo);
        AcceptButton = comecar;
    }

    private void Comecar_Click(object? sender, EventArgs e)
    {
        Hide();
        using FormularioJogo jogo = new FormularioJogo();
        jogo.ShowDialog(this);
        Close();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            BackgroundImage?.Dispose();
        base.Dispose(disposing);
    }
}
