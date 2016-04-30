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
    class Dano
    {
        public int qntd, g;
        public bool direita, esquerda;
        public int contagem = 0, opç, delay = 0;
        
        public Point P = new Point();
        public Point V = new Point(0,0);
    }
}
