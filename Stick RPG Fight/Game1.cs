﻿using Microsoft.Xna.Framework;
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
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //inicio
        //gerador de numero randomico
        Random aleatório;

        //booleaveis usuais comuns no game
        bool menu00 = true, menu01, Bapply, BFULL, BOTAO, UMAVEZ = true, SAIU;
        bool[] b1 = new bool[5];//botoes do menu
        Rectangle[] B1 = new Rectangle[5]; //botao
        Rectangle Bfull, APPLY ;

        public Rectangle FlechaE, FlechaD;
        public bool Frenteflecha;
        public Point posflecha = new Point(0, 0);

        //fonte escrita do jogo
        SpriteFont menu;
        SpriteFont HUDfont, BARfont;

        //imagens de itens fora das classes
        Texture2D imgB1, imgB2, imgAPPLY2, imgAPPLY, imgAPPLY3, imgteste, imgFlechaD, imgFlechaE, imgSangue;

        //LISTA DE CLASSES------
        //LISTA DE CLASSES
        //LISTA DE CLASSES
        //intro
        intromenu Entrada = new intromenu();

       

        // 1 personagem player só
        Personagem P1 = new Personagem();

        //novo botao pro menu
        Botoes Botao = new Botoes();

        //nova lista de i1
        List<Inimigo> listai1 = new List<Inimigo>();

        Agua DefineAgua = new Agua();
        //LISTA DE CLASSES
        //LISTA DE CLASSES
        //LISTA DE CLASSES --------

        //tempo para gerar 1/++ inimigo 
        int TempoParaInimigos = 100;
        //slow motion
        public static int slowmotion = 0;

        //contagem
        int contagemREGEN = 0;
        int contagemGERADOR = 0;
        //fim
        Draw DRAW = new Draw();
        Inimigo i1 = new Inimigo();

       

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {

            Window.Title = "Lethal Milker";

            aleatório = new Random();

            //botão menu00
            for (int i = 0; i < B1.Length; i++)
            {
                B1[i] = new Rectangle(Window.ClientBounds.Width / 4 + (i * Window.ClientBounds.Width / 10), Window.ClientBounds.Height - Window.ClientBounds.Height / 8, Window.ClientBounds.Width / 16, Window.ClientBounds.Height / 12);
            }
            APPLY = new Rectangle(Window.ClientBounds.Width / 4, Window.ClientBounds.Height / 8, Window.ClientBounds.Width / 3, Window.ClientBounds.Width / 3);
            Bfull = new Rectangle(B1[4].X, Window.ClientBounds.Height - Window.ClientBounds.Height / 4, Window.ClientBounds.Width / 16, Window.ClientBounds.Height / 12);

            MediaPlayer.IsRepeating = true;

            for (int i = 0; i < Contexto.Fase.Length; i++)
            {
                Contexto.Fase[i] = false;
            }

            JANELA.J.ATO[0] = true;
            
            JANELA.J.CRIARlinhas();//cria se linhas do menu
            Itens.IT.CRIARITENS();//cria se itens da janela cc
            ItensAll.a.Criar();//cria itens para selecionar


            //faz o save que possa ter, e caso nao tenha, faz a primeira vez
            Audio.A1.PRIMEIRAvez(Window.ClientBounds.Width, Window.ClientBounds.Height);

            //
            Savegame.S.Leitura(P1); //carrega o jogo antes de começar
            Savegame.S.Leitura2(); //leitura feita no começo do game (esse save é feito quando clica em botao SAIR, no menu)

           
            
            base.Initialize();
        }


        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Contexto.inicializar(Content,  P1, Botao, i1, DefineAgua); // classe contexto

            menu = Content.Load<SpriteFont>("menu");
            HUDfont = Content.Load<SpriteFont>("HUD");
            BARfont = Content.Load<SpriteFont>("BAR");

            imgB1 = Content.Load<Texture2D>("B1");
            imgB2 = Content.Load<Texture2D>("B2");

            imgAPPLY = Content.Load<Texture2D>("B APPLY");
            imgAPPLY2 = Content.Load<Texture2D>("B APPLY2");
            imgAPPLY3 = Content.Load<Texture2D>("B APPLY3");

            imgFlechaD = Content.Load<Texture2D>("Flecha D");
            imgFlechaE = Content.Load<Texture2D>("Flecha E");

            imgSangue = Content.Load<Texture2D>("sangue");

            imgteste = Content.Load<Texture2D>("teste");
            //--
        }


        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            //universal

            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);


            if (Mouse.GetState().LeftButton != ButtonState.Pressed) // BOTAO não pressionado
            {
                BOTAO = false;
            }
            TUTORIAL.t.FUNÇÃO(menu01);


            //GAME
            if (!JANELA.J.JANELACOMBO && !JANELA.J.JANELACOMERCIO && !JANELA.J.JANELAPAUSE && !JANELA.J.OPÇFASES && !JANELA.J.JANELAQUEST && !JANELA.J.JANELAPLACAR && !JANELA.J.JANELAOPÇOES && !JANELA.J.JANELACAMPANHA)
            {
                if (menu01 || Menu.m.COMBATES || Menu.m.CAMPANHA)
                {
                    var WidthTela = Window.ClientBounds.Width;
                    var HeightTela = Window.ClientBounds.Height;

                    //HOME 
                    //  HOME
                    //  HOME
                    //  HOME
                    //  HOME
                    if (Botao.HOME == true) // caso eu esteja na HOME
                    {
                        Menu.m.MENU = true;


                        //sai do modo COMBATE e do modo HISTORIA
                        Menu.m.COMBATES = false;
                        Menu.m.CAMPANHA = false;
                    }

                   
                    //
                    //clicando
                    //----  HOME
                    //BOTAO HOME
                    //BOTAO HOME
                    //BOTAO HOME
                    //BOTAO HOME
                    if (!Botao.HOME)
                    {
                        if (Botao.HOMEquadrado.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed) // botao home
                        {
                            BOTAO = true;
                            Botao.HOMEb = true;
                            
                            JANELA.J.POSIÇÃOPAUSE(WidthTela, HeightTela);
                        }
                        //se passar mouse fora
                        //se passar mouse fora
                        if (!Botao.HOMEquadrado.Contains(mousePosition))
                        {
                            Botao.HOMEb = false;

                        }
                        //passagem (para o menu do jogo)
                        //passagem
                        if (Botao.HOMEb && !BOTAO)
                        {
                            JANELA.J.JANELAPAUSE = true;
                            MediaPlayer.Pause();
                        }
                    }

                    //BOTAO COMERCIO
                    //BOTAO COMERCIO
                    //BOTAO COMERCIO
                    //BOTAO COMERCIO
                    if (Botao.COMERCIOquadrado.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        BOTAO = true;
                        Botao.COMERCIOb = true;

                    }
                    //se passar fora do mouse
                    if (!Botao.COMERCIOquadrado.Contains(mousePosition))
                    {
                        Botao.COMERCIOb = false;

                    }
                    //passagem (abrir janela)
                    if (Botao.COMERCIOb && !BOTAO)//
                    {
                        MediaPlayer.Pause();
                        JANELA.J.JANELACOMERCIO = true; // trava a tela
                        Botao.COMERCIOb = false;
                    }


                    //BOTAO COMBOS
                    //BOTAO COMBOS
                    //BOTAO COMBOS
                    //BOTAO COMBOS
                    if (Botao.COMBOSquadrado.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        BOTAO = true;
                        Botao.COMBOSb = true;

                    }
                    //se passar fora do mouse
                    if (!Botao.COMBOSquadrado.Contains(mousePosition))
                    {
                        Botao.COMBOSb = false;

                    }
                    //passagem (abrir janela)
                    if (Botao.COMBOSb && !BOTAO)//
                    {
                        MediaPlayer.Pause();
                        JANELA.J.JANELACOMBO = true; // trava a tela
                        Botao.COMBOSb = false;
                    }

                    //FORA DE GAME (menu)
                    if (!Menu.m.COMBATES && !Menu.m.CAMPANHA)
                    {
                        //botao de combate
                        if (Mouse.GetState().LeftButton == ButtonState.Pressed && Menu.m.CombateB.Contains(mousePosition))
                        {
                            BOTAO = true;
                            Menu.m.COMBATEb = true;
                        }
                        if (!Menu.m.CombateB.Contains(mousePosition))//se nao estiver encima, desativa
                        {
                            Menu.m.COMBATEb = false;
                            
                        }

                        if (!BOTAO && Menu.m.COMBATEb) //se soltar o botao apos ter clicado encima
                        {
                            Menu.m.COMBATEb = false;
                            JANELA.J.GERARQuest(aleatório); //cria uma quest antes de entra na fase
                            JANELA.J.OPÇFASES = true;
                            JANELA.J.ZERARFASE(listai1, P1, Botao, WidthTela, HeightTela);
                            //MediaPlayer.Play(AUDIO.combatesong);
                            MediaPlayer.Pause();
                            
                        }

                        //sair
                        if (Menu.m.SairB.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                        {
                            BOTAO = true;
                            Menu.m.SAIRb = true;
                        }
                        if (!Menu.m.SairB.Contains(mousePosition))
                            Menu.m.SAIRb = false;
                        if (Menu.m.SAIRb && !BOTAO)//botao pra saida
                        {
                            Menu.m.SAIRb = false;
                            Savegame.S.Gravacao2();
                            SAIU = true;
                            Exit();
                        }

                        //carregar
                        if (Menu.m.CarregarB.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                        {
                            BOTAO = true;
                            Menu.m.CARREGARb = true;
                        }
                        if (!Menu.m.CarregarB.Contains(mousePosition))
                            Menu.m.CARREGARb = false;

                        if (Menu.m.CARREGARb && !BOTAO)
                        {
                            Savegame.S.Leitura(P1);
                            Savegame.S.Leitura2();
                            Menu.m.CARREGARb = false;
                        }
                        //gravar
                        if (Menu.m.SalvarB.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                        {
                            BOTAO = true;
                            Menu.m.SALVARb = true;
                        }
                        if (!Menu.m.SalvarB.Contains(mousePosition))
                            Menu.m.SALVARb = false;

                        if (Menu.m.SALVARb && !BOTAO)
                        {
                            Savegame.S.Gravacao(P1);
                            Menu.m.SALVARb = false;
                        }

                        //OPÇÕES
                        if (Menu.m.OpçoesB.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                        {
                            BOTAO = true;
                            Menu.m.OPÇOESb = true;
                        }
                        if (!Menu.m.OpçoesB.Contains(mousePosition))
                            Menu.m.OPÇOESb = false;

                        if (Menu.m.OPÇOESb && !BOTAO)
                        {
                            JANELA.J.opçDESCER = false;
                            JANELA.J.POSopç.Y = 0 - JANELA.J.janelaopçao.Height;
                            JANELA.J.POSopç.X = WidthTela / 2 - JANELA.J.janelaopçao.Width / 2;
                            JANELA.J.JANELAOPÇOES = true;
                            Menu.m.OPÇOESb = false;
                        }

                        //CAMPANHA
                        if (Menu.m.CampanhaB.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                        {
                            BOTAO = true;
                            Menu.m.CAMPANHAb = true;
                        }
                        if (!Menu.m.CampanhaB.Contains(mousePosition))
                            Menu.m.CAMPANHAb = false;

                        if (Menu.m.CAMPANHAb && !BOTAO)
                        {
                            JANELA.J.campanhaDESLIZAR = false;
                            JANELA.J.POSatos[0].X = -WidthTela;
                            JANELA.J.POSatos[1].X = -WidthTela - WidthTela / 2;
                            JANELA.J.POSatos[2].X = -WidthTela * 2;

                            for (int i = 0; i < JANELA.J.POSatos.Length; i++)
                                JANELA.J.POSatos[i].Y = HeightTela / 4;

                            JANELA.J.JANELACAMPANHA = true;
                            Menu.m.CAMPANHAb = false;
                        }

                    }//fim menu


                    //FIM DO UNIVERSAL ITENS:
                    //FIM DO UNIVERSAL ITENS:
                    //FIM DO UNIVERSAL ITENS:
                    //FIM DO UNIVERSAL ITENS:

                }// botoes so funcionam no menu ou jogo




                //                                                           menu



                //============================================================ MENU ===================================================
                //============================================================ MENU ===================================================
                if (Menu.m.MENU && !Menu.m.COMBATES && !Menu.m.CAMPANHA && !SAIU)
                {
                    if (menu00)
                    {
                        IsMouseVisible = true;
                        menu01 = false;

                        //VOLUME
                        Audio.A1.POS(Window.ClientBounds.Width, Window.ClientBounds.Height, menu00);

                        Entrada.INTROMENU(b1, Bapply, B1, APPLY, Bfull, BFULL, graphics); // tentativa de guardar o codigo em uma classe (fail)

                        

                        if (Mouse.GetState().LeftButton == ButtonState.Pressed && Bfull.Contains(mousePosition))
                        {
                            BFULL = true;
                        }
                        else if (Mouse.GetState().LeftButton == ButtonState.Pressed && !Bfull.Contains(mousePosition) && !APPLY.Contains(mousePosition) && !B1[0].Contains(mousePosition) && !B1[1].Contains(mousePosition) && !B1[2].Contains(mousePosition) && !B1[3].Contains(mousePosition) && !B1[4].Contains(mousePosition))
                        {
                            BFULL = false;
                        }

                        for (int i = 0; i < B1.Length; i++)//qnd clicar no APPLY changes 
                        {
                            if (Mouse.GetState().LeftButton == ButtonState.Pressed && APPLY.Contains(mousePosition) && b1[i])
                            {
                                BOTAO = true;
                                Bapply = true;
                            }

                            if (!BOTAO && Mouse.GetState().LeftButton != ButtonState.Pressed && b1[i] && Bapply) //transição de telas
                            {
                                //inimigo1.Add();

                                MediaPlayer.Play(Audio.A1.menusong);
                                graphics.ApplyChanges();
                                menu00 = false;//sai pro proximo menu
                                menu01 = true;

                                Audio.A1.DISPONIVEL = false; // o audio para de funcionar
                               

                            }//fim da transição

                        }

                        if (Mouse.GetState().LeftButton == ButtonState.Pressed && !APPLY.Contains(mousePosition))
                        {
                            Bapply = false;
                        }

                    }//fim do menu00

                    if (menu01)
                    {
                        var W = Window.ClientBounds.Width;
                        var H = Window.ClientBounds.Height;    

                        LEVEL.l.POS(W, H, P1);
                        JANELA.J.POSIÇÃOPAUSE(W, H);
                        if (UMAVEZ)
                        {
                            ATUALIZAÇÃO.ATLZÇ.AtualizaTamanhoComeço(W, H, Botao, P1, FlechaE, FlechaD); // retangulos
                            UMAVEZ = false;

                            //flecha
                            FlechaD = new Rectangle(W - H / 11, H - H / 11, H / 11, H / 11);
                            FlechaE = new Rectangle(0, H - H / 11, H / 11, H / 11);

                            JANELA.J.POSatos[0].X = -W;
                            JANELA.J.POSatos[1].X = -W - W / 2;
                            JANELA.J.POSatos[2].X = -W * 2;

                            for (int i = 0; i < JANELA.J.POSatos.Length; i++ )
                                JANELA.J.POSatos[i].Y = H / 4;

                            MediaPlayer.Play(Audio.A1.menusong);
                        }

                        P1.RPGatualização(W, H);
                        Menu.m.menu01GAME(W, H, P1, aleatório); //RESUMAO 
                        JANELA.J.COMPLETARQuest(P1, Botao, listai1, W, H);
                        JANELA.J.POSQUEST(W, H);
                        JANELA.J.SELECIONADOS[0] = true;
                        

                    }//fim menu1
                }// FIM DO INICIO

                // #--------------------------------------------------------------------------------- jogo ------------------------------------------------------#





                // #--------------------------------------------------------------------------------- jogo ------------------------------------------------------#





                // #--------------------------------------------------------------------------------- jogo ------------------------------------------------------#
                if (Menu.m.COMBATES)
                {

                    var WidthTela = Window.ClientBounds.Width;
                    var HeightTela = Window.ClientBounds.Height;

                    Contexto.Fundo.atualizaçao(Contexto.Fundo, HeightTela);
                    Audio.A1.POS(WidthTela, HeightTela, menu00);

                    if (Keyboard.GetState().IsKeyDown(Keys.Escape))//saida
                        Botao.HOMEb = true; //é como se clicasse no botao home

                    //mov da flecha
                    FlechaD.X += posflecha.X;
                    FlechaE.X += posflecha.X;
                    if (Frenteflecha)
                    {
                        posflecha.X++;
                        if (posflecha.X >= Window.ClientBounds.Height / 300)// /3
                        {
                            Frenteflecha = false;
                        }
                    }
                    else if (!Frenteflecha)
                    {
                        posflecha.X--;
                        if (posflecha.X <= -Window.ClientBounds.Height / 300)// /3
                        {
                            Frenteflecha = true;
                        }
                    }

                    //METODOS
                    //METODOS
                    //mostrar tamanho da janela do combo
                    COMBO.c.TamanhoEatz(WidthTela, HeightTela, P1);

                    //quest
                    JANELA.J.COMPLETARQuest(P1, Botao, listai1, WidthTela, HeightTela);
                    JANELA.J.POSQUEST(WidthTela, HeightTela);

                    //placar
                    JANELA.J.POSPLACAR(WidthTela, HeightTela);

                    //TUDO do personagem
                    P1.MOV(WidthTela, HeightTela, aleatório); // tudo sobre movimentação (+metodos)
                    P1.RPGatualização(WidthTela, HeightTela); //atualiza os dados
                    P1.Luta(WidthTela, HeightTela, aleatório); // atualiza a posição, tamanho, frames
                    ESCUDO.e.POS(WidthTela, HeightTela, P1, listai1); //poder escudo (posição)
                    RETROCEDER.r.FUNÇÃO(P1);//voltar no tempo
                    VENTO.V.Funçao(P1, WidthTela, HeightTela, listai1);//vento
                    RAIO.r.FUNÇAO(P1, WidthTela, HeightTela, listai1);

                    if (Contexto.Fase[0])
                    {
                        P1.SubirAgua(WidthTela, HeightTela, aleatório);
                        P1.OndasH2O(WidthTela, HeightTela);
                    }

                    //posiçao do bot
                    for (int i = 0; i < listai1.Count; i++) // atualização de todos os inimigos
                    {
                        listai1[i].PosiçãoINIMIGO(WidthTela, HeightTela, aleatório, P1, listai1); ///NELA CONTEM TODOS OS OUTROS MÉTODOS DO INIMIGO <-
                    }

                    // SEPARADO --- PARA PODER USAR O PODER DE SLOW MOTION + CLONES
                    if (P1.PODERslow)
                    {
                        //preço
                        if (P1.mana > 0)
                            P1.mana -= 1;
                        else if (P1.mana <= 0)
                        {
                            P1.PODER = false;
                            P1.listaclonePoder.Clear(); // apagam os clones qnd n tiver mais poder
                            
                        }

                        P1.POSIÇÃOdoCLONE(P1);

                        //se eu atacar, eless vao reagir , mesmo no slowmotiom
                        for (int i = 0; i < listai1.Count; i++)
                        {
                            if (P1.individuo.Intersects(listai1[i].individuo) && P1.ATACANDO && listai1[i].TOMANDOHIT)
                            {
                                listai1[i].INTELIGENCIA(WidthTela, HeightTela, P1, listai1, aleatório);
                            }
                        }



                        //açao
                        //açao
                        //açao
                        //açao
                        if (slowmotion == 7)
                        {
                            //mov do bot
                            for (int i = 0; i < listai1.Count; i++) // atualização de todos os inimigos
                            {
                                listai1[i].MOV(WidthTela, HeightTela, aleatório, P1);
                                listai1[i].INTELIGENCIA(WidthTela, HeightTela, P1, listai1, aleatório);
                            }
                            //gerador de inimigos
                            TempoParaInimigos++;
                            if (TempoParaInimigos >= 500)
                            {
                                for (int G = 0; G < JANELA.J.qtddOLEADA; G++)
                                {
                                    if (listai1.Count >= 70)
                                    {
                                        JANELA.J.qtddOLEADA = 1;
                                    }
                                    i1.GERARi1(listai1, WidthTela, HeightTela, aleatório, P1);
                                }
                                TempoParaInimigos = 0;
                                JANELA.J.qtddOLEADA++;
                            }
                            
                            slowmotion = 0;
                        }
                        else
                        {
                            slowmotion++;
                        }
                        if (contagemGERADOR == 5)
                        {
                            P1.GERADORdeCLONES(P1);
                            contagemGERADOR = 0;
                        }
                        else
                        {
                            contagemGERADOR++;
                        }

                    }//fim poder slow
                    else
                    {
                        //mov do bot
                        for (int i = 0; i < listai1.Count; i++) // atualização de todos os inimigos
                        {
                            listai1[i].MOV(WidthTela, HeightTela, aleatório, P1);
                            listai1[i].INTELIGENCIA(WidthTela, HeightTela, P1, listai1, aleatório);
                        }
                        //gerador de inimigos
                        TempoParaInimigos++;
                        if (TempoParaInimigos >= 500)
                        {
                            for (int G = 0; G < JANELA.J.qtddOLEADA; G++)
                            {
                                if (listai1.Count >= 70)
                                {
                                    JANELA.J.qtddOLEADA = 1;
                                }
                                i1.GERARi1(listai1, WidthTela, HeightTela, aleatório, P1);
                            }
                            JANELA.J.qtddOLEADA++;
                            TempoParaInimigos = 0;
                        }
                        
                    }


                    //definir o combate
                    for (int i = 0; i < listai1.Count; i++) // atualização de todos os inimigos
                    {
                        if (listai1[i].individuo.Intersects(JANELA.J.FUNDO)) // se ele estiver NA TELA
                        {
                            P1.COMBATE = true;
                        }
                        else if (listai1.Count == 0) // se ele nao estiver NA TELA
                        {
                            P1.COMBATE = false;
                        }
                    }


                    //constantes (AUMENTA ENERGIA OU MANA COM O TEMPO)
                    if (P1.energia < P1.energiaTOTAL && !P1.CORRENDO && !P1.PULANDOcorrendo && !P1.ATACANDO)
                    {
                        P1.energia += 2;
                    }
                    if (P1.mana < P1.manaTOTAL && (!P1.PODER || P1.PODERescudo))//regenera tmb com o escudo ligado
                    {
                        if (contagemREGEN >= 2)
                        {
                            P1.mana += P1.UMporcento;
                            contagemREGEN = 0;
                        }
                        else
                        {
                            contagemREGEN++;
                        }
                    }

                    //ATIVAR PODER QUE ESTIVER DESTRAVADO
                    if (Keyboard.GetState().IsKeyDown(Keys.NumPad5) && (!P1.PODER || P1.PODERescudo))
                    {
                        P1.PODER = true;
                        //MediaPlayer.Play(AUDIO.PODERsong);

                        //SLOW
                        if (JANELA.J.SLOWselect && P1.mana >= 75)
                        {
                            P1.PODERslow = true;
                            //
                            P1.VISUPODER(); // criar efeito especial
                            P1.COLIDINDOdireita = false; // não ter colisao
                            P1.COLIDINDOesquerda = false;
                            P1.SENDOAGARRADO = false;
                        }
                        else
                        {
                            P1.PODERslow = false;
                        }
                        //RETROCEDER
                        //ESCUDO
                        ESCUDO.e.ATIVAR(P1);
                        RETROCEDER.r.ATIVAR(P1);
                        VENTO.V.ATIVAR(P1, WidthTela, HeightTela);
                        RAIO.r.ATIVAR(P1, WidthTela, HeightTela);
                    }
                    if (!P1.PODER)
                    {
                        P1.PODERslow = false;
                        P1.PODERretroceder = false;
                        P1.PODERvento = false;
                        P1.PODERraio = false;
                        P1.PODERescudo = false;
                    }
                    if (!P1.PODERslow && !P1.PODERretroceder && !P1.PODERvento && !P1.PODERraio && !P1.PODERescudo)
                    {
                        P1.PODER = false;
                    }


                }//fim do combate

                //PAUSE
                //PAUSE
                //PAUSE
                //PAUSE
                //PAUSE
            }//FIM DO QUE PAUSA A TELA (botões: COMBATE E COMERCIO || PAUSE || OPÇ das fases)
            //janela principal
            if (JANELA.J.JANELACOMBO || JANELA.J.JANELACOMERCIO)
            {
                var WidthTela = Window.ClientBounds.Width;
                var HeightTela = Window.ClientBounds.Height;

                JANELA.J.FUNÇÕESCC(BOTAO, WidthTela, HeightTela, P1); // janelas

                JANELA.J.POSIÇÃOCC(WidthTela, HeightTela);
                Info.I.POS(WidthTela, HeightTela);

            }
            //PAUSE
            if (JANELA.J.JANELAPAUSE)
            {
                var WidthTela = Window.ClientBounds.Width;
                var HeightTela = Window.ClientBounds.Height;
                //PAUSADO
                //PAUSADO
                //PAUSADO
                //PAUSADO

                JANELA.J.FUNÇÕESPAUSE(BOTAO, listai1, P1, Botao, WidthTela, HeightTela); // pause
            }
            //FASES
            if (JANELA.J.OPÇFASES)
            {
                var WidthTela = Window.ClientBounds.Width;
                var HeightTela = Window.ClientBounds.Height;
                JANELA.J.FUNÇÕESOPÇFASE(WidthTela, HeightTela, Botao, BOTAO, P1);
                JANELA.J.POSopçfase(WidthTela, HeightTela);
                //para sair dessa opçao
                //X
                if (Botao.HOMEquadrado.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed) // botao home
                {
                    BOTAO = true;
                    Botao.HOMEb = true;

                    JANELA.J.POSIÇÃOPAUSE(WidthTela, HeightTela);
                }
                //se passar mouse fora
                //se passar mouse fora
                if (!Botao.HOMEquadrado.Contains(mousePosition))
                {
                    Botao.HOMEb = false;

                }
                //passagem (para o menu do jogo)
                //passagem
                if (Botao.HOMEb && !BOTAO)
                {
                    JANELA.J.OPÇFASES = false;
                    MediaPlayer.Resume();
                }
                
            }
            //QUEST
            if (JANELA.J.JANELAQUEST)
            {
                var WidthTela = Window.ClientBounds.Width;
                var HeightTela = Window.ClientBounds.Height;
                JANELA.J.POSQUEST(WidthTela, HeightTela);
                JANELA.J.FUNÇOESQUEST(BOTAO, aleatório);
            }
            //PLACAR
            if (JANELA.J.JANELAPLACAR)
            {
                var WidthTela = Window.ClientBounds.Width;
                var HeightTela = Window.ClientBounds.Height;
                JANELA.J.POSPLACAR(WidthTela, HeightTela);
                JANELA.J.FUNÇOESPLACAR(BOTAO, P1, Botao, listai1, WidthTela, HeightTela, aleatório);

                //mostrar tamanho da janela do combo
                COMBO.c.TamanhoEatz(WidthTela, HeightTela, P1);
            }
            //OPÇ
            if (JANELA.J.JANELAOPÇOES)
            {
                var WidthTela = Window.ClientBounds.Width;
                var HeightTela = Window.ClientBounds.Height;
                JANELA.J.POSOPÇÕES(WidthTela, HeightTela, BOTAO, menu00, menu01, graphics, b1, Bapply, BFULL);
                //X
                if (Botao.HOMEquadrado.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed) // botao home
                {
                    BOTAO = true;
                    Botao.HOMEb = true;

                    JANELA.J.POSIÇÃOPAUSE(WidthTela, HeightTela);
                }
                //se passar mouse fora
                //se passar mouse fora
                if (!Botao.HOMEquadrado.Contains(mousePosition))
                {
                    Botao.HOMEb = false;

                }
                //passagem (para o menu do jogo)
                //passagem
                if (Botao.HOMEb && !BOTAO)
                {
                    JANELA.J.JANELAOPÇOES = false;
                    JANELA.J.opçDESCER = false;
                    JANELA.J.POSopç.Y = 0 - JANELA.J.janelaopçao.Height;
                    MediaPlayer.Resume();
                }
            }

            //CAMPANHA
            if (JANELA.J.JANELACAMPANHA)
            {
                var W = Window.ClientBounds.Width;
                var H = Window.ClientBounds.Height;

                JANELA.J.POSJANELACAMPANHA(W, H, BOTAO);

                //X
                if (Botao.HOMEquadrado.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed) // botao home
                {
                    BOTAO = true;
                    Botao.HOMEb = true;

                    JANELA.J.POSIÇÃOPAUSE(W, H);
                }
                //se passar mouse fora
                //se passar mouse fora
                if (!Botao.HOMEquadrado.Contains(mousePosition))
                {
                    Botao.HOMEb = false;

                }
                //passagem (para o menu do jogo)
                //passagem
                if (Botao.HOMEb && !BOTAO)
                {
                    JANELA.J.JANELACAMPANHA = false;
                    JANELA.J.campanhaDESLIZAR = false;
                    
                    JANELA.J.POSatos[0].X = -W;
                    JANELA.J.POSatos[1].X = -W - W/2;
                    JANELA.J.POSatos[2].X = -W * 2;

                    MediaPlayer.Resume();
                }
            }
                
           

            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            var WidthTela = Window.ClientBounds.Width;
            var HeightTela = Window.ClientBounds.Height;

            spriteBatch.Begin();


            if (Menu.m.MENU)
            {

                if (menu00)
                {
                    DRAW.Drawmenu00(WidthTela, HeightTela, spriteBatch, imgAPPLY2, imgAPPLY3, imgAPPLY, APPLY, Bapply, B1, imgB1, imgB2, b1, BFULL, menu, Bfull); // resumao
                    DRAW.DrawAudio(spriteBatch);
                }

                if (menu01)
                {
                    DRAW.Drawmenu01(spriteBatch, WidthTela, HeightTela, menu); // resumao
                }
            }//FIM DO MENU



            if (Menu.m.COMBATES)
            {

                DRAW.DrawCombate(spriteBatch, P1, listai1, FlechaD, FlechaE, imgFlechaD, imgFlechaE, menu, HUDfont, WidthTela, HeightTela, imgSangue, i1, DefineAgua, BARfont); //RESUMAO
                DRAW.DrawDano(spriteBatch, P1);// dano na tela (ou cura)
                //poderes
                DRAW.DrawCLONES(spriteBatch, P1); // PODER clones
                ESCUDO.e.Draw(spriteBatch, P1);
                VENTO.V.Draw(spriteBatch, P1);
                RAIO.r.Draw(spriteBatch, P1);
                DRAW.DrawCOMBOS(spriteBatch, WidthTela, HeightTela, P1); // face dos combos (mostrando)

                //spriteBatch.DrawString(menu, "LISTA: " + listai1.Count, new Vector2(0, Window.ClientBounds.Height - 15), Color.Black); //teste

            }//FIM DO COMBATE

            //botao menu e comercio
            DRAW.DrawBotaoEstatico(Botao, spriteBatch); //resumo dos botoes
            if (JANELA.J.JANELACOMBO || JANELA.J.JANELACOMERCIO)
            {
                DRAW.DrawJANELACC(Botao, spriteBatch, P1);
            }

            if (JANELA.J.JANELAPAUSE)
            {
                DRAW.DrawMENUPAUSE(spriteBatch, WidthTela, HeightTela);
            }
            if (JANELA.J.OPÇFASES)
            {
                DRAW.DrawJANELAopçfase(Botao, spriteBatch,BOTAO, P1);
            }
            if (JANELA.J.JANELAQUEST)
            {
                DRAW.DrawQUEST(spriteBatch, WidthTela, HeightTela);
            }
            if (JANELA.J.JANELAPLACAR)
            {
                DRAW.DrawPLACAR(spriteBatch, WidthTela, HeightTela, P1);
            }
            if (JANELA.J.JANELAOPÇOES)
            {
                JANELA.J.DrawJANELAOPÇOES(spriteBatch, Botao, WidthTela, HeightTela, Entrada);
                if (Audio.A1.DISPONIVEL)
                    DRAW.DrawAudio(spriteBatch);
            }
            if (JANELA.J.JANELACAMPANHA)
            {
                JANELA.J.DrawCAMPANHA(spriteBatch, Botao, WidthTela, HeightTela);
            }
            DRAW.DrawINFO(spriteBatch, WidthTela, HeightTela);

            TUTORIAL.t.Draw(spriteBatch, menu01, WidthTela, HeightTela);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
