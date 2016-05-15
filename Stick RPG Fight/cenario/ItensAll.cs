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
        public bool B, Bx, ABATRANCADA; //botao pra cada item 


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
            }
                //comercio
                //combo
                //ENTRADA
            for (int i = 0; i < JANELA.J.listaitensall.Count; i++)
            {
                if (!JANELA.J.listaitensall[i].ABASELECIONADA && !ItensAll.a.ABATRANCADA && i < 5)//se nao tiver nenhuma aba selecionada (possibilita a voce clicar nos itens)
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
                        ItensAll.a.ABATRANCADA = true;
                    }
                }//fim 

                //SAIDA
                if (ItensAll.a.ABATRANCADA)//se nao tiver nenhuma aba selecionada (possibilita a voce clicar nos itens)
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
                        for (int a = 0; a < JANELA.J.listaitensall.Count; a++)
                        {
                            JANELA.J.listaitensall[a].ABASELECIONADA = false;
                        }
                        ItensAll.a.ABATRANCADA = false;
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
                if (!ItensAll.a.ABATRANCADA)//se nao tiver nenhuma aba selecionada (ele mostra os itens)
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
                if (!ItensAll.a.ABATRANCADA)//se nao tiver nenhuma aba selecionada (ele mostra os itens)
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
                }//fim do nao estar aba trancada
                if (JANELA.J.listaitensall[i].ABASELECIONADA && ItensAll.a.ABATRANCADA)//se nao tiver nenhuma aba selecionada (ele mostra os itens)
                {
                    if (JANELA.J.JANELACOMERCIO)
                    {
                        if (JANELA.J.ARMAS)
                        {
                            if (i == 0)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "DESARMADO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Agilidade, que permite vários combos diferentes.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);

                            }
                            if (i == 1)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "ESPADA 2 MAOS", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Entre rápido e lento, porém com bastante dano.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                            }
                            if (i == 2)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "ADAGA", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Extremamente rápido e ágil, porém com pouco dano", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);

                            }
                            if (i == 3)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "ARCO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Lento, porém causa bastante dano a distância", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);

                            }
                            if (i == 4)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "TRIDENTE", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Rápido, longo e poderoso, porém pouco ágil", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);

                            }
                        }
                        if (JANELA.J.PODERES)
                        {
                            if (i == 0)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "SLOW", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Faça o tempo andar lento para os inimigos. Perfeito para fuga. A mana se esgoda com o ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "tempo. Custa mínimo de 70 mana.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);

                            }
                            if (i == 1)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "RETROCEDER", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Volte na posição que você soltou o poder, dentro de 3 segundos, com a vida daquele tempo. ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Caso tenha recuperado vida, cuidado. Perfeito pra evitar a morte, ou restaurar grande ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "quantidade de vida perdida. Custa 50% do mana.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.Gray);

                            }
                            if (i == 2)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "ESCUDO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Te protege do dano inimigo ou/e acerta 1 de dano, 60 vezes por segundo. Todo dano acertado ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "desgasta a quantidade do escudo. A quantidade do escudo é definido pela quantidade de mana", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "ao ativá-lo. Após 5 segudos ele desativa, se reativa-lo durante esse período irá somar na ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "quantidade de poder do escudo e recarregar o tempo. Custa minimo de 10 mana.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 120), Color.Gray);


                            }
                            if (i == 3)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "VENTO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Solta uma rajada de vento que irá empurrar os inimigos na direção que ele está indo e tira", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, " 1 de dano 60x por segundo. Perfeito pra quem estiver encurralado. Custa 30% de mana.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);

                            }
                            if (i == 4)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "RAIO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Faz com que caiam raios na direção que estiver, um após o outro. Quando um raio atingir o ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "chão o outro será lançado até esgotar o mana. Perfeito para matar inimgos em área. Custa", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "10% de mana cada raio criado.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.Gray);
                            }
                        }

                        if (JANELA.J.listaitensall[i].ATIVO)
                        {
                            spriteBatch.DrawString(JANELA.J.Neon15, "Disponível", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height - 20), Color.Green);
                        }
                    }
                    else if (JANELA.J.JANELACOMBO)
                    {
                        if (JANELA.J.ARMAS)
                        {
                            if (i == 0)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "DESARMADO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Agilidade, que permite vários combos diferentes.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);

                                spriteBatch.DrawString(JANELA.J.Neon, "MANUAL (teclas):", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "MOVIMENTAR: A(Esquerda), S(Agachar), D(Direita), W(Pular), Shift(Correr)", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 130), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "INTERAGIR (Num Ped): 7(Defesa), 8(Soco Esquerdo), 4(Soco Direito), 6(Chute Direito), 2(Chute Esquerdo)", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 150), Color.Gray);

                                spriteBatch.DrawString(JANELA.J.Neon, "COMBOS:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 190), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "1° Combo: 8  4  4  (6 + W)", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 220), Color.Gray);
                            }
                            if (i == 1)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "ESPADA 2 MAOS", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Entre rápido e lento, porém com bastante dano.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                            }
                            if (i == 2)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "ADAGA", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Extremamente rápido e ágil, porém com pouco dano", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);

                            }
                            if (i == 3)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "ARCO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Lento, porém causa bastante dano a distância", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);

                            }
                            if (i == 4)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "TRIDENTE", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Rápido, longo e poderoso, porém pouco ágil", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);

                            }
                        }
                        if (JANELA.J.PODERES)
                        {
                            if (i == 0)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "SLOW", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Faça o tempo andar lento para os inimigos. Perfeito para fuga. A mana se esgoda com o ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "tempo. Custa mínimo de 70 mana.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);

                            }
                            if (i == 1)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "RETROCEDER", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Volte na posição que você soltou o poder, dentro de 3 segundos, com a vida daquele tempo. ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Caso tenha recuperado vida, cuidado. Perfeito pra evitar a morte, ou restaurar grande ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "quantidade de vida perdida. Custa 50% do mana.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.Gray);

                            }
                            if (i == 2)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "ESCUDO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Te protege do dano inimigo ou/e acerta 1 de dano, 60 vezes por segundo. Todo dano acertado ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "desgasta a quantidade do escudo. A quantidade do escudo é definido pela quantidade de mana", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "ao ativá-lo. Após 5 segudos ele desativa, se reativa-lo durante esse período irá somar na ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "quantidade de poder do escudo e recarregar o tempo. Custa minimo de 10 mana.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 120), Color.Gray);


                            }
                            if (i == 3)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "VENTO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Solta uma rajada de vento que irá empurrar os inimigos na direção que ele está indo e tira", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, " 1 de dano 60x por segundo. Perfeito pra quem estiver encurralado. Custa 30% de mana.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);

                            }
                            if (i == 4)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "RAIO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Faz com que caiam raios na direção que estiver, um após o outro. Quando um raio atingir o ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "chão o outro será lançado até esgotar o mana. Perfeito para matar inimgos em área. Custa", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "10% de mana cada raio criado.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.Gray);
                            }
                        }

                        if (JANELA.J.listaitensall[i].ATIVO)
                        {
                            spriteBatch.DrawString(JANELA.J.Neon15, "Disponível", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height - 20), Color.Green);
                        }
                    }//fim combo aba 

                    if (!JANELA.J.listaitensall[i].Xis.Contains(mousePosition))
                        spriteBatch.Draw(JANELA.J.imgbotaoX, JANELA.J.listaitensall[i].Xis, Color.Black);
                    else if (JANELA.J.listaitensall[i].Xis.Contains(mousePosition))
                        spriteBatch.Draw(JANELA.J.imgbotaoXred, JANELA.J.listaitensall[i].Xis, Color.White);

                }// fim aba selecionada
            }
            
        }
    }
}
