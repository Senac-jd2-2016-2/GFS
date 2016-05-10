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

        //1x
        public bool UMAVEZ = true;

        //qtd de inimigos (OLEADA)
        public int qtddOLEADA = 1;

        //posição de itens e qntd
        public int POSyITEN = 0, QTDITENS = 10, QTDtotalITENSjanela = 9, TamanhodoPulodaSETA = 0; //quantidade q cabe na janela
        public int contagemMouseClickB = 0, contagemMouseClickC = 0, QuantidadeFaltaProFinalB, QuantidadeFaltaProFinalC;
        public bool[] ATIVOS = new bool[10], SELECIONADOS = new bool[10]; // se mudar os itens, muda aqui tmb

        //mov rolo
        public int NewpontoMouse, DistanciaMousePonto;
       

        //qntd de fases no jogo
        public int qntddefases;

        //escrita
        public SpriteFont Neon, Firefont, Woodfont, Neon15;

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

        

        //janelacc
        public bool ADAGATIVA, ESPADA2HATIVA, ADAGAselect, ESPADA2Hselect, MAOselect, setacimaB, setabaixoB, setacimaB2, setabaixoB2, ADAGAb, ESPADAb, MAOb;
        public bool ARCOATIVO, TRIDENTEATIVO, RETROCEDERATIVO, ESCUDOATIVO, VENTOATIVO, RAIOATIVO, ARCOselect, TRIDENTEselect, SLOWselect, RETROCEDERselect, ESCUDOselect, VENTOselect, RAIOselect, ARCOb, TRIDENTEb, SLOWb, RETROCEDERb, ESCUDOb, VENTOb, RAIOb;
        public Texture2D imgItemarco1, imgItemarco2, imgItemarco3, imgItemescudo1, imgItemescudo2, imgItemescudo3, imgItemraio1, imgItemraio2, imgItemraio3, imgItemretroceder1, imgItemretroceder2, imgItemretroceder3, imgItemslow1, imgItemslow2, imgItemtridente1, imgItemtridente2, imgItemtridente3, imgItemvento1, imgItemvento2, imgItemvento3;

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

                        //refazer
                        TRANSFERIDO = false;
                        TRANSFERIRpontos = false;
                        MOSTRARpontos = false;

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

                        //
                        TRANSFERIDO = false;
                        TRANSFERIRpontos = false;
                        MOSTRARpontos = false;
                        MediaPlayer.Play(Audio.A1.menusong);

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
                MediaPlayer.Pause();
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
                qntddefases++;
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
            if (!JANELAPLACAR && !JANELAQUEST)
            {
                for (int i = 0; i < Bfase.Length; i++)
                    Contexto.Fase[i] = false;

                Botao.HOME = true;
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

                //menu
                MediaPlayer.Play(Audio.A1.menusong);
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

        //usável pra qualquer jogo/programa (DINÂMICO) - (se for usar: Me avise, ficarei grato em saber)
        public void Rolometro(bool BOTAO, int QTDITENS, int QTDtotalITENSjanela, int QuantidadeFaltaProFinalB, int QuantidadeFaltaProFinalC, int contagemMouseClickB, int contagemMouseClickC, Rectangle janelarolo, Rectangle rolo, Rectangle setabaixo, Rectangle setacima, int TamanhodoPulodaSETA, bool setabaixoB, bool setacimaB, int W, int H, int POSyITEN)
        {
            
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            if (Mouse.GetState().LeftButton != ButtonState.Pressed) // BOTAO não pressionado
            {
                BOTAO = false;
                contagemMouseClickB = 0; //baixo
                contagemMouseClickC = 0; //cima
                
            }
            
            if (QTDITENS > QTDtotalITENSjanela) //ATUALIZAÇÃO DO ROLOMETRO
            {
                //QUANTIDADES QUE FALTAM PRA CHEGAR EM CERTO LUGAR
                QuantidadeFaltaProFinalB = (janelarolo.Y + janelarolo.Height) - (rolo.Y + rolo.Height);
                QuantidadeFaltaProFinalC = rolo.Y - janelarolo.Y;
                //att do qnt pular na seta (ela pula o tamanho de 1 iten inteiro)
                TamanhodoPulodaSETA = rolo.Height / QTDtotalITENSjanela; // tamanho / qtdjanela
                //baixo
                if (setabaixo.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    setabaixoB = true;
                    BOTAO = true;
                    contagemMouseClickB++;
                }
                if (!setabaixo.Contains(mousePosition))
                    setabaixoB = false;
                if (setabaixoB && !BOTAO || contagemMouseClickB >= 30)
                {

                    if (rolo.Y + rolo.Height < janelarolo.Y + janelarolo.Height - TamanhodoPulodaSETA) // so desce mais qnd tiver acima do espaço máximo - o qnt ele pode pular
                    {
                        rolo.Y += TamanhodoPulodaSETA;//rolo desce
                        POSyITEN -= TamanhodoPulodaSETA;//e o item sobe
                    }
                    else if (rolo.Y + rolo.Height >= janelarolo.Y + janelarolo.Height - TamanhodoPulodaSETA && rolo.Y + rolo.Height < janelarolo.Y + janelarolo.Height)// se ele estiver entre o final e espaço q ele pula, vai igualar ao final;
                    {
                        rolo.Y += QuantidadeFaltaProFinalB;
                        POSyITEN -= QuantidadeFaltaProFinalB;
                    }
                    setabaixoB = false;
                }

                if (!rolo.Contains(mousePosition) && janelarolo.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed && rolo.Y + rolo.Height < mouseState.Y && rolo.Y + rolo.Height < janelarolo.Y + janelarolo.Height - H / 250)
                {
                    rolo.Y += H / 200;
                    POSyITEN -= H / 200;
                }
                //cima
                if (setacima.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    setacimaB = true;
                    BOTAO = true;
                    contagemMouseClickC++;
                }
                if (!setacima.Contains(mousePosition))
                    setacimaB = false;
                if (setacimaB && !BOTAO || contagemMouseClickC >= 30)
                {

                    if (rolo.Y > janelarolo.Y + TamanhodoPulodaSETA) // so sobe mais qnd tiver embaixo do lugar menor + o qnt ele pode pular
                    {
                        rolo.Y -= TamanhodoPulodaSETA; //rolo sobe
                        POSyITEN += TamanhodoPulodaSETA;//e o item desce
                    }
                    else if (rolo.Y <= janelarolo.Y + TamanhodoPulodaSETA && rolo.Y > janelarolo.Y) // se ele estiver entre o final e espaço q ele pula, vai igualar ao final;
                    {
                        rolo.Y -= QuantidadeFaltaProFinalC;
                        POSyITEN += QuantidadeFaltaProFinalC;
                    }
                    setacimaB = false;
                }

                if (!rolo.Contains(mousePosition) && janelarolo.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed && rolo.Y > mouseState.Y && rolo.Y > janelarolo.Y + H / 250)
                {
                    rolo.Y -= H / 200;
                    POSyITEN += H / 200;
                }

                //caso passe do limite
                if (rolo.Y + rolo.Height > janelarolo.Y + janelarolo.Height)
                {
                    rolo.Y--;
                    POSyITEN++;
                }
                if (rolo.Y < janelarolo.Y)
                {
                    rolo.Y++;
                    POSyITEN--;
                }

                //qnd estiver clicado, encima
                if (rolo.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    //cada segundo atualiza o ponto e a distancia entro ponto e o mouse. Logo add na posição do obj
                    DistanciaMousePonto = mouseState.Y - NewpontoMouse;
                    //adição de posição
                    if (rolo.Y + rolo.Height + DistanciaMousePonto < janelarolo.Y + janelarolo.Height + 1 && rolo.Y + DistanciaMousePonto > janelarolo.Y - 1)
                    {
                        rolo.Y += DistanciaMousePonto;
                        POSyITEN -= DistanciaMousePonto;
                    }
                    NewpontoMouse = mouseState.Y;
                }

            }//fim do rolo
        }

        public void FUNÇÕESCC(bool BOTAO, int W, int H)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            if (Mouse.GetState().LeftButton != ButtonState.Pressed) // BOTAO não pressionado
            {
                BOTAO = false;
                contagemMouseClickB = 0; //baixo
                contagemMouseClickC = 0; //cima
                
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

            //Rolometro, dinamico.
            if (QTDITENS > QTDtotalITENSjanela) //ATUALIZAÇÃO DO ROLOMETRO
            {
                //QUANTIDADES QUE FALTAM PRA CHEGAR EM CERTO LUGAR
                QuantidadeFaltaProFinalB = (janelarolo.Y + janelarolo.Height) - (rolo.Y + rolo.Height);
                QuantidadeFaltaProFinalC = rolo.Y - janelarolo.Y;
                //att do qnt pular na seta (ela pula o tamanho de 1 iten inteiro)
                TamanhodoPulodaSETA = rolo.Height / QTDtotalITENSjanela; // tamanho / qtdjanela
                //baixo
                if (setabaixo.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    setabaixoB = true;
                    BOTAO = true;
                    contagemMouseClickB++;
                }
                if (!setabaixo.Contains(mousePosition))
                    setabaixoB = false;
                if (setabaixoB && !BOTAO || contagemMouseClickB >= 30)
                {

                    if (rolo.Y + rolo.Height < janelarolo.Y + janelarolo.Height - TamanhodoPulodaSETA) // so desce mais qnd tiver acima do espaço máximo - o qnt ele pode pular
                    {
                        rolo.Y += TamanhodoPulodaSETA;//rolo desce
                        POSyITEN -= TamanhodoPulodaSETA;//e o item sobe
                    }
                    else if (rolo.Y + rolo.Height >= janelarolo.Y + janelarolo.Height - TamanhodoPulodaSETA && rolo.Y + rolo.Height < janelarolo.Y + janelarolo.Height)// se ele estiver entre o final e espaço q ele pula, vai igualar ao final;
                    {
                        rolo.Y += QuantidadeFaltaProFinalB;
                        POSyITEN -= QuantidadeFaltaProFinalB;
                    }
                    setabaixoB = false;
                }

                if (!rolo.Contains(mousePosition) && janelarolo.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed && rolo.Y + rolo.Height < mouseState.Y && rolo.Y + rolo.Height < janelarolo.Y + janelarolo.Height - H / 250)
                {
                    rolo.Y += H / 200;
                    POSyITEN -= H / 200;
                }
                //cima
                if (setacima.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    setacimaB = true;
                    BOTAO = true;
                    contagemMouseClickC++;
                }
                if (!setacima.Contains(mousePosition))
                    setacimaB = false;
                if (setacimaB && !BOTAO || contagemMouseClickC >= 30)
                {

                    if (rolo.Y > janelarolo.Y + TamanhodoPulodaSETA) // so sobe mais qnd tiver embaixo do lugar menor + o qnt ele pode pular
                    {
                        rolo.Y -= TamanhodoPulodaSETA; //rolo sobe
                        POSyITEN += TamanhodoPulodaSETA;//e o item desce
                    }
                    else if (rolo.Y <= janelarolo.Y + TamanhodoPulodaSETA && rolo.Y > janelarolo.Y) // se ele estiver entre o final e espaço q ele pula, vai igualar ao final;
                    {
                        rolo.Y -= QuantidadeFaltaProFinalC;
                        POSyITEN += QuantidadeFaltaProFinalC;
                    }
                    setacimaB = false;
                }

                if (!rolo.Contains(mousePosition) && janelarolo.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed && rolo.Y > mouseState.Y && rolo.Y > janelarolo.Y + H / 250)
                {
                    rolo.Y -= H / 200;
                    POSyITEN += H / 200;
                }

                //caso passe do limite
                if (rolo.Y + rolo.Height > janelarolo.Y + janelarolo.Height)
                {
                    rolo.Y--;
                    POSyITEN++;
                }
                if (rolo.Y < janelarolo.Y)
                {
                    rolo.Y++;
                    POSyITEN--;
                }


                //qnd estiver clicado, encima
                if (rolo.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    //cada segundo atualiza o ponto e a distancia entro ponto e o mouse. Logo add na posição do obj
                    DistanciaMousePonto = mouseState.Y - NewpontoMouse;
                    //adição de posição
                    if (rolo.Y + rolo.Height + DistanciaMousePonto < janelarolo.Y + janelarolo.Height + 1 && rolo.Y + DistanciaMousePonto > janelarolo.Y - 1)
                    {
                        rolo.Y += DistanciaMousePonto;
                        POSyITEN -= DistanciaMousePonto;
                    }
                    NewpontoMouse = mouseState.Y;//ele precisa atualizar no final, pra poder sempre reatualizar
                }

            }//fim roda

            //itens click
            // + INFO DELES
            //0
            ATIVOS[0] = true;
            if (!MAOselect)
            {
                if (JANELA.J.listadeitens[0].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    MAOb = true;
                    BOTAO = true;
                }
                if (!JANELA.J.listadeitens[0].item.Contains(mousePosition))
                    MAOb = false;
                if (MAOb && !BOTAO)
                {
                    MAOselect = true;
                    MAOb = false;
                    SELECIONADOS[0] = true;

                    //tirar os outros da seleção
                    ADAGAselect = false;
                    ESPADA2Hselect = false;
                    ARCOselect = false;
                    TRIDENTEselect = false;

                    //descelecionar outros itens do mesmo grupo
                    for (int i = 1; i < 5; i++)
                    {
                        SELECIONADOS[i] = false;
                    }
                }
            }
            
            //1
            if (JANELA.J.ESPADA2HATIVA)
            {
                ATIVOS[1] = true;
                if (!JANELA.J.ESPADA2Hselect)
                {

                    if (JANELA.J.listadeitens[1].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        ESPADAb = true;
                        BOTAO = true;
                    }
                    if (!JANELA.J.listadeitens[1].item.Contains(mousePosition))
                        ESPADAb = false;
                    if (ESPADAb && !BOTAO)
                    {
                        ESPADA2Hselect = true;
                        ESPADAb = false;
                        SELECIONADOS[1] = true;

                        //tirar os outros da seleção
                        ADAGAselect = false;
                        MAOselect = false;
                        ARCOselect = false;
                        TRIDENTEselect = false;

                        SELECIONADOS[0] = false;
                        //descelecionar outros itens do mesmo grupo
                        for (int i = 2; i < 5; i++)
                        {
                            SELECIONADOS[i] = false;
                        }
                    }
                }
            }
            else
            {
                ATIVOS[1] = false;
                //se clicar encima e estiver bloqueado, ele vai ate o comercio
                if (JANELA.J.listadeitens[1].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    JANELACOMBO = false;
                    JANELACOMERCIO = true;
                    ARMAS = true;
                    PODERES = false;
                    PET = false;
                }
            }
            //2
            if (JANELA.J.ADAGATIVA)
            {
                ATIVOS[2] = true;
                if (!JANELA.J.ADAGAselect)
                {

                    if (JANELA.J.listadeitens[2].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        ADAGAb = true;
                        BOTAO = true;
                    }
                    if (!JANELA.J.listadeitens[2].item.Contains(mousePosition))
                        ADAGAb = false;
                    if (ADAGAb && !BOTAO)
                    {
                        ADAGAselect = true;
                        ADAGAb = false;
                        SELECIONADOS[2] = true;

                        //tirar os outros da seleção
                        ESPADA2Hselect = false;
                        MAOselect = false;
                        ARCOselect = false;
                        TRIDENTEselect = false;

                        SELECIONADOS[0] = false;
                        SELECIONADOS[1] = false;
                        //descelecionar outros itens do mesmo grupo
                        for (int i = 3; i < 5; i++)
                        {
                            SELECIONADOS[i] = false;
                        }
                    }
                }
            }
            else
            {
                ATIVOS[2] = false;
                //se clicar encima e estiver bloqueado, ele vai ate o comercio
                if (JANELA.J.listadeitens[2].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    JANELACOMBO = false;
                    JANELACOMERCIO = true;
                    ARMAS = true;
                    PODERES = false;
                    PET = false;
                }
            }
            //3
            if (JANELA.J.ARCOATIVO)
            {
                ATIVOS[3] = true;
                if (!JANELA.J.ARCOselect)
                {
                    
                    if (JANELA.J.listadeitens[3].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        ARCOb = true;
                        BOTAO = true;
                    }
                    if (!JANELA.J.listadeitens[3].item.Contains(mousePosition))
                        ARCOb = false;
                    if (ARCOb && !BOTAO)
                    {
                        ARCOselect = true;
                        ARCOb = false;
                        SELECIONADOS[3] = true;


                        //tirar os outros da seleção
                        ADAGAselect = false;
                        MAOselect = false;
                        ESPADA2Hselect = false;
                        TRIDENTEselect = false;

                        SELECIONADOS[0] = false;
                        SELECIONADOS[1] = false;
                        SELECIONADOS[2] = false;
                        SELECIONADOS[4] = false;
                        
                    }
                }
            }
            else
            {
                ATIVOS[3] = false;
                //se clicar encima e estiver bloqueado, ele vai ate o comercio
                if (JANELA.J.listadeitens[3].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    JANELACOMBO = false;
                    JANELACOMERCIO = true;
                    ARMAS = true;
                    PODERES = false;
                    PET = false;
                }
            }
            //4
            if (JANELA.J.TRIDENTEATIVO)
            {
                ATIVOS[4] = true;
                if (!JANELA.J.TRIDENTEselect)
                {

                    if (JANELA.J.listadeitens[4].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        TRIDENTEb = true;
                        BOTAO = true;
                    }
                    if (!JANELA.J.listadeitens[4].item.Contains(mousePosition))
                        TRIDENTEb = false;
                    if (TRIDENTEb && !BOTAO)
                    {
                        TRIDENTEselect = true;
                        TRIDENTEb = false;
                        SELECIONADOS[4] = true;

                        //tirar os outros da seleção
                        ADAGAselect = false;
                        MAOselect = false;
                        ESPADA2Hselect = false;
                        ARCOselect = false;

                        SELECIONADOS[0] = false;
                        SELECIONADOS[1] = false;
                        SELECIONADOS[2] = false;
                        SELECIONADOS[3] = false;
                    }
                }
            }
            else
            {
                ATIVOS[4] = false;
                //se clicar encima e estiver bloqueado, ele vai ate o comercio
                if (JANELA.J.listadeitens[4].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    JANELACOMBO = false;
                    JANELACOMERCIO = true;
                    ARMAS = true;
                    PODERES = false;
                    PET = false;
                }
            }




            if (!SLOWselect)
            {
                
                ATIVOS[5] = true;
                if (JANELA.J.listadeitens[5].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    SLOWb = true;
                    BOTAO = true;
                }
                if (!JANELA.J.listadeitens[5].item.Contains(mousePosition))
                    SLOWb = false;
                if (SLOWb && !BOTAO)
                {
                    SLOWselect = true;
                    SLOWb = false;
                    SELECIONADOS[5] = true;

                    //tirar os outros da seleção
                    RETROCEDERselect = false;
                    ESCUDOselect = false;
                    VENTOselect = false;
                    RAIOselect = false;

                    //descelecionar outros itens do mesmo grupo
                    for (int i = 6; i < 10; i++)
                    {
                        SELECIONADOS[i] = false;
                    }
                }
            }

            if (JANELA.J.RETROCEDERATIVO)
            {
                ATIVOS[6] = true;
                if (!JANELA.J.RETROCEDERselect)
                {

                    if (JANELA.J.listadeitens[6].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        RETROCEDERb = true;
                        BOTAO = true;
                    }
                    if (!JANELA.J.listadeitens[6].item.Contains(mousePosition))
                        RETROCEDERb = false;
                    if (RETROCEDERb && !BOTAO)
                    {
                        RETROCEDERselect = true;
                        RETROCEDERb = false;
                        SELECIONADOS[6] = true;

                        //tirar os outros da seleção
                        SLOWselect = false;
                        ESCUDOselect = false;
                        VENTOselect = false;
                        RAIOselect = false;

                        //descelecionar outros itens do mesmo grupo
                        SELECIONADOS[5] = false;
                        for (int i = 7; i < 10; i++)
                        {
                            SELECIONADOS[i] = false;
                        }
                    }
                }
            }
            else
            {
                ATIVOS[6] = false;
                //se clicar encima e estiver bloqueado, ele vai ate o comercio
                if (JANELA.J.listadeitens[6].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    JANELACOMBO = false;
                    JANELACOMERCIO = true;
                    ARMAS = false;
                    PODERES = true;
                    PET = false;
                }
            }


            if (JANELA.J.ESCUDOATIVO)
            {
                ATIVOS[7] = true;
                if (!JANELA.J.ESCUDOselect)
                {

                    if (JANELA.J.listadeitens[7].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        ESCUDOb = true;
                        BOTAO = true;
                    }
                    if (!JANELA.J.listadeitens[7].item.Contains(mousePosition))
                        ESCUDOb = false;
                    if (ESCUDOb && !BOTAO)
                    {
                        ESCUDOselect = true;
                        ESCUDOb = false;
                        SELECIONADOS[7] = true;

                        //tirar os outros da seleção
                        SLOWselect = false;
                        RETROCEDERselect = false;
                        VENTOselect = false;
                        RAIOselect = false;

                        //descelecionar outros itens do mesmo grupo
                        SELECIONADOS[5] = false;
                        SELECIONADOS[6] = false;
                        for (int i = 8; i < 10; i++)
                        {
                            SELECIONADOS[i] = false;
                        }
                    }
                }
            }
            else
            { 
                ATIVOS[7] = false;
                //se clicar encima e estiver bloqueado, ele vai ate o comercio
                if (JANELA.J.listadeitens[7].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    JANELACOMBO = false;
                    JANELACOMERCIO = true;
                    ARMAS = false;
                    PODERES = true;
                    PET = false;
                }
            }

            if (JANELA.J.VENTOATIVO)
            {
                ATIVOS[8] = true;
                if (!JANELA.J.VENTOselect)
                {

                    if (JANELA.J.listadeitens[8].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        VENTOb = true;
                        BOTAO = true;
                    }
                    if (!JANELA.J.listadeitens[8].item.Contains(mousePosition))
                        VENTOb = false;
                    if (VENTOb && !BOTAO)
                    {
                        VENTOselect = true;
                        VENTOb = false;
                        SELECIONADOS[8] = true;

                        //tirar os outros da seleção
                        SLOWselect = false;
                        RETROCEDERselect = false;
                        ESCUDOselect = false;
                        RAIOselect = false;

                        //descelecionar outros itens do mesmo grupo
                        SELECIONADOS[5] = false;
                        SELECIONADOS[6] = false;
                        SELECIONADOS[7] = false;
                        SELECIONADOS[9] = false;
                    }
                }
            }
            else
            { 
                ATIVOS[8] = false;
                //se clicar encima e estiver bloqueado, ele vai ate o comercio
                if (JANELA.J.listadeitens[8].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    JANELACOMBO = false;
                    JANELACOMERCIO = true;
                    ARMAS = false;
                    PODERES = true;
                    PET = false;
                }
            }

            if (JANELA.J.RAIOATIVO)
            {
                ATIVOS[9] = true;
                if (!JANELA.J.RAIOselect)
                {
                    if (JANELA.J.listadeitens[9].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        RAIOb = true;
                        BOTAO = true;
                    }
                    if (!JANELA.J.listadeitens[9].item.Contains(mousePosition))
                        RAIOb = false;
                    if (RAIOb && !BOTAO)
                    {
                        RAIOselect = true;
                        RAIOb = false;
                        SELECIONADOS[9] = true;

                        //tirar os outros da seleção
                        SLOWselect = false;
                        RETROCEDERselect = false;
                        ESCUDOselect = false;
                        VENTOselect = false;

                        //descelecionar outros itens do mesmo grupo
                        SELECIONADOS[5] = false;
                        SELECIONADOS[6] = false;
                        SELECIONADOS[7] = false;
                        SELECIONADOS[8] = false;
                    }
                }
            }
            else
            { 
                ATIVOS[9] = false;
                //se clicar encima e estiver bloqueado, ele vai ate o comercio
                if (JANELA.J.listadeitens[9].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    JANELACOMBO = false;
                    JANELACOMERCIO = true;
                    ARMAS = false;
                    PODERES = true;
                    PET = false;
                }
            }

        }//fim funçoes

        public void POSIÇÃOCC(int W, int H)
        {
            JANELA.J.R.X = W / 8;
            JANELA.J.R.Y = H / 8;
            JANELA.J.R.Width = W / 2 + W / 4;
            JANELA.J.R.Height = H / 2 + H / 4;

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
            janelaitens.Width = H / 3 - H / 100; //350
            janelaitens.Height = W / 3 + H / 41; //640 + 26 = 66

            janelaall.X = setacima.X + setacima.Width;
            janelaall.Y = janelaitens.Y;
            janelaall.Width = H - H / 30; // 1080 - 36 = 1044
            janelaall.Height = W / 3 + H / 41; //640 + 26 = 666

            //rolo1
            setacima.X = janelaitens.X + janelaitens.Width;
            setacima.Y = janelaitens.Y;
            setacima.Width = H / 47; //22
            setacima.Height = H / 47; //22

            setabaixo.X = janelaitens.X + janelaitens.Width;
            setabaixo.Y = janelaitens.Y + janelaitens.Height - H / 47;
            setabaixo.Width = H / 47; //22
            setabaixo.Height = H / 47; //22

            //rolometro2
            setacima2.X = janelaall.X + janelaall.Width;
            setacima2.Y = janelaitens.Y;
            setacima2.Width = H / 47; //22
            setacima2.Height = H / 47; //22

            setabaixo2.X = janelaall.X + janelaall.Width;
            setabaixo2.Y = janelaitens.Y + janelaitens.Height - H / 47;
            setabaixo2.Width = H / 47; //22
            setabaixo2.Height = H / 47; //22

            janelarolo.X = setacima.X;
            janelarolo.Y = setacima.Y + setacima.Height;
            janelarolo.Width = H / 47; //22
            janelarolo.Height = W / 3 - H / 60; //640 - 18 = 622;

            janelarolo2.X = setacima2.X;
            janelarolo2.Y = setacima2.Y + setacima2.Height;
            janelarolo2.Width = H / 47; //22
            janelarolo2.Height = W / 3 - H / 60; //640 - 18 = 622;

            rolo.X = janelarolo.X;
            rolo.Width = janelarolo.Width;

            rolo2.X = janelarolo2.X;
            rolo2.Width = janelarolo2.Width;

            //rolo 1
            if (QTDITENS <= QTDtotalITENSjanela)
            {
                rolo.Y = janelarolo.Y;
                rolo.Height = janelarolo.Height;
            }
            if (QTDITENS > QTDtotalITENSjanela)
            {
                if (UMAVEZ)
                {
                    rolo.Y = janelarolo.Y;
                    UMAVEZ = false;
                }

                rolo.Height = (int)(((float)(QTDtotalITENSjanela) / QTDITENS) * janelarolo.Height); // menor pelo meio e multiplica pelo tamanho que quero.
            }

            for (int i = 0; i < QTDITENS; i++)
            {
                //tamanho e x
                listadeitens[i].item.X = janelaitens.X;
                listadeitens[i].item.Width = janelaitens.Width;
                listadeitens[i].item.Height = H / 15 + H / H; //72 + 1 = 73
                if (i - 1 < 0)//1°
                {
                    listadeitens[i].item.Y = POSyITEN + janelaitens.Y;
                }
                if (i - 1 >= 0)//um embaixo do outro
                {
                    listadeitens[i].item.Y = listadeitens[i - 1].item.Y + listadeitens[i - 1].item.Height;
                }
            }

        }//fim poss

       
        
    }//fim da classe.......................... 

    
}
