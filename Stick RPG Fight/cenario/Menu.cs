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

        //fundo
        public Texture2D imgintromenu_semtraçado;
        public Texture2D imgintromenu_comtraçado;
        public Texture2D imgpredio_do_P1;

        public void FRAMEhistory()
        {
            framehistoryB.X++;
            if (framehistoryB.X >= SpritesheethistoryB.X)
            {
                framehistoryB.X = 0;
                framehistoryB.Y++;
            }
            if (framehistoryB.X == 6 && framehistoryB.Y == 7)
            {
                framehistoryB.X = 0;
                framehistoryB.Y = 0;
            }
        }

        public void FRAMEcombate()
        {
            framecombateB.X++;
            if (framecombateB.X >= SpritesheetcombateB.X)
            {
                framecombateB.X = 0;
                framecombateB.Y++;
            }
            if (framecombateB.X == 2 && framecombateB.Y == 14)
            {
                framecombateB.X = 0;
                framecombateB.Y = 0;
            }
        }

        public void menu01GAME(int WidthTela, int HeightTela)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);


            if (HistoryBotao.Contains(mousePosition))
            {
                
                framehistoryB.X = 0;
                framehistoryB.Y = 0;
                HistoryBotao.X = 0;
                HistoryBotao.Y = HeightTela / 3 - HeightTela / 30;
                HistoryBotao.Width = WidthTela / 2;
                HistoryBotao.Height = HeightTela / 6;

            }
            else
            {
                FRAMEhistory();
                if (HistoryBotao.Y != HeightTela / 3)
                {
                    HistoryBotao.X = 0;
                    HistoryBotao.Y = HeightTela / 3;
                    HistoryBotao.Width = WidthTela / 3;
                    HistoryBotao.Height = HeightTela / 8;
                    
                }
            }

            //combate
            if (CombateBotao.Contains(mousePosition))
            {

                framecombateB.X = 0;
                framecombateB.Y = 0;
                CombateBotao.X = WidthTela - WidthTela / 2;
                CombateBotao.Y = HeightTela / 3 - HeightTela / 30;
                CombateBotao.Width = WidthTela / 2;
                CombateBotao.Height = HeightTela / 6;


            }
            else
            {
                FRAMEcombate();
                CombateBotao.X = WidthTela - WidthTela / 3;
                CombateBotao.Y = HeightTela / 3;
                CombateBotao.Width = WidthTela / 3;
                CombateBotao.Height = HeightTela / 8;
                
            }
        }
    }
}
