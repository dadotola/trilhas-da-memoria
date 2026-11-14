# Trilhas da Memória

Jogo da memória sobre sustentabilidade urbana para crianças de 6 e 7 anos, desenvolvido em C# com Windows Forms para a disciplina de Lógica de Programação e Algoritmos II.

## Como jogar

Clique em **Começar** e encontre as figuras que se relacionam. Cada acerto apresenta uma mensagem educativa. Ao terminar as três fases, você pode jogar novamente ou encerrar.

| Fase | Tema | Tabuleiro |
| --- | --- | --- |
| 1 | Coleta seletiva e reciclagem | 4 × 4 — 8 pares |
| 2 | Economia de água e energia | 4 × 4 — 8 pares |
| 3 | Mobilidade sustentável e áreas verdes | 6 × 6 — 18 pares |

## Executar

No Windows, abra `JogoDaMemoria.sln` no Visual Studio com suporte ao .NET 10 e Windows Forms. Pressione **F5**.

## Gerar o instalador

Com o SDK .NET 10 e o Inno Setup 6 instalados, execute na raiz do projeto:

```powershell
./instalador/gerar-instalador.ps1
```

O arquivo será criado em `entrega/instalador/Instalar-TrilhasDaMemoria.exe`. Ele instala o jogo para Windows x64 com imagens, dependências e atalhos.

## Imagens

Ilustrações do Openclipart e do Twemoji. As fontes e licenças estão nos [créditos das imagens](JogoDaMemoria/Imagens/CREDITOS.md).
