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
    class Menu
    {
        //botao historia
        public Texture2D imghistory;
        public bool HISTORY;
        public bool HISTORYativado;
        public Rectangle HistoryBotao = new Rectangle();
        public Point TamanhoSpritesheethistoryB = new Point(952,281);
        public Point SpritesheethistoryB = new Point(8, 8);
        public Point framehistoryB = new Point(0, 0);

        //combate
        public Texture2D imgcombate;
        public Rectangle CombateBotao = new Rectangle();
        public Point TamanhoSpritesheetcombateB = new Point(1135, 275);
        public Point SpritesheetcombateB = new Point(7, 15);
        public Point framecombateB = new Point(0, 0);
        public bool COMBATE;
        public bool COMBATEativado;

        public void FRAMEhistory(Menu M1)
        {
            M1.framehistoryB.X++;
            if (M1.framehistoryB.X >= M1.SpritesheethistoryB.X)
            {
                M1.framehistoryB.X = 0;
                M1.framehistoryB.Y++;
            }
            if (M1.framehistoryB.X == 6 && M1.framehistoryB.Y == 7)
            {
                M1.framehistoryB.X = 0;
                M1.framehistoryB.Y = 0;
            }
        }

        public void FRAMEcombate(Menu M1)
        {
            M1.framecombateB.X++;
            if (M1.framecombateB.X >= M1.SpritesheetcombateB.X)
            {
                M1.framecombateB.X = 0;
                M1.framecombateB.Y++;
            }
            if (M1.framecombateB.X == 2 && M1.framecombateB.Y == 14)
            {
                M1.framecombateB.X = 0;
                M1.framecombateB.Y = 0;
            }
        }
    }
}
