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
            CampanhaB.X = W / 16;

            CombateB.Width = H / 2 + H / 37;// 540 + 29 = 569
            CombateB.Height = H / 15 + H / 300;// 72 + 3 = 75
            CombateB.X = W / 16;

            CarregarB.Width = H / 2 + H / 37;// 540 + 29 = 569
            CarregarB.Height = H / 15 + H / 300;// 72 + 3 = 75
            CarregarB.X = W / 16;

            SairB.Width = H / 2 + H / 37;// 540 + 29 = 569
            SairB.Height = H / 15 + H / 300;// 72 + 3 = 75
            SairB.X = W / 16;

            OpçoesB.Width = H / 2 + H / 37;// 540 + 29 = 569
            OpçoesB.Height = H / 15 + H / 300;// 72 + 3 = 75
            OpçoesB.X = W / 16;

            SalvarB.Width = H / 2 + H / 37;// 540 + 29 = 569
            SalvarB.Height = H / 15 + H / 300;// 72 + 3 = 75
            SalvarB.X = W / 16;
            //Y
            CampanhaB.Y = H / 15 + H / 300;
            CombateB.Y = CampanhaB.Y + (CampanhaB.Height * 2);
            CarregarB.Y = CombateB.Y + (CombateB.Height * 2);
            SalvarB.Y = CarregarB.Y + (CarregarB.Height * 2);
            OpçoesB.Y = SalvarB.Y + (SalvarB.Height * 2);
            SairB.Y = OpçoesB.Y + (OpçoesB.Height * 2);

            
        }
    }
}
