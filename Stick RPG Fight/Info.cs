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
    class Info
    {
        public Rectangle R = new Rectangle();
        public static Info I = new Info();
        public Texture2D img;
        public int contagemCC, distanciadeletra, contagemitens;
        public bool AMOSTRAjanelacc, direita, esquerda;
        public string Sair = "Saida", SeleçaoAbaComercio = "Encontre os itens que deseja comprar!", SeleçaoAbaCombo = "Encontre os itens que deseja aprender usar!", itemD = "Item disponível!", itemS = "Item selecionado!", itemV = "Item à venda!", comercio = "Compre seus itens", combo = "Aprenda a usar os itens que você tem!";

        public void POS(int W, int H)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            R.Width = (H + H / 4 + H / 23) / 2;//1080 + (270 + 46) (316) =1396
            R.Height = (H / 12 + H / 400) / 2; // 90 + 2 = 92
            distanciadeletra = (H / 10 + H / 130) / 2; //108 + 8 = 116;

            if (JANELA.J.JANELACOMERCIO || JANELA.J.JANELACOMBO)
            {
                //para conseguir amostrar
                for (int i = 0; i < JANELA.J.listadeitens.Count; i++)
                {
                    //tocar itens
                    if (!JANELA.J.Bcomercio.Contains(mousePosition) && !JANELA.J.Bcombos.Contains(mousePosition) && !JANELA.J.Barmas.Contains(mousePosition) && !JANELA.J.Bpet.Contains(mousePosition) && !JANELA.J.CAPAopç1.Contains(mousePosition) && mouseState.Y < JANELA.J.R.Y + JANELA.J.R.Height)//so mostra qnd encosta nos que estao à vista.
                    {
                        if (JANELA.J.listadeitens[i].item.Contains(mousePosition))
                        {
                            contagemitens++;
                        }
                    }
                }

                if (!JANELA.J.janelaitens.Contains(mousePosition))
                {
                    contagemitens = 0;
                }

                if (JANELA.J.xis.Contains(mousePosition) || JANELA.J.Barmas.Contains(mousePosition) || JANELA.J.Bpet.Contains(mousePosition) || JANELA.J.Bpoderes.Contains(mousePosition) || JANELA.J.Bcomercio.Contains(mousePosition) || JANELA.J.Bcombos.Contains(mousePosition))
                {
                    contagemCC++;
                }
                else if (!JANELA.J.Bcomercio.Contains(mousePosition) && !JANELA.J.Bcombos.Contains(mousePosition) && !JANELA.J.Barmas.Contains(mousePosition) && !JANELA.J.Bpet.Contains(mousePosition) && !JANELA.J.xis.Contains(mousePosition))
                {
                    contagemCC = 0;
                }
                
            }

            if (R.X + R.Width > W)
            {
                esquerda = true;
                direita = false;
            }
            else if (R.X + (R.Width * 2) <= W)
            {
                esquerda = false;
                direita = true;
            }
            R.Y = mouseState.Y + H / 50; // embaixo do mouse


            if (esquerda)
            {
                R.X = mouseState.X - R.Width;
            }
            else if (direita)
            {
                R.X = mouseState.X + H / 50;
            }

            //tempinho pra aparecer
            if (contagemCC >= 30 || contagemitens >= 30)
            {
                AMOSTRAjanelacc = true;
            }
            else if (contagemCC < 30 && contagemitens < 30)
            {
                AMOSTRAjanelacc = false;
            }

        }//
    }// class
}
