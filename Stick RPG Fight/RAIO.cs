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
        public Texture2D Raio;
        public Point frame = new Point(0, 0), tamanho = new Point(146, 458), spritesheet = new Point(10, 1);
        public Rectangle R = new Rectangle();
    }
}
