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
    class ESCUDO
    {
        public static ESCUDO e = new ESCUDO();
        public Texture2D img, Bar;
        public Rectangle R = new Rectangle(), Barra = new Rectangle(), BarHudP1 = new Rectangle();
        public int Contagem, Quantidade, Qtotal;


        public void POS(int W, int H, Personagem P1, List<Inimigo> listai1)
        {
            if (JANELA.J.ESCUDOselect && P1.PODER)
            {
                R.Width = (H / 3 - H / 67); //360 - 16 = 344
                R.Height = (H / 3 - H / 67); //360 - 16 = 344
                R.X = P1.individuo.X + P1.individuo.Width / 2 - R.Width / 2;
                R.Y = P1.individuo.Y + P1.individuo.Height/ 2 - R.Width / 2;

                //barra por cima da barra de vida
                Barra.Height = H / 70; //15
                Barra.Width = (int)(((float)(Quantidade) / Qtotal) * R.Width);
                Barra.X = R.X;
                Barra.Y = R.Y - Barra.Height;
                
                
                //se menor
                if (BarHudP1.Width <= P1.BarraVida.Width)
                {
                    BarHudP1.Width = Quantidade;
                    BarHudP1.X = P1.BarraVida.X + P1.BarraVida.Width - BarHudP1.Width;
                }
                //se ela for maior
                if (BarHudP1.Width > P1.BarraVida.Width)
                {
                    BarHudP1.Width = (int)(((float)(Quantidade) / Qtotal) * P1.BarraVida.Width); ;
                    BarHudP1.X = P1.BarraVida.X + P1.BarraVida.Width - BarHudP1.Width;
                }
                BarHudP1.Height = P1.BarraVida.Height;
                BarHudP1.Y = P1.BarraVida.Y;

                Funções(P1, listai1, W, H);
            }
            
        }

        public void Draw(SpriteBatch s, Personagem P1)
        {
            if (JANELA.J.ESCUDOselect && P1.PODER)
            {
                s.Draw(img, R, Color.White);
                s.Draw(Bar, Barra, Color.White);
            }
        }

        public void ATIVAR(Personagem P1)
        {
            if (JANELA.J.ESCUDOselect && P1.mana >= P1.VINTECINTOporcento)
            {
                Quantidade += P1.mana;
                Qtotal = Quantidade;
                Contagem = 0;
                P1.mana = 0; //joga tudo no escudo;
                P1.PODERescudo = true;
                P1.VISUPODER(); // criar efeito especial
                
                Audio.A1.EscudoSom.Play();
            }
            
        }

        public void Funções(Personagem P1, List<Inimigo> listai1, int W, int H)
        {
            if (JANELA.J.ESCUDOselect)
            {
                P1.SENDOAGARRADO = false;
                Contagem++;
                if (Contagem >= 300 || Quantidade <= 0)//caso dê 5 segundos ou acabe a quantidade do escudo
                {
                    Quantidade = 0;
                    Contagem = 0;
                    P1.PODER = false;
                }
                for (int i = 0; i < listai1.Count; i++)
                {
                    if (R.Intersects(listai1[i].meio))//encostar no INIMIGO (todos)
                    {
                        //perde 1 de vida ao encostar
                        listai1[i].vida -= 1;
                        listai1[i].gerarHUDVidaPerdida(1, P1);
                        P1.GERARdano(listai1[i].individuo.X, listai1[i].individuo.Y, listai1[i].individuo.Width, listai1[i].individuo.Height, P1.DIREITA, P1.ESQUERDA, 1, W, H, 1); // personagem leva dano (do personagem)
                        //perde vida do escudo
                        Quantidade -= 1;
                    }

                }
            }
        }
    }
}
