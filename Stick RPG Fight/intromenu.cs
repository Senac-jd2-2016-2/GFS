using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Content;
using System;

namespace Stick_RPG_Fight
{
    class intromenu
    {
       
        
        public void INTROMENU(bool[] b1, bool Bapply, Rectangle[] B1, Rectangle APPLY, Rectangle Bfull, bool BFULL, GraphicsDeviceManager graphics)
        {
            
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);

           
            if (b1[0])
            {
                graphics.PreferredBackBufferWidth = 1920;
                graphics.PreferredBackBufferHeight = 1080;

            }

            if (b1[1])
            {
                graphics.PreferredBackBufferWidth = 1400;
                graphics.PreferredBackBufferHeight = 900;

            }

            if (b1[2])
            {
                graphics.PreferredBackBufferWidth = 1366;
                graphics.PreferredBackBufferHeight = 768;

            }

            if (b1[3])
            {
                graphics.PreferredBackBufferWidth = 1280;
                graphics.PreferredBackBufferHeight = 960;

            }

            if (b1[4])
            {
                graphics.PreferredBackBufferWidth = 800;
                graphics.PreferredBackBufferHeight = 600;

            }

            for (int atual = 0; atual < B1.Length - 1; atual++) // formula pra colidir com os multiplicados (entre eles e contra qlq outra coisa)
            {
                for (int outro = atual + 1; outro < B1.Length; outro++)
                {
                    if (Mouse.GetState().LeftButton == ButtonState.Pressed && B1[atual].Contains(mousePosition) && !B1[outro].Contains(mousePosition))
                    {
                        b1[atual] = true;
                        b1[outro] = false;
                    }
                    else if (Mouse.GetState().LeftButton == ButtonState.Pressed && !B1[atual].Contains(mousePosition) && B1[outro].Contains(mousePosition))
                    {
                        b1[atual] = false;
                        b1[outro] = true;
                    }

                }
            }

           

            if (BFULL)
            {
                graphics.IsFullScreen = true;
            }
            else
            {
                graphics.IsFullScreen = false;
            }
            
        }
         
    }
}
