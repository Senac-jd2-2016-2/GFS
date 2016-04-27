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
    class JANELA
    {
        public static JANELA J = new JANELA();

        //parte dos retangulos
        public Rectangle R = new Rectangle();
        public Rectangle xis = new Rectangle();
        public Rectangle CAPAopç1 = new Rectangle();
        public Rectangle Bcomercio = new Rectangle();
        public Rectangle Bcombos = new Rectangle();
        public Rectangle Bpoderes = new Rectangle();
        public Rectangle Barmas = new Rectangle();
        public Rectangle Bpet = new Rectangle();

        //PAUSE
        public Rectangle pauseJANELA = new Rectangle();
        public Rectangle Bsair = new Rectangle();
        public Rectangle Bresume = new Rectangle();

        public Texture2D imgpauseJANELA;
        public Texture2D imgBsair1, imgBsair2, imgBsair3;
        public Texture2D imgBresume1, imgBresume2, imgBresume3, imgFUNDOmenu;

        public Texture2D imgjanelacombo, imgjanelacinzaopç1, imgjanelacomercio, imgbotaoComercioOFF, imgbotaoComercioON;
        public Texture2D imgbotaoPoderesOFF, imgbotaoPoderesON, imgbotaoX, imgbotaoXred;
        public Texture2D imgbotaoArmasOFF, imgbotaoArmasON, imgbotaoCombosOFF, imgbotaoCombosON, imgbotaoPetON, imgbotaoPetOFF;

        public bool JANELACOMBO = false, JANELACOMERCIO = false, ARMAS, COMBOS, PET, PODERES, bXIS, bCOMBO, bCOMERCIO, bARMAS, bPET, bPODERES;
        //pause
        public bool JANELAPAUSE, bSAIR, bRESUME;

        public void ZERARFASE(List<Inimigo> listai1, Personagem P1, Botoes Botao, int W, int H)
        {
            Botao.HOME = true;
            Contexto.Fase1 = false;
            Contexto.Fase2 = false;
            Contexto.Fase3 = false;
            Contexto.Fase4 = false;
            listai1.Clear();
            P1.individuo = new Rectangle(0, H - H / 3, W / 16, W / 4);
            Contexto.Fundo.fase = new Rectangle(0, -H / 10, W * 3, H + H / 10);
            //MediaPlayer.Play(AUDIO.menusong);
        }

        public void FUNÇÕESPAUSE(bool BOTAO, List<Inimigo> listai1, Personagem P1, Botoes Botao, int W, int H)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            if (Mouse.GetState().LeftButton != ButtonState.Pressed) // BOTAO não pressionado
            {
                BOTAO = false;
            }
            //--------------------------------------------------------------------------------
            //BOTAO SAIR
            if (JANELA.J.Bsair.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                BOTAO = true;
                JANELA.J.bSAIR = true;
            }
            if (!JANELA.J.Bsair.Contains(mousePosition))
                JANELA.J.bSAIR = false;
            if (JANELA.J.bSAIR && !BOTAO)
            {
                //posição volta pro começo e os inimigos somem (SAI DA FASE)
                JANELA.J.ZERARFASE(listai1, P1, Botao, W, H);

                JANELA.J.JANELAPAUSE = false;
                JANELA.J.bSAIR = false;
            }
            //BOTAO RESUME
            if (JANELA.J.Bresume.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                BOTAO = true;
                JANELA.J.bRESUME = true;
            }
            if (!JANELA.J.Bresume.Contains(mousePosition))
                JANELA.J.bRESUME = false;
            if (JANELA.J.bRESUME && !BOTAO)
            {
                JANELA.J.JANELAPAUSE = false;
                JANELA.J.bRESUME = false;
                MediaPlayer.Resume();
            }

            POSIÇÃOPAUSE(W, H);
        }

        public void POSIÇÃOPAUSE(int WidthTela, int HeightTela)
        {
            JANELA.J.pauseJANELA.X = WidthTela / 2 - ((HeightTela / 2 + HeightTela / 9 + HeightTela / 150) / 2);
            JANELA.J.pauseJANELA.Y = HeightTela / 2 - ((HeightTela / 5 + HeightTela / 37) / 2);
            JANELA.J.pauseJANELA.Width = HeightTela / 2 + HeightTela / 9 + HeightTela / 150;//540 + 120 + 7 = 667
            JANELA.J.pauseJANELA.Height = HeightTela / 5 + HeightTela / 37;//216 + 29 = 245

            JANELA.J.Bsair.X = HeightTela / 60; //18
            JANELA.J.Bsair.Y = HeightTela / 10 - HeightTela / HeightTela; //108 - 1;
            JANELA.J.Bsair.Width = ((HeightTela / 2 + HeightTela / 9 + HeightTela / 150) / 2) - HeightTela / 52;//313 = 333 - 20
            JANELA.J.Bsair.Height = HeightTela / 18 - HeightTela / HeightTela;//59 (58 - 1)

            JANELA.J.Bresume.X = ((HeightTela / 2 + HeightTela / 9 + HeightTela / 150) / 2) + HeightTela / 350; //333 + 3 = 336;
            JANELA.J.Bresume.Y = HeightTela / 10 - HeightTela / HeightTela; //108 - 1;
            JANELA.J.Bresume.Width = ((HeightTela / 2 + HeightTela / 9 + HeightTela / 150) / 2) - HeightTela / 52;//313 = 333 - 20
            JANELA.J.Bresume.Height = HeightTela / 18 - HeightTela / HeightTela;//59 (58 - 1)
        }

        public void FUNÇÕES(bool BOTAO)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            if (Mouse.GetState().LeftButton != ButtonState.Pressed) // BOTAO não pressionado
            {
                BOTAO = false;
            }

            MediaPlayer.Pause();
            //--------------------------------------------------------------------------------
            //SAIR
            if (JANELA.J.xis.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                BOTAO = true;
                JANELA.J.bXIS = true;
            }
            if (!JANELA.J.xis.Contains(mousePosition))
                JANELA.J.bXIS = false;
            if (JANELA.J.bXIS && !BOTAO)
            {
                JANELA.J.JANELACOMBO = false;
                JANELA.J.JANELACOMERCIO = false;
            }
            //ALTERNAR ENTRE COMBO E COMERCIO DENTRO DA JANELA
            if (JANELA.J.Bcomercio.Contains(mousePosition) && JANELA.J.JANELACOMBO && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                BOTAO = true;
                JANELA.J.bCOMERCIO = true;
            }
            if (!JANELA.J.Bcomercio.Contains(mousePosition))
                JANELA.J.bCOMERCIO = false;
            if (JANELA.J.bCOMERCIO && !BOTAO)
            {
                JANELA.J.JANELACOMBO = false;
                JANELA.J.JANELACOMERCIO = true;
            }
            //ALTERNAR ENTRE COMBO E COMERCIO DENTRO DA JANELA
            if (JANELA.J.Bcombos.Contains(mousePosition) && JANELA.J.JANELACOMERCIO && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                BOTAO = true;
                JANELA.J.bCOMBO = true;
            }
            if (!JANELA.J.Bcombos.Contains(mousePosition))
                JANELA.J.bCOMBO = false;
            if (JANELA.J.bCOMBO && !BOTAO)
            {
                JANELA.J.JANELACOMBO = true;
                JANELA.J.JANELACOMERCIO = false;
            }
            //ARMAS
            if (JANELA.J.Barmas.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                BOTAO = true;
                JANELA.J.bARMAS = true;
            }
            if (!JANELA.J.Barmas.Contains(mousePosition))
                JANELA.J.bARMAS = false;
            if (JANELA.J.bARMAS && !BOTAO)
            {
                JANELA.J.ARMAS = true;
                JANELA.J.PODERES = false;
                JANELA.J.PET = false;
            }
            //PET
            if (JANELA.J.Bpet.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                BOTAO = true;
                JANELA.J.bPET = true;
            }
            if (!JANELA.J.Bpet.Contains(mousePosition))
                JANELA.J.bPET = false;
            if (JANELA.J.bPET && !BOTAO)
            {
                JANELA.J.ARMAS = false;
                JANELA.J.PODERES = false;
                JANELA.J.PET = true;
            }
            //PODERES
            if (JANELA.J.Bpoderes.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                BOTAO = true;
                JANELA.J.bPODERES = true;
            }
            if (!JANELA.J.Bpoderes.Contains(mousePosition))
                JANELA.J.bPODERES = false;
            if (JANELA.J.bPODERES && !BOTAO)
            {
                JANELA.J.ARMAS = false;
                JANELA.J.PODERES = true;
                JANELA.J.PET = false;
            }
        }

        public void POSIÇÃO(int WidthTela, int HeightTela)
        {
            JANELA.J.R.X = WidthTela / 8;
            JANELA.J.R.Y = HeightTela / 8;
            JANELA.J.R.Width = WidthTela / 2 + WidthTela / 4;
            JANELA.J.R.Height = HeightTela / 2 + HeightTela / 4;

            JANELA.J.xis.X = JANELA.J.R.X + JANELA.J.R.Width - JANELA.J.R.Height / 18 + JANELA.J.R.Height / 240; //fim da tela
            JANELA.J.xis.Y = JANELA.J.R.Y;
            JANELA.J.xis.Width = JANELA.J.R.Height / 18 + JANELA.J.R.Height / 240; // = 45 + 3 = 48
            JANELA.J.xis.Height = JANELA.J.R.Height / 27; // = 30

            JANELA.J.CAPAopç1.Height =  JANELA.J.R.Height / 10 + JANELA.J.R.Height / 120; // = 81 + 6
            JANELA.J.CAPAopç1.Width = JANELA.J.R.Width - 2; // 1440 - 2
            JANELA.J.CAPAopç1.Y = JANELA.J.R.Y + JANELA.J.R.Height / 16 + JANELA.J.R.Height / 120; // = 50 + 6
            JANELA.J.CAPAopç1.X = JANELA.J.R.X + 1;

            JANELA.J.Bcomercio.Height = JANELA.J.R.Height / 30 - JANELA.J.R.Height / JANELA.J.R.Height; // = 27 - 1
            JANELA.J.Bcomercio.Width = JANELA.J.R.Height / 9 + JANELA.J.R.Height / 240; // = 90 + 3
            JANELA.J.Bcomercio.Y = JANELA.J.R.Y + JANELA.J.R.Height / 27; // = 30
            JANELA.J.Bcomercio.X = JANELA.J.R.X + 1;

            JANELA.J.Bcombos.Height = JANELA.J.R.Height / 30 - JANELA.J.R.Height / JANELA.J.R.Height; // = 27 - 1
            JANELA.J.Bcombos.Width = JANELA.J.R.Height / 9 + JANELA.J.R.Height / 240; // = 90 + 3
            JANELA.J.Bcombos.Y = JANELA.J.R.Y + JANELA.J.R.Height / 27; // = 30
            JANELA.J.Bcombos.X = JANELA.J.R.X + 1 + JANELA.J.Bcomercio.Width;

            JANELA.J.Barmas.Height = JANELA.J.R.Height / 30 - JANELA.J.R.Height / JANELA.J.R.Height; // = 27 - 1
            JANELA.J.Barmas.Width = JANELA.J.R.Height / 9 + JANELA.J.R.Height / 240; // = 90 + 3
            JANELA.J.Barmas.Y = JANELA.J.R.Y + JANELA.J.R.Height / 27; // = 30
            JANELA.J.Barmas.X = JANELA.J.R.X + 1 + ((JANELA.J.Bcomercio.Width) * 2); // posição em linha um na frente do outro

            JANELA.J.Bpet.Height = JANELA.J.R.Height / 30 - JANELA.J.R.Height / JANELA.J.R.Height; // = 27 - 1
            JANELA.J.Bpet.Width = JANELA.J.R.Height / 9 + JANELA.J.R.Height / 240; // = 90 + 3
            JANELA.J.Bpet.Y = JANELA.J.R.Y + JANELA.J.R.Height / 27; // = 30
            JANELA.J.Bpet.X = JANELA.J.R.X + 1 + ((JANELA.J.Bcomercio.Width) * 3);

            JANELA.J.Bpoderes.Height = JANELA.J.R.Height / 30 - JANELA.J.R.Height / JANELA.J.R.Height; // = 27 - 1
            JANELA.J.Bpoderes.Width = JANELA.J.R.Height / 9 + JANELA.J.R.Height / 240; // = 90 + 3
            JANELA.J.Bpoderes.Y = JANELA.J.R.Y + JANELA.J.R.Height / 27; // = 30
            JANELA.J.Bpoderes.X = JANELA.J.R.X + 1 + ((JANELA.J.Bcomercio.Width) * 4);
        }

       
        
    }
}
