namespace JogoDaMemoria;

partial class FormularioInicial
{
    private System.ComponentModel.IContainer components = null;
    private Panel conteudo;
    private Label titulo;
    private Label instrucoes;
    private Button comecar;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            components?.Dispose();
            BackgroundImage?.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        conteudo = new Panel();
        titulo = new Label();
        instrucoes = new Label();
        comecar = new Button();
        conteudo.SuspendLayout();
        SuspendLayout();

        titulo.Name = "titulo";
        titulo.Text = "Trilhas da Memória";
        titulo.AutoSize = false;
        titulo.Dock = DockStyle.Top;
        titulo.Height = 120;
        titulo.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
        titulo.ForeColor = Color.FromArgb(24, 83, 63);
        titulo.BackColor = Color.Transparent;
        titulo.TextAlign = ContentAlignment.MiddleCenter;

        instrucoes.Name = "instrucoes";
        instrucoes.Text = "Encontre os pares e cuide do planeta!\n\n" +
            "Escolha duas cartas.\nCombine cada figura com a sua amiga.\n" +
            "São 3 fases para aprender e brincar!";
        instrucoes.AutoSize = false;
        instrucoes.Dock = DockStyle.Fill;
        instrucoes.Font = new Font("Segoe UI", 17F);
        instrucoes.ForeColor = Color.FromArgb(24, 83, 63);
        instrucoes.BackColor = Color.FromArgb(240, 250, 231);
        instrucoes.TextAlign = ContentAlignment.MiddleCenter;

        comecar.Name = "comecar";
        comecar.Text = "Começar";
        comecar.Dock = DockStyle.Bottom;
        comecar.Height = 80;
        comecar.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        comecar.BackColor = Color.FromArgb(30, 110, 73);
        comecar.ForeColor = Color.White;
        comecar.FlatStyle = FlatStyle.Flat;
        comecar.Cursor = Cursors.Hand;
        comecar.Click += Comecar_Click;

        conteudo.Name = "conteudo";
        conteudo.Dock = DockStyle.Top;
        conteudo.Height = 420;
        conteudo.Padding = new Padding(40, 0, 40, 20);
        conteudo.BackColor = Color.Transparent;
        conteudo.Controls.Add(instrucoes);
        conteudo.Controls.Add(comecar);
        conteudo.Controls.Add(titulo);

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 640);
        MinimumSize = new Size(720, 560);
        StartPosition = FormStartPosition.CenterScreen;
        BackgroundImageLayout = ImageLayout.Stretch;
        Controls.Add(conteudo);
        AcceptButton = comecar;
        Name = "FormularioInicial";
        Text = "Trilhas da Memória";
        Load += FormularioInicial_Load;
        conteudo.ResumeLayout(false);
        ResumeLayout(false);
    }
}
