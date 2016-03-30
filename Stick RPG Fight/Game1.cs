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

        Random aleatório;

        bool MENU = true, menu00 = true, menu01, Bapply, BFULL, BOTAO;

        bool[] b1 = new bool[5];//botoes do menu
        Rectangle[] B1 = new Rectangle[5]; //botao
        Rectangle Bfull, APPLY;

        SpriteFont menu;

        Texture2D imgB1, imgB2, imgAPPLY2, imgAPPLY, imgAPPLY3, imgteste;

        intromenu Entrada = new intromenu();

        Menu M1 = new Menu();
        Audio AUDIO = new Audio();

        Personagem P1 = new Personagem();

        public void Criarinimmigos()
        {

        }

        List<Personagem> inimigo1 = new List<Personagem>();

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


            //exemplo


            for (int i = 0; i < 3; i++)
            {
                Personagem inimigo = new Personagem();


                inimigo1.Add(inimigo);
            }

            base.Initialize();
        }

        
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Contexto.inicializar(Content, M1, AUDIO, P1); // classe contexto

            menu = Content.Load<SpriteFont>("menu");

            imgB1 = Content.Load<Texture2D>("B1");
            imgB2 = Content.Load<Texture2D>("B2");

            imgAPPLY = Content.Load<Texture2D>("B APPLY");
            imgAPPLY2 = Content.Load<Texture2D>("B APPLY2");
            imgAPPLY3 = Content.Load<Texture2D>("B APPLY3");

            imgteste = Content.Load<Texture2D>("teste");
           //--
        }

       
        protected override void UnloadContent()
        {
           
        }

        protected override void Update(GameTime gameTime)
        {
            //universal
            if (Mouse.GetState().LeftButton != ButtonState.Pressed) // BOTAO não pressionado
            {
                BOTAO = false;
            }
            
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);

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

                            //personagem
                            P1.DIREITA = true;
                            P1.PARADO = true;
                            P1.COMBATE = false;
                            
                            //dimensão dos BOTÕES
                            M1.HistoryBotao = new Rectangle(0, Window.ClientBounds.Height / 3, Window.ClientBounds.Width / 3, Window.ClientBounds.Height / 8);
                            M1.CombateBotao = new Rectangle(Window.ClientBounds.Width - Window.ClientBounds.Width / 3, Window.ClientBounds.Height / 3, Window.ClientBounds.Width / 3, Window.ClientBounds.Height / 8);

                            P1.individuo = new Rectangle(0, Window.ClientBounds.Height - Window.ClientBounds.Height / 3, Window.ClientBounds.Width / 16, Window.ClientBounds.Height / 4);

                            Contexto.Fundo.fase = new Rectangle(0, -Window.ClientBounds.Height / 10, Window.ClientBounds.Width * 3, Window.ClientBounds.Height + Window.ClientBounds.Height / 10);
                            Contexto.Fundo.chao = new Rectangle(Contexto.Fundo.fase.X, Contexto.Fundo.fase.Y + Window.ClientBounds.Height / 4 + Contexto.Fundo.fase.Height - Window.ClientBounds.Height / 3 - 1, Contexto.Fundo.fase.Width, Window.ClientBounds.Height / 3 - Window.ClientBounds.Height / 4);

                            //MediaPlayer.Play(AUDIO.menusong);
                            
                        }//fim da transição

                    }

                    if (Mouse.GetState().LeftButton == ButtonState.Pressed && !APPLY.Contains(mousePosition))
                    {
                        Bapply = false;
                    }

                }//fim do menu00

                if (menu01)
                {
                    


                    if (Keyboard.GetState().IsKeyDown(Keys.Escape))//saida
                        Exit();
                    else
                    {
                        if (M1.HistoryBotao.Contains(mousePosition))
                        {
                            M1.FRAMEhistory(M1);

                            M1.HistoryBotao.X = 0;
                            M1.HistoryBotao.Y = Window.ClientBounds.Height / 3 - Window.ClientBounds.Height / 30;
                            M1.HistoryBotao.Width = Window.ClientBounds.Width / 2;
                            M1.HistoryBotao.Height = Window.ClientBounds.Height / 6;

                        }
                        else
                        {
                            if (M1.HistoryBotao.Y != Window.ClientBounds.Height / 3)
                            {
                                M1.HistoryBotao.X = 0;
                                M1.HistoryBotao.Y = Window.ClientBounds.Height / 3;
                                M1.HistoryBotao.Width = Window.ClientBounds.Width / 3;
                                M1.HistoryBotao.Height = Window.ClientBounds.Height / 8;
                                M1.framehistoryB.X = 0;
                                M1.framehistoryB.Y = 0;
                            }
                        }

                        //combate
                        if (M1.CombateBotao.Contains(mousePosition))
                        {
                            M1.FRAMEcombate(M1);

                            M1.CombateBotao.X = Window.ClientBounds.Width - Window.ClientBounds.Width / 2;
                            M1.CombateBotao.Y = Window.ClientBounds.Height / 3 - Window.ClientBounds.Height / 30;
                            M1.CombateBotao.Width = Window.ClientBounds.Width / 2;
                            M1.CombateBotao.Height = Window.ClientBounds.Height / 6;

                           
                        }
                        else
                        {
                            M1.CombateBotao.X = Window.ClientBounds.Width - Window.ClientBounds.Width / 3;
                            M1.CombateBotao.Y = Window.ClientBounds.Height / 3;
                            M1.CombateBotao.Width = Window.ClientBounds.Width / 3;
                            M1.CombateBotao.Height = Window.ClientBounds.Height / 8;
                            M1.framecombateB.X = 0;
                            M1.framecombateB.Y = 0;
                        }


                        //clicando
                        if (Mouse.GetState().LeftButton == ButtonState.Pressed && M1.CombateBotao.Contains(mousePosition))
                        {
                            BOTAO = true;
                            M1.COMBATEativado = true;
                        }

                        if (!M1.CombateBotao.Contains(mousePosition))
                        {
                            M1.COMBATEativado = false;
                        }

                        if (!BOTAO && M1.COMBATEativado)
                        {
                            MENU = false;
                            M1.COMBATE = true;
                        }
                    }
                }
            }// FIM DO INICIO

            // #--------------------------------------------------------------------------------- jogo ------------------------------------------------------#








            if (M1.COMBATE)
            {

                var WidthTela = Window.ClientBounds.Width;
                var HeightTela = Window.ClientBounds.Height;

                Contexto.Fundo.atualizachao(Contexto.Fundo, HeightTela);

                if (Keyboard.GetState().IsKeyDown(Keys.Escape))//saida
                    Exit();
                else
                {
                    P1.MOV(WidthTela,HeightTela, aleatório);

                    

                    if (P1.DIREITA) // olhando pra direita
                    {
                        if (!P1.COMBATE) // fora de combate
                        {
                            if (P1.PARADO)
                            {
                                //frame
                                P1.FRAMESparado1();
                                //tamanho do personagem
                                P1.individuo.Width = Window.ClientBounds.Width / 16;
                            }
                        }
                        if (P1.ANDANDO)
                        {
                            //frame
                            P1.FRAMESmovendo();
                            //tamanho do personagem
                            P1.individuo.Width = Window.ClientBounds.Width / 10;

                        }

                        if (P1.CORRENDO)
                        {
                            //frame
                            P1.FRAMESmovendo();
                            //tamanho do personagem
                            P1.individuo.Width = Window.ClientBounds.Width / 7;
                        }

                        if (P1.PULANDOparado)
                        {
                            //frame
                            if (!P1.ATACANDO)
                            {
                                P1.FRAMESpular(WidthTela, HeightTela);
                            }

                            //tamanho do personagem
                            P1.individuo.Width = Window.ClientBounds.Width / 8;
                        }

                        if (P1.PULANDOandando)
                        {
                            
                            //frame
                            if (!P1.ATACANDO)
                            {
                                P1.FRAMESpular(WidthTela, HeightTela);
                            }


                            
                            //tamanho do personagem
                            P1.individuo.Width = Window.ClientBounds.Width / 14;
                        }

                        if (P1.PULANDOcorrendo)
                        {

                            //frame
                            if (!P1.ATACANDO)
                            {
                                P1.FRAMESpular(WidthTela, HeightTela);
                            }


                            
                            //tamanho do personagem
                            P1.individuo.Width = Window.ClientBounds.Width / 8;
                        }
                        
                    }//fim da direita

                    if (P1.ESQUERDA) // olhando pra esquerda
                    {
                        if (!P1.COMBATE) // fora de combate
                        {
                            if (P1.PARADO)
                            {
                                //frame
                                P1.FRAMESparado1E();
                                //tamanho do personagem
                                P1.individuo.Width = Window.ClientBounds.Width / 16;
                            }
                        }
                        if (P1.ANDANDO)
                        {
                            //frame
                            P1.FRAMESmovendoE();
                            //tamanho do personagem
                            P1.individuo.Width = Window.ClientBounds.Width / 10;

                        }

                        if (P1.CORRENDO)
                        {
                            //frame
                            P1.FRAMESmovendoE();
                            //tamanho do personagem
                            P1.individuo.Width = Window.ClientBounds.Width / 7;
                        }

                        if (P1.PULANDOparado)
                        {
                            //frame
                            if (!P1.ATACANDO)
                            {
                                P1.FRAMESpularE( WidthTela, HeightTela);
                            }

                            //tamanho do personagem
                            P1.individuo.Width = Window.ClientBounds.Width / 8;
                        }

                        if (P1.PULANDOandando)
                        {

                            //frame
                            if (!P1.ATACANDO)
                            {
                                P1.FRAMESpularE( WidthTela, HeightTela);
                            }


                            
                            //tamanho do personagem
                            P1.individuo.Width = Window.ClientBounds.Width / 14;
                        }

                        if (P1.PULANDOcorrendo)
                        {

                            //frame
                            if (!P1.ATACANDO)
                            {
                                P1.FRAMESpularE( WidthTela, HeightTela);
                            }


                            
                            //tamanho do personagem
                            P1.individuo.Width = Window.ClientBounds.Width / 8;
                        }

                    }//fim da direita
                }

                
            }


            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);

            spriteBatch.Begin();

            


            if (MENU)
            {

                spriteBatch.Draw(Contexto.Fundo.menu00fundo, new Rectangle(0, 0, Window.ClientBounds.Width, Window.ClientBounds.Height), Color.White);

                spriteBatch.DrawString(menu, "TESTE: " + inimigo1.Count, new Vector2(0, Window.ClientBounds.Height - 15), Color.White); //teste

                if (menu00)
                {
                    spriteBatch.Draw(Contexto.Fundo.menu00fundo, new Rectangle(0, 0, Window.ClientBounds.Width, Window.ClientBounds.Height), Color.White);

                    if (!APPLY.Contains(mousePosition))
                    {
                        spriteBatch.Draw(imgAPPLY2, APPLY, Color.White);//menu00
                    }
                    if (APPLY.Contains(mousePosition))
                    {
                        spriteBatch.Draw(imgAPPLY, APPLY, Color.White);//menu00
                    }
                    if (APPLY.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed && Bapply)
                    {
                        spriteBatch.Draw(imgAPPLY3, APPLY, Color.White);//menu00
                    }


                    for (int i = 0; i < B1.Length; i++)
                    {
                        if (!b1[i])
                        {
                            spriteBatch.Draw(imgB1, B1[i], Color.White);
                        }
                        else if (b1[i])
                        {
                            spriteBatch.Draw(imgB2, B1[i], Color.White);
                        }
                    }

                    spriteBatch.DrawString(menu, "1920x1080p", new Vector2(B1[0].X - 20, B1[0].Y - 15), Color.White);

                    spriteBatch.DrawString(menu, "1440x900p", new Vector2(B1[1].X, B1[1].Y - 15), Color.White);

                    spriteBatch.DrawString(menu, "1366x768p", new Vector2(B1[2].X, B1[2].Y - 15), Color.White);

                    spriteBatch.DrawString(menu, "1280x960p", new Vector2(B1[3].X, B1[3].Y - 15), Color.White);

                    spriteBatch.DrawString(menu, "800x600p", new Vector2(B1[4].X, B1[4].Y - 15), Color.White);

                    if (!BFULL)
                    {
                        spriteBatch.Draw(imgB1, Bfull, Color.White);
                    }
                    else if (BFULL)
                    {
                        spriteBatch.Draw(imgB2, Bfull, Color.White);
                    }

                    spriteBatch.DrawString(menu, "FULL SCREEN", new Vector2(Bfull.X, Bfull.Y - 15), Color.White);



                }

                if (menu01)
                {
                    spriteBatch.Draw(M1.imghistory, M1.HistoryBotao,
                                   new Rectangle(M1.framehistoryB.X * M1.TamanhoSpritesheethistoryB.X, M1.framehistoryB.Y * M1.TamanhoSpritesheethistoryB.Y,
                                                 M1.TamanhoSpritesheethistoryB.X, M1.TamanhoSpritesheethistoryB.Y),
                                                 Color.White);

                    spriteBatch.Draw(M1.imgcombate, M1.CombateBotao,
                                   new Rectangle(M1.framecombateB.X * M1.TamanhoSpritesheetcombateB.X, M1.framecombateB.Y * M1.TamanhoSpritesheetcombateB.Y,
                                                 M1.TamanhoSpritesheetcombateB.X, M1.TamanhoSpritesheetcombateB.Y),
                                                 Color.White);

                    spriteBatch.DrawString(menu, "Versão 1.0", new Vector2(Window.ClientBounds.Width - 100, Window.ClientBounds.Height - 15), Color.Cyan);
                }
            }//FIM DO MENU



            if (M1.COMBATE)
            {
                spriteBatch.Draw(Contexto.Fundo.imgfase1, Contexto.Fundo.fase, Color.White); // fundo
                spriteBatch.Draw(imgteste, Contexto.Fundo.chao, Color.White);
                //--------------------------------------------------------------------------------------------------
                //--------------------------------------------------------------------------------------------------
                //--------------------------------------------------------------------------------------------------

                if (P1.DIREITA)
                {
                    if (!P1.COMBATE) // fora de combate
                    {
                        if (P1.PARADO) // parado fora de luta
                        {
                            spriteBatch.Draw(P1.imgSpriteSheetparado1, P1.individuo,
                                          new Rectangle(P1.frameparado1.X * P1.tamanhoSpriteSheetparado1.X, P1.frameparado1.Y * P1.tamanhoSpriteSheetparado1.Y,
                                                        P1.tamanhoSpriteSheetparado1.X, P1.tamanhoSpriteSheetparado1.Y),
                                                        Color.White);
                        }
                    }

                    if (P1.COMBATE) // em combate
                    {
                        if (P1.PARADO) // parado na luta
                        {
                            spriteBatch.Draw(P1.imgSpriteSheetparado2, P1.individuo,
                                          new Rectangle(P1.frameparado2.X * P1.tamanhoSpriteSheetparado2.X, P1.frameparado2.Y * P1.tamanhoSpriteSheetparado2.Y,
                                                        P1.tamanhoSpriteSheetparado2.X, P1.tamanhoSpriteSheetparado2.Y),
                                                        Color.White);
                        }
                    }

                    if (P1.ANDANDO) // se movimentando pra direita
                    {
                        spriteBatch.Draw(P1.imgSpriteSheetandando, P1.individuo,
                                          new Rectangle(P1.framemovendo.X * P1.tamanhoSpriteSheetandando.X, P1.framemovendo.Y * P1.tamanhoSpriteSheetandando.Y,
                                                        P1.tamanhoSpriteSheetandando.X, P1.tamanhoSpriteSheetandando.Y),
                                                        Color.White);
                    }

                    if (P1.CORRENDO)
                    {
                        spriteBatch.Draw(P1.imgSpriteSheetcorrendo, P1.individuo,
                                          new Rectangle(P1.framemovendo.X * P1.tamanhoSpriteSheetcorrendo.X, P1.framemovendo.Y * P1.tamanhoSpriteSheetcorrendo.Y,
                                                        P1.tamanhoSpriteSheetcorrendo.X, P1.tamanhoSpriteSheetcorrendo.Y),
                                                        Color.White);
                    }

                    if (P1.PULANDOandando || P1.PULANDOcorrendo || P1.PULANDOparado)
                    {
                        spriteBatch.Draw(P1.imgSpriteSheetpular, P1.individuo,
                                         new Rectangle(P1.framepular.X * P1.tamanhoSpriteSheetpular.X, P1.framepular.Y * P1.tamanhoSpriteSheetpular.Y,
                                                       P1.tamanhoSpriteSheetpular.X, P1.tamanhoSpriteSheetpular.Y),
                                                       Color.White);
                    }
                }


                //--------------------------------------------------------------------------------------------------
                //--------------------------------------------------------------------------------------------------
                //--------------------------------------------------------------------------------------------------
                if (P1.ESQUERDA)
                {
                    if (!P1.COMBATE) // fora de combate
                    {
                        if (P1.PARADO) // parado fora de luta
                        {
                            spriteBatch.Draw(P1.imgSpriteSheetparado1E, P1.individuo,
                                          new Rectangle(P1.frameparado1.X * P1.tamanhoSpriteSheetparado1.X, P1.frameparado1.Y * P1.tamanhoSpriteSheetparado1.Y,
                                                        P1.tamanhoSpriteSheetparado1.X, P1.tamanhoSpriteSheetparado1.Y),
                                                        Color.White);
                        }
                    }
                    if (P1.ANDANDO) // se movimentando pra esquerda
                    {
                        spriteBatch.Draw(P1.imgSpriteSheetandandoE, P1.individuo,
                                          new Rectangle(P1.framemovendo.X * P1.tamanhoSpriteSheetandando.X, P1.framemovendo.Y * P1.tamanhoSpriteSheetandando.Y,
                                                        P1.tamanhoSpriteSheetandando.X, P1.tamanhoSpriteSheetandando.Y),
                                                        Color.White);
                    }

                    if (P1.CORRENDO)
                    {
                        spriteBatch.Draw(P1.imgSpriteSheetcorrendoE, P1.individuo,
                                          new Rectangle(P1.framemovendo.X * P1.tamanhoSpriteSheetcorrendo.X, P1.framemovendo.Y * P1.tamanhoSpriteSheetcorrendo.Y,
                                                        P1.tamanhoSpriteSheetcorrendo.X, P1.tamanhoSpriteSheetcorrendo.Y),
                                                        Color.White);
                    }

                    if (P1.PULANDOandando || P1.PULANDOcorrendo || P1.PULANDOparado)
                    {
                        spriteBatch.Draw(P1.imgSpriteSheetpularE, P1.individuo,
                                         new Rectangle(P1.framepular.X * P1.tamanhoSpriteSheetpular.X, P1.framepular.Y * P1.tamanhoSpriteSheetpular.Y,
                                                       P1.tamanhoSpriteSheetpular.X, P1.tamanhoSpriteSheetpular.Y),
                                                       Color.White);
                    }
                }

                spriteBatch.DrawString(menu, "TESTE X: " + P1.framepular.X + " TESTE Y: " + P1.framepular.Y, new Vector2(0, Window.ClientBounds.Height - 15), Color.Black); //teste
            }//FIM DO COMBATE

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
