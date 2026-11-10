namespace JogoDaMemoria;

partial class FormularioJogo
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel tabuleiro;
    private System.Windows.Forms.Timer temporizador;
    private Label carta1;
    private Label carta2;
    private Label carta3;
    private Label carta4;
    private Label carta5;
    private Label carta6;
    private Label carta7;
    private Label carta8;
    private Label carta9;
    private Label carta10;
    private Label carta11;
    private Label carta12;
    private Label carta13;
    private Label carta14;
    private Label carta15;
    private Label carta16;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            components?.Dispose();

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        tabuleiro = new TableLayoutPanel();
        temporizador = new System.Windows.Forms.Timer(components);
        carta1 = new Label();
        carta2 = new Label();
        carta3 = new Label();
        carta4 = new Label();
        carta5 = new Label();
        carta6 = new Label();
        carta7 = new Label();
        carta8 = new Label();
        carta9 = new Label();
        carta10 = new Label();
        carta11 = new Label();
        carta12 = new Label();
        carta13 = new Label();
        carta14 = new Label();
        carta15 = new Label();
        carta16 = new Label();
        tabuleiro.SuspendLayout();
        SuspendLayout();

        // tabuleiro
        tabuleiro.BackColor = Color.CornflowerBlue;
        tabuleiro.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
        tabuleiro.ColumnCount = 4;
        tabuleiro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tabuleiro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tabuleiro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tabuleiro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tabuleiro.Dock = DockStyle.Fill;
        tabuleiro.Name = "tabuleiro";
        tabuleiro.RowCount = 4;
        tabuleiro.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tabuleiro.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tabuleiro.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tabuleiro.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tabuleiro.Size = new Size(600, 600);
        tabuleiro.TabIndex = 0;

        // carta1
        carta1.AutoSize = false;
        carta1.BackColor = Color.CornflowerBlue;
        carta1.Dock = DockStyle.Fill;
        carta1.Font = new Font("Webdings", 72F, FontStyle.Bold);
        carta1.ForeColor = Color.CornflowerBlue;
        carta1.Margin = new Padding(0);
        carta1.Name = "carta1";
        carta1.TextAlign = ContentAlignment.MiddleCenter;
        carta1.Cursor = Cursors.Hand;
        carta1.Click += Carta_Click;
        tabuleiro.Controls.Add(carta1, 0, 0);

        // carta2
        carta2.AutoSize = false;
        carta2.BackColor = Color.CornflowerBlue;
        carta2.Dock = DockStyle.Fill;
        carta2.Font = new Font("Webdings", 72F, FontStyle.Bold);
        carta2.ForeColor = Color.CornflowerBlue;
        carta2.Margin = new Padding(0);
        carta2.Name = "carta2";
        carta2.TextAlign = ContentAlignment.MiddleCenter;
        carta2.Cursor = Cursors.Hand;
        carta2.Click += Carta_Click;
        tabuleiro.Controls.Add(carta2, 1, 0);

        // carta3
        carta3.AutoSize = false;
        carta3.BackColor = Color.CornflowerBlue;
        carta3.Dock = DockStyle.Fill;
        carta3.Font = new Font("Webdings", 72F, FontStyle.Bold);
        carta3.ForeColor = Color.CornflowerBlue;
        carta3.Margin = new Padding(0);
        carta3.Name = "carta3";
        carta3.TextAlign = ContentAlignment.MiddleCenter;
        carta3.Cursor = Cursors.Hand;
        carta3.Click += Carta_Click;
        tabuleiro.Controls.Add(carta3, 2, 0);

        // carta4
        carta4.AutoSize = false;
        carta4.BackColor = Color.CornflowerBlue;
        carta4.Dock = DockStyle.Fill;
        carta4.Font = new Font("Webdings", 72F, FontStyle.Bold);
        carta4.ForeColor = Color.CornflowerBlue;
        carta4.Margin = new Padding(0);
        carta4.Name = "carta4";
        carta4.TextAlign = ContentAlignment.MiddleCenter;
        carta4.Cursor = Cursors.Hand;
        carta4.Click += Carta_Click;
        tabuleiro.Controls.Add(carta4, 3, 0);

        // carta5
        carta5.AutoSize = false;
        carta5.BackColor = Color.CornflowerBlue;
        carta5.Dock = DockStyle.Fill;
        carta5.Font = new Font("Webdings", 72F, FontStyle.Bold);
        carta5.ForeColor = Color.CornflowerBlue;
        carta5.Margin = new Padding(0);
        carta5.Name = "carta5";
        carta5.TextAlign = ContentAlignment.MiddleCenter;
        carta5.Cursor = Cursors.Hand;
        carta5.Click += Carta_Click;
        tabuleiro.Controls.Add(carta5, 0, 1);

        // carta6
        carta6.AutoSize = false;
        carta6.BackColor = Color.CornflowerBlue;
        carta6.Dock = DockStyle.Fill;
        carta6.Font = new Font("Webdings", 72F, FontStyle.Bold);
        carta6.ForeColor = Color.CornflowerBlue;
        carta6.Margin = new Padding(0);
        carta6.Name = "carta6";
        carta6.TextAlign = ContentAlignment.MiddleCenter;
        carta6.Cursor = Cursors.Hand;
        carta6.Click += Carta_Click;
        tabuleiro.Controls.Add(carta6, 1, 1);

        // carta7
        carta7.AutoSize = false;
        carta7.BackColor = Color.CornflowerBlue;
        carta7.Dock = DockStyle.Fill;
        carta7.Font = new Font("Webdings", 72F, FontStyle.Bold);
        carta7.ForeColor = Color.CornflowerBlue;
        carta7.Margin = new Padding(0);
        carta7.Name = "carta7";
        carta7.TextAlign = ContentAlignment.MiddleCenter;
        carta7.Cursor = Cursors.Hand;
        carta7.Click += Carta_Click;
        tabuleiro.Controls.Add(carta7, 2, 1);

        // carta8
        carta8.AutoSize = false;
        carta8.BackColor = Color.CornflowerBlue;
        carta8.Dock = DockStyle.Fill;
        carta8.Font = new Font("Webdings", 72F, FontStyle.Bold);
        carta8.ForeColor = Color.CornflowerBlue;
        carta8.Margin = new Padding(0);
        carta8.Name = "carta8";
        carta8.TextAlign = ContentAlignment.MiddleCenter;
        carta8.Cursor = Cursors.Hand;
        carta8.Click += Carta_Click;
        tabuleiro.Controls.Add(carta8, 3, 1);

        // carta9
        carta9.AutoSize = false;
        carta9.BackColor = Color.CornflowerBlue;
        carta9.Dock = DockStyle.Fill;
        carta9.Font = new Font("Webdings", 72F, FontStyle.Bold);
        carta9.ForeColor = Color.CornflowerBlue;
        carta9.Margin = new Padding(0);
        carta9.Name = "carta9";
        carta9.TextAlign = ContentAlignment.MiddleCenter;
        carta9.Cursor = Cursors.Hand;
        carta9.Click += Carta_Click;
        tabuleiro.Controls.Add(carta9, 0, 2);

        // carta10
        carta10.AutoSize = false;
        carta10.BackColor = Color.CornflowerBlue;
        carta10.Dock = DockStyle.Fill;
        carta10.Font = new Font("Webdings", 72F, FontStyle.Bold);
        carta10.ForeColor = Color.CornflowerBlue;
        carta10.Margin = new Padding(0);
        carta10.Name = "carta10";
        carta10.TextAlign = ContentAlignment.MiddleCenter;
        carta10.Cursor = Cursors.Hand;
        carta10.Click += Carta_Click;
        tabuleiro.Controls.Add(carta10, 1, 2);

        // carta11
        carta11.AutoSize = false;
        carta11.BackColor = Color.CornflowerBlue;
        carta11.Dock = DockStyle.Fill;
        carta11.Font = new Font("Webdings", 72F, FontStyle.Bold);
        carta11.ForeColor = Color.CornflowerBlue;
        carta11.Margin = new Padding(0);
        carta11.Name = "carta11";
        carta11.TextAlign = ContentAlignment.MiddleCenter;
        carta11.Cursor = Cursors.Hand;
        carta11.Click += Carta_Click;
        tabuleiro.Controls.Add(carta11, 2, 2);

        // carta12
        carta12.AutoSize = false;
        carta12.BackColor = Color.CornflowerBlue;
        carta12.Dock = DockStyle.Fill;
        carta12.Font = new Font("Webdings", 72F, FontStyle.Bold);
        carta12.ForeColor = Color.CornflowerBlue;
        carta12.Margin = new Padding(0);
        carta12.Name = "carta12";
        carta12.TextAlign = ContentAlignment.MiddleCenter;
        carta12.Cursor = Cursors.Hand;
        carta12.Click += Carta_Click;
        tabuleiro.Controls.Add(carta12, 3, 2);

        // carta13
        carta13.AutoSize = false;
        carta13.BackColor = Color.CornflowerBlue;
        carta13.Dock = DockStyle.Fill;
        carta13.Font = new Font("Webdings", 72F, FontStyle.Bold);
        carta13.ForeColor = Color.CornflowerBlue;
        carta13.Margin = new Padding(0);
        carta13.Name = "carta13";
        carta13.TextAlign = ContentAlignment.MiddleCenter;
        carta13.Cursor = Cursors.Hand;
        carta13.Click += Carta_Click;
        tabuleiro.Controls.Add(carta13, 0, 3);

        // carta14
        carta14.AutoSize = false;
        carta14.BackColor = Color.CornflowerBlue;
        carta14.Dock = DockStyle.Fill;
        carta14.Font = new Font("Webdings", 72F, FontStyle.Bold);
        carta14.ForeColor = Color.CornflowerBlue;
        carta14.Margin = new Padding(0);
        carta14.Name = "carta14";
        carta14.TextAlign = ContentAlignment.MiddleCenter;
        carta14.Cursor = Cursors.Hand;
        carta14.Click += Carta_Click;
        tabuleiro.Controls.Add(carta14, 1, 3);

        // carta15
        carta15.AutoSize = false;
        carta15.BackColor = Color.CornflowerBlue;
        carta15.Dock = DockStyle.Fill;
        carta15.Font = new Font("Webdings", 72F, FontStyle.Bold);
        carta15.ForeColor = Color.CornflowerBlue;
        carta15.Margin = new Padding(0);
        carta15.Name = "carta15";
        carta15.TextAlign = ContentAlignment.MiddleCenter;
        carta15.Cursor = Cursors.Hand;
        carta15.Click += Carta_Click;
        tabuleiro.Controls.Add(carta15, 2, 3);

        // carta16
        carta16.AutoSize = false;
        carta16.BackColor = Color.CornflowerBlue;
        carta16.Dock = DockStyle.Fill;
        carta16.Font = new Font("Webdings", 72F, FontStyle.Bold);
        carta16.ForeColor = Color.CornflowerBlue;
        carta16.Margin = new Padding(0);
        carta16.Name = "carta16";
        carta16.TextAlign = ContentAlignment.MiddleCenter;
        carta16.Cursor = Cursors.Hand;
        carta16.Click += Carta_Click;
        tabuleiro.Controls.Add(carta16, 3, 3);

        // temporizador
        temporizador.Interval = 750;
        temporizador.Tick += Temporizador_Tick;

        // FormularioJogo
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(600, 600);
        Controls.Add(tabuleiro);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormularioJogo";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Jogo da Memória";
        tabuleiro.ResumeLayout(false);
        ResumeLayout(false);
    }
}

