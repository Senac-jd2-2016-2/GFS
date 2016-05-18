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
        public int Contagem, ContagemGERADOR;
        public void ATIVAR(Personagem P1)
        {
            if (JANELA.J.RETROCEDERselect && P1.mana >= P1.mana / 2)
            {
                Contagem = 0;
                P1.mana -= P1.mana / 2; //joga tudo no escudo;
                P1.PODERretroceder = true;
                P1.VISUPODER(); // criar efeito especial

            }
        }

        public void FUNÇÃO(Personagem P1)
        {
            if (JANELA.J.RETROCEDERselect && P1.PODER && P1.PODERretroceder)
            {
                Contagem++;
                ContagemGERADOR++;
                P1.POSIÇÃOdoCLONE(P1);
                if (ContagemGERADOR >= 5)
                {
                    P1.GERADORdeCLONES(P1);
                    ContagemGERADOR = 0;
                }
                if (Contagem >= 300)
                {
                    P1.individuo.X = P1.listaclonePoder[0].individuo.X;
                    P1.individuo.Y = P1.listaclonePoder[0].individuo.Y;
                    Contexto.Fundo.fase.X = P1.listaclonePoder[0].POSmapacapturado.X;
                    Contexto.Fundo.fase.Y = P1.listaclonePoder[0].POSmapacapturado.Y;
                    P1.PODERretroceder = false;
                    Contagem = 0;
                    P1.listaclonePoder.Clear();
                    P1.PODER = false;
                }
            }
        }
    }
}
