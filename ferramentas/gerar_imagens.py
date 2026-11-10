"""Cria os pictogramas originais do jogo. Uso opcional: Python 3 e Pillow.
O aplicativo C# usa os PNGs prontos e não depende de Python.
"""
from pathlib import Path
from PIL import Image, ImageDraw

PASTA = Path(__file__).resolve().parents[1] / 'JogoDaMemoria' / 'Imagens'
PASTA.mkdir(parents=True, exist_ok=True)
VERDE, AZUL, AMARELO, ESCURO = '#438f58', '#4aa9d6', '#f5c849', '#24483d'


def criar(tipo, variante=False):
    imagem = Image.new('RGBA', (128, 96), (255, 255, 255, 0))
    d = ImageDraw.Draw(imagem)

    def linha(pontos, cor=ESCURO, largura=4):
        d.line(pontos, fill=cor, width=largura)

    def caixa(area, cor, raio=4):
        d.rounded_rectangle(area, radius=raio, fill=cor, outline=ESCURO, width=2)

    def sol(x=97, y=17):
        d.ellipse((x-12, y-12, x+12, y+12), fill=AMARELO)
        for dx, dy in [(0, -20), (0, 20), (-20, 0), (20, 0)]:
            linha([(x+dx*.75, y+dy*.75), (x+dx, y+dy)], AMARELO, 3)

    def pessoa(x=62, y=20, cor='#eb9258'):
        d.ellipse((x-7, y-8, x+7, y+6), fill='#bf875f', outline=ESCURO)
        linha([(x, y+7), (x, y+36)], cor, 10)
        linha([(x-17, y+25), (x, y+13), (x+17, y+25)])
        linha([(x, y+34), (x-14, y+57)])
        linha([(x, y+34), (x+14, y+57)])

    def arvore(x=63, y=34, pequena=False):
        linha([(x, y+10), (x, 87)], '#8a5f3d', 9 if not pequena else 5)
        r = 28 if not pequena else 17
        d.ellipse((x-r, y-r, x+r, y+r), fill=VERDE, outline=ESCURO, width=2)

    def planta():
        linha([(64, 79), (64, 39)], VERDE, 5)
        d.ellipse((40, 31, 64, 50), fill=VERDE)
        d.ellipse((64, 22, 91, 43), fill=VERDE)
        caixa((44, 72, 85, 92), '#c18351')

    def bicicleta():
        for x in (29, 98):
            d.ellipse((x-21, 48, x+21, 90), outline=ESCURO, width=4)
        linha([(29,69),(49,36),(73,69),(29,69),(67,36),(98,69)], VERDE, 4)
        linha([(43,31),(58,31)])
        linha([(67,36),(78,20),(91,20)])

    if tipo.startswith('lixeira_'):
        cor = {'azul':'#4489d2','vermelha':'#e55b52','verde':VERDE,'amarela':AMARELO}[tipo[8:]]
        caixa((36, 27, 94, 86), cor)
        caixa((30, 19, 100, 30), cor)
        linha([(56,12),(74,12)], largura=5)
        linha([(52,42),(52,70)], '#ffffff', 4)
        linha([(77,42),(77,70)], '#ffffff', 4)
    elif tipo in ('papel','rascunho'):
        caixa((35, 10, 92, 88), '#f4eee1')
        if variante and tipo == 'rascunho':
            d.ellipse((65,24,82,41), fill=AMARELO)
            d.polygon([(40,75),(61,43),(83,75)], fill=VERDE)
        else:
            for y in (30,43,56,69): linha([(46,y),(80,y)], '#8eb4c2', 3)
            if tipo == 'rascunho':
                linha([(46,35),(61,28),(73,39),(48,48),(79,57)], '#9b7399', 3)
                linha([(90,76),(109,20)], '#e3ad42', 7)
    elif tipo == 'garrafa':
        caixa((53, 5, 76, 17), AZUL)
        caixa((49, 15, 80, 30), '#95d9ed')
        caixa((41, 29, 88, 90), '#95d9ed')
        caixa((42, 48, 87, 69), AZUL)
    elif tipo == 'vidro':
        caixa((37, 23, 91, 89), '#b3dfc5')
        caixa((34, 13, 94, 27), '#6d9b84')
        linha([(47,39),(47,70)], '#ffffff', 4)
    elif tipo == 'metal':
        caixa((38, 16, 90, 85), '#b1c1c9')
        d.ellipse((38,10,90,26), fill='#dbe4e8', outline=ESCURO, width=2)
        d.ellipse((55,13,74,21), outline=ESCURO, width=2)
        caixa((39, 36, 89, 65), '#e68b5f')
    elif tipo == 'banana':
        d.arc((24, 2, 106, 90), 5, 160, fill=AMARELO, width=19)
        linha([(104,42),(109,30)], '#875c33', 5)
    elif tipo == 'composto':
        caixa((24, 23, 106, 89), '#9c744b')
        for y in (40,60,78): linha([(27,y),(103,y)], '#654930', 3)
        d.ellipse((45,6,74,27), fill=VERDE)
        d.ellipse((68,10,95,28), fill=VERDE)
    elif tipo in ('pilha','coletor'):
        if tipo == 'coletor': caixa((17,13,111,91), '#e7b16d')
        caixa((46, 22, 81, 83), '#5e96bd')
        caixa((55, 15, 72, 25), '#a8b4bc')
        linha([(57,38),(70,38)], '#ffffff', 3)
        linha([(64,31),(64,45)], '#ffffff', 3)
    elif tipo == 'sacola':
        d.arc((44,5,86,55),180,360, fill=ESCURO,width=5)
        caixa((29, 29, 101, 88), '#d7be86')
        if variante:
            d.ellipse((33,27,59,50), fill='#e8694a')
            d.polygon([(67,43),(70,15),(82,12),(87,43)], fill=VERDE)
    elif tipo == 'torneira':
        caixa((20,24,82,41), '#a6c1ca')
        caixa((70,34,90,55), '#a6c1ca')
        linha([(47,24),(47,11)], largura=5)
        linha([(32,11),(63,11)], largura=5)
        caixa((17,39,34,81), '#a6c1ca')
        if not variante:
            for y in (61,76,88): d.ellipse((77,y,84,y+7), fill=AZUL)
        else:
            linha([(95,65),(104,77),(121,51)], VERDE,5)
    elif tipo == 'escova':
        caixa((26, 16, 100, 29), '#f58d66')
        for x in range(70,99,6): linha([(x,16),(x,5)], AZUL,4)
        linha([(29,29),(29,81)], '#f58d66',10)
    elif tipo == 'copo':
        d.polygon([(34,15),(94,15),(85,88),(43,88)], fill='#c5e8f0', outline=ESCURO, width=3)
        d.polygon([(39,49),(88,49),(84,84),(44,84)], fill=AZUL)
    elif tipo == 'banho':
        linha([(22,88),(22,19),(66,19)], '#92abb5',8)
        d.pieslice((52,11,91,48),180,360,fill='#92abb5',outline=ESCURO,width=2)
        for x in (60,72,84):
            linha([(x,43),(x-4,58)],AZUL,3)
            linha([(x,64),(x-4,79)],AZUL,3)
        if variante:
            d.ellipse((83,55,123,94),fill='#ffffff',outline=ESCURO,width=3)
            linha([(103,61),(103,76),(114,76)],ESCURO,3)
    elif tipo == 'lampada':
        d.ellipse((39,10,90,63), fill=('#d0d4d3' if variante else AMARELO), outline=ESCURO,width=3)
        caixa((53,62,77,80),'#9da8aa')
        linha([(56,86),(73,86)],largura=4)
        if not variante:
            for a,b in [((25,35),(13,35)),((102,35),(115,35)),((33,8),(24,2)),((97,8),(107,2))]: linha([a,b],AMARELO,4)
    elif tipo == 'janela':
        caixa((24,12,104,88), '#d3edfa')
        linha([(64,13),(64,88)], '#9b7450',4)
        linha([(24,50),(104,50)], '#9b7450',4)
        d.polygon([(23,13),(8,23),(8,77),(23,88)],fill='#aaceb3',outline=ESCURO)
        d.polygon([(105,13),(120,23),(120,77),(105,88)],fill='#aaceb3',outline=ESCURO)
        sol(80,30)
    elif tipo == 'sol': sol(64,47)
    elif tipo == 'cano':
        linha([(8,28),(54,28),(54,66),(116,66)], '#829faa',16)
        if not variante:
            linha([(52,39),(60,46),(49,52)], '#ffffff',4)
            for y in (59,76): d.ellipse((40,y,47,y+10),fill=AZUL)
        else:
            caixa((43,38,66,58), '#b9cdd1')
            linha([(89,17),(100,31),(119,8)],VERDE,5)
    elif tipo == 'balde':
        d.arc((33,4,94,71),180,360,fill=ESCURO,width=4)
        d.polygon([(30,29),(98,29),(87,87),(41,87)],fill=AZUL,outline=ESCURO,width=3)
        if variante:
            linha([(103,15),(111,80)], '#9c744b',5)
            d.polygon([(98,72),(121,70),(125,87),(97,90)],fill='#d2b579')
    elif tipo == 'tv':
        caixa((15,12,113,73), '#435b64')
        caixa((22,19,106,65), '#192c35' if variante else AZUL)
        linha([(64,74),(64,86)],largura=5)
        linha([(43,88),(85,88)],largura=5)
        if not variante:
            sol(84,33)
            d.polygon([(24,62),(48,32),(76,62)],fill=VERDE)
    elif tipo == 'bicicleta':
        if variante:
            caixa((2,3,126,93),'#d8e8d5')
            linha([(6,44),(122,44)], '#ffffff',3)
        bicicleta()
    elif tipo in ('onibus','metro'):
        if variante:
            caixa((7,8,121,23),'#81ad94')
            linha([(13,23),(13,90)],largura=5)
            linha([(115,23),(115,90)],largura=5)
        caixa((26,27,102,77), '#e5b74e' if tipo == 'onibus' else AZUL)
        caixa((34,33,94,56),'#d0ebf6')
        for x in (43,85): d.ellipse((x-8,70,x+8,86),fill=ESCURO)
        if tipo == 'metro':
            linha([(35,88),(29,95)],largura=4)
            linha([(93,88),(99,95)],largura=4)
    elif tipo == 'caminhada':
        if variante:
            caixa((2,73,126,94),'#bac9c1')
            for x in (20,50,80,110): linha([(x,75),(x,94)],'#899a92',2)
        pessoa(64,19)
    elif tipo == 'carona':
        caixa((15,40,114,77), '#e78663')
        d.polygon([(30,40),(42,15),(87,15),(103,40)],fill='#95cce2',outline=ESCURO,width=2)
        for x in (36,94): d.ellipse((x-10,66,x+10,86),fill=ESCURO)
        for x in (51,78): d.ellipse((x-6,22,x+6,34),fill='#b7825d')
        if variante: linha([(45,5),(64,1),(84,5)],VERDE,4)
    elif tipo == 'faixa':
        caixa((2,36,126,94),'#84938f')
        for x in (10,36,62,88,114): d.polygon([(x,44),(x+10,44),(x+1,87),(x-9,87)],fill='#ffffff')
        if variante: pessoa(67,8)
    elif tipo == 'capacete':
        if variante: pessoa(64,29)
        d.pieslice((31,6,97,64),180,360,fill='#e88a5d',outline=ESCURO,width=3)
        linha([(35,35),(38,62),(70,75),(94,48)],ESCURO,4)
        linha([(52,13),(52,29)],'#ffffff',4)
        linha([(73,13),(73,29)],'#ffffff',4)
    elif tipo == 'semaforo':
        linha([(66,78),(66,94)],largura=7)
        caixa((43,4,87,80),'#435b54')
        d.ellipse((52,11,78,37),fill='#dd6660' if variante else '#724443')
        d.ellipse((52,46,78,72),fill='#42614a' if variante else '#82cb72')
    elif tipo == 'arvore':
        if variante: d.ellipse((12,74,116,95),fill='#b8d8c0')
        arvore()
    elif tipo == 'muda':
        if variante:
            arvore(49,37)
            linha([(104,83),(104,17),(96,29)], VERDE, 4)
            linha([(104,17),(113,29)], VERDE, 4)
        else:
            d.ellipse((30,77,99,94), fill='#a47850')
            linha([(64,84),(64,45)], VERDE, 5)
            d.ellipse((38,31,64,50), fill=VERDE)
            d.ellipse((64,22,91,43), fill=VERDE)
    elif tipo == 'regar':
        if variante: planta()
        else:
            caixa((23,31,77,81), '#60ac9c')
            d.polygon([(76,43),(104,24),(111,31),(78,63)],fill='#60ac9c',outline=ESCURO,width=2)
            d.arc((4,32,45,75),70,290,fill=ESCURO,width=4)
            for x,y in ((109,42),(115,51),(121,62)): d.ellipse((x,y,x+4,y+7),fill=AZUL)
    elif tipo == 'parque':
        arvore(23,31,True)
        linha([(45,57),(115,57)],'#a97a49',8)
        linha([(47,73),(116,73)],'#a97a49',8)
        for x in (52,108): linha([(x,70),(x,93)],largura=4)
        if variante: pessoa(79,16)
    elif tipo == 'lixo':
        if variante:
            caixa((43,16,92,87),VERDE)
            caixa((37,13,98,24),VERDE)
        else:
            caixa((21,53,53,73),'#ddd0b2')
            caixa((75,60,104,82),AZUL)
            linha([(14,87),(117,87)],VERDE,3)
    elif tipo == 'flor':
        if variante:
            for x in (49,78): d.ellipse((x-18,7,x+18,44),fill='#cee9f3',outline=ESCURO,width=2)
            d.ellipse((27,30,103,72),fill=AMARELO,outline=ESCURO,width=2)
            for x in (48,68,88): linha([(x,35),(x,67)],ESCURO,5)
            d.ellipse((94,40,100,46),fill=ESCURO)
        else:
            linha([(64,47),(64,91)],VERDE,5)
            for x,y in ((64,19),(42,36),(50,61),(80,61),(87,36)): d.ellipse((x-14,y-14,x+14,y+14),fill='#e69bab')
            d.ellipse((51,30,77,56),fill=AMARELO)
    elif tipo == 'passaro':
        if variante:
            arvore(38,32)
            d.ellipse((57,54,115,79),fill='#ac845d',outline=ESCURO,width=2)
            for x in (74,93): d.ellipse((x-7,47,x+7,65),fill='#f2e3c5')
        else:
            d.ellipse((30,32,91,74),fill=AZUL,outline=ESCURO,width=2)
            d.ellipse((70,13,101,47),fill=AZUL,outline=ESCURO,width=2)
            d.polygon([(100,26),(117,33),(100,39)],fill=AMARELO)
            d.ellipse((87,23,92,28),fill=ESCURO)
            linha([(54,73),(54,88)],largura=3)
    elif tipo == 'horta':
        if variante:
            caixa((10,62,118,92),'#a47850')
            for x in (29,64,98):
                linha([(x,68),(x,38)],VERDE,4)
                d.ellipse((x-17,25,x,43),fill=VERDE)
                d.ellipse((x,17,x+17,35),fill=VERDE)
        else:
            for x,y in ((35,36),(77,26),(63,70),(98,63)): d.ellipse((x-9,y-13,x+9,y+13),fill='#a47850',outline=ESCURO,width=2)
    elif tipo == 'trilha':
        d.polygon([(18,96),(46,55),(57,12),(80,12),(75,58),(108,96)],fill='#c7ad82')
        for x,y in ((21,26),(105,27),(15,70),(112,70)):
            d.ellipse((x-11,y-12,x+11,y+12),fill=VERDE)
        if variante: pessoa(64,19)
    elif tipo == 'rio':
        d.rectangle((0,0,128,96),fill='#e0efd9')
        d.polygon([(39,0),(89,0),(70,36),(105,70),(79,96),(22,96),(55,63),(31,34)],fill=AZUL)
        if not variante:
            caixa((51,10,68,27),'#ab8060')
            caixa((64,66,88,79),'#d9c9a8')
        else:
            d.ellipse((57,53,80,64),fill='#f8c756')
            d.polygon([(58,58),(48,51),(48,65)],fill='#f8c756')
    else:
        raise ValueError(tipo)
    return imagem


