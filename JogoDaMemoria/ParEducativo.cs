namespace JogoDaMemoria;

public class ParEducativo
{
    public string Codigo { get; }
    public string PrimeiraDescricao { get; }
    public string SegundaDescricao { get; }
    public string Mensagem { get; }

    public ParEducativo(string codigo, string primeiraDescricao, string segundaDescricao, string mensagem)
    {
        Codigo = codigo;
        PrimeiraDescricao = primeiraDescricao;
        SegundaDescricao = segundaDescricao;
        Mensagem = mensagem;
    }
}
