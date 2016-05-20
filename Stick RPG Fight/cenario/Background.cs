using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stick_RPG_Fight
{
    class Background
    {
        public Texture2D menu00fundo;
        public Texture2D imgfase1, imgfase2, imgfase3, imgfase4;
        public Texture2D imgfundopoder;
        public Rectangle fase = new Rectangle();
        public Rectangle chao = new Rectangle();
        


        public void atualizaçao(Background Fundo, int HeightTela)
        {
            Contexto.Fundo.chao.X = Contexto.Fundo.fase.X;
            Contexto.Fundo.chao.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height + HeightTela / 4 - HeightTela / 3 - 1;
            Contexto.Fundo.chao.Width = Contexto.Fundo.fase.Width;
            Contexto.Fundo.chao.Height = HeightTela / 3 - HeightTela/4;
        }
        
    }
}
