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
using System.IO;

namespace Stick_RPG_Fight
{
    class Savegame
    {

        public int g = 0;
        public static Savegame S = new Savegame();

        public void Gravacao(Personagem P1)
        {
            
            try
            {
                using (StreamWriter Warquivo = new
                StreamWriter(@"C:\Usuários\Documentos\savegame.txt"))
                {
                    Warquivo.Write(P1.leite + "@"
                        + P1.honra + "@" + P1.qntdcombos + "@");
                    for (int i = 0; i < JANELA.J.qntddefases; i++)
                    {
                        Warquivo.Write(JANELA.J.FASEdestravada[i] + "@");
                    }
                    Warquivo.WriteLine(P1.XP + "@" + P1.LVL + "@" + JANELA.J.ESPADA2HATIVA + "@" + JANELA.J.ADAGATIVA + "@" + JANELA.J.ARCOATIVO + "@" + JANELA.J.TRIDENTEATIVO + "@" + JANELA.J.RETROCEDERATIVO + "@" + JANELA.J.ESCUDOATIVO + "@" + JANELA.J.VENTOATIVO + "@" + JANELA.J.RAIOATIVO);
                    Warquivo.Close();
                }
            }
            catch (Exception ex) //colocar em linguagem do monogame
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Leitura(Personagem P1)
        {
            try
            {
                using (StreamReader Rarquivo = new
                StreamReader(@"C:\Usuários\Documentos\savegame.txt"))
                {
                    string linha;
                    while ((linha = Rarquivo.ReadLine()) != null)
                    {
                        string[] dados = linha.Split('@');
                        P1.leite = int.Parse(dados[0]);
                        P1.honra = int.Parse(dados[1]);
                        P1.qntdcombos = int.Parse(dados[2]);
                        for (int i = 0; i < JANELA.J.qntddefases; i++)
                        {
                            JANELA.J.FASEdestravada[i] = bool.Parse(dados[3 + (i)]);
                            g = 3 + i;
                        }
                        P1.XP = int.Parse(dados[g + 1]);
                        P1.LVL = int.Parse(dados[g + 2]);
                        //todos os itens que a pessoa comprou
                        JANELA.J.ESPADA2HATIVA = bool.Parse(dados[g + 3]);
                        JANELA.J.ADAGATIVA = bool.Parse(dados[g + 4]);
                        JANELA.J.ARCOATIVO = bool.Parse(dados[g + 5]);
                        JANELA.J.TRIDENTEATIVO = bool.Parse(dados[g + 6]);
                        JANELA.J.RETROCEDERATIVO = bool.Parse(dados[g + 7]);
                        JANELA.J.ESCUDOATIVO = bool.Parse(dados[g + 8]);
                        JANELA.J.VENTOATIVO = bool.Parse(dados[g + 9]);
                        JANELA.J.RAIOATIVO = bool.Parse(dados[g + 10]);
                       
                        Rarquivo.Close();
                    }
                }
            }
            catch (Exception ex) //colocar em linguagem do monogame
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
