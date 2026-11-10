# Trilhas da Memória

Projeto da disciplina Lógica de Programação e Algoritmos II, semestre 2026-II.

## Objetivo

Desenvolver um jogo da memória em C#, usando Visual Studio e Windows Forms, para ensinar hábitos de sustentabilidade urbana a crianças de 6 e 7 anos. O projeto deve ser planejado para aplicação em uma escola do bairro ou município.

Fonte dos requisitos: `AT_LogProgAlgII_2026-II.pdf`, fornecido pela estudante. O prazo indicado no documento é 14/11, no semestre 2026-II, com envio pelo AVA.

## Orientações para o desenvolvimento

- Usar soluções adequadas ao segundo período de Sistemas de Informação, com explicações acessíveis a uma estudante de 19 anos.
- Manter o código simples, limpo e organizado, com nomes claros e métodos com responsabilidades bem definidas.
- Evitar arquitetura e dependências desnecessárias.
- Usar imagens e mensagens curtas, adequadas ao público infantil.
- Registrar o desenvolvimento para apoiar o relatório e a apresentação.
- Preencher os relatos de aplicação com experiências e evidências reais.

## Requisitos do jogo

| Fase | Tema | Tabuleiro | Pares |
| --- | --- | --- | --- |
| 1 | Coleta seletiva e reciclagem | 4 × 4 | 8 |
| 2 | Economia de água e energia | 4 × 4 | 8 |
| 3 | Mobilidade sustentável e preservação das áreas verdes | 6 × 6 | 18 |

- [ ] Criar um formulário inicial com imagem de fundo relacionada à sustentabilidade e botão **Começar**.
- [ ] Carregar o jogo ao clicar em **Começar**.
- [ ] Utilizar imagens relacionadas ao tema de cada fase.
- [ ] Distribuir as cartas aleatoriamente, inicialmente viradas para baixo.
- [ ] Permitir revelar apenas duas cartas por vez.
- [ ] Reconhecer pares por sua relação educativa, incluindo imagens diferentes, como papel e lixeira azul.
- [ ] Manter os pares corretos abertos.
- [ ] Apresentar uma mensagem educativa curta a cada par encontrado.
- [ ] Usar o componente `Timer` para esconder cartas diferentes após um intervalo curto.
- [ ] Detectar a conclusão quando todos os pares da fase forem encontrados.
- [ ] Permitir jogar as três fases. A sequência automática entre fases é uma proposta de implementação.
- [ ] Exibir uma mensagem de parabéns e oferecer nova partida ou encerramento ao concluir o jogo.

Exemplos do enunciado:

| Par | Mensagem |
| --- | --- |
| Papel e lixeira azul | Muito bem! O papel deve ser colocado na lixeira azul. |
| Torneira aberta e torneira fechada | Fechar a torneira economiza água. |
| Bicicleta e ciclovia | Andar de bicicleta ajuda a reduzir a poluição. |

## Instalador

- [ ] Criar um instalador para Windows com uma ferramenta de empacotamento, como o Visual Studio Installer.
- [ ] Incluir executável, imagens, bibliotecas e demais arquivos necessários.
- [ ] Configurar atalhos no menu Iniciar e na área de trabalho.
- [ ] Testar a instalação e o funcionamento em Windows, registrando a versão utilizada.
- [ ] Distribuir o instalador aos usuários participantes.

## Entrega e apresentação de Sistemas de Informação

- [ ] Código-fonte do jogo.
- [ ] Instalador do jogo.
- [ ] Vídeo demonstrando o jogo completo, com as três fases, hospedado online para envio do link.
- [ ] Relatório detalhado da implementação, execução e implantação.
- [ ] Capturas de tela de cada fase do desenvolvimento no relatório.
- [ ] Imagens da interação dos usuários finais e demais evidências coletadas no relatório.
- [ ] Banner digital seguindo o template do AVA.
- [ ] Informações do projeto, descrição de uso, análise das evidências e link do vídeo no banner.
- [ ] Autorização das pessoas antes de anexar depoimentos de áudio ou texto.
- [ ] Apresentação presencial no polo, em data a confirmar pela coordenação.
- [ ] Foto da apresentação incluída no relatório.
- [ ] Envio integral dos componentes pelo AVA.

