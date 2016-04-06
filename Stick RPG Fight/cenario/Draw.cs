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
    class Draw
    {
        public void DrawCombate(SpriteBatch spriteBatch, Personagem P1, List<Inimigo> listai1, Rectangle TELACHEIA, Rectangle FlechaD, Rectangle FlechaE, Texture2D imgFlechaD, Texture2D imgFlechaE)
        {
            spriteBatch.Draw(Contexto.Fundo.imgfase1, Contexto.Fundo.fase, Color.White); // fundo

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
                else if (P1.COMBATE)
                {
                    if (P1.PARADO)
                    {
                        spriteBatch.Draw(P1.imgSpriteSheetparado2, P1.individuo,
                                      new Rectangle(P1.frameparado2.X * P1.tamanhoSpriteSheetparado2.X, P1.frameparado2.Y * P1.tamanhoSpriteSheetparado2.Y,
                                                    P1.tamanhoSpriteSheetparado2.X, P1.tamanhoSpriteSheetparado2.Y),
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
                else if (P1.COMBATE)
                {
                    if (P1.PARADO)
                    {
                        spriteBatch.Draw(P1.imgSpriteSheetparado2E, P1.individuo,
                                      new Rectangle(P1.frameparado2.X * P1.tamanhoSpriteSheetparado2.X, P1.frameparado2.Y * P1.tamanhoSpriteSheetparado2.Y,
                                                    P1.tamanhoSpriteSheetparado2.X, P1.tamanhoSpriteSheetparado2.Y),
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

            //INIMIGO 1
            for (int i = 0; i < listai1.Count; i++)
            {
                if (listai1[i].PARADO)
                {
                    spriteBatch.Draw(listai1[0].imgParadoi1, listai1[i].individuo,
                        new Rectangle(listai1[i].frameparadoi1.X * listai1[i].tamanhoparadoi1.X, listai1[i].frameparadoi1.Y * listai1[i].tamanhoparadoi1.Y,
                                                   listai1[i].tamanhoparadoi1.X, listai1[i].tamanhoparadoi1.Y), Color.White);
                }
                if (listai1[i].DIREITA)
                {
                    spriteBatch.Draw(listai1[0].imgAndarDi1, listai1[i].individuo,
                        new Rectangle(listai1[i].frameAndari1.X * listai1[i].tamanhoAndari1.X, listai1[i].frameAndari1.Y * listai1[i].tamanhoAndari1.Y,
                                                   listai1[i].tamanhoAndari1.X, listai1[i].tamanhoAndari1.Y), Color.White);
                }
                if (listai1[i].ESQUERDA)
                {
                    spriteBatch.Draw(listai1[0].imgAndarEi1, listai1[i].individuo,
                        new Rectangle(listai1[i].frameAndari1.X * listai1[i].tamanhoAndari1.X, listai1[i].frameAndari1.Y * listai1[i].tamanhoAndari1.Y,
                                                   listai1[i].tamanhoAndari1.X, listai1[i].tamanhoAndari1.Y), Color.White);
                }

                if (listai1[i].individuo.X > TELACHEIA.X + TELACHEIA.Width)
                {
                    spriteBatch.Draw(imgFlechaD, FlechaD, Color.White);
                }
                if (listai1[i].individuo.X < TELACHEIA.X)
                {
                    spriteBatch.Draw(imgFlechaE, FlechaE, Color.White);
                }
            }

            if (P1.PODER)
            {
                spriteBatch.Draw(Contexto.Fundo.imgfundopoder, TELACHEIA, Color.White);
            }

            //HUD
            spriteBatch.Draw(P1.imgBARRA, P1.Barra, Color.White);
            spriteBatch.Draw(P1.imgVIDA, P1.BarraVida, Color.White);
            spriteBatch.Draw(P1.imgENERGIA, P1.BarraEnergia, Color.White);
            spriteBatch.Draw(P1.imgMANA, P1.BarraMana, Color.White);
            spriteBatch.Draw(P1.imgSOBRE, P1.Barra, Color.White);

            

        }//fim draw combate
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------














        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        public void Drawmenu00(int WidthTela, int HeightTela, SpriteBatch spriteBatch, Texture2D imgAPPLY2, Texture2D imgAPPLY3, Texture2D imgAPPLY, Rectangle APPLY, bool Bapply, Rectangle[] B1, Texture2D imgB1, Texture2D imgB2, bool[] b1, bool BFULL, SpriteFont menu, Rectangle Bfull)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);

            spriteBatch.Draw(Contexto.Fundo.menu00fundo, new Rectangle(0, 0, WidthTela, HeightTela), Color.White);

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
        }//fim draw menu 00
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------













        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        public void Drawmenu01(SpriteBatch spriteBatch, Menu M1, int WidthTela, int HeightTela, SpriteFont menu)
        {
            spriteBatch.Draw(M1.imghistory, M1.HistoryBotao,
                                   new Rectangle(M1.framehistoryB.X * M1.TamanhoSpritesheethistoryB.X, M1.framehistoryB.Y * M1.TamanhoSpritesheethistoryB.Y,
                                                 M1.TamanhoSpritesheethistoryB.X, M1.TamanhoSpritesheethistoryB.Y),
                                                 Color.White);

            spriteBatch.Draw(M1.imgcombate, M1.CombateBotao,
                           new Rectangle(M1.framecombateB.X * M1.TamanhoSpritesheetcombateB.X, M1.framecombateB.Y * M1.TamanhoSpritesheetcombateB.Y,
                                         M1.TamanhoSpritesheetcombateB.X, M1.TamanhoSpritesheetcombateB.Y),
                                         Color.White);

            spriteBatch.DrawString(menu, "Versão 1.0", new Vector2(WidthTela - 100, HeightTela - 15), Color.Cyan);
        } //fim draw menu 01
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------













        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        public void DrawBotaoEstatico(Botoes Botao, SpriteBatch spriteBatch, bool MENU, Menu M1)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);


            if (Botao.HOME)
            {

                if (Botao.HOMEquadrado.Contains(mousePosition))
                {
                    spriteBatch.Draw(Botao.imghomeON, Botao.HOMEquadrado, Color.Green);
                }
                else
                {
                    spriteBatch.Draw(Botao.imghomeON, Botao.HOMEquadrado, Color.White);
                }
            }
            else if (!Botao.HOME)
            {
                if (Botao.HOMEquadrado.Contains(mousePosition))
                {
                    spriteBatch.Draw(Botao.imghomeOFF, Botao.HOMEquadrado, Color.Gold);
                    if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        spriteBatch.Draw(Botao.imghomeON, Botao.HOMEquadrado, Color.Gold);
                    }
                }
                else
                {
                    if (MENU)
                        spriteBatch.Draw(Botao.imghomeOFF, Botao.HOMEquadrado, Color.White);
                    else if (M1.COMBATE || M1.HISTORY)
                    {
                        spriteBatch.Draw(Botao.imghomeOFFTP, Botao.HOMEquadrado, Color.White);
                    }
                }

            }

            if (Botao.COMERCIO)
            {
                if (Botao.COMERCIOquadrado.Contains(mousePosition))
                {
                    spriteBatch.Draw(Botao.imgcomercioON, Botao.COMERCIOquadrado, Color.Green);
                }
                else
                {
                    spriteBatch.Draw(Botao.imgcomercioON, Botao.COMERCIOquadrado, Color.White);
                }

            }
            else if (!Botao.COMERCIO)
            {
                if (Botao.COMERCIOquadrado.Contains(mousePosition))
                {
                    spriteBatch.Draw(Botao.imgcomercioOFF, Botao.COMERCIOquadrado, Color.LightGoldenrodYellow);
                    if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        spriteBatch.Draw(Botao.imgcomercioON, Botao.COMERCIOquadrado, Color.LightGoldenrodYellow);
                    }
                }
                else
                {
                    if (MENU)
                        spriteBatch.Draw(Botao.imgcomercioOFF, Botao.COMERCIOquadrado, Color.White);
                    else if (M1.COMBATE || M1.HISTORY)
                    {
                        spriteBatch.Draw(Botao.imgcomercioOFFTP, Botao.COMERCIOquadrado, Color.White);
                    }
                }

            }
        }//fim do draw BOTOES ESTATICOS
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------

        public void DrawCLONES(SpriteBatch spriteBatch, Personagem P1)
        {
            for (int i = 0; i < P1.clonelistaPoder.Count; i++)
            {
                if (P1.clonelistaPoder[i].DIREITA)
                {
                    if (!P1.clonelistaPoder[i].COMBATE) // fora de combate
                    {
                        if (P1.clonelistaPoder[i].PARADO) // parado fora de luta
                        {
                            spriteBatch.Draw(P1.imgSpriteSheetparado1, P1.clonelistaPoder[i].individuo,
                                          new Rectangle(P1.clonelistaPoder[i].frameparado1.X * P1.clonelistaPoder[i].tamanhoSpriteSheetparado1.X, P1.clonelistaPoder[i].frameparado1.Y * P1.clonelistaPoder[i].tamanhoSpriteSheetparado1.Y,
                                                        P1.clonelistaPoder[i].tamanhoSpriteSheetparado1.X, P1.clonelistaPoder[i].tamanhoSpriteSheetparado1.Y),
                                                        Color.White);
                        }
                    }
                    else if (P1.clonelistaPoder[i].COMBATE)
                    {
                        if (P1.clonelistaPoder[i].PARADO)
                        {
                            spriteBatch.Draw(P1.imgSpriteSheetparado2, P1.clonelistaPoder[i].individuo,
                                          new Rectangle(P1.clonelistaPoder[i].frameparado2.X * P1.clonelistaPoder[i].tamanhoSpriteSheetparado2.X, P1.clonelistaPoder[i].frameparado2.Y * P1.clonelistaPoder[i].tamanhoSpriteSheetparado2.Y,
                                                        P1.clonelistaPoder[i].tamanhoSpriteSheetparado2.X, P1.clonelistaPoder[i].tamanhoSpriteSheetparado2.Y),
                                                        Color.White);
                        }
                    }

                    if (P1.clonelistaPoder[i].COMBATE) // em combate
                    {
                        if (P1.clonelistaPoder[i].PARADO) // parado na luta
                        {
                            spriteBatch.Draw(P1.imgSpriteSheetparado2, P1.clonelistaPoder[i].individuo,
                                          new Rectangle(P1.clonelistaPoder[i].frameparado2.X * P1.clonelistaPoder[i].tamanhoSpriteSheetparado2.X, P1.clonelistaPoder[i].frameparado2.Y * P1.clonelistaPoder[i].tamanhoSpriteSheetparado2.Y,
                                                        P1.clonelistaPoder[i].tamanhoSpriteSheetparado2.X, P1.clonelistaPoder[i].tamanhoSpriteSheetparado2.Y),
                                                        Color.White);
                        }
                    }

                    if (P1.clonelistaPoder[i].ANDANDO) // se movimentando pra direita
                    {
                        spriteBatch.Draw(P1.imgSpriteSheetandando, P1.clonelistaPoder[i].individuo,
                                          new Rectangle(P1.clonelistaPoder[i].framemovendo.X * P1.clonelistaPoder[i].tamanhoSpriteSheetandando.X, P1.clonelistaPoder[i].framemovendo.Y * P1.clonelistaPoder[i].tamanhoSpriteSheetandando.Y,
                                                        P1.clonelistaPoder[i].tamanhoSpriteSheetandando.X, P1.clonelistaPoder[i].tamanhoSpriteSheetandando.Y),
                                                        Color.White);
                    }

                    if (P1.clonelistaPoder[i].CORRENDO)
                    {
                        spriteBatch.Draw(P1.imgSpriteSheetcorrendo, P1.clonelistaPoder[i].individuo,
                                          new Rectangle(P1.clonelistaPoder[i].framemovendo.X * P1.clonelistaPoder[i].tamanhoSpriteSheetcorrendo.X, P1.clonelistaPoder[i].framemovendo.Y * P1.clonelistaPoder[i].tamanhoSpriteSheetcorrendo.Y,
                                                        P1.clonelistaPoder[i].tamanhoSpriteSheetcorrendo.X, P1.clonelistaPoder[i].tamanhoSpriteSheetcorrendo.Y),
                                                        Color.White);
                    }

                    if (P1.clonelistaPoder[i].PULANDOandando || P1.clonelistaPoder[i].PULANDOcorrendo || P1.clonelistaPoder[i].PULANDOparado)
                    {
                        spriteBatch.Draw(P1.imgSpriteSheetpular, P1.clonelistaPoder[i].individuo,
                                         new Rectangle(P1.clonelistaPoder[i].framepular.X * P1.clonelistaPoder[i].tamanhoSpriteSheetpular.X, P1.clonelistaPoder[i].framepular.Y * P1.clonelistaPoder[i].tamanhoSpriteSheetpular.Y,
                                                       P1.clonelistaPoder[i].tamanhoSpriteSheetpular.X, P1.clonelistaPoder[i].tamanhoSpriteSheetpular.Y),
                                                       Color.White);
                    }
                }


                //--------------------------------------------------------------------------------------------------
                //--------------------------------------------------------------------------------------------------
                //--------------------------------------------------------------------------------------------------
                if (P1.clonelistaPoder[i].ESQUERDA)
                {
                    if (!P1.clonelistaPoder[i].COMBATE) // fora de combate
                    {
                        if (P1.clonelistaPoder[i].PARADO) // parado fora de luta
                        {
                            spriteBatch.Draw(P1.imgSpriteSheetparado1E, P1.clonelistaPoder[i].individuo,
                                          new Rectangle(P1.clonelistaPoder[i].frameparado1.X * P1.clonelistaPoder[i].tamanhoSpriteSheetparado1.X, P1.clonelistaPoder[i].frameparado1.Y * P1.clonelistaPoder[i].tamanhoSpriteSheetparado1.Y,
                                                        P1.clonelistaPoder[i].tamanhoSpriteSheetparado1.X, P1.clonelistaPoder[i].tamanhoSpriteSheetparado1.Y),
                                                        Color.White);
                        }
                    }
                    else if (P1.clonelistaPoder[i].COMBATE)
                    {
                        if (P1.clonelistaPoder[i].PARADO)
                        {
                            spriteBatch.Draw(P1.imgSpriteSheetparado2E, P1.clonelistaPoder[i].individuo,
                                          new Rectangle(P1.clonelistaPoder[i].frameparado2.X * P1.clonelistaPoder[i].tamanhoSpriteSheetparado2.X, P1.clonelistaPoder[i].frameparado2.Y * P1.clonelistaPoder[i].tamanhoSpriteSheetparado2.Y,
                                                        P1.clonelistaPoder[i].tamanhoSpriteSheetparado2.X, P1.clonelistaPoder[i].tamanhoSpriteSheetparado2.Y),
                                                        Color.White);
                        }
                    }
                    if (P1.clonelistaPoder[i].ANDANDO) // se movimentando pra esquerda
                    {
                        spriteBatch.Draw(P1.imgSpriteSheetandandoE, P1.clonelistaPoder[i].individuo,
                                          new Rectangle(P1.clonelistaPoder[i].framemovendo.X * P1.clonelistaPoder[i].tamanhoSpriteSheetandando.X, P1.clonelistaPoder[i].framemovendo.Y * P1.clonelistaPoder[i].tamanhoSpriteSheetandando.Y,
                                                        P1.clonelistaPoder[i].tamanhoSpriteSheetandando.X, P1.clonelistaPoder[i].tamanhoSpriteSheetandando.Y),
                                                        Color.White);
                    }

                    if (P1.clonelistaPoder[i].CORRENDO)
                    {
                        spriteBatch.Draw(P1.imgSpriteSheetcorrendoE, P1.clonelistaPoder[i].individuo,
                                          new Rectangle(P1.clonelistaPoder[i].framemovendo.X * P1.clonelistaPoder[i].tamanhoSpriteSheetcorrendo.X, P1.clonelistaPoder[i].framemovendo.Y * P1.clonelistaPoder[i].tamanhoSpriteSheetcorrendo.Y,
                                                        P1.clonelistaPoder[i].tamanhoSpriteSheetcorrendo.X, P1.clonelistaPoder[i].tamanhoSpriteSheetcorrendo.Y),
                                                        Color.White);
                    }

                    if (P1.clonelistaPoder[i].PULANDOandando || P1.clonelistaPoder[i].PULANDOcorrendo || P1.clonelistaPoder[i].PULANDOparado)
                    {
                        spriteBatch.Draw(P1.imgSpriteSheetpularE, P1.clonelistaPoder[i].individuo,
                                         new Rectangle(P1.clonelistaPoder[i].framepular.X * P1.clonelistaPoder[i].tamanhoSpriteSheetpular.X, P1.clonelistaPoder[i].framepular.Y * P1.clonelistaPoder[i].tamanhoSpriteSheetpular.Y,
                                                       P1.clonelistaPoder[i].tamanhoSpriteSheetpular.X, P1.clonelistaPoder[i].tamanhoSpriteSheetpular.Y),
                                                       Color.White);
                    }
                }
            }
        }
    }
}
