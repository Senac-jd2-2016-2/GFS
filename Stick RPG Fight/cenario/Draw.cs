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
        public void DrawCombate(SpriteBatch spriteBatch, Personagem P1, List<Inimigo> listai1, Rectangle TELACHEIA, Rectangle FlechaD, Rectangle FlechaE, Texture2D imgFlechaD, Texture2D imgFlechaE, SpriteFont menu, SpriteFont HUDfont, int WidthTela, int HeightTela, Texture2D imgSangue, Inimigo i1, Agua DefineAgua, SpriteFont BARfont)
        {
            if (Contexto.Fase[0])
            {
                spriteBatch.Draw(Contexto.Fundo.imgfase1, Contexto.Fundo.fase, Color.White); // fundo
            }
            

            //--------------------------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------

            //                      INIMIGOS - - 

            //INIMIGO 1
            for (int i = 0; i < listai1.Count; i++)
            {
                //SANGUE E AGUA E OBJLANÇADO E EFEITOVISUAL
                //SANGUE E AGUA E OBJLANÇADO
                //SANGUE E AGUA E OBJLANÇADO
                //SANGUE E AGUA E OBJLANÇADO
                //SANGUE E AGUA E OBJLANÇADO
                //SANGUE E AGUA E OBJLANÇADO

                //visu efect
                for (int a = 0; a < listai1[i].listadevisualPOWER.Count; a++ )
                {
                    spriteBatch.Draw(Poder_Visual.p.imgcirculo, listai1[i].listadevisualPOWER[a].R, Color.Red);
                }
                    //sangue
                    for (int a = 0; a < listai1[i].listadesangue.Count; a++)// APARECER SANGUE
                    {
                        spriteBatch.Draw(imgSangue, listai1[i].listadesangue[a].sangueR, Color.White);

                    }

                if (Contexto.Fase[0]) //APENAS NA FASE 1
                {
                    for (int a = 0; a < listai1[i].listadeagua.Count; a++)
                    {
                        spriteBatch.Draw(DefineAgua.imgAgua, listai1[i].listadeagua[a].AguaR, Color.White);
                       
                    }
                    for (int a = 0; a < listai1[i].listadeondadeagua.Count; a++)
                    {
                        spriteBatch.Draw(DefineAgua.imgOndas, listai1[i].listadeondadeagua[a].R, new Rectangle(listai1[i].listadeondadeagua[a].frame.X * listai1[i].listadeondadeagua[a].tamanho.X, listai1[i].listadeondadeagua[a].frame.Y * listai1[i].listadeondadeagua[a].tamanho.Y,
                                                    listai1[i].listadeondadeagua[a].tamanho.X, listai1[i].listadeondadeagua[a].tamanho.Y), Color.White);
                    }
                }

                for (int a = 0; a < listai1[i].listadefacas.Count; a++)
                {
                    if (listai1[i].faca_voando && listai1[i].listadefacas.Count > 0)
                    {
                        if (listai1[i].listadefacas[a].esquerda)
                            spriteBatch.Draw(i1.imgFacaEi1, listai1[i].listadefacas[a].OBJ, new Rectangle(listai1[i].listadefacas[a].frameFACA.X * listai1[i].listadefacas[a].tamanhoFacai1.X, listai1[i].listadefacas[a].frameFACA.Y * listai1[i].listadefacas[a].tamanhoFacai1.Y,
                                                           listai1[i].listadefacas[a].tamanhoFacai1.X, listai1[i].listadefacas[a].tamanhoFacai1.Y), Color.White);
                        if (listai1[i].listadefacas[a].direita)
                            spriteBatch.Draw(i1.imgFacaDi1, listai1[i].listadefacas[a].OBJ, new Rectangle(listai1[i].listadefacas[a].frameFACA.X * listai1[i].listadefacas[a].tamanhoFacai1.X, listai1[i].listadefacas[a].frameFACA.Y * listai1[i].listadefacas[a].tamanhoFacai1.Y,
                                                           listai1[i].listadefacas[a].tamanhoFacai1.X, listai1[i].listadefacas[a].tamanhoFacai1.Y), Color.White);
                    }
                }

                //PARADO
                //PARADO
                //PARADO
                //PARADO
                //PARADO
                //PARADO
                //movimentos
                if (listai1[i].PARADO && !listai1[i].MORRENDO && !listai1[i].ATACANDO)
                {
                    spriteBatch.Draw(i1.imgParadoi1, listai1[i].individuo,
                        new Rectangle(listai1[i].frameparadoi1.X * listai1[i].tamanhoparadoi1.X, listai1[i].frameparadoi1.Y * listai1[i].tamanhoparadoi1.Y,
                                                   listai1[i].tamanhoparadoi1.X, listai1[i].tamanhoparadoi1.Y), Color.White);
                }

                //DIREITA
                //DIREITA
                //DIREITA
                //DIREITA
                //DIREITA
                //DIREITA
                if (listai1[i].DIREITA)
                {
                    if (listai1[i].ANDANDO)
                    {
                        spriteBatch.Draw(i1.imgAndarDi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameAndari1.X * listai1[i].tamanhoAndari1.X, listai1[i].frameAndari1.Y * listai1[i].tamanhoAndari1.Y,
                                                       listai1[i].tamanhoAndari1.X, listai1[i].tamanhoAndari1.Y), Color.White);
                    }
                    ///TOMANDO HIT
                    /////TOMANDO HIT
                    //TOMANDO HIT
                    //TOMANDO HIT
                    //TOMANDO HIT
                    if (listai1[i].TOMANDOHIT)
                    {
                        if (listai1[i].HIT1)
                        {
                            spriteBatch.Draw(i1.imgHit1Di1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoHit1i1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoHit1i1.Y,
                                                       listai1[i].tamanhoHit1i1.X, listai1[i].tamanhoHit1i1.Y), Color.White);
                        }
                        if (listai1[i].HIT2)
                        {
                            spriteBatch.Draw(i1.imgHit2Di1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoHit2i1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoHit2i1.Y,
                                                       listai1[i].tamanhoHit2i1.X, listai1[i].tamanhoHit2i1.Y), Color.White);

                        }
                        if (listai1[i].HIT3)
                        {
                            spriteBatch.Draw(i1.imgHit3Di1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoHit3i1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoHit3i1.Y,
                                                       listai1[i].tamanhoHit3i1.X, listai1[i].tamanhoHit3i1.Y), Color.White);
                        }
                    }
                    //DEFENDENDO E AGACHADO
                    //DEFENDENDO E AGACHADO
                    //DEFENDENDO E AGACHADO
                    if (listai1[i].DEFENDENDO && listai1[i].AGACHADO)
                    {
                        spriteBatch.Draw(i1.imgAgacharDEFDi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoAgacharDEFi1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoAgacharDEFi1.Y,
                                                       listai1[i].tamanhoAgacharDEFi1.X, listai1[i].tamanhoAgacharDEFi1.Y), Color.White);

                    }
                    //DEFENDENDO
                    //DEFENDENDO
                    //DEFENDENDO
                    //DEFENDENDO
                    //DEFENDENDO
                    if (listai1[i].DEFENDENDO && !listai1[i].AGACHADO)
                    {
                        spriteBatch.Draw(i1.imgDEFDi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoDEFi1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoDEFi1.Y,
                                                       listai1[i].tamanhoDEFi1.X, listai1[i].tamanhoDEFi1.Y), Color.White);

                    }
                    //AGACHADO
                    //AGACHADO
                    //AGACHADO
                    //AGACHADO
                    //AGACHADO
                    if (!listai1[i].DEFENDENDO && listai1[i].AGACHADO)
                    {
                        spriteBatch.Draw(i1.imgAgacharDi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoAgachari1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoAgachari1.Y,
                                                       listai1[i].tamanhoAgachari1.X, listai1[i].tamanhoAgachari1.Y), Color.White);

                    }

                    
                    //CAIDO
                    //CAIDO
                    //CAIDO
                    //CAIDO
                    if (listai1[i].CAIDO)
                    {
                        spriteBatch.Draw(i1.imgCaidoDi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoCaidoi1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoCaidoi1.Y,
                                                       listai1[i].tamanhoCaidoi1.X, listai1[i].tamanhoCaidoi1.Y), Color.White);
                    }
                    //LEVANTANDO
                    //LEVANTANDO
                    //LEVANTANDO
                    //LEVANTANDO
                    if (listai1[i].LEVANTANDO)
                    {
                        spriteBatch.Draw(i1.imgLevantarDi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoLevantari1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoLevantari1.Y,
                                                       listai1[i].tamanhoLevantari1.X, listai1[i].tamanhoLevantari1.Y), Color.White);
                    }
                    //RASTEIRA
                    //RASTEIRA
                    //RASTEIRA
                    //RASTEIRA
                    if (listai1[i].RASTEIRA)
                    {
                        spriteBatch.Draw(i1.imgRasteiraDi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoRasteirai1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoRasteirai1.Y,
                                                       listai1[i].tamanhoRasteirai1.X, listai1[i].tamanhoRasteirai1.Y), Color.White);
                    }
                    //ATAQUE
                    //ATAQUE
                    //ATAQUE
                    //ATAQUE
                    //ATAQUE
                    if (listai1[i].ATACANDO)
                    {
                        if (listai1[i].ATACK1)
                        {
                             spriteBatch.Draw(i1.imgATK1Di1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoATK1i1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoATK1i1.Y,
                                                       listai1[i].tamanhoATK1i1.X, listai1[i].tamanhoATK1i1.Y), Color.White);
                    
                        }

                        //LANÇAR FACA
                        //LANÇAR FACA
                        //LANÇAR FACA
                        //LANÇAR FACA
                        //LANÇAR FACA
                        if (listai1[i].Jogar_Faca)
                        {
                            spriteBatch.Draw(i1.imgJogarFacaDi1, listai1[i].individuo,
                                new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoJogarFacai1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoJogarFacai1.Y,
                                                           listai1[i].tamanhoJogarFacai1.X, listai1[i].tamanhoJogarFacai1.Y), Color.White);

                        }
                    }
                    //AGARRAR
                    //AGARRAR
                    //AGARRAR
                    //AGARRAR
                    //AGARRAR
                    if (listai1[i].AGARRAR)
                    {
                        spriteBatch.Draw(i1.imgAgarrarDi1, listai1[i].individuo,
                       new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoAgarrari1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoAgarrari1.Y,
                                                  listai1[i].tamanhoAgarrari1.X, listai1[i].tamanhoAgarrari1.Y), Color.White);

                    }
                    //PODER
                    //PODER
                    //PODER
                    //PODER
                    if (listai1[i].PODER)
                    {
                        spriteBatch.Draw(i1.imgPODERDi1, listai1[i].individuo,
                       new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoPODERi1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoPODERi1.Y,
                                                  listai1[i].tamanhoPODERi1.X, listai1[i].tamanhoPODERi1.Y), Color.White);

                    }

                    //morrendo
                    //morrendo
                    //morrendo
                    //morrendo
                    if (listai1[i].MORRENDO)
                    {
                        spriteBatch.Draw(i1.imgMORTEDi1, listai1[i].individuo,
                       new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoMORTEi1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoMORTEi1.Y,
                                                  listai1[i].tamanhoMORTEi1.X, listai1[i].tamanhoMORTEi1.Y), Color.White);

                    }
                }




                //ESQUUERDA/ESQUUERDA/ESQUUERDA/ESQUUERDA/ESQUUERDA/ESQUUERDA/ESQUUERDA/ESQUUERDA/ESQUUERDA
                //ESQUUERDA
                //ESQUUERDA
                //ESQUUERDA
                //ESQUUERDA
                //ESQUUERDA
                if (listai1[i].ESQUERDA)
                {
                    if (listai1[i].ANDANDO)
                    {
                        spriteBatch.Draw(i1.imgAndarEi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameAndari1.X * listai1[i].tamanhoAndari1.X, listai1[i].frameAndari1.Y * listai1[i].tamanhoAndari1.Y,
                                                       listai1[i].tamanhoAndari1.X, listai1[i].tamanhoAndari1.Y), Color.White);
                    }
                    ///TOMANDO HIT
                    /////TOMANDO HIT
                    //TOMANDO HIT
                    //TOMANDO HIT
                    //TOMANDO HIT
                    if (listai1[i].TOMANDOHIT)
                    {
                        if (listai1[i].HIT1)
                        {
                            spriteBatch.Draw(i1.imgHit1Ei1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoHit1i1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoHit1i1.Y,
                                                       listai1[i].tamanhoHit1i1.X, listai1[i].tamanhoHit1i1.Y), Color.White);
                        }
                        if (listai1[i].HIT2)
                        {
                            spriteBatch.Draw(i1.imgHit2Ei1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoHit2i1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoHit2i1.Y,
                                                       listai1[i].tamanhoHit2i1.X, listai1[i].tamanhoHit2i1.Y), Color.White);

                        }
                        if (listai1[i].HIT3)
                        {
                            spriteBatch.Draw(i1.imgHit3Ei1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoHit3i1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoHit3i1.Y,
                                                       listai1[i].tamanhoHit3i1.X, listai1[i].tamanhoHit3i1.Y), Color.White);
                        }
                    }
                    //DEFENDENDO E AGACHADO
                    //DEFENDENDO E AGACHADO                             //DEFENDENDO E AGACHADO
                    //DEFENDENDO E AGACHADO 
                    //DEFENDENDO E AGACHADO 
                    //DEFENDENDO E AGACHADO
                    if (listai1[i].DEFENDENDO && listai1[i].AGACHADO)
                    {
                        spriteBatch.Draw(i1.imgAgacharDEFEi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoAgacharDEFi1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoAgacharDEFi1.Y,
                                                       listai1[i].tamanhoAgacharDEFi1.X, listai1[i].tamanhoAgacharDEFi1.Y), Color.White);
                        
                    }
                    //DEFENDENDO
                    //DEFENDENDO
                    //DEFENDENDO
                    //DEFENDENDO
                    //DEFENDENDO
                    if (listai1[i].DEFENDENDO && !listai1[i].AGACHADO)
                    {
                        spriteBatch.Draw(i1.imgDEFEi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoDEFi1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoDEFi1.Y,
                                                       listai1[i].tamanhoDEFi1.X, listai1[i].tamanhoDEFi1.Y), Color.White);

                    }
                    //AGACHADO
                    //AGACHADO
                    //AGACHADO
                    //AGACHADO
                    //AGACHADO
                    if (!listai1[i].DEFENDENDO && listai1[i].AGACHADO)
                    {
                        spriteBatch.Draw(i1.imgAgacharEi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoAgachari1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoAgachari1.Y,
                                                       listai1[i].tamanhoAgachari1.X, listai1[i].tamanhoAgachari1.Y), Color.White);

                    }
                    
                    
                    //CAIDO
                    //CAIDO
                    //CAIDO
                    //CAIDO
                    if (listai1[i].CAIDO)
                    {
                        spriteBatch.Draw(i1.imgCaidoEi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoCaidoi1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoCaidoi1.Y,
                                                       listai1[i].tamanhoCaidoi1.X, listai1[i].tamanhoCaidoi1.Y), Color.White);
                    }
                    //LEVANTANDO
                    //LEVANTANDO
                    //LEVANTANDO
                    //LEVANTANDO
                    if (listai1[i].LEVANTANDO)
                    {
                        spriteBatch.Draw(i1.imgLevantarEi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoLevantari1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoLevantari1.Y,
                                                       listai1[i].tamanhoLevantari1.X, listai1[i].tamanhoLevantari1.Y), Color.White);
                    }
                    //RASTEIRA
                    //RASTEIRA
                    //RASTEIRA
                    //RASTEIRA
                    if (listai1[i].RASTEIRA)
                    {
                        spriteBatch.Draw(i1.imgRasteiraEi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoRasteirai1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoRasteirai1.Y,
                                                       listai1[i].tamanhoRasteirai1.X, listai1[i].tamanhoRasteirai1.Y), Color.White);
                    }
                    //ATAQUE
                    //ATAQUE
                    //ATAQUE
                    //ATAQUE
                    //ATAQUE
                    if (listai1[i].ATACANDO)
                    {
                        if (listai1[i].ATACK1)
                        {
                            spriteBatch.Draw(i1.imgATK1Ei1, listai1[i].individuo,
                           new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoATK1i1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoATK1i1.Y,
                                                      listai1[i].tamanhoATK1i1.X, listai1[i].tamanhoATK1i1.Y), Color.White);

                        }
                        //LANÇAR FACA
                        //LANÇAR FACA
                        //LANÇAR FACA
                        //LANÇAR FACA
                        //LANÇAR FACA
                        if (listai1[i].Jogar_Faca)
                        {
                            spriteBatch.Draw(i1.imgJogarFacaEi1, listai1[i].individuo,
                                new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoJogarFacai1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoJogarFacai1.Y,
                                                           listai1[i].tamanhoJogarFacai1.X, listai1[i].tamanhoJogarFacai1.Y), Color.White);

                        }
                    }
                    //AGARRAR
                    //AGARRAR
                    //AGARRAR
                    //AGARRAR
                    //AGARRAR
                    if (listai1[i].AGARRAR)
                    {
                        spriteBatch.Draw(i1.imgAgarrarEi1, listai1[i].individuo,
                       new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoAgarrari1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoAgarrari1.Y,
                                                  listai1[i].tamanhoAgarrari1.X, listai1[i].tamanhoAgarrari1.Y), Color.White);

                    }

                    //PODER
                    //PODER
                    //PODER
                    //PODER
                    if (listai1[i].PODER)
                    {
                        spriteBatch.Draw(i1.imgPODEREi1, listai1[i].individuo,
                       new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoPODERi1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoPODERi1.Y,
                                                  listai1[i].tamanhoPODERi1.X, listai1[i].tamanhoPODERi1.Y), Color.White);

                    }
                    //morrendo
                    //morrendo
                    //morrendo
                    //morrendo
                    if (listai1[i].MORRENDO)
                    {
                        spriteBatch.Draw(i1.imgMORTEi1, listai1[i].individuo,
                       new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoMORTEi1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoMORTEi1.Y,
                                                  listai1[i].tamanhoMORTEi1.X, listai1[i].tamanhoMORTEi1.Y), Color.White);

                    }
                }//fim ESQUERDA
            }
            for (int i = 0; i < listai1.Count; i++)
            {
                //barras
                spriteBatch.Draw(P1.imgVIDA, listai1[i].VIDA, Color.White);
                spriteBatch.Draw(P1.imgMANA, listai1[i].MANA, Color.White);
                spriteBatch.Draw(P1.imgENERGIA, listai1[i].ENERGIA, Color.White);


                spriteBatch.DrawString(BARfont, "HP " + listai1[i].vida, new Vector2(listai1[i].VIDA.X + 5, listai1[i].VIDA.Y + listai1[i].VIDA.Height / 8), Color.Black);

                spriteBatch.DrawString(BARfont, "PODER " + listai1[i].mana, new Vector2(listai1[i].VIDA.X + 5, listai1[i].VIDA.Y + listai1[i].VIDA.Height / 2), Color.Black);

                spriteBatch.DrawString(BARfont, "ENERGIA " + listai1[i].energia, new Vector2(listai1[i].VIDA.X + 8, listai1[i].VIDA.Y + listai1[i].VIDA.Height / 2 + listai1[i].VIDA.Height / 4), Color.Black);

                if (listai1[i].individuo.X > TELACHEIA.X + TELACHEIA.Width)
                {
                    spriteBatch.Draw(imgFlechaD, FlechaD, Color.White);
                }
                if (listai1[i].individuo.X < TELACHEIA.X)
                {
                    spriteBatch.Draw(imgFlechaE, FlechaE, Color.White);
                }


            }




            //--------------------------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------
            // ------------------------------------ ( LISTAS DO P1 )--------------------------------------------
            // ------------------------------------ ( LISTAS DO P1 )--------------------------------------------
            // ------------------------------------ ( LISTAS DO P1 )--------------------------------------------
            // ------------------------------------ ( LISTAS DO P1 )--------------------------------------------
            // ------------------------------------ ( LISTAS DO P1 )--------------------------------------------
            //visu efect
            for (int a = 0; a < P1.listadevisualPOWER.Count; a++)
            {
                spriteBatch.Draw(Poder_Visual.p.imgcirculo, P1.listadevisualPOWER[a].R, Color.White);
            }
            if (Contexto.Fase[0]) //APENAS NA FASE 1
            {
                //agua
                for (int a = 0; a < P1.listadeagua.Count; a++)
                {
                    spriteBatch.Draw(DefineAgua.imgAgua, P1.listadeagua[a].AguaR, Color.SteelBlue);
                    
                }
                //onda de agua
                for (int a = 0; a < P1.listadeondadeagua.Count; a++)
                {
                    spriteBatch.Draw(DefineAgua.imgOndas, P1.listadeondadeagua[a].R, new Rectangle(P1.listadeondadeagua[a].frame.X * P1.listadeondadeagua[a].tamanho.X, P1.listadeondadeagua[a].frame.Y * P1.listadeondadeagua[a].tamanho.Y,
                                                    P1.listadeondadeagua[a].tamanho.X, P1.listadeondadeagua[a].tamanho.Y), Color.White);
                }
            }
            /// ----------------
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


                //ATAQUE
                if (P1.ATACANDO)
                {
                    if (P1.DIREITA)
                    {
                        if (P1.PARTE1)
                        {
                            spriteBatch.Draw(P1.imgsoco1, P1.individuo,
                                        new Rectangle(P1.frameLUTA.X * P1.tamanhosoco1.X, P1.frameLUTA.Y * P1.tamanhosoco1.Y,
                                                      P1.tamanhosoco1.X, P1.tamanhosoco1.Y),
                                                      Color.White);
                        }
                        if (P1.COMBO1)
                        {
                            if (P1.PARTE2)
                            {
                                spriteBatch.Draw(P1.imgsoco2C1, P1.individuo,
                                        new Rectangle(P1.frameLUTA.X * P1.tamanhosoco2C1.X, P1.frameLUTA.Y * P1.tamanhosoco2C1.Y,
                                                      P1.tamanhosoco2C1.X, P1.tamanhosoco2C1.Y),
                                                      Color.White);
                            }
                            if (P1.PARTE3)
                            {
                                spriteBatch.Draw(P1.imgsoco3C1, P1.individuo,
                                        new Rectangle(P1.frameLUTA.X * P1.tamanhosoco3C1.X, P1.frameLUTA.Y * P1.tamanhosoco3C1.Y,
                                                      P1.tamanhosoco3C1.X, P1.tamanhosoco3C1.Y),
                                                      Color.White);
                            }
                            if (P1.PARTE4)
                            {
                                spriteBatch.Draw(P1.imgjoelhada4C1, P1.individuo,
                                        new Rectangle(P1.frameLUTA.X * P1.tamanhojoelhada4C1.X, P1.frameLUTA.Y * P1.tamanhojoelhada4C1.Y,
                                                      P1.tamanhojoelhada4C1.X, P1.tamanhojoelhada4C1.Y),
                                                      Color.White);
                            }
                        }//combo 1
                        
                    }//fim D

                   
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

                if (P1.ESQUERDA)
                {
                    if (P1.PARTE1)
                    {
                        spriteBatch.Draw(P1.imgsoco1E, P1.individuo,
                                    new Rectangle(P1.frameLUTA.X * P1.tamanhosoco1.X, P1.frameLUTA.Y * P1.tamanhosoco1.Y,
                                                  P1.tamanhosoco1.X, P1.tamanhosoco1.Y),
                                                  Color.White);
                    }
                    if (P1.COMBO1)
                    {
                        if (P1.PARTE2)
                        {
                            spriteBatch.Draw(P1.imgsoco2C1E, P1.individuo,
                                    new Rectangle(P1.frameLUTA.X * P1.tamanhosoco2C1.X, P1.frameLUTA.Y * P1.tamanhosoco2C1.Y,
                                                  P1.tamanhosoco2C1.X, P1.tamanhosoco2C1.Y),
                                                  Color.White);
                        }
                        if (P1.PARTE3)
                        {
                            spriteBatch.Draw(P1.imgsoco3C1E, P1.individuo,
                                    new Rectangle(P1.frameLUTA.X * P1.tamanhosoco3C1.X, P1.frameLUTA.Y * P1.tamanhosoco3C1.Y,
                                                  P1.tamanhosoco3C1.X, P1.tamanhosoco3C1.Y),
                                                  Color.White);
                        }
                        if (P1.PARTE4)
                        {
                            spriteBatch.Draw(P1.imgjoelhada4C1E, P1.individuo,
                                    new Rectangle(P1.frameLUTA.X * P1.tamanhojoelhada4C1.X, P1.frameLUTA.Y * P1.tamanhojoelhada4C1.Y,
                                                  P1.tamanhojoelhada4C1.X, P1.tamanhojoelhada4C1.Y),
                                                  Color.White);
                        }
                    }//fim combo1
                }//fim esquerda
            }

            

            if (P1.PODER)
            {
                spriteBatch.Draw(Contexto.Fundo.imgfundopoder, TELACHEIA, Color.White);
            }

            //HUD P1
            spriteBatch.Draw(P1.imgBARRA, P1.Barra, Color.White);
            spriteBatch.Draw(P1.imgVIDA, P1.BarraVida, Color.White);
            spriteBatch.DrawString(HUDfont, "HP " + P1.vida, new Vector2(P1.BarraVida.X + 5, P1.BarraVida.Y + HeightTela / 100 + HeightTela / 200), Color.Black);
            spriteBatch.Draw(P1.imgMANA, P1.BarraMana, Color.White);
            spriteBatch.DrawString(HUDfont, "PODER " + P1.mana, new Vector2(P1.BarraMana.X + 5, P1.BarraMana.Y + (HeightTela / 100 * 5) + HeightTela / 200), Color.Black);
            spriteBatch.Draw(P1.imgENERGIA, P1.BarraEnergia, Color.White);
            spriteBatch.DrawString(HUDfont, "ENERGIA " + P1.energia, new Vector2(P1.BarraEnergia.X + 8, P1.BarraEnergia.Y + (HeightTela / 100 * 8)), Color.Black);
            spriteBatch.Draw(P1.imgSOBRE, P1.Barra, Color.White);

            spriteBatch.Draw(P1.imgXP, P1.XPrec, Color.White);
            spriteBatch.DrawString(HUDfont, "XP " + P1.XP, new Vector2(P1.XPrec.X + HeightTela / 100, P1.XPrec.Y + HeightTela / 100), Color.Black);//dentro da barra de xp
            spriteBatch.DrawString(HUDfont, "LVL " + P1.LVL, new Vector2(P1.XPrec.X + HeightTela / 100, P1.XPrec.Y + P1.XPrec.Height + HeightTela / 100), Color.GreenYellow); // LVL
            spriteBatch.Draw(P1.imgXPT, P1.XPTrec, Color.White);
            spriteBatch.Draw(P1.imgpino, P1.Pino, Color.White);

        }//fim draw combate
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------














        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        public void Drawmenu00(int WidthTela, int HeightTela, SpriteBatch spriteBatch, Texture2D imgAPPLY2, Texture2D imgAPPLY3, Texture2D imgAPPLY, Rectangle APPLY, bool Bapply, Rectangle[] B1, Texture2D imgB1, Texture2D imgB2, bool[] b1, bool BFULL, SpriteFont menu, Rectangle Bfull,Menu M1)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);

            spriteBatch.Draw(M1.imgintromenu_comtraçado, new Rectangle(0, 0, WidthTela, HeightTela), Color.White);

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

            spriteBatch.DrawString(menu, "1360x768p", new Vector2(B1[2].X, B1[2].Y - 15), Color.White);

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
            spriteBatch.Draw(M1.imgintromenu_semtraçado, new Rectangle(0, 0, WidthTela, HeightTela), Color.White);

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
        public void DrawJANELA(Botoes Botao, SpriteBatch spriteBatch)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            spriteBatch.Draw(JANELA.J.imgFUNDOmenu, JANELA.J.FUNDO, Color.White);

            if (JANELA.J.JANELACOMBO)
            {
                spriteBatch.Draw(JANELA.J.imgjanelacombo, JANELA.J.R, Color.White);
                spriteBatch.Draw(JANELA.J.imgbotaoCombosON, JANELA.J.Bcombos, Color.White);
                spriteBatch.Draw(JANELA.J.imgbotaoComercioOFF, JANELA.J.Bcomercio, Color.White);
            }
            if (JANELA.J.JANELACOMERCIO)
            {
                spriteBatch.Draw(JANELA.J.imgjanelacomercio, JANELA.J.R, Color.White);
                spriteBatch.Draw(JANELA.J.imgbotaoCombosOFF, JANELA.J.Bcombos, Color.White);
                spriteBatch.Draw(JANELA.J.imgbotaoComercioON, JANELA.J.Bcomercio, Color.White);
            }
            spriteBatch.Draw(JANELA.J.imgjanelacinzaopç1, JANELA.J.CAPAopç1, Color.White);
            //pet
            if (!JANELA.J.PET)
            {
                spriteBatch.Draw(JANELA.J.imgbotaoPetOFF, JANELA.J.Bpet, Color.White);
            }
            else if (JANELA.J.PET)
            {
                spriteBatch.Draw(JANELA.J.imgbotaoPetON, JANELA.J.Bpet, Color.White);
            }
            //poderes
            if (!JANELA.J.PODERES)
            {
                spriteBatch.Draw(JANELA.J.imgbotaoPoderesOFF, JANELA.J.Bpoderes, Color.White);
            }
            else if (JANELA.J.PODERES)
            {
                spriteBatch.Draw(JANELA.J.imgbotaoPoderesON, JANELA.J.Bpoderes, Color.White);
            }
            //armas
            if (!JANELA.J.ARMAS)
            {
                spriteBatch.Draw(JANELA.J.imgbotaoArmasOFF, JANELA.J.Barmas, Color.White);
            }
            else if (JANELA.J.ARMAS)
            {
                spriteBatch.Draw(JANELA.J.imgbotaoArmasON, JANELA.J.Barmas, Color.White);
            }
            
            if (JANELA.J.xis.Contains(mousePosition))
            {
                spriteBatch.Draw(JANELA.J.imgbotaoXred, JANELA.J.xis, Color.White);
            }
            else if (!JANELA.J.xis.Contains(mousePosition))
            {
                spriteBatch.Draw(JANELA.J.imgbotaoX, JANELA.J.xis, Color.White);
            }
        }
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------

        public void DrawMENUPAUSE(SpriteBatch spriteBatch, int W, int H)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);

            spriteBatch.Draw(JANELA.J.imgFUNDOmenu, JANELA.J.FUNDO, Color.White);
            spriteBatch.Draw(JANELA.J.imgpauseJANELA, JANELA.J.pauseJANELA, Color.White);

            if (!JANELA.J.Bsair.Contains(mousePosition))//sem
            {
                spriteBatch.Draw(JANELA.J.imgBsair1, JANELA.J.Bsair, Color.White);
            }
            if (JANELA.J.Bsair.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)//encima
            {
                spriteBatch.Draw(JANELA.J.imgBsair2, JANELA.J.Bsair, Color.White);
            }
            if (JANELA.J.Bsair.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)//click
            {
                spriteBatch.Draw(JANELA.J.imgBsair3, JANELA.J.Bsair, Color.White);
            }

            if (!JANELA.J.Bresume.Contains(mousePosition))//sem
            {
                spriteBatch.Draw(JANELA.J.imgBresume1, JANELA.J.Bresume, Color.White);
            }
            if (JANELA.J.Bresume.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)//encima
            {
                spriteBatch.Draw(JANELA.J.imgBresume2, JANELA.J.Bresume, Color.White);
            }
            if (JANELA.J.Bresume.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)//click
            {
                spriteBatch.Draw(JANELA.J.imgBresume3, JANELA.J.Bresume, Color.White);
            }

        }

        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------


        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        public void DrawJANELAopçfase(Botoes Botao, SpriteBatch spriteBatch, bool MENU, Menu M1)
        {
            spriteBatch.Draw(JANELA.J.imgFUNDOmenu, JANELA.J.FUNDO, Color.White);
            spriteBatch.Draw(JANELA.J.imgfaseB1, JANELA.J.Rfase[0], Color.White);

            for (int i = 0; i < JANELA.J.Rfase.Length; i++)
            {
                spriteBatch.Draw(JANELA.J.imgPbranco, JANELA.J.linhas[i], Color.Red);
            }
        }



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

            //HOME
            //HOME
            //HOME
            //HOME
            //HOME
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

            //COMERCIO
            //COMERCIO
            //COMERCIO
            //COMERCIO
            //COMERCIO
            if (JANELA.J.JANELACOMERCIO)
            {
                if (Botao.COMERCIOquadrado.Contains(mousePosition))
                {
                    spriteBatch.Draw(Botao.imgcomercioON, Botao.COMERCIOquadrado, Color.Gold);
                }
                else
                {
                    spriteBatch.Draw(Botao.imgcomercioON, Botao.COMERCIOquadrado, Color.White);
                }

            }
            else if (!JANELA.J.JANELACOMERCIO)
            {
                if (Botao.COMERCIOquadrado.Contains(mousePosition))
                {
                    spriteBatch.Draw(Botao.imgcomercioOFF, Botao.COMERCIOquadrado, Color.Violet);
                    if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        spriteBatch.Draw(Botao.imgcomercioON, Botao.COMERCIOquadrado, Color.Yellow);
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
            }//fim

            //COMBOS
            //COMBOS
            //COMBOS
            //COMBOS
            //COMBOS
            if (JANELA.J.JANELACOMBO)
            {
                if (Botao.COMBOSquadrado.Contains(mousePosition))
                {
                    spriteBatch.Draw(Botao.imgcombosON, Botao.COMBOSquadrado, Color.CornflowerBlue);
                }
                else
                {
                    spriteBatch.Draw(Botao.imgcombosON, Botao.COMBOSquadrado, Color.White);
                }

            }
            else if (!JANELA.J.JANELACOMBO)
            {
                if (Botao.COMBOSquadrado.Contains(mousePosition))
                {
                    spriteBatch.Draw(Botao.imgcombosOFF, Botao.COMBOSquadrado, Color.Pink);
                    if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        spriteBatch.Draw(Botao.imgcombosON, Botao.COMBOSquadrado, Color.CornflowerBlue);
                    }
                }
                else
                {
                    if (MENU)
                        spriteBatch.Draw(Botao.imgcombosOFF, Botao.COMBOSquadrado, Color.White);
                    else if (M1.COMBATE || M1.HISTORY) //diferença entre game e menu
                    {
                        spriteBatch.Draw(Botao.imgcombosOFFTP, Botao.COMBOSquadrado, Color.White);
                    }
                }
            }//fim

        }//fim do draw BOTOES ESTATICOS
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------


        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------

        public void DrawDano(SpriteBatch spriteBatch, Personagem P1)
        {
            if (P1.listadedano.Count > 0)
            {
                for (int i = 0; i < P1.listadedano.Count; i++)
                {
                    if (P1.listadedano[i].opç == 1)//hit
                    {
                        spriteBatch.DrawString(JANELA.J.Neon, "" + P1.listadedano[i].qntd, new Vector2(P1.listadedano[i].P.X, P1.listadedano[i].P.Y), Color.White);
                    }
                    if (P1.listadedano[i].opç == 2)//dano
                    {
                        spriteBatch.DrawString(JANELA.J.Firefont, "" + P1.listadedano[i].qntd, new Vector2(P1.listadedano[i].P.X, P1.listadedano[i].P.Y), Color.Red);
                    }
                    if (P1.listadedano[i].opç == 3)//heal
                    {
                        spriteBatch.DrawString(JANELA.J.Neon, "" + P1.listadedano[i].qntd, new Vector2(P1.listadedano[i].P.X, P1.listadedano[i].P.Y), Color.Green);
                    }
                }
            }
        }//fim draw dano

        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------


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
                    if (P1.clonelistaPoder[i].PARTE1)
                    {
                        spriteBatch.Draw(P1.imgsoco1, P1.clonelistaPoder[i].individuo,
                                    new Rectangle(P1.clonelistaPoder[i].frameLUTA.X * P1.clonelistaPoder[i].tamanhosoco1.X, P1.clonelistaPoder[i].frameLUTA.Y * P1.clonelistaPoder[i].tamanhosoco1.Y,
                                                  P1.clonelistaPoder[i].tamanhosoco1.X, P1.clonelistaPoder[i].tamanhosoco1.Y),
                                                  Color.White);
                    }
                    if (P1.clonelistaPoder[i].COMBO1)
                    {
                        if (P1.clonelistaPoder[i].PARTE2)
                        {
                            spriteBatch.Draw(P1.imgsoco2C1, P1.clonelistaPoder[i].individuo,
                                    new Rectangle(P1.clonelistaPoder[i].frameLUTA.X * P1.clonelistaPoder[i].tamanhosoco2C1.X, P1.clonelistaPoder[i].frameLUTA.Y * P1.clonelistaPoder[i].tamanhosoco2C1.Y,
                                                  P1.clonelistaPoder[i].tamanhosoco2C1.X, P1.clonelistaPoder[i].tamanhosoco2C1.Y),
                                                  Color.White);
                        }
                        if (P1.clonelistaPoder[i].PARTE3)
                        {
                            spriteBatch.Draw(P1.imgsoco3C1, P1.clonelistaPoder[i].individuo,
                                    new Rectangle(P1.clonelistaPoder[i].frameLUTA.X * P1.clonelistaPoder[i].tamanhosoco3C1.X, P1.clonelistaPoder[i].frameLUTA.Y * P1.clonelistaPoder[i].tamanhosoco3C1.Y,
                                                  P1.clonelistaPoder[i].tamanhosoco3C1.X, P1.clonelistaPoder[i].tamanhosoco3C1.Y),
                                                  Color.White);
                        }
                        if (P1.clonelistaPoder[i].PARTE4)
                        {
                            spriteBatch.Draw(P1.imgjoelhada4C1, P1.clonelistaPoder[i].individuo,
                                    new Rectangle(P1.clonelistaPoder[i].frameLUTA.X * P1.clonelistaPoder[i].tamanhojoelhada4C1.X, P1.clonelistaPoder[i].frameLUTA.Y * P1.clonelistaPoder[i].tamanhojoelhada4C1.Y,
                                                  P1.clonelistaPoder[i].tamanhojoelhada4C1.X, P1.clonelistaPoder[i].tamanhojoelhada4C1.Y),
                                                  Color.White);
                        }
                    }//fim combo1
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

                    if (P1.clonelistaPoder[i].PARTE1)
                    {
                        spriteBatch.Draw(P1.imgsoco1E, P1.clonelistaPoder[i].individuo,
                                    new Rectangle(P1.clonelistaPoder[i].frameLUTA.X * P1.clonelistaPoder[i].tamanhosoco1.X, P1.clonelistaPoder[i].frameLUTA.Y * P1.clonelistaPoder[i].tamanhosoco1.Y,
                                                  P1.clonelistaPoder[i].tamanhosoco1.X, P1.clonelistaPoder[i].tamanhosoco1.Y),
                                                  Color.White);
                    }
                    if (P1.clonelistaPoder[i].COMBO1)
                    {
                        if (P1.clonelistaPoder[i].PARTE2)
                        {
                            spriteBatch.Draw(P1.imgsoco2C1E, P1.clonelistaPoder[i].individuo,
                                    new Rectangle(P1.clonelistaPoder[i].frameLUTA.X * P1.clonelistaPoder[i].tamanhosoco2C1.X, P1.clonelistaPoder[i].frameLUTA.Y * P1.clonelistaPoder[i].tamanhosoco2C1.Y,
                                                  P1.clonelistaPoder[i].tamanhosoco2C1.X, P1.clonelistaPoder[i].tamanhosoco2C1.Y),
                                                  Color.White);
                        }
                        if (P1.clonelistaPoder[i].PARTE3)
                        {
                            spriteBatch.Draw(P1.imgsoco3C1E, P1.clonelistaPoder[i].individuo,
                                    new Rectangle(P1.clonelistaPoder[i].frameLUTA.X * P1.clonelistaPoder[i].tamanhosoco3C1.X, P1.clonelistaPoder[i].frameLUTA.Y * P1.clonelistaPoder[i].tamanhosoco3C1.Y,
                                                  P1.clonelistaPoder[i].tamanhosoco3C1.X, P1.clonelistaPoder[i].tamanhosoco3C1.Y),
                                                  Color.White);
                        }
                        if (P1.clonelistaPoder[i].PARTE4)
                        {
                            spriteBatch.Draw(P1.imgjoelhada4C1E, P1.clonelistaPoder[i].individuo,
                                    new Rectangle(P1.clonelistaPoder[i].frameLUTA.X * P1.clonelistaPoder[i].tamanhojoelhada4C1.X, P1.clonelistaPoder[i].frameLUTA.Y * P1.clonelistaPoder[i].tamanhojoelhada4C1.Y,
                                                  P1.clonelistaPoder[i].tamanhojoelhada4C1.X, P1.clonelistaPoder[i].tamanhojoelhada4C1.Y),
                                                  Color.White);
                        }
                    }//fim combo1
                
                }
            }
        }
    }
}
