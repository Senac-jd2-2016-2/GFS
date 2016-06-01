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
    class RAIO
    {
        public static RAIO r = new RAIO();
        public Texture2D RaioD, RaioE;
        public Point frame = new Point(0, 0), tamanho = new Point(146, 458), spritesheet = new Point(10, 1), PS = new Point(0, 0);
        public Rectangle R = new Rectangle();
        public int Contagem, Vy;
        public bool PODERraio, D, E, AcertouCHAO;

        public void ATIVAR(Personagem P1, int W, int H)
        {
            if (JANELA.J.VENTOselect && P1.mana >= P1.DEZporcento && P1.listaraio.Count <= 0)
            {
                P1.mana -= P1.DEZporcento;

                RAIO r1 = new RAIO();
                r1.PODERraio = true;
                
                if (P1.DIREITA)
                {
                    r1.PS = new Point(P1.individuo.X + P1.individuo.Width + (-Contexto.Fundo.fase.X), (-Contexto.Fundo.fase.Y));
                    r1.D = true;
                    r1.frame.X = 0;
                    r1.R.X = P1.individuo.X + P1.individuo.Width + (-Contexto.Fundo.fase.X);
                    r1.R.Y = (-Contexto.Fundo.fase.Y);
                }
                if (P1.ESQUERDA)
                {
                    r1.PS = new Point(P1.individuo.X - P1.individuo.Width + (-Contexto.Fundo.fase.X), (-Contexto.Fundo.fase.Y));
                    r1.E = true;
                    r1.frame.X = 9;
                    r1.R.X = P1.individuo.X - P1.individuo.Width + (-Contexto.Fundo.fase.X);
                    r1.R.Y = (-Contexto.Fundo.fase.Y);
                }

                r1.Vy = 0;
                r1.R.Width = H / 7 - H / 130;//146 = 154 - 8
                r1.R.Height = H / 3 + H / 11;//458 = 360 + 98
                
                P1.listaraio.Add(r1);
                P1.SENDOAGARRADO = false;
                P1.PODERvento = true;
            }
        }

       

        public void FUNÇAO(Personagem P1, int W, int H, List<Inimigo> i1)
        {
            for (int i = 0; i < P1.listaraio.Count; i++)
            {
                if (P1.PODERraio && P1.listaraio.Count > 0)
                {
                    if (P1.listaraio.Count <= 0)
                    {
                        P1.PODERraio = false;
                    }

                    if (JANELA.J.RAIOselect && P1.listaraio[i].PODERraio)
                    {
                        //POSIÇÃO
                        P1.listaraio[i].R.X = P1.listaraio[i].PS.X + Contexto.Fundo.fase.X;
                        P1.listaraio[i].R.Y = P1.listaraio[i].Vy + P1.listaraio[i].PS.Y + Contexto.Fundo.fase.Y;

                        //acertar inimigo
                        if (P1.listaraio[i].AcertouCHAO)
                        {
                            for (int a = 0; a < i1.Count; a++)
                            {
                                if (P1.listaraio[i].D && P1.listaraio[i].frame.X >= 3 && P1.listaraio[i].R.Intersects(i1[a].individuo))
                                {
                                    i1[a].vida -= H / 53; //20
                                    i1[a].gerarHUDVidaPerdida(H / 53, P1);
                                    P1.GERARdano(i1[a].individuo.X, i1[a].individuo.Y, i1[a].individuo.Width, i1[a].individuo.Height, P1.DIREITA, P1.ESQUERDA, H / 53, W, H, 1); // personagem leva dano (do personagem)
                                }
                                else if (P1.listaraio[i].E && P1.listaraio[i].frame.X <= 6 && P1.listaraio[i].R.Intersects(i1[a].individuo))
                                {
                                    i1[a].vida -= H / 53; //20
                                    i1[a].gerarHUDVidaPerdida(H / 53, P1);
                                    P1.GERARdano(i1[a].individuo.X, i1[a].individuo.Y, i1[a].individuo.Width, i1[a].individuo.Height, P1.DIREITA, P1.ESQUERDA, H / 53, W, H, 1); // personagem leva dano (do personagem)
                                }

                            }
                        }

                        //no ar
                        if (!P1.listaraio[i].R.Intersects(Contexto.Fundo.chao) && !P1.listaraio[i].AcertouCHAO)//sem encostar no chao
                        {
                            P1.listaraio[i].Vy += H / 53; //20
                            if (P1.listaraio[i].D)
                                P1.listaraio[i].frame.X++;
                            else if (P1.listaraio[i].E)
                                P1.listaraio[i].frame.X--;

                            if (P1.listaraio[i].frame.X >= 2 && P1.listaraio[i].D)
                            {
                                P1.listaraio[i].frame.X= 0;
                            }

                            else if (P1.listaraio[i].frame.X <= 7 && P1.listaraio[i].E)
                            {
                                P1.listaraio[i].frame.X = 9;
                            }
                        }
                        if (P1.listaraio[i].R.Intersects(Contexto.Fundo.chao))//sem encostar no chao
                        {
                            P1.listaraio[i].Vy = 0; //para de se mover
                            P1.listaraio[i].PS.Y = Contexto.Fundo.chao.Y - P1.listaraio[i].R.Height + (-Contexto.Fundo.fase.Y);
                            P1.listaraio[i].AcertouCHAO = true;
                            
                        }

                        if (P1.listaraio[i].AcertouCHAO)
                        {
                            if (P1.listaraio[i].D)
                                P1.listaraio[i].frame.X++;
                            else if (P1.listaraio[i].E)
                                P1.listaraio[i].frame.X--;

                            if (P1.listaraio[i].frame.X >= P1.listaraio[i].spritesheet.X && P1.listaraio[i].D)
                            {
                                if (P1.mana >= P1.DEZporcento)
                                {
                                    //criar novo raio ate acabar o mana
                                    P1.mana -= P1.DEZporcento;

                                    RAIO r1 = new RAIO();
                                    r1.PODERraio = true;

                                    if (P1.listaraio[i].D)
                                    {
                                        r1.PS = new Point(P1.listaraio[i].R.X + P1.listaraio[i].R.Width + (-Contexto.Fundo.fase.X), (-Contexto.Fundo.fase.Y));
                                        r1.D = true;
                                        r1.frame.X = 0;
                                        r1.R.X = P1.listaraio[i].R.X + P1.listaraio[i].R.Width + (-Contexto.Fundo.fase.X);
                                        r1.R.Y = (-Contexto.Fundo.fase.Y);
                                    }
                                    if (P1.listaraio[i].E)
                                    {
                                        r1.PS = new Point(P1.listaraio[i].R.X - P1.listaraio[i].R.Width + (-Contexto.Fundo.fase.X), (-Contexto.Fundo.fase.Y));
                                        r1.E = true;
                                        r1.frame.X = 9;
                                        r1.R.X = P1.listaraio[i].R.X - P1.listaraio[i].R.Width + (-Contexto.Fundo.fase.X);
                                        r1.R.Y = (-Contexto.Fundo.fase.Y);
                                    }

                                    r1.Vy = 0;
                                    r1.R.Width = H / 7 - H / 130;//146 = 154 - 8
                                    r1.R.Height = H / 3 + H / 11;//458 = 360 + 98

                                    P1.listaraio.Add(r1);
                                    P1.SENDOAGARRADO = false;
                                    P1.PODERvento = true;
                                }
                                P1.listaraio.Remove(P1.listaraio[i]);
                            }

                            else if (P1.listaraio[i].frame.X <= -1 && P1.listaraio[i].E)
                            {
                                //criar novo raio ate acabar o mana
                                if (P1.mana >= P1.DEZporcento)
                                {
                                    P1.mana -= P1.DEZporcento;

                                    RAIO r1 = new RAIO();
                                    r1.PODERraio = true;

                                    if (P1.listaraio[i].D)
                                    {
                                        r1.PS = new Point(P1.listaraio[i].R.X + P1.listaraio[i].R.Width + (-Contexto.Fundo.fase.X), (-Contexto.Fundo.fase.Y));
                                        r1.D = true;
                                        r1.frame.X = 0;
                                        r1.R.X = P1.listaraio[i].R.X + P1.listaraio[i].R.Width + (-Contexto.Fundo.fase.X);
                                        r1.R.Y = (-Contexto.Fundo.fase.Y);
                                    }
                                    if (P1.listaraio[i].E)
                                    {
                                        r1.PS = new Point(P1.listaraio[i].R.X - P1.listaraio[i].R.Width + (-Contexto.Fundo.fase.X), (-Contexto.Fundo.fase.Y));
                                        r1.E = true;
                                        r1.frame.X = 9;
                                        r1.R.X = P1.listaraio[i].R.X - P1.listaraio[i].R.Width + (-Contexto.Fundo.fase.X);
                                        r1.R.Y = (-Contexto.Fundo.fase.Y);
                                    }

                                    r1.Vy = 0;
                                    r1.R.Width = H / 7 - H / 130;//146 = 154 - 8
                                    r1.R.Height = H / 3 + H / 11;//458 = 360 + 98

                                    P1.listaraio.Add(r1);
                                    P1.SENDOAGARRADO = false;
                                    P1.PODERvento = true;
                                }
                                P1.listaraio.Remove(P1.listaraio[i]);
                            }
                        }

                    }
                }//fim poder
            }//fim multiplicação

            
        }//void
    }
}
