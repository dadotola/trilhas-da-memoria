namespace JogoDaMemoria;

public static class CatalogoFases
{
    public static List<Fase> Criar()
    {
        return new List<Fase>
        {
            new Fase("Coleta seletiva e reciclagem", 4, new List<ParEducativo>
            {
                new("papel", "Papel", "Lixeira azul", "Muito bem! O papel deve ser colocado na lixeira azul."),
                new("plastico", "Garrafa plástica", "Lixeira vermelha", "A garrafa plástica limpa pode ser reciclada!"),
                new("vidro", "Pote de vidro", "Lixeira verde", "O vidro vai na lixeira verde. Peça ajuda a um adulto!"),
                new("metal", "Latinha", "Lixeira amarela", "As latinhas podem virar novos objetos de metal!"),
                new("organico", "Casca de banana", "Composteira", "Cascas de frutas podem virar adubo na composteira!"),
                new("pilha", "Pilha usada", "Coletor de pilhas", "Entregue pilhas usadas a um adulto para levar ao coletor certo."),
                new("sacola", "Sacola de pano", "Compras com sacola", "Reutilizar a sacola de pano diminui o lixo!"),
                new("rascunho", "Folha usada", "Desenho no verso", "Usar o verso da folha ajuda a economizar papel!")
            }),
            new Fase("Economia de água e energia", 4, new List<ParEducativo>
            {
                new("torneira", "Torneira aberta", "Torneira fechada", "Fechar a torneira economiza água."),
                new("escova", "Escova de dentes", "Copo com água", "Use um copo e feche a torneira ao escovar os dentes!"),
                new("banho", "Chuveiro", "Banho rápido", "Um banho mais curto economiza água e energia!"),
                new("lampada", "Luz acesa", "Luz apagada", "Apague a luz ao sair de um quarto vazio!"),
                new("janela", "Janela aberta", "Luz do sol", "Aproveite a luz do dia para iluminar a casa!"),
                new("vazamento", "Cano pingando", "Cano consertado", "Avise um adulto quando encontrar um vazamento!"),
                new("balde", "Balde", "Limpeza com balde", "Usar um balde na limpeza ajuda a gastar menos água!"),
                new("televisao", "TV ligada", "TV desligada", "Desligue a televisão quando ninguém estiver assistindo!")
            }),
            new Fase("Mobilidade sustentável e áreas verdes", 6, new List<ParEducativo>
            {
                new("bicicleta", "Bicicleta", "Ciclovia", "Andar de bicicleta ajuda a reduzir a poluição."),
                new("onibus", "Ônibus", "Ponto de ônibus", "O ônibus leva muitas pessoas em uma só viagem!"),
                new("caminhada", "Caminhada", "Calçada", "Caminhar com um adulto em trajetos curtos faz bem!"),
                new("metro", "Metrô", "Estação", "O metrô transporta muitas pessoas pela cidade!"),
                new("carona", "Carro com amigos", "Carona combinada", "Compartilhar uma viagem pode diminuir o número de carros!"),
                new("faixa", "Faixa de pedestres", "Travessia segura", "Atravesse na faixa com um adulto e atenção ao trânsito!"),
                new("capacete", "Capacete", "Ciclista protegido", "Use capacete e pedale com segurança!"),
                new("semaforo", "Sinal de pedestres", "Esperar para passar", "Espere o sinal de pedestres permitir a travessia!"),
                new("arvore", "Árvore", "Sombra fresquinha", "As árvores dão sombra e ajudam a refrescar a cidade!"),
                new("muda", "Muda", "Árvore crescendo", "Plantar e cuidar das árvores ajuda a natureza!"),
                new("regar", "Regador", "Planta cuidada", "Regue as plantas na medida certa, sem desperdiçar água!"),
                new("parque", "Parque", "Brincar no parque", "Cuide do parque para todos poderem brincar!"),
                new("lixo", "Lixo no chão", "Lixo na lixeira", "Jogue o lixo na lixeira e mantenha a praça limpa!"),
                new("flor", "Flor", "Abelha", "As flores alimentam as abelhas. Observe sem machucar!"),
                new("passaro", "Pássaro", "Árvore com ninho", "As árvores também são a casa de muitos animais!"),
                new("horta", "Sementes", "Horta", "Cultivar uma horta nos ensina a cuidar da natureza!"),
                new("trilha", "Trilha", "Passeio na trilha", "Siga a trilha e preserve as plantas ao redor!"),
                new("rio", "Rio com lixo", "Rio limpo", "Não jogue lixo nos rios. A água é importante para a vida!")
            })
        };
    }
}