## Estrutura do relatório recebido

Seguir o arquivo `Modelo de Relatório de Projetos (Curricularização) (1).docx`:

- Capa: curso, código e nome da disciplina, professora, título, estudante, cidade/UF e semestre 2026-II.
- Introdução: problema social, relevância, relação com a disciplina, apresentação do trabalho e valor para a comunidade.
- Objetivo: objetivo geral e objetivos específicos com etapas concretas.
- Fundamentação Teórica: conceitos utilizados, tecnologias relacionadas e citações de fontes confiáveis.
- Metodologia: identificação da demanda social, coleta de informações, ferramentas e métodos utilizados.
- Desenvolvimento do Projeto: demanda real, justificativa, público-alvo, escopo, impacto esperado e documentação da construção do jogo.
- Resultados e Discussão: evidências da aplicação, interação com a comunidade e análise dos objetivos alcançados.
- Conclusão: importância social, contribuições, dificuldades, aprendizados e melhorias futuras.
- Referências: fontes efetivamente utilizadas, formatadas em ABNT.
- Apêndices e Anexos, se aplicáveis: questionários, evidências completas, roteiros e códigos extensos.

Enquanto o desenvolvimento e a aplicação não ocorrerem, manter esses trechos como pendentes ou como planejamento, sem apresentá-los como atividades realizadas.

## Estrutura do banner recebido

Preservar o template `Template de Banner (2).pptx`, da Universidade Salgado de Oliveira — UNIVERSO. O slide contém campos para curso, modalidade EAD, campus, título do projeto, autor e professor, além das seções:

- Introdução.
- Objetivos.
- Metodologia.
- Resultados.
- Conclusões.
- Referências.

Incluir também a descrição de uso, a análise das evidências e o link do vídeo demonstrativo, exigidos pelo enunciado, distribuindo essas informações nas seções do modelo.

## Referência de implementação recebida: Exemplo 2

As capturas enviadas mostram o exemplo de jogo da memória em C# e Windows Forms. Alguns trechos estão cortados; o registro abaixo considera o conteúdo visível.

- `TableLayoutPanel` organiza o tabuleiro em células de tamanhos iguais, com `Dock = Fill`.
- Controles `Label` representam as cartas e compartilham um evento de clique.
- `Random` distribui os elementos aleatoriamente.
- Duas variáveis guardam a primeira e a segunda cartas selecionadas.
- O evento `Tick` de um `Timer` oculta as cartas diferentes e limpa a seleção.
- Enquanto o temporizador estiver ativo, novos cliques devem ser ignorados.
- Cartas já reveladas não devem ser selecionadas novamente.
- Um método verifica a conclusão da partida.

Adaptações necessárias para atender ao enunciado do trabalho:

- Substituir os símbolos da fonte Webdings por imagens dos temas de sustentabilidade.
- Identificar cada par por um código compartilhado, pois as duas imagens correspondentes podem ser diferentes.
- Manter o estado das cartas separado da aparência visual, para distinguir cartas selecionadas de pares confirmados.
- Confirmar a igualdade dos pares antes de verificar a vitória. No exemplo visível, a verificação ocorre antes da comparação e considera todas as cartas abertas, o que pode anunciar vitória com as duas últimas cartas diferentes.
- Ampliar a configuração para duas fases 4 × 4 e uma fase 6 × 6.
- Acrescentar tela inicial, mensagens educativas, progressão das fases e opção de nova partida ou encerramento.

O slide final propõe sons para acerto, erro e ocultação, usando `System.Media`. Esse desafio é complementar; o PDF do trabalho não exige sons.

## Primeira etapa: reproduzir o jogo dos slides

A ordem definida para o trabalho é construir primeiro o jogo do Exemplo 2 e depois adaptar essa base às instruções do PDF. A primeira versão usa os símbolos Webdings e o tabuleiro azul do material, sem antecipar as fases temáticas.

O projeto está em `JogoDaMemoria.sln` e utiliza C# com Windows Forms para .NET 10.

