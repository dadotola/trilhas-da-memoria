namespace JogoDaMemoria;

public class Carta
{
    public ParEducativo Par { get; }
    public string Descricao { get; }
    public string Imagem { get; }
    public bool Revelada { get; set; }
    public bool Encontrada { get; set; }

    public Carta(ParEducativo par, string descricao, string imagem)
    {
        Par = par;
        Descricao = descricao;
        Imagem = imagem;
    }
}
