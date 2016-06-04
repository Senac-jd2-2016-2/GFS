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
    class Personagem
    {
        //      img (ARQUIVO)
        public Texture2D imgBARRA;
        public Texture2D imgVIDA;
        public Texture2D imgVIDA2;
        public Texture2D imgENERGIA;
        public Texture2D imgMANA;
        public Texture2D imgSOBRE;
        public Texture2D imgXP;
        public Texture2D imgXPT;
        public Texture2D imgpino;

        public Rectangle BarraVida = new Rectangle();
        public Rectangle BarraEnergia = new Rectangle();
        public Rectangle BarraMana = new Rectangle();
        public Rectangle Barra = new Rectangle();
        public Rectangle XPTrec = new Rectangle();
        public Rectangle XPrec = new Rectangle();
        public Rectangle Pino = new Rectangle();

        //                                                                                                  IMAGENS

        //                                                                                                 ESQUERDA
        public Texture2D imgparado1maosE; // parado fora de combate (E)
        public Texture2D imgandandomaosE;// andando (E)
        public Texture2D imgcorrendomaosE;//correndo (E)
        public Texture2D imgpularmaosE; //Pular (E)
        public Texture2D imgparado2maosE; // em combate (E)
        public Texture2D imgHIT1maosE, imgHIT2maosE;//tomando hit em pé (D) 
        public Texture2D imgdefesamaosE; //defesa em PE (D)
        public Texture2D imgagachadoHITmaosE; //tomando hit agachado (D)

        public Texture2D imgsoco1maosE; //soco esquerdo 1 (E)
        public Texture2D imgsoco2C1maosE; // soco direito 2 - combo 1 (E)
        public Texture2D imgsoco3C1maosE; // girada direito 3 - combo 1 (E)
        public Texture2D imgjoelhada4C1maosE; // joelhada esquerda 4 - combo 1 (E)

        //ARMAS
        //Adaga
        public Texture2D imgParadoAdagaE, imgPulandoAdagaE, imgSacarAdagaE, imgCorrendoAdagaE, imgDefendendoAdagaE, imgHit1AdagaE, imgHit2AdagaE, imgCombo1_1AdagaE, imgCombo1_2AdagaE, imgCombo1_3AdagaE, imgCombo1_4AdagaE;
        //ARCO
        public Texture2D imgParadoArcoE, imgPulandoArcoE, imgSacarArcoE, imgCorrendoArcoE, imgHit1ArcoE, imgHit2ArcoE, imgATIRARarcoE, imgFlechaE;
        //ESPADA 2H
        public Texture2D imgParadoEspada2mE, imgCorrerEspada2mE, imgDefenderEspada2mE, imgHit1Espada2mE, imgHit2Espada2mE, imgSacarEspada2mE, imgCombo1_1Espada2mE, imgCombo1_2Espada2mE, imgCombo1_3Espada2mE, imgCombo1_4Espada2mE;
        //TRIDENTE
        public Texture2D imgParadoTridenteE, imgCombo2_1TridenteE, imgCorrerTridenteE, imgDefenderTridenteE, imgPularTridenteE, imgHit1TridenteE, imgHit2TridenteE, imgSacarTridenteE, imgCombo1_1TridenteE, imgCombo1_2TridenteE, imgCombo1_3TridenteE, imgCombo1_4TridenteE;

        //                                                                                               /DIREITA
        public Texture2D imgparado1maosD; // parado fora de combate (D)
        public Texture2D imgparado2maosD; // em combate (D)
        public Texture2D imgagacharmaosD;//em combate (D)
        public Texture2D imgandandomaosD;// andando (D)
        public Texture2D imgcorrendomaosD;//correndo (D)
        public Texture2D imgdefesamaosD; //defesa em PE (D)
        public Texture2D imgagachadoHITmaosD; //tomando hit agachado (D)
        public Texture2D imgHIT1maosD, imgHIT2maosD;//tomando hit em pé (D) 
        
        public Texture2D imgpularmaos; //Pular (D)
        public Texture2D imgsoco1maos; //soco esquerdo 1
        public Texture2D imgsoco2C1maos; // soco direito 2 - combo 1 (D)
        public Texture2D imgsoco3C1maos; // girada direito 3 - combo 1 (D)
        public Texture2D imgjoelhada4C1Maos; // joelhada esquerda 4 - combo 1 (D)

        //ARMAS
        //ARMAS
        //Adaga
        public Texture2D imgParadoAdagaD, imgPulandoAdagaD, imgSacarAdagaD, imgCorrendoAdagaD, imgDefendendoAdagaD, imgHit1AdagaD, imgHit2AdagaD, imgCombo1_1AdagaD, imgCombo1_2AdagaD, imgCombo1_3AdagaD, imgCombo1_4AdagaD; 
        //ARCO
        public Texture2D imgParadoArcoD, imgPulandoArcoD, imgSacarArcoD, imgCorrendoArcoD, imgHit1ArcoD, imgHit2ArcoD, imgATIRARarcoD, imgFlechaD; 
        //ESPADA 2H
        public Texture2D imgParadoEspada2mD, imgCorrerEspada2mD, imgDefenderEspada2mD, imgHit1Espada2mD, imgHit2Espada2mD, imgSacarEspada2mD, imgCombo1_1Espada2mD, imgCombo1_2Espada2mD, imgCombo1_3Espada2mD, imgCombo1_4Espada2mD;
        //TRIDENTE
        public Texture2D imgParadoTridenteD, imgCombo2_1TridenteD, imgCorrerTridenteD, imgDefenderTridenteD, imgPularTridenteD, imgHit1TridenteD, imgHit2TridenteD, imgSacarTridenteD, imgCombo1_1TridenteD, imgCombo1_2TridenteD, imgCombo1_3TridenteD, imgCombo1_4TridenteD;
        










        //                                                       TAMANHO
        //MOVIMENTAÇÃO
        //MAOS
        public Point tamanhoMaosparado1 = new Point(148, 466); //Dimensões do sprite
        public Point tamanhoMaosparado2 = new Point(283, 452); //Dimensões do sprite
        public Point tamanhoMaosagachar = new Point(323, 450); //Dimensões do sprite
        public Point tamanhoMaosandando = new Point(200, 462); //Dimensões do sprite
        public Point tamanhoMaoscorrendo = new Point(355, 474); //Dimensões do sprite
        public Point tamanhoMaosdefesa1 = new Point(309, 451); //Dimensões do sprite
        public Point tamanhoMaosagachadoHIT = new Point(663, 622); //Dimensões do sprite
        public Point tamanhoMaospular = new Point(284, 454); //Dimensões do sprite

        public Point tamanhoMaosHIT1 = new Point(273, 452); //Dimensões do sprite
        public Point tamanhoMaosHIT2 = new Point(303, 468); //Dimensões do sprite
        //LUTA
        //MAOS
        public Point tamanhosoco1Maos = new Point(360, 446); //Dimensões do sprite
        public Point tamanhosoco2C1Maos = new Point(370, 443); //Dimensões do sprite
        public Point tamanhosoco3C1Maos = new Point(403, 458); //Dimensões do sprite
        public Point tamanhojoelhada4C1Maos = new Point(341, 469); //Dimensões do sprite

        //ARMA
        //adaga
        public Point tamanhoSacarAdaga = new Point(388, 542); //Dimensões do sprite
        public Point tamanhoPularAdaga = new Point(309, 468); //Dimensões do sprite
        public Point tamanhoParadoAdaga = new Point(291, 457); //Dimensões do sprite
        public Point tamanhoHIT1Adaga = new Point(311, 466); //Dimensões do sprite
        public Point tamanhoHIT2Adaga = new Point(295, 468); //Dimensões do sprite
        public Point tamanhoDefenderAdaga = new Point(293, 470); //Dimensões do sprite
        public Point tamanhoCorrerAdaga = new Point(414, 481); //Dimensões do sprite
        public Point tamanhoCombo1_1Adaga = new Point(426, 457); //Dimensões do sprite
        public Point tamanhoCombo1_2Adaga = new Point(448, 471); //Dimensões do sprite
        public Point tamanhoCombo1_3Adaga = new Point(456, 459); //Dimensões do sprite
        public Point tamanhoCombo1_4Adaga = new Point(511, 492); //Dimensões do sprite
        //arco
        public Point tamanhoATIRARarco = new Point(688, 668); //Dimensões do sprite
        public Point tamanhoSACARarco = new Point(634, 683); //Dimensões do sprite
        public Point tamanhoPulararco = new Point(548, 535); //Dimensões do sprite
        public Point tamanhoParadoarco = new Point(540, 511); //Dimensões do sprite
        public Point tamanhoHIT2arco = new Point(550, 483); //Dimensões do sprite
        public Point tamanhoHIT1arco = new Point(609, 485); //Dimensões do sprite
        public Point tamanhoCORRERarco = new Point(658, 566); //Dimensões do sprite
        //espada
        public Point tamanhoSACARespada = new Point(488, 505); //Dimensões do sprite
        public Point tamanhoPARADOespada = new Point(435, 500); //Dimensões do sprite
        public Point tamanhoHIT2espada = new Point(438, 514); //Dimensões do sprite
        public Point tamanhoHIT1espada = new Point(443, 490); //Dimensões do sprite
        public Point tamanhoDEFENDERespada = new Point(435, 620); //Dimensões do sprite
        public Point tamanhoCORRERespada = new Point(442, 499); //Dimensões do sprite
        public Point tamanhoCombo1_1espada = new Point(1050, 522); //Dimensões do sprite
        public Point tamanhoCombo1_2espada = new Point(1176, 668); //Dimensões do sprite
        public Point tamanhoCombo1_3espada = new Point(589, 488); //Dimensões do sprite
        public Point tamanhoCombo1_4espada = new Point(572, 549); //Dimensões do sprite
        //TRIDENTE
        public Point tamanhoSACARtridente = new Point(699, 673); //Dimensões do sprite
        public Point tamanhoPULARtridente = new Point(480, 535); //Dimensões do sprite
        public Point tamanhoPARADOtridente = new Point(469, 530); //Dimensões do sprite
        public Point tamanhoDEFENDERtridente = new Point(512, 592); //Dimensões do sprite
        public Point tamanhoCORRERtridente = new Point(616, 584); //Dimensões do sprite
        public Point tamanhocombo2_1tridente = new Point(687, 524); //Dimensões do sprite
        public Point tamanhocombo1_1tridente = new Point(635, 668); //Dimensões do sprite
        public Point tamanhocombo1_2tridente = new Point(659, 718); //Dimensões do sprite
        public Point tamanhocombo1_3tridente = new Point(677, 571); //Dimensões do sprite
        public Point tamanhocombo1_4tridente = new Point(821, 679); //Dimensões do sprite
        public Point tamanhoHIT1tridente = new Point(393, 509); //Dimensões do sprite
        public Point tamanhoHIT2tridente = new Point(391, 518); //Dimensões do sprite
        
        //      sprite qntdd
        //MAOS
        public Point SpriteSheetparado1maos = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetparado2maos = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetagacharmaos = new Point(8, 4); //Dimensões da spritesheet
        public Point SpriteSheetmovendomaos = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetpularmaos = new Point(8, 4); //Dimensões da spritesheet
        public Point SpriteSheetdefesamaos = new Point(8, 4); //Dimensões da spritesheet
        public Point SpriteSheetagachadoHITmaos = new Point(8, 10); //Dimensões da spritesheet

        public Point SpriteSheetHIT1maos = new Point(8, 4); //Dimensões da spritesheet
        public Point SpriteSheetHIT2maos = new Point(8, 4); //Dimensões da spritesheet

        //armas
        //adaga
        public Point SpriteSheetSacarAdaga = new Point(8, 6); //Dimensões do sprite
        public Point SpriteSheetPularAdaga = new Point(8, 4); //Dimensões do sprite
        public Point SpriteSheetParadoAdaga = new Point(8, 4); //Dimensões do sprite
        public Point SpriteSheetHIT1Adaga = new Point(8, 3); //Dimensões do sprite
        public Point SpriteSheetHIT2Adaga = new Point(8, 3); //Dimensões do sprite
        public Point SpriteSheetDefenderAdaga = new Point(8, 4); //Dimensões do sprite
        public Point SpriteSheetCorrerAdaga = new Point(8, 7); //Dimensões do sprite
        public Point SpriteSheetCombo1_1Adaga = new Point(8, 4); //Dimensões do sprite
        public Point SpriteSheetCombo1_2Adaga = new Point(8, 5); //Dimensões do sprite
        public Point SpriteSheetCombo1_3Adaga = new Point(8, 4); //Dimensões do sprite
        public Point SpriteSheetCombo1_4Adaga = new Point(8, 8); //Dimensões do sprite
        //arco
        public Point SpriteSheetATIRARarco = new Point(8, 7); //Dimensões do sprite
        public Point SpriteSheetSACARarco = new Point(8, 6); //Dimensões do sprite
        public Point SpriteSheetPulararco = new Point(8, 4); //Dimensões do sprite
        public Point SpriteSheetParadoarco = new Point(8, 4); //Dimensões do sprite
        public Point SpriteSheetHIT2arco = new Point(8, 4); //Dimensões do sprite
        public Point SpriteSheetHIT1arco = new Point(8, 4); //Dimensões do sprite
        public Point SpriteSheetCORRERarco = new Point(8, 6); //Dimensões do sprite
        //espada
        public Point SpriteSheetSACARespada = new Point(8, 6); //Dimensões do sprite
        public Point SpriteSheetPARADOespada = new Point(8, 4); //Dimensões do sprite
        public Point SpriteSheetHIT2espada = new Point(8, 3); //Dimensões do sprite
        public Point SpriteSheetHIT1espada = new Point(8, 3); //Dimensões do sprite
        public Point SpriteSheetDEFENDERespada = new Point(8, 4); //Dimensões do sprite
        public Point SpriteSheetCORRERespada = new Point(8, 8); //Dimensões do sprite
        public Point SpriteSheetCombo1_1espada = new Point(6, 8); //Dimensões do sprite
        public Point SpriteSheetCombo1_2espada = new Point(4, 6); //Dimensões do sprite
        public Point SpriteSheetCombo1_3espada = new Point(8, 6); //Dimensões do sprite
        public Point SpriteSheetCombo1_4espada = new Point(8, 7); //Dimensões do sprite
        //TRIDENTE
        public Point SpriteSheetSACARtridente = new Point(8, 6); //Dimensões do sprite
        public Point SpriteSheetPULARtridente = new Point(8, 3); //Dimensões do sprite
        public Point SpriteSheetPARADOtridente = new Point(8, 4); //Dimensões do sprite
        public Point SpriteSheetDEFENDERtridente = new Point(8, 4); //Dimensões do sprite
        public Point SpriteSheetCORRERtridente = new Point(8, 6); //Dimensões do sprite
        public Point SpriteSheetcombo2_1tridente = new Point(9, 5); //Dimensões do sprite
        public Point SpriteSheetcombo1_1tridente = new Point(8, 4); //Dimensões do sprite
        public Point SpriteSheetcombo1_2tridente = new Point(8, 6); //Dimensões do sprite
        public Point SpriteSheetcombo1_3tridente = new Point(8, 7); //Dimensões do sprite
        public Point SpriteSheetcombo1_4tridente = new Point(9, 7); //Dimensões do sprite
        public Point SpriteSheetHIT1tridente = new Point(8, 4); //Dimensões do sprite
        public Point SpriteSheetHIT2tridente = new Point(8, 4); //Dimensões do sprite

        //luta
        //MAOS
        public Point SpriteSheetsoco1 = new Point(8, 3); //Dimensões da spritesheet
        public Point SpriteSheetsoco2C1 = new Point(8, 5); //Dimensões da spritesheet
        public Point SpriteSheetsoco3C1 = new Point(8, 5); //Dimensões da spritesheet
        public Point SpriteSheetjoelhada4C1 = new Point(8, 8); //Dimensões da spritesheet
            
        //      FRAMES
        //mov
        public Point frameparado1 = new Point(0, 0); //Marca o frame a ser utilizado
        public Point frameparado2 = new Point(0, 0); //Marca o frame a ser utilizado 
        public Point frameagachar1 = new Point(0, 0); //Marca o frame a ser utilizado 
        public Point frameagachar2 = new Point(0, 0); //Marca o frame a ser utilizado 
        public Point framemovendo = new Point(0, 0); //Marca o frame a ser utilizado 
        public Point framepular = new Point(0, 0); //Marca o frame a ser utilizado

        //hitado
        public Point framedefesa = new Point(0, 0); //Marca o frame a ser utilizado 
        public Point frameHIT = new Point(0, 0); //Marca o frame a ser utilizado 
        

        //luta
        public Point frameLUTA = new Point(0, 0); //Marca o frame a ser utilizado 
        public Point frameARMA = new Point(0, 0); //marca o frame a ser usado pelas armas

        public Rectangle individuo = new Rectangle();
        public Rectangle meio = new Rectangle();
        public Rectangle DistanciadeLuta = new Rectangle();
        public Rectangle DistanciadeLutaADistancia = new Rectangle();

        public bool DIREITA;
        public bool ESQUERDA;
        public bool AGACHADO;
        public bool ATACANDO;
        public bool PARADO;
        public bool COMBATE;
        public bool PULANDOparado;
        public bool PULANDOandando;
        public bool PULANDOcorrendo;
        public bool ANDANDO;
        public bool CORRENDO;
        public bool DEFENDENDO;
        public bool PODER;
        public bool DESCANSANDO;
        public bool SACARARMA;


        //poderes que se tem
        public bool PODERslow, PODERvento, PODERraio, PODERretroceder, PODERescudo;

        public bool ATAQUELANÇADO;
        public bool SENDOAGARRADO;

       
        public bool HIT1;
        public bool HIT2;
        public bool AGACHADOHIT;

        public bool LEVARCONTRAATAQUE; //bool para inimigos

        public bool UsarArma;

        //LUTA
        //MAOS
        //frame voltando
        public bool INVERSO;
        //combo de ataques
        public bool COMBO1; // soco E , soco D, girada D, joelhada E (BOTOES : 8,4,4,6)
        public bool COMBO2;
        //cada ataque (partes)
        public bool PARTE1;
        public bool PARTE2;
        public bool PARTE3;
        public bool PARTE4;
        //
        //ADAGA
        public bool COMBO1adaga;
        public bool PARTE1adaga, PARTE2adaga, PARTE3adaga, PARTE4adaga;
        //ESPADA
        public bool COMBO1espada2m, COMBO2espada2m;
        public bool PARTE1espada2m, PARTE2espada2m, PARTE3espada2m, PARTE4espada2m;
        //ARCO
        public bool ATIRAR1arco, ATIRAR2arco, ATIRAR3arco, ATIRAR4arco;
        //TRIDENTE
        public bool COMBO1tridente, COMBO2tridente;
        public bool PARTE1_1tridente, PARTE1_2tridente, PARTE2tridente, PARTE3tridente, PARTE4tridente;

        public bool COLIDINDOdireita;
        public bool COLIDINDOesquerda;
        public bool subindo;
        public bool descendo;
        public bool IVUNERAVEL;

        //      INT
        public int Vx;
        public int Vy;
        public int g = 0; // gravidade
        public int vida;
        public int energia;
        public int mana;
        public int XP;
        public int XPT;
        public int LVL;

        //para inteligencia artificial inimiga
        public int DefesaCONTAGEM = 0;
        public int AgachadoDEFCONTAGEM = 0;
        public int ParadoCONTAGEM = 0;

        public int vidaTOTAL;
        public int energiaTOTAL;
        public int manaTOTAL;

        public int escudo;

        

        //DINHEIRO
        public int leite;
        public int leiterepositório;
        public int honra;
        public int honrarepositório;
        public int qntdcombos;
        public int qntdcombosrepositório;

        //sobre clones (poder 1 e 2)
        public Point POSmapacapturado = new Point(0, 0);
        public Point POSp1capturado = new Point(0, 0);
        
        //gastos
        public int TRINTAporcento, DEZporcento, CINQUENTAporcento, UMporcento, VINTECINTOporcento;

        //Fase 1 cenario
        public int ONDAcontagem = 0;

        public List<Personagem> listaclonePoder = new List<Personagem>();
        public List<Agua> listadeagua = new List<Agua>();
        public List<OndasdeAgua> listadeondadeagua = new List<OndasdeAgua>();
        public List<Poder_Visual> listadevisualPOWER = new List<Poder_Visual>();
        public List<VIDAperdida> listavidaperdida = new List<VIDAperdida>();
        public List<VENTO> listavento = new List<VENTO>();
        public List<RAIO> listaraio = new List<RAIO>();
        
        //dano
        public List<Dano> listadedano = new List<Dano>();
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================

        public void PORCENTAGENS()
        {
            //de mana
            TRINTAporcento = (int)(manaTOTAL * 0.3f);
            DEZporcento = (int)(manaTOTAL * 0.1f);
            CINQUENTAporcento = (int)(manaTOTAL * 0.5f);
            UMporcento = (int)(manaTOTAL * 0.01f);//1% (meio porcento nao pode)
            VINTECINTOporcento = (int)(manaTOTAL * 0.25f);
        }

        public void RPGatualização(int WidthTela, int HeightTela) // atualiza tudo em relação ao RPG (vida / mana / money etc etc)
        {
            PORCENTAGENS();
            if (XP >= XPT)//aumentar de lvl
            {
                XP = 0;
                LVL++;
                
                vida = vidaTOTAL;
                mana = manaTOTAL;
                energia = energiaTOTAL;
            }

            XPT = 100 * LVL;
            XPrec.Width = (int)(((float)(XP) / XPT) * XPTrec.Width);
            vidaTOTAL = 200 + ((3 * LVL) * LVL);
            manaTOTAL = 150 + ((2 * LVL) * LVL);
            energiaTOTAL = 120 + ((4 * LVL) * LVL);

            if (XPrec.Width > 0)
            {
                Pino.X = XPTrec.X + XPrec.Width;
            }
            if (XPrec.Width <= 0)
            {
                Pino.X = XPTrec.X;
            }
            Pino.Y = XPrec.Y;
            Pino.Height = XPrec.Height;
            Pino.Width = HeightTela / 90;

            //HUD
            BarraVida.Width = (int)((float)(vida) / vidaTOTAL * Barra.Width);
            BarraEnergia.Width = (int)((float)(energia) / energiaTOTAL * Barra.Width);
            BarraMana.Width = (int)((float)(mana) / manaTOTAL * Barra.Width);

            if (vida <= 0)
            {
                vida = 0;
                JANELA.J.JANELAPLACAR = true;
            }
        }
        //===========================================================================================================================================================================

        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        //=========================================================================================FRAMES DA LUTA====================================================================
        public void FRAMESluta()
        {
            //ATUALIZAÇÃO PRA INTELIGENCIA ARTIFICIAL INIMIGA
            ATAQUELANÇADO = false;
            LEVARCONTRAATAQUE = false;

            //CASO O JOGADOR FIQUE SÓ NA RETAGUARDA: (IA inimiga)
            if (PARADO)
            {
                ParadoCONTAGEM++;
            }
            else if (!PARADO)
            {
                ParadoCONTAGEM = 0;
            }
            //CASO FIQUE APENAS DEFENDENDO: (IA inimiga)
            if (DEFENDENDO)
            {
                DefesaCONTAGEM++;
            }
            else if (!DEFENDENDO)
            {
                DefesaCONTAGEM = 0;
            }
            //CASO FIQUE AGACHADO DEFENDENDO: : (IA inimiga)
            if (DEFENDENDO && AGACHADO)
            {
                AgachadoDEFCONTAGEM++;
            }
            else if (!DEFENDENDO && AGACHADO || !AGACHADO && DEFENDENDO || !DEFENDENDO && !AGACHADO)
            {
                AgachadoDEFCONTAGEM = 0;
            }

            //SKILLS P1
            if (ATACANDO)
            {
                if (JANELA.J.MAOselect)
                {
                    if (DIREITA)
                    {
                        //atualização
                        PARADO = false;
                        ANDANDO = false;
                        CORRENDO = false;
                        ATACANDO = true;

                        if (PARTE1)//soco esquerdo
                        {
                            Vx = 0;
                            Vy = 0;

                            if (!INVERSO)
                            {
                                frameLUTA.X++;
                                if (frameLUTA.X >= SpriteSheetsoco1.X)
                                {
                                    frameLUTA.X = 0;
                                    frameLUTA.Y++;
                                }
                                if (frameLUTA.X >= 7 && frameLUTA.Y == 1 || frameLUTA.Y == 2 && frameLUTA.X < 3) // caso ataque nesse periodo
                                {
                                    if (Keyboard.GetState().IsKeyDown(Keys.NumPad4) && !Keyboard.GetState().IsKeyDown(Keys.NumPad8) && !Keyboard.GetState().IsKeyDown(Keys.NumPad6) && !Keyboard.GetState().IsKeyDown(Keys.NumPad2) && energia >= 10)
                                    {
                                        PARTE1 = false;
                                        PARTE2 = true;


                                        COMBO1 = true;
                                        frameLUTA.X = 0;
                                        frameLUTA.Y = 0;
                                        energia -= 10;
                                        ATAQUELANÇADO = true; // mostrar q ele atacou
                                    }
                                }

                                if (frameLUTA.X >= 4 && frameLUTA.Y == 2)
                                {
                                    INVERSO = true;
                                }
                            }
                            else if (INVERSO)
                            {
                                frameLUTA.X--;
                                if (frameLUTA.X <= 0 && frameLUTA.Y == 0)
                                {
                                    //TERMINAR A SEQUENCIA:

                                    PARTE1 = false;
                                    INVERSO = false;
                                    ATACANDO = false;
                                    COMBO1 = false;
                                    PARADO = true;
                                    frameLUTA.X = 0;
                                    frameLUTA.Y = 0;

                                }
                                if (frameLUTA.X < 0)
                                {
                                    frameLUTA.X = 7;
                                    frameLUTA.Y--;
                                }

                            }
                        }//fim parte 1

                        if (PARTE2 && COMBO1)//combo 1, 2° soco
                        {
                            frameLUTA.X++;
                            if (frameLUTA.X >= SpriteSheetsoco2C1.X)
                            {
                                frameLUTA.X = 0;
                                frameLUTA.Y++;
                            }
                            if (frameLUTA.X >= 5 && frameLUTA.Y == 4)//caso termine antes de continuar a sequencia
                            {
                                PARTE2 = false;
                                COMBO1 = false;
                                INVERSO = false;
                                ATACANDO = false;
                                PARADO = true;
                                frameLUTA.X = 0;
                                frameLUTA.Y = 0;
                            }

                            if (frameLUTA.Y == 3 || frameLUTA.Y == 4 && frameLUTA.X < 5) // caso ataque nesse periodo
                            {
                                if (Keyboard.GetState().IsKeyDown(Keys.NumPad4) && !Keyboard.GetState().IsKeyDown(Keys.NumPad8) && !Keyboard.GetState().IsKeyDown(Keys.NumPad6) && !Keyboard.GetState().IsKeyDown(Keys.NumPad2) && energia >= 25)
                                {

                                    PARTE2 = false;
                                    PARTE3 = true;

                                    COMBO1 = true;
                                    frameLUTA.X = 0;
                                    frameLUTA.Y = 0;
                                    energia -= 25;
                                    ATAQUELANÇADO = true; // mostrar q ele atacou
                                }
                            }
                        }//parte 2

                        if (PARTE3 && COMBO1)//combo 1, 3° soco
                        {
                            frameLUTA.X++;
                            if (frameLUTA.X >= SpriteSheetsoco3C1.X)
                            {
                                frameLUTA.X = 0;
                                frameLUTA.Y++;
                            }
                            if (frameLUTA.X >= 5 && frameLUTA.Y == 4)//caso termine antes de continuar a sequencia
                            {
                                PARTE3 = false;
                                COMBO1 = false;
                                INVERSO = false;
                                ATACANDO = false;
                                PARADO = true;
                                frameLUTA.X = 0;
                                frameLUTA.Y = 0;
                            }

                            if (frameLUTA.Y == 3 && frameLUTA.X >= 7 || frameLUTA.Y == 4 && frameLUTA.X < 5) // caso ataque nesse periodo
                            {
                                if (Keyboard.GetState().IsKeyDown(Keys.NumPad6) && Keyboard.GetState().IsKeyDown(Keys.W) && !Keyboard.GetState().IsKeyDown(Keys.NumPad8) && !Keyboard.GetState().IsKeyDown(Keys.NumPad4) && !Keyboard.GetState().IsKeyDown(Keys.NumPad2) && energia >= 30)
                                {

                                    PARTE3 = false;
                                    PARTE4 = true;

                                    COMBO1 = true;
                                    frameLUTA.X = 0;
                                    frameLUTA.Y = 0;
                                    energia -= 30;
                                    ATAQUELANÇADO = true; // mostrar q ele atacou
                                }
                            }
                        }//fim parte 3

                        if (PARTE4 && COMBO1)//combo 1, 4° joelhada
                        {
                            frameLUTA.X++;
                            if (frameLUTA.X >= SpriteSheetsoco2C1.X)
                            {
                                frameLUTA.X = 0;
                                frameLUTA.Y++;
                            }

                            if (frameLUTA.X >= 5 && frameLUTA.Y == 4)//FIM
                            {
                                PARTE4 = false;
                                COMBO1 = false;
                                INVERSO = false;
                                ATACANDO = false;
                                PARADO = true;
                                frameLUTA.X = 0;
                                frameLUTA.Y = 0;

                                // inimigo contrataca no final
                                LEVARCONTRAATAQUE = true;
                            }
                        }

                    }//FIM DIREITA

                    if (ESQUERDA)
                    {
                        //atualização
                        PARADO = false;
                        ANDANDO = false;
                        CORRENDO = false;
                        ATACANDO = true;

                        if (PARTE1)//soco esquerdo
                        {
                            Vx = 0;
                            Vy = 0;

                            if (!INVERSO)
                            {
                                frameLUTA.X--;
                                if (frameLUTA.X < 0)
                                {
                                    frameLUTA.X = 7;
                                    frameLUTA.Y++;
                                }
                                if (frameLUTA.X <= 0 && frameLUTA.Y == 1 || frameLUTA.Y == 2 && frameLUTA.X > 3) // caso ataque nesse periodo
                                {
                                    if (Keyboard.GetState().IsKeyDown(Keys.NumPad4) && !Keyboard.GetState().IsKeyDown(Keys.NumPad8) && !Keyboard.GetState().IsKeyDown(Keys.NumPad6) && !Keyboard.GetState().IsKeyDown(Keys.NumPad2) && energia >= 10)
                                    {
                                        PARTE1 = false;
                                        PARTE2 = true;

                                        COMBO1 = true;
                                        frameLUTA.X = 7;
                                        frameLUTA.Y = 0;
                                        energia -= 10;
                                        ATAQUELANÇADO = true; // mostrar q ele atacou
                                    }
                                }

                                if (frameLUTA.X <= 3 && frameLUTA.Y == 2)
                                {
                                    INVERSO = true;
                                }
                            }
                            else if (INVERSO)
                            {
                                frameLUTA.X++;
                                if (frameLUTA.X >= 7 && frameLUTA.Y == 0)
                                {
                                    //TERMINAR A SEQUENCIA:

                                    PARTE1 = false;
                                    INVERSO = false;
                                    ATACANDO = false;
                                    COMBO1 = false;
                                    PARADO = true;
                                    frameLUTA.X = 0;
                                    frameLUTA.Y = 0;

                                }
                                if (frameLUTA.X >= SpriteSheetsoco1.X)
                                {
                                    frameLUTA.X = 0;
                                    frameLUTA.Y--;
                                }

                            }
                        }//fim parte 1

                        if (PARTE2 && COMBO1)//combo 1, 2° soco
                        {
                            frameLUTA.X--;
                            if (frameLUTA.X < 0)
                            {
                                frameLUTA.X = 7;
                                frameLUTA.Y++;
                            }
                            if (frameLUTA.X <= 3 && frameLUTA.Y == 4)//caso termine antes de continuar a sequencia
                            {
                                PARTE2 = false;
                                COMBO1 = false;
                                INVERSO = false;
                                ATACANDO = false;
                                PARADO = true;
                                frameLUTA.X = 0;
                                frameLUTA.Y = 0;
                            }

                            if (frameLUTA.Y == 3 || frameLUTA.Y == 4 && frameLUTA.X > 3) // caso ataque nesse periodo
                            {
                                if (Keyboard.GetState().IsKeyDown(Keys.NumPad4) && !Keyboard.GetState().IsKeyDown(Keys.NumPad8) && !Keyboard.GetState().IsKeyDown(Keys.NumPad6) && !Keyboard.GetState().IsKeyDown(Keys.NumPad2) && energia >= 25)
                                {
                                    PARTE2 = false;
                                    PARTE3 = true;

                                    COMBO1 = true;
                                    frameLUTA.X = 7;
                                    frameLUTA.Y = 0;
                                    energia -= 25;
                                    ATAQUELANÇADO = true; // mostrar q ele atacou
                                }
                            }
                        }//parte 2

                        if (PARTE3 && COMBO1)//combo 1, 3° soco
                        {
                            frameLUTA.X--;
                            if (frameLUTA.X < 0)
                            {
                                frameLUTA.X = 7;
                                frameLUTA.Y++;
                            }
                            if (frameLUTA.X <= 3 && frameLUTA.Y == 4)//caso termine antes de continuar a sequencia
                            {
                                PARTE3 = false;
                                COMBO1 = false;
                                INVERSO = false;
                                ATACANDO = false;
                                PARADO = true;
                                frameLUTA.X = 0;
                                frameLUTA.Y = 0;
                            }

                            if (frameLUTA.Y == 3 && frameLUTA.X <= 0 || frameLUTA.Y == 4 && frameLUTA.X > 3) // caso ataque nesse periodo
                            {
                                if (Keyboard.GetState().IsKeyDown(Keys.NumPad6) && Keyboard.GetState().IsKeyDown(Keys.W) && !Keyboard.GetState().IsKeyDown(Keys.NumPad8) && !Keyboard.GetState().IsKeyDown(Keys.NumPad4) && !Keyboard.GetState().IsKeyDown(Keys.NumPad2) && energia >= 30)
                                {
                                    PARTE3 = false;
                                    PARTE4 = true;

                                    COMBO1 = true;
                                    frameLUTA.X = 7;
                                    frameLUTA.Y = 0;
                                    energia -= 30;
                                    ATAQUELANÇADO = true; // mostrar q ele atacou
                                }
                            }
                        }//fim parte 3

                        if (PARTE4 && COMBO1)//combo 1, 4° joelhada
                        {
                            frameLUTA.X--;
                            if (frameLUTA.X < 0)
                            {
                                frameLUTA.X = 7;
                                frameLUTA.Y++;
                            }

                            if (frameLUTA.X <= 1 && frameLUTA.Y == 4)//FIM
                            {
                                PARTE4 = false;
                                COMBO1 = false;
                                INVERSO = false;
                                ATACANDO = false;
                                PARADO = true;
                                frameLUTA.X = 0;
                                frameLUTA.Y = 0;
                                LEVARCONTRAATAQUE = true;
                            }
                        }

                    }
                }// se ele tiver selecionado o soco
            }//fim da LUTA frames (img)
        }

        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================


        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================

        public void FRAMESparado2()
        {
            frameparado2.X++;
            if (frameparado2.X >= SpriteSheetparado2maos.X)
            {
                frameparado2.X = 0;
                frameparado2.Y++;
            }
            if (frameparado2.X == 6 && frameparado2.Y == 7)
            {
                frameparado2.X = 0;
                frameparado2.Y = 0;
            }
        }
        public void FRAMESparado2E()
        {
            frameparado2.X--;
            if (frameparado2.X <= -1)
            {
                frameparado2.X = 7;
                frameparado2.Y++;
            }
            if (frameparado2.X == 1 && frameparado2.Y == 7)
            {
                frameparado2.X = 7;
                frameparado2.Y = 0;
            }
        }
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        public void FRAMESpular(int WidthTela, int HeightTela)
        {
            if (subindo)
            {
                if (framepular.X == 6 && framepular.Y == 3)
                {
                    
                }
                else
                {
                    framepular.X++;
                }
                if (framepular.X >= SpriteSheetpularmaos.X)
                {
                    framepular.X = 0;
                    framepular.Y++;
                }
                if (Vy + g >= 0 && Vy < 0)
                {
                    subindo = false;
                    descendo = true;
                }
            }
            if (descendo)
            {

                if (framepular.X == 0 && framepular.Y == 0)
                {
                   
                }
                else
                {
                    framepular.X--;
                }
                if (framepular.X <= -1)
                {
                    framepular.X = 7;
                    framepular.Y--;
                }
                if (individuo.Intersects(Contexto.Fundo.chao))
                {
                    g = 0;
                    Vy = 0;
                    descendo = false;
                    PULANDOandando = false;
                    PULANDOcorrendo = false;
                    PULANDOparado = false;
                }
            }
        }

        public void FRAMESpularE(int WidthTela, int HeightTela)//Esquerda
        {
            if (subindo)
            {
                if (framepular.X == 1 && framepular.Y == 3)
                {

                }
                else
                {
                    framepular.X--;
                }
                if (framepular.X <= -1)
                {
                    framepular.X = 7;
                    framepular.Y++;
                }
                if (Vy + g >= 0 && Vy < 0)
                {
                    subindo = false;
                    descendo = true;
                }
            }
            if (descendo)
            {

                if (framepular.X == 0 && framepular.Y == 0)
                {

                }
                else
                {
                    framepular.X++;
                }
                if (framepular.X >= SpriteSheetpularmaos.X)
                {
                    framepular.X = 0;
                    framepular.Y--;
                }
                if (individuo.Intersects(Contexto.Fundo.chao))
                {
                    g = 0;
                    Vy = 0;
                    descendo = false;
                    PULANDOandando = false;
                    PULANDOcorrendo = false;
                    PULANDOparado = false;
                }
            }
        }

        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        public void FRAMESparado1()
        {
            frameparado1.X++;
            if (frameparado1.X >= SpriteSheetparado1maos.X)
            {
                frameparado1.X = 0;
                frameparado1.Y++;
            }
            if (frameparado1.X == 6 && frameparado1.Y == 7)
            {
                frameparado1.X = 0;
                frameparado1.Y = 0;
            }
        }
        public void FRAMESparado1E()//Esquerda
        {
            frameparado1.X--;
            if (frameparado1.X <= -1)
            {
                frameparado1.X = 7;
                frameparado1.Y++;
            }
            if (frameparado1.X == 1 && frameparado1.Y == 7)
            {
                frameparado1.X = 7;
                frameparado1.Y = 0;
            }
        }
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        public void FRAMESmovendo()
        {
            framemovendo.X++;
            if (framemovendo.X >= SpriteSheetmovendomaos.X)
            {
                framemovendo.X = 0;
                framemovendo.Y++;
            }
            if (framemovendo.X == 5 && framemovendo.Y == 7)
            {
                framemovendo.X = 0;
                framemovendo.Y = 0;
            }
        }
        public void FRAMESmovendoE()//ESQUERDA
        {
            framemovendo.X--;
            if (framemovendo.X <= -1)
            {
                framemovendo.X = 7;
                framemovendo.Y++;
            }
            if (framemovendo.X == 1 && framemovendo.Y == 7)
            {
                framemovendo.X = 7;
                framemovendo.Y = 0;
            }
        }
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================

        //===================================================================================LUTA====================================================================================

        public void Luta(int WidthTela, int HeightTela, Random aleatório)
        {

            // ----------------------
            FRAMESluta();//frame dos ataques // junto a suas funçoes 
            // ----------------------
            // ----------------------
            // ----------------------
            if (JANELA.J.MAOselect)
            {
                if (DIREITA && !ESQUERDA)
                {
                    if (Keyboard.GetState().IsKeyDown(Keys.NumPad8) && !PARTE1 && !PARTE2 && !PARTE3 && !PARTE4 && !Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !ATACANDO && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && energia >= 20 && !SENDOAGARRADO)
                    {
                        ATAQUELANÇADO = true;
                        PARTE1 = true;
                        frameLUTA.X = 0;
                        frameLUTA.Y = 0;
                        ATACANDO = true;
                        energia -= 20;
                    }

                    //atualização de tamanho do personagem
                    if (PARTE1)
                    {
                        individuo.Width = WidthTela / 9;
                    }
                    if (COMBO1)
                    {
                        if (PARTE2)
                        {
                            individuo.Width = WidthTela / 9 + HeightTela / 100;
                        }
                        if (PARTE3)
                        {
                            //tamanhho
                            individuo.Width = WidthTela / 8;

                            //direita
                            if (individuo.X + individuo.Width < WidthTela) //movimento do individuo dentro da tela
                            {
                                Vx = HeightTela / 100; // = 10
                            }
                            else if (individuo.X + individuo.Width >= WidthTela)//se chegar no final para de andar
                            {
                                Vx = 0;
                                //tirar o personagem do nada
                                if (individuo.X + individuo.Width > WidthTela + HeightTela / 100)
                                    individuo.X -= 5;

                            }
                            if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width > WidthTela) // se a fase chegar no final ela nao anda mais
                            {
                                if (individuo.X + individuo.Width >= WidthTela - HeightTela / 80) // HeightTela/80 = 13 , se o individuo passar do final da tela - 10 = movimento;
                                {
                                    Contexto.Fundo.fase.X -= HeightTela / 100; // = 10
                                }
                                //tirar o fundo do vacuo
                                if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width <= WidthTela)
                                {
                                    Contexto.Fundo.fase.X += HeightTela / 100; // = 10
                                }
                            }




                        }
                        if (PARTE4)
                        {
                            individuo.Width = WidthTela / 10;

                            //direita
                            if (individuo.X + individuo.Width < WidthTela) //movimento do individuo dentro da tela
                            {
                                Vx = HeightTela / 90; // = 12
                            }
                            else if (individuo.X + individuo.Width >= WidthTela)//se chegar no final para de andar
                            {
                                Vx = 0;
                                //tirar o personagem do nada
                                if (individuo.X + individuo.Width > WidthTela + HeightTela / 100)
                                    individuo.X -= 5;

                            }
                            if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width > WidthTela) // se a fase chegar no final ela nao anda mais
                            {
                                if (individuo.X + individuo.Width >= WidthTela - HeightTela / 80) // HeightTela/80 = 13 , se o individuo passar do final da tela - 10 = movimento;
                                {
                                    Contexto.Fundo.fase.X -= HeightTela / 90; // = 12
                                }
                                //tirar o fundo do vacuo
                                if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width <= WidthTela)
                                {
                                    Contexto.Fundo.fase.X += HeightTela / 90; // = 12
                                }
                            }
                        }
                    }
                }
                if (ESQUERDA && !DIREITA)
                {
                    if (Keyboard.GetState().IsKeyDown(Keys.NumPad8) && !PARTE1 && !PARTE2 && !PARTE3 && !PARTE4 && !Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !ATACANDO && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && energia >= 20 && !SENDOAGARRADO)
                    {
                        ATAQUELANÇADO = true;
                        PARTE1 = true;
                        frameLUTA.X = 7;
                        frameLUTA.Y = 0;
                        ATACANDO = true;
                        energia -= 20;
                    }

                    //atualização de tamanho do personagem
                    if (PARTE1)
                    {
                        individuo.Width = WidthTela / 9;
                    }
                    if (COMBO1)
                    {
                        if (PARTE2)
                        {
                            individuo.Width = WidthTela / 9 + HeightTela / 100;
                        }
                        if (PARTE3)
                        {

                            //tamanho
                            individuo.Width = WidthTela / 8;


                            //esquerda
                            if (individuo.X > 0) // se o individuo estiver maior que 0 ele pode correr pra esquerda
                            {
                                Vx = -HeightTela / 100; // = 10
                            }
                            else if (individuo.X <= 0) // se colidir com o começo ele para
                            {
                                Vx = 0;

                            }
                            if (Contexto.Fundo.fase.X < 0) // se o fundo estiver no 0 ele para
                            {
                                if (individuo.X <= HeightTela / 80) // se o individuo estiver menor ou igual a 13 ele começa a ir pra esquerda (fundo)
                                {
                                    Contexto.Fundo.fase.X += HeightTela / 100; // = 10
                                }
                                //tirar o fundo do vacuo
                                if (Contexto.Fundo.fase.X >= 0)
                                {
                                    Contexto.Fundo.fase.X -= HeightTela / 100; // = 10
                                }
                            }


                        }
                        if (PARTE4)
                        {
                            individuo.Width = WidthTela / 10;

                            //esquerda
                            if (individuo.X > 0) // se o individuo estiver maior que 0 ele pode correr pra esquerda
                            {
                                Vx = -HeightTela / 90; // = 12
                            }
                            else if (individuo.X <= 0) // se colidir com o começo ele para
                            {
                                Vx = 0;

                            }
                            if (Contexto.Fundo.fase.X < 0) // se o fundo estiver no 0 ele para
                            {
                                if (individuo.X <= HeightTela / 80) // se o individuo estiver menor ou igual a 13 ele começa a ir pra esquerda (fundo)
                                {
                                    Contexto.Fundo.fase.X += HeightTela / 900; // = 12
                                }
                                //tirar o fundo do vacuo
                                if (Contexto.Fundo.fase.X >= 0)
                                {
                                    Contexto.Fundo.fase.X -= HeightTela / 90; // = 12
                                }
                            }
                        }
                    }
                }
            }//fim da mao select
        }//fim do void luta







        //===========================================================================================================================================================================

        //===========================================================================================================================================================================
        //===========================================================================================================================================================================

        //===================================================================================MOV=====================================================================================
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        public void MOV(int W, int H, Random aleatório)
        {
            //METODOS
            //visual efeito
            REMOVERVISUPODER(W, H);//METODO DE REMOVER O EFEITO (QND CHEGAR EM TAL TAMANHO)
            PosDANO(W, H);// posição da informação do dano
            POSvidaperdida(); //barra vermelha
            //
            HITfunçao(W, H);//tudo sobre levar HIT inimigo

            //mov do personagem
            individuo.X += Vx;
            individuo.Y += (Vy + g);

            meio.X = individuo.X + individuo.Width / 4;
            meio.Y = individuo.Y;
            meio.Width = individuo.Width / 2;
            meio.Height = individuo.Height;

            DistanciadeLuta.X = individuo.X - W / 8;
            DistanciadeLuta.Y = individuo.Y;
            DistanciadeLuta.Width = W / 4;
            DistanciadeLuta.Height = individuo.Height;

            DistanciadeLutaADistancia.X = individuo.X - W / 4;
            DistanciadeLutaADistancia.Y = individuo.Y;
            DistanciadeLutaADistancia.Width = W / 2;
            DistanciadeLutaADistancia.Height = individuo.Height;

            //chao empurra pra cima
            if (individuo.Intersects(Contexto.Fundo.chao))
            {
                individuo.Y -= H / 270;
            }

            //subindo tela (impressao)
            if (Contexto.Fundo.fase.Y < 0)
            {
                if (Vy + g < 0)
                {
                    Contexto.Fundo.fase.Y += H / 100; //10
                }
            }
            else if (Contexto.Fundo.fase.Y > 0)
            {
                Contexto.Fundo.fase.Y = 0;
            }


            //descendo tela (impressao)
            if (Contexto.Fundo.fase.Y > -H / 10)
            {
                if (Vy + g > 0)
                {
                    Contexto.Fundo.fase.Y -= H / 100; //10
                }
            }
            else if (Contexto.Fundo.fase.Y < -H / 10)
            {
                Contexto.Fundo.fase.Y = -H / 10;
            }

            if (SENDOAGARRADO)
            {
                if (!PODER) //se ele nao estiver soltando poder
                {
                    Vx = 0;
                    Vy = 0;
                    g = 0;
                }
            }
            else if (!SENDOAGARRADO) // PARALIZADO
            {
                //pulando parado
                if (Keyboard.GetState().IsKeyDown(Keys.W) && !Keyboard.GetState().IsKeyDown(Keys.D) && !Keyboard.GetState().IsKeyDown(Keys.A) && !AGACHADO && !ATACANDO && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !HIT1 && !HIT2 && !AGACHADOHIT)
                {
                    PULANDOparado = true;
                    PARADO = false;
                    CORRENDO = false;
                    ANDANDO = false;
                    subindo = true;
                    Vy = aleatório.Next(-H / 15, -H / 25);
                    if (ESQUERDA)
                    {
                        framepular.X = 7;
                        framepular.Y = 0;
                    }
                    descendo = false;
                }

                //pulando andando
                if (Keyboard.GetState().IsKeyDown(Keys.W) && (Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.A)) && !Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !AGACHADO && !ATACANDO && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !HIT1 && !HIT2 && !AGACHADOHIT)
                {
                    PULANDOandando = true;
                    PARADO = false;
                    CORRENDO = false;
                    ANDANDO = false;
                    subindo = true;

                    Vy = aleatório.Next(-H / 15, -H / 25);
                    if (ESQUERDA)
                    {
                        framepular.X = 7;
                        framepular.Y = 0;
                    }
                    descendo = false;
                }

                //pulando andando
                if (Keyboard.GetState().IsKeyDown(Keys.W) && (Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.A)) && Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !AGACHADO && !ATACANDO && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && energia >= 35 && !HIT1 && !HIT2 && !AGACHADOHIT)
                {
                    PULANDOcorrendo = true;
                    PARADO = false;
                    CORRENDO = false;
                    ANDANDO = false;
                    subindo = true;
                    Vy = aleatório.Next(-H / 15, -H / 25);
                    if (ESQUERDA)
                    {
                        framepular.X = 7;
                        framepular.Y = 0;
                    }
                    descendo = false;

                    if (energia > 0)
                        energia -= 25;
                }

                if (PULANDOparado || PULANDOcorrendo || PULANDOandando) // A T U A L I Z A Ç Ã O
                {
                    //em ordem de acontecimentos
                    //pula

                    //gravidade
                    if (subindo || (descendo && !individuo.Intersects(Contexto.Fundo.chao)))
                    {
                        g += H / 300;
                    }
                    if (descendo && individuo.Intersects(Contexto.Fundo.chao) && !subindo)
                    {
                        g = 0;
                        Vy = 0;
                    }
                    //cair

                    //nao colidir com inimigo
                    COLIDINDOdireita = false;
                    COLIDINDOesquerda = false;
                    PARADO = false;

                }




                //parar de correr
                if (energia < 7)
                {
                    DESCANSANDO = true;
                }
                else if (energia >= 50)
                {
                    DESCANSANDO = false;
                }

                





                //parado
                if (!Keyboard.GetState().IsKeyDown(Keys.D) && !Keyboard.GetState().IsKeyDown(Keys.A) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO && !HIT1 && !HIT2 && !AGACHADOHIT)
                {
                    PARADO = true;
                    Vx = 0;
                    Vy = 0;
                    ANDANDO = false;
                    CORRENDO = false;
                    //atualização de spritesheet
                    framemovendo.X = 0;
                    framemovendo.Y = 0;
                }// fim do parado

                if (Keyboard.GetState().IsKeyDown(Keys.D) && Keyboard.GetState().IsKeyDown(Keys.A) && !PULANDOparado && !AGACHADO && !ATACANDO && !PULANDOandando && !PULANDOcorrendo && !HIT1 && !HIT2 && !AGACHADOHIT) // qnd apertar os dois botoes
                {
                    PARADO = true;
                    ANDANDO = false;
                    CORRENDO = false;
                    Vx = 0;
                }







                if (DIREITA) /// POSIÇÃO (CORPO) estiver olhando para --  DIREITA
                {
                    //andar DIREITA
                    if (Keyboard.GetState().IsKeyDown(Keys.D) && !Keyboard.GetState().IsKeyDown(Keys.A) && (!Keyboard.GetState().IsKeyDown(Keys.LeftShift) || DESCANSANDO) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO && !COLIDINDOdireita && !HIT1 && !HIT2 && !AGACHADOHIT)
                    {
                        //atualizando o frame parado
                        frameparado1.X = 0;
                        frameparado1.Y = 0;
                        frameparado2.X = 0;
                        frameparado2.Y = 0;

                        //mov DIREITA
                        if (individuo.X + individuo.Width < W) //movimento do individuo dentro da tela
                        {
                            Vx = H / 130; // = 8
                        }
                        else if (individuo.X + individuo.Width >= W)//se chegar no final para de andar
                        {
                            Vx = 0;
                            //tirar o personagem do nada
                            if (individuo.X + individuo.Width > W + H / 100)
                                individuo.X -= 5;

                        }
                        if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width > W) // se a fase chegar no final ela nao anda mais
                        {
                            if (individuo.X + individuo.Width >= W - H / 80) // HeightTela/80 = 13 , se o individuo passar do final da tela - 10 = movimento;
                            {
                                Contexto.Fundo.fase.X -= H / 130; // = 8
                            }
                            //tirar o fundo do vacuo
                            if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width <= W)
                            {
                                Contexto.Fundo.fase.X += H / 130; // = 8
                            }
                        }

                        PARADO = false;
                        ANDANDO = true;
                        CORRENDO = false;
                    }

                    //correr DIREITA

                    else if (Keyboard.GetState().IsKeyDown(Keys.D) && !Keyboard.GetState().IsKeyDown(Keys.A) && Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO && !DESCANSANDO && !COLIDINDOdireita && !HIT1 && !HIT2 && !AGACHADOHIT)
                    {

                        //atualizando o frame parado
                        frameparado1.X = 0;
                        frameparado1.Y = 0;
                        frameparado2.X = 0;
                        frameparado2.Y = 0;

                        //gastando energia ao correr
                        if (energia > 0)
                            energia -= 3;

                        //mov DIREITA
                        if (individuo.X + individuo.Width < W) //movimento do individuo dentro da tela
                        {
                            Vx = H / 54; // = 20
                        }
                        else if (individuo.X + individuo.Width >= W)//se encostar no final para de correr
                        {
                            Vx = 0;
                            //tirar o personagem do nada
                            if (individuo.X + individuo.Width > W + H / 100)
                                individuo.X -= 5;
                        }
                        if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width > W) // se a fase chegar no final ela nao anda mais
                        {
                            if (individuo.X + individuo.Width >= W - H / 80) // HeightTela/80 = 13 , se o individuo passar do final da tela - 10 = movimento;
                            {
                                Contexto.Fundo.fase.X -= H / 54; // = 20
                            }
                            //tirar o fundo do vacuo
                            if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width <= W)
                            {
                                Contexto.Fundo.fase.X += H / 54; // = 20
                            }
                        }

                        PARADO = false;
                        ANDANDO = false;
                        CORRENDO = true;
                    }

                   //desabilitar
                    else if (Keyboard.GetState().IsKeyDown(Keys.A) && !Keyboard.GetState().IsKeyDown(Keys.D) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO && !HIT1 && !HIT2 && !AGACHADOHIT)
                    {
                        DIREITA = false;
                        ESQUERDA = true;
                    }


                    if (PULANDOandando)
                    {
                        //mov DIREITA
                        if (individuo.X + individuo.Width < W) //movimento do individuo dentro da tela
                        {
                            Vx = H / 130; // = 8
                        }
                        else if (individuo.X + individuo.Width >= W)//se chegar no final para de andar
                        {
                            Vx = 0;
                            //tirar o personagem do nada
                            if (individuo.X + individuo.Width > W + H / 100)
                                individuo.X -= 5;

                        }
                        if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width > W) // se a fase chegar no final ela nao anda mais
                        {
                            if (individuo.X + individuo.Width >= W - H / 80) // HeightTela/80 = 13 , se o individuo passar do final da tela - 10 = movimento;
                            {
                                Contexto.Fundo.fase.X -= H / 130; // = 8
                            }
                            //tirar o fundo do vacuo
                            if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width <= W)
                            {
                                Contexto.Fundo.fase.X += H / 130; // = 8
                            }
                        }
                    }

                    if (PULANDOcorrendo)
                    {
                        //mov DIREITA
                        if (individuo.X + individuo.Width < W) //movimento do individuo dentro da tela
                        {
                            Vx = H / 54; // = 20
                        }
                        else if (individuo.X + individuo.Width >= W)//se encostar no final para de correr
                        {
                            Vx = 0;
                            //tirar o personagem do nada
                            if (individuo.X + individuo.Width > W + H / 100)
                                individuo.X -= 5;
                        }
                        if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width > W) // se a fase chegar no final ela nao anda mais
                        {
                            if (individuo.X + individuo.Width >= W - H / 80) // HeightTela/80 = 13 , se o individuo passar do final da tela - 10 = movimento;
                            {
                                Contexto.Fundo.fase.X -= H / 54; // = 20
                            }
                            //tirar o fundo do vacuo
                            if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width <= W)
                            {
                                Contexto.Fundo.fase.X += H / 54; // = 20
                            }
                        }
                    }

                }//fim direita##









                if (ESQUERDA) /// POSIÇÃO (CORPO) estiver olhando para --  ESQUERDA
                {
                    //Andando ESQUERDA
                    if (Keyboard.GetState().IsKeyDown(Keys.A) && !Keyboard.GetState().IsKeyDown(Keys.D) && (!Keyboard.GetState().IsKeyDown(Keys.LeftShift) || DESCANSANDO) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO && !COLIDINDOesquerda && !HIT1 && !HIT2 && !AGACHADOHIT)
                    {
                        //atualizando o frame parado
                        frameparado1.X = 0;
                        frameparado1.Y = 0;
                        frameparado2.X = 0;
                        frameparado2.Y = 0;

                        //mov ESQUERDA
                        if (individuo.X > 0) // se o individuo estiver maior que 0 ele pode correr pra esquerda
                        {
                            Vx = -H / 130; // = 8
                        }
                        else if (individuo.X <= 0) // se colidir com o começo ele para
                        {
                            Vx = 0;

                        }
                        if (Contexto.Fundo.fase.X < 0) // se o fundo estiver no 0 ele para
                        {
                            if (individuo.X <= H / 80) // se o individuo estiver menor ou igual a 13 ele começa a ir pra esquerda (fundo)
                            {
                                Contexto.Fundo.fase.X += H / 130; // = 8
                            }
                            //tirar o fundo do vacuo
                            if (Contexto.Fundo.fase.X >= 0)
                            {
                                Contexto.Fundo.fase.X -= H / 130; // = 8
                            }
                        }

                        PARADO = false;
                        ANDANDO = true;
                        CORRENDO = false;
                    }

                    //Correndo ESQUERDA
                    else if (!Keyboard.GetState().IsKeyDown(Keys.D) && Keyboard.GetState().IsKeyDown(Keys.A) && Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO && !DESCANSANDO && !COLIDINDOesquerda && !HIT1 && !HIT2 && !AGACHADOHIT)
                    {
                        //atualizando o frame parado
                        frameparado1.X = 0;
                        frameparado1.Y = 0;
                        frameparado2.X = 0;
                        frameparado2.Y = 0;

                        //gastando a energia
                        if (energia > 0)
                            energia -= 3;

                        //mov ESQUERDA
                        if (individuo.X > 0) // se o individuo estiver maior que 0 ele pode correr pra esquerda
                        {
                            Vx = -H / 54; // = 20
                        }
                        else if (individuo.X <= 0) // se colidir com o começo ele para
                        {
                            Vx = 0;

                        }
                        if (Contexto.Fundo.fase.X < 0) // se o fundo estiver no 0 ele para
                        {
                            if (individuo.X <= H / 80) // se o individuo estiver menor ou igual a 13 ele começa a ir pra esquerda (fundo)
                            {
                                Contexto.Fundo.fase.X += H / 54; // = 20
                            }
                            //tirar o fundo do vacuo
                            if (Contexto.Fundo.fase.X >= 0)
                            {
                                Contexto.Fundo.fase.X -= H / 54; // = 20
                            }
                        }



                        PARADO = false;
                        ANDANDO = false;
                        CORRENDO = true;
                    }

                    //desabilitar lado
                    else if (Keyboard.GetState().IsKeyDown(Keys.D) && !Keyboard.GetState().IsKeyDown(Keys.A) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO && !HIT1 && !HIT2 && !AGACHADOHIT)
                    {
                        DIREITA = true;
                        ESQUERDA = false;
                    }



                    if (PULANDOandando)
                    {
                        //mov ESQUERDA
                        if (individuo.X > 0) // se o individuo estiver maior que 0 ele pode correr pra esquerda
                        {
                            Vx = -H / 130; // = 8
                        }
                        else if (individuo.X <= 0) // se colidir com o começo ele para
                        {
                            Vx = 0;

                        }
                        if (Contexto.Fundo.fase.X < 0) // se o fundo estiver no 0 ele para
                        {
                            if (individuo.X <= H / 80) // se o individuo estiver menor ou igual a 13 ele começa a ir pra esquerda (fundo)
                            {
                                Contexto.Fundo.fase.X += H / 130; // = 8
                            }
                            //tirar o fundo do vacuo
                            if (Contexto.Fundo.fase.X >= 0)
                            {
                                Contexto.Fundo.fase.X -= H / 130; // = 8
                            }
                        }
                    }

                    if (PULANDOcorrendo)
                    {
                        //mov ESQUERDA
                        if (individuo.X > 0) // se o individuo estiver maior que 0 ele pode correr pra esquerda
                        {
                            Vx = -H / 54; // = 20
                        }
                        else if (individuo.X <= 0) // se colidir com o começo ele para
                        {
                            Vx = 0;

                        }
                        if (Contexto.Fundo.fase.X < 0) // se o fundo estiver no 0 ele para
                        {
                            if (individuo.X <= H / 80) // se o individuo estiver menor ou igual a 13 ele começa a ir pra esquerda (fundo)
                            {
                                Contexto.Fundo.fase.X += H / 54; // = 20
                            }
                            //tirar o fundo do vacuo
                            if (Contexto.Fundo.fase.X >= 0)
                            {
                                Contexto.Fundo.fase.X -= H / 54; // = 20
                            }
                        }
                    }
                }//fim esquerda##

                //PERSONAGEM - > SPRITES E POSIÇÃO (DRAW / UPDATE)
                //PERSONAGEM
                if (DIREITA) // olhando pra direita
                {
                    if (!COMBATE) // fora de combate
                    {
                        if (PARADO)
                        {
                            //frame
                            FRAMESparado1();
                            //tamanho do personagem
                            individuo.Width = W / 22;
                        }
                    }
                    else if (COMBATE) //dentro de combate
                    {
                        if (PARADO)
                        {
                            //frame
                            FRAMESparado2();
                            //tamanho do personagem
                            individuo.Width = W / 11;
                        }
                    }
                    if (ANDANDO)
                    {
                        //frame
                        FRAMESmovendo();
                        //tamanho do personagem
                        individuo.Width = W / 13;

                    }

                    if (CORRENDO)
                    {
                        //frame
                        FRAMESmovendo();
                        //tamanho do personagem
                        individuo.Width = W / 9 + W / 120; //16
                    }

                    if (PULANDOparado)
                    {
                        //frame
                        if (!ATACANDO)
                        {
                            FRAMESpular(W, H);
                        }

                        //tamanho do personagem
                        individuo.Width = W / 10;
                    }

                    if (PULANDOandando)
                    {

                        //frame
                        if (!ATACANDO)
                        {
                            FRAMESpular(W, H);
                        }



                        //tamanho do personagem
                        individuo.Width = W / 10;
                    }

                    if (PULANDOcorrendo)
                    {

                        //frame
                        if (!ATACANDO)
                        {
                            FRAMESpular(W, H);
                        }



                        //tamanho do personagem
                        individuo.Width = W / 9;
                    }

                }//fim da direita

                if (ESQUERDA) // olhando pra esquerda
                {
                    if (!COMBATE) // fora de combate
                    {
                        if (PARADO)
                        {
                            //frame
                            FRAMESparado1E();
                            //tamanho do personagem
                            individuo.Width = W / 18;
                        }
                    }
                    else if (COMBATE)
                    {
                        if (PARADO) // em combate
                        {
                            //frame
                            FRAMESparado2E();
                            //tamanho do personagem
                            individuo.Width = W / 11;
                        }
                    }
                    if (ANDANDO)
                    {
                        //frame
                        FRAMESmovendoE();
                        //tamanho do personagem
                        individuo.Width = W / 13;

                    }

                    if (CORRENDO)
                    {
                        //frame
                        FRAMESmovendoE();
                        //tamanho do personagem
                        individuo.Width = W / 9 + W / 120; //16
                    }

                    if (PULANDOparado)
                    {
                        //frame
                        if (!ATACANDO)
                        {
                            FRAMESpularE(W, H);
                        }

                        //tamanho do personagem
                        individuo.Width = W / 10;
                    }

                    if (PULANDOandando)
                    {

                        //frame
                        if (!ATACANDO)
                        {
                            FRAMESpularE(W, H);
                        }



                        //tamanho do personagem
                        individuo.Width = W / 10;
                    }

                    if (PULANDOcorrendo)
                    {

                        //frame
                        if (!ATACANDO)
                        {
                            FRAMESpularE(W, H);
                        }



                        //tamanho do personagem
                        individuo.Width = W / 9;
                    }
                }//fim da direita
            } // FIM DO SENDO AGARRADO / PARALIZADO (é dizer q o personagem n pode se mecher)
        }//fim do MOV

        //Quando tomar um hit, parar tudo e mostrar tomando hit
        public void HITfunçao(int W, int H)
        {
            //HIT
            //HIT
            //PERSONAGEM TOMA HIT
            if (!PULANDOandando && !PULANDOcorrendo && !PULANDOparado && (HIT1 || HIT2 || AGACHADOHIT))
            {
                DEFENDENDO = false;
                PARADO = false;
                ATACANDO = false;
                ANDANDO = false;
                AGACHADO = false;
                CORRENDO = false;
                SACARARMA = false;
                //
                COMBO1 = false;
                COMBO2 = false;
                COMBO1adaga = false;
                COMBO1espada2m = false;
                COMBO1tridente = false;
                COMBO2espada2m = false;
                COMBO2tridente = false;
                ATIRAR1arco = false;
                ATIRAR2arco = false;
                ATIRAR3arco = false;
                ATIRAR4arco = false;
                
                PARTE1 = false;
                PARTE1_1tridente = false;
                PARTE1_2tridente = false;
                PARTE1adaga = false;
                PARTE1espada2m = false;
                PARTE2 = false;
                PARTE2adaga = false;
                PARTE2espada2m = false;
                PARTE2tridente = false;
                PARTE3 = false;
                PARTE3adaga = false;
                PARTE3espada2m = false;
                PARTE3tridente = false;
                PARTE4 = false;
                PARTE4adaga = false;
                PARTE4espada2m = false;
                PARTE4tridente = false;

            }

            if (HIT1)
            {
                individuo.Width = W / 9;
                //MAO
                if (JANELA.J.MAOselect && DIREITA)
                {
                    frameHIT.X++;
                    if (frameHIT.X >= SpriteSheetHIT1maos.X)
                    {
                        frameHIT.X = 0;
                        frameHIT.Y++;
                    }
                    if (frameHIT.X >= SpriteSheetHIT1maos.X - 1 && frameHIT.Y >= 3)
                    {
                        frameHIT.X = 0;
                        frameHIT.Y = 0;
                        HIT1 = false;
                        PARADO = true;
                    }
                }
                if (JANELA.J.MAOselect && ESQUERDA)
                {
                    frameHIT.X--;
                    if (frameHIT.X <= -1)
                    {
                        frameHIT.X = 7;
                        frameHIT.Y++;
                    }
                    if (frameHIT.X <= 0 && frameHIT.Y >= 3)
                    {
                        frameHIT.X = 7;
                        frameHIT.Y = 0;
                        HIT1 = false;
                        PARADO = true;
                    }
                }
                //ADAGA
            }
            if (HIT2)
            {
                individuo.Width = W / 9;
                //MAO
                if (JANELA.J.MAOselect && DIREITA)
                {
                    frameHIT.X++;
                    if (frameHIT.X >= SpriteSheetHIT2maos.X)
                    {
                        frameHIT.X = 0;
                        frameHIT.Y++;
                    }
                    if (frameHIT.X >= SpriteSheetHIT2maos.X - 1 && frameHIT.Y >= 3)
                    {
                        frameHIT.X = 0;
                        frameHIT.Y = 0;
                        HIT2 = false;
                        PARADO = true;
                    }
                }
                if (JANELA.J.MAOselect && ESQUERDA)
                {
                    frameHIT.X--;
                    if (frameHIT.X <= -1)
                    {
                        frameHIT.X = 7;
                        frameHIT.Y++;
                    }
                    if (frameHIT.X <= 0 && frameHIT.Y >= 3)
                    {
                        frameHIT.X = 7;
                        frameHIT.Y = 0;
                        HIT2 = false;
                        PARADO = true;
                    }
                }
                //ADAGA
            }
            if (AGACHADOHIT)
            {
                individuo.Width = W / 4;
                if (!JANELA.J.MAOselect)
                {
                    HIT2 = true;
                    AGACHADOHIT = false;
                }
                //MAO
                if (JANELA.J.MAOselect)
                {
                    if (DIREITA)
                    {
                        frameHIT.X++;
                        if (frameHIT.X >= SpriteSheetagachadoHITmaos.X)
                        {
                            frameHIT.X = 0;
                            frameHIT.Y++;
                        }
                        if (frameHIT.X >= SpriteSheetagachadoHITmaos.X - 2 && frameHIT.Y >= 9)
                        {
                            frameHIT.X = 0;
                            frameHIT.Y = 0;
                            AGACHADOHIT = false;
                            PARADO = true;
                        }
                    }

                    if (ESQUERDA)
                    {
                        frameHIT.X--;
                        if (frameHIT.X <= -1)
                        {
                            frameHIT.X = 7;
                            frameHIT.Y++;
                        }
                        if (frameHIT.X <= 1 && frameHIT.Y >= 9)
                        {
                            frameHIT.X = 7;
                            frameHIT.Y = 0;
                            AGACHADOHIT = false;
                            PARADO = true;
                        }
                    }
                }
                //ADAGA
            }
           
        }


        public void GERADORdeCLONES(Personagem P1)
        {
            Personagem clone = new Personagem();

            //pegando apenas a posição de imagem travada

            //atualizar posiçao
            clone.individuo.X = P1.individuo.X;
            clone.individuo.Y = P1.individuo.Y;
            
            clone.individuo.Width = P1.individuo.Width;
            clone.individuo.Height = P1.individuo.Height;
            clone.Vx = P1.individuo.X + (-Contexto.Fundo.fase.X); // posiçao do jogador + a posição mapa = posição universal
            clone.Vy = P1.individuo.Y + (-Contexto.Fundo.fase.Y);

            //boleaveis
            clone.DIREITA = P1.DIREITA;
            clone.ESQUERDA = P1.ESQUERDA;
            clone.AGACHADO = P1.AGACHADO;
            clone.ATACANDO = P1.ATACANDO;
            clone.PARADO = P1.PARADO;
            clone.COMBATE = P1.COMBATE;
            clone.PULANDOparado = P1.PULANDOparado;
            clone.PULANDOandando = P1.PULANDOandando;
            clone.PULANDOcorrendo = P1.PULANDOcorrendo;
            clone.ANDANDO = P1.ANDANDO;
            clone.CORRENDO = P1.CORRENDO;
            clone.PARTE1 = P1.PARTE1;
            clone.PARTE2 = P1.PARTE2;
            clone.PARTE3 = P1.PARTE3;
            clone.PARTE4 = P1.PARTE4;
            clone.COMBO1 = P1.COMBO1;
            clone.COMBO2 = P1.COMBO2;
            clone.DEFENDENDO = P1.DEFENDENDO;
            clone.HIT1 = P1.HIT1;
            clone.HIT2 = P1.HIT2;
            clone.AGACHADOHIT = P1.AGACHADOHIT;
            clone.SACARARMA = P1.SACARARMA;
            //armas
            clone.PARTE1adaga = P1.PARTE1adaga;
            clone.PARTE2adaga = P1.PARTE2adaga;
            clone.PARTE3adaga = P1.PARTE3adaga;
            clone.PARTE4adaga = P1.PARTE4adaga;
            clone.COMBO1adaga = P1.COMBO1adaga;

            clone.ATIRAR1arco = P1.ATIRAR1arco;
            clone.ATIRAR2arco = P1.ATIRAR2arco;
            clone.ATIRAR3arco = P1.ATIRAR3arco;
            clone.ATIRAR4arco = P1.ATIRAR4arco;

            clone.PARTE1espada2m = P1.PARTE1espada2m;
            clone.PARTE2espada2m = P1.PARTE2espada2m;
            clone.PARTE3espada2m = P1.PARTE3espada2m;
            clone.PARTE4espada2m = P1.PARTE4espada2m;
            clone.COMBO1espada2m = P1.COMBO1espada2m;
            clone.COMBO2espada2m = P1.COMBO2espada2m;

            clone.PARTE1_1tridente = P1.PARTE1_1tridente;
            clone.PARTE1_2tridente = P1.PARTE1_2tridente;
            clone.PARTE2tridente = P1.PARTE2tridente;
            clone.PARTE3tridente = P1.PARTE3tridente;
            clone.PARTE4tridente = P1.PARTE4tridente;
            clone.COMBO1tridente = P1.COMBO1tridente;
            clone.COMBO2tridente = P1.COMBO2tridente;


            //frame
            clone.frameparado1 = P1.frameparado1; //Marca o frame a ser utilizado
            clone.frameparado2 = P1.frameparado2; //Marca o frame a ser utilizado 
            clone.frameagachar1 = P1.frameagachar1; //Marca o frame a ser utilizado 
            clone.frameagachar2 = P1.frameagachar2; //Marca o frame a ser utilizado 
            clone.framemovendo = P1.framemovendo; //Marca o frame a ser utilizado 
            clone.framepular = P1.framepular; //Marca o frame a ser utilizado
            clone.framedefesa = P1.framedefesa; //Marca o frame a ser utilizado 
            clone.frameHIT = P1.frameHIT; //Marca o frame a ser utilizado 
            clone.frameLUTA = P1.frameLUTA;

            //INT / POSIÇÕES
            clone.POSmapacapturado.X = Contexto.Fundo.fase.X;
            clone.POSmapacapturado.Y = Contexto.Fundo.fase.Y;
            clone.POSp1capturado.X = P1.individuo.X;
            clone.POSp1capturado.Y = P1.individuo.Y;
            clone.vida = P1.vida;

            P1.listaclonePoder.Add(clone);
        }

        public void POSIÇÃOdoCLONE(Personagem P1)
        {
            for (int i = 0; i < P1.listaclonePoder.Count; i++)
            {
                P1.listaclonePoder[i].individuo.X = P1.listaclonePoder[i].Vx + Contexto.Fundo.fase.X; // posição definida (não variável)
                P1.listaclonePoder[i].individuo.Y = P1.listaclonePoder[i].Vy + Contexto.Fundo.fase.Y;

            }
        }

        public void SubirAgua(int WidthTela, int HeightTela, Random aleatório)
        {
            if (Contexto.Fase[0])
            {
                if ((ANDANDO || CORRENDO || ATACANDO))
                {
                    Agua A1 = new Agua();


                    A1.AguaR.Width = HeightTela / 70;
                    A1.AguaR.Height = HeightTela / 70;
                    if (DIREITA)
                    {
                        A1.AguaR.X = individuo.X + individuo.Width;
                        A1.Px = individuo.X + individuo.Width + (-Contexto.Fundo.fase.X); // posiçao do jogar + a posição mapa = posição universal
                        A1.direita = true;
                    }
                    if (ESQUERDA)
                    {
                        A1.AguaR.X = individuo.X;
                        A1.Px = individuo.X + (-Contexto.Fundo.fase.X); // posiçao do jogar + a posição mapa = posição universal
                        A1.esquerda = true;
                    }
                    A1.Py = individuo.Y + individuo.Height - HeightTela / 70 + (-Contexto.Fundo.fase.Y);
                    A1.g = 0;

                    listadeagua.Add(A1);
                }//fim da criação

                if (listadeagua.Count >= 0)
                {
                    for (int i = 0; i < listadeagua.Count; i++)
                    {
                        listadeagua[i].AguaR.X = listadeagua[i].Px + Contexto.Fundo.fase.X + listadeagua[i].Vx; // posição definida (não variável)
                        listadeagua[i].AguaR.Y = listadeagua[i].Py + Contexto.Fundo.fase.Y + listadeagua[i].g + listadeagua[i].Vy;

                        //velocidade gravidade
                        listadeagua[i].g += HeightTela / 300;

                        if (listadeagua[i].Vy == 0)
                        {
                            listadeagua[i].Vy = aleatório.Next(-HeightTela / 20, -HeightTela / 100);
                        }
                        if (listadeagua[i].esquerda)
                        {
                            listadeagua[i].Vx += aleatório.Next(HeightTela / 200, HeightTela / 150);
                        }
                        if (listadeagua[i].direita)
                        {
                            listadeagua[i].Vx -= aleatório.Next(HeightTela / 200, HeightTela / 150);
                        }

                        if (listadeagua[i].AguaR.Intersects(Contexto.Fundo.chao))
                        {
                            listadeagua.Remove(listadeagua[i]);
                        }
                    }//fim do array

                }//fim da mov
            }//fim da fase 1
        }//fim de subir agua

        public void OndasH2O(int WidthTela, int HeightTela)
        {
            ONDAcontagem++;//forma de reprodução da onda

            if (Contexto.Fase[0] && (!PULANDOandando || !PULANDOcorrendo || !PULANDOparado) && ONDAcontagem >= 30 && individuo.Y >= HeightTela - HeightTela / 3 - HeightTela / 30)
            {
                ONDAcontagem = 0;

                OndasdeAgua A1 = new OndasdeAgua();

                //tamanho
                A1.R.Width = HeightTela / 6; // 90 / 2
                A1.R.Height = HeightTela / 13; // 41

                //posição que nasce
                A1.R.X = individuo.X;
                A1.R.Y = meio.Y + meio.Height;

                //posição no mapa
                A1.Px = individuo.X + (-Contexto.Fundo.fase.X);
                A1.Py = meio.Y + meio.Height - HeightTela / 26 + (-Contexto.Fundo.fase.Y);

                //tornando a real
                A1.ONDA = true;

                listadeondadeagua.Add(A1);
            }

            if (Contexto.Fase[0] && listadeondadeagua.Count > 0)//se existir
            {
                for (int i = 0; i < listadeondadeagua.Count; i++)//vezes
                {
                    if (listadeondadeagua[i].ONDA)//caso esteja on
                    {
                        //posição do ponto dela no mapa
                        listadeondadeagua[i].R.X = listadeondadeagua[i].Px + Contexto.Fundo.fase.X;
                        listadeondadeagua[i].R.Y = listadeondadeagua[i].Py + Contexto.Fundo.fase.Y;

                        listadeondadeagua[i].frame.X++;
                        if (listadeondadeagua[i].frame.X > 7)
                        {
                            listadeondadeagua[i].frame.X = 0;
                            listadeondadeagua[i].frame.Y++;
                        }

                        if (listadeondadeagua[i].frame.X == 6 && listadeondadeagua[i].frame.Y == 7) // apagando a onda
                        {
                            listadeondadeagua.Remove(listadeondadeagua[i]);
                        }
                    }
                }
            }

        }//fim da onda

        public void PersonagemGAMEZERADO()
        {
            //personagem
            DIREITA = true;
            PARADO = true;
            COMBATE = false;
            SENDOAGARRADO = false;
            COLIDINDOdireita = false;
            COLIDINDOesquerda = false;

            vida = 200;
            vidaTOTAL = 200;
            energia = 150;
            energiaTOTAL = 150;
            mana = 120;
            manaTOTAL = 120;

            XP = 0;
            XPT = 100;
            LVL = 1;
            leite = 0;
        }//fim do GAMEZERADO

        //criar visual poder
        public void VISUPODER()
        {
            Poder_Visual A1 = new Poder_Visual();

            A1.R.Width = 1;
            A1.R.Height = 1;
            A1.R.X = individuo.X + individuo.Width / 2;
            A1.R.Y = individuo.Y + individuo.Height / 2;
            A1.Px = individuo.X + individuo.Width / 2 + (-Contexto.Fundo.fase.X);
            A1.Py = individuo.Y + individuo.Height / 2 + (-Contexto.Fundo.fase.Y);

            listadevisualPOWER.Add(A1);
        }//fim da criação do visual poder

        public void REMOVERVISUPODER(int WidthTela, int HeightTela)
        {
            if (listadevisualPOWER.Count > 0)
            {
                for (int i = 0; i < listadevisualPOWER.Count; i++)
                {
                    listadevisualPOWER[i].CRESCER(HeightTela);
                    if (listadevisualPOWER[i].R.Width >= WidthTela * 3)//qnd ele sair da tela, o personagem elimina tal visual efeito
                    {
                        listadevisualPOWER.Remove(listadevisualPOWER[i]);
                    }
                }
            }
        }

        // gerar dano
        public void GERARdano(int PosX, int PosY, int PosWidth, int PosHeight, bool D, bool E, int qtd, int W, int H, int opção)
        {
            Dano D1 = new Dano();

            D1.P.X = PosX + PosWidth / 2;
            D1.P.Y = PosY + PosHeight / 2;

            //fazendo dano inimigo
            if (E)
            {
                D1.esquerda = true;
                D1.direita = false;
            }
            if (D)
            {
                D1.direita = true;
                D1.esquerda = false;
            }
            

            if (D1.direita)
            {
                D1.V.X += H / 400;
            }
            if (D1.esquerda)
            {
                D1.V.X -= H / 400;
            }
            D1.V.Y = -H / 60;

            D1.qntd = qtd;

            D1.opç = opção;
            
            // OPÇ 1 = DANO / 2 = HIT / 3 = HEAL / 4 = ESCUDO

            this.listadedano.Add(D1);
        }

        public void PosDANO(int W, int H)
        {
            if (listadedano.Count > 0)
            {
                for (int i = 0; i < listadedano.Count; i++)
                {
                    listadedano[i].contagem++;
                    listadedano[i].delay++;
                    if (listadedano[i].delay >= 3)
                    {
                        listadedano[i].g += H / 400;
                        listadedano[i].delay = 0;
                    }


                    listadedano[i].P.X = (listadedano[i].P.X + listadedano[i].V.X);
                    listadedano[i].P.Y = (listadedano[i].P.Y + listadedano[i].V.Y) + listadedano[i].g;

                    if (listadedano[i].contagem >= 120)
                    {
                        listadedano.Remove(listadedano[i]);
                    }
                }
            }
        }// fim posiçao dano

        public void gerarHUDVidaPerdida(int qtdd)
        {
            VIDAperdida V = new VIDAperdida();

            V.qtdd = qtdd;
            V.R.Width = qtdd;
            V.R.Height = this.BarraVida.Height;
            V.R.X = this.BarraVida.X + this.BarraVida.Width;
            V.R.Y = this.BarraVida.Y;

            this.listavidaperdida.Add(V);
        }//fim gerar vida perdida

        public void POSvidaperdida()
        {
            if (listavidaperdida.Count > 0)
            {
                for (int i = 0; i < listavidaperdida.Count; i++)
                {
                    if (i - 1 < 0)//1°
                    {
                        listavidaperdida[i].R.X = this.BarraVida.X + this.BarraVida.Width;
                    }
                    if (i - 1 >= 0) // se tiver na frente
                    {
                        listavidaperdida[i].R.X = listavidaperdida[i - 1].R.X + listavidaperdida[i - 1].R.Width;
                    }

                    listavidaperdida[i].R.Y = this.BarraVida.Y;
                    listavidaperdida[i].R.Width = listavidaperdida[i].qtdd;
                    listavidaperdida[i].R.Height = this.BarraVida.Height;

                    listavidaperdida[i].contagem++;
                    if (listavidaperdida[i].contagem == 120)
                    {
                        listavidaperdida.Remove(listavidaperdida[i]);
                    }
                }
            }
        }
    }//fim da classe
}
