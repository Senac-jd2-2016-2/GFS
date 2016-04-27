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
        bool MENU = true, menu00 = true, menu01, Bapply, BFULL, BOTAO;
        bool[] b1 = new bool[5];//botoes do menu
        Rectangle[] B1 = new Rectangle[5]; //botao
        Rectangle Bfull, APPLY, TELACHEIA, FlechaE, FlechaD;

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

        //menu e o audio
        Menu M1 = new Menu();
        Audio AUDIO = new Audio();

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
       
        //MAPAS

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        
        protected override void Initialize()
        {
           
            Window.Title = "Stick RPG Fight";
            
            aleatório = new Random();

            //botão menu00
            for (int i = 0; i < B1.Length; i++)
            {
                B1[i] = new Rectangle(Window.ClientBounds.Width / 4 + (i * Window.ClientBounds.Width / 10), Window.ClientBounds.Height - Window.ClientBounds.Height / 8, Window.ClientBounds.Width / 16, Window.ClientBounds.Height / 12);
            }
            APPLY = new Rectangle(Window.ClientBounds.Width / 4, Window.ClientBounds.Height / 8, Window.ClientBounds.Width / 3, Window.ClientBounds.Width / 3);
            Bfull = new Rectangle(B1[4].X, Window.ClientBounds.Height - Window.ClientBounds.Height / 4, Window.ClientBounds.Width / 16, Window.ClientBounds.Height / 12);

            MediaPlayer.IsRepeating = true;

            //novo inimigo

            

            base.Initialize();
        }

        
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Contexto.inicializar(Content, M1, AUDIO, P1, Botao, i1, DefineAgua); // classe contexto

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

            if (!JANELA.J.JANELACOMBO && !JANELA.J.JANELACOMERCIO)
            {
                if (menu01 || M1.COMBATE || M1.HISTORY)
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
                        MENU = true;


                        //sai do modo COMBATE e do modo HISTORIA
                        M1.COMBATE = false;
                        M1.HISTORY = false;
                    }
                    //PAUSADO
                    //PAUSADO
                    //PAUSADO
                    //PAUSADO
                    if (JANELA.J.JANELAPAUSE)
                    {
                        JANELA.J.FUNÇÕESPAUSE(BOTAO, listai1, P1, Botao, WidthTela, HeightTela);
                    }

                    //clicando pra entrar no MODO combate (DENTRO DO MENU)
                    //clicando pra entrar no combate
                    //clicando pra entrar no combate
                    //clicando pra entrar no combate
                    //clicando pra entrar no combate
                    if (Mouse.GetState().LeftButton == ButtonState.Pressed && M1.CombateBotao.Contains(mousePosition))
                    {
                        BOTAO = true;
                        M1.COMBATEativado = true;
                        MediaPlayer.Pause();
                    }

                    if (!M1.CombateBotao.Contains(mousePosition))//se nao estiver encima, desativa
                    {
                        M1.COMBATEativado = false;
                        MediaPlayer.Resume();
                    }

                    if (!BOTAO && M1.COMBATEativado) //se soltar o botao apos ter clicado encima
                    {

                        MENU = false;
                        M1.COMBATE = true;
                        Contexto.Fase1 = true;
                        Botao.HOME = false;
                        //MediaPlayer.Play(AUDIO.combatesong);
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
                            MediaPlayer.Pause();
                        }
                        //se passar mouse fora
                        //se passar mouse fora
                        if (!Botao.HOMEquadrado.Contains(mousePosition))
                        {
                            Botao.HOMEb = false;
                            MediaPlayer.Resume();
                        }
                        //passagem (para o menu do jogo)
                        //passagem
                        if (Botao.HOMEb && !BOTAO)
                        {
                            
                            JANELA.J.JANELAPAUSE = true;
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
                        MediaPlayer.Pause();
                    }
                    //se passar fora do mouse
                    if (!Botao.COMERCIOquadrado.Contains(mousePosition))
                    {
                        Botao.COMERCIOb = false;
                        MediaPlayer.Resume();
                    }
                    //passagem (abrir janela)
                    if (Botao.COMERCIOb && !BOTAO)//
                    {
                        MediaPlayer.Pause();
                        JANELA.J.JANELACOMERCIO = true; // trava a tela
                        //Botao.COMERCIOb = false;
                    }


                    //BOTAO COMBOS
                    //BOTAO COMBOS
                    //BOTAO COMBOS
                    //BOTAO COMBOS
                    if (Botao.COMBOSquadrado.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        BOTAO = true;
                        Botao.COMBOSb = true;
                        MediaPlayer.Pause();
                    }
                    //se passar fora do mouse
                    if (!Botao.COMBOSquadrado.Contains(mousePosition))
                    {
                        Botao.COMBOSb = false;
                        MediaPlayer.Resume();
                    }
                    //passagem (abrir janela)
                    if (Botao.COMBOSb && !BOTAO)//
                    {
                        MediaPlayer.Pause();
                        JANELA.J.JANELACOMBO = true; // trava a tela
                        //Botao.COMBOSb = false;
                    }


                    //FIM DO UNIVERSAL ITENS:
                    //FIM DO UNIVERSAL ITENS:
                    //FIM DO UNIVERSAL ITENS:
                    //FIM DO UNIVERSAL ITENS:

                }// botoes so funcionam no menu ou jogo




                //                                                           menu



                //============================================================ MENU ===================================================
                //============================================================ MENU ===================================================
                if (MENU && !M1.COMBATE)
                {
                    if (menu00)
                    {
                        IsMouseVisible = true;



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


                                graphics.ApplyChanges();
                                menu00 = false;//sai pro proximo menu
                                menu01 = true;

                                // atualização



                                //dimensão dos BOTÕES
                                M1.HistoryBotao = new Rectangle(0, Window.ClientBounds.Height / 3, Window.ClientBounds.Width / 3, Window.ClientBounds.Height / 8);
                                M1.CombateBotao = new Rectangle(Window.ClientBounds.Width - Window.ClientBounds.Width / 3, Window.ClientBounds.Height / 3, Window.ClientBounds.Width / 3, Window.ClientBounds.Height / 8);

                                P1.individuo = new Rectangle(0, Window.ClientBounds.Height - Window.ClientBounds.Height / 3, Window.ClientBounds.Width / 16, Window.ClientBounds.Height / 4);

                                Contexto.Fundo.fase = new Rectangle(0, -Window.ClientBounds.Height / 10, Window.ClientBounds.Width * 3, Window.ClientBounds.Height + Window.ClientBounds.Height / 10);
                                Contexto.Fundo.chao = new Rectangle(Contexto.Fundo.fase.X, Contexto.Fundo.fase.Y + Window.ClientBounds.Height / 4 + Contexto.Fundo.fase.Height - Window.ClientBounds.Height / 3 - 1, Contexto.Fundo.fase.Width, Window.ClientBounds.Height / 3 - Window.ClientBounds.Height / 4);

                                //MediaPlayer.Play(AUDIO.menusong);

                                //botao
                                Botao.HOME = true;
                                Botao.HOMEquadrado = new Rectangle(Window.ClientBounds.Height / 100, Window.ClientBounds.Height / 100, Window.ClientBounds.Height / 10, Window.ClientBounds.Height / 10);
                                
                                Botao.COMERCIOquadrado = new Rectangle(Window.ClientBounds.Height / 100, Window.ClientBounds.Height / 100 + Window.ClientBounds.Height / 10 + Window.ClientBounds.Height / 100, Window.ClientBounds.Height / 10, Window.ClientBounds.Height / 10);
                                
                                Botao.COMBOSquadrado = new Rectangle(Window.ClientBounds.Height / 100,  Window.ClientBounds.Height / 100 + Window.ClientBounds.Height / 10 + Window.ClientBounds.Height / 100 + Window.ClientBounds.Height / 10 + Window.ClientBounds.Height / 100, Window.ClientBounds.Height / 10, Window.ClientBounds.Height / 10);

                                //HUD
                                //barra
                                P1.XPrec = new Rectangle(Botao.HOMEquadrado.X + Botao.HOMEquadrado.Width + Window.ClientBounds.Height / 100, Botao.HOMEquadrado.Y, 0, Window.ClientBounds.Height / 24);
                                P1.XPTrec = new Rectangle(Botao.HOMEquadrado.X + Botao.HOMEquadrado.Width + Window.ClientBounds.Height / 100, Botao.HOMEquadrado.Y, Window.ClientBounds.Width - Window.ClientBounds.Height / 10 - Window.ClientBounds.Height / 50, Window.ClientBounds.Height / 24);

                                P1.Barra = new Rectangle(Botao.HOMEquadrado.X + Botao.HOMEquadrado.Width + Window.ClientBounds.Height / 100, Botao.COMERCIOquadrado.Y, Window.ClientBounds.Width / 3, Window.ClientBounds.Height / 10);
                                P1.BarraEnergia = new Rectangle(Botao.HOMEquadrado.X + Botao.HOMEquadrado.Width + Window.ClientBounds.Height / 100, Botao.COMERCIOquadrado.Y, Window.ClientBounds.Width / 3, Window.ClientBounds.Height / 10);
                                P1.BarraVida = new Rectangle(Botao.HOMEquadrado.X + Botao.HOMEquadrado.Width + Window.ClientBounds.Height / 100, Botao.COMERCIOquadrado.Y, Window.ClientBounds.Width / 3, Window.ClientBounds.Height / 10);
                                P1.BarraMana = new Rectangle(Botao.HOMEquadrado.X + Botao.HOMEquadrado.Width + Window.ClientBounds.Height / 100, Botao.COMERCIOquadrado.Y, Window.ClientBounds.Width / 3, Window.ClientBounds.Height / 10);


                                //se não salvou o game (COMEÇO DO GAME)
                                P1.PersonagemGAMEZERADO(); // zera tudo

                                //tela
                                TELACHEIA = new Rectangle(0, 0, Window.ClientBounds.Width, Window.ClientBounds.Height);

                                //flecha D e E
                                FlechaD = new Rectangle(Window.ClientBounds.Width - Window.ClientBounds.Height / 10, Window.ClientBounds.Height - Window.ClientBounds.Height / 10, Window.ClientBounds.Height / 10, Window.ClientBounds.Height / 10);
                                FlechaE = new Rectangle(0, Window.ClientBounds.Height - Window.ClientBounds.Height / 10, Window.ClientBounds.Height / 10, Window.ClientBounds.Height / 10);

                            }//fim da transição

                        }

                        if (Mouse.GetState().LeftButton == ButtonState.Pressed && !APPLY.Contains(mousePosition))
                        {
                            Bapply = false;
                        }

                    }//fim do menu00

                    if (menu01)
                    {

                        var WidthTela = Window.ClientBounds.Width;
                        var HeightTela = Window.ClientBounds.Height;

                        if (Keyboard.GetState().IsKeyDown(Keys.Escape))//saida
                            Exit();
                        else
                        {

                            M1.menu01GAME(WidthTela, HeightTela); //RESUMAO 

                        }
                    }
                }// FIM DO INICIO

                // #--------------------------------------------------------------------------------- jogo ------------------------------------------------------#





                // #--------------------------------------------------------------------------------- jogo ------------------------------------------------------#





                // #--------------------------------------------------------------------------------- jogo ------------------------------------------------------#
                if (M1.COMBATE)
                {

                    var WidthTela = Window.ClientBounds.Width;
                    var HeightTela = Window.ClientBounds.Height;

                    Contexto.Fundo.atualizaçao(Contexto.Fundo, HeightTela);

                    if (Keyboard.GetState().IsKeyDown(Keys.Escape))//saida
                        Exit();
                    else
                    {
                        //TUDO do personagem
                        P1.MOV(WidthTela, HeightTela, aleatório); // tudo sobre movimentação (+metodos)
                        P1.RPGatualização(WidthTela, HeightTela); //atualiza os dados
                        P1.Luta(WidthTela, HeightTela, aleatório); // atualiza a posição, tamanho, frames

                        if (Contexto.Fase1)
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
                        if (P1.PODER)
                        {
                            //preço
                            if (P1.mana > 0)
                                P1.mana -= 1;
                            else if (P1.mana <= 0)
                            {
                                P1.PODER = false;
                                //MediaPlayer.Play(AUDIO.combatesong);
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
                                if (TempoParaInimigos == 320)
                                {
                                    i1.GERARi1(listai1, WidthTela, HeightTela, aleatório);
                                    TempoParaInimigos = 0;
                                }
                                else
                                {
                                    TempoParaInimigos++;
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


                            //POSIÇÃO DO EFEITO VISUAL
                            //POSIÇÃO DO EFEITO VISUAL
                            //POSIÇÃO DO EFEITO VISUAL


                        }
                        else if (!P1.PODER)
                        {
                            //mov do bot
                            for (int i = 0; i < listai1.Count; i++) // atualização de todos os inimigos
                            {
                                listai1[i].MOV(WidthTela, HeightTela, aleatório, P1);
                                listai1[i].INTELIGENCIA(WidthTela, HeightTela, P1, listai1, aleatório);
                            }
                            //gerador de inimigos
                            if (TempoParaInimigos == 320)
                            {
                                i1.GERARi1(listai1, WidthTela, HeightTela, aleatório);
                                TempoParaInimigos = 0;
                            }
                            else
                            {
                                TempoParaInimigos++;
                            }

                            P1.clonelistaPoder.Clear();
                        }


                        //definir o combate
                        for (int i = 0; i < listai1.Count; i++) // atualização de todos os inimigos
                        {
                            if (listai1[i].individuo.Intersects(TELACHEIA)) // se ele estiver NA TELA
                            {
                                P1.COMBATE = true;
                            }
                            else if (listai1.Count == 0) // se ele nao estiver NA TELA
                            {
                                P1.COMBATE = false;
                            }
                        }

                        //HUD
                        P1.BarraVida.Width = (int)((float)(P1.vida) / P1.vidaTOTAL * WidthTela / 3);
                        P1.BarraEnergia.Width = (int)((float)(P1.energia) / P1.energiaTOTAL * WidthTela / 3);
                        P1.BarraMana.Width = (int)((float)(P1.mana) / P1.manaTOTAL * WidthTela / 3);

                        //constantes (AUMENTA ENERGIA OU MANA COM O TEMPO)
                        if (P1.energia <= P1.energiaTOTAL && !P1.CORRENDO && !P1.PULANDOcorrendo && !P1.ATACANDO)
                        {
                            P1.energia += 2;
                        }
                        if (P1.mana <= P1.manaTOTAL && !P1.PODER)
                        {
                            if (contagemREGEN == 2)
                            {
                                P1.mana += 1;
                                contagemREGEN = 0;
                            }
                            else
                            {
                                contagemREGEN++;
                            }
                        }

                        //ATIVAR PODER QUE ESTIVER DESTRAVADO
                        if (Keyboard.GetState().IsKeyDown(Keys.NumPad5) && !P1.PODER && P1.mana >= 75)
                        {
                            P1.PODER = true;
                            //MediaPlayer.Play(AUDIO.PODERsong);
                            P1.VISUPODER(); // criar efeito especial
                            P1.COLIDINDOdireita = false; // não ter colisao
                            P1.COLIDINDOesquerda = false;
                        }

                    }//fim do jogo
                }//fim do combate

                //PAUSE
                //PAUSE
                //PAUSE
                //PAUSE
                //PAUSE
            }//FIM DO QUE PAUSA A TELA (botões: COMBATE E COMERCIO)
            if (JANELA.J.JANELACOMBO || JANELA.J.JANELACOMERCIO)
            {
                JANELA.J.FUNÇÕES(BOTAO);
            }
            

            base.Update(gameTime);
        }

       
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            var WidthTela = Window.ClientBounds.Width;
            var HeightTela = Window.ClientBounds.Height;

            spriteBatch.Begin();

            


            if (MENU)
            {

                if (menu00)
                {

                    DRAW.Drawmenu00(WidthTela, HeightTela, spriteBatch, imgAPPLY2, imgAPPLY3, imgAPPLY, APPLY, Bapply, B1, imgB1, imgB2, b1, BFULL, menu, Bfull, M1); // resumao


                }

                if (menu01)
                {
                    DRAW.Drawmenu01(spriteBatch, M1, WidthTela, HeightTela, menu); // resumao
                }
            }//FIM DO MENU



            if (M1.COMBATE)
            {
                DRAW.DrawCombate(spriteBatch, P1, listai1, TELACHEIA, FlechaD, FlechaE, imgFlechaD, imgFlechaE, menu, HUDfont, WidthTela, HeightTela, imgSangue, i1, DefineAgua, BARfont); //RESUMAO
                DRAW.DrawCLONES(spriteBatch, P1); // PODER

                spriteBatch.DrawString(menu, "LISTA: " + listai1.Count , new Vector2(0, Window.ClientBounds.Height - 15), Color.Black); //teste
                
            }//FIM DO COMBATE

            //botao menu e comercio
            DRAW.DrawBotaoEstatico(Botao, spriteBatch, MENU, M1); //resumo dos botoes
            if (JANELA.J.JANELACOMBO || JANELA.J.JANELACOMERCIO)
            {
                DRAW.DrawJANELA(Botao, spriteBatch);
            }


            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
