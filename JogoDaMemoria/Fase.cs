namespace JogoDaMemoria;

public class Fase
{
    public string Tema { get; }
    public int Tamanho { get; }
    public List<ParEducativo> Pares { get; }

    public Fase(string tema, int tamanho, List<ParEducativo> pares)
    {
        Tema = tema;
        Tamanho = tamanho;
        Pares = pares;
    }
}
