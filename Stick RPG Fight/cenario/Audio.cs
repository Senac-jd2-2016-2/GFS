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
    class Audio
    {
        public Song menusong;
        public Song combatesong;
        public Song PODERsong;
        public SoundEffect COINCOLLECT, GRITOVENCEDOR, RISADA, SUPERCHORO, PLACAREFFECT, pop, LEITEganho, EscudoSom;

        public Rectangle barra = new Rectangle(), pino = new Rectangle(), Vol = new Rectangle();

        public Texture2D imgbarra, imgpino, imgVol1, imgVol2;

        public static Audio A1 = new Audio();

        public static float MasterVolume { get; set; }
        public int VolumeMaximo, POSxClick;
        public bool PRIMEIRAVEZ = true;

        public void POS(int W, int H, bool menu00)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);

            if (PRIMEIRAVEZ)
            {
                VolumeMaximo = 100; //*100 tamanho

                barra.Width = VolumeMaximo;
                barra.Height = 10;

                barra.X = W / 2 + W / 4;
                barra.Y = H / 8;
                PRIMEIRAVEZ = false;
                Audio.MasterVolume = 1.0f;
                pino.X = barra.X + barra.Width;
            }

            if (menu00)
            {
                VolumeMaximo = 100; //*100 tamanho

                barra.Width = VolumeMaximo;
                barra.Height = 10;
                barra.X = W / 2 + W / 4;
                barra.Y = H / 8;
            }
            else
            {
                
                VolumeMaximo = H / 10 - H / 130; //*100 tamanho

                barra.Width = VolumeMaximo;
                barra.Height = H / 100; // 10               (100 x 10)
            }

            pino.Width = 6;
            pino.Height = barra.Height * 3;
            pino.Y = barra.Y - barra.Height;

            Vol.Width = H / 5;
            Vol.Height = H / 5;
            Vol.X = barra.X - Vol.Width;
            Vol.Y = barra.Y + barra.Height / 2 - Vol.Height / 2;
            
            //formula do volume
            if (barra.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                pino.X = mouseState.X;
                if (pino.X > barra.X + barra.Width)
                {
                    pino.X = barra.X + barra.Width;
                }
                if (pino.X < barra.X)
                {
                    pino.X = barra.X;
                }
            }
            if (Vol.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                pino.X = barra.X;
            }
            Audio.MasterVolume = ((float)(pino.X - barra.X) / VolumeMaximo);
            MediaPlayer.Volume = Audio.MasterVolume;
            
        }
    }
}
