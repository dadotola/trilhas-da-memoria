using System.Reflection;

namespace JogoDaMemoria;

public static class RecursosImagens
{
    public static Bitmap Carregar(string nome)
    {
        string recurso = "JogoDaMemoria.Imagens." + nome + ".png";
        using Stream arquivo = Assembly.GetExecutingAssembly().GetManifestResourceStream(recurso)
            ?? throw new InvalidOperationException("Imagem não encontrada: " + recurso);
        using Image imagem = Image.FromStream(arquivo);
        return new Bitmap(imagem);
    }
}
