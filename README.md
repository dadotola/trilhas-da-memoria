# Trilhas da Memória

Um jogo educativo em C# e Windows Forms para crianças de 6 e 7 anos, com o tema Sustentabilidade Urbana. Projeto de Lógica de Programação e Algoritmos II, Sistemas de Informação, semestre 2026-II.

O trabalho começou com o jogo dos slides do Exemplo 2. A versão inicial, com símbolos Webdings e tabuleiro azul 4 × 4, permanece no histórico do Git, no commit `a06af76`. A versão atual adapta essa base ao enunciado `AT_LogProgAlgII_2026-II.pdf`.

## Como jogar

Clique em **Começar**. Revele duas cartas e encontre as figuras relacionadas: por exemplo, papel e lixeira azul. Cada acerto apresenta uma mensagem educativa. As cartas diferentes ficam abertas por um segundo e depois são escondidas. Ao completar uma fase, o jogo passa à próxima. Depois das três fases, é possível começar uma nova partida ou encerrar.

| Fase | Tema | Tabuleiro | Pares |
| --- | --- | --- | --- |
| 1 | Coleta seletiva e reciclagem | 4 × 4 | 8 |
| 2 | Economia de água e energia | 4 × 4 | 8 |
| 3 | Mobilidade sustentável e preservação das áreas verdes | 6 × 6 | 18 |

## Executar no Windows

1. Instale o Visual Studio com suporte ao .NET 10 e a carga **Desenvolvimento para desktop com .NET**.
2. Abra `JogoDaMemoria.sln`.
3. Pressione **F5**.

Também é possível executar no terminal de um computador Windows com o SDK .NET 10:

```bash
dotnet run --project JogoDaMemoria/JogoDaMemoria.csproj
```

O aplicativo depende de Windows Forms e não abre nativamente no Linux. No Linux, é possível compilar e conferir os dados das fases; os testes visuais e de instalação precisam acontecer no Windows.

## Organização do código

| Arquivo | Função |
| --- | --- |
| `Program.cs` | Abrir a tela inicial. |
| `FormularioInicial.cs` | Exibir a imagem de fundo, as instruções e o botão Começar. |
| `FormularioJogo.cs` | Montar o tabuleiro, sortear cartas, tratar cliques e avançar as fases. |
| `FormularioJogo.Designer.cs` | Definir os controles do jogo e o Timer. |
| `Carta.cs` | Guardar a descrição, a imagem e o estado de uma carta. |
| `ParEducativo.cs` | Identificar as duas cartas correspondentes e sua mensagem. |
| `Fase.cs` | Guardar o tema, o tamanho e os pares de uma fase. |
| `CatalogoFases.cs` | Definir os 34 pares e as mensagens das três fases. |
| `RecursosImagens.cs` | Ler os PNGs incorporados ao aplicativo. |

Foram mantidos `TableLayoutPanel`, cartas em `Label`, evento de clique compartilhado, `Random`, duas cartas selecionadas e `System.Windows.Forms.Timer`, como no material da disciplina. A comparação usa o código do par, pois imagens equivalentes podem ser diferentes. A vitória é verificada somente após um acerto confirmado.

Os nomes e métodos estão em português. As classes representam conceitos do jogo, sem banco de dados, serviços externos ou frameworks adicionais. As 68 ilustrações das cartas e o fundo são desenhos originais simples, incluídos em `JogoDaMemoria/Imagens` e incorporados como recursos na compilação. O script opcional `ferramentas/gerar_imagens.py` permite recriá-los com Python e Pillow; ele não é necessário para jogar.

## Gerar o instalador

O PDF permite ferramentas de empacotamento como o Visual Studio Installer. Este projeto utiliza **Inno Setup 6**, com configuração em `instalador/TrilhasDaMemoria.iss`.

No Windows, instale o SDK .NET 10 e o Inno Setup 6. Na raiz do projeto, execute no PowerShell:

```powershell
./instalador/gerar-instalador.ps1
```

