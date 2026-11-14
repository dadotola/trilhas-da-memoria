namespace JogoDaMemoria;

public partial class FormularioInicial : Form
{
    public FormularioInicial()
    {
        InitializeComponent();
    }

    private void FormularioInicial_Load(object? sender, EventArgs e)
    {
        BackgroundImage = RecursosImagens.Carregar("inicio");
    }

    private void Comecar_Click(object? sender, EventArgs e)
    {
        Hide();
        using (FormularioJogo jogo = new FormularioJogo())
        {
            jogo.ShowDialog(this);
        }
        Close();
    }
}
