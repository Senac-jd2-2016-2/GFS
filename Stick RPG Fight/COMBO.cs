using System;
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
    class COMBO
    {
        public static COMBO c = new COMBO();
        public Rectangle R = new Rectangle();
        public Texture2D img;
        public int HITS = 0, contagem = 0, POSx = 0, contagempontuação;
        public bool ATIVO, MOSTRARHIT, PONTUAÇÃO;

        public void TamanhoEatz(int W, int H, Personagem P1)
        {
            R.X = W + POSx;
            //R.Width = W / 5 + H / 200; // 384 + 5; 389
            if (ATIVO)
            {
                //INSTRUÇÃO: ELE VAI SAIR DA ESQUERDA COM 0 width e FICAR DO TAMANHO DA SPRITE, QND ATIVO.. ELE SE ATIVA DANDO SOCO. APOS TANTOS SEGUNDOS ELE DESATIVA
                
                if (R.Width < W / 5 + H / 200)
                {
                    R.Width += H / 25; //43
                    POSx -= H / 25;
                    MOSTRARHIT = false;
                }
                else if (R.Width > W / 5 + H / 200)
                {
                    MOSTRARHIT = true;
                    R.Width = W / 5 + H / 200; // 384 + 5; 389
                    POSx = -(W / 5 + H / 200);
                }
                if (R.Width == W / 5 + H / 200)
                {
                    MOSTRARHIT = true;
                }

                //TEMPO PRA TERMINAR OS COMBOS
                contagem++;
                if (contagem >= 120) // se nao bater em 2 SEGUNDOS, ele termina
                {
                    PONTUAÇÃO = true;
                    contagempontuação++;
                    if (contagempontuação >= 60)
                    {
                        ATIVO = false;
                        contagempontuação = 0;
                        contagem = 0;
                    }
                    if (contagempontuação == 30)
                    {
                        Audio.A1.pop.Play();
                        if (HITS < 10)
                        {
                            P1.qntdcombosrepositório += HITS;
                        }
                        if (HITS >= 10 && HITS < 100)
                        {
                            P1.qntdcombosrepositório += HITS * 2;
                        }
                        if (HITS >= 100)
                        {
                            P1.qntdcombosrepositório += HITS * 3;
                        }

                    }
                    //pra n bugar
                    if (contagempontuação == 31)
                    {
                        HITS = 0;
                    }
                }
            }
            else
            {
                if (R.Width > 0)
                {
                    R.Width -= H / 25;
                    POSx += (H / 25) * 2;
                }
                else if (R.Width < 0)
                {
                    R.Width = 0;
                    POSx = 0;
                }

                MOSTRARHIT = false;
                PONTUAÇÃO = false;
            }
            R.Y = H / 2 - H / 13 + H / 300;
            R.Height = H / 13 + H / 300; //83 + 3 = 86
        }
    }
}
