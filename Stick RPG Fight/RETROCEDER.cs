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
    class RETROCEDER
    {
        public static RETROCEDER r = new RETROCEDER();
        public int Contagem, ContagemGERADOR, contagemFIM;
        public bool FIM;
        public void ATIVAR(Personagem P1)
        {
            if (JANELA.J.RETROCEDERselect && P1.mana >= P1.manaTOTAL / 2)
            {
                Contagem = 0;
                ContagemGERADOR = 0;
                P1.mana -= P1.mana / 2; //joga tudo no escudo;
                P1.PODERretroceder = true;
                P1.VISUPODER(); // criar efeito especial
                
            }
        }

        public void FUNÇÃO(Personagem P1)
        {
            if (JANELA.J.RETROCEDERselect && P1.PODER && P1.PODERretroceder)
            {
                P1.SENDOAGARRADO = false;
                if (!FIM)
                {
                    Contagem++;
                    ContagemGERADOR++;
                    P1.POSIÇÃOdoCLONE(P1);
                    if (ContagemGERADOR >= 9)
                    {
                        P1.GERADORdeCLONES(P1);
                        ContagemGERADOR = 0;
                    }
                }//enquanto nao tiver acabado
                if (Contagem >= 290) //fim do tempo (+/-3 segundos)
                {
                    FIM = true;
                    contagemFIM++;
                    if (contagemFIM >= 2)//a cada tanto vou indo pra posição do ultimo clone (no final acaba tudo)
                    {
                        if (P1.listaclonePoder.Count > 1)//ultimo
                        {
                            P1.IVUNERAVEL = true;
                            P1.individuo.X = P1.listaclonePoder[P1.listaclonePoder.Count - 1].POSp1capturado.X; //vou até o ultimo clone
                            P1.individuo.Y = P1.listaclonePoder[P1.listaclonePoder.Count - 1].POSp1capturado.Y;
                            Contexto.Fundo.fase.X = P1.listaclonePoder[P1.listaclonePoder.Count - 1].POSmapacapturado.X;
                            Contexto.Fundo.fase.Y = P1.listaclonePoder[P1.listaclonePoder.Count - 1].POSmapacapturado.Y;
                            P1.vida = P1.listaclonePoder[P1.listaclonePoder.Count - 1].vida;
                            P1.listaclonePoder.RemoveAt(P1.listaclonePoder.Count - 1); //apaga o ultimo até chegar no 1°
                            
                        }
                        if (P1.listaclonePoder.Count <= 1) //primeiro (final)
                        {
                            P1.IVUNERAVEL = false;
                            P1.individuo.X = P1.listaclonePoder[0].POSp1capturado.X;
                            P1.individuo.Y = P1.listaclonePoder[0].POSp1capturado.Y;
                            Contexto.Fundo.fase.X = P1.listaclonePoder[0].POSmapacapturado.X;
                            Contexto.Fundo.fase.Y = P1.listaclonePoder[0].POSmapacapturado.Y;
                            Contagem = 0;
                            P1.listaclonePoder.Clear(); //limpa
                            P1.PODER = false;
                            P1.PODERretroceder = false;

                            FIM = false;
                        }
                        contagemFIM = 0;
                    }
                    
                }
            }
        }
    }
}
