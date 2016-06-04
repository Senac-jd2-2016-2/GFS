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
        public Rectangle Item = new Rectangle(), Xis = new Rectangle(), Botaocompra = new Rectangle();
        public bool ATIVO, ABASELECIONADA;
        public int PosY, QuantidadePorAba = 9, QuantidadePorLinha = 3; // definir antes de começar
        public Texture2D imgespada2H, imgmaos, imgadaga, imgtridente, imgslow, imgretroceder, imgarco, imgescudo, imgvento, imgraio, prop1, prop2, prop3, prop4, imgCOMPRAR, imgEQUIPAR1, imgEQUIPAR2;
        public bool B, Bx, ABATRANCADA, BOTAOCOMPRAarm, BOTAOCOMPRA, BOTAOCOMPRApod, BOTAOCOMPRApet, SELECIONADO; //botao pra cada item 


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
                JANELA.J.listaitensall[i].Xis.X = JANELA.J.janelaall.X + JANELA.J.janelaall.Width - JANELA.J.listaitensall[i].Xis.Width; //fim da tela
                JANELA.J.listaitensall[i].Xis.Y = JANELA.J.janelaall.Y;
                JANELA.J.listaitensall[i].Xis.Width = JANELA.J.R.Height / 18 + JANELA.J.R.Height / 240; // = 45 + 3 = 48
                JANELA.J.listaitensall[i].Xis.Height = JANELA.J.R.Height / 27; // = 30

                //BOTAO compra / equipar
                JANELA.J.listaitensall[i].Botaocompra.X = JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - ((H / 4 - H / 170) / 2); //fim da tela
                JANELA.J.listaitensall[i].Botaocompra.Y = JANELA.J.janelaall.Y + JANELA.J.janelaall.Height - (H / 9 + H / 150);
                JANELA.J.listaitensall[i].Botaocompra.Width = H / 4 - H / 170; // = 270 - 6 = 264
                JANELA.J.listaitensall[i].Botaocompra.Height = H / 9 + H / 150; // 120 + 7 = 127
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

        public void FUNÇÕES(bool BOTAO, Personagem P1)
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
                //imagem (RECEBENDO)
                if (JANELA.J.ARMAS)
                {
                    if (i < 5) // menor do que a quantidade de itens de cada
                    {
                        JANELA.J.listaitensall[i].ATIVO = JANELA.J.ATIVOS[i];//transformo o ativo da janela esquerda, como o ativo da janela all (direita)
                        JANELA.J.listaitensall[i].SELECIONADO = JANELA.J.SELECIONADOS[i];
                    }
                }
                else if (JANELA.J.PODERES)
                {
                    if (i < 5) // menor do que a quantidade de itens de cada
                    {
                        JANELA.J.listaitensall[i].ATIVO = JANELA.J.ATIVOS[i + 5];
                        JANELA.J.listaitensall[i].SELECIONADO = JANELA.J.SELECIONADOS[i + 5];
                        
                    }
                }
                 else if (JANELA.J.PET)
                {
                    if (i < 5) // menor do que a quantidade de itens de cada
                    {
                        JANELA.J.listaitensall[i].ATIVO = JANELA.J.ATIVOS[i + 10];
                        JANELA.J.listaitensall[i].SELECIONADO = JANELA.J.SELECIONADOS[i + 10];
                    }
                }
            }
                //comercio
                //combo
                //ENTRADA
            for (int i = 0; i < JANELA.J.listaitensall.Count; i++)
            {
                if (!JANELA.J.listaitensall[i].ABASELECIONADA && !ItensAll.a.ABATRANCADA && i < 5 && (JANELA.J.PODERES || JANELA.J.PET || JANELA.J.ARMAS))//se nao tiver nenhuma aba selecionada (possibilita a voce clicar nos itens)
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

                //BOTAO COMPRA / USAR
                if (JANELA.J.listaitensall[i].ABASELECIONADA && ItensAll.a.ABATRANCADA)
                {
                    if (!JANELA.J.listaitensall[i].ATIVO)//se ele tiver sem comprar (--------------------------> MODO COMPRA <---------------------)
                    {
                        if (JANELA.J.listaitensall[i].Botaocompra.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed && JANELA.J.JANELACOMERCIO)
                        {
                            if (i == 1 && JANELA.J.ARMAS && P1.qntdcombos >= 1000 && P1.leite >= 100 && P1.honra >= 20 || i == 2 && JANELA.J.ARMAS && P1.qntdcombos >= 20000 && P1.leite >= 50 && P1.honra >= 10 || i == 3 && JANELA.J.ARMAS && P1.qntdcombos >= 10000 && P1.leite >= 300 && P1.honra >= 55 || i == 4 && JANELA.J.ARMAS && P1.qntdcombos >= 35000 && P1.leite >= 50 && P1.honra >= 200)//ARMAS
                            {
                                BOTAO = true;
                                JANELA.J.listaitensall[i].BOTAOCOMPRAarm = true;
                            }
                            if (i == 1 && JANELA.J.PODERES && P1.qntdcombos >= 500 && P1.leite >= 200 && P1.honra >= 10 || i == 2 && JANELA.J.PODERES && P1.qntdcombos >= 1000 && P1.leite >= 300 && P1.honra >= 150 || i == 3 && JANELA.J.PODERES && P1.qntdcombos >= 30000 && P1.leite >= 100 && P1.honra >= 50 || i == 4 && JANELA.J.PODERES && P1.qntdcombos >= 10500 && P1.leite >= 500 && P1.honra >= 350)//ARMAS
                            {
                                BOTAO = true;
                                JANELA.J.listaitensall[i].BOTAOCOMPRApod = true;
                            }
                        }
                        if (!JANELA.J.listaitensall[i].Botaocompra.Contains(mousePosition))
                        {
                            JANELA.J.listaitensall[i].BOTAOCOMPRAarm = false;
                            JANELA.J.listaitensall[i].BOTAOCOMPRApod = false;
                            JANELA.J.listaitensall[i].BOTAOCOMPRApet = false;
                        }
                        if (JANELA.J.listaitensall[i].BOTAOCOMPRAarm && !BOTAO)
                        {
                            JANELA.J.listaitensall[i].BOTAOCOMPRAarm = false;
                            //ARMAS
                            if (i == 1 && JANELA.J.ARMAS) // (espada) ESTE É O PREÇO DE CADA ITEM ARMA
                            {
                                P1.qntdcombos -= 1000;
                                P1.leite -= 100;
                                JANELA.J.ESPADA2HATIVA = true;
                            }
                            if (i == 2 && JANELA.J.ARMAS) //adaga
                            {
                                P1.qntdcombos -= 20000;
                                P1.leite -= 50;
                                JANELA.J.ADAGATIVA = true;
                            }
                            if (i == 3 && JANELA.J.ARMAS) //arco
                            {
                                P1.qntdcombos -= 10000;
                                P1.leite -= 300;
                                JANELA.J.ARCOATIVO = true;
                            }
                            if (i == 4 && JANELA.J.ARMAS) //tridente
                            {
                                P1.qntdcombos -= 35000;
                                P1.leite -= 50;
                                JANELA.J.TRIDENTEATIVO = true;
                            }
                        }

                        if (JANELA.J.listaitensall[i].BOTAOCOMPRApod && !BOTAO)
                        {
                            JANELA.J.listaitensall[i].BOTAOCOMPRApod = false;
                            //PODERES
                            if (i == 1 && JANELA.J.PODERES) // (retroceder) ESTE É O PREÇO DE CADA ITEM PODER
                            {
                                P1.qntdcombos -= 500;
                                P1.leite -= 200;
                                JANELA.J.RETROCEDERATIVO = true;
                            }
                            if (i == 2 && JANELA.J.PODERES) //ESCUDO
                            {
                                P1.qntdcombos -= 1000;
                                P1.leite -= 300;
                                JANELA.J.ESCUDOATIVO= true;
                            }
                            if (i == 3 && JANELA.J.PODERES) //VENTO
                            {
                                P1.qntdcombos -= 30000;
                                P1.leite -= 100;
                                JANELA.J.VENTOATIVO = true;
                            }
                            if (i == 4 && JANELA.J.PODERES) //RAIO
                            {
                                P1.qntdcombos -= 10500;
                                P1.leite -= 500;
                                JANELA.J.RAIOATIVO = true;
                            }
                            
                            //PET
                        }//fim do botao compra
                    }//fim (caso ele esteja desativo)
                    if (JANELA.J.listaitensall[i].ATIVO && !JANELA.J.SELECIONADOS[i])
                    {
                        if (JANELA.J.listaitensall[i].Botaocompra.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                        {
                            BOTAO = true;
                            JANELA.J.listaitensall[i].BOTAOCOMPRA = true;
                        }
                        if (!JANELA.J.listaitensall[i].Botaocompra.Contains(mousePosition))
                            JANELA.J.listaitensall[i].BOTAOCOMPRA = false;
                        if (JANELA.J.listaitensall[i].BOTAOCOMPRA && !BOTAO)
                        {
                            //aqui vai selecionar o item da aba (sendo que i é de 0 - 4, [5 itens cada], somar faz com q a posição do proximo seja exata)
                            if (JANELA.J.ARMAS)
                            {
                                
                                if (i == 0)
                                {
                                    JANELA.J.SELECIONADOS[i] = true;
                                    //
                                    JANELA.J.MAOselect = true;
                                    JANELA.J.ESPADA2Hselect = false;
                                    JANELA.J.ADAGAselect = false;
                                    JANELA.J.ARCOselect = false;
                                    JANELA.J.TRIDENTEselect = false;
                                    //
                                    for (int a = 1; a < 5; a++ )
                                        JANELA.J.SELECIONADOS[a] = false;
                                }
                                if (i == 1)
                                {
                                    JANELA.J.SELECIONADOS[i] = true;
                                    //
                                    JANELA.J.MAOselect = false;
                                    JANELA.J.ESPADA2Hselect = true;
                                    JANELA.J.ADAGAselect = false;
                                    JANELA.J.ARCOselect = false;
                                    JANELA.J.TRIDENTEselect = false;
                                    //
                                    JANELA.J.SELECIONADOS[0] = false;
                                    for (int a = 2; a < 5; a++)
                                        JANELA.J.SELECIONADOS[a] = false;
                                }
                                if (i == 2)
                                {
                                    JANELA.J.SELECIONADOS[i] = true;
                                    //
                                    JANELA.J.MAOselect = false;
                                    JANELA.J.ESPADA2Hselect = false;
                                    JANELA.J.ADAGAselect = true;
                                    JANELA.J.ARCOselect = false;
                                    JANELA.J.TRIDENTEselect = false;
                                    //
                                    JANELA.J.SELECIONADOS[0] = false;
                                    JANELA.J.SELECIONADOS[1] = false;
                                    for (int a = 3; a < 5; a++)
                                        JANELA.J.SELECIONADOS[a] = false;
                                }
                                if (i == 3)
                                {
                                    JANELA.J.SELECIONADOS[i] = true;
                                    //
                                    JANELA.J.MAOselect = false;
                                    JANELA.J.ESPADA2Hselect = false;
                                    JANELA.J.ADAGAselect = false;
                                    JANELA.J.ARCOselect = true;
                                    JANELA.J.TRIDENTEselect = false;
                                    //
                                    JANELA.J.SELECIONADOS[4] = false;
                                    for (int a = 0; a < 3; a++)
                                        JANELA.J.SELECIONADOS[a] = false;
                                }
                                if (i == 4)
                                {
                                    JANELA.J.SELECIONADOS[i] = true;
                                    //
                                    JANELA.J.MAOselect = false;
                                    JANELA.J.ESPADA2Hselect = false;
                                    JANELA.J.ADAGAselect = false;
                                    JANELA.J.ARCOselect = false;
                                    JANELA.J.TRIDENTEselect = true;
                                    //
                                    for (int a = 0; a < 4; a++)
                                        JANELA.J.SELECIONADOS[a] = false;
                                }
                            }
                            if (JANELA.J.PODERES)
                            {
                                P1.PODER = false;
                                // 5 - 9
                                if (i == 0)
                                {
                                    JANELA.J.SELECIONADOS[i + 5] = true;
                                    //
                                    JANELA.J.SLOWselect = true;
                                    JANELA.J.RETROCEDERselect = false;
                                    JANELA.J.ESCUDOselect = false;
                                    JANELA.J.VENTOselect = false;
                                    JANELA.J.RAIOselect = false;
                                    //
                                    for (int a = 1; a < 5; a++)
                                        JANELA.J.SELECIONADOS[a + 5] = false;
                                }
                                if (i == 1)
                                {
                                    JANELA.J.SELECIONADOS[i + 5] = true;
                                    //
                                    JANELA.J.SLOWselect = false;
                                    JANELA.J.RETROCEDERselect = true;
                                    JANELA.J.ESCUDOselect = false;
                                    JANELA.J.VENTOselect = false;
                                    JANELA.J.RAIOselect = false;
                                    //
                                    JANELA.J.SELECIONADOS[0 + 5] = false;
                                    for (int a = 2; a < 5; a++)
                                        JANELA.J.SELECIONADOS[a + 5] = false;
                                }
                                if (i == 2)
                                {
                                    JANELA.J.SELECIONADOS[i + 5] = true;
                                    //
                                    JANELA.J.SLOWselect = false;
                                    JANELA.J.RETROCEDERselect = false;
                                    JANELA.J.ESCUDOselect = true;
                                    JANELA.J.VENTOselect = false;
                                    JANELA.J.RAIOselect = false;
                                    //
                                    JANELA.J.SELECIONADOS[0 + 5] = false;
                                    JANELA.J.SELECIONADOS[1 + 5] = false;
                                    for (int a = 3; a < 5; a++)
                                        JANELA.J.SELECIONADOS[a + 5] = false;
                                }
                                if (i == 3)
                                {
                                    JANELA.J.SELECIONADOS[i + 5] = true;
                                    //
                                    JANELA.J.SLOWselect = false;
                                    JANELA.J.RETROCEDERselect = false;
                                    JANELA.J.ESCUDOselect = false;
                                    JANELA.J.VENTOselect = true;
                                    JANELA.J.RAIOselect = false;
                                    //
                                    JANELA.J.SELECIONADOS[4 + 5] = false;
                                    for (int a = 0; a < 3; a++)
                                        JANELA.J.SELECIONADOS[a + 5] = false;
                                }
                                if (i == 4)
                                {
                                    JANELA.J.SELECIONADOS[i + 5] = true;
                                    //
                                    JANELA.J.SLOWselect = false;
                                    JANELA.J.RETROCEDERselect = false;
                                    JANELA.J.ESCUDOselect = false;
                                    JANELA.J.VENTOselect = false;
                                    JANELA.J.RAIOselect = true;
                                    //
                                    for (int a = 0; a < 4; a++)
                                        JANELA.J.SELECIONADOS[a + 5] = false;
                                }
                            }
                            if (JANELA.J.PET)
                            {
                                JANELA.J.SELECIONADOS[i + 10] = true;
                                /*
                                if (i == 0) JANELA.J.MAOselect = true;
                                if (i == 1) JANELA.J.MAOselect = true;
                                if (i == 2) JANELA.J.MAOselect = true;
                                if (i == 3) JANELA.J.MAOselect = true;
                                if (i == 4) JANELA.J.MAOselect = true; */
                            }
                            JANELA.J.listaitensall[i].BOTAOCOMPRA = false;
                        }
                    }//fim do botao que ativa (qnd estiver dentro da aba)
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
                            if (i == 3)
                                spriteBatch.Draw(imgvento, JANELA.J.listaitensall[3].Item, Color.White);
                            if (i == 4)
                                spriteBatch.Draw(imgraio, JANELA.J.listaitensall[4].Item, Color.White);

                        }
                    }
                }//fim do nao estar aba trancada
                if (JANELA.J.listaitensall[i].ABASELECIONADA && ItensAll.a.ABATRANCADA)//se nao tiver nenhuma aba selecionada (ele mostra os itens)
                {
                    if (JANELA.J.JANELACOMERCIO)
                    {
                        if (JANELA.J.ARMAS)//COMPRAS
                        {
                            if (i == 0)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "DESARMADO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Agilidade, que permite vários combos diferentes.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);

                                spriteBatch.DrawString(JANELA.J.Neon, "PREÇOS:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "COMBOS: 0, LEITE: 0, HONRA: 0", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 130), Color.Gray);

                            }
                            if (i == 1)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "ESPADA 2 MAOS", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Entre rápido e lento, porém com bastante dano.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);

                                spriteBatch.DrawString(JANELA.J.Neon, "PREÇOS:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "COMBOS: 1000, LEITE: 0, HONRA: 0", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 130), Color.Gray);
                            }
                            if (i == 2)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "ADAGA", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Extremamente rápido e ágil, porém com pouco dano", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);

                                spriteBatch.DrawString(JANELA.J.Neon, "PREÇOS:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "COMBOS: 20000, LEITE: 50, HONRA: 10", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 130), Color.Gray);
                            }
                            if (i == 3)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "ARCO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Lento, porém causa bastante dano a distância", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                
                                spriteBatch.DrawString(JANELA.J.Neon, "PREÇOS:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "COMBOS: 10000, LEITE: 300, HONRA: 55", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 130), Color.Gray);
                            }
                            if (i == 4)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "TRIDENTE", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Rápido, longo e poderoso, porém pouco ágil", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                
                                spriteBatch.DrawString(JANELA.J.Neon, "PREÇOS:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "COMBOS: 35000, LEITE: 50, HONRA: 200", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 130), Color.Gray);
                            }
                        }
                        if (JANELA.J.PODERES)
                        {
                            if (i == 0)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "SLOW", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Faça o tempo andar lento para os inimigos. Perfeito para fuga. A mana se esgoda com o ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "tempo. Custo mínimo de 70 mana.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);
                               
                                spriteBatch.DrawString(JANELA.J.Neon, "PREÇOS:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 120), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "COMBOS: 0, LEITE: 0, HONRA: 0", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 150), Color.Gray);
                            }
                            if (i == 1)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "RETROCEDER", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Volte na posição que você soltou o poder, dentro de 3 segundos, com a vida daquele tempo. ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Caso tenha recuperado vida, cuidado. Perfeito pra evitar a morte, ou restaurar grande ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "quantidade de vida perdida. Custa 50% do mana.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.Gray);
                                
                                spriteBatch.DrawString(JANELA.J.Neon, "PREÇOS:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 140), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "COMBOS: 500, LEITE: 200, HONRA: 10", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 170), Color.Gray);
                            }
                            if (i == 2)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "ESCUDO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Te protege do dano inimigo ou/e acerta 1 de dano, 60 vezes por segundo. Todo dano acertado ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "desgasta a quantidade do escudo. A quantidade do escudo é definido pela quantidade de mana", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "ao ativá-lo. Após 5 segudos ele desativa, se reativa-lo durante esse período irá somar na ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "quantidade de poder do escudo e recarregar o tempo. Custo mínimo de 25% do mana.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 120), Color.Gray);
                               
                                spriteBatch.DrawString(JANELA.J.Neon, "PREÇOS:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 160), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "COMBOS: 1000, LEITE: 300, HONRA: 150", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 190), Color.Gray);

                            }
                            if (i == 3)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "VENTO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Solta uma rajada de vento que irá empurrar os inimigos na direção que ele está indo e tira", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "60 de dano por segundo ao encostar. Perfeito pra quem estiver encurralado. Custa 30% de mana.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);
                                
                                spriteBatch.DrawString(JANELA.J.Neon, "PREÇOS:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 120), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "COMBOS: 30000, LEITE: 100, HONRA: 50", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 150), Color.Gray);
                            }
                            if (i == 4)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "RAIO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Faz com que caiam raios na direção que estiver, um após o outro. Quando um raio atingir o ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "chão o outro será lançado até esgotar o mana. Perfeito para matar inimigos em área. Custa", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "10% de mana cada raio criado.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.Gray);

                                spriteBatch.DrawString(JANELA.J.Neon, "PREÇOS:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 140), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "COMBOS: 10500, LEITE: 500, HONRA: 350", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 190), Color.Gray);
                            }
                        }

                        if (JANELA.J.listaitensall[i].ATIVO)
                        {
                            spriteBatch.DrawString(JANELA.J.Neon15, "Disponível", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height - 20), Color.Green);
                        }
                        else if (!JANELA.J.listaitensall[i].ATIVO)
                        {
                            spriteBatch.DrawString(JANELA.J.Neon15, "À venda", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height - 20), Color.Red);
                        }
                    }
                    else if (JANELA.J.JANELACOMBO) //INFORMAÇÕES
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

                                spriteBatch.DrawString(JANELA.J.Neon, "MANUAL (tecla):", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 120), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "(Num Ped) 5", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 150), Color.Gray);
                            }
                            if (i == 1)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "RETROCEDER", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Volte na posição que você soltou o poder, dentro de 3 segundos, com a vida daquele tempo. ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Caso tenha recuperado vida, cuidado. Perfeito pra evitar a morte, ou restaurar grande ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "quantidade de vida perdida. Custa 50% do mana.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.Gray);

                                spriteBatch.DrawString(JANELA.J.Neon, "MANUAL (tecla):", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 140), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "(Num Ped) 5", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 170), Color.Gray);
                            }
                            if (i == 2)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "ESCUDO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Te protege do dano inimigo ou/e acerta 1 de dano, 60 vezes por segundo. Todo dano acertado ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "desgasta a quantidade do escudo. A quantidade do escudo é definido pela quantidade de mana", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "ao ativá-lo. Após 5 segudos ele desativa, se reativa-lo durante esse período irá somar na ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "quantidade de poder do escudo e recarregar o tempo. Custo mínimo de 25% do mana.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 120), Color.Gray);

                                spriteBatch.DrawString(JANELA.J.Neon, "MANUAL (tecla):", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 160), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "(Num Ped) 5", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 200), Color.Gray);
                            }
                            if (i == 3)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "VENTO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Solta uma rajada de vento que irá empurrar os inimigos na direção que ele está indo e tira", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "60 de dano por segundo ao encostar. Perfeito pra quem estiver encurralado. Custa 30% de mana.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);

                                spriteBatch.DrawString(JANELA.J.Neon, "MANUAL (tecla):", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 120), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "(Num Ped) 5", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 150), Color.Gray);
                            }
                            if (i == 4)
                            {
                                spriteBatch.DrawString(JANELA.J.Firefont, "RAIO", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 2 - JANELA.J.janelaall.Width / 8, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 16), Color.Black);
                                spriteBatch.DrawString(JANELA.J.Neon, "DEFINIÇÃO:", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 30), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "Faz com que caiam raios na direção que estiver, um após o outro. Quando um raio atingir o ", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 60), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "chão o outro será lançado até esgotar o mana. Perfeito para matar inimgos em área. Custa", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 80), Color.Gray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "10% de mana cada raio criado.", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 100), Color.Gray);

                                spriteBatch.DrawString(JANELA.J.Neon, "MANUAL (tecla):", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 16, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 140), Color.DarkGray);
                                spriteBatch.DrawString(JANELA.J.Neon15, "(Num Ped) 5", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height / 14 + 170), Color.Gray);
                            }
                        }

                        if (JANELA.J.listaitensall[i].ATIVO)
                        {
                            spriteBatch.DrawString(JANELA.J.Neon15, "Disponível", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height - 20), Color.Green);
                        }
                        else if (!JANELA.J.listaitensall[i].ATIVO)
                        {
                            spriteBatch.DrawString(JANELA.J.Neon15, "À venda", new Vector2(JANELA.J.janelaall.X + JANELA.J.janelaall.Width / 30, JANELA.J.janelaall.Y + JANELA.J.janelaall.Height - 20), Color.Red);
                        }
                    }//fim combo aba 

                    if (!JANELA.J.listaitensall[i].Xis.Contains(mousePosition))
                        spriteBatch.Draw(JANELA.J.imgbotaoX, JANELA.J.listaitensall[i].Xis, Color.Black);
                    else if (JANELA.J.listaitensall[i].Xis.Contains(mousePosition))
                        spriteBatch.Draw(JANELA.J.imgbotaoXred, JANELA.J.listaitensall[i].Xis, Color.White);

                    if (!JANELA.J.listaitensall[i].ATIVO && JANELA.J.JANELACOMERCIO)
                    {
                        if (!JANELA.J.listaitensall[i].Botaocompra.Contains(mousePosition) )
                        {
                            spriteBatch.Draw(a.imgCOMPRAR, JANELA.J.listaitensall[i].Botaocompra, Color.White);
                        }
                        if (JANELA.J.listaitensall[i].Botaocompra.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                        {
                            spriteBatch.Draw(a.imgCOMPRAR, JANELA.J.listaitensall[i].Botaocompra, Color.Green);
                        }
                        if (JANELA.J.listaitensall[i].Botaocompra.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                        {
                            spriteBatch.Draw(a.imgCOMPRAR, JANELA.J.listaitensall[i].Botaocompra, Color.DarkGreen);
                        }
                    }
                    if (JANELA.J.listaitensall[i].ATIVO)
                    {
                        if (!JANELA.J.listaitensall[i].SELECIONADO)
                        {
                            if (!JANELA.J.listaitensall[i].Botaocompra.Contains(mousePosition))
                            {
                                spriteBatch.Draw(a.imgEQUIPAR1, JANELA.J.listaitensall[i].Botaocompra, Color.White);
                            }
                            if (JANELA.J.listaitensall[i].Botaocompra.Contains(mousePosition) && Mouse.GetState().LeftButton != ButtonState.Pressed)
                            {
                                spriteBatch.Draw(a.imgEQUIPAR1, JANELA.J.listaitensall[i].Botaocompra, Color.Green);
                            }
                            if (JANELA.J.listaitensall[i].Botaocompra.Contains(mousePosition) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                            {
                                spriteBatch.Draw(a.imgEQUIPAR2, JANELA.J.listaitensall[i].Botaocompra, Color.White);
                            }
                        }
                        else if (JANELA.J.listaitensall[i].SELECIONADO)
                        {
                            spriteBatch.Draw(a.imgEQUIPAR2, JANELA.J.listaitensall[i].Botaocompra, Color.White);
                        }
                    }
                }// fim aba selecionada
            }
            
        }
    }
}
