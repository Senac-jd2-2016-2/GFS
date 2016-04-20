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
    class Agua
    {
        public Rectangle AguaR = new Rectangle();
        public Rectangle Ondas = new Rectangle();
        public Texture2D imgAgua;
        public Texture2D imgOndas;

        public Point spritesheet = new Point(8, 8);
        public Point tamanhoframes = new Point(90, 41);
        public Point frames = new Point(0,0);

        public int Px;
        public int Vy = 0;
        public int Vx = 0;
        
        public int Py;
        public int g = 0;
        public int contagem = 0;

        public bool direita;
        public bool esquerda;
    }
}
