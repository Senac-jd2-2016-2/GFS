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
    class LEVEL
    {
        public static LEVEL l = new LEVEL();
        public Texture2D sprites;
        public Point tamanho = new Point(425, 164), frame = new Point(0, 0);
        public Rectangle R = new Rectangle();

        public void POS(int W, int H, Personagem P1)
        {
            R.Width = (H / 3 + H / 17 + H / 400) + ((H / 3 + H / 17 + H / 400)/2); //360 + 63 + 2 = 425
            R.Height = (H / 7 + H / 100) + ((H / 7 + H / 100) / 2);//164 = 154 + 10
            R.Y = H / 8;
            R.X = W / 2 - R.Width / 2;

            if (P1.LVL < 10)
            {
                frame.X = 0;
            }
            else if (P1.LVL < 20 && P1.LVL >= 10)
            {
                frame.X = 1;
            }
            else if (P1.LVL < 30 && P1.LVL >= 20)
            {
                frame.X = 2;
            }
            else if (P1.LVL < 40 && P1.LVL >= 30)
            {
                frame.X = 3;
            }
            else if (P1.LVL >= 40)
            {
                frame.X = 4;
            }
        }
        public void DrawLVL(SpriteBatch s)
        {
            s.Draw(l.sprites, l.R,
                                    new Rectangle(l.frame.X * l.tamanho.X, l.frame.Y * l.tamanho.Y,
                                                  l.tamanho.X, l.tamanho.Y),
                                                  Color.White);
        }
    }
}
