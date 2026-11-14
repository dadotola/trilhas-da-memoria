namespace JogoDaMemoria;

public static class RecursosImagens
{
    public static Bitmap Carregar(string nome)
    {
        string caminho = Path.Combine(Application.StartupPath, "Imagens", nome + ".png");
        // Carrega o PNG da pasta do jogo e devolve uma cópia para liberar o arquivo.
        using (Image imagem = Image.FromFile(caminho))
        {
            return new Bitmap(imagem);
        }
    }
}