| Arquivo | Responsabilidade |
| --- | --- |
| `JogoDaMemoria/Program.cs` | Iniciar o aplicativo. |
| `JogoDaMemoria/FormularioJogo.Designer.cs` | Definir o formulário, as 16 cartas, o tabuleiro e o Timer. |
| `JogoDaMemoria/FormularioJogo.cs` | Sortear símbolos, tratar os cliques, comparar cartas e verificar a vitória. |

Os métodos e variáveis usam nomes em português. A distribuição segue o exemplo: sortear um símbolo da lista e removê-lo para que cada símbolo apareça exatamente duas vezes. O intervalo para esconder um par diferente é de 750 milissegundos. A vitória é verificada somente após confirmar um par correto; nesta versão, a mensagem de parabéns é seguida pelo fechamento do formulário, como nos slides.

### Abrir e executar no Windows

1. Usar Visual Studio com suporte ao SDK .NET 10 e à carga de trabalho **Desenvolvimento para desktop com .NET**.
2. Abrir `JogoDaMemoria.sln`.
3. Pressionar **F5** para compilar e executar.
4. Para visualizar o formulário no designer, abrir `FormularioJogo.cs` com **Exibir Designer**.

O uso do .NET atualiza a configuração do projeto; os controles e a lógica seguem o exemplo fornecido. Windows Forms é uma tecnologia de interface para Windows, conforme a [documentação da Microsoft](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/overview/). A fonte Webdings deve estar disponível na máquina para que os símbolos sejam exibidos como no material.

### Conferência manual da primeira etapa

- [ ] O formulário abre com 16 cartas escondidas.
- [ ] Clicar em uma carta revela seu símbolo.
- [ ] Clicar novamente na mesma carta não forma um par.
- [ ] Um par correto permanece aberto.
- [ ] Um par diferente fica visível brevemente e depois é escondido.
- [ ] Durante esse intervalo, clicar em uma terceira carta não a revela.
- [ ] Cartas de pares encontrados não podem ser escolhidas novamente.
- [ ] Se as duas últimas cartas reveladas forem diferentes, a vitória não é anunciada.
- [ ] A mensagem de parabéns aparece somente com oito pares corretos.
- [ ] Fechar o jogo enquanto o Timer está ativo encerra a aplicação sem erro.

### Segunda etapa: adaptar ao PDF

Após conferir a base no Windows, acrescentar a tela inicial e adaptar as cartas para imagens relacionadas por um identificador de par. Depois implementar mensagens educativas, três fases, nova partida e instalador. A versão com símbolos é uma etapa de desenvolvimento e ainda não atende à entrega final do PDF.

## Etapas propostas

1. Conferir os slides de referência do AVA e definir a escola de aplicação.
2. Planejar os pares, imagens e mensagens das três fases.
3. Criar o projeto C# e o formulário inicial.
4. Implementar e conferir a primeira fase: embaralhamento, seleção, comparação, Timer e conclusão.
5. Adicionar as outras fases e a opção de nova partida.
6. Validar a usabilidade para o público infantil e gerar o instalador.
7. Aplicar o jogo e reunir evidências reais.
8. Finalizar relatório, vídeo e banner, incluindo a evidência da apresentação.

## Materiais e informações pendentes

- Slides do **Exemplo de Aplicação 1**, ainda não enviados. As capturas recebidas são do **Exemplo 2** e já permitem planejar a lógica principal do jogo.
- Nome da estudante e dados acadêmicos para identificar os materiais de entrega.
- Escola e município onde o jogo será aplicado.
- Disponibilidade de um computador Windows com Visual Studio para validar a interface e o instalador.

## Situação atual

O PDF, o modelo de relatório, os textos do template de banner e as capturas do Exemplo 2 foram lidos e seus requisitos foram organizados. Os arquivos originais dos modelos foram preservados. A base do jogo dos slides foi implementada e compilada no Linux com o SDK .NET 10. A validação da interface no Windows e as adaptações do PDF estão pendentes. Os itens acima serão marcados somente conforme forem concluídos e verificados.
