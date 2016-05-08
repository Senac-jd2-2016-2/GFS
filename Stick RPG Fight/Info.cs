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
        public int contagem, distanciadeletra;
        public bool AMOSTRA, direita, esquerda;
        public string Sair = "Saida", SeleçaoAba = "Encontre os itens que deseja comprar ou aprenda a usá-los!", itemD = "Item disponível!", itemS = "Item selecionado!", itemV = "Item à venda!", comercio = "Compre seus itens", combo = "Aprenda a usar os itens que você tem!";

        public void POS(int W, int H)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            R.Width = H + H / 4 + H / 23;//1080 + (270 + 46) (316) =1396
            R.Height = H / 12 + H / 400; // 90 + 2 = 92
            distanciadeletra = H / 10 + H / 130; //108 + 8 = 116;
            if (AMOSTRA)
            {
                R.Y = mouseState.Y + distanciadeletra; // embaixo do mouse
                if (R.X + R.Width > W)
                {
                    esquerda = true;
                    direita = false;
                }
                else if (R.X + R.Width <= W)
                {
                    esquerda = false;
                    direita = true;
                }

                if (esquerda)
                {
                    R.X = mouseState.X - H + H / 4 + H / 23;
                }
                else if (direita)
                {
                    R.X = mouseState.X;
                }
            }//
        }//
    }// class
}
