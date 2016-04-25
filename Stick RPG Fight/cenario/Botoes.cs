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
    class Botoes
    {
        public Rectangle HOMEquadrado = new Rectangle();
        public Rectangle COMERCIOquadrado = new Rectangle();
        public Rectangle COMBOSquadrado = new Rectangle();
        //
        public Texture2D imghomeON;
        public Texture2D imghomeOFF;
        public Texture2D imghomeOFFTP;
        //
        public Texture2D imgcomercioON;
        public Texture2D imgcomercioOFF;
        public Texture2D imgcomercioOFFTP;
        //
        public Texture2D imgcombosON;
        public Texture2D imgcombosOFF;
        public Texture2D imgcombosOFFTP;
        // bool
        public bool HOME;
        public bool HOMEb;
        
        public bool COMERCIOb;

        public bool COMBOSb;
    }
}
