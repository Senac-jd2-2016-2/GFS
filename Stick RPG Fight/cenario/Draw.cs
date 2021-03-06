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
    class Draw
    {
        public void DrawCombate(SpriteBatch s, Personagem P1, List<Inimigo> listai1, Rectangle FlechaD, Rectangle FlechaE, Texture2D imgFlechaD, Texture2D imgFlechaE, SpriteFont menu, SpriteFont HUDfont, int WidthTela, int HeightTela, Texture2D imgSangue, Inimigo i1, Agua DefineAgua, SpriteFont BARfont)
        {
            for (int i = 0; i < Contexto.Fase.Length; i++)
            {
                if (Contexto.Fase[i])
                {
                    s.Draw(Contexto.Fundo.imgfase[i], Contexto.Fundo.fase, Color.White); // fundo
                }
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
                for (int a = 0; a < listai1[i].listadevisualPOWER.Count; a++)
                {
                    s.Draw(Poder_Visual.p.imgcirculo, listai1[i].listadevisualPOWER[a].R, Color.Red);
                }
                //sangue
                for (int a = 0; a < listai1[i].listadesangue.Count; a++)// APARECER SANGUE
                {
                    s.Draw(imgSangue, listai1[i].listadesangue[a].sangueR, Color.White);

                }

                if (Contexto.Fase[0]) //APENAS NA FASE 1
                {
                    for (int a = 0; a < listai1[i].listadeagua.Count; a++)
                    {
                        s.Draw(DefineAgua.imgAgua, listai1[i].listadeagua[a].AguaR, Color.White);

                    }
                    for (int a = 0; a < listai1[i].listadeondadeagua.Count; a++)
                    {
                        s.Draw(DefineAgua.imgOndas, listai1[i].listadeondadeagua[a].R, new Rectangle(listai1[i].listadeondadeagua[a].frame.X * listai1[i].listadeondadeagua[a].tamanho.X, listai1[i].listadeondadeagua[a].frame.Y * listai1[i].listadeondadeagua[a].tamanho.Y,
                                                    listai1[i].listadeondadeagua[a].tamanho.X, listai1[i].listadeondadeagua[a].tamanho.Y), Color.White);
                    }
                }

                for (int a = 0; a < listai1[i].listadefacas.Count; a++)
                {
                    if (listai1[i].faca_voando && listai1[i].listadefacas.Count > 0)
                    {
                        if (listai1[i].listadefacas[a].esquerda)
                            s.Draw(i1.imgFacaEi1, listai1[i].listadefacas[a].OBJ, new Rectangle(listai1[i].listadefacas[a].frameFACA.X * listai1[i].listadefacas[a].tamanhoFacai1.X, listai1[i].listadefacas[a].frameFACA.Y * listai1[i].listadefacas[a].tamanhoFacai1.Y,
                                                           listai1[i].listadefacas[a].tamanhoFacai1.X, listai1[i].listadefacas[a].tamanhoFacai1.Y), Color.White);
                        if (listai1[i].listadefacas[a].direita)
                            s.Draw(i1.imgFacaDi1, listai1[i].listadefacas[a].OBJ, new Rectangle(listai1[i].listadefacas[a].frameFACA.X * listai1[i].listadefacas[a].tamanhoFacai1.X, listai1[i].listadefacas[a].frameFACA.Y * listai1[i].listadefacas[a].tamanhoFacai1.Y,
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
                    s.Draw(i1.imgParadoi1, listai1[i].individuo,
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
                    if (listai1[i].ANDANDO && !listai1[i].PARADO)
                    {
                        s.Draw(i1.imgAndarDi1, listai1[i].individuo,
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
                            s.Draw(i1.imgHit1Di1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoHit1i1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoHit1i1.Y,
                                                       listai1[i].tamanhoHit1i1.X, listai1[i].tamanhoHit1i1.Y), Color.White);
                        }
                        if (listai1[i].HIT2)
                        {
                            s.Draw(i1.imgHit2Di1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoHit2i1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoHit2i1.Y,
                                                       listai1[i].tamanhoHit2i1.X, listai1[i].tamanhoHit2i1.Y), Color.White);

                        }
                        if (listai1[i].HIT3)
                        {
                            s.Draw(i1.imgHit3Di1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoHit3i1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoHit3i1.Y,
                                                       listai1[i].tamanhoHit3i1.X, listai1[i].tamanhoHit3i1.Y), Color.White);
                        }
                    }
                    //DEFENDENDO E AGACHADO
                    //DEFENDENDO E AGACHADO
                    //DEFENDENDO E AGACHADO
                    if (listai1[i].DEFENDENDO && listai1[i].AGACHADO)
                    {
                        s.Draw(i1.imgAgacharDEFDi1, listai1[i].individuo,
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
                        s.Draw(i1.imgDEFDi1, listai1[i].individuo,
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
                        s.Draw(i1.imgAgacharDi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoAgachari1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoAgachari1.Y,
                                                       listai1[i].tamanhoAgachari1.X, listai1[i].tamanhoAgachari1.Y), Color.White);

                    }


                    //CAIDO
                    //CAIDO
                    //CAIDO
                    //CAIDO
                    if (listai1[i].CAIDO)
                    {
                        s.Draw(i1.imgCaidoDi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoCaidoi1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoCaidoi1.Y,
                                                       listai1[i].tamanhoCaidoi1.X, listai1[i].tamanhoCaidoi1.Y), Color.White);
                    }
                    //LEVANTANDO
                    //LEVANTANDO
                    //LEVANTANDO
                    //LEVANTANDO
                    if (listai1[i].LEVANTANDO)
                    {
                        s.Draw(i1.imgLevantarDi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoLevantari1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoLevantari1.Y,
                                                       listai1[i].tamanhoLevantari1.X, listai1[i].tamanhoLevantari1.Y), Color.White);
                    }
                    //RASTEIRA
                    //RASTEIRA
                    //RASTEIRA
                    //RASTEIRA
                    if (listai1[i].RASTEIRA)
                    {
                        s.Draw(i1.imgRasteiraDi1, listai1[i].individuo,
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
                            s.Draw(i1.imgATK1Di1, listai1[i].individuo,
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
                            s.Draw(i1.imgJogarFacaDi1, listai1[i].individuo,
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
                        s.Draw(i1.imgAgarrarDi1, listai1[i].individuo,
                       new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoAgarrari1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoAgarrari1.Y,
                                                  listai1[i].tamanhoAgarrari1.X, listai1[i].tamanhoAgarrari1.Y), Color.White);

                    }
                    //PODER
                    //PODER
                    //PODER
                    //PODER
                    if (listai1[i].PODER)
                    {
                        s.Draw(i1.imgPODERDi1, listai1[i].individuo,
                       new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoPODERi1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoPODERi1.Y,
                                                  listai1[i].tamanhoPODERi1.X, listai1[i].tamanhoPODERi1.Y), Color.White);

                    }

                    //morrendo
                    //morrendo
                    //morrendo
                    //morrendo
                    if (listai1[i].MORRENDO)
                    {
                        s.Draw(i1.imgMORTEDi1, listai1[i].individuo,
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
                    if (listai1[i].ANDANDO && !listai1[i].PARADO)
                    {
                        s.Draw(i1.imgAndarEi1, listai1[i].individuo,
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
                            s.Draw(i1.imgHit1Ei1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoHit1i1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoHit1i1.Y,
                                                       listai1[i].tamanhoHit1i1.X, listai1[i].tamanhoHit1i1.Y), Color.White);
                        }
                        if (listai1[i].HIT2)
                        {
                            s.Draw(i1.imgHit2Ei1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoHit2i1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoHit2i1.Y,
                                                       listai1[i].tamanhoHit2i1.X, listai1[i].tamanhoHit2i1.Y), Color.White);

                        }
                        if (listai1[i].HIT3)
                        {
                            s.Draw(i1.imgHit3Ei1, listai1[i].individuo,
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
                        s.Draw(i1.imgAgacharDEFEi1, listai1[i].individuo,
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
                        s.Draw(i1.imgDEFEi1, listai1[i].individuo,
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
                        s.Draw(i1.imgAgacharEi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoAgachari1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoAgachari1.Y,
                                                       listai1[i].tamanhoAgachari1.X, listai1[i].tamanhoAgachari1.Y), Color.White);

                    }


                    //CAIDO
                    //CAIDO
                    //CAIDO
                    //CAIDO
                    if (listai1[i].CAIDO)
                    {
                        s.Draw(i1.imgCaidoEi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoCaidoi1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoCaidoi1.Y,
                                                       listai1[i].tamanhoCaidoi1.X, listai1[i].tamanhoCaidoi1.Y), Color.White);
                    }
                    //LEVANTANDO
                    //LEVANTANDO
                    //LEVANTANDO
                    //LEVANTANDO
                    if (listai1[i].LEVANTANDO)
                    {
                        s.Draw(i1.imgLevantarEi1, listai1[i].individuo,
                            new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoLevantari1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoLevantari1.Y,
                                                       listai1[i].tamanhoLevantari1.X, listai1[i].tamanhoLevantari1.Y), Color.White);
                    }
                    //RASTEIRA
                    //RASTEIRA
                    //RASTEIRA
                    //RASTEIRA
                    if (listai1[i].RASTEIRA)
                    {
                        s.Draw(i1.imgRasteiraEi1, listai1[i].individuo,
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
                            s.Draw(i1.imgATK1Ei1, listai1[i].individuo,
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
                            s.Draw(i1.imgJogarFacaEi1, listai1[i].individuo,
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
                        s.Draw(i1.imgAgarrarEi1, listai1[i].individuo,
                       new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoAgarrari1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoAgarrari1.Y,
                                                  listai1[i].tamanhoAgarrari1.X, listai1[i].tamanhoAgarrari1.Y), Color.White);

                    }

                    //PODER
                    //PODER
                    //PODER
                    //PODER
                    if (listai1[i].PODER)
                    {
                        s.Draw(i1.imgPODEREi1, listai1[i].individuo,
                       new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoPODERi1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoPODERi1.Y,
                                                  listai1[i].tamanhoPODERi1.X, listai1[i].tamanhoPODERi1.Y), Color.White);

                    }
                    //morrendo
                    //morrendo
                    //morrendo
                    //morrendo
                    if (listai1[i].MORRENDO)
                    {
                        s.Draw(i1.imgMORTEi1, listai1[i].individuo,
                       new Rectangle(listai1[i].frameALLi1.X * listai1[i].tamanhoMORTEi1.X, listai1[i].frameALLi1.Y * listai1[i].tamanhoMORTEi1.Y,
                                                  listai1[i].tamanhoMORTEi1.X, listai1[i].tamanhoMORTEi1.Y), Color.White);

                    }
                }//fim ESQUERDA
            }
            for (int i = 0; i < listai1.Count; i++)
            {
                //barras
                s.Draw(P1.imgVIDA, listai1[i].VIDA, Color.White);
                //vida perdida
                for (int a = 0; a < listai1[i].listavidaperdida.Count; a++)
                {
                    if (listai1[i].listavidaperdida.Count > 0 && listai1[i].vida >= 0)
                    {
                        s.Draw(P1.imgVIDA2, listai1[i].listavidaperdida[a].R, Color.White);
                    }
                }
                s.Draw(P1.imgMANA, listai1[i].MANA, Color.White);
                s.Draw(P1.imgENERGIA, listai1[i].ENERGIA, Color.White);


                s.DrawString(BARfont, "HP " + listai1[i].vida, new Vector2(listai1[i].VIDA.X + 5, listai1[i].VIDA.Y + listai1[i].VIDA.Height / 8), Color.Black);

                s.DrawString(BARfont, "PODER " + listai1[i].mana, new Vector2(listai1[i].VIDA.X + 5, listai1[i].VIDA.Y + listai1[i].VIDA.Height / 2), Color.Black);

                s.DrawString(BARfont, "ENERGIA " + listai1[i].energia, new Vector2(listai1[i].VIDA.X + 8, listai1[i].VIDA.Y + listai1[i].VIDA.Height / 2 + listai1[i].VIDA.Height / 4), Color.Black);

                if (listai1[i].individuo.X > JANELA.J.FUNDO.X + JANELA.J.FUNDO.Width)
                {
                    s.Draw(imgFlechaD, FlechaD, Color.White);
                }
                if (listai1[i].individuo.X < JANELA.J.FUNDO.X)
                {
                    s.Draw(imgFlechaE, FlechaE, Color.White);
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
                s.Draw(Poder_Visual.p.imgcirculo, P1.listadevisualPOWER[a].R, Color.White);
            }
            if (Contexto.Fase[0]) //APENAS NA FASE 1
            {
                //agua
                for (int a = 0; a < P1.listadeagua.Count; a++)
                {
                    s.Draw(DefineAgua.imgAgua, P1.listadeagua[a].AguaR, Color.SteelBlue);

                }
                //onda de agua
                for (int a = 0; a < P1.listadeondadeagua.Count; a++)
                {
                    s.Draw(DefineAgua.imgOndas, P1.listadeondadeagua[a].R, new Rectangle(P1.listadeondadeagua[a].frame.X * P1.listadeondadeagua[a].tamanho.X, P1.listadeondadeagua[a].frame.Y * P1.listadeondadeagua[a].tamanho.Y,
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
                        s.Draw(P1.imgparado1maosD, P1.individuo,
                                      new Rectangle(P1.frameparado1.X * P1.tamanhoMaosparado1.X, P1.frameparado1.Y * P1.tamanhoMaosparado1.Y,
                                                    P1.tamanhoMaosparado1.X, P1.tamanhoMaosparado1.Y),
                                                    Color.White);
                    }
                }
                else if (P1.COMBATE)
                {
                    if (P1.PARADO && !P1.HIT1 && !P1.HIT2 && !P1.AGACHADOHIT)
                    {
                        s.Draw(P1.imgparado2maosD, P1.individuo,
                                      new Rectangle(P1.frameparado2.X * P1.tamanhoMaosparado2.X, P1.frameparado2.Y * P1.tamanhoMaosparado2.Y,
                                                    P1.tamanhoMaosparado2.X, P1.tamanhoMaosparado2.Y),
                                                    Color.White);
                    }
                }

                if (P1.COMBATE) // em combate
                {
                    if (P1.PARADO) // parado na luta
                    {
                        s.Draw(P1.imgparado2maosD, P1.individuo,
                                      new Rectangle(P1.frameparado2.X * P1.tamanhoMaosparado2.X, P1.frameparado2.Y * P1.tamanhoMaosparado2.Y,
                                                    P1.tamanhoMaosparado2.X, P1.tamanhoMaosparado2.Y),
                                                    Color.White);
                    }
                }

                if (P1.DEFENDENDO)
                {
                    if (JANELA.J.MAOselect)
                    {
                        s.Draw(P1.imgdefesamaosD, P1.individuo,
                                          new Rectangle(P1.framedefesa.X * P1.tamanhoMaosdefesa1.X, P1.framedefesa.Y * P1.tamanhoMaosdefesa1.Y,
                                                        P1.tamanhoMaosdefesa1.X, P1.tamanhoMaosdefesa1.Y),
                                                        Color.White);
                    }
                }

                if (P1.ANDANDO) // se movimentando pra direita
                {
                    if (JANELA.J.MAOselect)
                    {
                        s.Draw(P1.imgandandomaosD, P1.individuo,
                                          new Rectangle(P1.framemovendo.X * P1.tamanhoMaosandando.X, P1.framemovendo.Y * P1.tamanhoMaosandando.Y,
                                                        P1.tamanhoMaosandando.X, P1.tamanhoMaosandando.Y),
                                                        Color.White);
                    }
                }

                if (P1.CORRENDO)
                {
                    if (JANELA.J.MAOselect)
                    {
                        s.Draw(P1.imgcorrendomaosD, P1.individuo,
                                          new Rectangle(P1.framemovendo.X * P1.tamanhoMaoscorrendo.X, P1.framemovendo.Y * P1.tamanhoMaoscorrendo.Y,
                                                        P1.tamanhoMaoscorrendo.X, P1.tamanhoMaoscorrendo.Y),
                                                        Color.White);
                    }
                }

                if (P1.PULANDOandando || P1.PULANDOcorrendo || P1.PULANDOparado)
                {
                    if (JANELA.J.MAOselect)
                    {
                        s.Draw(P1.imgpularmaos, P1.individuo,
                                         new Rectangle(P1.framepular.X * P1.tamanhoMaospular.X, P1.framepular.Y * P1.tamanhoMaospular.Y,
                                                       P1.tamanhoMaospular.X, P1.tamanhoMaospular.Y),
                                                       Color.White);
                    }
                }

                //HIT
                if (P1.HIT1)
                {
                    if (JANELA.J.MAOselect)
                    {

                        s.Draw(P1.imgHIT1maosD, P1.individuo,
                                        new Rectangle(P1.frameHIT.X * P1.tamanhoMaosHIT1.X, P1.frameHIT.Y * P1.tamanhoMaosHIT1.Y,
                                                      P1.tamanhoMaosHIT1.X, P1.tamanhoMaosHIT1.Y),
                                                      Color.White);
                    }
                }
                if (P1.HIT2)
                {
                    if (JANELA.J.MAOselect)
                    {

                        s.Draw(P1.imgHIT2maosD, P1.individuo,
                                        new Rectangle(P1.frameHIT.X * P1.tamanhoMaosHIT2.X, P1.frameHIT.Y * P1.tamanhoMaosHIT2.Y,
                                                      P1.tamanhoMaosHIT2.X, P1.tamanhoMaosHIT2.Y),
                                                      Color.White);
                    }
                }
                if (P1.AGACHADOHIT)
                {
                    if (JANELA.J.MAOselect)
                    {

                        s.Draw(P1.imgagachadoHITmaosD, P1.individuo,
                                        new Rectangle(P1.frameHIT.X * P1.tamanhoMaosagachadoHIT.X, P1.frameHIT.Y * P1.tamanhoMaosagachadoHIT.Y,
                                                      P1.tamanhoMaosagachadoHIT.X, P1.tamanhoMaosagachadoHIT.Y),
                                                      Color.White);
                    }
                }


                //ATAQUE
                if (P1.ATACANDO)
                {
                   
                        if (P1.PARTE1)
                        {
                            s.Draw(P1.imgsoco1maos, P1.individuo,
                                        new Rectangle(P1.frameLUTA.X * P1.tamanhosoco1Maos.X, P1.frameLUTA.Y * P1.tamanhosoco1Maos.Y,
                                                      P1.tamanhosoco1Maos.X, P1.tamanhosoco1Maos.Y),
                                                      Color.White);
                        }
                        if (P1.COMBO1)
                        {
                            if (P1.PARTE2)
                            {
                                s.Draw(P1.imgsoco2C1maos, P1.individuo,
                                        new Rectangle(P1.frameLUTA.X * P1.tamanhosoco2C1Maos.X, P1.frameLUTA.Y * P1.tamanhosoco2C1Maos.Y,
                                                      P1.tamanhosoco2C1Maos.X, P1.tamanhosoco2C1Maos.Y),
                                                      Color.White);
                            }
                            if (P1.PARTE3)
                            {
                                s.Draw(P1.imgsoco3C1maos, P1.individuo,
                                        new Rectangle(P1.frameLUTA.X * P1.tamanhosoco3C1Maos.X, P1.frameLUTA.Y * P1.tamanhosoco3C1Maos.Y,
                                                      P1.tamanhosoco3C1Maos.X, P1.tamanhosoco3C1Maos.Y),
                                                      Color.White);
                            }
                            if (P1.PARTE4)
                            {
                                s.Draw(P1.imgjoelhada4C1Maos, P1.individuo,
                                        new Rectangle(P1.frameLUTA.X * P1.tamanhojoelhada4C1Maos.X, P1.frameLUTA.Y * P1.tamanhojoelhada4C1Maos.Y,
                                                      P1.tamanhojoelhada4C1Maos.X, P1.tamanhojoelhada4C1Maos.Y),
                                                      Color.White);
                            }
                        }//combo 1

                }//ataque
            }//fim D


            //--------------------------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------
            if (P1.ESQUERDA)
            {
                if (!P1.COMBATE) // fora de combate
                {
                    if (P1.PARADO ) // parado fora de luta
                    {
                        s.Draw(P1.imgparado1maosE, P1.individuo,
                                      new Rectangle(P1.frameparado1.X * P1.tamanhoMaosparado1.X, P1.frameparado1.Y * P1.tamanhoMaosparado1.Y,
                                                    P1.tamanhoMaosparado1.X, P1.tamanhoMaosparado1.Y),
                                                    Color.White);
                    }
                }
                else if (P1.COMBATE)
                {
                    if (P1.PARADO && !P1.HIT1 && !P1.HIT2 && !P1.AGACHADOHIT)
                    {
                        s.Draw(P1.imgparado2maosE, P1.individuo,
                                      new Rectangle(P1.frameparado2.X * P1.tamanhoMaosparado2.X, P1.frameparado2.Y * P1.tamanhoMaosparado2.Y,
                                                    P1.tamanhoMaosparado2.X, P1.tamanhoMaosparado2.Y),
                                                    Color.White);
                    }
                }

                if (P1.DEFENDENDO)
                {
                    if (JANELA.J.MAOselect)
                    {
                        s.Draw(P1.imgdefesamaosE, P1.individuo,
                                          new Rectangle(P1.framedefesa.X * P1.tamanhoMaosdefesa1.X, P1.framedefesa.Y * P1.tamanhoMaosdefesa1.Y,
                                                        P1.tamanhoMaosdefesa1.X, P1.tamanhoMaosdefesa1.Y),
                                                        Color.White);
                    }
                }

                if (P1.ANDANDO) // se movimentando pra esquerda
                {
                    if (JANELA.J.MAOselect)
                    {
                        s.Draw(P1.imgandandomaosE, P1.individuo,
                                          new Rectangle(P1.framemovendo.X * P1.tamanhoMaosandando.X, P1.framemovendo.Y * P1.tamanhoMaosandando.Y,
                                                        P1.tamanhoMaosandando.X, P1.tamanhoMaosandando.Y),
                                                        Color.White);
                    }
                }

                if (P1.CORRENDO)
                {
                    if (JANELA.J.MAOselect)
                    {
                        s.Draw(P1.imgcorrendomaosE, P1.individuo,
                                          new Rectangle(P1.framemovendo.X * P1.tamanhoMaoscorrendo.X, P1.framemovendo.Y * P1.tamanhoMaoscorrendo.Y,
                                                        P1.tamanhoMaoscorrendo.X, P1.tamanhoMaoscorrendo.Y),
                                                        Color.White);
                    }
                }

                if (P1.PULANDOandando || P1.PULANDOcorrendo || P1.PULANDOparado)
                {
                    if (JANELA.J.MAOselect)
                    {
                        s.Draw(P1.imgpularmaosE, P1.individuo,
                                         new Rectangle(P1.framepular.X * P1.tamanhoMaospular.X, P1.framepular.Y * P1.tamanhoMaospular.Y,
                                                       P1.tamanhoMaospular.X, P1.tamanhoMaospular.Y),
                                                       Color.White);
                    }
                }

                //HIT
                if (P1.HIT1)
                {
                    if (JANELA.J.MAOselect)
                    {

                        s.Draw(P1.imgHIT1maosE, P1.individuo,
                                        new Rectangle(P1.frameHIT.X * P1.tamanhoMaosHIT1.X, P1.frameHIT.Y * P1.tamanhoMaosHIT1.Y,
                                                      P1.tamanhoMaosHIT1.X, P1.tamanhoMaosHIT1.Y),
                                                      Color.White);
                    }
                }
                if (P1.HIT2)
                {
                    if (JANELA.J.MAOselect)
                    {

                        s.Draw(P1.imgHIT2maosE, P1.individuo,
                                        new Rectangle(P1.frameHIT.X * P1.tamanhoMaosHIT2.X, P1.frameHIT.Y * P1.tamanhoMaosHIT2.Y,
                                                      P1.tamanhoMaosHIT2.X, P1.tamanhoMaosHIT2.Y),
                                                      Color.White);
                    }
                }
                if (P1.AGACHADOHIT)
                {
                    if (JANELA.J.MAOselect)
                    {

                        s.Draw(P1.imgagachadoHITmaosE, P1.individuo,
                                        new Rectangle(P1.frameHIT.X * P1.tamanhoMaosagachadoHIT.X, P1.frameHIT.Y * P1.tamanhoMaosagachadoHIT.Y,
                                                      P1.tamanhoMaosagachadoHIT.X, P1.tamanhoMaosagachadoHIT.Y),
                                                      Color.White);
                    }
                }

                if (P1.ATACANDO)
                {
                    if (P1.PARTE1)
                    {
                        s.Draw(P1.imgsoco1maosE, P1.individuo,
                                    new Rectangle(P1.frameLUTA.X * P1.tamanhosoco1Maos.X, P1.frameLUTA.Y * P1.tamanhosoco1Maos.Y,
                                                  P1.tamanhosoco1Maos.X, P1.tamanhosoco1Maos.Y),
                                                  Color.White);
                    }
                    if (P1.COMBO1)
                    {
                        if (P1.PARTE2)
                        {
                            s.Draw(P1.imgsoco2C1maosE, P1.individuo,
                                    new Rectangle(P1.frameLUTA.X * P1.tamanhosoco2C1Maos.X, P1.frameLUTA.Y * P1.tamanhosoco2C1Maos.Y,
                                                  P1.tamanhosoco2C1Maos.X, P1.tamanhosoco2C1Maos.Y),
                                                  Color.White);
                        }
                        if (P1.PARTE3)
                        {
                            s.Draw(P1.imgsoco3C1maosE, P1.individuo,
                                    new Rectangle(P1.frameLUTA.X * P1.tamanhosoco3C1Maos.X, P1.frameLUTA.Y * P1.tamanhosoco3C1Maos.Y,
                                                  P1.tamanhosoco3C1Maos.X, P1.tamanhosoco3C1Maos.Y),
                                                  Color.White);
                        }
                        if (P1.PARTE4)
                        {
                            s.Draw(P1.imgjoelhada4C1maosE, P1.individuo,
                                    new Rectangle(P1.frameLUTA.X * P1.tamanhojoelhada4C1Maos.X, P1.frameLUTA.Y * P1.tamanhojoelhada4C1Maos.Y,
                                                  P1.tamanhojoelhada4C1Maos.X, P1.tamanhojoelhada4C1Maos.Y),
                                                  Color.White);
                        }
                    }//fim combo1
                }//fim ataque
            }//fim E



            if (P1.PODERretroceder || P1.PODERslow)
            {
                s.Draw(Contexto.Fundo.imgfundopoder, JANELA.J.FUNDO, Color.White);
            }

            //HUD P1
            s.Draw(P1.imgBARRA, P1.Barra, Color.White);
            s.Draw(P1.imgVIDA, P1.BarraVida, Color.White);
            //vida perdida
            for (int i = 0; i < P1.listavidaperdida.Count; i++)
            {
                if (P1.listavidaperdida.Count > 0 && P1.vida >= 0)
                {
                    s.Draw(P1.imgVIDA2, P1.listavidaperdida[i].R, Color.White);
                }
            }
            if (P1.PODERescudo)
            {
                s.Draw(ESCUDO.e.Bar, ESCUDO.e.BarHudP1, Color.White);
            }

            s.DrawString(HUDfont, "HP " + P1.vida, new Vector2(P1.BarraVida.X + 5, P1.BarraVida.Y + HeightTela / 100 + HeightTela / 200), Color.Black);
            s.Draw(P1.imgMANA, P1.BarraMana, Color.White);
            s.DrawString(HUDfont, "PODER " + P1.mana, new Vector2(P1.BarraMana.X + 5, P1.BarraMana.Y + (HeightTela / 100 * 5) + HeightTela / 200), Color.Black);
            s.Draw(P1.imgENERGIA, P1.BarraEnergia, Color.White);
            s.DrawString(HUDfont, "ENERGIA " + P1.energia, new Vector2(P1.BarraEnergia.X + 8, P1.BarraEnergia.Y + (HeightTela / 100 * 8)), Color.Black);
            s.Draw(P1.imgSOBRE, P1.Barra, Color.White);

            s.Draw(P1.imgXP, P1.XPrec, Color.White);
            s.DrawString(HUDfont, "XP " + P1.XP, new Vector2(P1.XPrec.X + HeightTela / 100, P1.XPrec.Y + HeightTela / 100), Color.Black);//dentro da barra de xp
            
            s.Draw(P1.imgXPT, P1.XPTrec, Color.White);
            s.Draw(P1.imgpino, P1.Pino, Color.White);

            LEVEL.l.DrawLVL(s);
            if (P1.LVL < 10)
            {
                s.DrawString(JANELA.J.Firefont, "LVL " + P1.LVL, new Vector2(LEVEL.l.R.X + LEVEL.l.R.Width / 3, LEVEL.l.R.Y + LEVEL.l.R.Height / 4), Color.White); // LVL
            }
            else if (P1.LVL < 20 && P1.LVL >= 10)
            {
                s.DrawString(JANELA.J.Firefont, "LVL " + P1.LVL, new Vector2(LEVEL.l.R.X + LEVEL.l.R.Width / 3, LEVEL.l.R.Y + LEVEL.l.R.Height / 4), Color.Gray); // LVL
            }
            else if (P1.LVL < 30 && P1.LVL >= 20)
            {
                s.DrawString(JANELA.J.Firefont, "LVL " + P1.LVL, new Vector2(LEVEL.l.R.X + LEVEL.l.R.Width / 3, LEVEL.l.R.Y + LEVEL.l.R.Height / 4), Color.Yellow); // LVL
            }
            else if (P1.LVL < 40 && P1.LVL >= 30)
            {
                s.DrawString(JANELA.J.Firefont, "LVL " + P1.LVL, new Vector2(LEVEL.l.R.X + LEVEL.l.R.Width / 3, LEVEL.l.R.Y + LEVEL.l.R.Height / 4), Color.Blue); // LVL
            }
            else if (P1.LVL >= 40)
            {
                if (P1.LVL < 100)
                {
                    s.DrawString(JANELA.J.Firefont, "LVL " + P1.LVL, new Vector2(LEVEL.l.R.X + LEVEL.l.R.Width / 3, LEVEL.l.R.Y + LEVEL.l.R.Height / 4), Color.Green); // LVL
                }
                if (P1.LVL > 100)
                {
                    s.DrawString(JANELA.J.Firefont, "LVL " + P1.LVL, new Vector2(LEVEL.l.R.X + LEVEL.l.R.Width / 4, LEVEL.l.R.Y + LEVEL.l.R.Height / 4), Color.Green); // LVL
                }
            }
            //quest
            s.DrawString(HUDfont, "MISSAO COMPLETADA " + ((int)(((float)(JANELA.J.Qqtddcompletada) / JANELA.J.Qqtdd) * 100)) + "%", new Vector2(LEVEL.l.R.X + LEVEL.l.R.Width / 4, LEVEL.l.R.Y + LEVEL.l.R.Height / 2), Color.White); // LVL

            //pontos
            s.DrawString(HUDfont, "Leite:" + P1.leiterepositório + ", Honra: " + P1.honrarepositório + ", Tempo:" + JANELA.J.Qminuto + ":" + JANELA.J.Qtempo, new Vector2(LEVEL.l.R.X + LEVEL.l.R.Width / 5, LEVEL.l.R.Y + LEVEL.l.R.Height / 2 + LEVEL.l.R.Height / 10), Color.White); // LVL
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

            spriteBatch.Draw(Menu.m.imgintromenu_comtraçado, new Rectangle(0, 0, WidthTela, HeightTela), Color.White);
            //fundo escuro
            if (APPLY.Contains(mousePosition) && Bapply)
            {
                spriteBatch.Draw(JANELA.J.imgFUNDOmenu, new Rectangle(0, 0, WidthTela, HeightTela), Color.White);
            }

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

            spriteBatch.DrawString(menu, "1920x1080p", new Vector2(B1[0].X - 20, B1[0].Y - 15), Color.Black);

            spriteBatch.DrawString(menu, "1440x900p", new Vector2(B1[1].X, B1[1].Y - 15), Color.Black);

            spriteBatch.DrawString(menu, "1360x768p", new Vector2(B1[2].X, B1[2].Y - 15), Color.Black);

            spriteBatch.DrawString(menu, "1280x960p", new Vector2(B1[3].X, B1[3].Y - 15), Color.Black);

            spriteBatch.DrawString(menu, "800x600p", new Vector2(B1[4].X, B1[4].Y - 15), Color.Black);

            if (!BFULL)
            {
                spriteBatch.Draw(imgB1, Bfull, Color.White);
            }
            else if (BFULL)
            {
                spriteBatch.Draw(imgB2, Bfull, Color.White);
            }

            spriteBatch.DrawString(JANELA.J.Neon, "FULL SCREEN", new Vector2(Bfull.X, Bfull.Y - 25), Color.Yellow);

            spriteBatch.DrawString(JANELA.J.Neon15, "Escolha sua resolução de tela", new Vector2(APPLY.X, 15), Color.Black);
        }//fim draw menu 00
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------





        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        public void Drawmenu01(SpriteBatch spriteBatch, int WidthTela, int HeightTela, SpriteFont menu)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            spriteBatch.Draw(Contexto.Fundo.menu00fundo, new Rectangle(0, 0, WidthTela, HeightTela), Color.White);

            if (!JANELA.J.JANELACOMBO && !JANELA.J.JANELACOMERCIO)
            {
                if (!Menu.m.CampanhaB.Contains(mousePosition))
                    spriteBatch.Draw(Menu.m.imgcampanha1, Menu.m.CampanhaB, Color.White);
                else if (Menu.m.CampanhaB.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                    spriteBatch.Draw(Menu.m.imgcampanha2, Menu.m.CampanhaB, Color.White);
                else if (Menu.m.CampanhaB.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    spriteBatch.Draw(Menu.m.imgcampanha3, Menu.m.CampanhaB, Color.White);

                if (!Menu.m.CombateB.Contains(mousePosition))
                    spriteBatch.Draw(Menu.m.imgcombates1, Menu.m.CombateB, Color.White);
                else if (Menu.m.CombateB.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                    spriteBatch.Draw(Menu.m.imgcombates2, Menu.m.CombateB, Color.White);
                else if (Menu.m.CombateB.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    spriteBatch.Draw(Menu.m.imgcombates3, Menu.m.CombateB, Color.White);

                if (!Menu.m.SairB.Contains(mousePosition))
                    spriteBatch.Draw(Menu.m.imgsair1, Menu.m.SairB, Color.White);
                else if (Menu.m.SairB.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                    spriteBatch.Draw(Menu.m.imgsair2, Menu.m.SairB, Color.White);
                else if (Menu.m.SairB.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    spriteBatch.Draw(Menu.m.imgsair3, Menu.m.SairB, Color.White);

                if (!Menu.m.CarregarB.Contains(mousePosition))
                    spriteBatch.Draw(Menu.m.imgcarregar1, Menu.m.CarregarB, Color.White);
                else if (Menu.m.CarregarB.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                    spriteBatch.Draw(Menu.m.imgcarregar2, Menu.m.CarregarB, Color.White);
                else if (Menu.m.CarregarB.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    spriteBatch.Draw(Menu.m.imgcarregar3, Menu.m.CarregarB, Color.White);

                if (!Menu.m.SalvarB.Contains(mousePosition))
                    spriteBatch.Draw(Menu.m.imgsalvar1, Menu.m.SalvarB, Color.White);
                else if (Menu.m.SalvarB.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                    spriteBatch.Draw(Menu.m.imgsalvar2, Menu.m.SalvarB, Color.White);
                else if (Menu.m.SalvarB.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    spriteBatch.Draw(Menu.m.imgsalvar3, Menu.m.SalvarB, Color.White);

                if (!Menu.m.OpçoesB.Contains(mousePosition))
                    spriteBatch.Draw(Menu.m.imgopçoes1, Menu.m.OpçoesB, Color.White);
                else if (Menu.m.OpçoesB.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                    spriteBatch.Draw(Menu.m.imgopçoes2, Menu.m.OpçoesB, Color.White);
                else if (Menu.m.OpçoesB.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    spriteBatch.Draw(Menu.m.imgopçoes3, Menu.m.OpçoesB, Color.White);
            }
            

            spriteBatch.DrawString(menu, "Versão 0.5 " + Savegame.S.Ex + " " + Savegame.S.Ex2, new Vector2(0, HeightTela - 15), Color.Cyan);
        } //fim draw menu 01
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------




        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        public void DrawJANELACC(Botoes Botao, SpriteBatch spriteBatch, Personagem P1)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            spriteBatch.Draw(JANELA.J.imgFUNDOmenu, JANELA.J.FUNDO, Color.White);

            if (JANELA.J.JANELACOMBO)
            {
                spriteBatch.Draw(JANELA.J.imgjanelacombo, JANELA.J.R, Color.White);
                
            }
            if (JANELA.J.JANELACOMERCIO)
            {
                spriteBatch.Draw(JANELA.J.imgjanelacomercio, JANELA.J.R, Color.White);
               
            }
            
            //all
            if (!JANELA.J.ARMAS && !JANELA.J.PET && !JANELA.J.PODERES)
                spriteBatch.Draw(JANELA.J.imgjanelaall, JANELA.J.janelaall, Color.DarkGray);
            spriteBatch.DrawString(JANELA.J.Neon15, "[Selecione algum tipo]", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height - 20), Color.Green);
            if (JANELA.J.ARMAS || JANELA.J.PET || JANELA.J.PODERES)
                spriteBatch.Draw(JANELA.J.imgjanelaall, JANELA.J.janelaall, Color.White);

            spriteBatch.Draw(JANELA.J.imgjanelaall, JANELA.J.janelaitens, Color.White);

            //itens
            //mao
            if (JANELA.J.listadeitens[0].item.Y > JANELA.J.Bcombos.Y && JANELA.J.listadeitens[0].item.Y + JANELA.J.listadeitens[0].item.Height < JANELA.J.R.Y + JANELA.J.R.Height)
            {
                if (!JANELA.J.MAOselect)
                {
                    if (!JANELA.J.listadeitens[0].item.Contains(mousePosition))
                    {
                        spriteBatch.Draw(JANELA.J.imgmao1, JANELA.J.listadeitens[0].item, Color.White);
                    }
                    if (JANELA.J.listadeitens[0].item.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                    {
                        spriteBatch.Draw(JANELA.J.imgmao1, JANELA.J.listadeitens[0].item, Color.DarkSeaGreen);
                    }
                    if (JANELA.J.listadeitens[0].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        spriteBatch.Draw(JANELA.J.imgmao1, JANELA.J.listadeitens[0].item, Color.DarkGreen);
                    }
                }
                else if (JANELA.J.MAOselect)
                {
                    spriteBatch.Draw(JANELA.J.imgmao2, JANELA.J.listadeitens[0].item, Color.White);
                }
            }

            //espada2h
            if (JANELA.J.listadeitens[1].item.Y > JANELA.J.Bcombos.Y && JANELA.J.listadeitens[1].item.Y + JANELA.J.listadeitens[9].item.Height < JANELA.J.R.Y + JANELA.J.R.Height)//caso esteja dentro da janela
            {
                if (JANELA.J.ESPADA2HATIVA)
                {
                    if (!JANELA.J.ESPADA2Hselect)
                    {
                        if (!JANELA.J.listadeitens[1].item.Contains(mousePosition))
                        {
                            spriteBatch.Draw(JANELA.J.imgespada2H1, JANELA.J.listadeitens[1].item, Color.White);
                        }
                        if (JANELA.J.listadeitens[1].item.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                        {
                            spriteBatch.Draw(JANELA.J.imgespada2H1, JANELA.J.listadeitens[1].item, Color.DarkSeaGreen);
                        }
                        if (JANELA.J.listadeitens[1].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                        {
                            spriteBatch.Draw(JANELA.J.imgespada2H1, JANELA.J.listadeitens[1].item, Color.DarkGreen);
                        }
                    }
                    else if (JANELA.J.ESPADA2Hselect)
                    {
                        spriteBatch.Draw(JANELA.J.imgespada2H2, JANELA.J.listadeitens[1].item, Color.White);
                    }
                }
                else if (!JANELA.J.ESPADA2HATIVA)
                {
                    spriteBatch.Draw(JANELA.J.imgespada2H3, JANELA.J.listadeitens[1].item, Color.White);
                }
            }

            //daga
            if (JANELA.J.listadeitens[2].item.Y > JANELA.J.Bcombos.Y && JANELA.J.listadeitens[2].item.Y + JANELA.J.listadeitens[2].item.Height < JANELA.J.R.Y + JANELA.J.R.Height)
            {
                if (JANELA.J.ADAGATIVA)
                {
                    if (!JANELA.J.ADAGAselect)
                    {
                        if (!JANELA.J.listadeitens[2].item.Contains(mousePosition))
                        {
                            spriteBatch.Draw(JANELA.J.imgadaga1, JANELA.J.listadeitens[2].item, Color.White);
                        }
                        if (JANELA.J.listadeitens[2].item.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                        {
                            spriteBatch.Draw(JANELA.J.imgadaga1, JANELA.J.listadeitens[2].item, Color.DarkSeaGreen);
                        }
                        if (JANELA.J.listadeitens[2].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                        {
                            spriteBatch.Draw(JANELA.J.imgadaga1, JANELA.J.listadeitens[2].item, Color.DarkGreen);
                        }
                    }
                    else if (JANELA.J.ADAGAselect)
                    {
                        spriteBatch.Draw(JANELA.J.imgadaga2, JANELA.J.listadeitens[2].item, Color.White);
                    }
                }
                else if (!JANELA.J.ADAGATIVA)
                {
                    spriteBatch.Draw(JANELA.J.imgadaga3, JANELA.J.listadeitens[2].item, Color.White);
                }
            }



            //arco
            if (JANELA.J.listadeitens[3].item.Y > JANELA.J.Bcombos.Y && JANELA.J.listadeitens[3].item.Y + JANELA.J.listadeitens[3].item.Height < JANELA.J.R.Y + JANELA.J.R.Height)//caso esteja dentro da janela
            {
                if (JANELA.J.ARCOATIVO)
                {
                    if (!JANELA.J.ARCOselect)
                    {
                        if (!JANELA.J.listadeitens[3].item.Contains(mousePosition))
                        {
                            spriteBatch.Draw(JANELA.J.imgItemarco1, JANELA.J.listadeitens[3].item, Color.White);
                        }
                        if (JANELA.J.listadeitens[3].item.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                        {
                            spriteBatch.Draw(JANELA.J.imgItemarco1, JANELA.J.listadeitens[3].item, Color.DarkSeaGreen);
                        }
                        if (JANELA.J.listadeitens[3].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                        {
                            spriteBatch.Draw(JANELA.J.imgItemarco1, JANELA.J.listadeitens[3].item, Color.DarkGreen);
                        }
                    }
                    else if (JANELA.J.ARCOselect)
                    {
                        spriteBatch.Draw(JANELA.J.imgItemarco2, JANELA.J.listadeitens[3].item, Color.White);
                    }
                }
                else if (!JANELA.J.ARCOATIVO)
                {
                    spriteBatch.Draw(JANELA.J.imgItemarco3, JANELA.J.listadeitens[3].item, Color.White);
                }
            }

            ///---------------------------

            //tridente
            if (JANELA.J.listadeitens[4].item.Y > JANELA.J.Bcombos.Y && JANELA.J.listadeitens[4].item.Y + JANELA.J.listadeitens[4].item.Height < JANELA.J.R.Y + JANELA.J.R.Height)//caso esteja dentro da janela
            {
                if (JANELA.J.TRIDENTEATIVO)
                {
                    if (!JANELA.J.TRIDENTEselect)
                    {
                        if (!JANELA.J.listadeitens[4].item.Contains(mousePosition))
                        {
                            spriteBatch.Draw(JANELA.J.imgItemtridente1, JANELA.J.listadeitens[4].item, Color.White);
                        }
                        if (JANELA.J.listadeitens[4].item.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                        {
                            spriteBatch.Draw(JANELA.J.imgItemtridente1, JANELA.J.listadeitens[4].item, Color.DarkSeaGreen);
                        }
                        if (JANELA.J.listadeitens[4].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                        {
                            spriteBatch.Draw(JANELA.J.imgItemtridente1, JANELA.J.listadeitens[4].item, Color.DarkGreen);
                        }
                    }
                    else if (JANELA.J.TRIDENTEselect)
                    {
                        spriteBatch.Draw(JANELA.J.imgItemtridente2, JANELA.J.listadeitens[4].item, Color.White);
                    }
                }
                else if (!JANELA.J.TRIDENTEATIVO)
                {
                    spriteBatch.Draw(JANELA.J.imgItemtridente3, JANELA.J.listadeitens[4].item, Color.White);
                }
            }

            //slow motion
            if (JANELA.J.listadeitens[5].item.Y > JANELA.J.Bcombos.Y && JANELA.J.listadeitens[5].item.Y + JANELA.J.listadeitens[5].item.Height < JANELA.J.R.Y + JANELA.J.R.Height)//caso esteja dentro da janela
            {

                if (!JANELA.J.SLOWselect)
                {
                    if (!JANELA.J.listadeitens[5].item.Contains(mousePosition))
                    {
                        spriteBatch.Draw(JANELA.J.imgItemslow1, JANELA.J.listadeitens[5].item, Color.White);
                    }
                    if (JANELA.J.listadeitens[5].item.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                    {
                        spriteBatch.Draw(JANELA.J.imgItemslow1, JANELA.J.listadeitens[5].item, Color.DarkSeaGreen);
                    }
                    if (JANELA.J.listadeitens[5].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        spriteBatch.Draw(JANELA.J.imgItemslow1, JANELA.J.listadeitens[5].item, Color.DarkGreen);
                    }
                }
                else if (JANELA.J.SLOWselect)
                {
                    spriteBatch.Draw(JANELA.J.imgItemslow2, JANELA.J.listadeitens[5].item, Color.White);
                }


            }
            //retroceder
            if (JANELA.J.listadeitens[6].item.Y > JANELA.J.Bcombos.Y && JANELA.J.listadeitens[6].item.Y + JANELA.J.listadeitens[6].item.Height < JANELA.J.R.Y + JANELA.J.R.Height)//caso esteja dentro da janela
            {
                if (JANELA.J.RETROCEDERATIVO)
                {
                    if (!JANELA.J.RETROCEDERselect)
                    {
                        if (!JANELA.J.listadeitens[6].item.Contains(mousePosition))
                        {
                            spriteBatch.Draw(JANELA.J.imgItemretroceder1, JANELA.J.listadeitens[6].item, Color.White);
                        }
                        if (JANELA.J.listadeitens[6].item.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                        {
                            spriteBatch.Draw(JANELA.J.imgItemretroceder1, JANELA.J.listadeitens[6].item, Color.DarkSeaGreen);
                        }
                        if (JANELA.J.listadeitens[6].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                        {
                            spriteBatch.Draw(JANELA.J.imgItemretroceder1, JANELA.J.listadeitens[6].item, Color.DarkGreen);
                        }
                    }
                    else if (JANELA.J.RETROCEDERselect)
                    {
                        spriteBatch.Draw(JANELA.J.imgItemretroceder2, JANELA.J.listadeitens[6].item, Color.White);
                    }
                }
                else if (!JANELA.J.RETROCEDERATIVO)
                {
                    spriteBatch.Draw(JANELA.J.imgItemretroceder3, JANELA.J.listadeitens[6].item, Color.White);
                }
            }
            //escudo de chakra
            if (JANELA.J.listadeitens[7].item.Y > JANELA.J.Bcombos.Y && JANELA.J.listadeitens[7].item.Y + JANELA.J.listadeitens[7].item.Height < JANELA.J.R.Y + JANELA.J.R.Height)//caso esteja dentro da janela
            {
                if (JANELA.J.ESCUDOATIVO)
                {
                    if (!JANELA.J.ESCUDOselect)
                    {
                        if (!JANELA.J.listadeitens[7].item.Contains(mousePosition))
                        {
                            spriteBatch.Draw(JANELA.J.imgItemescudo1, JANELA.J.listadeitens[7].item, Color.White);
                        }
                        if (JANELA.J.listadeitens[7].item.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                        {
                            spriteBatch.Draw(JANELA.J.imgItemescudo1, JANELA.J.listadeitens[7].item, Color.DarkSeaGreen);
                        }
                        if (JANELA.J.listadeitens[7].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                        {
                            spriteBatch.Draw(JANELA.J.imgItemescudo1, JANELA.J.listadeitens[7].item, Color.DarkGreen);
                        }
                    }
                    else if (JANELA.J.ESCUDOselect)
                    {
                        spriteBatch.Draw(JANELA.J.imgItemescudo2, JANELA.J.listadeitens[7].item, Color.White);
                    }
                }
                else if (!JANELA.J.ESCUDOATIVO)
                {
                    spriteBatch.Draw(JANELA.J.imgItemescudo3, JANELA.J.listadeitens[7].item, Color.White);
                }
            }
            //vento
            if (JANELA.J.listadeitens[8].item.Y > JANELA.J.Bcombos.Y && JANELA.J.listadeitens[8].item.Y + JANELA.J.listadeitens[8].item.Height < JANELA.J.R.Y + JANELA.J.R.Height)//caso esteja dentro da janela
            {
                if (JANELA.J.VENTOATIVO)
                {
                    if (!JANELA.J.VENTOselect)
                    {
                        if (!JANELA.J.listadeitens[8].item.Contains(mousePosition))
                        {
                            spriteBatch.Draw(JANELA.J.imgItemvento1, JANELA.J.listadeitens[8].item, Color.White);
                        }
                        if (JANELA.J.listadeitens[8].item.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                        {
                            spriteBatch.Draw(JANELA.J.imgItemvento1, JANELA.J.listadeitens[8].item, Color.DarkSeaGreen);
                        }
                        if (JANELA.J.listadeitens[8].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                        {
                            spriteBatch.Draw(JANELA.J.imgItemvento1, JANELA.J.listadeitens[8].item, Color.DarkGreen);
                        }
                    }
                    else if (JANELA.J.VENTOselect)
                    {
                        spriteBatch.Draw(JANELA.J.imgItemvento2, JANELA.J.listadeitens[8].item, Color.White);
                    }
                }
                else if (!JANELA.J.VENTOATIVO)
                {
                    spriteBatch.Draw(JANELA.J.imgItemvento3, JANELA.J.listadeitens[8].item, Color.White);
                }
            }
            //rajada de raios
            if (JANELA.J.listadeitens[9].item.Y > JANELA.J.Bcombos.Y && JANELA.J.listadeitens[9].item.Y + JANELA.J.listadeitens[9].item.Height < JANELA.J.R.Y + JANELA.J.R.Height + 1)//caso esteja dentro da janela
            {
                if (JANELA.J.RAIOATIVO)
                {
                    if (!JANELA.J.RAIOselect)
                    {
                        if (!JANELA.J.listadeitens[9].item.Contains(mousePosition))
                        {
                            spriteBatch.Draw(JANELA.J.imgItemraio1, JANELA.J.listadeitens[9].item, Color.White);
                        }
                        if (JANELA.J.listadeitens[9].item.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                        {
                            spriteBatch.Draw(JANELA.J.imgItemraio1, JANELA.J.listadeitens[9].item, Color.DarkSeaGreen);
                        }
                        if (JANELA.J.listadeitens[9].item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                        {
                            spriteBatch.Draw(JANELA.J.imgItemraio1, JANELA.J.listadeitens[9].item, Color.DarkGreen);
                        }
                    }
                    else if (JANELA.J.RAIOselect)
                    {
                        spriteBatch.Draw(JANELA.J.imgItemraio2, JANELA.J.listadeitens[9].item, Color.White);
                    }
                }
                else if (!JANELA.J.RAIOATIVO)
                {
                    spriteBatch.Draw(JANELA.J.imgItemraio3, JANELA.J.listadeitens[9].item, Color.White);
                }
            }

            ItensAll.a.DRAW(spriteBatch);


            //FIM ITENS



            if (JANELA.J.JANELACOMBO)
            {
                spriteBatch.Draw(JANELA.J.imgbotaoCombosON, JANELA.J.Bcombos, Color.White);
                spriteBatch.Draw(JANELA.J.imgbotaoComercioOFF, JANELA.J.Bcomercio, Color.White);
            }
            



            if (JANELA.J.JANELACOMERCIO)
            {
                spriteBatch.Draw(JANELA.J.imgbotaoCombosOFF, JANELA.J.Bcombos, Color.White);
                spriteBatch.Draw(JANELA.J.imgbotaoComercioON, JANELA.J.Bcomercio, Color.White);
            }

            //parte de cima
            spriteBatch.Draw(JANELA.J.imgjanelacinzaopç1, JANELA.J.CAPAopç1, Color.White); //AQUI MOSTRA AS INFORMAÇÕES
            spriteBatch.DrawString(JANELA.J.Neon15, "COMBOS " + P1.qntdcombos, new Vector2(JANELA.J.CAPAopç1.X + JANELA.J.CAPAopç1.Width / 16, JANELA.J.CAPAopç1.Y + JANELA.J.CAPAopç1.Height / 8), Color.DarkGoldenrod); //mostrar MOEDAS
            spriteBatch.DrawString(JANELA.J.Neon15, "LEITE " + P1.leite, new Vector2(JANELA.J.CAPAopç1.X + JANELA.J.CAPAopç1.Width / 2, JANELA.J.CAPAopç1.Y + JANELA.J.CAPAopç1.Height / 8), Color.DarkSalmon);
            spriteBatch.DrawString(JANELA.J.Neon15, "HONRA " + P1.honra, new Vector2(JANELA.J.CAPAopç1.X + JANELA.J.CAPAopç1.Width - JANELA.J.CAPAopç1.Width / 4, JANELA.J.CAPAopç1.Y + JANELA.J.CAPAopç1.Height / 8), Color.DarkViolet);

            //informações para as janelas
            spriteBatch.DrawString(JANELA.J.Neon, "Equipagem", new Vector2(JANELA.J.CAPAopç1.X + JANELA.J.CAPAopç1.Width / 16, JANELA.J.CAPAopç1.Y + JANELA.J.CAPAopç1.Height / 2), Color.DarkGray);
            spriteBatch.DrawString(JANELA.J.Neon, "Informações e Compras", new Vector2(JANELA.J.CAPAopç1.X + JANELA.J.CAPAopç1.Width / 2, JANELA.J.CAPAopç1.Y + JANELA.J.CAPAopç1.Height / 2), Color.DarkGray);


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

            
            //seta cima##############
            if (!JANELA.J.setacima.Contains(mousePosition))
            {
                spriteBatch.Draw(JANELA.J.imgsetacima, JANELA.J.setacima, Color.White);
            }
            if (JANELA.J.setacima.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
            {
                spriteBatch.Draw(JANELA.J.imgsetacima, JANELA.J.setacima, Color.DarkGray);
            }
            if (JANELA.J.setacima.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                spriteBatch.Draw(JANELA.J.imgsetacima, JANELA.J.setacima, Color.Black);
            }
            //seta 2
            if (!JANELA.J.setacima2.Contains(mousePosition))
            {
                spriteBatch.Draw(JANELA.J.imgsetacima, JANELA.J.setacima2, Color.White);
            }
            if (JANELA.J.setacima2.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
            {
                spriteBatch.Draw(JANELA.J.imgsetacima, JANELA.J.setacima2, Color.DarkGray);
            }
            if (JANELA.J.setacima2.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                spriteBatch.Draw(JANELA.J.imgsetacima, JANELA.J.setacima2, Color.Black);
            }
            //seta baixo#######################
            if (!JANELA.J.setabaixo.Contains(mousePosition))
            {
                spriteBatch.Draw(JANELA.J.imgsetabaixo, JANELA.J.setabaixo, Color.White);
            }
            if (JANELA.J.setabaixo.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
            {
                spriteBatch.Draw(JANELA.J.imgsetabaixo, JANELA.J.setabaixo, Color.DarkGray);
            }
            if (JANELA.J.setabaixo.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                spriteBatch.Draw(JANELA.J.imgsetabaixo, JANELA.J.setabaixo, Color.Black);
            }
            //seta baixo 2
            if (!JANELA.J.setabaixo2.Contains(mousePosition))
            {
                spriteBatch.Draw(JANELA.J.imgsetabaixo, JANELA.J.setabaixo2, Color.White);
            }
            if (JANELA.J.setabaixo2.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
            {
                spriteBatch.Draw(JANELA.J.imgsetabaixo, JANELA.J.setabaixo2, Color.DarkGray);
            }
            if (JANELA.J.setabaixo2.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                spriteBatch.Draw(JANELA.J.imgsetabaixo, JANELA.J.setabaixo2, Color.Black);
            }

            // rolometro
            spriteBatch.Draw(JANELA.J.imgjanelarolo, JANELA.J.janelarolo, Color.White);
            spriteBatch.Draw(JANELA.J.imgjanelarolo, JANELA.J.janelarolo2, Color.White);
            spriteBatch.Draw(JANELA.J.imgrolo, JANELA.J.rolo, Color.White);
            spriteBatch.Draw(JANELA.J.imgrolo, JANELA.J.rolo2, Color.White);

            
            
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
        public void DrawJANELAopçfase(Botoes Botao, SpriteBatch spriteBatch, bool BOTAO, Personagem P1)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);

            
            //fundo escuro
            spriteBatch.Draw(JANELA.J.imgFUNDOmenu, JANELA.J.FUNDO, Color.White);
            //capa fundo
            spriteBatch.Draw(JANELA.J.imgCapaMapas, JANELA.J.CapaMapas, Color.White);

            for (int i = 0; i < JANELA.J.Rfase.Length; i++)
            {

                
                if (!JANELA.J.Rfase[i].Contains(mousePosition))
                {
                    spriteBatch.Draw(JANELA.J.imgfaseB[i], JANELA.J.Rfase[i], Color.White);
                }
                if (JANELA.J.Rfase[i].Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed && !JANELA.J.FASEdestravada[i])
                {
                    spriteBatch.Draw(JANELA.J.imgfaseB[i], JANELA.J.Rfase[i], Color.Red);
                }
                if (JANELA.J.Rfase[i].Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed && JANELA.J.FASEdestravada[i])
                {
                    spriteBatch.Draw(JANELA.J.imgfaseB[i], JANELA.J.Rfase[i], Color.Green);
                }
                if (JANELA.J.Rfase[i].Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed && JANELA.J.FASEdestravada[i])
                {
                    spriteBatch.Draw(JANELA.J.imgfaseB[i], JANELA.J.Rfase[i], Color.DarkCyan);
                }
                if (JANELA.J.Rfase[i].Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed && !JANELA.J.FASEdestravada[i])
                {
                    spriteBatch.Draw(JANELA.J.imgfaseB[i], JANELA.J.Rfase[i], Color.DarkRed);
                }


                //ponto
                if (JANELA.J.Rfase.Length - 1 > i)
                {
                    if (JANELA.J.FASEdestravada[i + 1])
                    {
                        spriteBatch.Draw(JANELA.J.imgPbranco, JANELA.J.linhas[i], Color.Green);
                    }
                    if (!JANELA.J.FASEdestravada[i + 1])
                    {
                        spriteBatch.Draw(JANELA.J.imgPbranco, JANELA.J.linhas[i], Color.Red);
                    }
                }
            }//fim mult

            //botao voltar (menu)
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
                if (Menu.m.MENU)
                    spriteBatch.Draw(Botao.imghomeOFF, Botao.HOMEquadrado, Color.White);
                else if (Menu.m.COMBATES || Menu.m.CAMPANHA)
                {
                    spriteBatch.Draw(Botao.imghomeOFFTP, Botao.HOMEquadrado, Color.White);
                }
            }
            //setas
            if (!JANELA.J.Setamenu1.Contains(mousePosition))
            {
                spriteBatch.Draw(JANELA.J.imgsetamenu1, JANELA.J.Setamenu1, Color.White);
            }
            else if (JANELA.J.Setamenu1.Contains(mousePosition))
            {
                spriteBatch.Draw(JANELA.J.imgsetamenu2, JANELA.J.Setamenu1, Color.White);
            }
            if (!JANELA.J.Setamenu3.Contains(mousePosition))
            {
                spriteBatch.Draw(JANELA.J.imgsetamenu3, JANELA.J.Setamenu3, Color.White);
            }
            else if (JANELA.J.Setamenu3.Contains(mousePosition))
            {
                spriteBatch.Draw(JANELA.J.imgsetamenu4, JANELA.J.Setamenu3, Color.White);
            }
            //botao compra
            if (JANELA.J.CLICKMENUCOMPRA)
            {
                spriteBatch.Draw(JANELA.J.imgclickmenucompra, JANELA.J.Clickmenucompra, Color.White);
                if (Mouse.GetState().LeftButton != ButtonState.Pressed)
                    spriteBatch.Draw(JANELA.J.imgcompramenu1, JANELA.J.compramenu, Color.White);
                if (JANELA.J.compramenu.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    spriteBatch.Draw(JANELA.J.imgcompramenu2, JANELA.J.compramenu, Color.White);
            }

            //ESCRITO NA ABA INFO PRA COMPRAR (FASES)
            if (JANELA.J.INFOeCOMPRAfase[1])
            {
                spriteBatch.DrawString(JANELA.J.Neon15, "Arena", new Vector2(JANELA.J.Clickmenucompra.X + JANELA.J.Clickmenucompra.Width / 8, JANELA.J.Clickmenucompra.Y + JANELA.J.Clickmenucompra.Height / 9), Color.Black);
                spriteBatch.DrawString(JANELA.J.Neon15, "O mapa custa: 5 Missões completadas.", new Vector2(JANELA.J.Clickmenucompra.X + JANELA.J.Clickmenucompra.Width / 8, JANELA.J.Clickmenucompra.Y + JANELA.J.Clickmenucompra.Height / 2), Color.Black);
                spriteBatch.DrawString(JANELA.J.Neon15, "Você fez: " + JANELA.J.Qcompletadas, new Vector2(JANELA.J.Clickmenucompra.X + JANELA.J.Clickmenucompra.Width / 8, JANELA.J.Clickmenucompra.Y + JANELA.J.Clickmenucompra.Height / 2 + 20), Color.Black);
            }
            if (JANELA.J.INFOeCOMPRAfase[2])
            {
                spriteBatch.DrawString(JANELA.J.Neon15, "Floresta Japonesa Encantada", new Vector2(JANELA.J.Clickmenucompra.X + JANELA.J.Clickmenucompra.Width / 8, JANELA.J.Clickmenucompra.Y + JANELA.J.Clickmenucompra.Height / 9), Color.Black);
                spriteBatch.DrawString(JANELA.J.Neon15, "O mapa custa: 50 LEITE e 5 HONRA.", new Vector2(JANELA.J.Clickmenucompra.X + JANELA.J.Clickmenucompra.Width / 8, JANELA.J.Clickmenucompra.Y + JANELA.J.Clickmenucompra.Height / 2), Color.Black);
                spriteBatch.DrawString(JANELA.J.Neon15, "Você tem: L: " + P1.leite + " H: " + P1.honra, new Vector2(JANELA.J.Clickmenucompra.X + JANELA.J.Clickmenucompra.Width / 8, JANELA.J.Clickmenucompra.Y + JANELA.J.Clickmenucompra.Height / 2 + 20), Color.Black);
            }
            if (JANELA.J.INFOeCOMPRAfase[3])
            {
                spriteBatch.DrawString(JANELA.J.Neon15, "Celeiro", new Vector2(JANELA.J.Clickmenucompra.X + JANELA.J.Clickmenucompra.Width / 8, JANELA.J.Clickmenucompra.Y + JANELA.J.Clickmenucompra.Height / 9), Color.Black);
                spriteBatch.DrawString(JANELA.J.Neon15, "O mapa custa: 50 Missões completadas.", new Vector2(JANELA.J.Clickmenucompra.X + JANELA.J.Clickmenucompra.Width / 8, JANELA.J.Clickmenucompra.Y + JANELA.J.Clickmenucompra.Height / 2), Color.Black);
                spriteBatch.DrawString(JANELA.J.Neon15, "Você fez: " + JANELA.J.Qcompletadas, new Vector2(JANELA.J.Clickmenucompra.X + JANELA.J.Clickmenucompra.Width / 8, JANELA.J.Clickmenucompra.Y + JANELA.J.Clickmenucompra.Height / 2 + 20), Color.Black);
            }
            if (JANELA.J.INFOeCOMPRAfase[4])
            {
                spriteBatch.DrawString(JANELA.J.Neon15, "Rua japonesa", new Vector2(JANELA.J.Clickmenucompra.X + JANELA.J.Clickmenucompra.Width / 8, JANELA.J.Clickmenucompra.Y + JANELA.J.Clickmenucompra.Height / 9), Color.Black);
                spriteBatch.DrawString(JANELA.J.Neon15, "O mapa custa: 75 Missões completadas e 20 HONRA.", new Vector2(JANELA.J.Clickmenucompra.X + JANELA.J.Clickmenucompra.Width / 8, JANELA.J.Clickmenucompra.Y + JANELA.J.Clickmenucompra.Height / 2), Color.Black);
                spriteBatch.DrawString(JANELA.J.Neon15, "Você fez: " + JANELA.J.Qcompletadas + " Missões e tem " + P1.honra + " de HONRA", new Vector2(JANELA.J.Clickmenucompra.X + JANELA.J.Clickmenucompra.Width / 8, JANELA.J.Clickmenucompra.Y + JANELA.J.Clickmenucompra.Height / 2 + 20), Color.Black);
            }
            if (JANELA.J.INFOeCOMPRAfase[5])
            {
                spriteBatch.DrawString(JANELA.J.Neon15, "Metrô japonês", new Vector2(JANELA.J.Clickmenucompra.X + JANELA.J.Clickmenucompra.Width / 8, JANELA.J.Clickmenucompra.Y + JANELA.J.Clickmenucompra.Height / 9), Color.Black);
                spriteBatch.DrawString(JANELA.J.Neon15, "O mapa custa: 100 Missões completadas e 50 HONRA.", new Vector2(JANELA.J.Clickmenucompra.X + JANELA.J.Clickmenucompra.Width / 8, JANELA.J.Clickmenucompra.Y + JANELA.J.Clickmenucompra.Height / 2), Color.Black);
                spriteBatch.DrawString(JANELA.J.Neon15, "Você fez: " + JANELA.J.Qcompletadas + " Missões e tem " + P1.honra + " de HONRA", new Vector2(JANELA.J.Clickmenucompra.X + JANELA.J.Clickmenucompra.Width / 8, JANELA.J.Clickmenucompra.Y + JANELA.J.Clickmenucompra.Height / 2 + 20), Color.Black);
            }

        }//fim void



        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        public void DrawBotaoEstatico(Botoes Botao, SpriteBatch spriteBatch)
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
                    if (Menu.m.MENU)
                        spriteBatch.Draw(Botao.imghomeOFF, Botao.HOMEquadrado, Color.White);
                    else if (Menu.m.COMBATES || Menu.m.CAMPANHA)
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
                    if (Menu.m.MENU)
                        spriteBatch.Draw(Botao.imgcomercioOFF, Botao.COMERCIOquadrado, Color.White);
                    else if (Menu.m.COMBATES || Menu.m.CAMPANHA)
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
                    if (Menu.m.MENU)
                        spriteBatch.Draw(Botao.imgcombosOFF, Botao.COMBOSquadrado, Color.White);
                    else if (Menu.m.COMBATES || Menu.m.CAMPANHA) //diferença entre game e menu
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
                    if (P1.listadedano[i].opç == 4)//heal
                    {
                        spriteBatch.DrawString(JANELA.J.Neon, "" + P1.listadedano[i].qntd, new Vector2(P1.listadedano[i].P.X, P1.listadedano[i].P.Y), Color.Violet);
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
        public void DrawQUEST(SpriteBatch spriteBatch, int W, int H)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            spriteBatch.Draw(JANELA.J.imgFUNDOmenu, JANELA.J.FUNDO, Color.White);

            //quest
            spriteBatch.Draw(JANELA.J.imgQuest, JANELA.J.Quest,
                               new Rectangle(JANELA.J.frameQuest.X * JANELA.J.tamanhoQuest.X, JANELA.J.frameQuest.Y * JANELA.J.tamanhoQuest.Y,
                                                          JANELA.J.tamanhoQuest.X, JANELA.J.tamanhoQuest.Y), Color.White);

            //botoes
            if (JANELA.J.QUESTdisponivel && !JANELA.J.RODAR1 && !JANELA.J.RODAR2)
            {

                //refresh
                if (!JANELA.J.Brefresh.Contains(mousePosition))
                {
                    spriteBatch.Draw(JANELA.J.imgRefresh1, JANELA.J.Brefresh, Color.Gray);
                }
                if (JANELA.J.Brefresh.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                {
                    spriteBatch.Draw(JANELA.J.imgRefresh1, JANELA.J.Brefresh, Color.White);
                }
                if (JANELA.J.Brefresh.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    spriteBatch.Draw(JANELA.J.imgRefresh2, JANELA.J.Brefresh, Color.White);
                }

                //OK
                if (!JANELA.J.Bok.Contains(mousePosition))
                {
                    spriteBatch.Draw(JANELA.J.imgOK1, JANELA.J.Bok, Color.White);
                }
                if (JANELA.J.Bok.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                {
                    spriteBatch.Draw(JANELA.J.imgOK2, JANELA.J.Bok, Color.White);
                }
                if (JANELA.J.Bok.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    spriteBatch.Draw(JANELA.J.imgOK3, JANELA.J.Bok, Color.White);
                }


                //posição da escrita da quest
                if (JANELA.J.frameQuest.X == 0 && JANELA.J.frameQuest.Y == 0)
                {
                    if (JANELA.J.Qopç == 1)
                    {
                        spriteBatch.DrawString(JANELA.J.Woodfont, "MISSAO Massacre ", new Vector2(JANELA.J.Brefresh.X, JANELA.J.Brefresh.Y + JANELA.J.Brefresh.Height + H / 100), Color.Black);
                        spriteBatch.DrawString(JANELA.J.Woodfont, "MATE " + JANELA.J.Qqtdd + " inimigos", new Vector2(JANELA.J.Brefresh.X, JANELA.J.Brefresh.Y + JANELA.J.Brefresh.Height + H / 100 + 25), Color.Red);
                    }
                    if (JANELA.J.Qopç == 2)
                    {
                        spriteBatch.DrawString(JANELA.J.Woodfont, "MISSAO Sobrevivencia ", new Vector2(JANELA.J.Brefresh.X, JANELA.J.Brefresh.Y + JANELA.J.Brefresh.Height + H / 100), Color.Black);
                        spriteBatch.DrawString(JANELA.J.Woodfont, "SOBREVIVA " + JANELA.J.Qqtdd + " segundos", new Vector2(JANELA.J.Brefresh.X, JANELA.J.Brefresh.Y + JANELA.J.Brefresh.Height + H / 100 + 25), Color.Red);
                    }
                    if (JANELA.J.Qopç == 3)
                    {
                        spriteBatch.DrawString(JANELA.J.Woodfont, "MISSAO Defesa do LEITE ", new Vector2(JANELA.J.Brefresh.X, JANELA.J.Brefresh.Y + JANELA.J.Brefresh.Height + H / 100), Color.Black);
                        spriteBatch.DrawString(JANELA.J.Woodfont, "DEFENDA o leite por " + JANELA.J.Qqtdd + " segundos", new Vector2(JANELA.J.Brefresh.X, JANELA.J.Brefresh.Y + JANELA.J.Brefresh.Height + H / 100 + 25), Color.Red);
                    }
                }
                if (JANELA.J.frameQuest.X == 2 && JANELA.J.frameQuest.Y == 5)
                {
                    if (JANELA.J.Qopç == 1)
                    {
                        spriteBatch.DrawString(JANELA.J.Woodfont, "MISSAO Massacre", new Vector2(JANELA.J.Brefresh.X - JANELA.J.Quest.Width / 4, JANELA.J.Brefresh.Y + JANELA.J.Brefresh.Height + H / 100), Color.Black);
                        spriteBatch.DrawString(JANELA.J.Woodfont, "MATE " + JANELA.J.Qqtdd + " inimigos", new Vector2(JANELA.J.Brefresh.X - JANELA.J.Quest.Width / 4, JANELA.J.Brefresh.Y + JANELA.J.Brefresh.Height + H / 100 + 25), Color.Red);
                    }
                    if (JANELA.J.Qopç == 2)
                    {
                        spriteBatch.DrawString(JANELA.J.Woodfont, "MISSAO Sobrevivencia", new Vector2(JANELA.J.Brefresh.X - JANELA.J.Quest.Width / 4, JANELA.J.Brefresh.Y + JANELA.J.Brefresh.Height + H / 100), Color.Black);
                        spriteBatch.DrawString(JANELA.J.Woodfont, "SOBREVIVA " + JANELA.J.Qqtdd + " segundos", new Vector2(JANELA.J.Brefresh.X - JANELA.J.Quest.Width / 4, JANELA.J.Brefresh.Y + JANELA.J.Brefresh.Height + H / 100 + 25), Color.Red);
                    }

                    if (JANELA.J.Qopç == 3)
                    {
                        spriteBatch.DrawString(JANELA.J.Woodfont, "MISSAO Defesa do LEITE ", new Vector2(JANELA.J.Brefresh.X - JANELA.J.Quest.Width / 4, JANELA.J.Brefresh.Y + JANELA.J.Brefresh.Height + H / 100), Color.Black);
                        spriteBatch.DrawString(JANELA.J.Woodfont, "DEFENDA o leite por " + JANELA.J.Qqtdd + " segundos", new Vector2(JANELA.J.Brefresh.X - JANELA.J.Quest.Width / 4, JANELA.J.Brefresh.Y + JANELA.J.Brefresh.Height + H / 100 + 25), Color.Red);
                    }
                }

            }//fim quest disponivel
        }//DrawQUEST

        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        public void DrawPLACAR(SpriteBatch spriteBatch, int W, int H, Personagem P1)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            spriteBatch.Draw(JANELA.J.imgFUNDOmenu, JANELA.J.FUNDO, Color.White);

            spriteBatch.Draw(JANELA.J.imgPlacar, JANELA.J.Placar, Color.White);

            if (JANELA.J.PLACARdisponivel)
            {
                spriteBatch.DrawString(JANELA.J.Neon, "LEITE ganho: " + P1.leiterepositório, new Vector2(JANELA.J.Placar.X + JANELA.J.Placar.Width / 12, JANELA.J.Placar.Y + JANELA.J.Placar.Height / 4), Color.DarkGreen);
                spriteBatch.DrawString(JANELA.J.Neon, "HONRA ganho: " + P1.honrarepositório, new Vector2(JANELA.J.Placar.X + JANELA.J.Placar.Width / 12, JANELA.J.Placar.Y + JANELA.J.Placar.Height / 4 + (30 * 1)), Color.DarkGreen);
                spriteBatch.DrawString(JANELA.J.Neon, "COMBOS ganho: " + P1.qntdcombosrepositório, new Vector2(JANELA.J.Placar.X + JANELA.J.Placar.Width / 12, JANELA.J.Placar.Y + JANELA.J.Placar.Height / 4 + (30 * 2)), Color.DarkGreen);
                spriteBatch.DrawString(JANELA.J.Neon, "XP ganho: " + (50 + (10 * JANELA.J.Qcompletadas)), new Vector2(JANELA.J.Placar.X + JANELA.J.Placar.Width / 12, JANELA.J.Placar.Y + JANELA.J.Placar.Height / 4 + (30 * 3)), Color.DarkGreen);

                spriteBatch.DrawString(JANELA.J.Neon, "LEITE: " + P1.leite, new Vector2(JANELA.J.Placar.X + JANELA.J.Placar.Width / 2, JANELA.J.Placar.Y + JANELA.J.Placar.Height / 4), Color.DarkBlue);
                spriteBatch.DrawString(JANELA.J.Neon, "HONRA: " + P1.honra, new Vector2(JANELA.J.Placar.X + JANELA.J.Placar.Width / 2, JANELA.J.Placar.Y + JANELA.J.Placar.Height / 4 + (30 * 1)), Color.DarkBlue);
                spriteBatch.DrawString(JANELA.J.Neon, "COMBOS: " + P1.qntdcombos, new Vector2(JANELA.J.Placar.X + JANELA.J.Placar.Width / 2, JANELA.J.Placar.Y + JANELA.J.Placar.Height / 4 + (30 * 2)), Color.DarkBlue);
                spriteBatch.DrawString(JANELA.J.Neon, "XP ATUAL: " + P1.XP, new Vector2(JANELA.J.Placar.X + JANELA.J.Placar.Width / 2, JANELA.J.Placar.Y + JANELA.J.Placar.Height / 4 + (30 * 3)), Color.DarkBlue);
                spriteBatch.DrawString(JANELA.J.Neon, "LVL ATUAL: " + P1.LVL, new Vector2(JANELA.J.Placar.X + JANELA.J.Placar.Width / 2, JANELA.J.Placar.Y + JANELA.J.Placar.Height / 4 + (30 * 4)), Color.DarkBlue);
                spriteBatch.DrawString(JANELA.J.Neon, "MISSÕES feitas: " + JANELA.J.Qcompletadas, new Vector2(JANELA.J.Placar.X + JANELA.J.Placar.Width / 2, JANELA.J.Placar.Y + JANELA.J.Placar.Height / 4 + (30 * 5)), Color.DarkBlue);
                
                if (JANELA.J.TRANSFERIDO)
                {
                    //refresh
                    if (!JANELA.J.Brefresh2.Contains(mousePosition))
                    {
                        spriteBatch.Draw(JANELA.J.imgRefresh1, JANELA.J.Brefresh2, Color.Gray);
                    }
                    if (JANELA.J.Brefresh2.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                    {
                        spriteBatch.Draw(JANELA.J.imgRefresh1, JANELA.J.Brefresh2, Color.White);
                    }
                    if (JANELA.J.Brefresh2.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        spriteBatch.Draw(JANELA.J.imgRefresh2, JANELA.J.Brefresh2, Color.White);
                    }

                    //OK
                    if (!JANELA.J.Bok2.Contains(mousePosition))
                    {
                        spriteBatch.Draw(JANELA.J.imgOK1, JANELA.J.Bok2, Color.White);
                    }
                    if (JANELA.J.Bok2.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                    {
                        spriteBatch.Draw(JANELA.J.imgOK2, JANELA.J.Bok2, Color.White);
                    }
                    if (JANELA.J.Bok2.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        spriteBatch.Draw(JANELA.J.imgOK3, JANELA.J.Bok2, Color.White);
                    }
                }//transferido
            }//placar disponivel
        }

        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        public void DrawCOMBOS(SpriteBatch spriteBatch, int W, int H, Personagem P1)
        {
            spriteBatch.Draw(COMBO.c.img, COMBO.c.R, Color.White);

            if (COMBO.c.MOSTRARHIT)
            {
                if (COMBO.c.PONTUAÇÃO)
                {
                    if (P1.qntdcombosrepositório < 10)
                    {
                        spriteBatch.DrawString(JANELA.J.Firefont, "HIT! " + COMBO.c.HITS + ",COMBOS: " + P1.qntdcombosrepositório, new Vector2(COMBO.c.R.X, COMBO.c.R.Y + COMBO.c.R.Height / 4), Color.Black);
                    }
                    if (P1.qntdcombosrepositório >= 10 && P1.qntdcombosrepositório < 100)
                    {
                        spriteBatch.DrawString(JANELA.J.Firefont, "HIT! " + COMBO.c.HITS + ",COMBOS: " + P1.qntdcombosrepositório, new Vector2(COMBO.c.R.X - (26 * 1), COMBO.c.R.Y + COMBO.c.R.Height / 4), Color.Black);
                    }
                    if (P1.qntdcombosrepositório >= 100 && P1.qntdcombosrepositório < 1000)
                    {
                        spriteBatch.DrawString(JANELA.J.Firefont, "HIT! " + COMBO.c.HITS + ",COMBOS: " + P1.qntdcombosrepositório, new Vector2(COMBO.c.R.X - (26 * 2), COMBO.c.R.Y + COMBO.c.R.Height / 4), Color.Black);
                    }
                    if (P1.qntdcombosrepositório >= 1000)
                    {
                        spriteBatch.DrawString(JANELA.J.Firefont, "HIT! " + COMBO.c.HITS + ",COMBOS: " + P1.qntdcombosrepositório, new Vector2(COMBO.c.R.X - (26 * 3), COMBO.c.R.Y + COMBO.c.R.Height / 4), Color.Black);
                    }
                }
                else
                {
                    //mostrar os hits sendo feitos
                    if (COMBO.c.HITS < 10)
                    {
                        spriteBatch.DrawString(JANELA.J.Firefont, "HIT! " + COMBO.c.HITS, new Vector2(COMBO.c.R.X + COMBO.c.R.Width / 2 - (26 * 1), COMBO.c.R.Y + COMBO.c.R.Height / 4), Color.White);
                    }
                    if (COMBO.c.HITS >= 10 && COMBO.c.HITS < 100)
                    {
                        spriteBatch.DrawString(JANELA.J.Firefont, "HIT! " + COMBO.c.HITS, new Vector2(COMBO.c.R.X + COMBO.c.R.Width / 2 - (26 * 2), COMBO.c.R.Y + COMBO.c.R.Height / 4), Color.White);
                    }
                    if (COMBO.c.HITS >= 100 && COMBO.c.HITS < 1000)
                    {
                        spriteBatch.DrawString(JANELA.J.Firefont, "HIT! " + COMBO.c.HITS, new Vector2(COMBO.c.R.X + COMBO.c.R.Width / 2 - (26 * 3), COMBO.c.R.Y + COMBO.c.R.Height / 4), Color.White);
                    }
                    if (COMBO.c.HITS >= 1000)
                    {
                        spriteBatch.DrawString(JANELA.J.Firefont, "HIT! " + COMBO.c.HITS, new Vector2(COMBO.c.R.X + COMBO.c.R.Width / 2 - (26 * 4), COMBO.c.R.Y + COMBO.c.R.Height / 4), Color.White);
                    }
                }
                
            }
        }
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        public void DrawINFO(SpriteBatch spriteBatch, int W, int H)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);

            //DENTRO DA JANELA COMERCIO / COMBO
            if (Info.I.AMOSTRAjanelacc && (JANELA.J.JANELACOMERCIO || JANELA.J.JANELACOMBO))
            {
                spriteBatch.Draw(Info.I.img, Info.I.R, Color.White);
                for (int i = 0; i < JANELA.J.QTDITENS; i++) // todos os itens da lista
                {
                    if (!JANELA.J.Bcomercio.Contains(mousePosition) && !JANELA.J.Bcombos.Contains(mousePosition) && !JANELA.J.Barmas.Contains(mousePosition) && !JANELA.J.Bpet.Contains(mousePosition) && !JANELA.J.CAPAopç1.Contains(mousePosition) && mouseState.Y < JANELA.J.R.Y + JANELA.J.R.Height)//so mostra qnd encosta nos que estao à vista.
                    {
                        if (JANELA.J.listadeitens[i].item.Contains(mousePosition) && !JANELA.J.ATIVOS[i])
                        {
                            spriteBatch.DrawString(JANELA.J.Neon15, Info.I.itemV, new Vector2(Info.I.R.X + Info.I.distanciadeletra, Info.I.R.Y + Info.I.R.Height / 4), Color.Gray);
                        }
                        if (JANELA.J.listadeitens[i].item.Contains(mousePosition) && JANELA.J.ATIVOS[i] && !JANELA.J.SELECIONADOS[i])
                        {
                            spriteBatch.DrawString(JANELA.J.Neon15, Info.I.itemD, new Vector2(Info.I.R.X + Info.I.distanciadeletra, Info.I.R.Y + Info.I.R.Height / 4), Color.Gray);
                        }
                        if (JANELA.J.listadeitens[i].item.Contains(mousePosition) && JANELA.J.ATIVOS[i] && JANELA.J.SELECIONADOS[i])
                        {
                            spriteBatch.DrawString(JANELA.J.Neon15, Info.I.itemS, new Vector2(Info.I.R.X + Info.I.distanciadeletra, Info.I.R.Y + Info.I.R.Height / 4), Color.Gray);
                        }
                    }
                }
                if (JANELA.J.xis.Contains(mousePosition))
                {
                    spriteBatch.DrawString(JANELA.J.Neon15, Info.I.Sair, new Vector2(Info.I.R.X + Info.I.distanciadeletra, Info.I.R.Y + Info.I.R.Height / 4), Color.Gray);
                }
                if (JANELA.J.Bcomercio.Contains(mousePosition))
                {
                    spriteBatch.DrawString(JANELA.J.Neon15, Info.I.comercio, new Vector2(Info.I.R.X + Info.I.distanciadeletra, Info.I.R.Y + Info.I.R.Height / 4), Color.Gray);
                }
                if (JANELA.J.Bcombos.Contains(mousePosition))
                {
                    spriteBatch.DrawString(JANELA.J.Neon15, Info.I.combo, new Vector2(Info.I.R.X + Info.I.distanciadeletra, Info.I.R.Y + Info.I.R.Height / 4), Color.Gray);
                }
                //abas
                if (JANELA.J.Barmas.Contains(mousePosition) || JANELA.J.Bpet.Contains(mousePosition) || JANELA.J.Bpoderes.Contains(mousePosition))
                {
                    if (JANELA.J.JANELACOMERCIO)
                        spriteBatch.DrawString(JANELA.J.Neon15, Info.I.SeleçaoAbaComercio, new Vector2(Info.I.R.X + Info.I.distanciadeletra, Info.I.R.Y + Info.I.R.Height / 4), Color.Gray);

                    if (JANELA.J.JANELACOMBO)
                        spriteBatch.DrawString(JANELA.J.Neon15, Info.I.SeleçaoAbaCombo, new Vector2(Info.I.R.X + Info.I.distanciadeletra, Info.I.R.Y + Info.I.R.Height / 4), Color.Gray);
                }
            }
        }
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        public void DrawAudio(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Audio.A1.imgbarra, Audio.A1.barra, Color.White);
            spriteBatch.Draw(Audio.A1.imgpino, Audio.A1.pino, Color.White);
            
            if (Audio.MasterVolume <= 0.0f)
                spriteBatch.Draw(Audio.A1.imgVol1, Audio.A1.Vol, Color.White);
            if (Audio.MasterVolume > 0.0f)
                spriteBatch.Draw(Audio.A1.imgVol2, Audio.A1.Vol, Color.White);
        }
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------

        public void DrawCLONES(SpriteBatch spriteBatch, Personagem P1)
        {
            for (int i = 0; i < P1.listaclonePoder.Count; i++)
            {
                if (P1.listaclonePoder[i].DIREITA)
                {
                    if (!P1.listaclonePoder[i].COMBATE) // fora de combate
                    {
                        if (P1.listaclonePoder[i].PARADO) // parado fora de luta
                        {
                            spriteBatch.Draw(P1.imgparado1maosD, P1.listaclonePoder[i].individuo,
                                          new Rectangle(P1.listaclonePoder[i].frameparado1.X * P1.listaclonePoder[i].tamanhoMaosparado1.X, P1.listaclonePoder[i].frameparado1.Y * P1.listaclonePoder[i].tamanhoMaosparado1.Y,
                                                        P1.listaclonePoder[i].tamanhoMaosparado1.X, P1.listaclonePoder[i].tamanhoMaosparado1.Y),
                                                        Color.White);
                        }
                    }
                    else if (P1.listaclonePoder[i].COMBATE)
                    {
                        if (P1.listaclonePoder[i].PARADO)
                        {
                            spriteBatch.Draw(P1.imgparado2maosD, P1.listaclonePoder[i].individuo,
                                          new Rectangle(P1.listaclonePoder[i].frameparado2.X * P1.listaclonePoder[i].tamanhoMaosparado2.X, P1.listaclonePoder[i].frameparado2.Y * P1.listaclonePoder[i].tamanhoMaosparado2.Y,
                                                        P1.listaclonePoder[i].tamanhoMaosparado2.X, P1.listaclonePoder[i].tamanhoMaosparado2.Y),
                                                        Color.White);
                        }
                    }

                    if (P1.listaclonePoder[i].COMBATE) // em combate
                    {
                        if (P1.listaclonePoder[i].PARADO) // parado na luta
                        {
                            spriteBatch.Draw(P1.imgparado2maosD, P1.listaclonePoder[i].individuo,
                                          new Rectangle(P1.listaclonePoder[i].frameparado2.X * P1.listaclonePoder[i].tamanhoMaosparado2.X, P1.listaclonePoder[i].frameparado2.Y * P1.listaclonePoder[i].tamanhoMaosparado2.Y,
                                                        P1.listaclonePoder[i].tamanhoMaosparado2.X, P1.listaclonePoder[i].tamanhoMaosparado2.Y),
                                                        Color.White);
                        }
                    }

                    if (P1.listaclonePoder[i].ANDANDO) // se movimentando pra direita
                    {
                        spriteBatch.Draw(P1.imgandandomaosD, P1.listaclonePoder[i].individuo,
                                          new Rectangle(P1.listaclonePoder[i].framemovendo.X * P1.listaclonePoder[i].tamanhoMaosandando.X, P1.listaclonePoder[i].framemovendo.Y * P1.listaclonePoder[i].tamanhoMaosandando.Y,
                                                        P1.listaclonePoder[i].tamanhoMaosandando.X, P1.listaclonePoder[i].tamanhoMaosandando.Y),
                                                        Color.White);
                    }

                    if (P1.listaclonePoder[i].CORRENDO)
                    {
                        spriteBatch.Draw(P1.imgcorrendomaosD, P1.listaclonePoder[i].individuo,
                                          new Rectangle(P1.listaclonePoder[i].framemovendo.X * P1.listaclonePoder[i].tamanhoMaoscorrendo.X, P1.listaclonePoder[i].framemovendo.Y * P1.listaclonePoder[i].tamanhoMaoscorrendo.Y,
                                                        P1.listaclonePoder[i].tamanhoMaoscorrendo.X, P1.listaclonePoder[i].tamanhoMaoscorrendo.Y),
                                                        Color.White);
                    }

                    if (P1.listaclonePoder[i].PULANDOandando || P1.listaclonePoder[i].PULANDOcorrendo || P1.listaclonePoder[i].PULANDOparado)
                    {
                        spriteBatch.Draw(P1.imgpularmaos, P1.listaclonePoder[i].individuo,
                                         new Rectangle(P1.listaclonePoder[i].framepular.X * P1.listaclonePoder[i].tamanhoMaospular.X, P1.listaclonePoder[i].framepular.Y * P1.listaclonePoder[i].tamanhoMaospular.Y,
                                                       P1.listaclonePoder[i].tamanhoMaospular.X, P1.listaclonePoder[i].tamanhoMaospular.Y),
                                                       Color.White);
                    }
                    if (P1.listaclonePoder[i].PARTE1)
                    {
                        spriteBatch.Draw(P1.imgsoco1maos, P1.listaclonePoder[i].individuo,
                                    new Rectangle(P1.listaclonePoder[i].frameLUTA.X * P1.listaclonePoder[i].tamanhosoco1Maos.X, P1.listaclonePoder[i].frameLUTA.Y * P1.listaclonePoder[i].tamanhosoco1Maos.Y,
                                                  P1.listaclonePoder[i].tamanhosoco1Maos.X, P1.listaclonePoder[i].tamanhosoco1Maos.Y),
                                                  Color.White);
                    }
                    if (P1.listaclonePoder[i].COMBO1)
                    {
                        if (P1.listaclonePoder[i].PARTE2)
                        {
                            spriteBatch.Draw(P1.imgsoco2C1maos, P1.listaclonePoder[i].individuo,
                                    new Rectangle(P1.listaclonePoder[i].frameLUTA.X * P1.listaclonePoder[i].tamanhosoco2C1Maos.X, P1.listaclonePoder[i].frameLUTA.Y * P1.listaclonePoder[i].tamanhosoco2C1Maos.Y,
                                                  P1.listaclonePoder[i].tamanhosoco2C1Maos.X, P1.listaclonePoder[i].tamanhosoco2C1Maos.Y),
                                                  Color.White);
                        }
                        if (P1.listaclonePoder[i].PARTE3)
                        {
                            spriteBatch.Draw(P1.imgsoco3C1maos, P1.listaclonePoder[i].individuo,
                                    new Rectangle(P1.listaclonePoder[i].frameLUTA.X * P1.listaclonePoder[i].tamanhosoco3C1Maos.X, P1.listaclonePoder[i].frameLUTA.Y * P1.listaclonePoder[i].tamanhosoco3C1Maos.Y,
                                                  P1.listaclonePoder[i].tamanhosoco3C1Maos.X, P1.listaclonePoder[i].tamanhosoco3C1Maos.Y),
                                                  Color.White);
                        }
                        if (P1.listaclonePoder[i].PARTE4)
                        {
                            spriteBatch.Draw(P1.imgjoelhada4C1Maos, P1.listaclonePoder[i].individuo,
                                    new Rectangle(P1.listaclonePoder[i].frameLUTA.X * P1.listaclonePoder[i].tamanhojoelhada4C1Maos.X, P1.listaclonePoder[i].frameLUTA.Y * P1.listaclonePoder[i].tamanhojoelhada4C1Maos.Y,
                                                  P1.listaclonePoder[i].tamanhojoelhada4C1Maos.X, P1.listaclonePoder[i].tamanhojoelhada4C1Maos.Y),
                                                  Color.White);
                        }
                    }//fim combo1
                }


                //--------------------------------------------------------------------------------------------------
                //--------------------------------------------------------------------------------------------------
                //--------------------------------------------------------------------------------------------------
                if (P1.listaclonePoder[i].ESQUERDA)
                {
                    if (!P1.listaclonePoder[i].COMBATE) // fora de combate
                    {
                        if (P1.listaclonePoder[i].PARADO) // parado fora de luta
                        {
                            spriteBatch.Draw(P1.imgparado1maosE, P1.listaclonePoder[i].individuo,
                                          new Rectangle(P1.listaclonePoder[i].frameparado1.X * P1.listaclonePoder[i].tamanhoMaosparado1.X, P1.listaclonePoder[i].frameparado1.Y * P1.listaclonePoder[i].tamanhoMaosparado1.Y,
                                                        P1.listaclonePoder[i].tamanhoMaosparado1.X, P1.listaclonePoder[i].tamanhoMaosparado1.Y),
                                                        Color.White);
                        }
                    }
                    else if (P1.listaclonePoder[i].COMBATE)
                    {
                        if (P1.listaclonePoder[i].PARADO)
                        {
                            spriteBatch.Draw(P1.imgparado2maosE, P1.listaclonePoder[i].individuo,
                                          new Rectangle(P1.listaclonePoder[i].frameparado2.X * P1.listaclonePoder[i].tamanhoMaosparado2.X, P1.listaclonePoder[i].frameparado2.Y * P1.listaclonePoder[i].tamanhoMaosparado2.Y,
                                                        P1.listaclonePoder[i].tamanhoMaosparado2.X, P1.listaclonePoder[i].tamanhoMaosparado2.Y),
                                                        Color.White);
                        }
                    }
                    if (P1.listaclonePoder[i].ANDANDO) // se movimentando pra esquerda
                    {
                        spriteBatch.Draw(P1.imgandandomaosE, P1.listaclonePoder[i].individuo,
                                          new Rectangle(P1.listaclonePoder[i].framemovendo.X * P1.listaclonePoder[i].tamanhoMaosandando.X, P1.listaclonePoder[i].framemovendo.Y * P1.listaclonePoder[i].tamanhoMaosandando.Y,
                                                        P1.listaclonePoder[i].tamanhoMaosandando.X, P1.listaclonePoder[i].tamanhoMaosandando.Y),
                                                        Color.White);
                    }

                    if (P1.listaclonePoder[i].CORRENDO)
                    {
                        spriteBatch.Draw(P1.imgcorrendomaosE, P1.listaclonePoder[i].individuo,
                                          new Rectangle(P1.listaclonePoder[i].framemovendo.X * P1.listaclonePoder[i].tamanhoMaoscorrendo.X, P1.listaclonePoder[i].framemovendo.Y * P1.listaclonePoder[i].tamanhoMaoscorrendo.Y,
                                                        P1.listaclonePoder[i].tamanhoMaoscorrendo.X, P1.listaclonePoder[i].tamanhoMaoscorrendo.Y),
                                                        Color.White);
                    }

                    if (P1.listaclonePoder[i].PULANDOandando || P1.listaclonePoder[i].PULANDOcorrendo || P1.listaclonePoder[i].PULANDOparado)
                    {
                        spriteBatch.Draw(P1.imgpularmaosE, P1.listaclonePoder[i].individuo,
                                         new Rectangle(P1.listaclonePoder[i].framepular.X * P1.listaclonePoder[i].tamanhoMaospular.X, P1.listaclonePoder[i].framepular.Y * P1.listaclonePoder[i].tamanhoMaospular.Y,
                                                       P1.listaclonePoder[i].tamanhoMaospular.X, P1.listaclonePoder[i].tamanhoMaospular.Y),
                                                       Color.White);
                    }

                    if (P1.listaclonePoder[i].PARTE1)
                    {
                        spriteBatch.Draw(P1.imgsoco1maosE, P1.listaclonePoder[i].individuo,
                                    new Rectangle(P1.listaclonePoder[i].frameLUTA.X * P1.listaclonePoder[i].tamanhosoco1Maos.X, P1.listaclonePoder[i].frameLUTA.Y * P1.listaclonePoder[i].tamanhosoco1Maos.Y,
                                                  P1.listaclonePoder[i].tamanhosoco1Maos.X, P1.listaclonePoder[i].tamanhosoco1Maos.Y),
                                                  Color.White);
                    }
                    if (P1.listaclonePoder[i].COMBO1)
                    {
                        if (P1.listaclonePoder[i].PARTE2)
                        {
                            spriteBatch.Draw(P1.imgsoco2C1maosE, P1.listaclonePoder[i].individuo,
                                    new Rectangle(P1.listaclonePoder[i].frameLUTA.X * P1.listaclonePoder[i].tamanhosoco2C1Maos.X, P1.listaclonePoder[i].frameLUTA.Y * P1.listaclonePoder[i].tamanhosoco2C1Maos.Y,
                                                  P1.listaclonePoder[i].tamanhosoco2C1Maos.X, P1.listaclonePoder[i].tamanhosoco2C1Maos.Y),
                                                  Color.White);
                        }
                        if (P1.listaclonePoder[i].PARTE3)
                        {
                            spriteBatch.Draw(P1.imgsoco3C1maosE, P1.listaclonePoder[i].individuo,
                                    new Rectangle(P1.listaclonePoder[i].frameLUTA.X * P1.listaclonePoder[i].tamanhosoco3C1Maos.X, P1.listaclonePoder[i].frameLUTA.Y * P1.listaclonePoder[i].tamanhosoco3C1Maos.Y,
                                                  P1.listaclonePoder[i].tamanhosoco3C1Maos.X, P1.listaclonePoder[i].tamanhosoco3C1Maos.Y),
                                                  Color.White);
                        }
                        if (P1.listaclonePoder[i].PARTE4)
                        {
                            spriteBatch.Draw(P1.imgjoelhada4C1maosE, P1.listaclonePoder[i].individuo,
                                    new Rectangle(P1.listaclonePoder[i].frameLUTA.X * P1.listaclonePoder[i].tamanhojoelhada4C1Maos.X, P1.listaclonePoder[i].frameLUTA.Y * P1.listaclonePoder[i].tamanhojoelhada4C1Maos.Y,
                                                  P1.listaclonePoder[i].tamanhojoelhada4C1Maos.X, P1.listaclonePoder[i].tamanhojoelhada4C1Maos.Y),
                                                  Color.White);
                        }
                    }//fim combo1
                
                }
            }
        }//fim clone

        
    }
}
