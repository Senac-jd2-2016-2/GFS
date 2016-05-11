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
        public bool MENU = true, BOTAO;

        //botao historia
        public Texture2D imgcampanha1;
        public Texture2D imgcampanha2;
        public Texture2D imgcampanha3;
        public bool CAMPANHA;
        public bool CAMPANHAb;
        public Rectangle CampanhaB = new Rectangle();
        
        public static Menu m = new Menu();

        //combate
        public Texture2D imgcombates1;
        public Texture2D imgcombates2;
        public Texture2D imgcombates3;
        public Rectangle CombateB = new Rectangle();
       
        public bool COMBATES;
        public bool COMBATEb;

        //fundo
        public Texture2D imgintromenu_semtraçado;
        public Texture2D imgintromenu_comtraçado;
        public Texture2D imgpredio_do_P1;

        //carregar
        public Rectangle CarregarB = new Rectangle();
        public Texture2D imgcarregar1;
        public Texture2D imgcarregar2;
        public Texture2D imgcarregar3;
        public bool CARREGARb;
       //sair
        public Rectangle SairB = new Rectangle();
        public Texture2D imgsair1;
        public Texture2D imgsair2;

        public Texture2D imgsair3;
        public bool SAIRb;
        //opções
        public Rectangle OpçoesB = new Rectangle();
        public Texture2D imgopçoes1;
        public Texture2D imgopçoes2;
        public Texture2D imgopçoes3;
        public bool OPÇOESb;
        //salvar
        public Rectangle SalvarB = new Rectangle();
        public Texture2D imgsalvar1;
        public Texture2D imgsalvar2;
        public Texture2D imgsalvar3;
        public bool SALVARb;

        public void menu01GAME(int W, int H, Personagem P1, Random A)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);

            JANELA.J.POSIÇÃOCC(W, H);

            CampanhaB.Width = H / 2 + H / 37 ;// 540 + 29 = 569
            CampanhaB.Height = H / 15 + H / 300;// 72 + 3 = 75
            CampanhaB.X = H / 52 + H / 10;

            CombateB.Width = H / 2 + H / 37;// 540 + 29 = 569
            CombateB.Height = H / 15 + H / 300;// 72 + 3 = 75
            CombateB.X = CampanhaB.X;

            CarregarB.Width = H / 2 + H / 37;// 540 + 29 = 569
            CarregarB.Height = H / 15 + H / 300;// 72 + 3 = 75
            CarregarB.X = CampanhaB.X;

            SairB.Width = H / 2 + H / 37;// 540 + 29 = 569
            SairB.Height = H / 15 + H / 300;// 72 + 3 = 75
            SairB.X = CampanhaB.X;

            OpçoesB.Width = H / 2 + H / 37;// 540 + 29 = 569
            OpçoesB.Height = H / 15 + H / 300;// 72 + 3 = 75
            OpçoesB.X = CampanhaB.X;

            SalvarB.Width = H / 2 + H / 37;// 540 + 29 = 569
            SalvarB.Height = H / 15 + H / 300;// 72 + 3 = 75
            SalvarB.X = CampanhaB.X;
            //Y
            CampanhaB.Y = H / 100;
            CombateB.Y = CampanhaB.Y + H / 100 + H / 10;
            CarregarB.Y = CombateB.Y + H / 100 + H / 10;
            SalvarB.Y = CarregarB.Y + H / 100 + H / 10;
            OpçoesB.Y = SalvarB.Y + H / 100 + H / 10;
            SairB.Y = OpçoesB.Y + H / 100 + H / 10;

            
        }
    }
}
