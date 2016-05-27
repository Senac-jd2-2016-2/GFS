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
        public Texture2D imgdefesa1maosE; //defesa em PE (D)

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
        public Texture2D imgdefesa1maosD; //defesa em PE (D)
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
        public Point tamanhoMaosagachar = new Point(323, 452); //Dimensões do sprite
        public Point tamanhoMaosandando = new Point(200, 462); //Dimensões do sprite
        public Point tamanhoMaoscorrendo = new Point(355, 474); //Dimensões do sprite
        public Point tamanhoMaosdefesa1 = new Point(309, 451); //Dimensões do sprite
        public Point tamanhoMaosagachadoHIT = new Point(663, 622); //Dimensões do sprite
        public Point tamanhoMaospular = new Point(284, 454); //Dimensões do sprite

        //LUTA
        //MAOS
        public Point tamanhosoco1Maos = new Point(360, 446); //Dimensões do sprite
        public Point tamanhosoco2C1Maos = new Point(370, 443); //Dimensões do sprite
        public Point tamanhosoco3C1Maos = new Point(403, 458); //Dimensões do sprite
        public Point tamanhojoelhada4C1Maos = new Point(341, 469); //Dimensões do sprite

        //ARMA
        public Point tamanhoSpriteSheetATIRARarco = new Point(694, 683); //Dimensões do sprite
        public Point tamanhoSpriteSheetSACARarco = new Point(626, 692); //Dimensões do sprite
        
        //      sprite qntdd
        //MAOS
        public Point SpriteSheetparado1 = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetparado2 = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetagachar1 = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetagachar2 = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetmovendo = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetpular = new Point(8, 4); //Dimensões da spritesheet
        public Point SpriteSheetdefesa1 = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetagachadoHIT = new Point(10, 8); //Dimensões da spritesheet

        //armas
        public Point SpriteSheetATIRARarco = new Point(9, 7); //Dimensões da spritesheet
        public Point SpriteSheetSACARarco = new Point(8, 8); //Dimensões da spritesheet

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
        public Point framedefesa1 = new Point(0, 0); //Marca o frame a ser utilizado 
        public Point frameagachadoHIT = new Point(0, 0); //Marca o frame a ser utilizado 

        //arma
        public Point frameATIRARarco = new Point(0, 0); //Marca o frame a ser utilizado 
        public Point frameSACARarco = new Point(0, 0); //Marca o frame a ser utilizado 

        //luta
        public Point frameLUTA = new Point(0, 0); //Marca o frame a ser utilizado 

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

        //poderes que se tem
        public bool PODERslow, PODERvento, PODERraio, PODERretroceder, PODERescudo;

        public bool ATAQUELANÇADO;
        public bool SENDOAGARRADO;

        public bool TOMANDOHIT;
        public bool HIT1;
        public bool HIT2;
        public bool HIT3;

        public bool LEVARCONTRAATAQUE;

        public bool UsarArma;

        //LUTA
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

        public bool COLIDINDOdireita;
        public bool COLIDINDOesquerda;
        public bool subindo;
        public bool descendo;

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
        public int TRINTAporcento, DEZporcento, CINQUENTAporcento;

        //Fase 1 cenario
        public int ONDAcontagem = 0;

        public List<Personagem> listaclonePoder = new List<Personagem>();
        public List<Agua> listadeagua = new List<Agua>();
        public List<OndasdeAgua> listadeondadeagua = new List<OndasdeAgua>();
        public List<Poder_Visual> listadevisualPOWER = new List<Poder_Visual>();
        public List<VIDAperdida> listavidaperdida = new List<VIDAperdida>();
        
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
            CINQUENTAporcento = (int)(manaTOTAL / 0.5f);
        }

        public void RPGatualização(int WidthTela, int HeightTela) // atualiza tudo em relação ao RPG (vida / mana / money etc etc)
        {
            if (XP >= XPT)//aumentar de lvl
            {
                XP = 0;
                LVL++;
                XPT = 100 * LVL;
                vidaTOTAL += 10 * LVL;
                manaTOTAL += 5 * LVL;
                energiaTOTAL += 5 * LVL;
                vida = vidaTOTAL;
                mana = manaTOTAL;
                energia = energiaTOTAL;
            }

            XPrec.Width = (int)(((float)(XP) / XPT) * XPTrec.Width);

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

            PORCENTAGENS();
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
            if (frameparado2.X >= SpriteSheetparado2.X)
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
                if (framepular.X >= SpriteSheetpular.X)
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
                if (framepular.X >= SpriteSheetpular.X)
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
            if (frameparado1.X >= SpriteSheetparado1.X)
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
            if (framemovendo.X >= SpriteSheetmovendo.X)
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
                if (Keyboard.GetState().IsKeyDown(Keys.W) && !Keyboard.GetState().IsKeyDown(Keys.D) && !Keyboard.GetState().IsKeyDown(Keys.A) && !AGACHADO && !ATACANDO && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo)
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
                if (Keyboard.GetState().IsKeyDown(Keys.W) && (Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.A)) && !Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !AGACHADO && !ATACANDO && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo)
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
                if (Keyboard.GetState().IsKeyDown(Keys.W) && (Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.A)) && Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !AGACHADO && !ATACANDO && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && energia >= 35)
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
                if (!Keyboard.GetState().IsKeyDown(Keys.D) && !Keyboard.GetState().IsKeyDown(Keys.A) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO)
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

                if (Keyboard.GetState().IsKeyDown(Keys.D) && Keyboard.GetState().IsKeyDown(Keys.A) && !PULANDOparado && !AGACHADO && !ATACANDO && !PULANDOandando && !PULANDOcorrendo) // qnd apertar os dois botoes
                {
                    PARADO = true;
                    ANDANDO = false;
                    CORRENDO = false;
                    Vx = 0;
                }







                if (DIREITA) /// POSIÇÃO (CORPO) estiver olhando para --  DIREITA
                {
                    //andar DIREITA
                    if (Keyboard.GetState().IsKeyDown(Keys.D) && !Keyboard.GetState().IsKeyDown(Keys.A) && (!Keyboard.GetState().IsKeyDown(Keys.LeftShift) || DESCANSANDO) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO && !COLIDINDOdireita)
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

                    else if (Keyboard.GetState().IsKeyDown(Keys.D) && !Keyboard.GetState().IsKeyDown(Keys.A) && Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO && !DESCANSANDO && !COLIDINDOdireita)
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
                    else if (Keyboard.GetState().IsKeyDown(Keys.A) && !Keyboard.GetState().IsKeyDown(Keys.D) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO)
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
                    if (Keyboard.GetState().IsKeyDown(Keys.A) && !Keyboard.GetState().IsKeyDown(Keys.D) && (!Keyboard.GetState().IsKeyDown(Keys.LeftShift) || DESCANSANDO) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO && !COLIDINDOesquerda)
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
                    else if (!Keyboard.GetState().IsKeyDown(Keys.D) && Keyboard.GetState().IsKeyDown(Keys.A) && Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO && !DESCANSANDO && !COLIDINDOesquerda)
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
                    else if (Keyboard.GetState().IsKeyDown(Keys.D) && !Keyboard.GetState().IsKeyDown(Keys.A) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO)
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

            //frame
            clone.frameparado1 = P1.frameparado1; //Marca o frame a ser utilizado
            clone.frameparado2 = P1.frameparado2; //Marca o frame a ser utilizado 
            clone.frameagachar1 = P1.frameagachar1; //Marca o frame a ser utilizado 
            clone.frameagachar2 = P1.frameagachar2; //Marca o frame a ser utilizado 
            clone.framemovendo = P1.framemovendo; //Marca o frame a ser utilizado 
            clone.framepular = P1.framepular; //Marca o frame a ser utilizado
            clone.framedefesa1 = P1.framedefesa1; //Marca o frame a ser utilizado 
            clone.frameagachadoHIT = P1.frameagachadoHIT; //Marca o frame a ser utilizado 
            clone.frameATIRARarco = P1.frameATIRARarco; //Marca o frame a ser utilizado 
            clone.frameSACARarco = P1.frameSACARarco; //Marca o frame a ser utilizado 
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
            
            // OPÇ 1 = DANO / 2 = HIT / 3 = HEAL

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
