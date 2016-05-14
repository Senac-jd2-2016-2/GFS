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
    class ItensAll
    {
        public static ItensAll a = new ItensAll();

        //retangles
        public Rectangle Item = new Rectangle(), Xis = new Rectangle();
        public bool ATIVO, ABASELECIONADA;
        public int PosY, QuantidadePorAba = 9, QuantidadePorLinha = 3; // definir antes de começar
        public Texture2D imgespada2H, imgmaos, imgadaga, imgtridente, imgslow, imgretroceder, imgarco, imgescudo, prop1, prop2, prop3, prop4;
        public bool B, Bx; //botao pra cada item 


        public void Criar()
        {
            for (int i = 0; i < QuantidadePorAba; i++)
            {
                //add quantos quadrados vao ter
                ItensAll A = new ItensAll();
                A.Item = new Rectangle();
                A.ATIVO = false;
                A.B = false;
                A.Bx = false;
                JANELA.J.listaitensall.Add(A);
            }
        }

        public void POS(int W, int H)
        {
            //tamanho
            for (int i = 0; i < JANELA.J.listaitensall.Count; i++)
            {
                JANELA.J.listaitensall[i].Item.Width = H / 3 - H / 52; // 360 - 20 = 340;
                JANELA.J.listaitensall[i].Item.Height = H / 4 + H / 31; //270 + 34 = 304

                //BOTAO X = pra sair da aba
                JANELA.J.listaitensall[i].Xis.X = JANELA.J.janelaall.X + JANELA.J.janelaall.Width - JANELA.J.R.Height / 18 - JANELA.J.R.Height / 240; //fim da tela
                JANELA.J.listaitensall[i].Xis.Y = JANELA.J.janelaall.Y;
                JANELA.J.listaitensall[i].Xis.Width = JANELA.J.R.Height / 18 + JANELA.J.R.Height / 240; // = 45 + 3 = 48
                JANELA.J.listaitensall[i].Xis.Height = JANELA.J.R.Height / 27; // = 30
            }

            //Faço ele chegar no final, pular uma fila, e assim até o infinito (qnts numeros eu quiser)
            for (int y = 0; y < QuantidadePorLinha; y++)
            {
                for (int x = 0; x < QuantidadePorLinha; x++)
                {
                    //formula pra pular dinamicamente qnts numeros eu quiser.
                    JANELA.J.listaitensall[x + (y * QuantidadePorLinha)].Item.X = JANELA.J.janelaall.X + (x * (JANELA.J.listaitensall[x].Item.Width + H / 100));//o que soma é a distancia entre um e outro
                    JANELA.J.listaitensall[x + (y * QuantidadePorLinha)].Item.Y = JANELA.J.janelaall.Y + (y * (JANELA.J.listaitensall[x].Item.Height + H / 100));
                }
            }


            
        }

        public void FUNÇÕES(bool BOTAO)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            if (Mouse.GetState().LeftButton != ButtonState.Pressed) // BOTAO não pressionado
            {
                BOTAO = false;
            }
            //cada janela tem seus itens
            for (int i = 0; i < JANELA.J.listaitensall.Count; i++)
            {
                //imagem
                if (JANELA.J.ARMAS)
                {
                    if (i < 5) // menor do que a quantidade de itens de cada
                    {
                        JANELA.J.listaitensall[i].ATIVO = JANELA.J.ATIVOS[i];
                    }
                }
                else if (JANELA.J.PODERES)
                {
                    if (i < 5) // menor do que a quantidade de itens de cada
                    {
                        JANELA.J.listaitensall[i].ATIVO = JANELA.J.ATIVOS[i + 5];
                    }
                }
                 else if (JANELA.J.PET)
                {
                    if (i < 5) // menor do que a quantidade de itens de cada
                    {
                        JANELA.J.listaitensall[i].ATIVO = JANELA.J.ATIVOS[i + 10];
                    }
                }

                //comercio
                //combo
                //ENTRADA
                if (!JANELA.J.listaitensall[i].ABASELECIONADA)//se nao tiver nenhuma aba selecionada (possibilita a voce clicar nos itens)
                {
                    if (JANELA.J.listaitensall[i].Item.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        BOTAO = true;
                        JANELA.J.listaitensall[i].B = true;
                    }
                    if (!JANELA.J.listaitensall[i].Item.Contains(mousePosition))
                        JANELA.J.listaitensall[i].B = false;
                    if (JANELA.J.listaitensall[i].B && !BOTAO)
                    {
                        JANELA.J.listaitensall[i].B = false;
                        JANELA.J.listaitensall[i].ABASELECIONADA = true;
                    }
                }//fim 

                //SAIDA
                if (JANELA.J.listaitensall[i].ABASELECIONADA)//se nao tiver nenhuma aba selecionada (possibilita a voce clicar nos itens)
                {
                    if (JANELA.J.listaitensall[i].Xis.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        BOTAO = true;
                        JANELA.J.listaitensall[i].Bx = true;
                    }
                    if (!JANELA.J.listaitensall[i].Xis.Contains(mousePosition))
                        JANELA.J.listaitensall[i].Bx = false;
                    if (JANELA.J.listaitensall[i].Bx && !BOTAO)
                    {
                        JANELA.J.listaitensall[i].Bx = false;
                        JANELA.J.listaitensall[i].ABASELECIONADA = false;
                    }
                }
            }//fim multiplicação
        }//fim do void

        public void DRAW(SpriteBatch spriteBatch)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);

            for (int i = 0; i < JANELA.J.listaitensall.Count; i++)
            {
                if (!JANELA.J.listaitensall[i].ABASELECIONADA)//se nao tiver nenhuma aba selecionada (ele mostra os itens)
                {
                    //se estiver dentro da janela
                    if (JANELA.J.listaitensall[i].Item.Y > JANELA.J.Bcombos.Y && JANELA.J.listaitensall[i].Item.Y + JANELA.J.listaitensall[i].Item.Height < JANELA.J.R.Y + JANELA.J.R.Height + 1)
                    {
                        //aparecem apenas quando estejam selecionados
                        if (JANELA.J.ARMAS || JANELA.J.PODERES || JANELA.J.PET)
                        {
                            //se estiver comprado ou nao
                            if (!JANELA.J.listaitensall[i].ATIVO)
                            {
                                if (!JANELA.J.listaitensall[i].Item.Contains(mousePosition))
                                    spriteBatch.Draw(prop1, JANELA.J.listaitensall[i].Item, Color.White);
                                if (JANELA.J.listaitensall[i].Item.Contains(mousePosition))
                                    spriteBatch.Draw(prop2, JANELA.J.listaitensall[i].Item, Color.White);
                            }
                            if (JANELA.J.listaitensall[i].ATIVO)
                            {
                                if (!JANELA.J.listaitensall[i].Item.Contains(mousePosition))
                                    spriteBatch.Draw(prop3, JANELA.J.listaitensall[i].Item, Color.White);
                                if (JANELA.J.listaitensall[i].Item.Contains(mousePosition))
                                    spriteBatch.Draw(prop4, JANELA.J.listaitensall[i].Item, Color.White);
                            }
                        }

                    }
                }
                
            }//dentro do array

            for (int i = 0; i < JANELA.J.listaitensall.Count; i++)
            {
                if (!JANELA.J.listaitensall[i].ABASELECIONADA)//se nao tiver nenhuma aba selecionada (ele mostra os itens)
                {
                    //se estiver dentro da janela
                    if (JANELA.J.listaitensall[i].Item.Y > JANELA.J.Bcombos.Y && JANELA.J.listaitensall[i].Item.Y + JANELA.J.listaitensall[i].Item.Height < JANELA.J.R.Y + JANELA.J.R.Height + 1)
                    {

                        //o iten de cada grupo
                        if (JANELA.J.ARMAS)
                        {
                            if (i == 0)
                                spriteBatch.Draw(imgmaos, JANELA.J.listaitensall[0].Item, Color.White);
                            if (i == 1)
                                spriteBatch.Draw(imgespada2H, JANELA.J.listaitensall[1].Item, Color.White);
                            if (i == 2)
                                spriteBatch.Draw(imgadaga, JANELA.J.listaitensall[2].Item, Color.White);
                            if (i == 3)
                                spriteBatch.Draw(imgarco, JANELA.J.listaitensall[3].Item, Color.White);
                            if (i == 4)
                                spriteBatch.Draw(imgtridente, JANELA.J.listaitensall[4].Item, Color.White);
                        }
                        if (JANELA.J.PODERES)
                        {
                            if (i == 0)
                                spriteBatch.Draw(imgslow, JANELA.J.listaitensall[0].Item, Color.White);
                            if (i == 1)
                                spriteBatch.Draw(imgretroceder, JANELA.J.listaitensall[1].Item, Color.White);
                            if (i == 2)
                                spriteBatch.Draw(imgescudo, JANELA.J.listaitensall[2].Item, Color.White);

                        }
                    }
                }//fim do nao estar aba aberta
                if (JANELA.J.listaitensall[i].ABASELECIONADA)//se nao tiver nenhuma aba selecionada (ele mostra os itens)
                {
                    if (JANELA.J.JANELACOMERCIO)
                    {
                        if (JANELA.J.ARMAS)
                        {
                            if (i == 0)
                                spriteBatch.DrawString(JANELA.J.Neon, "PUNHOS", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 4, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                            if (i == 1)
                                spriteBatch.DrawString(JANELA.J.Neon, "ESPADA 2 MÃOS", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 4, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                            if (i == 2)
                                spriteBatch.DrawString(JANELA.J.Neon, "ADAGA", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 4, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                            if (i == 3)
                                spriteBatch.DrawString(JANELA.J.Neon, "ARCO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 4, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                            if (i == 4)
                                spriteBatch.DrawString(JANELA.J.Neon, "TRIDENTE", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 4, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                        }
                        if (JANELA.J.PODERES)
                        {
                            if (i == 0)
                                spriteBatch.DrawString(JANELA.J.Neon, "SLOW", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 4, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                            if (i == 1)
                                spriteBatch.DrawString(JANELA.J.Neon, "RETROCEDER", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 4, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                            if (i == 2)
                                spriteBatch.DrawString(JANELA.J.Neon, "ESCUDO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 4, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);

                        }
                    }
                    if (JANELA.J.JANELACOMBO)
                    {
                        if (JANELA.J.ARMAS)
                        {
                            if (i == 0)
                                spriteBatch.DrawString(JANELA.J.Neon, "PUNHOS", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 4, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                            if (i == 1)
                                spriteBatch.DrawString(JANELA.J.Neon, "ESPADA 2 MÃOS", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 4, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                            if (i == 2)
                                spriteBatch.DrawString(JANELA.J.Neon, "ADAGA", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 4, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                            if (i == 3)
                                spriteBatch.DrawString(JANELA.J.Neon, "ARCO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 4, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                            if (i == 4)
                                spriteBatch.DrawString(JANELA.J.Neon, "TRIDENTE", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 4, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                        }
                        if (JANELA.J.PODERES)
                        {
                            if (i == 0)
                                spriteBatch.DrawString(JANELA.J.Neon, "SLOW", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 4, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                            if (i == 1)
                                spriteBatch.DrawString(JANELA.J.Neon, "RETROCEDER", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 4, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                            if (i == 2)
                                spriteBatch.DrawString(JANELA.J.Neon, "ESCUDO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 4, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);

                        }
                    }//fim combo aba 

                    if (!JANELA.J.listaitensall[i].Xis.Contains(mousePosition))
                        spriteBatch.Draw(JANELA.J.imgbotaoX, JANELA.J.listaitensall[i].Xis, Color.White);
                    else if (JANELA.J.listaitensall[i].Xis.Contains(mousePosition))
                        spriteBatch.Draw(JANELA.J.imgbotaoXRed, JANELA.J.listaitensall[i].Xis, Color.White);

                }// fim aba selecionada
            }
            
        }
    }
}
