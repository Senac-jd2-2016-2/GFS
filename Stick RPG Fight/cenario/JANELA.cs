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

        //qtd de inimigos (OLEADA)
        public int qtddOLEADA = 1;

        //escrita
        public SpriteFont Neon, Firefont, Woodfont;

        //separo todos os retangles, imagens, bool para preparar as janelas dentro do jogo, tambem utilizo a classe JANELA pra não criar classes pequenas com poucos codigos, pois a classe janela é estática.
        //

        //parte dos retangulos
        public Rectangle R = new Rectangle();
        public Rectangle xis = new Rectangle();
        public Rectangle CAPAopç1 = new Rectangle();
        public Rectangle Bcomercio = new Rectangle();
        public Rectangle Bcombos = new Rectangle();
        public Rectangle Bpoderes = new Rectangle();
        public Rectangle Barmas = new Rectangle();
        public Rectangle Bpet = new Rectangle();
        public Rectangle Brefresh = new Rectangle();
        public Rectangle Bok = new Rectangle();
        public Rectangle Quest = new Rectangle();
        //       PLACAR (ok e refresh 2x)
        public Rectangle Bok2 = new Rectangle();
        public Rectangle Brefresh2 = new Rectangle();
        public Rectangle Placar = new Rectangle();
        public Rectangle janelaall = new Rectangle();
        public Rectangle janelaitens = new Rectangle();
        //rolometro
        public Rectangle setacima = new Rectangle();
        public Rectangle setabaixo = new Rectangle();
        public Rectangle janelarolo = new Rectangle();
        public Rectangle rolo = new Rectangle();
        //rolometro2
        public Rectangle setacima2 = new Rectangle();
        public Rectangle setabaixo2 = new Rectangle();
        public Rectangle janelarolo2 = new Rectangle();
        public Rectangle rolo2 = new Rectangle();

        //placar
        public Texture2D imgPlacar;
        public Point POSplacar = new Point(0, 0);
        public bool bREFRESH2, bOK2, JANELAPLACAR, PLACARdisponivel, MOSTRARpontos, TRANSFERIRpontos, TRANSFERIDO;
        public int contagemMOSTRARPONTOS = 0, contagemTRANSFERIRPONTOS = 0;

        //PAUSE
        public Rectangle pauseJANELA = new Rectangle();
        public Rectangle Bsair = new Rectangle();
        public Rectangle Bresume = new Rectangle();
        public Rectangle FUNDO = new Rectangle();

        public Texture2D imgpauseJANELA;
        public Texture2D imgBsair1, imgBsair2, imgBsair3;
        public Texture2D imgBresume1, imgBresume2, imgBresume3, imgFUNDOmenu;

        public Texture2D imgjanelacombo, imgjanelacinzaopç1, imgjanelacomercio, imgbotaoComercioOFF, imgbotaoComercioON;
        public Texture2D imgbotaoPoderesOFF, imgbotaoPoderesON, imgbotaoX, imgbotaoXred;
        public Texture2D imgbotaoArmasOFF, imgbotaoArmasON, imgbotaoCombosOFF, imgbotaoCombosON, imgbotaoPetON, imgbotaoPetOFF;
        public Texture2D imgjanelaall, imgjanelarolo, imgrolo, imgsetacima, imgsetabaixo, imgadaga1, imgadaga2, imgadaga3, imgespada2H1, imgespada2H2, imgespada2H3, imgmao1, imgmao2;

        //QUEST
        public Texture2D imgQuest, imgRefresh1, imgRefresh2, imgOK1, imgOK2, imgOK3;
        public bool RODAR1, RODAR2, bREFRESH, bOK, JANELAQUEST, QUESTdisponivel;
        public Point tamanhoQuest = new Point(788, 613);
        public Point spriteQuest = new Point(8, 6);
        public Point frameQuest = new Point(0, 0), POSquest = new Point(0,0);
        public int Qopç, Qqtdd, Qcompletadas, Qqtddcompletada, Qtempo;//opç de quest/ quantidade pra terminar quest/ quantas quests completadas/ quantidade de coisas feitas na quest/ tempo;

        //ESCOLHA DE FASE
        public Texture2D imgPbranco;
        public Texture2D[] imgfaseB = new Texture2D[2];

        public Rectangle[] Rfase = new Rectangle[2];
        public Rectangle[] linhas = new Rectangle[2];
        public Point Prolar = new Point(0, 0);

        public bool OPÇFASES, PRIMEIROclick;
        public bool[] Bfase = new bool[2];
        public bool[] FASEdestravada = new bool[2];

        public List<Itens> listadeitens = new List<Itens>();
        
        //janela normal de compras e combo 
        public bool JANELACOMBO = false, JANELACOMERCIO = false, ARMAS, PET, PODERES, bXIS, bCOMBO, bCOMERCIO, bARMAS, bPET, bPODERES;
        //pause
        public bool JANELAPAUSE, bSAIR, bRESUME;

        public void FUNÇOESPLACAR(bool BOTAO, Personagem P1, Botoes Botao, List<Inimigo> listai1, int W, int H, Menu M1, Random A)
        {
            if (PLACARdisponivel)
            {
                var mouseState = Mouse.GetState();
                var mousePosition = new Point(mouseState.X, mouseState.Y);
                if (Mouse.GetState().LeftButton != ButtonState.Pressed) // BOTAO não pressionado
                {
                    BOTAO = false;
                }
                //--------------------------------------------------------------------------------

                if (!TRANSFERIDO)
                {
                    if (!TRANSFERIRpontos)//vou mostrar os pontos, dps transferir, e quando transferido posso sair da tela
                    {
                        MOSTRARpontos = true;
                        
                        if (MOSTRARpontos)
                        {
                            contagemMOSTRARPONTOS++;
                            if (contagemMOSTRARPONTOS >= 30)
                            {
                                contagemMOSTRARPONTOS = 0;
                                TRANSFERIRpontos = true; // sai do laço
                                //como só vou mostrar, não tem nenhuma função no update, apenas no DRAW.
                                
                                if (P1.leiterepositório == 0 && P1.honrarepositório == 0)
                                {
                                    Audio.A1.SUPERCHORO.Play();
                                }
                                if (P1.leiterepositório > 0 && P1.honrarepositório > 0 && P1.leiterepositório <= 10 && P1.honrarepositório <= 10)
                                {
                                    Audio.A1.RISADA.Play();
                                }
                                if (P1.leiterepositório > 10 && P1.honrarepositório > 10)
                                {
                                    Audio.A1.RISADA.Play();
                                }
                            }
                        }
                    }
                    //
                    if (TRANSFERIRpontos)
                    {
                        
                        contagemTRANSFERIRPONTOS++;
                        if (contagemTRANSFERIRPONTOS >= 60)
                        {
                            contagemTRANSFERIRPONTOS = 0;
                            
                            //VOU TRANSFERIR OS PONTOS AQUI => pra poder atualizar 1x só.
                            P1.leite += P1.leiterepositório;
                            P1.honra += P1.honrarepositório;
                            P1.qntdcombos += P1.qntdcombosrepositório;
                            P1.XP += 50 + (10 * Qcompletadas); // add XP

                            //audio de dinheiro
                            Audio.A1.COINCOLLECT.Play();

                            TRANSFERIDO = true; //saida do laço
                        }
                    }
                }

                if (TRANSFERIDO)
                {
                    if (JANELA.J.Brefresh2.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        BOTAO = true;
                        JANELA.J.bREFRESH2 = true;
                    }
                    if (!JANELA.J.Brefresh2.Contains(mousePosition))
                        JANELA.J.bREFRESH2 = false;
                    //botao girar
                    if (JANELA.J.bREFRESH2 && !BOTAO)
                    {
                        //posição volta pro começo e os inimigos somem (SAI DA FASE)
                        JANELA.J.ZERARFASE(listai1, P1, Botao, W, H);
                        JANELA.J.JANELAQUEST = true;
                        JANELA.J.JANELAPLACAR = false;
                        JANELA.J.bREFRESH2 = false;

                        GERARQuest(A); // cria uma quest e começa denovo
                    }




                    //aceitar missão
                    if (JANELA.J.Bok2.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        BOTAO = true;
                        JANELA.J.bOK2 = true;
                    }
                    if (!JANELA.J.Bok2.Contains(mousePosition))
                        JANELA.J.bOK2 = false;

                    if (JANELA.J.bOK2 && !BOTAO)
                    {
                        
                        //TERMINAR FASE
                        M1.COMBATE = false;
                        //posição volta pro começo e os inimigos somem (SAI DA FASE)
                        JANELA.J.JANELAPLACAR = false;
                        JANELA.J.ZERARFASE(listai1, P1, Botao, W, H);

                        for (int i = 0; i < Bfase.Length; i++)
                            Contexto.Fase[i] = false;
                    }
                }//transferido
            }//placar
        }//fim das funções

        public void POSPLACAR(int W, int H)
        {
            Placar.Width = H - W / 6 + H / 38; //1080 - 320 + 28 = 788
            Placar.Height = W / 3 - H / 40;//640 - 27= 613
            Placar.X = POSplacar.X + W / 2 - ((H - W / 6 + H / 38) / 2);
            Placar.Y = POSplacar.Y - (W / 3 - H / 40);

            Bok2.X = Placar.X + H / 4 + H / 100; //270 + 10 = 280
            Bok2.Y = Placar.Y + H / 2 - H / 38; //540 - 28 = 512
            Bok2.Width = H / 5 + H / 40;// 216 + 27 =243
            Bok2.Height = H / 13 - H / 200;// 83 - 5 = 78

            Brefresh2.X = Bok2.X + Bok2.Width + H / 100; //10
            Brefresh2.Y = Bok2.Y; //
            Brefresh2.Width = H / 13 - H / 300;// 83 - 3 = 80
            Brefresh2.Height = H / 13 - H / 400;// 83 - 2 = 81

            if (JANELAPLACAR)
            {
                if (POSplacar.Y > W / 3 + H / 40 )
                {
                    POSplacar.Y = W / 3 + H / 40;
                    Audio.A1.PLACAREFFECT.Play();
                    
                }
                if (POSplacar.Y < W / 3 + H / 40)
                {
                    POSplacar.Y += H / 20; //54
                    PLACARdisponivel = false;
                }
                if (POSplacar.Y == W / 3 + H / 40)
                {
                    PLACARdisponivel = true;
                }
            }
            else if (!JANELAPLACAR)
            {
                POSplacar.Y = 0;
                PLACARdisponivel = false;
            }
        }

        public void COMPLETARQuest(Menu M1, Personagem P1, Botoes Botao, List<Inimigo> listai1, int W, int H)
        {
            if (M1.COMBATE)
            {
                if (Qqtddcompletada >= Qqtdd) // MISAO COMPLETADA
                {
                    Qcompletadas++;
                    Qqtddcompletada = 0;

                    //isto acontece 2x... Qnd morrer ou qnd terminar quest
                    JANELAPLACAR = true; // leva até o placar (QND TERMINAR A QUEST)
                }
                
                if (Qopç == 2)
                {
                    Qtempo++;
                    if (Qtempo >= 60)
                    {
                        Qtempo = 0;
                        Qqtddcompletada++;
                    }
                }
            
            }
            else if (!M1.COMBATE)
            {
                Qqtddcompletada = 0;
                Qtempo = 0;
            }
        }

        public void GERARQuest(Random A)
        {
            Qopç = A.Next(1, 3); // 2 opç
            if (Qopç == 1)
            {
                Qqtdd = 10 + (3 * Qcompletadas); // qnt precisa pra completar
            }
            if (Qopç == 2)
            {
                Qqtdd = 30 + (5 * Qcompletadas);
            }
        }//fim gerar quest

        //
        public void FUNÇOESQUEST(bool BOTAO, Random A)
        {

            if (QUESTdisponivel)
            {
                var mouseState = Mouse.GetState();
                var mousePosition = new Point(mouseState.X, mouseState.Y);
                if (Mouse.GetState().LeftButton != ButtonState.Pressed) // BOTAO não pressionado
                {
                    BOTAO = false;
                }
                //--------------------------------------------------------------------------------

                if (JANELA.J.Brefresh.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed && !RODAR1 && !RODAR2)
                {
                    BOTAO = true;
                    JANELA.J.bREFRESH = true;
                }
                if (!JANELA.J.Brefresh.Contains(mousePosition))
                    JANELA.J.bREFRESH = false;
                //botao girar
                if (JANELA.J.bREFRESH && !BOTAO && frameQuest.X == 0 && frameQuest.Y == 0 && !RODAR1 && !RODAR2)
                {
                    RODAR1 = true;
                    JANELA.J.bREFRESH = false;
                    GERARQuest(A);
                }
                if (JANELA.J.bREFRESH && !BOTAO && frameQuest.X == 2 && frameQuest.Y == 5 && !RODAR1 && !RODAR2)
                {
                    RODAR2 = true;
                    JANELA.J.bREFRESH = false;
                    GERARQuest(A);
                }



                //r
                if (RODAR1)
                {
                    frameQuest.X++;
                    if (frameQuest.X >= spriteQuest.X)
                    {
                        frameQuest.X = 0;
                        frameQuest.Y++;
                    }
                    if (frameQuest.X == 2 && frameQuest.Y == 5)
                    {
                        RODAR1 = false;
                    }
                }
                if (RODAR2)
                {
                    frameQuest.X--;
                    if (frameQuest.X <= -1)
                    {
                        frameQuest.X = 7;
                        frameQuest.Y--;
                    }
                    if (frameQuest.X == 0 && frameQuest.Y == 0)
                    {
                        RODAR2 = false;
                    }
                }



                //aceitar missão
                if (JANELA.J.Bok.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed && !RODAR1 && !RODAR2)
                {
                    BOTAO = true;
                    JANELA.J.bOK = true;
                }
                if (!JANELA.J.Bok.Contains(mousePosition))
                    JANELA.J.bOK = false;

                if (JANELA.J.bOK && !BOTAO && !RODAR1 && !RODAR2)
                {
                    JANELAQUEST = false;
                }
            }

        }//fim funções quest

        //
        public void POSQUEST(int W, int H)
        {
            Quest.Width = H - W / 6 + H / 38; //1080 - 320 + 28 = 788
            Quest.Height = W / 3 - H / 40;//640 - 27= 613
            Quest.X = POSquest.X + W / 2 - ((H - W / 6 + H / 38) / 2);
            Quest.Y = POSquest.Y - (W / 3 - H / 40);

            Brefresh.X = Quest.X + H / 3; //360
            Brefresh.Y = Quest.Y + H / 4 + H / 37; //270 + 29 =299
            Brefresh.Width = H / 13 - H / 300 ;// 83 - 3 = 80
            Brefresh.Height = H / 13 - H / 400;// 83 - 2 = 81

            Bok.X = Quest.X + H / 4 + H / 100; //270 + 10 = 280
            Bok.Y = Quest.Y + H / 2 - H / 38; //540 - 28 = 512
            Bok.Width = H / 5 + H / 40;// 216 + 27 =243
            Bok.Height = H / 13 - H / 200;// 83 - 5 = 78

            if (JANELAQUEST)
            {
                if (POSquest.Y > H / 2)
                {
                    POSquest.Y = H / 2;
                }
                if (POSquest.Y < H / 2)
                {
                    POSquest.Y += H / 20; //54
                    QUESTdisponivel = false;
                }
                if (POSquest.Y == H / 2)
                {
                    QUESTdisponivel = true;
                }
            }
            else if (!JANELAQUEST)
            {
                POSquest.Y = 0;
                QUESTdisponivel = false;
            }
        }


        //
        public void CRIARlinhas()
        {
            for (int i = 0; i < linhas.Length; i++)
            {
                linhas[i] = new Rectangle();
            }
            for (int i = 0; i < Rfase.Length; i++)
            {
                Rfase[i] = new Rectangle();
                Bfase[i] = false;
            }
            JANELA.J.FASEdestravada[0] = true;
        }
       
        public void FUNÇÕESOPÇFASE(int W, int H, Botoes Botao, Menu M1, bool MENU, bool BOTAO)
        {
            
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            if (Mouse.GetState().LeftButton != ButtonState.Pressed) // BOTAO não pressionado
            {
                BOTAO = false;
            }
            //--------------------------------------------------------------------------------
            for (int i = 0; i < Rfase.Length; i++)
            {
                if (FASEdestravada[i])
                {
                    if (Rfase[i].Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        BOTAO = true;
                        JANELA.J.Bfase[i] = true;
                    }
                    if (!JANELA.J.Rfase[i].Contains(mousePosition))
                        JANELA.J.Bfase[i] = false;
                    if (JANELA.J.Bfase[i] && !BOTAO)
                    {
                        MENU = false;
                        M1.COMBATE = true;
                        Contexto.Fase[i] = true;
                        Botao.HOME = false;
                        JANELA.J.OPÇFASES = false;

                        //abre janela de quest
                        JANELA.J.JANELAQUEST = true;
                    }
                }
            }
        }

        public void POSopçfase(int W, int H)
        {
           
            var PULO = W / 2;
            for (int i = 0; i < Rfase.Length; i++)
            {
                //FASE ((TODAS))
                Rfase[i].Width = H / 3 + H / 10 - H / 400;// de lei
                Rfase[i].Height = H / 6 + H / 250;// de lei 
                Rfase[i].X = Prolar.X + W / 8 + (PULO * i);
                Rfase[i].Y = Prolar.Y + H / 8;

                if (i < Rfase.Length)
                {
                    //LINHAS (TODAS)
                    linhas[i].X = Rfase[i].X + Rfase[i].Width;
                    linhas[i].Y = Rfase[i].Y + Rfase[i].Height / 2;
                    linhas[i].Width = PULO - Rfase[i].Width;
                    linhas[i].Height = H / 300; // = 3
                }
               
            }
        }

        //

        public void ZERARFASE(List<Inimigo> listai1, Personagem P1, Botoes Botao, int W, int H)
        {
            //sai pro menu
            Botao.HOME = true;
            if (!JANELAPLACAR && !JANELAQUEST)
            {
                for (int i = 0; i < Bfase.Length; i++)
                    Contexto.Fase[i] = false;
            }
            
            //todos os inimigos desaparecem
            listai1.Clear();
            //
            
            P1.individuo.X = 0;
            P1.individuo.Y = H - H / 3;
            Contexto.Fundo.fase = new Rectangle(0, -H / 10, W * 3, H + H / 10);
            //MediaPlayer.Play(AUDIO.menusong);

            //perder progresso
            P1.leiterepositório = 0;
            P1.honrarepositório = 0;
            P1.qntdcombosrepositório = 0;
            //regenerar
            P1.vida = P1.vidaTOTAL;
            P1.energia = P1.energiaTOTAL;
            P1.mana = P1.manaTOTAL;
            P1.SENDOAGARRADO = false;
            P1.COLIDINDOdireita = false;
            P1.COLIDINDOesquerda = false;

            //limpando listas
            P1.listadedano.Clear();
            P1.listaclonePoder.Clear();
            P1.listadeagua.Clear();
            P1.listadeondadeagua.Clear();
            P1.listadevisualPOWER.Clear();
            P1.listavidaperdida.Clear();

            
            //oleada
            qtddOLEADA = 1;
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

            JANELA.J.Bsair.X = JANELA.J.pauseJANELA.X + HeightTela / 60; //18
            JANELA.J.Bsair.Y = JANELA.J.pauseJANELA.Y + HeightTela / 10 - HeightTela / HeightTela; //108 - 1;
            JANELA.J.Bsair.Width = ((HeightTela / 2 + HeightTela / 9 + HeightTela / 150) / 2) - HeightTela / 52;//313 = 333 - 20
            JANELA.J.Bsair.Height = HeightTela / 18 - HeightTela / HeightTela;//59 (58 - 1)

            JANELA.J.Bresume.X = JANELA.J.pauseJANELA.X + ((HeightTela / 2 + HeightTela / 9 + HeightTela / 150) / 2) + HeightTela / 350; //333 + 3 = 336;
            JANELA.J.Bresume.Y = JANELA.J.pauseJANELA.Y + HeightTela / 10 - HeightTela / HeightTela; //108 - 1;
            JANELA.J.Bresume.Width = ((HeightTela / 2 + HeightTela / 9 + HeightTela / 150) / 2) - HeightTela / 52;//313 = 333 - 20
            JANELA.J.Bresume.Height = HeightTela / 18 - HeightTela / HeightTela;//59 (58 - 1)

            //// --- fundo
            JANELA.J.FUNDO.X = 0;
            JANELA.J.FUNDO.Y = 0;
            JANELA.J.FUNDO.Width = WidthTela;
            JANELA.J.FUNDO.Height = HeightTela;

            
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

            JANELA.J.xis.X = JANELA.J.R.X + JANELA.J.R.Width - JANELA.J.R.Height / 18 - JANELA.J.R.Height / 240; //fim da tela
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

            janelaitens.X = Bcomercio.X;
            janelaitens.Y = CAPAopç1.Y + CAPAopç1.Height;
            janelaitens.Width = HeightTela / 3 - HeightTela / 100; //350
        }

       
        
    }//fim da classe.......................... 

    
}
