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
    class ObjLançado
    {
        public Rectangle OBJ = new Rectangle();
        public int Vx;
        public int Vy;
        public int PosX;
        public int PosY;

        public bool direita;
        public bool esquerda;
        public bool CAINDO;

        //item
        //(FACA)
        public Point frameFACA = new Point(0, 0); //Marca o frame a ser utilizado
        public Point SpriteSheetFacai1 = new Point(8, 3); //Dimensões do spritesheet
        public Point tamanhoFacai1 = new Point(123, 123); //Dimensões do sprite
    }
}
