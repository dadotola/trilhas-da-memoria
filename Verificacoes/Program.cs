using JogoDaMemoria;

// Confere o conteúdo usado pelo jogo, sem depender da interface Windows Forms.
string raiz = args.Length > 0 ? args[0] : Directory.GetCurrentDirectory();
string pastaImagens = Path.Combine(raiz, "JogoDaMemoria", "Imagens");
List<Fase> fases = CatalogoFases.Criar();
int[] tamanhos = { 4, 4, 6 };
int[] quantidades = { 8, 8, 18 };
HashSet<string> codigos = new HashSet<string>();

Conferir(fases.Count == 3, "Devem existir três fases.");
for (int i = 0; i < fases.Count; i++)
{
    Fase fase = fases[i];
    Conferir(fase.Tamanho == tamanhos[i], "Tamanho incorreto na fase " + (i + 1));
    Conferir(fase.Pares.Count == quantidades[i], "Quantidade de pares incorreta.");
    Conferir(fase.Pares.Count * 2 == fase.Tamanho * fase.Tamanho, "O tabuleiro não será preenchido.");
    HashSet<string> desenhos = new HashSet<string>();
    foreach (ParEducativo par in fase.Pares)
    {
        Conferir(codigos.Add(par.Codigo), "Código de par repetido: " + par.Codigo);
        Conferir(!string.IsNullOrWhiteSpace(par.Mensagem), "Par sem mensagem educativa.");
        Conferir(!string.IsNullOrWhiteSpace(par.PrimeiraDescricao), "Carta sem descrição.");
        Conferir(!string.IsNullOrWhiteSpace(par.SegundaDescricao), "Carta sem descrição.");
        foreach (string lado in new[] { "_a", "_b" })
        {
            string imagem = Path.Combine(pastaImagens, par.Codigo + lado + ".png");
            Conferir(File.Exists(imagem), "Imagem ausente: " + imagem);
            byte[] conteudo = File.ReadAllBytes(imagem);
            byte[] assinatura = conteudo.Take(8).ToArray();
            Conferir(assinatura.SequenceEqual(new byte[] { 137, 80, 78, 71, 13, 10, 26, 10 }),
                "Arquivo não é PNG: " + imagem);
            string resumo = Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(conteudo));
            Conferir(desenhos.Add(resumo), "Há imagens repetidas na mesma fase: " + imagem);
        }
    }
}
Conferir(File.Exists(Path.Combine(pastaImagens, "inicio.png")), "Fundo da tela inicial ausente.");
Console.WriteLine("Conferência concluída: 3 fases, 34 pares, 68 cartas com imagens e mensagens.");

static void Conferir(bool condicao, string mensagem)
{
    if (!condicao)
        throw new InvalidOperationException(mensagem);
}
