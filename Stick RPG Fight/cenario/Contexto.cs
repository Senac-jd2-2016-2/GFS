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
        public static bool[] Fase = new bool[10]; // Quantas fases

        public static void inicializar(ContentManager content,Personagem P1, Botoes Botao,  Inimigo i1, Agua DefineAgua) // carregar imagens quando a fase começa (não no começo)
        {
            Info.I.img = content.Load<Texture2D>("Info");

            VENTO.V.VentoD = content.Load<Texture2D>("Vento Spritesheet D");
            VENTO.V.VentoE = content.Load<Texture2D>("Vento Spritesheet E");
            RAIO.r.Raio = content.Load<Texture2D>("Raio Spritesheet");
            ESCUDO.e.img = content.Load<Texture2D>("Escudo Poder");

            Audio.A1.imgbarra = content.Load<Texture2D>("volume barra");
            Audio.A1.imgpino = content.Load<Texture2D>("volumeB");
            Audio.A1.imgVol1 = content.Load<Texture2D>("volume-");
            Audio.A1.imgVol2 = content.Load<Texture2D>("volume+");

                //                                                                                      Direito
            //MAO
            P1.imgparado1maosD = content.Load<Texture2D>("spritesheet p1 parado1"); // só imagem, logo posso usar isso também pros inimigos.
            P1.imgparado2maosD = content.Load<Texture2D>("spritesheet p1 parado2");
            P1.imgandandomaosD = content.Load<Texture2D>("spritesheet p1 andando");
            P1.imgATIRARarcoD = content.Load<Texture2D>("spritesheet p1 atirar (arco)");
            P1.imgSacarArcoD = content.Load<Texture2D>("spritesheet p1 sacar arco");
            
            P1.imgagacharmaosD = content.Load<Texture2D>("spritesheet p1 agachar2");
            P1.imgcorrendomaosD = content.Load<Texture2D>("spritesheet p1 correndo");
            P1.imgdefesamaosD = content.Load<Texture2D>("spritesheet p1 defesa1");
            P1.imgagachadoHITmaosD = content.Load<Texture2D>("spritesheet p1 agachar hit");
            P1.imgpularmaos = content.Load<Texture2D>("spritesheet p1 pular1");
            P1.imgsoco1maos = content.Load<Texture2D>("p1 - soco1");
            P1.imgsoco2C1maos = content.Load<Texture2D>("p1 - soco2 combo1");
            P1.imgsoco3C1maos = content.Load<Texture2D>("p1 - soco3 combo1");
            P1.imgjoelhada4C1Maos = content.Load<Texture2D>("p1 - joelhada4 combo1");
            //
            P1.imgHIT1maosD = content.Load<Texture2D>("spritesheet p1 hit1");
            P1.imgHIT2maosD = content.Load<Texture2D>("spritesheet p1 hit2");
            P1.imgdefesamaosD = content.Load<Texture2D>("spritesheet p1 defesa1");

            //ARMAS
            //adaga
            
            P1.imgParadoAdagaD = content.Load<Texture2D>("spritesheet p1 parado (adaga)");

            P1.imgPulandoAdagaD = content.Load<Texture2D>("spritesheet p1 pulando (adaga)");

            P1.imgSacarAdagaD = content.Load<Texture2D>("spritesheet p1 sacar (adaga)");

            P1.imgCorrendoAdagaD = content.Load<Texture2D>("spritesheet p1 correndo (adaga)");

            P1.imgDefendendoAdagaD = content.Load<Texture2D>("spritesheet p1 defendendo (adaga)");

            P1.imgHit1AdagaD = content.Load<Texture2D>("spritesheet p1 hit1 (adaga)");

            P1.imgHit2AdagaD = content.Load<Texture2D>("spritesheet p1 hit2 (adaga)");

            P1.imgCombo1_1AdagaD = content.Load<Texture2D>("spritesheet p1 combo1 - 1 (adaga)");

            P1.imgCombo1_2AdagaD = content.Load<Texture2D>("spritesheet p1 combo1 - 2 (adaga)");

            P1.imgCombo1_3AdagaD = content.Load<Texture2D>("spritesheet p1 combo1 - 3 (adaga)");

            P1.imgCombo1_4AdagaD = content.Load<Texture2D>("spritesheet p1 combo1 - 4 (adaga)");


            //arco
            P1.imgParadoArcoD = content.Load<Texture2D>("spritesheet p1 parado (arco)");

            P1.imgPulandoArcoD = content.Load<Texture2D>("spritesheet p1 pular (arco)");

            P1.imgSacarArcoD = content.Load<Texture2D>("spritesheet p1 sacar (arco)");

            P1.imgCorrendoArcoD = content.Load<Texture2D>("spritesheet p1 correndo (arco)");

            P1.imgHit1ArcoD = content.Load<Texture2D>("spritesheet p1 hit1 (arco)");

            P1.imgHit2ArcoD = content.Load<Texture2D>("spritesheet p1 hit2 (arco)");

            P1.imgATIRARarcoD = content.Load<Texture2D>("spritesheet p1 atirar (arco)");

            P1.imgFlechaD = content.Load<Texture2D>("Flecha E");

            
            //espada 2H
            P1.imgParadoEspada2mD = content.Load<Texture2D>("spritesheet p1 parado (espada2M)");

            P1.imgSacarEspada2mD = content.Load<Texture2D>("spritesheet p1 sacar (espada2M)");

            P1.imgCorrerEspada2mD = content.Load<Texture2D>("spritesheet p1 correr (espada2M)");

            P1.imgDefenderEspada2mD = content.Load<Texture2D>("spritesheet p1 defender (espada2M)");

            P1.imgHit1Espada2mD = content.Load<Texture2D>("spritesheet p1 hit1 (espada2M)");

            P1.imgHit2Espada2mD = content.Load<Texture2D>("spritesheet p1 hit2 (espada2M)");

            P1.imgCombo1_1Espada2mD = content.Load<Texture2D>("spritesheet p1 combo1 - 1 (espada2M)");

            P1.imgCombo1_2Espada2mD = content.Load<Texture2D>("spritesheet p1 combo1 - 2 (espada2M)");

            P1.imgCombo1_3Espada2mD = content.Load<Texture2D>("spritesheet p1 combo1 - 3 (espada2M)");

            P1.imgCombo1_4Espada2mD = content.Load<Texture2D>("spritesheet p1 combo1 - 4 (espada2M)");


            //tridente
            P1.imgParadoTridenteD = content.Load<Texture2D>("spritesheet p1 parado (tridente)");

            P1.imgCombo2_1TridenteD = content.Load<Texture2D>("spritesheet p1 combo2 - 1 (tridente)");

            P1.imgCorrerTridenteD = content.Load<Texture2D>("spritesheet p1 correndo (tridente)");

            P1.imgDefenderTridenteD = content.Load<Texture2D>("spritesheet p1 defendendo (tridente)");

            P1.imgPularTridenteD = content.Load<Texture2D>("spritesheet p1 pulando (tridente)");

            P1.imgHit1TridenteD = content.Load<Texture2D>("spritesheet p1 hit1 (tridente)");

            P1.imgHit2TridenteD = content.Load<Texture2D>("spritesheet p1 hit2 (tridente)");

            P1.imgSacarTridenteD = content.Load<Texture2D>("spritesheet p1 sacar (tridente)");

            P1.imgCombo1_1TridenteD = content.Load<Texture2D>("spritesheet p1 combo1 - 1 (tridente)");

            P1.imgCombo1_2TridenteD = content.Load<Texture2D>("spritesheet p1 combo1 - 2 (tridente)");

            P1.imgCombo1_3TridenteD = content.Load<Texture2D>("spritesheet p1 combo1 - 3 (tridente)");

            P1.imgCombo1_4TridenteD = content.Load<Texture2D>("spritesheet p1 combo1 - 4 (tridente)");
            


            //                                                                                                  ESQUERDO
            //MAO
            P1.imgparado1maosE = content.Load<Texture2D>("spritesheet p1 parado1 E"); // (E)
            P1.imgandandomaosE = content.Load<Texture2D>("spritesheet p1 andando E");
            P1.imgcorrendomaosE = content.Load<Texture2D>("spritesheet p1 correndo E");
            P1.imgpularmaosE = content.Load<Texture2D>("spritesheet p1 pular1 E");
            P1.imgparado2maosE = content.Load<Texture2D>("spritesheet p1 parado2 E");
            P1.imgsoco1maosE = content.Load<Texture2D>("p1 - soco1 E");
            P1.imgsoco2C1maosE = content.Load<Texture2D>("p1 - soco2 combo1 E");
            P1.imgsoco3C1maosE = content.Load<Texture2D>("p1 - soco3 combo1 E");
            P1.imgjoelhada4C1maosE = content.Load<Texture2D>("p1 - joelhada4 combo1 E");
            P1.imgagachadoHITmaosE = content.Load<Texture2D>("spritesheet p1 agachar hit E");
            //
            P1.imgHIT1maosE = content.Load<Texture2D>("spritesheet p1 hit1 E");
            P1.imgHIT2maosE = content.Load<Texture2D>("spritesheet p1 hit2 E");
            P1.imgdefesamaosE = content.Load<Texture2D>("spritesheet p1 defesa1 E");

           
            //ARMAS
            //adaga
            
            P1.imgParadoAdagaE = content.Load<Texture2D>("spritesheet p1 parado (adaga) E");
              
            P1.imgPulandoAdagaE = content.Load<Texture2D>("spritesheet p1 pulando (adaga) E");
              
            P1.imgSacarAdagaE = content.Load<Texture2D>("spritesheet p1 sacar (adaga) E");
              
            P1.imgCorrendoAdagaE = content.Load<Texture2D>("spritesheet p1 correndo (adaga) E");
              
            P1.imgDefendendoAdagaE = content.Load<Texture2D>("spritesheet p1 defendendo (adaga) E");
              
            P1.imgHit1AdagaE = content.Load<Texture2D>("spritesheet p1 hit1 (adaga) E");
              
            P1.imgHit2AdagaE = content.Load<Texture2D>("spritesheet p1 hit2 (adaga) E");
              
            P1.imgCombo1_1AdagaE = content.Load<Texture2D>("spritesheet p1 combo1 - 1 (adaga) E");
              
            P1.imgCombo1_2AdagaE = content.Load<Texture2D>("spritesheet p1 combo1 - 2 (adaga) E");
              
            P1.imgCombo1_3AdagaE = content.Load<Texture2D>("spritesheet p1 combo1 - 3 (adaga) E");
              
            P1.imgCombo1_4AdagaE = content.Load<Texture2D>("spritesheet p1 combo1 - 4 (adaga) E");

              
            //arco
            P1.imgParadoArcoE = content.Load<Texture2D>("spritesheet p1 parado (arco) E");
              
            P1.imgPulandoArcoE = content.Load<Texture2D>("spritesheet p1 pular (arco) E");
              
            P1.imgSacarArcoE = content.Load<Texture2D>("spritesheet p1 sacar (arco) E");
             
            P1.imgCorrendoArcoE = content.Load<Texture2D>("spritesheet p1 correndo (arco) E");
              
            P1.imgHit1ArcoE = content.Load<Texture2D>("spritesheet p1 hit1 (arco) E");
              
            P1.imgHit2ArcoE = content.Load<Texture2D>("spritesheet p1 hit2 (arco) E");
              
            P1.imgATIRARarcoE = content.Load<Texture2D>("spritesheet p1 atirar (arco) E");
              
            P1.imgFlechaE = content.Load<Texture2D>("Flecha E");
              
            
              
           //espada 2H
           P1.imgParadoEspada2mE = content.Load<Texture2D>("spritesheet p1 parado (espada2M) E");
             
           P1.imgSacarEspada2mE = content.Load<Texture2D>("spritesheet p1 sacar (espada2M) E");
              
           P1.imgCorrerEspada2mE = content.Load<Texture2D>("spritesheet p1 correr (espada2M) E");
              
           P1.imgDefenderEspada2mE = content.Load<Texture2D>("spritesheet p1 defender (espada2M) E");
              
           P1.imgHit1Espada2mE = content.Load<Texture2D>("spritesheet p1 hit1 (espada2M) E");
              
           P1.imgHit2Espada2mE = content.Load<Texture2D>("spritesheet p1 hit2 (espada2M) E");
             
           P1.imgCombo1_1Espada2mE = content.Load<Texture2D>("spritesheet p1 combo1 - 1 (espada2M) E");
             
           P1.imgCombo1_2Espada2mE = content.Load<Texture2D>("spritesheet p1 combo1 - 2 (espada2M) E");
              
           P1.imgCombo1_3Espada2mE = content.Load<Texture2D>("spritesheet p1 combo1 - 3 (espada2M) E");

           P1.imgCombo1_4Espada2mE = content.Load<Texture2D>("spritesheet p1 combo1 - 4 (espada2M) E");

           //tridente
           P1.imgParadoTridenteE = content.Load<Texture2D>("spritesheet p1 parado (tridente) E");

           P1.imgCombo2_1TridenteE = content.Load<Texture2D>("spritesheet p1 combo2 - 1 (tridente) E");

           P1.imgCorrerTridenteE = content.Load<Texture2D>("spritesheet p1 correndo (tridente) E");

           P1.imgDefenderTridenteE = content.Load<Texture2D>("spritesheet p1 defendendo (tridente) E");

           P1.imgPularTridenteE = content.Load<Texture2D>("spritesheet p1 pulando (tridente) E");

           P1.imgHit1TridenteE = content.Load<Texture2D>("spritesheet p1 hit1 (tridente) E");

           P1.imgHit2TridenteE = content.Load<Texture2D>("spritesheet p1 hit2 (tridente) E");

           P1.imgSacarTridenteE = content.Load<Texture2D>("spritesheet p1 sacar (tridente) E");

           P1.imgCombo1_1TridenteE = content.Load<Texture2D>("spritesheet p1 combo1 - 1 (tridente) E");

           P1.imgCombo1_2TridenteE = content.Load<Texture2D>("spritesheet p1 combo1 - 2 (tridente) E");

           P1.imgCombo1_3TridenteE = content.Load<Texture2D>("spritesheet p1 combo1 - 3 (tridente) E");

           P1.imgCombo1_4TridenteE = content.Load<Texture2D>("spritesheet p1 combo1 - 4 (tridente) E");
           

















            Fundo.menu00fundo = content.Load<Texture2D>("menu1");
            Fundo.imgfase[0] = content.Load<Texture2D>("fase 1");
            Fundo.imgfase[1] = content.Load<Texture2D>("fase 2");
            Fundo.imgfase[2] = content.Load<Texture2D>("fase 3");
            Fundo.imgfase[3] = content.Load<Texture2D>("fase 4");
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
            JANELA.J.imgCapaMapas = content.Load<Texture2D>("Capa menu mapas");
            JANELA.J.imgsetamenu1 = content.Load<Texture2D>("setamenu1");
            JANELA.J.imgsetamenu2 = content.Load<Texture2D>("setamenu2");
            JANELA.J.imgsetamenu3 = content.Load<Texture2D>("setamenu3");
            JANELA.J.imgsetamenu4 = content.Load<Texture2D>("setamenu4");
            JANELA.J.imgclickmenucompra = content.Load<Texture2D>("clickmenucompra");
            JANELA.J.imgcompramenu1 = content.Load<Texture2D>("comprarmenu1");
            JANELA.J.imgcompramenu2 = content.Load<Texture2D>("comprarmenu2");
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
            JANELA.J.imgfaseB[1] = content.Load<Texture2D>("fase B2");
            JANELA.J.imgfaseB[2] = content.Load<Texture2D>("fase B3");
            JANELA.J.imgfaseB[3] = content.Load<Texture2D>("fase B4");
            for (int i = 4; i < JANELA.J.imgfaseB.Length; i++ )
            {
                JANELA.J.imgfaseB[i] = content.Load<Texture2D>("fase B1");
            }

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
