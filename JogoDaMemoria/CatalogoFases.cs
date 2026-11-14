namespace JogoDaMemoria;

public static class CatalogoFases
{
    public static List<Fase> Criar()
    {
        return new List<Fase>
        {
            new Fase("Coleta seletiva e reciclagem", 4, new List<ParEducativo>
            {
                new ParEducativo("papel", "Papel", "Lixeira azul", "Muito bem! O papel deve ser colocado na lixeira azul."),
                new ParEducativo("plastico", "Garrafa plástica", "Lixeira vermelha", "A garrafa plástica limpa pode ser reciclada!"),
                new ParEducativo("vidro", "Pote de vidro", "Lixeira verde", "O vidro vai na lixeira verde. Peça ajuda a um adulto!"),
                new ParEducativo("metal", "Latinha", "Lixeira amarela", "As latinhas podem virar novos objetos de metal!"),
                new ParEducativo("organico", "Casca de banana", "Adubo", "Cascas de frutas podem virar adubo na composteira!"),
                new ParEducativo("pilha", "Pilha usada", "Coletor de pilhas", "Entregue pilhas usadas a um adulto para levar ao coletor certo."),
                new ParEducativo("sacola", "Sacola reutilizável", "Compras com sacola", "Reutilizar uma sacola nas compras diminui o lixo!"),
                new ParEducativo("rascunho", "Folha usada", "Desenhar no verso", "Usar o verso da folha para desenhar ajuda a economizar papel!")
            }),
            new Fase("Economia de água e energia", 4, new List<ParEducativo>
            {
                new ParEducativo("torneira", "Torneira aberta", "Torneira fechada", "Fechar a torneira economiza água."),
                new ParEducativo("escova", "Escova de dentes", "Copo com água", "Use um copo e feche a torneira ao escovar os dentes!"),
                new ParEducativo("banho", "Chuveiro", "Banho rápido", "Um banho mais curto economiza água e energia!"),
                new ParEducativo("lampada", "Luz acesa", "Luz apagada", "Apague a luz ao sair de um quarto vazio!"),
                new ParEducativo("janela", "Janela", "Luz do sol", "Aproveite a luz do dia para iluminar a casa!"),
                new ParEducativo("vazamento", "Torneira pingando", "Consertar vazamento", "Avise um adulto quando encontrar um vazamento!"),
                new ParEducativo("balde", "Balde", "Limpeza com balde", "Usar um balde na limpeza ajuda a gastar menos água!"),
                new ParEducativo("televisao", "TV ligada", "TV desligada", "Desligue a televisão quando ninguém estiver assistindo!")
            }),
            new Fase("Mobilidade sustentável e áreas verdes", 6, new List<ParEducativo>
            {
                new ParEducativo("bicicleta", "Bicicleta", "Ciclovia", "Andar de bicicleta ajuda a reduzir a poluição."),
                new ParEducativo("onibus", "Ônibus", "Ponto de ônibus", "O ônibus leva muitas pessoas em uma só viagem!"),
                new ParEducativo("caminhada", "Caminhada", "Calçada", "Caminhar com um adulto em trajetos curtos faz bem!"),
                new ParEducativo("metro", "Metrô", "Estação", "O metrô transporta muitas pessoas pela cidade!"),
                new ParEducativo("carona", "Carro", "Carona em família", "Compartilhar uma viagem pode diminuir o número de carros!"),
                new ParEducativo("faixa", "Faixa de pedestres", "Travessia segura", "Atravesse na faixa com um adulto e atenção ao trânsito!"),
                new ParEducativo("capacete", "Capacete", "Ciclista protegido", "Use capacete e pedale com segurança!"),
                new ParEducativo("semaforo", "Sinal fechado", "Sinal aberto", "Espere o sinal de pedestres permitir a travessia e atravesse com um adulto!"),
                new ParEducativo("arvore", "Árvore", "Sombra fresquinha", "As árvores dão sombra e ajudam a refrescar a cidade!"),
                new ParEducativo("muda", "Muda", "Árvore crescendo", "Plantar e cuidar das árvores ajuda a natureza!"),
                new ParEducativo("regar", "Regador", "Planta cuidada", "Regue as plantas na medida certa, sem desperdiçar água!"),
                new ParEducativo("parque", "Parque", "Brincar no parque", "Cuide do parque para todos poderem brincar!"),
                new ParEducativo("lixo", "Não jogar lixo", "Lixo na lixeira", "Jogue o lixo na lixeira e mantenha a praça limpa!"),
                new ParEducativo("flor", "Flor", "Abelha", "As flores alimentam as abelhas. Observe sem machucar!"),
                new ParEducativo("passaro", "Pássaro", "Ninho com ovos", "As árvores também são a casa de muitos animais. Preserve os ninhos!"),
                new ParEducativo("horta", "Sementes", "Horta", "Cultivar uma horta nos ensina a cuidar da natureza!"),
                new ParEducativo("trilha", "Passeio na natureza", "Calçado para trilha", "Siga a trilha e preserve as plantas ao redor!"),
                new ParEducativo("rio", "Rio com lixo", "Rio limpo", "Não jogue lixo nos rios. A água é importante para a vida!")
            })
        };
    }
}
