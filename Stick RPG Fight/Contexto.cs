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
    class Contexto
    {
        
        public static Background Fundo = new Background();


        public static void inicializar(ContentManager content, Menu M1, Audio AUDIO, Personagem P1) // carregar imagens quando a fase começa (não no começo)
        {
            //Direito
            P1.imgSpriteSheetparado1 = content.Load<Texture2D>("spritesheet p1 parado1"); // só imagem, logo posso usar isso também pros inimigos.
            P1.imgSpriteSheetparado2 = content.Load<Texture2D>("spritesheet p1 parado2");
            P1.imgSpriteSheetandando = content.Load<Texture2D>("spritesheet p1 andando");
            P1.imgSpriteSheetATIRARarco = content.Load<Texture2D>("spritesheet p1 atirar (arco)");
            P1.imgSpriteSheetSACARarco = content.Load<Texture2D>("spritesheet p1 sacar arco");
            P1.imgSpriteSheetagachar1 = content.Load<Texture2D>("spritesheet p1 agachar1");
            P1.imgSpriteSheetagachar2 = content.Load<Texture2D>("spritesheet p1 agachar2");
            P1.imgSpriteSheetcorrendo = content.Load<Texture2D>("spritesheet p1 correndo");
            P1.imgSpriteSheetdefesa1 = content.Load<Texture2D>("spritesheet p1 defesa1");
            P1.imgSpriteSheetagachadoHIT = content.Load<Texture2D>("spritesheet p1 agachar hit");
            P1.imgSpriteSheetpular = content.Load<Texture2D>("spritesheet p1 pular1");

            //ESQUERDO
            P1.imgSpriteSheetparado1E = content.Load<Texture2D>("spritesheet p1 parado1 ESQUERDA"); // (E)
            P1.imgSpriteSheetandandoE = content.Load<Texture2D>("spritesheet p1 andando ESQUERDA");
            P1.imgSpriteSheetcorrendoE = content.Load<Texture2D>("spritesheet p1 correndo ESQUERDA");
            P1.imgSpriteSheetpularE = content.Load<Texture2D>("spritesheet p1 pular1 ESQUERDA");

            Fundo.menu00fundo = content.Load<Texture2D>("menu1");
            Fundo.imgfase1 = content.Load<Texture2D>("fase de luta");

            M1.imghistory = content.Load<Texture2D>("history");
            M1.imgcombate = content.Load<Texture2D>("combate");

            AUDIO.menusong = content.Load<Song>("Dreamland");

        }
    }
}
