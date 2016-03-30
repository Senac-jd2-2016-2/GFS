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
        public Texture2D imgSpriteSheetparado1E; // parado fora de combate (E)
        public Texture2D imgSpriteSheetandandoE;// andando (E)
        public Texture2D imgSpriteSheetcorrendoE;//correndo (E)
        public Texture2D imgSpriteSheetpularE; //Pular (E)
        
        public Texture2D imgSpriteSheetparado1; // parado fora de combate (D)
        public Texture2D imgSpriteSheetparado2; // em combate (D)
        public Texture2D imgSpriteSheetagachar1;//fora de combate (D)
        public Texture2D imgSpriteSheetagachar2;//em combate (D)
        public Texture2D imgSpriteSheetandando;// andando (D)
        public Texture2D imgSpriteSheetcorrendo;//correndo (D)
        public Texture2D imgSpriteSheetdefesa1; //defesa em PE (D)
        public Texture2D imgSpriteSheetagachadoHIT; //tomando hit agachado (D)
        public Texture2D imgSpriteSheetATIRARarco; //atirando com o arco (D)
        public Texture2D imgSpriteSheetSACARarco; //atirando com o arco (D)
        public Texture2D imgSpriteSheetpular; //Pular (D)

        public Point tamanhoSpriteSheetparado1 = new Point(148, 466); //Dimensões do sprite
        public Point tamanhoSpriteSheetparado2 = new Point(283, 452); //Dimensões do sprite
        public Point tamanhoSpriteSheetagachar1 = new Point(353, 474); //Dimensões do sprite
        public Point tamanhoSpriteSheetagachar2 = new Point(323, 452); //Dimensões do sprite
        public Point tamanhoSpriteSheetandando = new Point(200, 462); //Dimensões do sprite
        public Point tamanhoSpriteSheetcorrendo = new Point(355, 474); //Dimensões do sprite
        public Point tamanhoSpriteSheetdefesa1 = new Point(307, 447); //Dimensões do sprite
        public Point tamanhoSpriteSheetagachadoHIT = new Point(682, 651); //Dimensões do sprite
        public Point tamanhoSpriteSheetATIRARarco = new Point(694, 683); //Dimensões do sprite
        public Point tamanhoSpriteSheetSACARarco = new Point(626, 692); //Dimensões do sprite
        public Point tamanhoSpriteSheetpular = new Point(298, 451); //Dimensões do sprite

        public Point SpriteSheetparado1 = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetparado2 = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetagachar1 = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetagachar2 = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetmovendo = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetpular = new Point(8, 7); //Dimensões da spritesheet
        
        public Point SpriteSheetdefesa1 = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetagachadoHIT = new Point(10, 8); //Dimensões da spritesheet
        public Point SpriteSheetATIRARarco = new Point(9, 7); //Dimensões da spritesheet
        public Point SpriteSheetSACARarco = new Point(8, 8); //Dimensões da spritesheet

        public Point frameparado1 = new Point(0, 0); //Marca o frame a ser utilizado
        public Point frameparado2 = new Point(0, 0); //Marca o frame a ser utilizado 
        public Point frameagachar1 = new Point(0, 0); //Marca o frame a ser utilizado 
        public Point frameagachar2 = new Point(0, 0); //Marca o frame a ser utilizado 
        public Point framemovendo = new Point(0, 0); //Marca o frame a ser utilizado 
        public Point framepular = new Point(0, 0); //Marca o frame a ser utilizado
        
        public Point framedefesa1 = new Point(0, 0); //Marca o frame a ser utilizado 
        public Point frameagachadoHIT = new Point(0, 0); //Marca o frame a ser utilizado 
        public Point frameATIRARarco = new Point(0, 0); //Marca o frame a ser utilizado 
        public Point frameSACARarco = new Point(0, 0); //Marca o frame a ser utilizado 

        public Rectangle individuo = new Rectangle();

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

        public bool subindo;
        public bool descendo;

        public int Vx;
        public int Vy;
        public int g = 0; // gravidade

        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================




        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        public void FRAMESpular(int WidthTela, int HeightTela)
        {
            
        }

        public void FRAMESpularE(int WidthTela, int HeightTela)//Esquerda
        {
            
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
            if (frameparado1.X == 5 && frameparado1.Y == 7)
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

        //===================================================================================MOV=====================================================================================
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        public void MOV(int WidthTela, int HeightTela, Random aleatório)
        {
            //mov do personagem
            individuo.X += Vx;
            individuo.Y += (Vy + g); 


            //pulando parado
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && !Keyboard.GetState().IsKeyDown(Keys.D) && !Keyboard.GetState().IsKeyDown(Keys.A) && !AGACHADO && !ATACANDO && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo)
            {
                PULANDOparado = true;
                PARADO = false;
                CORRENDO = false;
                ANDANDO = false;
                if (ESQUERDA)
                {
                    framepular.X = 7;
                    framepular.Y = 6;
                }
            }

            //pulando andando
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && (Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.A)) && !Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !AGACHADO && !ATACANDO && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo)
            {
                PULANDOandando = true;
                PARADO = false;
                CORRENDO = false;
                ANDANDO = false;
                if (ESQUERDA)
                {
                    framepular.X = 7;
                    framepular.Y = 6;
                }
            }

            //pulando andando
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && (Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.A)) && Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !AGACHADO && !ATACANDO && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo)
            {
                PULANDOcorrendo = true;
                PARADO = false;
                CORRENDO = false;
                ANDANDO = false;
                if (ESQUERDA)
                {
                    framepular.X = 7;
                    framepular.Y = 6;
                }
            }

            if (PULANDOparado || PULANDOcorrendo || PULANDOandando) // A T U A L I Z A Ç Ã O
            {
                //em ordem de acontecimentos
                //pula
                if (framepular.Y == 3 && framepular.X == 0 && !subindo && !descendo) // se ele estiver saltando ele sai do chao
                {
                    Vy = aleatório.Next(-HeightTela / 12, -HeightTela / 14);
                    subindo = true;
                }
                //gravidade
                if (subindo || (descendo && (individuo.Y < HeightTela - HeightTela / 3))) // se estiver com um dos dois ativos
                {
                    g += HeightTela/140;
                }
                //cair
                if (subindo && Vy + g <= 0 && !individuo.Intersects(Contexto.Fundo.chao)) //se ele estiver subindo e Vy + g for menor que 0 e não estiver tocando o chao = ele para de subir e começa a descer
                {
                    subindo = false;
                    descendo = true;

                }
                //colide chao
                if (descendo && ((individuo.Y >= HeightTela - HeightTela / 3) || individuo.Intersects(Contexto.Fundo.chao))) // se ele estiver descendo e tocar o chao, ele para de cair
                {
                    g = 0;//ele zera pra poder parar
                    Vy = 0;
                    if (individuo.Y > HeightTela - HeightTela / 3 + 10)
                    {
                        individuo.Y -= HeightTela / 140;//sobe se o personagem passar do chao
                    }
                }

                
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
                if (Keyboard.GetState().IsKeyDown(Keys.D) && !Keyboard.GetState().IsKeyDown(Keys.A) && !Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO)
                {
                    //atualizando o frame parado
                    frameparado1.X = 0;
                    frameparado1.Y = 0;
                    frameparado2.X = 0;
                    frameparado2.Y = 0;

                    
                    //mov DIREITA
                    if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width > WidthTela)
                    {
                        if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width / 6 <= individuo.X + individuo.Width && Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width - Contexto.Fundo.fase.Width / 6 >= individuo.X + individuo.Width)
                        {
                            //movimentação do mapa
                            Contexto.Fundo.fase.X -= 5;
                        }
                    }
                    if (individuo.X + individuo.Width < Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width)//caso passe do final da tela
                    {
                        if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width / 6 > individuo.X + individuo.Width || Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width - Contexto.Fundo.fase.Width / 6 < individuo.X + individuo.Width)
                        {
                            //correndo sozinho
                            Vx = 5;
                        }
                        else if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width / 6 <= individuo.X + individuo.Width && Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width - Contexto.Fundo.fase.Width / 6 >= individuo.X + individuo.Width)
                        {
                            //correndo preso ao fundo
                            Vx = 0;
                        }
                    }
                    else if (individuo.X + individuo.Width >= Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width)
                    {
                        Vx = 0; //para no final da tela
                    }
                    PARADO = false;
                    ANDANDO = true;
                    CORRENDO = false;
                }


                //correr DIREITA
                else if (Keyboard.GetState().IsKeyDown(Keys.D) && !Keyboard.GetState().IsKeyDown(Keys.A) && Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO)
                {
                    //atualizando o frame parado
                    frameparado1.X = 0;
                    frameparado1.Y = 0;
                    frameparado2.X = 0;
                    frameparado2.Y = 0;

                   
                    //mov DIREITA
                    if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width > WidthTela)
                    {
                        if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width / 6 <= individuo.X + individuo.Width && Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width - Contexto.Fundo.fase.Width / 6 >= individuo.X + individuo.Width)
                        {
                            //movimentação do mapa
                            Contexto.Fundo.fase.X -= 15;
                        }
                    }
                    if (individuo.X + individuo.Width < Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width)
                    {
                        if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width / 6 > individuo.X + individuo.Width || Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width - Contexto.Fundo.fase.Width / 6 < individuo.X + individuo.Width)
                        {
                            //correndo sozinho
                            Vx = 15;
                        }
                        else if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width / 6 <= individuo.X + individuo.Width && Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width - Contexto.Fundo.fase.Width / 6 >= individuo.X + individuo.Width)
                        {
                            //correndo preso ao fundo
                            Vx = 0;
                        }
                    }
                    else if (individuo.X + individuo.Width >= Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width)
                    {
                        Vx = 0; //para no final da tela
                    }
                    PARADO = false;
                    ANDANDO = false;
                    CORRENDO = true;
                }

                //desabilitar
                else if (Keyboard.GetState().IsKeyDown(Keys.A) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO)
                {
                    DIREITA = false;
                    ESQUERDA = true;
                }
                
            }//fim direita##









            if (ESQUERDA) /// POSIÇÃO (CORPO) estiver olhando para --  ESQUERDA
            {
                //Andando ESQUERDA
                if (Keyboard.GetState().IsKeyDown(Keys.A) && !Keyboard.GetState().IsKeyDown(Keys.D) && !Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO)
                {
                    //atualizando o frame parado
                    frameparado1.X = 0;
                    frameparado1.Y = 0;
                    frameparado2.X = 0;
                    frameparado2.Y = 0;

                    //mov ESQUERDA
                    if (Contexto.Fundo.fase.X < 5)//TELA
                    {
                        if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width / 6 <= individuo.X && Contexto.Fundo.fase.X + individuo.Width + Contexto.Fundo.fase.Width - Contexto.Fundo.fase.Width / 6 >= individuo.X + individuo.Width)
                        {
                            //movimentação do mapa
                            Contexto.Fundo.fase.X += 5;
                        }
                    }
                    if (individuo.X > Contexto.Fundo.fase.X)//PERSONAGEM
                    {
                        if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width / 6 + 20 >= individuo.X + individuo.Width || Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width - Contexto.Fundo.fase.Width / 6 < individuo.X + individuo.Width)
                        {
                            //correndo sozinho
                            Vx = -5;
                        }
                        else if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width / 6 <= individuo.X + individuo.Width && Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width - Contexto.Fundo.fase.Width / 6 >= individuo.X + individuo.Width)
                        {
                            //correndo preso ao fundo
                            Vx = 0;
                        }
                    }
                    else if (individuo.X <= Contexto.Fundo.fase.X)
                    {
                        Vx = 0; //caso pase do inicio da tela
                    }
                    PARADO = false;
                    ANDANDO = true;
                    CORRENDO = false;
                }

                //Correndo ESQUERDA
                else if (!Keyboard.GetState().IsKeyDown(Keys.D) && Keyboard.GetState().IsKeyDown(Keys.A) && Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO)
                {
                    //atualizando o frame parado
                    frameparado1.X = 0;
                    frameparado1.Y = 0;
                    frameparado2.X = 0;
                    frameparado2.Y = 0;

                    //mov ESQUERDA
                    if (Contexto.Fundo.fase.X < 15)//TELA
                    {
                        if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width / 6 <= individuo.X + individuo.Width && Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width - Contexto.Fundo.fase.Width / 6 >= individuo.X + individuo.Width)
                        {
                            //movimentação do mapa
                            Contexto.Fundo.fase.X += 15;
                        }
                    }
                    if (individuo.X > Contexto.Fundo.fase.X)//PERSONAGEM
                    {
                        if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width / 6 + 20 >= individuo.X + individuo.Width || Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width - Contexto.Fundo.fase.Width / 6 < individuo.X + individuo.Width)
                        {
                            //correndo sozinho
                            Vx = -15;
                        }
                        else if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width / 6 <= individuo.X + individuo.Width && Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width - Contexto.Fundo.fase.Width / 6 >= individuo.X + individuo.Width)
                        {
                            //correndo preso ao fundo
                            Vx = 0;
                        }
                    }
                    else if (individuo.X <= Contexto.Fundo.fase.X)
                    {
                        Vx = 0; //caso pase do inicio da tela
                    }
                    PARADO = false;
                    ANDANDO = false;
                    CORRENDO = true;
                }

                //desabilitar lado
                else if (Keyboard.GetState().IsKeyDown(Keys.D) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO)
                {
                    DIREITA = true;
                    ESQUERDA = false;
                }
            }//fim esquerda##
        }
    }
}
