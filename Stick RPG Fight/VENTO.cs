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
    class VENTO
    {
        public static VENTO V = new VENTO();
        public Texture2D VentoD, VentoE;
        public Point frame = new Point(0, 0), tamanho = new Point(426, 348), spritesheet = new Point(11, 1), PS = new Point(0, 0);
        public Rectangle R = new Rectangle();
        public int Contagem, Vx;
        public bool PODERvento, D, E;

        public void ATIVAR(Personagem P1, int W, int H)
        {
            if (JANELA.J.VENTOselect && P1.mana >= P1.TRINTAporcento)
            {
                P1.mana -= P1.TRINTAporcento;

                VENTO v1 = new VENTO();
                v1.PODERvento = true;
                v1.Contagem = 0;
                if (P1.DIREITA)
                {
                    v1.PS = new Point(P1.individuo.X + P1.individuo.Width + (-Contexto.Fundo.fase.X), P1.individuo.Y + (-Contexto.Fundo.fase.Y));
                    v1.D = true;
                    v1.frame.X = 0;
                    v1.R.X = P1.individuo.X + P1.individuo.Width + (-Contexto.Fundo.fase.X);
                    v1.R.Y = P1.individuo.Y + (-Contexto.Fundo.fase.Y);
                }
                if (P1.ESQUERDA)
                {
                    v1.PS = new Point(P1.individuo.X - P1.individuo.Width + (-Contexto.Fundo.fase.X), P1.individuo.Y + (-Contexto.Fundo.fase.Y));
                    v1.E = true;
                    v1.frame.X = 10;
                    v1.R.X = P1.individuo.X - P1.individuo.Width + (-Contexto.Fundo.fase.X);
                    v1.R.Y = P1.individuo.Y + (-Contexto.Fundo.fase.Y);
                }
                
                
                v1.R.Width = H / 3 + H / 10 - H / 250;//464 = 360 + 108 - 4
                v1.R.Height = H / 3 - H / 90;//348 = 360 - 12
                v1.Vx = 0;
                P1.listavento.Add(v1);
                P1.SENDOAGARRADO = false;
                P1.PODERvento = true;
            }
        }

        public void Funçao(Personagem P1, int W, int H, List<Inimigo> i1)
        {
            for (int i = 0; i < P1.listavento.Count; i++)
            {
                if (P1.PODERvento && P1.listavento.Count > 0)
                {
                    if (JANELA.J.VENTOselect && P1.listavento[i].PODERvento)
                    {
                        //POSIÇÃO
                        P1.listavento[i].R.X = P1.listavento[i].Vx + P1.listavento[i].PS.X + Contexto.Fundo.fase.X;
                        P1.listavento[i].R.Y = P1.listavento[i].PS.Y + Contexto.Fundo.fase.Y;

                        for (int a = 0; a < i1.Count; a++)
                        {
                            if (i1.Count > 0)
                            {
                                if (P1.listavento[i].R.Intersects(i1[a].individuo))
                                {
                                    i1[a].vida -= H / 200;
                                    i1[a].gerarHUDVidaPerdida(H / 200, P1);
                                    P1.GERARdano(i1[a].individuo.X, i1[a].individuo.Y, i1[a].individuo.Width, i1[a].individuo.Height, P1.DIREITA, P1.ESQUERDA, H / 200, W, H, 1); // personagem leva dano (do personagem)
                                    if (P1.listavento[i].D)
                                        i1[a].Px += H / 15; //72
                                    else if (P1.listavento[i].E)
                                        i1[a].Px -= H / 15; //-72
                                }
                            }//

                        }

                        if (P1.listavento[i].D)
                        {
                            P1.listavento[i].Vx += H / 20; //54
                            P1.listavento[i].frame.X++;
                            if (P1.listavento[i].frame.X >= P1.listavento[i].spritesheet.X)
                            {
                                P1.listavento[i].PODERvento = false;
                                P1.listavento.Remove(P1.listavento[i]);
                            }
                        }
                        else if (P1.listavento[i].E)
                        {
                            P1.listavento[i].Vx -= H / 20; //-54
                            P1.listavento[i].frame.X--;
                            if (P1.listavento[i].frame.X <= -1)
                            {
                                P1.listavento[i].PODERvento = false;
                                P1.listavento.Remove(P1.listavento[i]);
                            }
                        }
                        
                    }
                }

                if (P1.listavento.Count == 0)
                {
                    P1.PODERvento = false;
                }
            }
        }//fim funçao

        public void Draw(SpriteBatch s, Personagem P1)
        {
            for (int i = 0; i < P1.listavento.Count; i++)
            {
                if (P1.listavento.Count > 0 && P1.PODERvento && P1.listavento[i].PODERvento)
                {
                    if (P1.listavento[i].D)
                    {
                        s.Draw(V.VentoD, P1.listavento[i].R,  new Rectangle(P1.listavento[i].frame.X * P1.listavento[i].tamanho.X, P1.listavento[i].frame.Y * P1.listavento[i].tamanho.Y,
                                                      P1.listavento[i].tamanho.X, P1.listavento[i].tamanho.Y), Color.White);
                    }
                    if (P1.listavento[i].E)
                    {
                        s.Draw(V.VentoE, P1.listavento[i].R, new Rectangle(P1.listavento[i].frame.X * P1.listavento[i].tamanho.X, P1.listavento[i].frame.Y * P1.listavento[i].tamanho.Y,
                                                     P1.listavento[i].tamanho.X, P1.listavento[i].tamanho.Y), Color.White);
                    }
                }
            }
        }
    }
}