O script publica o jogo para **Windows x64**, incluindo o runtime .NET e as imagens incorporadas. A publicação autocontida permite distribuir a pasta sem exigir que o jogador instale o SDK. Veja a [documentação de publicação da Microsoft](https://learn.microsoft.com/en-us/dotnet/core/deploying/).

Arquivos gerados:

- `entrega/jogo/`: executável e dependências. Para testar, execute `JogoDaMemoria.exe` dessa pasta mantendo os demais arquivos juntos.
- `entrega/instalador/Instalar-TrilhasDaMemoria.exe`: instalador completo, depois da compilação pelo Inno Setup.

O instalador é por usuário e configura atalhos no menu Iniciar e na área de trabalho, usando a [seção Icons do Inno Setup](https://jrsoftware.org/ishelp/topic_iconssection.htm). A compatibilidade deve ser confirmada no Windows dos computadores da escola; não foi verificada em todas as versões ou arquiteturas do sistema.

Há também um fluxo em `.github/workflows/compilar-windows.yml`. Depois que os arquivos forem enviados ao GitHub, ele pode gerar o instalador em um executor Windows. O resultado fica nos artefatos da execução **Compilar jogo e instalador**, na aba Actions. A configuração do fluxo não significa que ele já foi executado ou validado.

## Verificações

Para conferir o catálogo, execute na raiz do projeto:

```bash
dotnet run --project Verificacoes/Verificacoes.csproj
```

Essa verificação confere as três fases, seus tamanhos, quantidades de pares, códigos únicos, mensagens, descrições e a presença dos PNGs das 68 cartas e do fundo. Também detecta arquivos de imagem idênticos dentro de uma fase, para evitar cartas visualmente ambíguas. Ela não substitui jogar no Windows.

Para compilar:

```bash
dotnet build JogoDaMemoria.sln
```

Conferência manual pendente no Windows:

- [ ] Tela inicial com fundo de sustentabilidade e botão Começar.
- [ ] Fases 1 e 2 com 16 cartas e fase 3 com 36 cartas, inicialmente escondidas.
- [ ] Mesma carta não pode ser escolhida duas vezes; pares encontrados não são selecionados novamente.
- [ ] Duas cartas diferentes são escondidas após um segundo; terceira carta bloqueada nesse intervalo.
- [ ] Cada par correto permanece aberto e apresenta sua própria mensagem.
- [ ] Duas últimas cartas diferentes não anunciam vitória.
- [ ] Progressão correta entre as três fases.
- [ ] Nova partida reinicia a fase 1, sem cartas ou contadores da partida anterior.
- [ ] Encerrar ou fechar durante o Timer termina o aplicativo sem erro.
- [ ] Na tela da escola, imagens e legendas ficam legíveis, inclusive em 6 × 6 e na escala de exibição utilizada.
- [ ] Instalar, abrir pelos dois atalhos e jogar em um Windows compatível sem SDK/runtime previamente instalado.
- [ ] Desinstalar e conferir a remoção dos arquivos e atalhos.

## Etapas futuras de entrega

Por orientação da estudante, o relatório e o banner não serão produzidos nesta etapa. Os modelos recebidos ficam como referência para quando essa parte do trabalho começar. Trechos sobre aplicação e resultados devem ser preenchidos após a atividade acontecer.

O relatório deve conter capa, introdução, objetivo, fundamentação teórica, metodologia, desenvolvimento, resultados e discussão, conclusão, referências em ABNT e apêndices/anexos aplicáveis. O banner deve seguir o modelo da UNIVERSO com introdução, objetivos, metodologia, resultados, conclusões e referências, além da identificação, descrição de uso, análise das evidências e link do vídeo.

Para finalizar a entrega indicada no PDF, até **14/11/2026 pelo AVA**:

- [ ] Conferir os slides do Exemplo 1, ainda não recebidos; foram recebidas capturas do Exemplo 2.
- [ ] Confirmar escola, cidade e público participante.
- [ ] Testar o jogo e o instalador no Windows e registrar as capturas de tela.
- [ ] Aplicar o jogo na escola, reunir evidências reais e distribuir o instalador.
- [ ] Solicitar autorização antes de anexar depoimentos de áudio ou texto, conforme o enunciado.
- [ ] Gravar vídeo demonstrativo das três fases, hospedar online e inserir o link no relatório e banner.
- [ ] Completar o relatório com capturas do desenvolvimento, imagens da interação e análise das evidências.
- [ ] Completar o banner no modelo fornecido e preparar a apresentação presencial no polo.
- [ ] Incluir no relatório uma foto da apresentação, em data a confirmar pela coordenação.
- [ ] Enviar código-fonte, instalador, relatório, link do vídeo e banner.

Sons aparecem como desafio complementar nos slides e não são exigidos pelo PDF; não foram acrescentados nesta etapa.
