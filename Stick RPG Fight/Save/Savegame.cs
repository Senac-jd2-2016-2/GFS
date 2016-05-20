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

        public int g = 0, g2 = 0;
        public string Ex = "", Ex2 = "";
        public static Savegame S = new Savegame();

        public void Gravacao(Personagem P1)
        {
            //@"C:\savegame.txt"
            try
            {
                using (StreamWriter Warquivo = new
                StreamWriter("savegame.txt"))
                {
                    Warquivo.Write(P1.leite + " "
                        + P1.honra + " " + P1.qntdcombos + " ");
                    for (int i = 0; i < JANELA.J.qntddefases; i++)
                    {
                        Warquivo.Write(JANELA.J.FASEdestravada[i] + " ");
                    }
                    Warquivo.WriteLine(P1.XP + " " + P1.LVL + " " + JANELA.J.ESPADA2HATIVA + " " + JANELA.J.ADAGATIVA + " " + JANELA.J.ARCOATIVO + " " + JANELA.J.TRIDENTEATIVO + " " + JANELA.J.RETROCEDERATIVO + " " + JANELA.J.ESCUDOATIVO + " " + JANELA.J.VENTOATIVO + " " + JANELA.J.RAIOATIVO + " " + JANELA.J.Qcompletadas);
                    Warquivo.Close();
                }
            }
            catch (Exception ex) //colocar em linguagem do monogame
            {
                Ex2 = ex.Message;
            }
        }

        public void Leitura(Personagem P1)
        {
            if (File.Exists("savegame.txt"))
            {
                try
                {
                    using (StreamReader Rarquivo = new StreamReader("savegame.txt"))
                    {
                        string linha;
                        while ((linha = Rarquivo.ReadLine()) != null)
                        {
                            string[] dados = linha.Split(' ');
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
                            JANELA.J.Qcompletadas = int.Parse(dados[g + 11]);
                            
                            Ex = "";
                            
                        }
                        Rarquivo.Close();
                    }
                }
                catch (Exception ex) //colocar em linguagem do monogame
                {
                    Ex = ex.Message;
                }
            }
            else
            {
                Ex = " Savegame não existe";
            }
        }//

        /// -------------------------- GRAVAÇÃO DE COISAS NORMAIS NO JOGO: como: (ja entrou no jogo antes?, quais itens selecionou da ultima vez?, já passou pelo tutorial?)
        /// /// -------------------------- GRAVAÇÃO DE COISAS NORMAIS NO JOGO: como: (ja entrou no jogo antes?, quais itens selecionou da ultima vez?, já passou pelo tutorial?)
        /// /// -------------------------- GRAVAÇÃO DE COISAS NORMAIS NO JOGO: como: (ja entrou no jogo antes?, quais itens selecionou da ultima vez?, já passou pelo tutorial?)
        /// /// -------------------------- GRAVAÇÃO DE COISAS NORMAIS NO JOGO: como: (ja entrou no jogo antes?, quais itens selecionou da ultima vez?, já passou pelo tutorial?)
        //// -------------------------- GRAVAÇÃO DE COISAS NORMAIS NO JOGO: como: (ja entrou no jogo antes?, quais itens selecionou da ultima vez?, já passou pelo tutorial?)
        public void Gravacao2()
        {
            //@"C:\savegame.txt"
            try
            {
                using (StreamWriter Warquivo = new
                StreamWriter("savepos.txt"))
                {
                    for (int i = 0; i < JANELA.J.listadeitens.Count; i++)
                    {
                        if (JANELA.J.ATIVOS[i])
                        {
                            Warquivo.Write(JANELA.J.SELECIONADOS[i] + " ");
                            
                        }
                    }
                    //armas
                    Warquivo.Write(JANELA.J.MAOselect + " " + JANELA.J.ESPADA2Hselect + " " + JANELA.J.ADAGAselect + " " + JANELA.J.ARCOselect + " " + JANELA.J.TRIDENTEselect + " ");

                    //Poderes
                    Warquivo.Write(JANELA.J.SLOWselect + " " + JANELA.J.RETROCEDERselect + " " + JANELA.J.ESCUDOselect + " " + JANELA.J.VENTOselect + " " + JANELA.J.RAIOselect + " ");

                    //SOM
                    Warquivo.Write(Audio.A1.pino.X + " " + Audio.MasterVolume + " " + Audio.A1.PRIMEIRAVEZ + " ");
                    //pet
                    Warquivo.Close();
                }
            }
            catch (Exception ex) //colocar em linguagem do monogame
            {
                Ex2 = ex.Message;
            }
        }

        public void Leitura2()
        {
            if (File.Exists("savepos.txt"))
            {
                try
                {
                    using (StreamReader Rarquivo = new StreamReader("savepos.txt"))
                    {
                        string linha;
                        while ((linha = Rarquivo.ReadLine()) != null)
                        {
                            string[] dados = linha.Split(' ');
                            for (int i = 0; i < JANELA.J.listadeitens.Count; i++)
                            {
                                if (JANELA.J.ATIVOS[i])
                                {
                                    JANELA.J.SELECIONADOS[i] = bool.Parse(dados[i]);
                                    g2 = i;
                                }
                            }
                            //armas
                            JANELA.J.MAOselect = bool.Parse(dados[g2 + 1]);
                            JANELA.J.ESPADA2Hselect = bool.Parse(dados[g2 + 2]);
                            JANELA.J.ADAGAselect = bool.Parse(dados[g2 + 3]);
                            JANELA.J.ARCOselect = bool.Parse(dados[g2 + 4]);
                            JANELA.J.TRIDENTEselect = bool.Parse(dados[g2 + 5]);
                            
                            //poderes
                            JANELA.J.SLOWselect = bool.Parse(dados[g2 + 6]);
                            JANELA.J.RETROCEDERselect = bool.Parse(dados[g2 + 7]);
                            JANELA.J.ESCUDOselect = bool.Parse(dados[g2 + 8]);
                            JANELA.J.VENTOselect = bool.Parse(dados[g2 + 9]);
                            JANELA.J.RAIOselect = bool.Parse(dados[g2 + 10]);

                            //audio
                            Audio.A1.pino.X = int.Parse(dados[g2 + 11]);
                            Audio.MasterVolume = int.Parse(dados[g2 + 12]);
                            Audio.A1.PRIMEIRAVEZ = bool.Parse(dados[g2 + 13]);

                            //pet
                        }
                        Rarquivo.Close();
                    }
                }
                catch (Exception ex) //colocar em linguagem do monogame
                {
                    Ex = ex.Message;
                }
            }
            else
            {
                Ex = " Primeira vez jogando";
            }
        }
    }
}
