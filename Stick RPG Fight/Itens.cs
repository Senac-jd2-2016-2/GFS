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
    class Itens
    {
        public Rectangle item = new Rectangle();

        public void CRIARITENS()
        {
            for (int a = 0; a < 3; a++)
            {
                Itens i = new Itens();
                JANELA.J.listadeitens.Add(i);
            }
        }
    }
}
