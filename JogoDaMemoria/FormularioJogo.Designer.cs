namespace JogoDaMemoria;

partial class FormularioJogo
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel tabuleiro;
    private Panel areaTabuleiro;
    private System.Windows.Forms.Timer temporizador;
    private Label tituloFase;
    private Label instrucao;
    private Label placar;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            components?.Dispose();
            LimparTabuleiro();
            fonteEscondida.Dispose();
            fonteRevelada.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        tabuleiro = new TableLayoutPanel();
        areaTabuleiro = new Panel();
        temporizador = new System.Windows.Forms.Timer(components);
        tituloFase = new Label();
        instrucao = new Label();
        placar = new Label();
        SuspendLayout();

        tituloFase.Dock = DockStyle.Top;
        tituloFase.Height = 48;
        tituloFase.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        tituloFase.TextAlign = ContentAlignment.MiddleCenter;

        instrucao.Dock = DockStyle.Top;
        instrucao.Height = 32;
        instrucao.Font = new Font("Segoe UI", 12F);
        instrucao.TextAlign = ContentAlignment.MiddleCenter;

        placar.Dock = DockStyle.Bottom;
        placar.Height = 30;
        placar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        placar.TextAlign = ContentAlignment.MiddleCenter;

        tabuleiro.ColumnCount = 4;
        tabuleiro.RowCount = 4;
        tabuleiro.Dock = DockStyle.Fill;
        tabuleiro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tabuleiro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tabuleiro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tabuleiro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tabuleiro.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tabuleiro.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tabuleiro.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tabuleiro.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tabuleiro.BackColor = Color.FromArgb(227, 240, 218);
        tabuleiro.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
        tabuleiro.Name = "tabuleiro";
        areaTabuleiro.Name = "areaTabuleiro";
        areaTabuleiro.Dock = DockStyle.Fill;
        areaTabuleiro.Controls.Add(tabuleiro);
        areaTabuleiro.Resize += RedimensionarTabuleiro;
        temporizador.Interval = 1000;
        temporizador.Tick += Temporizador_Tick;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 680);
        MinimumSize = new Size(800, 700);
        BackColor = Color.FromArgb(244, 249, 236);
        ForeColor = Color.FromArgb(24, 60, 45);
        Padding = new Padding(8);
        Controls.Add(areaTabuleiro);
        Controls.Add(placar);
        Controls.Add(instrucao);
        Controls.Add(tituloFase);
        StartPosition = FormStartPosition.CenterScreen;
        Name = "FormularioJogo";
        Text = "Trilhas da Memória — Sustentabilidade Urbana";
        Load += FormularioJogo_Load;
        ResumeLayout(false);
    }
}
