using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stick_RPG_Fight
{
    class Contexto
    {
        
        public static Background Fundo = new Background();
        public static bool[] Fase = new bool[4]; // qual fase usar

        public static void inicializar(ContentManager content,Personagem P1, Botoes Botao,  Inimigo i1, Agua DefineAgua) // carregar imagens quando a fase começa (não no começo)
        {
            Info.I.img = content.Load<Texture2D>("Info");

            VENTO.V.Vento = content.Load<Texture2D>("Vento Spritesheet");
            RAIO.r.Raio = content.Load<Texture2D>("Raio Spritesheet");
            ESCUDO.e.img = content.Load<Texture2D>("Escudo Poder");

            Audio.A1.imgbarra = content.Load<Texture2D>("volume barra");
            Audio.A1.imgpino = content.Load<Texture2D>("volumeB");
            Audio.A1.imgVol1 = content.Load<Texture2D>("volume-");
            Audio.A1.imgVol2 = content.Load<Texture2D>("volume+");

                //Direito
            P1.imgSpriteSheetparado1 = content.Load<Texture2D>("spritesheet p1 parado1"); // só imagem, logo posso usar isso também pros inimigos.
            P1.imgSpriteSheetparado2 = content.Load<Texture2D>("spritesheet p1 parado2");
            P1.imgSpriteSheetandando = content.Load<Texture2D>("spritesheet p1 andando");
            P1.imgSpriteSheetATIRARarco = content.Load<Texture2D>("spritesheet p1 atirar (arco)");
            P1.imgSpriteSheetSACARarco = content.Load<Texture2D>("spritesheet p1 sacar arco");
            P1.imgSpriteSheetagachar1 = content.Load<Texture2D>("spritesheet p1 agachar1");
            P1.imgSpriteSheetagachar2 = content.Load<Texture2D>("spritesheet p1 agachar2");
            P1.imgSpriteSheetcorrendo = content.Load<Texture2D>("spritesheet p1 correndo");
            P1.imgSpriteSheetdefesa1 = content.Load<Texture2D>("spritesheet p1 defesa1");
            P1.imgSpriteSheetagachadoHIT = content.Load<Texture2D>("spritesheet p1 agachar hit");
            P1.imgSpriteSheetpular = content.Load<Texture2D>("spritesheet p1 pular1");
            P1.imgsoco1 = content.Load<Texture2D>("p1 - soco1");
            P1.imgsoco2C1 = content.Load<Texture2D>("p1 - soco2 combo1");
            P1.imgsoco3C1 = content.Load<Texture2D>("p1 - soco3 combo1");
            P1.imgjoelhada4C1 = content.Load<Texture2D>("p1 - joelhada4 combo1");

            //ESQUERDO
            P1.imgSpriteSheetparado1E = content.Load<Texture2D>("spritesheet p1 parado1 ESQUERDA"); // (E)
            P1.imgSpriteSheetandandoE = content.Load<Texture2D>("spritesheet p1 andando ESQUERDA");
            P1.imgSpriteSheetcorrendoE = content.Load<Texture2D>("spritesheet p1 correndo ESQUERDA");
            P1.imgSpriteSheetpularE = content.Load<Texture2D>("spritesheet p1 pular1 ESQUERDA");
            P1.imgSpriteSheetparado2E = content.Load<Texture2D>("spritesheet p1 parado2 ESQUERDA");
            P1.imgsoco1E = content.Load<Texture2D>("p1 - soco1 E");
            P1.imgsoco2C1E = content.Load<Texture2D>("p1 - soco2 combo1 E");
            P1.imgsoco3C1E = content.Load<Texture2D>("p1 - soco3 combo1 E");
            P1.imgjoelhada4C1E = content.Load<Texture2D>("p1 - joelhada4 combo1 E");

            Fundo.menu00fundo = content.Load<Texture2D>("menu1");
            Fundo.imgfase1 = content.Load<Texture2D>("fase de luta");
            Fundo.imgfundopoder = content.Load<Texture2D>("fundo poder");

            Menu.m.imgcampanha1 = content.Load<Texture2D>("campanha");
            Menu.m.imgcampanha2 = content.Load<Texture2D>("campanha2");
            Menu.m.imgcampanha3 = content.Load<Texture2D>("campanha3");

            Menu.m.imgcombates1 = content.Load<Texture2D>("combates1");
            Menu.m.imgcombates2 = content.Load<Texture2D>("combates2");
            Menu.m.imgcombates3 = content.Load<Texture2D>("combates3");

            Menu.m.imgsair1 = content.Load<Texture2D>("sair1");
            Menu.m.imgsair2 = content.Load<Texture2D>("sair2");
            Menu.m.imgsair3 = content.Load<Texture2D>("sair3");

            Menu.m.imgsalvar1 = content.Load<Texture2D>("salvar1");
            Menu.m.imgsalvar2 = content.Load<Texture2D>("salvar2");
            Menu.m.imgsalvar3 = content.Load<Texture2D>("salvar3");

            Menu.m.imgopçoes1 = content.Load<Texture2D>("opçoes1");
            Menu.m.imgopçoes2 = content.Load<Texture2D>("opçoes2");
            Menu.m.imgopçoes3 = content.Load<Texture2D>("opçoes3");

            Menu.m.imgcarregar1 = content.Load<Texture2D>("carregar");
            Menu.m.imgcarregar2 = content.Load<Texture2D>("carregar2");
            Menu.m.imgcarregar3 = content.Load<Texture2D>("carregar3");

            //itens ALL
            ItensAll.a.imgespada2H = content.Load<Texture2D>("Espada 2H");
            ItensAll.a.imgmaos = content.Load<Texture2D>("Mãos");
            ItensAll.a.prop1 = content.Load<Texture2D>("Propriedade 1");
            ItensAll.a.prop2 = content.Load<Texture2D>("Propriedade 2");
            ItensAll.a.prop3 = content.Load<Texture2D>("Propriedade 3");
            ItensAll.a.prop4 = content.Load<Texture2D>("Propriedade 4");
            ItensAll.a.imgadaga = content.Load<Texture2D>("Adagas");
            ItensAll.a.imgarco = content.Load<Texture2D>("Arco");
            ItensAll.a.imgtridente = content.Load<Texture2D>("Tridente");
            ItensAll.a.imgslow = content.Load<Texture2D>("Slow");
            ItensAll.a.imgretroceder = content.Load<Texture2D>("Retroceder");
            ItensAll.a.imgescudo = content.Load<Texture2D>("Escudo");
            ItensAll.a.imgvento = content.Load<Texture2D>("Vento");
            ItensAll.a.imgraio = content.Load<Texture2D>("Raio");
            ItensAll.a.imgEQUIPAR1 = content.Load<Texture2D>("equipar1");
            ItensAll.a.imgEQUIPAR2 = content.Load<Texture2D>("equipar2");
            ItensAll.a.imgCOMPRAR = content.Load<Texture2D>("comprar");

            Menu.m.imgintromenu_comtraçado = content.Load<Texture2D>("intro game");
            Menu.m.imgintromenu_semtraçado = content.Load<Texture2D>("intro game sem traçado");
            //M1.imgpredio_do_P1 = content.Load<Texture2D>("predio");
            
            Audio.A1.menusong = content.Load<Song>("Menu song");
            Audio.A1.combatesong = content.Load<Song>("Combate song");
            Audio.A1.PODERsong = content.Load<Song>("coração LENTO");
            Audio.A1.COINCOLLECT = content.Load<SoundEffect>("COINS Collect");
            Audio.A1.PLACAREFFECT = content.Load<SoundEffect>("SUCCESS CHIME");
            Audio.A1.RISADA = content.Load<SoundEffect>("Male Chuckling");
            Audio.A1.SUPERCHORO = content.Load<SoundEffect>("Male Dramatic Crying");
            Audio.A1.GRITOVENCEDOR = content.Load<SoundEffect>("Grito de vencedor");
            Audio.A1.pop = content.Load<SoundEffect>("POP Echo");
            Audio.A1.LEITEganho = content.Load<SoundEffect>("SPLAT Crush 01");
            Audio.A1.EscudoSom = content.Load<SoundEffect>("escudo Audio");

            //botoes statics
            Botao.imgcomercioOFF = content.Load<Texture2D>("comercioOFF");
            Botao.imgcomercioOFFTP = content.Load<Texture2D>("comercioOFFTP");
            Botao.imgcomercioON = content.Load<Texture2D>("comercioON");
            Botao.imghomeOFF = content.Load<Texture2D>("homeOFF");
            Botao.imghomeOFFTP = content.Load<Texture2D>("homeOFFTP");
            Botao.imghomeON = content.Load<Texture2D>("homeON");
            Botao.imgcombosOFF = content.Load<Texture2D>("COMBOS OFF");
            Botao.imgcombosOFFTP = content.Load<Texture2D>("COMBOS OFFTP");
            Botao.imgcombosON = content.Load<Texture2D>("COMBOS ON");

            
            // inimigo 1
            i1.imgAndarDi1 = content.Load<Texture2D>("i1 - andar DIREITA");
            i1.imgAndarEi1 = content.Load<Texture2D>("i1 - andar");
            i1.imgParadoi1 = content.Load<Texture2D>("i1 - parado");
            //D
            i1.imgDEFDi1 = content.Load<Texture2D>("i1 - defesaD");
            i1.imgFacaDi1 = content.Load<Texture2D>("FacaD");
            i1.imgAgacharDi1 = content.Load<Texture2D>("i1 - agacharD");
            i1.imgAgacharDEFDi1 = content.Load<Texture2D>("i1 - agachar defendendoD");
            i1.imgCaidoDi1 = content.Load<Texture2D>("i1 - caidoD");
            i1.imgJogarFacaDi1 = content.Load<Texture2D>("i1 - jogando facaD");
            i1.imgHit1Di1 = content.Load<Texture2D>("i1 - hit1D");
            i1.imgHit2Di1 = content.Load<Texture2D>("i1 - hit2D");
            i1.imgHit3Di1 = content.Load<Texture2D>("i1 - hit3D");
            i1.imgLevantarDi1 = content.Load<Texture2D>("i1 - levantarD");
            i1.imgATK1Di1 = content.Load<Texture2D>("i1 - ataque1D");
            i1.imgAgarrarDi1 = content.Load<Texture2D>("i1 - agarrarD");
            i1.imgRasteiraDi1 = content.Load<Texture2D>("i1 - rasteiraD");
            i1.imgPODERDi1 = content.Load<Texture2D>("i1 - poderD");
            i1.imgMORTEDi1 = content.Load<Texture2D>("i1 - morteD");
            //E
            i1.imgDEFEi1 = content.Load<Texture2D>("i1 - defesa");
            i1.imgFacaEi1 = content.Load<Texture2D>("FacaE");
            i1.imgAgacharEi1 = content.Load<Texture2D>("i1 - agachar");
            i1.imgAgacharDEFEi1 = content.Load<Texture2D>("i1 - agachar defendendo");
            i1.imgCaidoEi1 = content.Load<Texture2D>("i1 - caido");
            i1.imgJogarFacaEi1 = content.Load<Texture2D>("i1 - jogando faca");
            i1.imgHit1Ei1 = content.Load<Texture2D>("i1 - hit1");
            i1.imgHit2Ei1 = content.Load<Texture2D>("i1 - hit2");
            i1.imgHit3Ei1 = content.Load<Texture2D>("i1 - hit3");
            i1.imgLevantarEi1 = content.Load<Texture2D>("i1 - levantar");
            i1.imgATK1Ei1 = content.Load<Texture2D>("i1 - ataque1");
            i1.imgAgarrarEi1 = content.Load<Texture2D>("i1 - agarrar");
            i1.imgRasteiraEi1 = content.Load<Texture2D>("i1 - rasteira");
            i1.imgPODEREi1 = content.Load<Texture2D>("i1 - poder");
            i1.imgMORTEi1 = content.Load<Texture2D>("i1 - morte");

            

            P1.imgBARRA = content.Load<Texture2D>("BARRA");
            P1.imgSOBRE = content.Load<Texture2D>("SOBRE");
            P1.imgVIDA = content.Load<Texture2D>("VIDA");
            P1.imgVIDA2 = content.Load<Texture2D>("VIDA2");
            P1.imgENERGIA = content.Load<Texture2D>("ENERGIA");
            P1.imgMANA = content.Load<Texture2D>("MANA");
            P1.imgXP = content.Load<Texture2D>("xp");
            P1.imgXPT = content.Load<Texture2D>("xptotal");
            P1.imgpino = content.Load<Texture2D>("pino");

            DefineAgua.imgAgua = content.Load<Texture2D>("agua");
            DefineAgua.imgOndas = content.Load<Texture2D>("SSH");

            //JANELA SPRITES
            JANELA.J.imgbotaoArmasOFF = content.Load<Texture2D>("botao armas OFF");
            JANELA.J.imgbotaoArmasON = content.Load<Texture2D>("botao armas ON");
            JANELA.J.imgbotaoCombosOFF = content.Load<Texture2D>("botao combos OFF");
            JANELA.J.imgbotaoCombosON = content.Load<Texture2D>("botao combos ON");
            JANELA.J.imgbotaoComercioOFF = content.Load<Texture2D>("botao comercio OFF");
            JANELA.J.imgbotaoComercioON = content.Load<Texture2D>("botao comercio ON");
            JANELA.J.imgbotaoPetOFF = content.Load<Texture2D>("botao pet OFF");
            JANELA.J.imgbotaoPetON = content.Load<Texture2D>("botao pet ON");
            JANELA.J.imgbotaoPoderesOFF = content.Load<Texture2D>("botao poderes OFF");
            JANELA.J.imgbotaoPoderesON = content.Load<Texture2D>("botao poderes ON");
            JANELA.J.imgbotaoX = content.Load<Texture2D>("bX");
            JANELA.J.imgbotaoXred = content.Load<Texture2D>("bX red");
            JANELA.J.imgjanelacinzaopç1 = content.Load<Texture2D>("janela cinza (opç1)");
            JANELA.J.imgjanelacombo = content.Load<Texture2D>("janela combo");
            JANELA.J.imgjanelacomercio = content.Load<Texture2D>("janela comercio");
            //new
            JANELA.J.imgrolo = content.Load<Texture2D>("rolo");
            JANELA.J.imgjanelarolo = content.Load<Texture2D>("janela rolo");
            JANELA.J.imgsetabaixo = content.Load<Texture2D>("seta baixo");
            JANELA.J.imgsetacima = content.Load<Texture2D>("seta cima");
            JANELA.J.imgjanelaall = content.Load<Texture2D>("janela all");
            JANELA.J.imgadaga1 = content.Load<Texture2D>("item adaga 1");
            JANELA.J.imgadaga2 = content.Load<Texture2D>("item adaga 2");
            JANELA.J.imgadaga3 = content.Load<Texture2D>("item adaga 3");
            JANELA.J.imgespada2H1 = content.Load<Texture2D>("item espada 2H 1");
            JANELA.J.imgespada2H2 = content.Load<Texture2D>("item espada 2H 2");
            JANELA.J.imgespada2H3 = content.Load<Texture2D>("item espada 2H 3");
            JANELA.J.imgmao1 = content.Load<Texture2D>("item maos 1");
            JANELA.J.imgmao2 = content.Load<Texture2D>("item maos 2");

            JANELA.J.imgItemarco1 = content.Load<Texture2D>("item arco 1");
            JANELA.J.imgItemarco2 = content.Load<Texture2D>("item arco 2");
            JANELA.J.imgItemarco3 = content.Load<Texture2D>("item arco 3");
            JANELA.J.imgItemtridente1 = content.Load<Texture2D>("item tridente 1");
            JANELA.J.imgItemtridente2 = content.Load<Texture2D>("item tridente 2");
            JANELA.J.imgItemtridente3 = content.Load<Texture2D>("item tridente 3");
            JANELA.J.imgItemslow1 = content.Load<Texture2D>("item slow 1");
            JANELA.J.imgItemslow2 = content.Load<Texture2D>("item slow 2");
            JANELA.J.imgItemretroceder1 = content.Load<Texture2D>("item retroceder 1");
            JANELA.J.imgItemretroceder2 = content.Load<Texture2D>("item retroceder 2");
            JANELA.J.imgItemretroceder3 = content.Load<Texture2D>("item retroceder 3");
            JANELA.J.imgItemescudo1 = content.Load<Texture2D>("item escudo 1");
            JANELA.J.imgItemescudo2 = content.Load<Texture2D>("item escudo 2");
            JANELA.J.imgItemescudo3 = content.Load<Texture2D>("item escudo 3");
            JANELA.J.imgItemvento1 = content.Load<Texture2D>("item vento 1");
            JANELA.J.imgItemvento2 = content.Load<Texture2D>("item vento 2");
            JANELA.J.imgItemvento3 = content.Load<Texture2D>("item vento 3");
            JANELA.J.imgItemraio1 = content.Load<Texture2D>("item raio 1");
            JANELA.J.imgItemraio2 = content.Load<Texture2D>("item raio 2");
            JANELA.J.imgItemraio3 = content.Load<Texture2D>("item raio 3");


            //resume
            JANELA.J.imgpauseJANELA = content.Load<Texture2D>("janela PAUSE x MENU");

            JANELA.J.imgBsair1 = content.Load<Texture2D>("botao sair 1");

            JANELA.J.imgBsair2 = content.Load<Texture2D>("botao sair 2");

            JANELA.J.imgBsair3 = content.Load<Texture2D>("botao sair 3");

            JANELA.J.imgBresume1 = content.Load<Texture2D>("botao resume 1");

            JANELA.J.imgBresume2 = content.Load<Texture2D>("botao resume 2");

            JANELA.J.imgBresume3 = content.Load<Texture2D>("botao resume 3");

            JANELA.J.imgFUNDOmenu = content.Load<Texture2D>("menu capa");

            //opç fase

            JANELA.J.imgPbranco = content.Load<Texture2D>("ponto branco");
            JANELA.J.imgfaseB[0] = content.Load<Texture2D>("fase B1");
            JANELA.J.imgfaseB[1] = content.Load<Texture2D>("fase B1");

            //quests
            JANELA.J.imgQuest = content.Load<Texture2D>("Q S");
            JANELA.J.imgRefresh1 = content.Load<Texture2D>("refresh 1");
            JANELA.J.imgRefresh2 = content.Load<Texture2D>("refresh 2");
            JANELA.J.imgOK1 = content.Load<Texture2D>("OK 1");
            JANELA.J.imgOK2 = content.Load<Texture2D>("OK 2");
            JANELA.J.imgOK3 = content.Load<Texture2D>("OK 3");

            //placar
            JANELA.J.imgPlacar = content.Load<Texture2D>("Placar");


            //spritefonte
            JANELA.J.Neon15 = content.Load<SpriteFont>("Neon15");
            JANELA.J.Neon = content.Load<SpriteFont>("Neon");
            JANELA.J.Firefont = content.Load<SpriteFont>("FIRESTARTER");
            JANELA.J.Woodfont = content.Load<SpriteFont>("Woodfont");

            //visual do poder lançado
            Poder_Visual.p.imgcirculo = content.Load<Texture2D>("poder");

            //combo
            COMBO.c.img = content.Load<Texture2D>("HITSface");
        }
    }
}