PARES = {
    'papel': ('papel','lixeira_azul'), 'plastico': ('garrafa','lixeira_vermelha'),
    'vidro': ('vidro','lixeira_verde'), 'metal': ('metal','lixeira_amarela'),
    'organico': ('banana','composto'), 'pilha': ('pilha','coletor'),
    'sacola': ('sacola','sacola'), 'rascunho': ('rascunho','rascunho'),
    'torneira': ('torneira','torneira'), 'escova': ('escova','copo'),
    'banho': ('banho','banho'), 'lampada': ('lampada','lampada'),
    'janela': ('janela','sol'), 'vazamento': ('cano','cano'),
    'balde': ('balde','balde'), 'televisao': ('tv','tv'),
    'bicicleta': ('bicicleta','bicicleta'), 'onibus': ('onibus','onibus'),
    'caminhada': ('caminhada','caminhada'), 'metro': ('metro','metro'),
    'carona': ('carona','carona'), 'faixa': ('faixa','faixa'),
    'capacete': ('capacete','capacete'), 'semaforo': ('semaforo','semaforo'),
    'arvore': ('arvore','arvore'), 'muda': ('muda','muda'),
    'regar': ('regar','regar'), 'parque': ('parque','parque'),
    'lixo': ('lixo','lixo'), 'flor': ('flor','flor'),
    'passaro': ('passaro','passaro'), 'horta': ('horta','horta'),
    'trilha': ('trilha','trilha'), 'rio': ('rio','rio')
}

for codigo, tipos in PARES.items():
    for i, tipo in enumerate(tipos):
        criar(tipo, bool(i)).resize((64,48), Image.Resampling.LANCZOS).save(PASTA / f'{codigo}_{"ab"[i]}.png')

fundo = Image.new('RGB', (1200, 800), '#eaf6e5')
d = ImageDraw.Draw(fundo)
d.rectangle((0, 470, 1200, 800), fill='#d4e8b5')
d.ellipse((-300,530,1000,1000),fill='#afcf93')
d.ellipse((600,510,1600,1050),fill='#bedb9c')
d.ellipse((1020,25,1140,145),fill=AMARELO)
for tipo, x, y, tamanho in [('arvore',20,440,(230,220)),('arvore',960,410,(240,240)),('bicicleta',420,600,(190,145)),('lixeira_azul',210,600,(100,100)),('lixeira_verde',310,600,(100,100)),('regar',750,600,(150,115))]:
    icone = criar(tipo).resize(tamanho,Image.Resampling.LANCZOS)
    fundo.paste(icone,(x,y),icone)
fundo.save(PASTA / 'inicio.png')
print(f'Geradas {len(PARES)*2} imagens de cartas e 1 fundo.')
