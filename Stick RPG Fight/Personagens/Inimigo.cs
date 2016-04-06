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
    class Inimigo
    {
        //                                i1
        //sprite
        public Texture2D imgParadoi1;
        public Texture2D imgAndarDi1;
        public Texture2D imgAndarEi1;
        //tamanho do sprite
        public Point tamanhoparadoi1 = new Point(225, 383); //Dimensões do sprite
        public Point tamanhoAndari1 = new Point(166, 367); //Dimensões do sprite
        //qnts sprites
        public Point SpriteSheetparadoi1 = new Point(20, 10); //Dimensões da spritesheet
        public Point SpriteSheetAndari1 = new Point(20, 4); //Dimensões da spritesheet
        //frame de posição momentanea do sprite
        public Point frameparadoi1 = new Point(0, 0); //Marca o frame a ser utilizado
        public Point frameAndari1 = new Point(0, 0); //Marca o frame a ser utilizado
        //

        //GERAL DOS RETANGLES
        public Rectangle individuo = new Rectangle();
        public Rectangle cima = new Rectangle();
        public Rectangle pernas = new Rectangle();

        //GERAL int
        public int opç = 1;
        public int life;
        public int energia;
        public int poder;

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

        public bool subindo;
        public bool descendo;

        public int Vx = 0;
        public int Vy = 0;
        public int g = 0; // gravidade

        public void GERARi1(List<Inimigo> listai1, int WidthTela, int HeightTela, Random aleatório)
        {
            Inimigo i1 = new Inimigo(); // gera um novo
            i1.opç = aleatório.Next(1,3);
            if (i1.opç == 1)
            {
                i1.individuo = new Rectangle(Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width + Vx, HeightTela - HeightTela / 3, WidthTela / 14, HeightTela / 4);
                i1.DIREITA = false;
                i1.ESQUERDA = true;
            }
            else if (i1.opç == 2)
            {
                i1.individuo = new Rectangle(Contexto.Fundo.fase.X + Vx - WidthTela / 14, HeightTela - HeightTela / 3, WidthTela / 14, HeightTela / 4);
                i1.DIREITA = true;
                i1.ESQUERDA = false;
            }

            i1.Vx = 0;
            i1.Vy = 0;
            
            listai1.Insert(listai1.Count, i1);
        }

        public void PosiçãoINIMIGO(int WidthTela, int HeightTela)
        {
            //posição no mapa
            if (opç == 1)
            {
                individuo.X = Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width + Vx;
                if (ANDANDO)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 + Vy - HeightTela / 70;
                if (PARADO)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 - HeightTela / 45 + Vy; //27 = 40
            }
            else if (opç == 2)
            {
                individuo.X = Contexto.Fundo.fase.X + Vx - WidthTela / 14;
                if (ANDANDO)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 + Vy - HeightTela / 70;
                if (PARADO)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 - HeightTela / 45 + Vy; //27 = 40
            }
        }

        public void INTELIGENCIA(int WidthTela, int HeightTela, Personagem P1, List<Inimigo> listai1)
        {
            if (!individuo.Intersects(P1.individuo)) // caso nao estejam tocando
            {
                if (individuo.X + individuo.Width < P1.individuo.X && !DIREITA) //se o bot estiver na esquerda do personagem
                {
                    DIREITA = true;
                    ESQUERDA = false;
                    PARADO = false;
                    ANDANDO = true;

                    //frame
                    frameAndari1.X = 19;
                    frameAndari1.Y = 0;
                }
                else if (individuo.X > P1.individuo.X + P1.individuo.Width && !ESQUERDA) //se o bot estiver na direita do personagem
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
            else if (individuo.Intersects(P1.individuo))//se estiver tocando
            {
                PARADO = true;
                DIREITA = false;
                ESQUERDA = false;
                ANDANDO = false;
            }

            for (int atual = 0; atual < listai1.Count - 1; atual++) // formula pra colidir com os multiplicados (entre eles e contra qlq outra coisa)
            {
                for (int outro = atual + 1; outro < listai1.Count; outro++)
                {
                    if (listai1[atual].individuo.X > P1.individuo.X && listai1[atual].individuo.X < listai1[outro].individuo.X && listai1[atual].individuo.Intersects(listai1[outro].individuo))
                    {
                        listai1[outro].PARADO = true;
                        listai1[outro].DIREITA = false;
                        listai1[outro].ESQUERDA = false;
                        listai1[outro].ANDANDO = false;

                    }
                    if (listai1[atual].individuo.X < P1.individuo.X && listai1[atual].individuo.X > listai1[outro].individuo.X && listai1[atual].individuo.Intersects(listai1[outro].individuo))
                    {
                        listai1[outro].PARADO = true;
                        listai1[outro].DIREITA = false;
                        listai1[outro].ESQUERDA = false;
                        listai1[outro].ANDANDO = false;

                    }
                    
                }
            }//fim da colisao
        }

        public void MOV(int WidthTela, int HeightTela, Random aleatório)
        {
            if (PARADO)//PARADO
            {
                individuo.Width = WidthTela / 10;
                individuo.Height = HeightTela / 4 + HeightTela / 27;
                frameparadoi1.X++;
                if (frameparadoi1.X >= SpriteSheetAndari1.X)
                {
                    frameparadoi1.X = 0;
                    frameparadoi1.Y++;
                }
                if (frameparadoi1.X == 6 && frameparadoi1.Y == 9)
                {
                    frameparadoi1.X = 0;
                    frameparadoi1.Y = 0;
                }
            }
            else if (DIREITA && !ESQUERDA)//DIREITA
            {
                Vx += aleatório.Next(HeightTela / 300,HeightTela / 150);
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
            else if (!DIREITA && ESQUERDA)//ESQUERDA
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
            
        }

    }

   
}
