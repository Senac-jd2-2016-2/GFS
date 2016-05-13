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
        public Rectangle Item = new Rectangle();
        public bool ATIVO;
        public int PosY, QuantidadePorAba = 9, QuantidadePorLinha = 3; // definir antes de começar
        public Texture2D imgespada2H, imgmaos, prop1, prop2, prop3, prop4;

        public void Criar()
        {
            for (int i = 0; i < QuantidadePorAba; i++)
            {
                //add quantos quadrados vao ter
                ItensAll A = new ItensAll();
                A.Item = new Rectangle();
                A.ATIVO = false;
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

        public void FUNÇÕES()
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
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
            }
        }

        public void DRAW(SpriteBatch spriteBatch)
        {
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);

            for (int i = 0; i < JANELA.J.listaitensall.Count; i++)
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
                    //o iten de cada grupo
                    if (JANELA.J.ARMAS)
                    {
                        spriteBatch.Draw(imgmaos, JANELA.J.listaitensall[0].Item, Color.White);
                        spriteBatch.Draw(imgespada2H, JANELA.J.listaitensall[1].Item, Color.White);
                    }
                }
                
            }//dentro do array
            
        }
    }
}
