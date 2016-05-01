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
    class ATUALIZAÇÃO
    {
        public static ATUALIZAÇÃO ATLZÇ = new ATUALIZAÇÃO();
        public void AtualizaTamanhoComeço(int W, int H, Botoes Botao, Personagem P1, Menu M1, Rectangle FlechaE, Rectangle FlechaD)
        {
            //dimensão dos BOTÕES
            M1.HistoryBotao = new Rectangle(0, H / 3, W / 3, H / 8);
            M1.CombateBotao = new Rectangle(W - W / 3, H / 3, W / 3, H / 8);

            //tamanho personagem
            P1.individuo = new Rectangle(0, H - H / 3, W / 16, H / 4);

            Contexto.Fundo.fase = new Rectangle(0, -H / 10, W * 3, H + H / 10);
            Contexto.Fundo.chao = new Rectangle(Contexto.Fundo.fase.X, Contexto.Fundo.fase.Y + H / 4 + Contexto.Fundo.fase.Height - H / 3 - 1, Contexto.Fundo.fase.Width, H / 3 - H / 4);

            //MediaPlayer.Play(AUDIO.menusong);

            //botao
            Botao.HOME = true;
            Botao.HOMEquadrado = new Rectangle(H / 100, H / 100, H / 10, H / 10);

            Botao.COMERCIOquadrado = new Rectangle(H / 100, H / 100 + H / 10 + H / 100, H / 10, H / 10);

            Botao.COMBOSquadrado = new Rectangle(H / 100, H / 100 + H / 10 + H / 100 + H / 10 + H / 100, H / 10, H / 10);

            //HUD
            //barra
            P1.XPrec = new Rectangle(Botao.HOMEquadrado.X + Botao.HOMEquadrado.Width + H / 100, Botao.HOMEquadrado.Y, 0, H / 29);
            P1.XPTrec = new Rectangle(Botao.HOMEquadrado.X + Botao.HOMEquadrado.Width + H / 100, Botao.HOMEquadrado.Y, H + H / 100 + H / 400, H / 29);

            P1.Barra = new Rectangle(Botao.HOMEquadrado.X + Botao.HOMEquadrado.Width + H / 100, Botao.COMERCIOquadrado.Y, H / 2 + H / 11, H / 10);
            P1.BarraEnergia = new Rectangle(Botao.HOMEquadrado.X + Botao.HOMEquadrado.Width + H / 100, Botao.COMERCIOquadrado.Y, H / 2 + H / 11, H / 10);
            P1.BarraVida = new Rectangle(Botao.HOMEquadrado.X + Botao.HOMEquadrado.Width + H / 100, Botao.COMERCIOquadrado.Y, H / 2 + H / 11, H / 10);
            P1.BarraMana = new Rectangle(Botao.HOMEquadrado.X + Botao.HOMEquadrado.Width + H / 100, Botao.COMERCIOquadrado.Y, H / 2 + H / 11, H / 10);


            //se não salvou o game (COMEÇO DO GAME)
            P1.PersonagemGAMEZERADO(); // zera tudo

            
            //flecha D e E
            FlechaD = new Rectangle(W - H / 11, H - H / 11, H / 11, H / 11);
            FlechaE = new Rectangle(0, H - H / 11, H / 11, H / 11);
        }
    }
}
