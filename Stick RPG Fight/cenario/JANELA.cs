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
        public int POSyITEN = 0, QTDITENS = 15, QTDtotalITENSjanela = 9, TamanhodoPulodaSETA = 0; //quantidade q cabe na janela
        public int contagemMouseClickB = 0, contagemMouseClickC = 0, QuantidadeFaltaProFinalB, QuantidadeFaltaProFinalC;
        public bool[] ATIVOS = new bool[15], SELECIONADOS = new bool[15]; // se mudar os itens, muda aqui tmb

        //selecionado (PRINCIPAL DA JANELA CC)
        public List<ItensAll> listaitensall = new List<ItensAll>();

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

        //janela OPTION  =============-
        public Rectangle janelaopçao, somB, resoluçaoB, creditosB;
        public bool JANELAOPÇOES, SOM, SOMb, RESOLUÇAO, RESOLUÇAOb, CREDITOS, CREDITOSb, opçDESCER, MudarRESULUÇAO;
        public Texture2D imgjanelaopç1, imgjanelaopç2, imgsomb1, imgsomb2, imgresoluçao1, imgresoluçao2, imgcreditos1, imgcreditos2;
        public Point POSopç = new Point(0, 0);

        //Janela CAMPANHA 
        
        public Rectangle[] Ato = new Rectangle[3]; // Quantidade de ATOS na história ((((((((( ATOs )))))))))
        public bool JANELACAMPANHA, campanhaDESLIZAR;
        public bool[] ATO = new bool[3];
        public bool[] atoB = new bool[3];
        public bool[] ATO_CAMPANHA = new bool[3];
        public Texture2D[] imgATOS = new Texture2D[3];
        public Point POSatos = new Point(0, 0);

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
        public bool ADAGATIVA, ESPADA2HATIVA, ADAGAselect, ESPADA2Hselect, MAOselect = true, setacimaB, setabaixoB, setacimaB2, setabaixoB2, ADAGAb, ESPADAb, MAOb;
        public bool ARCOATIVO, TRIDENTEATIVO, RETROCEDERATIVO, ESCUDOATIVO, VENTOATIVO, RAIOATIVO, ARCOselect, TRIDENTEselect, SLOWselect, RETROCEDERselect, ESCUDOselect, VENTOselect, RAIOselect, ARCOb, TRIDENTEb, SLOWb, RETROCEDERb, ESCUDOb, VENTOb, RAIOb;
        public Texture2D imgItemarco1, imgItemarco2, imgItemarco3, imgItemescudo1, imgItemescudo2, imgItemescudo3, imgItemraio1, imgItemraio2, imgItemraio3, imgItemretroceder1, imgItemretroceder2, imgItemretroceder3, imgItemslow1, imgItemslow2, imgItemtridente1, imgItemtridente2, imgItemtridente3, imgItemvento1, imgItemvento2, imgItemvento3;

        //QUEST
        public Texture2D imgQuest, imgRefresh1, imgRefresh2, imgOK1, imgOK2, imgOK3;
        public bool RODAR1, RODAR2, bREFRESH, bOK, JANELAQUEST, QUESTdisponivel;
        public Point tamanhoQuest = new Point(788, 613);
        public Point spriteQuest = new Point(8, 6);
        public Point frameQuest = new Point(0, 0), POSquest = new Point(0,0);
        public int Qopç, Qqtdd, Qcompletadas, Qqtddcompletada, Qtempo, Qminuto;//opç de quest/ quantidade pra terminar quest/ quantas quests completadas/ quantidade de coisas feitas na quest/ tempo;

        //ESCOLHA DE FASE
        public Texture2D imgPbranco, imgCapaMapas, imgsetamenu1, imgsetamenu2, imgsetamenu3, imgsetamenu4, imgclickmenucompra, imgcompramenu1,imgcompramenu2;
        public Texture2D[] imgfaseB = new Texture2D[10];

        public Rectangle CapaMapas = new Rectangle(), Setamenu1 = new Rectangle(), Setamenu3 = new Rectangle(), Clickmenucompra = new Rectangle(), compramenu = new Rectangle();
        public Rectangle[] Rfase = new Rectangle[10];
        public Rectangle[] linhas = new Rectangle[10];
        public Point Prolar = new Point(0, 0);
        public Point Pclickmenu = new Point(0, 0);

        public bool OPÇFASES, CLICKMENUCOMPRA, Bcompramenu;
        public bool[] Bfase = new bool[10];
        public bool[] FASEdestravada = new bool[10];
        public bool[] INFOeCOMPRAfase = new bool[10];

        public List<Itens> listadeitens = new List<Itens>();
        
        //janela normal de compras e combo 
        public bool JANELACOMBO = false, JANELACOMERCIO = false, ARMAS, PET, PODERES, bXIS, bCOMBO, bCOMERCIO, bARMAS, bPET, bPODERES;
        //pause
        public bool JANELAPAUSE, bSAIR, bRESUME;

        public void DrawCAMPANHA(SpriteBatch s, Botoes Botao, int W, int H)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);

            //capa fundo
            s.Draw(JANELA.J.imgFUNDOmenu, new Rectangle(0, 0, W, H), Color.White);

            s.DrawString(Neon, "Modo Campanha", new Vector2(POSatos.X + W / 3, POSatos.Y - H / 6), Color.White);
            for (int i = 0; i < Ato.Length; i++)
            {
                if (!Ato[i].Contains(mousePosition))
                    s.Draw(imgATOS[i], Ato[i], Color.White);
                else if (Ato[i].Contains(mousePosition) && ATO[i])
                    s.Draw(imgATOS[i], Ato[i], Color.White);
                else if (Ato[i].Contains(mousePosition) && !ATO[i])
                    s.Draw(imgATOS[i], Ato[i], Color.Red);
            }

            //botao voltar (menu)
            if (Botao.HOMEquadrado.Contains(mousePosition))
            {
                s.Draw(Botao.imghomeOFF, Botao.HOMEquadrado, Color.Gold);
                if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    s.Draw(Botao.imghomeON, Botao.HOMEquadrado, Color.Gold);
                }
            }
            else
            {
                if (Menu.m.MENU)
                    s.Draw(Botao.imghomeOFF, Botao.HOMEquadrado, Color.White);
                else if (Menu.m.COMBATES || Menu.m.CAMPANHA)
                {
                    s.Draw(Botao.imghomeOFFTP, Botao.HOMEquadrado, Color.White);
                }
            }
        }

        public void POSJANELACAMPANHA(int W, int H, bool BOTAO)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            if (Mouse.GetState().LeftButton != ButtonState.Pressed) //desclicar
            {
                BOTAO = false;
            }

            //POSIÇÕES DE CADA ATO (ISSO NA JANELA DO CAMPANHA, ANTES DE ENTRAR NO JOGO)
            for (int i = 0; i < Ato.Length; i++)
            {
                Ato[i].Width = W;
                Ato[i].X = POSatos.X;
                Ato[i].Height = H / 6 - H / 180;// 180 - 6 = 174 
                Ato[i].Y = POSatos.Y + (i * (Ato[i].Height + H / 35)); //um embaixo do outro

            }//mult

            //FAZER OS ATOS DESLIZAREM PRA DIREITA TODA VEZ QUE CLICAR
            if (!campanhaDESLIZAR)
            {
                POSatos.X += H / 15;
                if (POSatos.X >= 0)
                {
                    POSatos.X = 0;
                    campanhaDESLIZAR = true;
                }
                
            }
            else if (campanhaDESLIZAR)
            {
                for (int i = 0; i < Ato.Length; i++)
                {
                    if (ATO[i] && Ato[i].Contains(mousePosition) &&  Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        BOTAO = true;
                        atoB[i] = true;
                    }
                    if (ATO[i] && !Ato[i].Contains(mousePosition))
                        atoB[i] = false;
                    if (atoB[i] && !BOTAO)
                    {
                        ATO_CAMPANHA[i] = true;
                        Menu.m.CAMPANHA = true;
                        JANELA.J.JANELACAMPANHA = false;
                        atoB[i] = false;
                    }
                }
            }
        }

        public void DrawJANELAOPÇOES(SpriteBatch s, Botoes Botao, int W, int H, intromenu Entrada)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);

            //capa fundo
            s.Draw(JANELA.J.imgFUNDOmenu, new Rectangle(0, 0, W, H), Color.White);

            if (JANELAOPÇOES)
            {
                if (!CREDITOS)
                {
                    s.Draw(imgjanelaopç1, janelaopçao, Color.White);
                    s.Draw(imgcreditos1, creditosB, Color.White);
                }
                else if (CREDITOS)
                {
                    s.Draw(imgjanelaopç2, janelaopçao, Color.White);
                    s.Draw(imgcreditos2, creditosB, Color.White);
                }
                if (!SOM)
                {
                    s.Draw(imgsomb1, somB, Color.White);
                }
                else if (SOM)
                {
                    s.Draw(imgsomb2, somB, Color.White);
                }
                if (!RESOLUÇAO)
                {
                    s.Draw(imgresoluçao1, resoluçaoB, Color.White);
                }
                else if (RESOLUÇAO)
                {
                    s.Draw(imgresoluçao2, resoluçaoB, Color.White);
                    s.DrawString(Neon, "Clique aqui para voltar ao começo", new Vector2(janelaopçao.X + janelaopçao.Width / 4, janelaopçao.Y + janelaopçao.Height / 2), Color.White);
                }


                //botao voltar (menu)
                if (Botao.HOMEquadrado.Contains(mousePosition))
                {
                    s.Draw(Botao.imghomeOFF, Botao.HOMEquadrado, Color.Gold);
                    if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        s.Draw(Botao.imghomeON, Botao.HOMEquadrado, Color.Gold);
                    }
                }
                else
                {
                    if (Menu.m.MENU)
                        s.Draw(Botao.imghomeOFF, Botao.HOMEquadrado, Color.White);
                    else if (Menu.m.COMBATES || Menu.m.CAMPANHA)
                    {
                        s.Draw(Botao.imghomeOFFTP, Botao.HOMEquadrado, Color.White);
                    }
                }
            }
        }

        public void POSOPÇÕES(int W, int H, bool BOTAO, bool menu00, bool menu01, GraphicsDeviceManager graphics, bool[] b1, bool Bapply, bool BFULL)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            janelaopçao.X = POSopç.X;
            janelaopçao.Y = POSopç.Y;

            somB.Height = H / 16 - 1;
            resoluçaoB.Height = H / 16 - 1;
            creditosB.Height = H / 16 - 1;
            somB.Width = H / 4 + H / 20 + 1;//321 = 270 + 54
            resoluçaoB.Width = H / 4 + 4;//274 = 270 + 4
            creditosB.Width = H / 4 + H / 21;//325 = 270 + 51

            somB.X = POSopç.X;
            somB.Y = POSopç.Y;
            resoluçaoB.X = POSopç.X + somB.Width;
            resoluçaoB.Y = POSopç.Y;
            creditosB.X = POSopç.X + somB.Width + resoluçaoB.Width;
            creditosB.Y = POSopç.Y;

            janelaopçao.Width = H - H / 7 - 2;//924 = 1080 - 154 - 2
            janelaopçao.Height = H / 2 - H / 16 - 1;//540 - 67 - 1 = 472
            if (!opçDESCER)
            {
                Audio.A1.DISPONIVEL = false;
                SOM = true;
                RESOLUÇAO = false;
                CREDITOS = false;
                POSopç.X = W / 2 - janelaopçao.Width / 2;
                POSopç.Y += H / 20;
                if (POSopç.Y >= H / 2 - janelaopçao.Height / 2)
                {
                    opçDESCER = true;
                }
            }
            else if (opçDESCER)
            {
                POSopç.Y = H / 2 - janelaopçao.Height / 2;
                //              SOM
                if (somB.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed) // botao home
                {
                    BOTAO = true;
                    SOMb = true;
                }
                //se passar mouse fora
                //se passar mouse fora
                if (!somB.Contains(mousePosition))
                {
                    SOMb = false;

                }
                //passagem (para o menu do jogo)
                //passagem
                if (SOMb && !BOTAO)
                {
                    SOM = true;
                    RESOLUÇAO = false;
                    CREDITOS = false;

                    SOMb = false;
                }
                //              RESOLUÇAO
                if (resoluçaoB.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed) // botao home
                {
                    BOTAO = true;
                    RESOLUÇAOb = true;
                }
                //se passar mouse fora
                //se passar mouse fora
                if (!resoluçaoB.Contains(mousePosition))
                {
                    RESOLUÇAOb = false;

                }
                //passagem (para o menu do jogo)
                //passagem
                if (RESOLUÇAOb && !BOTAO)
                {
                    SOM = false;
                    RESOLUÇAO = true;
                    CREDITOS = false;

                    RESOLUÇAOb = false;
                }
                //              CREDITOS
                if (creditosB.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed) // botao home
                {
                    BOTAO = true;
                    CREDITOSb = true;
                }
                //se passar mouse fora
                //se passar mouse fora
                if (!creditosB.Contains(mousePosition))
                {
                    CREDITOSb = false;

                }
                //passagem (para o menu do jogo)
                //passagem
                if (CREDITOSb && !BOTAO)
                {
                    SOM = false;
                    RESOLUÇAO = false;
                    CREDITOS = true;

                    CREDITOSb = false;
                }

            }

            if (SOM)
            {
                Audio.A1.DISPONIVEL = true;
                Audio.A1.barra.X = janelaopçao.X + janelaopçao.Width / 3;
                Audio.A1.barra.Y = janelaopçao.Y + janelaopçao.Height / 2;
                Audio.A1.POS(W, H, menu00);
            }
            else if (RESOLUÇAO)
            {
                Audio.A1.DISPONIVEL = false;
                if (Mouse.GetState().LeftButton == ButtonState.Pressed && janelaopçao.Contains(mousePosition) && !resoluçaoB.Contains(mousePosition) && !creditosB.Contains(mousePosition) && !somB.Contains(mousePosition))
                {
                    BOTAO = true;
                    MudarRESULUÇAO = true;
                    
                }
                if (!janelaopçao.Contains(mousePosition))
                    MudarRESULUÇAO = false;
                if (MudarRESULUÇAO && !BOTAO)
                {
                    graphics.PreferredBackBufferWidth = 800;
                    graphics.PreferredBackBufferHeight = 600;
                    graphics.IsFullScreen = false;
                    BFULL = false;
                    Bapply = false;
                    for (int i = 0; i < b1.Length; i++)
                    {
                        b1[i] = false;
                    }
                    graphics.ApplyChanges();
                    JANELAOPÇOES = false;
                    MudarRESULUÇAO = false;
                    BOTAO = false;
                    menu01 = false;
                    menu00 = true;
                }
            }
            else if (CREDITOS)
            {
                Audio.A1.DISPONIVEL = false;
            }
        }

        public void FUNÇOESPLACAR(bool BOTAO, Personagem P1, Botoes Botao, List<Inimigo> listai1, int W, int H,Random A)
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
                                MediaPlayer.Pause();
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
                            if (P1.leiterepositório > 0 || P1.qntdcombosrepositório > 0 || P1.honrarepositório > 0)
                                Audio.A1.COINCOLLECT.Play(); //so sai som de dinheiro qnd tiver ganhado algo

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
                        Menu.m.COMBATES = false;
                        //posição volta pro começo e os inimigos somem (SAI DA FASE)
                        JANELA.J.JANELAPLACAR = false;
                        JANELA.J.ZERARFASE(listai1, P1, Botao, W, H);

                        //
                        TRANSFERIDO = false;
                        TRANSFERIRpontos = false;
                        MOSTRARpontos = false;
                        MediaPlayer.Play(Audio.A1.menusong);

                        for (int i = 0; i < Contexto.Fase.Length; i++)
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

        public void COMPLETARQuest(Personagem P1, Botoes Botao, List<Inimigo> listai1, int W, int H)
        {
            if (Menu.m.COMBATES)
            {
                if (Qqtddcompletada >= Qqtdd) // MISAO COMPLETADA
                {
                    Qcompletadas++;
                    Qqtddcompletada = 0;

                    if (Qopç == 3)
                        P1.honrarepositório++;

                    //isto acontece 2x... Qnd morrer ou qnd terminar quest
                    JANELAPLACAR = true; // leva até o placar (QND TERMINAR A QUEST)
                }


                Qtempo++;
                if (Qtempo >= 60)
                {
                    Qtempo = 0;
                    Qminuto++;
                    if (Qopç == 2 || Qopç == 3)
                    {
                        Qqtddcompletada++;
                    }
                }


            }
            else if (!Menu.m.COMBATES)
            {
                Qqtddcompletada = 0;
                Qtempo = 0;
                Qminuto = 0;
            }
        }

        public void GERARQuest(Random A)
        {
            Qopç = A.Next(1, 4); // 2 opç
            if (Qopç == 1)
            {
                //MATE
                Qqtdd = 10 + (3 * Qcompletadas); // qnt precisa pra completar
            }
            if (Qopç == 2)
            {
                //SOBREVIVA
                Qqtdd = 30 + (5 * Qcompletadas);
            }
            if (Qopç == 3)
            {
                //DEFESA
                Qqtdd = 20 + (5 * Qcompletadas);
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
                    MediaPlayer.Play(Audio.A1.combatesong);
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
                INFOeCOMPRAfase[i] = false;
                qntddefases++;
            }
            JANELA.J.FASEdestravada[0] = true;
            
        }
       
        public void FUNÇÕESOPÇFASE(int W, int H, Botoes Botao, bool BOTAO, Personagem P1)
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
                        Menu.m.MENU = false;
                        Menu.m.COMBATES = true;
                        Contexto.Fase[i] = true; // quantas fases
                        Botao.HOME = false;
                        JANELA.J.OPÇFASES = false;

                        //abre janela de quest
                        JANELA.J.JANELAQUEST = true;

                        //pra desabilitar o botao qnd sair
                        JANELA.J.Bfase[i] = false;
                    }
                }
            }

            //setas
            if (Setamenu1.Contains(mousePosition))
            {
                if (Prolar.Y < 0)
                {
                    Prolar.Y += H / 35;
                }
                if (Mouse.GetState().LeftButton == ButtonState.Pressed || Prolar.Y > 0)
                {
                    Prolar.Y = 0;
                }
            }
            if (Setamenu3.Contains(mousePosition))
            {
                if (Prolar.Y > -H)
                {
                    Prolar.Y -= H / 35;
                }
                if (Mouse.GetState().LeftButton == ButtonState.Pressed || Prolar.Y < -H)
                {
                    Prolar.Y = -H;
                }
            }

            //botao compra da opç de fases
            if (Mouse.GetState().RightButton == ButtonState.Pressed && !CLICKMENUCOMPRA)//ativar
            {
                for (int i = 0; i < Bfase.Length; i++)
                {
                    if (Rfase[i].Contains(mousePosition) && FASEdestravada[i] == false)
                    {
                        CLICKMENUCOMPRA = true;//ativa a aba
                        INFOeCOMPRAfase[i] = true; //mostra apenas aquela na qual cliquei
                        Pclickmenu.X = mouseState.X - (Prolar.X);
                        Pclickmenu.Y = mouseState.Y + H / 50 - (Prolar.Y);
                    }

                }
            }
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && CLICKMENUCOMPRA && !Clickmenucompra.Contains(mousePosition))//desativar
            {
                CLICKMENUCOMPRA = false;
                for (int i = 0; i < Bfase.Length; i++) //desativar todas as informaçoes
                {
                    INFOeCOMPRAfase[i] = false;
                }
            }

            //compra
            if (CLICKMENUCOMPRA)
            {
                if (!compramenu.Contains(mousePosition))
                    Bcompramenu = false;

                //fase arena
                if (INFOeCOMPRAfase[1] && Mouse.GetState().LeftButton == ButtonState.Pressed && compramenu.Contains(mousePosition))
                {
                    BOTAO = true;
                    Bcompramenu = true;
                }
                if (Bcompramenu && !BOTAO && INFOeCOMPRAfase[1])
                {
                    if (Qcompletadas >= 5)
                    {
                        FASEdestravada[1] = true;
                        CLICKMENUCOMPRA = false;
                        INFOeCOMPRAfase[1] = false;
                    }
                    Bcompramenu = false;
                }
                //fase floresta amaldiçoada
                if (INFOeCOMPRAfase[2] && Mouse.GetState().LeftButton == ButtonState.Pressed && compramenu.Contains(mousePosition))
                {
                    BOTAO = true;
                    Bcompramenu = true;
                }
                if (Bcompramenu && !BOTAO && INFOeCOMPRAfase[2])
                {
                    if (P1.leite >= 50 && P1.honra >= 5)
                    {
                        FASEdestravada[2] = true;
                        CLICKMENUCOMPRA = false;
                        INFOeCOMPRAfase[2] = false;
                    }
                    Bcompramenu = false;
                }
                //fase celeiro
                if (INFOeCOMPRAfase[3] && Mouse.GetState().LeftButton == ButtonState.Pressed && compramenu.Contains(mousePosition))
                {
                    BOTAO = true;
                    Bcompramenu = true;
                }
                if (Bcompramenu && !BOTAO && INFOeCOMPRAfase[3])
                {
                    if (Qcompletadas >= 50)
                    {
                        FASEdestravada[3] = true;
                        CLICKMENUCOMPRA = false;
                        INFOeCOMPRAfase[3] = false;
                    }
                    Bcompramenu = false;
                }
                //
                //fase rua japonesa
                if (INFOeCOMPRAfase[4] && Mouse.GetState().LeftButton == ButtonState.Pressed && compramenu.Contains(mousePosition))
                {
                    BOTAO = true;
                    Bcompramenu = true;
                }
                if (Bcompramenu && !BOTAO && INFOeCOMPRAfase[4])
                {
                    if (Qcompletadas >= 75 && P1.honra >= 20)
                    {
                        FASEdestravada[4] = true;
                        CLICKMENUCOMPRA = false;
                        INFOeCOMPRAfase[4] = false;
                    }
                    Bcompramenu = false;
                }
                
            }
        }

        public void POSopçfase(int W, int H)
        {
           
            var PULO = W / 2;
            var PULOH = H / 2;
            for (int i = 0; i < Rfase.Length; i++)
            {
                //FASE ((TODAS))
                if (i == 0 || i == 1)
                {
                    Rfase[i].Width = H / 3 + H / 10 - H / 400;// de lei
                    Rfase[i].Height = H / 6 + H / 250;// de lei 
                    Rfase[i].X = Prolar.X + W / 8 + (PULO * i);
                    Rfase[i].Y = Prolar.Y + H / 8;
                }
                if (i == 2 || i == 3)
                {
                    Rfase[i].Width = H / 3 + H / 10 - H / 400;// de lei
                    Rfase[i].Height = H / 6 + H / 250;// de lei 
                    if (i == 2)
                        Rfase[i].X = Prolar.X + W / 8 + (PULO);
                    if (i == 3)
                        Rfase[i].X = Prolar.X + W / 8;
                    Rfase[i].Y = Prolar.Y + H / 8 + (PULOH);
                }
                if (i == 4 || i == 5)
                {
                    Rfase[i].Width = H / 3 + H / 10 - H / 400;// de lei
                    Rfase[i].Height = H / 6 + H / 250;// de lei 
                    if (i == 5)
                        Rfase[i].X = Prolar.X + W / 8 + (PULO);
                    if (i == 4)
                        Rfase[i].X = Prolar.X + W / 8;
                    Rfase[i].Y = Prolar.Y + H / 8 + (PULOH * 2);
                }
                if (i == 6 || i == 7)
                {
                    Rfase[i].Width = H / 3 + H / 10 - H / 400;// de lei
                    Rfase[i].Height = H / 6 + H / 250;// de lei 
                    if (i == 6)
                        Rfase[i].X = Prolar.X + W / 8 + (PULO);
                    if (i == 7)
                        Rfase[i].X = Prolar.X + W / 8;
                    Rfase[i].Y = Prolar.Y + H / 8 + (PULOH * 3);
                }
                if (i == 8 || i == 9)
                {
                    Rfase[i].Width = H / 3 + H / 10 - H / 400;// de lei
                    Rfase[i].Height = H / 6 + H / 250;// de lei 
                    if (i == 9)
                        Rfase[i].X = Prolar.X + W / 8 + (PULO);
                    if (i == 8)
                        Rfase[i].X = Prolar.X + W / 8;
                    Rfase[i].Y = Prolar.Y + H / 8 + (PULOH * 3);
                }
                if (i == 10 || i == 11)
                {
                    Rfase[i].Width = H / 3 + H / 10 - H / 400;// de lei
                    Rfase[i].Height = H / 6 + H / 250;// de lei 
                    if (i == 10)
                        Rfase[i].X = Prolar.X + W / 8 + (PULO);
                    if (i == 11)
                        Rfase[i].X = Prolar.X + W / 8;
                    Rfase[i].Y = Prolar.Y + H / 8 + (PULOH * 4);
                }

                if (i < Rfase.Length)
                {
                    //LINHAS 1
                    if (i == 0 || i == 4 || i == 8 || i == 12)//direita ( 4 em 4 )
                    {
                        linhas[i].X = Rfase[i].X + Rfase[i].Width;
                        linhas[i].Y = Rfase[i].Y + Rfase[i].Height / 2;
                        linhas[i].Width = PULO - Rfase[i].Width;
                        linhas[i].Height = H / 300; // = 3
                    }

                    if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9 || i == 11 || i == 13) //descendo (2 em 2)
                    {
                        linhas[i].Width = H / 300;// = 3
                        linhas[i].Height = PULOH - Rfase[i].Height; 
                        linhas[i].X = Rfase[i].X + Rfase[i].Width / 2;
                        linhas[i].Y = Rfase[i].Y + Rfase[i].Height;
                    }
                    if (i == 2 || i == 6 || i == 10 || i == 14)//esquerda // (4 em 4)
                    {
                        linhas[i].Width = PULO - Rfase[i].Width;
                        linhas[i].Height = H / 300; // = 3
                        linhas[i].X = Rfase[i].X - linhas[i].Width; 
                        linhas[i].Y = Rfase[i].Y + Rfase[i].Height / 2;
                    }
                }
               
            }//fim multipl

            //capa
            CapaMapas.X = Prolar.X + H / 10 + H / 100 + H / 100;//128
            CapaMapas.Width = W - ((H / 10 + H / 100 + H / 100) * 2); //1920 - 256 = 1664
            CapaMapas.Y = Prolar.Y;
            CapaMapas.Height = H * 2;

            Setamenu1.Width = CapaMapas.Width;
            Setamenu3.Width = CapaMapas.Width;

            Setamenu1.Height = H / 100 + H / 10;//118
            Setamenu3.Height = H / 100 + H / 10;//118

            Setamenu1.X = CapaMapas.X;
            Setamenu3.X = CapaMapas.X;

            Setamenu1.Y = 0;
            Setamenu3.Y = H - Setamenu3.Height;

            //compra
            Clickmenucompra.Width = H / 2 + H / 24; //540 + 45
            Clickmenucompra.Height = H / 4 + H / 400; //280 + 2
            compramenu.Width = H / 5 - H / 200;//211 = 216 - 5
            compramenu.Height = H / 18 - H / 400;//58 = 60 - 2
            if (CLICKMENUCOMPRA)
            {
                Clickmenucompra.X = Pclickmenu.X + Prolar.X;
                Clickmenucompra.Y = Pclickmenu.Y + Prolar.Y;

                compramenu.X = Clickmenucompra.X + Clickmenucompra.Width / 2 - compramenu.Width / 2;//no meio
                compramenu.Y = Clickmenucompra.Y + Clickmenucompra.Height / 2 + Clickmenucompra.Height / 5;
            }


            
        }//fim void

        //

        public void ZERARFASE(List<Inimigo> listai1, Personagem P1, Botoes Botao, int W, int H)
        {
            //sai pro menu
            if (!JANELAPLACAR && !JANELAQUEST)
            {
                for (int i = 0; i < Contexto.Fase.Length; i++)
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
            P1.PODER = false;
            P1.IVUNERAVEL = false;
            P1.PODERraio = false;
            P1.PODERvento = false;

            //limpando listas
            P1.listadedano.Clear();
            P1.listaclonePoder.Clear();
            P1.listadeagua.Clear();
            P1.listadeondadeagua.Clear();
            P1.listadevisualPOWER.Clear();
            P1.listavidaperdida.Clear();
            P1.listavento.Clear();
            P1.listaraio.Clear();

            //sair do poder 
            P1.PODERslow = false;

            RETROCEDER.r.Contagem = 0;
            P1.listaclonePoder.Clear(); //limpa
            P1.PODERretroceder = false;
            RETROCEDER.r.FIM = false;
            
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

        public void FUNÇÕESCC(bool BOTAO, int W, int H, Personagem P1)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            if (Mouse.GetState().LeftButton != ButtonState.Pressed) // BOTAO não pressionado
            {
                BOTAO = false;
                contagemMouseClickB = 0; //baixo
                contagemMouseClickC = 0; //cima
                
            }

            ItensAll.a.FUNÇÕES(BOTAO, P1);// funções da janela ALL

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
                MediaPlayer.Resume();
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
                //SAI DA ABA do ALL
                for (int a = 0; a < JANELA.J.listaitensall.Count; a++)
                {
                    JANELA.J.listaitensall[a].ABASELECIONADA = false;
                }
                ItensAll.a.ABATRANCADA = false;
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
                //SAI DA ABA do ALL
                for (int a = 0; a < JANELA.J.listaitensall.Count; a++)
                {
                    JANELA.J.listaitensall[a].ABASELECIONADA = false;
                }
                ItensAll.a.ABATRANCADA = false;
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
                //SAI DA ABA do ALL
                for (int a = 0; a < JANELA.J.listaitensall.Count; a++)
                {
                    JANELA.J.listaitensall[a].ABASELECIONADA = false;
                }
                ItensAll.a.ABATRANCADA = false;
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
                    //desabilitar o poder (qnd mudar pra outro poder) - nao gerando conflito
                    P1.PODER = false;

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

                        //desabilitar o poder (qnd mudar pra outro poder) - nao gerando conflito
                        P1.PODER = false;

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

                        //desabilitar o poder (qnd mudar pra outro poder) - nao gerando conflito
                        P1.PODER = false;

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

                        //desabilitar o poder (qnd mudar pra outro poder) - nao gerando conflito
                        P1.PODER = false;

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

                        //desabilitar o poder (qnd mudar pra outro poder) - nao gerando conflito
                        P1.PODER = false;

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
            //
            //Itens all
            ItensAll.a.POS(W, H);

        }//fim poss

       
        
    }//fim da classe.......................... 

    
}
