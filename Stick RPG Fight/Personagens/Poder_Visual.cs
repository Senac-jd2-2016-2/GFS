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
    class Poder_Visual
    {
        public static Poder_Visual p = new Poder_Visual();
        public int Px = 0, Py = 0;
        public Texture2D imgcirculo;
        public Rectangle R = new Rectangle();

        public void CRESCER(int HeightTela)
        {
            Px -= HeightTela / 36; //60
            Py -= HeightTela / 36; //60
            R.Width += HeightTela / 18; //60
            R.Height += HeightTela / 18; //60

            R.X = Px + Contexto.Fundo.fase.X;
            R.Y = Py + Contexto.Fundo.fase.Y;
        }
    }
}
