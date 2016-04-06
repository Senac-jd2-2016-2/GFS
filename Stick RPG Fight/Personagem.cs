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
        public Texture2D imgBARRA;
        public Texture2D imgVIDA;
        public Texture2D imgENERGIA;
        public Texture2D imgMANA;
        public Texture2D imgSOBRE;

        public Rectangle BarraVida = new Rectangle();
        public Rectangle BarraEnergia = new Rectangle();
        public Rectangle BarraMana = new Rectangle();
        public Rectangle Barra = new Rectangle();

        public Texture2D imgSpriteSheetparado1E; // parado fora de combate (E)
        public Texture2D imgSpriteSheetandandoE;// andando (E)
        public Texture2D imgSpriteSheetcorrendoE;//correndo (E)
        public Texture2D imgSpriteSheetpularE; //Pular (E)
        public Texture2D imgSpriteSheetparado2E; // em combate (E)
        
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
        public Point tamanhoSpriteSheetpular = new Point(284, 454); //Dimensões do sprite

        public Point SpriteSheetparado1 = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetparado2 = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetagachar1 = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetagachar2 = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetmovendo = new Point(8, 8); //Dimensões da spritesheet
        public Point SpriteSheetpular = new Point(8, 4); //Dimensões da spritesheet
        
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
        public Rectangle cima = new Rectangle();
        public Rectangle pernas = new Rectangle();

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
        public bool PODER = false;
        public bool DESCANSANDO;

        public bool subindo;
        public bool descendo;

        public int Vx;
        public int Vy;
        public int g = 0; // gravidade
        public int vida;
        public int energia;
        public int mana;

        public int vidaTOTAL;
        public int energiaTOTAL;
        public int manaTOTAL;

        public int escudo;

        public List<Personagem> clonelistaPoder = new List<Personagem>();
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

        //===================================================================================MOV=====================================================================================
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        //===========================================================================================================================================================================
        public void MOV(int WidthTela, int HeightTela, Random aleatório)
        {
            //mov do personagem
            individuo.X += Vx;
            individuo.Y += (Vy + g);

            //chao empurra pra cima
            if (individuo.Intersects(Contexto.Fundo.chao))
            {
                individuo.Y -= HeightTela / 270;
            }

            //subindo tela (impressao)
            if (Contexto.Fundo.fase.Y < 0)
            {
                if (Vy + g < 0)
                {
                    Contexto.Fundo.fase.Y += HeightTela / 100; //10
                }
            }
            else if (Contexto.Fundo.fase.Y > 0)
            {
                Contexto.Fundo.fase.Y = 0;
            }


            //descendo tela (impressao)
            if (Contexto.Fundo.fase.Y > -HeightTela / 10)
            {
                if (Vy + g > 0)
                {
                    Contexto.Fundo.fase.Y -= HeightTela / 100; //10
                }
            }
            else if (Contexto.Fundo.fase.Y < -HeightTela / 10)
            {
                Contexto.Fundo.fase.Y = -HeightTela / 10;
            }


            //pulando parado
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && !Keyboard.GetState().IsKeyDown(Keys.D) && !Keyboard.GetState().IsKeyDown(Keys.A) && !AGACHADO && !ATACANDO && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo)
            {
                PULANDOparado = true;
                PARADO = false;
                CORRENDO = false;
                ANDANDO = false;
                subindo = true;
                Vy = aleatório.Next(-HeightTela / 15, -HeightTela / 25);
                if (ESQUERDA)
                {
                    framepular.X = 7;
                    framepular.Y = 0;
                }
                descendo = false;
            }

            //pulando andando
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && (Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.A)) && !Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !AGACHADO && !ATACANDO && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo)
            {
                PULANDOandando = true;
                PARADO = false;
                CORRENDO = false;
                ANDANDO = false;
                subindo = true;

                Vy = aleatório.Next(-HeightTela / 15, -HeightTela / 25);
                if (ESQUERDA)
                {
                    framepular.X = 7;
                    framepular.Y = 0;
                }
                descendo = false;
            }

            //pulando andando
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && (Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.A)) && Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !AGACHADO && !ATACANDO && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && energia >= 35)
            {
                PULANDOcorrendo = true;
                PARADO = false;
                CORRENDO = false;
                ANDANDO = false;
                subindo = true;
                Vy = aleatório.Next(-HeightTela / 15, -HeightTela / 25);
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
                    g += HeightTela / 300;
                }
                if (descendo && individuo.Intersects(Contexto.Fundo.chao) && !subindo)
                {
                    g = 0;
                    Vy = 0;
                }
                //cair

            }





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
                if (Keyboard.GetState().IsKeyDown(Keys.D) && !Keyboard.GetState().IsKeyDown(Keys.A) && (!Keyboard.GetState().IsKeyDown(Keys.LeftShift) || DESCANSANDO) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO)
                {
                    //atualizando o frame parado
                    frameparado1.X = 0;
                    frameparado1.Y = 0;
                    frameparado2.X = 0;
                    frameparado2.Y = 0;

                    //mov DIREITA
                    if (individuo.X + individuo.Width < WidthTela) //movimento do individuo dentro da tela
                    {
                        Vx = HeightTela / 130; // = 8
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
                            Contexto.Fundo.fase.X -= HeightTela / 130; // = 8
                        }
                        //tirar o fundo do vacuo
                        if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width <= WidthTela)
                        {
                            Contexto.Fundo.fase.X += HeightTela / 130; // = 8
                        }
                    }

                    PARADO = false;
                    ANDANDO = true;
                    CORRENDO = false;
                }

                //correr DIREITA

                else if (Keyboard.GetState().IsKeyDown(Keys.D) && !Keyboard.GetState().IsKeyDown(Keys.A) && Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO && !DESCANSANDO)
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
                    if (individuo.X + individuo.Width < WidthTela) //movimento do individuo dentro da tela
                    {
                        Vx = HeightTela / 54; // = 20
                    }
                    else if (individuo.X + individuo.Width >= WidthTela)//se encostar no final para de correr
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
                            Contexto.Fundo.fase.X -= HeightTela / 54; // = 20
                        }
                        //tirar o fundo do vacuo
                        if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width <= WidthTela)
                        {
                            Contexto.Fundo.fase.X += HeightTela / 54; // = 20
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
                    if (individuo.X + individuo.Width < WidthTela) //movimento do individuo dentro da tela
                    {
                        Vx = HeightTela / 130; // = 8
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
                            Contexto.Fundo.fase.X -= HeightTela / 130; // = 8
                        }
                        //tirar o fundo do vacuo
                        if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width <= WidthTela)
                        {
                            Contexto.Fundo.fase.X += HeightTela / 130; // = 8
                        }
                    }
                }

                if (PULANDOcorrendo)
                {
                    //mov DIREITA
                    if (individuo.X + individuo.Width < WidthTela) //movimento do individuo dentro da tela
                    {
                        Vx = HeightTela / 54; // = 20
                    }
                    else if (individuo.X + individuo.Width >= WidthTela)//se encostar no final para de correr
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
                            Contexto.Fundo.fase.X -= HeightTela / 54; // = 20
                        }
                        //tirar o fundo do vacuo
                        if (Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width <= WidthTela)
                        {
                            Contexto.Fundo.fase.X += HeightTela / 54; // = 20
                        }
                    }
                }

            }//fim direita##









            if (ESQUERDA) /// POSIÇÃO (CORPO) estiver olhando para --  ESQUERDA
            {
                //Andando ESQUERDA
                if (Keyboard.GetState().IsKeyDown(Keys.A) && !Keyboard.GetState().IsKeyDown(Keys.D) && (!Keyboard.GetState().IsKeyDown(Keys.LeftShift) || DESCANSANDO) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO)
                {
                    //atualizando o frame parado
                    frameparado1.X = 0;
                    frameparado1.Y = 0;
                    frameparado2.X = 0;
                    frameparado2.Y = 0;

                    //mov ESQUERDA
                    if (individuo.X > 0) // se o individuo estiver maior que 0 ele pode correr pra esquerda
                    {
                        Vx = -HeightTela / 130; // = 8
                    }
                    else if (individuo.X <= 0) // se colidir com o começo ele para
                    {
                        Vx = 0;

                    }
                    if (Contexto.Fundo.fase.X < 0) // se o fundo estiver no 0 ele para
                    {
                        if (individuo.X <= HeightTela / 80) // se o individuo estiver menor ou igual a 13 ele começa a ir pra esquerda (fundo)
                        {
                            Contexto.Fundo.fase.X += HeightTela / 130; // = 8
                        }
                        //tirar o fundo do vacuo
                        if (Contexto.Fundo.fase.X >= 0)
                        {
                            Contexto.Fundo.fase.X -= HeightTela / 130; // = 8
                        }
                    }

                    PARADO = false;
                    ANDANDO = true;
                    CORRENDO = false;
                }

                //Correndo ESQUERDA
                else if (!Keyboard.GetState().IsKeyDown(Keys.D) && Keyboard.GetState().IsKeyDown(Keys.A) && Keyboard.GetState().IsKeyDown(Keys.LeftShift) && !PULANDOparado && !PULANDOandando && !PULANDOcorrendo && !AGACHADO && !ATACANDO && !DESCANSANDO)
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
                        Vx = -HeightTela / 54; // = 20
                    }
                    else if (individuo.X <= 0) // se colidir com o começo ele para
                    {
                        Vx = 0;

                    }
                    if (Contexto.Fundo.fase.X < 0) // se o fundo estiver no 0 ele para
                    {
                        if (individuo.X <= HeightTela / 80) // se o individuo estiver menor ou igual a 13 ele começa a ir pra esquerda (fundo)
                        {
                            Contexto.Fundo.fase.X += HeightTela / 54; // = 20
                        }
                        //tirar o fundo do vacuo
                        if (Contexto.Fundo.fase.X >= 0)
                        {
                            Contexto.Fundo.fase.X -= HeightTela / 54; // = 20
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
                        Vx = -HeightTela / 130; // = 8
                    }
                    else if (individuo.X <= 0) // se colidir com o começo ele para
                    {
                        Vx = 0;

                    }
                    if (Contexto.Fundo.fase.X < 0) // se o fundo estiver no 0 ele para
                    {
                        if (individuo.X <= HeightTela / 80) // se o individuo estiver menor ou igual a 13 ele começa a ir pra esquerda (fundo)
                        {
                            Contexto.Fundo.fase.X += HeightTela / 130; // = 8
                        }
                        //tirar o fundo do vacuo
                        if (Contexto.Fundo.fase.X >= 0)
                        {
                            Contexto.Fundo.fase.X -= HeightTela / 130; // = 8
                        }
                    }
                }

                if (PULANDOcorrendo)
                {
                    //mov ESQUERDA
                    if (individuo.X > 0) // se o individuo estiver maior que 0 ele pode correr pra esquerda
                    {
                        Vx = -HeightTela / 54; // = 20
                    }
                    else if (individuo.X <= 0) // se colidir com o começo ele para
                    {
                        Vx = 0;

                    }
                    if (Contexto.Fundo.fase.X < 0) // se o fundo estiver no 0 ele para
                    {
                        if (individuo.X <= HeightTela / 80) // se o individuo estiver menor ou igual a 13 ele começa a ir pra esquerda (fundo)
                        {
                            Contexto.Fundo.fase.X += HeightTela / 54; // = 20
                        }
                        //tirar o fundo do vacuo
                        if (Contexto.Fundo.fase.X >= 0)
                        {
                            Contexto.Fundo.fase.X -= HeightTela / 54; // = 20
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
                        individuo.Width = WidthTela / 18;
                    }
                }
                else if (COMBATE) //dentro de combate
                {
                    if (PARADO)
                    {
                        //frame
                        FRAMESparado2();
                        //tamanho do personagem
                        individuo.Width = WidthTela / 11;
                    }
                }
                if (ANDANDO)
                {
                    //frame
                    FRAMESmovendo();
                    //tamanho do personagem
                    individuo.Width = WidthTela / 13;

                }

                if (CORRENDO)
                {
                    //frame
                    FRAMESmovendo();
                    //tamanho do personagem
                    individuo.Width = WidthTela / 9 + WidthTela / 120; //16
                }

                if (PULANDOparado)
                {
                    //frame
                    if (!ATACANDO)
                    {
                        FRAMESpular(WidthTela, HeightTela);
                    }

                    //tamanho do personagem
                    individuo.Width = WidthTela / 10;
                }

                if (PULANDOandando)
                {

                    //frame
                    if (!ATACANDO)
                    {
                        FRAMESpular(WidthTela, HeightTela);
                    }



                    //tamanho do personagem
                    individuo.Width = WidthTela / 10;
                }

                if (PULANDOcorrendo)
                {

                    //frame
                    if (!ATACANDO)
                    {
                        FRAMESpular(WidthTela, HeightTela);
                    }



                    //tamanho do personagem
                    individuo.Width = WidthTela / 9;
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
                        individuo.Width = WidthTela / 18;
                    }
                }
                else if (COMBATE)
                {
                    if (PARADO) // em combate
                    {
                        //frame
                        FRAMESparado2E();
                        //tamanho do personagem
                        individuo.Width = WidthTela / 11;
                    }
                }
                if (ANDANDO)
                {
                    //frame
                    FRAMESmovendoE();
                    //tamanho do personagem
                    individuo.Width = WidthTela / 13;

                }

                if (CORRENDO)
                {
                    //frame
                    FRAMESmovendoE();
                    //tamanho do personagem
                    individuo.Width = WidthTela / 9 + WidthTela / 120; //16
                }

                if (PULANDOparado)
                {
                    //frame
                    if (!ATACANDO)
                    {
                        FRAMESpularE(WidthTela, HeightTela);
                    }

                    //tamanho do personagem
                    individuo.Width = WidthTela / 10;
                }

                if (PULANDOandando)
                {

                    //frame
                    if (!ATACANDO)
                    {
                        FRAMESpularE(WidthTela, HeightTela);
                    }



                    //tamanho do personagem
                    individuo.Width = WidthTela / 10;
                }

                if (PULANDOcorrendo)
                {

                    //frame
                    if (!ATACANDO)
                    {
                        FRAMESpularE(WidthTela, HeightTela);
                    }



                    //tamanho do personagem
                    individuo.Width = WidthTela / 9;
                }
            }//fim da direita
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
            clone.Vx = P1.individuo.X + (-Contexto.Fundo.fase.X); // posiçao do jogar + a posição mapa = posição universal
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

            P1.clonelistaPoder.Add(clone);
        }

        public void POSIÇÃOdoCLONE(Personagem P1)
        {
            for (int i = 0; i < P1.clonelistaPoder.Count; i++)
            {
                P1.clonelistaPoder[i].individuo.X = P1.clonelistaPoder[i].Vx + Contexto.Fundo.fase.X; // posição definida (não variável)
                P1.clonelistaPoder[i].individuo.Y = P1.clonelistaPoder[i].Vy + Contexto.Fundo.fase.Y;
            }
        }
    }
}
