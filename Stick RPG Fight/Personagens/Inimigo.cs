﻿using Microsoft.Xna.Framework;
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
    class Inimigo
    {
        //                                i1
        //sprite
        public Texture2D imgParadoi1;
        public Texture2D imgAndarDi1;
        public Texture2D imgAndarEi1;

        //D
        public Texture2D imgFacaDi1;
        public Texture2D imgAgacharDi1;
        public Texture2D imgAgacharDEFDi1;
        public Texture2D imgCaidoDi1;
        public Texture2D imgJogarFacaDi1;
        public Texture2D imgDEFDi1;
        public Texture2D imgHit1Di1;
        public Texture2D imgHit2Di1;
        public Texture2D imgHit3Di1;
        public Texture2D imgLevantarDi1;
        //E
        public Texture2D imgFacaEi1;
        public Texture2D imgAgacharEi1;
        public Texture2D imgAgacharDEFEi1;
        public Texture2D imgCaidoEi1;
        public Texture2D imgJogarFacaEi1;
        public Texture2D imgDEFEi1;
        public Texture2D imgHit1Ei1;
        public Texture2D imgHit2Ei1;
        public Texture2D imgHit3Ei1;
        public Texture2D imgLevantarEi1;

        //tamanho do sprite
        public Point tamanhoparadoi1 = new Point(225, 383); //Dimensões do sprite
        public Point tamanhoAndari1 = new Point(166, 367); //Dimensões do sprite

        public Point tamanhoFacai1 = new Point(123, 123); //Dimensões do sprite
        public Point tamanhoAgachari1 = new Point(195, 363); //Dimensões do sprite
        public Point tamanhoAgacharDEFi1 = new Point(214, 363); //Dimensões do sprite
        public Point tamanhoCaidoi1 = new Point(357, 178); //Dimensões do sprite
        public Point tamanhoDEFi1 = new Point(197, 361); //Dimensões do sprite
        public Point tamanhoJogarFacai1 = new Point(260, 389); //Dimensões do sprite
        public Point tamanhoHit1i1 = new Point(193, 362); //Dimensões do sprite
        public Point tamanhoHit2i1 = new Point(221, 365); //Dimensões do sprite
        public Point tamanhoHit3i1 = new Point(343, 361); //Dimensões do sprite
        public Point tamanhoLevantari1 = new Point(355, 359); //Dimensões do sprite

        //qnts sprites
        public Point SpriteSheetparadoi1 = new Point(20, 10); //Dimensões da spritesheet
        public Point SpriteSheetAndari1 = new Point(20, 4); //Dimensões da spritesheet

        public Point tamanhoFacai1 = new Point(8, 3); //Dimensões do spritesheet
        public Point SpriteSheetAgachari1 = new Point(8, 3); //Dimensões do spritesheet
        public Point SpriteSheetAgacharDEFi1 = new Point(8, 3); //Dimensões do spritesheet
        public Point SpriteSheetCaidoi1 = new Point(4, 8); //Dimensões do spritesheet
        public Point SpriteSheetDEFi1 = new Point(8, 3); //Dimensões do spritesheet
        public Point SpriteSheetJogarFacai1 = new Point(8, 8); //Dimensões do spritesheet
        public Point SpriteSheetHit1i1 = new Point(9, 3); //Dimensões do spritesheet
        public Point SpriteSheetHit2i1 = new Point(9, 3); //Dimensões do spritesheet
        public Point SpriteSheetHit3i1 = new Point(8, 6); //Dimensões do spritesheet
        public Point SpriteSheetLevantari1 = new Point(8, 7); //Dimensões do spritesheet

        //frame de posição momentanea do sprite
        public Point frameparadoi1 = new Point(0, 0); //Marca o frame a ser utilizado
        public Point frameAndari1 = new Point(0, 0); //Marca o frame a ser utilizado
        //FRAME para TUDO (menos parado e andar)
        public Point frameALLi1 = new Point(0, 0); //Marca o frame a ser utilizado
        //

        //GERAL DOS RETANGLES
        public Rectangle individuo = new Rectangle();
        public Rectangle meio = new Rectangle();

        //barra
        public Rectangle VIDA = new Rectangle();
        public Rectangle MANA = new Rectangle();
        public Rectangle ENERGIA = new Rectangle();

        //GERAL int
        public int opç = 1;
        public int vida;
        public int mana;
        public int energia;
        public int vidaT;
        public int manaT;
        public int energiaT;

        // GERAL DOS MOVIMENTOS
        public bool DIREITA = true;
        public bool ESQUERDA;
        public bool AGACHADO;
        public bool ATACANDO;
        public bool PARADO;
        public bool PULANDOparado;
        public bool PULANDOandando;
        public bool PULANDOcorrendo;
        public bool ANDANDO = true;
        public bool CORRENDO;
        public bool DEFENDENDO;

        //hit
        public bool TOMANDOHIT; //tomando hit
        public bool HIT1; //cabeça
        public bool HIT2; //peito
        public bool HIT3; //pernas

        public bool subindo;
        public bool descendo;

        public int Vx = 0;
        public int Vy = 0;
        public int g = 0; // gravidade

        public List<Sangue> listadesangue = new List<Sangue>();
        public List<Agua> listadeagua = new List<Agua>();

        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)//CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)//CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)//CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)//CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        public void GERARi1(List<Inimigo> listai1, int WidthTela, int HeightTela, Random aleatório)
        {
            Inimigo i1 = new Inimigo(); // gera um novo
            i1.opç = aleatório.Next(1,3);
            if (i1.opç == 1)
            {
                i1.individuo = new Rectangle(Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width + Vx, HeightTela - HeightTela / 3, WidthTela / 14, HeightTela / 4);
                i1.meio = new Rectangle(i1.individuo.X + i1.individuo.Width / 4, i1.individuo.Y, i1.individuo.Width / 2, i1.individuo.Height);
                i1.DIREITA = false;
                i1.ESQUERDA = true;
            }
            else if (i1.opç == 2)
            {
                i1.individuo = new Rectangle(Contexto.Fundo.fase.X + Vx - WidthTela / 14, HeightTela - HeightTela / 3, WidthTela / 14, HeightTela / 4);
                i1.meio = new Rectangle(i1.individuo.X + i1.individuo.Width / 4, i1.individuo.Y, i1.individuo.Width / 2, i1.individuo.Height);
                i1.DIREITA = true;
                i1.ESQUERDA = false;
            }

            i1.Vx = 0;
            i1.Vy = 0;
            i1.vidaT = 50;
            i1.manaT = 20;
            i1.energiaT = 100;
            i1.vida = 50;
            
            listai1.Add(i1);
        }

        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        public void PosiçãoINIMIGO(int WidthTela, int HeightTela)
        {
            //posição no mapa
            if (opç == 1)
            {
                individuo.X = Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width + Vx;
                if (ANDANDO)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 + Vy - HeightTela / 70 - HeightTela / 60;
                if (PARADO)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 - HeightTela / 45 + Vy - HeightTela / 60; //27 = 40
            }
            else if (opç == 2)
            {
                individuo.X = Contexto.Fundo.fase.X + Vx - WidthTela / 14;
                if (ANDANDO)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 + Vy - HeightTela / 70 - HeightTela / 60;
                if (PARADO)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 - HeightTela / 45 + Vy - HeightTela / 60; //27 = 40
            }
        }


        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        public void INTELIGENCIA(int WidthTela, int HeightTela, Personagem P1, List<Inimigo> listai1)
        {
            //CASO NAO ENCOSTE
            //CASO NAO ENCOSTE//CASO NAO ENCOSTE
            //CASO NAO ENCOSTE
            //CASO NAO ENCOSTE
            if (!meio.Intersects(P1.meio)) // caso nao estejam tocando
            {
                if (meio.X + meio.Width < P1.meio.X && !DIREITA) //se o bot estiver na esquerda do personagem
                {
                    DIREITA = true;
                    ESQUERDA = false;
                    PARADO = false;
                    ANDANDO = true;

                    //frame
                    frameAndari1.X = 19;
                    frameAndari1.Y = 0;
                }
                else if (meio.X > P1.meio.X + P1.meio.Width && !ESQUERDA) //se o bot estiver na direita do personagem
                {
                    DIREITA = false;
                    ESQUERDA = true;
                    PARADO = false;
                    ANDANDO = true;
                    
                        //frame
                        frameAndari1.X = 0;
                        frameAndari1.Y = 0;
                    
                }
                
            }
            //se estiver tocando
            //se estiver tocando
            //se estiver tocando
            //se estiver tocando
            else if (meio.Intersects(P1.meio))//se estiver tocando
            {
                PARADO = true;
                DIREITA = false;
                ESQUERDA = false;
                ANDANDO = false;
            }

            //COLISAO ENTRE ELES

            // formula pra colidir com os multiplicados (entre eles e contra qlq outra coisa)
            // formula pra colidir com os multiplicados (entre eles e contra qlq outra coisa)
            // formula pra colidir com os multiplicados (entre eles e contra qlq outra coisa)
            // formula pra colidir com os multiplicados (entre eles e contra qlq outra coisa)
            for (int atual = 0; atual < listai1.Count - 1; atual++) // formula pra colidir com os multiplicados (entre eles e contra qlq outra coisa)
            {
                for (int outro = atual + 1; outro < listai1.Count; outro++)
                {
                    if (listai1[atual].meio.X > P1.individuo.X && listai1[atual].meio.X < listai1[outro].meio.X && listai1[atual].meio.Intersects(listai1[outro].meio))
                    {
                        listai1[outro].PARADO = true;
                        listai1[outro].DIREITA = false;
                        listai1[outro].ESQUERDA = false;
                        listai1[outro].ANDANDO = false;

                    }
                    if (listai1[atual].meio.X < P1.individuo.X && listai1[atual].meio.X > listai1[outro].meio.X && listai1[atual].meio.Intersects(listai1[outro].meio))
                    {
                        listai1[outro].PARADO = true;
                        listai1[outro].DIREITA = false;
                        listai1[outro].ESQUERDA = false;
                        listai1[outro].ANDANDO = false;

                    }
                    
                }
            }//fim da colisao

            //empurrar
            //empurrar//empurrar
            //empurrar
            //empurrar
            //empurrar
            if (P1.ATACANDO)
            {
                if (P1.meio.X < meio.X && P1.individuo.Intersects(meio) && P1.PARTE3 && P1.COMBO1 && P1.DIREITA)
                {
                    Vx += HeightTela / 100;
                }
                if (P1.meio.X < meio.X && P1.individuo.Intersects(meio) && P1.PARTE4 && P1.COMBO1 && P1.DIREITA)
                {
                    Vx += HeightTela / 90;
                }

                if (P1.meio.X > meio.X && P1.individuo.Intersects(meio) && P1.PARTE3 && P1.COMBO1 && P1.ESQUERDA)
                {
                    Vx -= HeightTela / 100;
                }
                if (P1.meio.X > meio.X && P1.individuo.Intersects(meio) && P1.PARTE4 && P1.COMBO1 && P1.ESQUERDA)
                {
                    Vx -= HeightTela / 90;
                }
            }
        }

        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        public void MOV(int WidthTela, int HeightTela, Random aleatório)
        {
            meio.X = individuo.X + individuo.Width / 4;
            meio.Y = individuo.Y;
            meio.Width = individuo.Width / 2;
            meio.Height = individuo.Height;
            //PARADO
            //PARADO
            //PARADO
            //PARADO
            //PARADO
            //PARADO
            //PARADO
            //PARADO
            if (PARADO)//PARADO
            {
                individuo.Width = WidthTela / 10;
                individuo.Height = HeightTela / 4 + HeightTela / 27; //tamanho
                frameparadoi1.X++;
                if (frameparadoi1.X >= SpriteSheetAndari1.X)
                {
                    frameparadoi1.X = 0;
                    frameparadoi1.Y++;
                }
                if (frameparadoi1.X == 7 && frameparadoi1.Y == 9)
                {
                    frameparadoi1.X = 0;
                    frameparadoi1.Y = 0;
                }
            }
            //DIREITA
            //DIREITA
            //DIREITA
            //DIREITA
            //DIREITA
            else if (DIREITA && !ESQUERDA)//DIREITA
            {
                //ANDANDO
                //ANDANDO
                //ANDANDO
                //ANDANDO
                //ANDANDO
                //ANDANDO
                //ANDANDO
                if (ANDANDO)
                {
                    Vx += aleatório.Next(HeightTela / 300, HeightTela / 150);
                    individuo.Width = WidthTela / 14;
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                    frameAndari1.X--;
                    if (frameAndari1.X <= -1)
                    {
                        frameAndari1.X = 19;
                        frameAndari1.Y++;
                    }
                    if (frameAndari1.X == 17 && frameAndari1.Y == 3)
                    {
                        frameAndari1.X = 19;
                        frameAndari1.Y = 0;
                    }
                }
                //TOMANDO HIT
                //TOMANDO HIT
                //TOMANDO HIT//TOMANDO HIT
                //TOMANDO HIT
                //TOMANDO HIT
                //TOMANDO HIT
                if (TOMANDOHIT)
                {
                    if (HIT1)//CABEÇA
                    {
                        frameALLi1.X--;
                        if (frameALLi1.X >= SpriteSheetHit1i1.X)
                        {
                            frameALLi1.X = 8;
                            frameALLi1.Y++;
                        }
                        if (frameALLi1.X == 1 && frameALLi1.X == 2)
                        {
                            HIT1 = false;
                            TOMANDOHIT = false;
                        }
                    }
                    if (HIT2)//PEITO
                    {
                        frameALLi1.X--;
                        if (frameALLi1.X >= SpriteSheetHit1i1.X)
                        {
                            frameALLi1.X = 8;
                            frameALLi1.Y++;
                        }
                        if (frameALLi1.X == 1 && frameALLi1.X == 2)
                        {
                            HIT2 = false;
                            TOMANDOHIT = false;
                        }
                    }
                }
            }
            //ESQUERDA
            //ESQUERDA
            //ESQUERDA
            //ESQUERDA
            //ESQUERDA
            else if (!DIREITA && ESQUERDA)//ESQUERDA
            {
                //ANDANDO
                //ANDANDO
                //ANDANDO
                //ANDANDO
                //ANDANDO
                //ANDANDO
                if (ANDANDO)
                {
                    Vx -= aleatório.Next(HeightTela / 140, HeightTela / 130);
                    individuo.Width = WidthTela / 14;
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                    frameAndari1.X++;
                    if (frameAndari1.X >= SpriteSheetAndari1.X)
                    {
                        frameAndari1.X = 0;
                        frameAndari1.Y++;
                    }
                    if (frameAndari1.X == 2 && frameAndari1.Y == 3)
                    {
                        frameAndari1.X = 0;
                        frameAndari1.Y = 0;
                    }
                }
                //TOMANDO HIT
                //TOMANDO HIT
                //TOMANDO HIT
                //TOMANDO HIT
                //TOMANDO HIT
                if (TOMANDOHIT)
                {
                    if (HIT1)//CABEÇA
                    {
                        frameALLi1.X++;
                        if (frameALLi1.X >= SpriteSheetHit1i1.X)
                        {
                            frameALLi1.X = 0;
                            frameALLi1.Y++;
                        }
                        if (frameALLi1.X == 6 && frameALLi1.X == 2)
                        {
                            HIT1 = false;
                            TOMANDOHIT = false;
                        }
                    }
                    if (HIT1)//PEITO
                    {
                        frameALLi1.X++;
                        if (frameALLi1.X >= SpriteSheetHit1i1.X)
                        {
                            frameALLi1.X = 0;
                            frameALLi1.Y++;
                        }
                        if (frameALLi1.X == 6 && frameALLi1.X == 2)
                        {
                            HIT2 = false;
                            TOMANDOHIT = false;
                        }
                    }
                }
            }
            
        }//fim

        //HP
        //HP
        //HP
        //HP
        //HP
        //HP
        //HP
        //HP
        //HP
        //HP
        public void HP(int WidthTela, int HeightTela, List<Inimigo> listai1, Personagem P1)
        {
            VIDA.Width = (int)(((float)(vida) / vidaT) * individuo.Width);

            VIDA.X = individuo.X;
            VIDA.Height = HeightTela / 30;
            VIDA.Y = individuo.Y - HeightTela / 30;

            MANA.Width = (int)(((float)(mana) / manaT) * individuo.Width);

            MANA.X = individuo.X;
            MANA.Height = HeightTela / 30;
            MANA.Y = individuo.Y - HeightTela / 30;

            ENERGIA.Width = (int)(((float)(energia) / energiaT) * individuo.Width);

            ENERGIA.X = individuo.X;
            ENERGIA.Height = HeightTela / 30;
            ENERGIA.Y = individuo.Y - HeightTela / 30;

            
            if (mana < manaT)
            {
                mana++;
            }
            if (energia < energiaT)
            {
                energia++;
            }

            for (int i = 0; i < listai1.Count; i++)
            {
                if (listai1[i].vida <= 0)
                {
                    listai1.Remove(listai1[i]);
                    P1.XP += 10;
                }
            }
        }


        //AGUA]
        //AGUA
        //AGUA
        //AGUA
        //AGUA
        //AGUA
        //AGUA
        //AGUA
        public void SubirAgua(int WidthTela, int HeightTela, Random aleatório, bool fase1)
        {
            if (fase1)
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
                        A1.AguaR.X = individuo.X ;
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
        }//fim





        //SANGRAR
        //SANGRAR
        //SANGRAR
        //SANGRAR
        //SANGRAR
        //SANGRAR
        //SANGRAR
        //SANGRAR
        public void Sangrar(int WidthTela, int HeightTela,Personagem P1, Random aleatório)
        {
            if (P1.individuo.Intersects(meio) && P1.ATACANDO && (P1.individuo.X < individuo.X && P1.DIREITA || P1.individuo.X > individuo.X && P1.ESQUERDA) && !DEFENDENDO)
            {
                if ((P1.DIREITA && ((P1.PARTE1 && P1.frameLUTA.Y >= 1) || (P1.PARTE2 && (P1.frameLUTA.X >= 5 && P1.frameLUTA.Y == 2) || P1.frameLUTA.Y >= 2) || (P1.PARTE3 && (P1.frameLUTA.X >= 4 && P1.frameLUTA.Y == 3) || P1.frameLUTA.Y == 4) || (P1.PARTE4 && P1.frameLUTA.Y >= 3))) || (P1.ESQUERDA && ((P1.PARTE1 && P1.frameLUTA.Y >= 1) || (P1.PARTE2 && (P1.frameLUTA.X <= 2 && P1.frameLUTA.Y == 2) || P1.frameLUTA.Y >= 2) || (P1.PARTE3 && (P1.frameLUTA.X <= 3 && P1.frameLUTA.Y == 3) || P1.frameLUTA.Y == 4) || (P1.PARTE4 && P1.frameLUTA.Y >= 3))))
                {//para sangrar / tomar dano apenas qnd estiver em tal parte do ataque
                    Sangue S1 = new Sangue();



                    S1.sangueR.Width = HeightTela / 100;
                    S1.sangueR.Height = HeightTela / 100;
                    if (P1.PARTE4 && P1.COMBO1)
                    {
                        S1.Vx = individuo.X + individuo.Width / 2 + (-Contexto.Fundo.fase.X); // posiçao do jogar + a posição mapa = posição universal
                        S1.Vy = P1.individuo.Y + P1.individuo.Height / 2 + (-Contexto.Fundo.fase.Y);
                    }
                    if ((P1.PARTE2 || P1.PARTE3) && P1.COMBO1)
                    {
                        S1.Vx = individuo.X + individuo.Width / 2 + (-Contexto.Fundo.fase.X); // posiçao do jogar + a posição mapa = posição universal
                        S1.Vy = P1.individuo.Y + P1.individuo.Height / 3 + (-Contexto.Fundo.fase.Y);
                    }
                    if (P1.PARTE1)
                    {
                        S1.Vx = individuo.X + individuo.Width / 2 + (-Contexto.Fundo.fase.X); // posiçao do jogar + a posição mapa = posição universal
                        S1.Vy = P1.individuo.Y + P1.individuo.Height / 3 + (-Contexto.Fundo.fase.Y);
                    }
                    S1.g = 0;

                    listadesangue.Add(S1);
                }
            }//fim da criação de sangue (SANGRAR)

            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            if (!DEFENDENDO && P1.individuo.Intersects(meio) && P1.ATACANDO && (P1.individuo.X < individuo.X && P1.DIREITA || P1.individuo.X > individuo.X && P1.ESQUERDA))
            {
                //COMBO1
                //COMBO1
                //COMBO1
                //COMBO1
                if (((P1.DIREITA && (P1.PARTE1 && P1.frameLUTA.Y == 1 && P1.frameLUTA.X == 1)) || (P1.ESQUERDA && (P1.PARTE1 && P1.frameLUTA.Y >= 1 && P1.frameLUTA.X == 6))) && !P1.INVERSO)
                {//para sangrar / tomar dano apenas qnd estiver em tal parte do ataque
                    vida-= 10;
                    HIT1 = true;
                    TOMANDOHIT = true;
                    if (P1.DIREITA)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                    }
                    if (P1.ESQUERDA)
                    {
                        frameALLi1.X = 8;
                        frameALLi1.Y = 0;
                    }
                }
                if (((P1.DIREITA && (P1.PARTE2 && P1.frameLUTA.X == 4 && P1.frameLUTA.Y == 2)) || P1.ESQUERDA && (P1.PARTE2 && P1.frameLUTA.X == 2 && P1.frameLUTA.Y == 2)) && P1.COMBO1)
                {
                    vida -= 20;
                    HIT1 = true;
                    TOMANDOHIT = true;
                    if (P1.DIREITA)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                    }
                    if (P1.ESQUERDA)
                    {
                        frameALLi1.X = 8;
                        frameALLi1.Y = 0;
                    }

                }
                if ((P1.DIREITA && (P1.PARTE3 && P1.frameLUTA.X == 4 && P1.frameLUTA.Y == 3) || P1.ESQUERDA && (P1.PARTE3 && (P1.frameLUTA.X == 3 && P1.frameLUTA.Y == 3))) && P1.COMBO1)
                {
                    vida -= 30;
                    HIT2 = true;
                    TOMANDOHIT = true;
                    if (P1.DIREITA)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                    }
                    if (P1.ESQUERDA)
                    {
                        frameALLi1.X = 8;
                        frameALLi1.Y = 0;
                    }
                }
                if ((P1.DIREITA && P1.PARTE4 && P1.frameLUTA.Y == 4 && P1.frameLUTA.X == 0 || P1.ESQUERDA && P1.PARTE4 && P1.frameLUTA.Y == 4 && P1.frameLUTA.X == 7) && P1.COMBO1)
                {
                    vida -= 30;
                    HIT2 = true;
                    TOMANDOHIT = true;
                    if (P1.DIREITA)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                    }
                    if (P1.ESQUERDA)
                    {
                        frameALLi1.X = 8;
                        frameALLi1.Y = 0;
                    }
                }
                //
            }

            if (listadesangue.Count > 0) // se nao for nulo a qntdd
            {
                for (int i = 0; i < listadesangue.Count; i++)
                {
                    
                    listadesangue[i].sangueR.X = listadesangue[i].Vx + Contexto.Fundo.fase.X + listadesangue[i].VariavelX; // posição definida (não variável)
                    listadesangue[i].sangueR.Y = listadesangue[i].Vy + Contexto.Fundo.fase.Y + listadesangue[i].g;
                    //velocidade gravidade
                    listadesangue[i].g += aleatório.Next(HeightTela / 250, HeightTela / 100);
                    
                        //direita ou esquerda
                        if (P1.individuo.Intersects(meio)  && P1.individuo.X < individuo.X && P1.DIREITA)
                        {
                            listadesangue[i].VariavelX += aleatório.Next(HeightTela / 300, HeightTela / 50);
                        }
                        if (P1.individuo.Intersects(meio) && P1.individuo.X > individuo.X && P1.ESQUERDA)
                        {
                            listadesangue[i].VariavelX -= aleatório.Next(HeightTela / 300, HeightTela / 50);
                        }

                        if (listadesangue[i].sangueR.Intersects(Contexto.Fundo.chao) || listadesangue[i].sangueR.Y > Contexto.Fundo.chao.Y + Contexto.Fundo.chao.Height)
                        {
                            listadesangue.Remove(listadesangue[i]);
                        }
                   
                }
            }
        }


    }

   
}
