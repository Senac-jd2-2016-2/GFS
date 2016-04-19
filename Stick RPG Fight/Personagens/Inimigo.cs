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
    class Inimigo
    {
        //                                i1
        //sprite
        public Texture2D imgParadoi1;
        public Texture2D imgAndarDi1;
        public Texture2D imgAndarEi1;

        //D
        public Texture2D imgFacaDi1;
        public Texture2D imgAgacharDi1;
        public Texture2D imgAgacharDEFDi1;
        public Texture2D imgCaidoDi1;
        public Texture2D imgJogarFacaDi1;
        public Texture2D imgDEFDi1;
        public Texture2D imgHit1Di1;
        public Texture2D imgHit2Di1;
        public Texture2D imgHit3Di1;
        public Texture2D imgLevantarDi1;
        public Texture2D imgATK1Di1;
        public Texture2D imgAgarrarDi1;
        public Texture2D imgRasteiraDi1;
        public Texture2D imgPODERDi1;
        //E
        public Texture2D imgFacaEi1;
        public Texture2D imgAgacharEi1;
        public Texture2D imgAgacharDEFEi1;
        public Texture2D imgCaidoEi1;
        public Texture2D imgJogarFacaEi1;
        public Texture2D imgDEFEi1;
        public Texture2D imgHit1Ei1;
        public Texture2D imgHit2Ei1;
        public Texture2D imgHit3Ei1;
        public Texture2D imgLevantarEi1;
        public Texture2D imgATK1Ei1;
        public Texture2D imgAgarrarEi1;
        public Texture2D imgRasteiraEi1;
        public Texture2D imgPODEREi1;

        //tamanho do sprite
        public Point tamanhoparadoi1 = new Point(225, 383); //Dimensões do sprite
        public Point tamanhoAndari1 = new Point(166, 367); //Dimensões do sprite

        
        public Point tamanhoAgachari1 = new Point(198, 362); //Dimensões do sprite
        public Point tamanhoAgacharDEFi1 = new Point(215, 362); //Dimensões do sprite
        public Point tamanhoCaidoi1 = new Point(357, 178); //Dimensões do sprite
        public Point tamanhoDEFi1 = new Point(197, 361); //Dimensões do sprite
        public Point tamanhoJogarFacai1 = new Point(260, 389); //Dimensões do sprite
        public Point tamanhoHit1i1 = new Point(193, 362); //Dimensões do sprite
        public Point tamanhoHit2i1 = new Point(221, 365); //Dimensões do sprite
        public Point tamanhoHit3i1 = new Point(448, 371); //Dimensões do sprite //
        public Point tamanhoLevantari1 = new Point(371, 368); //Dimensões do sprite

        public Point tamanhoATK1i1 = new Point(217, 365); //Dimensões do sprite // (MESMO ALTURA DO AGARRAR / HIT 2 / AGACHAR / DEF) (MESMO QUE O X do HIT2 / Agachar DEF)
        public Point tamanhoAgarrari1 = new Point(266, 365); //Dimensões do sprite // (mesma altura do ATAK1)
        public Point tamanhoRasteirai1 = new Point(294, 372); //Dimensões do sprite // (mesma altura do Hit3)
        public Point tamanhoPODERi1 = new Point(217, 363); //Dimensões do sprite // (mesma altura do ATAK1) (mesma X do ATK1)

        //qnts sprites
        public Point SpriteSheetparadoi1 = new Point(20, 10); //Dimensões da spritesheet
        public Point SpriteSheetAndari1 = new Point(20, 4); //Dimensões da spritesheet

        
        public Point SpriteSheetAgachari1 = new Point(8, 3); //Dimensões do spritesheet
        public Point SpriteSheetAgacharDEFi1 = new Point(8, 3); //Dimensões do spritesheet
        public Point SpriteSheetCaidoi1 = new Point(4, 8); //Dimensões do spritesheet
        public Point SpriteSheetDEFi1 = new Point(8, 3); //Dimensões do spritesheet
        public Point SpriteSheetJogarFacai1 = new Point(8, 8); //Dimensões do spritesheet
        public Point SpriteSheetHit1i1 = new Point(9, 3); //Dimensões do spritesheet
        public Point SpriteSheetHit2i1 = new Point(9, 3); //Dimensões do spritesheet
        public Point SpriteSheetHit3i1 = new Point(8, 6); //Dimensões do spritesheet
        public Point SpriteSheetLevantari1 = new Point(8, 7); //Dimensões do spritesheet

        public Point SpriteSheetATK1i1 = new Point(8, 4); //Dimensões do spritesheet
        public Point SpriteSheetAgarrari1 = new Point(8, 13); //Dimensões do spritesheet
        public Point SpriteSheetRasteirai1 = new Point(8, 8); //Dimensões do spritesheet
        public Point SpriteSheetPODERi1 = new Point(10, 13); //Dimensões do spritesheet

        //frame de posição momentanea do sprite
        public Point frameparadoi1 = new Point(0, 0); //Marca o frame a ser utilizado
        public Point frameAndari1 = new Point(0, 0); //Marca o frame a ser utilizado
        //FRAME para TUDO (menos parado e andar)
        public Point frameALLi1 = new Point(0, 0); //Marca o frame a ser utilizado

        
        //

        //GERAL DOS RETANGLES
        public Rectangle individuo = new Rectangle();
        public Rectangle meio = new Rectangle();

        //barra
        public Rectangle VIDA = new Rectangle();
        public Rectangle MANA = new Rectangle();
        public Rectangle ENERGIA = new Rectangle();

        //GERAL int
        public int opç;
        public int opçluta = 0;
        public int opç_Atk;
        public int vida;
        public int mana;
        public int energia;
        public int vidaT;
        public int manaT;
        public int energiaT;

        // GERAL DOS MOVIMENTOS
        public bool DIREITA = true;
        public bool ESQUERDA;
        public bool AGACHADO;
        public bool ATACANDO;
        public bool PARADO;
        public bool PODER;
        public bool PULANDOparado;
        public bool PULANDOandando;
        public bool PULANDOcorrendo;
        public bool ANDANDO = true;
        public bool CORRENDO;
        public bool DEFENDENDO;
        public bool RASTEIRA;
        public bool AGARRAR;
        public bool MORRENDO;
        public bool CAIDO;
        public bool LEVANTANDO;
        public bool ATACK1;

        public bool faca_voando;
        public bool Jogar_Faca;

        //hit
        public bool TOMANDOHIT; //tomando hit
        public bool HIT1; //cabeça
        public bool HIT2; //peito
        public bool HIT3; //pernas

        public bool subindo;
        public bool descendo;

        public int Vx = 0;
        public int Vy = 0;
        public int g = 0; // gravidade

        public List<Sangue> listadesangue = new List<Sangue>();
        public List<Agua> listadeagua = new List<Agua>();
        public List<ObjLançado> listadefacas = new List<ObjLançado>();

        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)//CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)//CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)//CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        //CRIANDO NOVO INIMIGO (1)
        public void GERARi1(List<Inimigo> listai1, int WidthTela, int HeightTela, Random aleatório)
        {
            Inimigo i1 = new Inimigo(); // gera um novo
            i1.opç = aleatório.Next(1,3);
            if (i1.opç == 1)
            {
                i1.individuo = new Rectangle(Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width + Vx, HeightTela - HeightTela / 3, WidthTela / 14, HeightTela / 4);
                i1.meio = new Rectangle(i1.individuo.X + i1.individuo.Width / 4, i1.individuo.Y, i1.individuo.Width / 2, i1.individuo.Height);
                i1.DIREITA = false;
                i1.ESQUERDA = true;
            }
            else if (i1.opç == 2)
            {
                i1.individuo = new Rectangle(Contexto.Fundo.fase.X + Vx - WidthTela / 14, HeightTela - HeightTela / 3, WidthTela / 14, HeightTela / 4);
                i1.meio = new Rectangle(i1.individuo.X + i1.individuo.Width / 4, i1.individuo.Y, i1.individuo.Width / 2, i1.individuo.Height);
                i1.DIREITA = true;
                i1.ESQUERDA = false;
            }

            i1.Vx = 0;
            i1.Vy = 0;
            i1.vidaT = 100;
            i1.manaT = 20;
            i1.energiaT = 100;
            i1.vida = 100;
            
            listai1.Add(i1);
        }

        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        //POSICIONAMENTO DO INIMIGO
        public void PosiçãoINIMIGO(int WidthTela, int HeightTela)
        {
            //posição no mapa
            if (opç == 1)
            {
                individuo.X = Contexto.Fundo.fase.X + Contexto.Fundo.fase.Width + Vx;
                if (ANDANDO)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 + Vy - HeightTela / 70 - HeightTela / 60;
                if (PARADO)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 - HeightTela / 45 + Vy - HeightTela / 60; //27 = 40
                if (HIT1 || HIT2 || HIT3 || LEVANTANDO || (AGACHADO && DEFENDENDO) || (AGACHADO && !DEFENDENDO) || (DEFENDENDO && !AGACHADO))
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 - HeightTela / 45 + Vy - HeightTela / 100;
                if (Jogar_Faca)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 - HeightTela / 45 + Vy - HeightTela / 80;
                if (CAIDO)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 - HeightTela / 45 + Vy - HeightTela / 80 + HeightTela / 10;
                if (ATACK1 || AGARRAR || PODER)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 - HeightTela / 45 + Vy - HeightTela / 100;
                if (RASTEIRA)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 - HeightTela / 45 + Vy - HeightTela / 50;
                
               
            }
            else if (opç == 2)
            {
                individuo.X = Contexto.Fundo.fase.X + Vx - WidthTela / 14;
                if (ANDANDO)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 + Vy - HeightTela / 70 - HeightTela / 60;
                if (PARADO)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 - HeightTela / 45 + Vy - HeightTela / 60; //27 = 40
                if (HIT1 || HIT2 || HIT3 || LEVANTANDO || (AGACHADO && DEFENDENDO) || (AGACHADO && !DEFENDENDO) || (DEFENDENDO && !AGACHADO))
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 - HeightTela / 45 + Vy - HeightTela / 100;
                if (Jogar_Faca)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 - HeightTela / 45 + Vy - HeightTela / 80;
                if (CAIDO)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 - HeightTela / 45 + Vy - HeightTela / 80 + HeightTela / 10;
                if (ATACK1 || AGARRAR || PODER)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 - HeightTela / 45 + Vy - HeightTela / 100;
                if (RASTEIRA)
                    individuo.Y = Contexto.Fundo.fase.Y + Contexto.Fundo.fase.Height - HeightTela / 3 - HeightTela / 45 + Vy - HeightTela / 50;
            }
        }


        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        //INTELIGENCIA ARTIFICIAL
        public void INTELIGENCIA(int WidthTela, int HeightTela, Personagem P1, List<Inimigo> listai1, Random aleatório)
        {


            //INTELIGENCIA DA LUTA//INTELIGENCIA DA LUTA
            //INTELIGENCIA DA LUTA
            //INTELIGENCIA DA LUTA
            //INTELIGENCIA DA LUTA
            //INTELIGENCIA DA LUTA
            //INTELIGENCIA DA LUTA

            //INTELIGENCIA DA LUTA
            //INTELIGENCIA DA LUTA//INTELIGENCIA DA LUTA
            /*
            DIREITA;
            ESQUERDA;
            AGACHADO;
            ATACANDO;
            PARADO;
            PODER;
            PULANDOparado;
            PULANDOandando;
            PULANDOcorrendo;
            ANDANDO = true;
            CORRENDO;
            DEFENDENDO;
            RASTEIRA;
            */

            if (!TOMANDOHIT && !ATACANDO && !PODER && !RASTEIRA && !MORRENDO && !CAIDO && !LEVANTANDO && meio.Intersects(P1.DistanciadeLuta))
            {
                // SE P1 atacar de pe //caso P1 pule
                if (P1.ATACANDO && !P1.AGACHADO && P1.ATAQUELANÇADO && opçluta == 0 || (P1.PULANDOandando || P1.PULANDOparado) && opçluta == 0 || (P1.PARADO || P1.ANDANDO || P1.CORRENDO) && P1.individuo.Intersects(meio) && opçluta == 0)
                {
                    
                    opçluta = aleatório.Next(1,6);
                    
                    opç_Atk = aleatório.Next(1,3);
                    if (DIREITA)
                    {
                        frameALLi1.X = 7;
                        frameALLi1.Y = 0;
                    }
                    if (ESQUERDA)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                    }
                }

                //se p1 atacar agachado
                if (P1.ATACANDO && P1.AGACHADO && opçluta == 0)
                {
                    
                    opçluta = aleatório.Next(2,6);
                    if (DIREITA)
                    {
                        frameALLi1.X = 7;
                        frameALLi1.Y = 0;
                    }
                    if (ESQUERDA)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                    }
                }
                //qnd o P1 terminar o combo, o inimigo dá contraataque.
                if (P1.LEVARCONTRAATAQUE && opçluta == 0)
                {
                    opçluta = 1;
                    
                    opç_Atk = aleatório.Next(1,3);
                    if (DIREITA)
                    {
                        frameALLi1.X = 7;
                        frameALLi1.Y = 0;
                    }
                    if (ESQUERDA)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                    }
                }
                
                //qnd o P1 fica parado demais:
                if (P1.DefesaCONTAGEM >= 30 && opçluta == 0)
                {
                    
                    opçluta = aleatório.Next(6,8);
                    //atualizar o frame do PODER // MOVIMENTOS
                    if (DIREITA && opç != 6)
                    {
                        frameALLi1.X = 7;
                        frameALLi1.Y = 0;
                    }
                    if (ESQUERDA && opç != 6)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                    }
                    if (DIREITA && opç == 6)
                    {
                        frameALLi1.X = 7;
                        frameALLi1.Y = 0;
                    }
                    if (ESQUERDA && opç == 6)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                    }
                }
                //se defender por muito tempo
                if (P1.ParadoCONTAGEM >= 30 && opçluta == 0)
                {
                    do
                    {
                        
                        opçluta = aleatório.Next(1, 8);
                        
                        opç_Atk = aleatório.Next(1, 3);

                    } while (opçluta == 2 || opçluta == 3 || opçluta == 5); // n quero q ele def , agache, nem agache e defenda

                    //atualizar o frame do PODER // MOVIMENTOS
                    if (DIREITA && opç != 6)
                    {
                        frameALLi1.X = 7;
                        frameALLi1.Y = 0;
                    }
                    if (ESQUERDA && opç != 6)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                    }
                    if (DIREITA && opç == 6)
                    {
                        frameALLi1.X = 7;
                        frameALLi1.Y = 0;
                    }
                    if (ESQUERDA && opç == 6)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                    }
                }
                //QND ESTIVER MT TEMPO AGACHADO E DEFENDENDO
                if (P1.AgachadoDEFCONTAGEM >= 30 && opçluta == 0)
                {
                    opçluta = 7;
                    if (DIREITA )
                    {
                        frameALLi1.X = 7;
                        frameALLi1.Y = 0;
                    }
                    if (ESQUERDA)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                    }
                } 
                

                //caso P1 use poder
                if (P1.PODER && opçluta == 0)
                {
                    do
                    {
                        opçluta = aleatório.Next(2, 7);
                    } while (opçluta == 3);

                    if (DIREITA)
                    {
                        frameALLi1.X = 7;
                        frameALLi1.Y = 0;
                    }
                    if (ESQUERDA)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                    }
                }
                
                //caso pule correndo
                if (P1.PULANDOcorrendo && opçluta == 0)
                {
                   
                    opçluta = aleatório.Next(2,6);
                    if (DIREITA)
                    {
                        frameALLi1.X = 7;
                        frameALLi1.Y = 0;
                    }
                    if (ESQUERDA)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                    }
                    
                }

                //                                              #@$#%&$#@$#%&$#@$#%&$#@$#%&$#@$#%&$#@$#%&$#@$#%&$
                //ações do inimigo
                //ações do inimigo
                //ações do inimigo
                //ações do inimigo
                //ações do inimigo
                //ações do inimigo (OPÇÕES DA LUTA)
                if (opçluta == 1) //ATK
                {
                    if (!meio.Intersects(P1.individuo) && opç_Atk == 1)
                    {
                        ANDANDO = true;
                        DEFENDENDO = false;
                        AGACHADO = false;
                        PARADO = false;
                        if (meio.X < P1.individuo.X)
                        {
                            DIREITA = true;
                            ESQUERDA = false;
                        }
                        if (meio.X > P1.individuo.X)
                        {
                            ESQUERDA = true;
                            DIREITA = false;
                        }
                    }
                    if ((meio.Intersects(P1.individuo) || opç_Atk == 2) && energia >= 10 && !ATACANDO)
                    {
                        
                        //para com os basicos
                        DEFENDENDO = false;
                        ANDANDO = false;
                        PARADO = false;
                        AGACHADO = false;
                        ATACANDO = true;
                    }
                }
                if (opçluta == 2 )//DEF
                {
                    DEFENDENDO = true;
                    //para com os basicos
                    PARADO = false;
                    AGACHADO = false;
                    ANDANDO = false;
                    
                }
                if (opçluta == 3)//AGACH
                {
                    AGACHADO = true;
                    //para com os basicos
                    DEFENDENDO = false;
                    ANDANDO = false;
                    PARADO = false;
                    
                }
                if (opçluta == 4 )//RASTEIRA
                {
                    RASTEIRA = true;
                    //para com os basicos
                    DEFENDENDO = false;
                    ANDANDO = false;
                    PARADO = false;
                    AGACHADO = false;
                }
                if (opçluta == 5)//AGACH + DEF
                {
                    AGACHADO = true;
                    DEFENDENDO = true;
                    //para com os basicos
                    ANDANDO = false;
                    PARADO = false;
                }
                if (opçluta == 6 && mana >= 20)//PODER
                {
                    PODER = true;
                    //para com os basicos
                    DEFENDENDO = false;
                    ANDANDO = false;
                    PARADO = false;
                    AGACHADO = false;
                }
                if (opçluta == 7 )//AGARRAR
                {
                    if (!meio.Intersects(P1.individuo) )
                    {
                        ANDANDO = true;
                        DEFENDENDO = false;
                        AGACHADO = false;
                        if (meio.X < P1.individuo.X)
                        {
                            DIREITA = true;
                            ESQUERDA = false;
                        }
                        if (meio.X > P1.individuo.X)
                        {
                            ESQUERDA = true;
                            DIREITA = false;
                        }
                    }
                    if (meio.Intersects(P1.individuo))
                    {
                        AGARRAR = true;
                        DEFENDENDO = false;
                        ANDANDO = false;
                        PARADO = false;
                        
                    }
                    //para com os basicos
                    DEFENDENDO = false;
                    PARADO = false;
                    AGACHADO = false;
                }
                // ==== FIM DAS OPÇluta

                //AJUDA NA OPÇluta
                //caso o inimigo fique NA DIREITA ou ESQUERDA do P1
                if (meio.X < P1.individuo.X )
                {
                    DIREITA = true;
                    ESQUERDA = false;
                }
                if (meio.X > P1.individuo.X)
                {
                    ESQUERDA = true;
                    DIREITA = false; 
                } 


                //OPÇOES DE ATAQUE
                //OPÇOES DE ATAQUE
                //OPÇOES DE ATAQUE
                //OPÇOES DE ATAQUE
                if (opç_Atk == 1)
                {
                    Jogar_Faca = true;
                }
                if (opç_Atk == 2)
                {
                    ATACK1 = true;
                }



            }//FIM DAS ESCOLHAS DO INIMIGO PARA SE DEFENDER                 #@$#%&$#@$#%&$#@$#%&$#@$#%&$


            /*
            public bool DIREITA = true;
            ESQUERDA;
            AGACHADO;
            ATACANDO;
            PARADO;
            PODER;
            PULANDOparado;
            PULANDOandando;
            PULANDOcorrendo;
            ANDANDO = true;
            CORRENDO;
            DEFENDENDO;
            RASTEIRA;
            */

            //LEVANTANDO e CAIDO
            //LEVANTANDO e CAIDO//LEVANTANDO e CAIDO
            //LEVANTANDO e CAIDO
            //LEVANTANDO e CAIDO
            //LEVANTANDO e CAIDO
            //LEVANTANDO e CAIDO
            if (CAIDO)//nao recebe dano ate nao se levantar.
            {
                if (P1.PULANDOcorrendo || P1.ESQUERDA && P1.individuo.X < individuo.X || P1.DIREITA && P1.individuo.X > individuo.X || P1.AGACHADO && P1.DEFENDENDO || P1.DEFENDENDO )
                {
                    CAIDO = false;
                    LEVANTANDO = true;
                    if (DIREITA)
                    {
                        frameALLi1.X = 7;
                        frameALLi1.Y = 0;
                    }
                    if (ESQUERDA)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                    }
                }
            }




            //se nao tiver nada, ele para:
            /*
            if (!DIREITA && !ESQUERDA && !ATACANDO && !PODER && !AGACHADO && !DEFENDENDO && !TOMANDOHIT && !AGARRAR && !RASTEIRA && !ANDANDO && opçluta == 0)
            {
                PARADO = true;
            }*/
            



            //CASO NAO ENCOSTE
            //CASO NAO ENCOSTE//CASO NAO ENCOSTE
            //CASO NAO ENCOSTE
            //CASO NAO ENCOSTE
            if (!TOMANDOHIT && !meio.Intersects(P1.DistanciadeLuta) && !ATACANDO && !PODER && !AGARRAR && !RASTEIRA) // caso nao estejam tocando
            {
                if (meio.X + meio.Width < P1.meio.X && !DIREITA) //se o bot estiver na esquerda do personagem
                {
                    DIREITA = true;
                    ESQUERDA = false;
                    PARADO = false;
                    ANDANDO = true;
                    ATACANDO = false;
                    AGACHADO = false;
                    DEFENDENDO = false;


                    //frame
                    frameAndari1.X = 19;
                    frameAndari1.Y = 0;
                }
                else if (meio.X > P1.meio.X + P1.meio.Width && !ESQUERDA) //se o bot estiver na direita do personagem
                {
                    DIREITA = false;
                    ESQUERDA = true;
                    PARADO = false;
                    ANDANDO = true;
                    ATACANDO = false;
                    AGACHADO = false;
                    DEFENDENDO = false;
                        //frame
                        frameAndari1.X = 0;
                        frameAndari1.Y = 0;
                    
                }
                
            }
            //se estiver tocando
            //se estiver tocando
            //se estiver tocando
            //se estiver tocando
            if (meio.Intersects(P1.DistanciadeLuta) && !TOMANDOHIT && !ATACANDO && !DEFENDENDO && !RASTEIRA && !PODER && !AGACHADO && !AGARRAR && opçluta == 0)//se estiver tocando
            {
                PARADO = true;
                ANDANDO = false;
                DIREITA = false;
                ESQUERDA = false;
            }

            /*
            //COLISAO ENTRE ELES
            if (!TOMANDOHIT)
            {
                // formula pra colidir com os multiplicados (entre eles e contra qlq outra coisa)
                // formula pra colidir com os multiplicados (entre eles e contra qlq outra coisa)
                // formula pra colidir com os multiplicados (entre eles e contra qlq outra coisa)
                // formula pra colidir com os multiplicados (entre eles e contra qlq outra coisa)
                
                for (int atual = 0; atual < listai1.Count - 1; atual++) // formula pra colidir com os multiplicados (entre eles e contra qlq outra coisa)
                {
                    for (int outro = atual + 1; outro < listai1.Count; outro++)
                    {
                        if (listai1[atual].meio.X > P1.individuo.X && listai1[atual].meio.X < listai1[outro].meio.X && listai1[atual].meio.Intersects(listai1[outro].meio))
                        {
                            listai1[outro].PARADO = true;
                            listai1[outro].DIREITA = false;
                            listai1[outro].ESQUERDA = false;
                            listai1[outro].ANDANDO = false;

                        }
                        if (listai1[atual].meio.X < P1.individuo.X && listai1[atual].meio.X > listai1[outro].meio.X && listai1[atual].meio.Intersects(listai1[outro].meio))
                        {
                            listai1[outro].PARADO = true;
                            listai1[outro].DIREITA = false;
                            listai1[outro].ESQUERDA = false;
                            listai1[outro].ANDANDO = false;

                        }

                    }
                }//fim da colisao
                 
            }*/

            //empurrar
            //empurrar//empurrar
            //empurrar
            //empurrar
            //empurrar
            if (P1.ATACANDO)
            {
                if (P1.meio.X < meio.X && P1.individuo.Intersects(meio) && P1.PARTE3 && P1.COMBO1 && P1.DIREITA)
                {
                    Vx += HeightTela / 100;
                }
                if (P1.meio.X < meio.X && P1.individuo.Intersects(meio) && P1.PARTE4 && P1.COMBO1 && P1.DIREITA)
                {
                    Vx += HeightTela / 90;
                }

                if (P1.meio.X > meio.X && P1.individuo.Intersects(meio) && P1.PARTE3 && P1.COMBO1 && P1.ESQUERDA)
                {
                    Vx -= HeightTela / 100;
                }
                if (P1.meio.X > meio.X && P1.individuo.Intersects(meio) && P1.PARTE4 && P1.COMBO1 && P1.ESQUERDA)
                {
                    Vx -= HeightTela / 90;
                }
            }
        }

        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        //MOVIMENTAÇÃO -------------------------------------------------------------
        public void MOV(int WidthTela, int HeightTela, Random aleatório, Personagem P1)
        {
            meio.X = individuo.X + individuo.Width / 4;
            meio.Y = individuo.Y;
            meio.Width = individuo.Width / 2;
            meio.Height = individuo.Height;
            //PARADO
            //PARADO
            //PARADO
            //PARADO
            //PARADO
            //PARADO
            //PARADO
            //PARADO
            if (PARADO)//PARADO
            {
                individuo.Width = WidthTela / 10;
                individuo.Height = HeightTela / 4 + HeightTela / 27; //tamanho
                frameparadoi1.X++;
                if (frameparadoi1.X >= SpriteSheetAndari1.X)
                {
                    frameparadoi1.X = 0;
                    frameparadoi1.Y++;
                }
                if (frameparadoi1.X == 7 && frameparadoi1.Y == 9)
                {
                    frameparadoi1.X = 0;
                    frameparadoi1.Y = 0;
                }
            }
            //DIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITADIREITA
            //DIREITA
            //DIREITA
            //DIREITA
            //DIREITA
            else if (DIREITA && !ESQUERDA)//DIREITA
            {
                //ANDANDO
                //ANDANDO
                //ANDANDO
                //ANDANDO
                //ANDANDO
                //ANDANDO
                //ANDANDO
                if (ANDANDO)
                {
                    Vx += aleatório.Next(HeightTela / 300, HeightTela / 150);
                    individuo.Width = WidthTela / 14;
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                    frameAndari1.X--;
                    if (frameAndari1.X <= -1)
                    {
                        frameAndari1.X = 19;
                        frameAndari1.Y++;
                    }
                    if (frameAndari1.X == 17 && frameAndari1.Y == 3)
                    {
                        frameAndari1.X = 19;
                        frameAndari1.Y = 0;
                    }
                }
                //TOMANDO HIT
                //TOMANDO HIT
                //TOMANDO HIT//TOMANDO HIT
                //TOMANDO HIT
                //TOMANDO HIT
                //TOMANDO HIT
                if (TOMANDOHIT)
                {
                    if (HIT1)//CABEÇA
                    {
                        HIT2 = false;
                        HIT3 = false;
                        individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                        individuo.Width = WidthTela / 12;
                        frameALLi1.X--;
                        if (frameALLi1.X <= -1)
                        {
                            frameALLi1.X = 8;
                            frameALLi1.Y++;
                        }
                        if (frameALLi1.X <= 1 && frameALLi1.Y == 2)
                        {
                            HIT1 = false;
                            TOMANDOHIT = false;
                            opçluta = 0;
                        }
                    }
                    if (HIT2)//PEITO
                    {
                        HIT1 = false;
                        HIT3 = false;
                        individuo.Width = WidthTela / 10;
                        individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                        frameALLi1.X--;
                        if (frameALLi1.X <= -1)
                        {
                            frameALLi1.X = 8;
                            frameALLi1.Y++;
                        }
                        if (frameALLi1.X <= 1 && frameALLi1.Y == 2)
                        {
                            HIT2 = false;
                            TOMANDOHIT = false;
                            opçluta = 0;
                        }
                    }
                    if (HIT3)//Pernas (cair)
                    {
                        HIT1 = false;
                        HIT2 = false;
                        individuo.Width = WidthTela / 6;
                        individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                        frameALLi1.X--;
                        if (frameALLi1.X <= -1)
                        {
                            frameALLi1.X = 7;
                            frameALLi1.Y++;
                        }
                        if (frameALLi1.X <= 4 && frameALLi1.Y == 5)
                        {
                            HIT3 = false;
                            TOMANDOHIT = false;
                            CAIDO = true;
                        }
                    }
                }//fim tomando hit

                //OUTROS MOVIMENTOS
                //OUTROS MOVIMENTOS
                //OUTROS MOVIMENTOS
                //OUTROS MOVIMENTOS
                if (DEFENDENDO && !AGACHADO)
                {
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                    individuo.Width = WidthTela / 12;
                    if (frameALLi1.X <= -1)
                    {
                        frameALLi1.X = 7;
                        frameALLi1.Y++;
                    }
                    if (frameALLi1.Y < 2)
                    {
                        frameALLi1.X--;
                    }
                    if (frameALLi1.Y >= 2)
                        opçluta = 0; 
                }
                //defendendo e agachando
                if (DEFENDENDO && AGACHADO)
                {
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                    individuo.Width = WidthTela / 10;
                    if (frameALLi1.X <= -1)
                    {
                        frameALLi1.X = 7;
                        frameALLi1.Y++;
                    }
                    if (frameALLi1.Y < 2)
                    {
                        frameALLi1.X--;
                    }
                    if (frameALLi1.Y >= 2)
                        opçluta = 0; 
                }
                //agachando sem defender
                if (!DEFENDENDO && AGACHADO)
                {
                    individuo.Width = WidthTela / 12;
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                    
                    if (frameALLi1.X <= -1)
                    {
                        frameALLi1.X = 7;
                        frameALLi1.Y++;
                    }
                    if (frameALLi1.Y < 2)
                    {
                        frameALLi1.X--;
                    }
                    if (frameALLi1.Y >= 2)
                        opçluta = 0; 
                }

                //jogar faca
                if (ATACANDO)
                {
                    if (Jogar_Faca)
                    {
                        individuo.Width = WidthTela / 8;
                        individuo.Height = HeightTela / 4 + (3 * HeightTela / 70);
                        frameALLi1.X--;
                        if (frameALLi1.X <= -1)
                        {
                            frameALLi1.X = 7;
                            frameALLi1.Y++;
                        }
                        if (frameALLi1.X <= 1 && frameALLi1.Y == 7 || frameALLi1.Y > 7)
                        {
                            Jogar_Faca = false;
                            ATACANDO = false;
                            opçluta = 0;
                            opç_Atk = 0;
                        }
                        if (frameALLi1.X == 5 && frameALLi1.Y == 5)
                        {
                            faca_voando = true;
                            GerarFacas(WidthTela, HeightTela);
                        }
                    }
                    if (ATACK1)
                    {
                        individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                        individuo.Width = WidthTela / 10 - HeightTela / 200;
                        frameALLi1.X--;
                        if (frameALLi1.X <= -1)
                        {
                            frameALLi1.X = 7;
                            frameALLi1.Y++;
                        }
                        if (frameALLi1.X <= 0 && frameALLi1.Y == 3 || frameALLi1.Y > 3)
                        {
                            ATACK1 = false;
                            ATACANDO = false;
                            opçluta = 0;
                            opç_Atk = 0;
                        }
                        //SE ENCOSTAR NO INIMIGO ELE TOMA HIT
                        if (frameALLi1.X == 0 && frameALLi1.Y == 2 && (!P1.DEFENDENDO && P1.ESQUERDA || P1.DIREITA) && P1.meio.Intersects(individuo))
                        {
                            P1.vida -= 10;
                            P1.Vx += HeightTela / 100;

                            //FALTA MOSTRAR VC TOMANDO HIT
                        }
                    }//fim atack1
                }

                //APOS LEVAR HIT3
                if (CAIDO)
                {
                    individuo.Width = WidthTela / 6 + HeightTela / 70;
                    individuo.Height = HeightTela / 4 + (3 * HeightTela / 70) - HeightTela / 10;
                    frameALLi1.X--;
                    if (frameALLi1.X <= -1)
                    {
                        frameALLi1.X = 3;
                        frameALLi1.Y++;
                    }
                    if (frameALLi1.X <= 0 && frameALLi1.Y == 7)
                    {
                        frameALLi1.X = 3;
                        frameALLi1.Y = 0;
                    }
                }

                //levantar do chao
                if (LEVANTANDO)
                {
                    individuo.Width = WidthTela / 6 + HeightTela / 70;
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                    frameALLi1.X--;
                    if (frameALLi1.X <= -1)
                    {
                        frameALLi1.X = 7;
                        frameALLi1.Y++;
                    }
                    if (frameALLi1.X <= 5 && frameALLi1.Y == 6)
                    {
                        LEVANTANDO = false;
                        opçluta = 0;
                    }
                }

                //PODERRRR
                if (PODER)
                {
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                    individuo.Width = WidthTela / 10 - HeightTela / 200;
                    frameALLi1.X--;
                    if (frameALLi1.X <= -1)
                    {
                        frameALLi1.X = 9;
                        frameALLi1.Y++;
                    }
                    //criando facas
                    if (frameALLi1.X == 0 && frameALLi1.Y == 7)
                    {
                        GerarFacasPoder(WidthTela, HeightTela);
                        faca_voando = true;
                    }
                    //fim do mov poder
                    if (frameALLi1.X <= 4 && frameALLi1.Y == 12 || frameALLi1.Y > 12)
                    {
                        PODER = false;
                        opçluta = 0;
                    }
                }

                //RASTEIRAAAAAA!
                if (RASTEIRA)
                {
                    individuo.Width = WidthTela / 10 - HeightTela / 200 + HeightTela / 14;
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70) + HeightTela / 100;
                    frameALLi1.X--;
                    if (frameALLi1.X <= -1)
                    {
                        frameALLi1.X = 7;
                        frameALLi1.Y++;
                    }
                    //criando facas
                    if (frameALLi1.X <= 1 && frameALLi1.Y == 7 || frameALLi1.Y > 7)
                    {
                        RASTEIRA = false;
                        opçluta = 0;
                    }
                    //movimento
                    if (frameALLi1.X >= 1 && frameALLi1.Y < 7)
                    {
                        Vx += HeightTela / 150;
                    }
                    if (individuo.Intersects(P1.meio) && (!P1.DEFENDENDO && !P1.AGACHADO && P1.ESQUERDA) && P1.meio.X > individuo.X && frameALLi1.Y >= 2 && frameALLi1.Y <= 5)
                    {
                        P1.vida -= 1;
                    }
                    //falta fz P1 cair (hit)
                }

                //AGARRAR
                if (AGARRAR)
                {
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                    individuo.Width = WidthTela / 10 + HeightTela / 27;
                    frameALLi1.X--;
                    if (frameALLi1.X <= -1)
                    {
                        frameALLi1.X = 7;
                        frameALLi1.Y++;
                    }
                    //se agarrar
                    if (P1.meio.Intersects(individuo) && P1.meio.X > individuo.X && frameALLi1.Y >= 3 && frameALLi1.Y < 12)
                    {
                        P1.Vx = 0;
                        P1.Vy = 0;
                        P1.SENDOAGARRADO = true;
                    }
                    //TOMANDO HIT (qnd FOR PEGO e esteja em TAL FRAME)
                    if (frameALLi1.X == 6 && P1.meio.X > individuo.X && frameALLi1.Y == 5 && P1.meio.Intersects(individuo))
                    {
                        P1.vida -= 10;
                    }
                    if (frameALLi1.Y == 10 && P1.meio.X > individuo.X && P1.meio.Intersects(individuo))
                    {
                        P1.vida -= 2;
                    }
                    //fim do agarrar
                    if (frameALLi1.X <= 3 && frameALLi1.Y == 12 || frameALLi1.Y > 12)
                    {
                        AGARRAR = false;
                        opçluta = 0;
                        P1.SENDOAGARRADO = false;
                    }
                }
            }//fim direita


            //ESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDAESQUERDA
            //ESQUERDA
            //ESQUERDA
            //ESQUERDA
            //ESQUERDA
            else if (!DIREITA && ESQUERDA)//ESQUERDA
            {
                //ANDANDO
                //ANDANDO
                //ANDANDO
                //ANDANDO
                //ANDANDO
                //ANDANDO
                if (ANDANDO)
                {
                    Vx -= aleatório.Next(HeightTela / 140, HeightTela / 130);
                    individuo.Width = WidthTela / 14;
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                    frameAndari1.X++;
                    if (frameAndari1.X >= SpriteSheetAndari1.X)
                    {
                        frameAndari1.X = 0;
                        frameAndari1.Y++;
                    }
                    if (frameAndari1.X == 2 && frameAndari1.Y == 3)
                    {
                        frameAndari1.X = 0;
                        frameAndari1.Y = 0;
                    }
                }
                //TOMANDO HIT
                //TOMANDO HIT
                //TOMANDO HIT
                //TOMANDO HIT
                //TOMANDO HIT
                if (TOMANDOHIT)
                {
                   
                    if (HIT1)//CABEÇA
                    {
                        individuo.Width = WidthTela / 12;
                        individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                        frameALLi1.X++;
                        if (frameALLi1.X >= SpriteSheetHit1i1.X)
                        {
                            frameALLi1.X = 0;
                            frameALLi1.Y++;
                        }
                        if (frameALLi1.X >= 6 && frameALLi1.Y == 2 || frameALLi1.Y > 2)
                        {
                            HIT1 = false;
                            TOMANDOHIT = false;
                        }
                    }
                    if (HIT2)//PEITO
                    {
                        individuo.Width = WidthTela / 10;
                        individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                        frameALLi1.X++;
                        if (frameALLi1.X >= SpriteSheetHit2i1.X)
                        {
                            frameALLi1.X = 0;
                            frameALLi1.Y++;
                        }
                        if (frameALLi1.X >= 6 && frameALLi1.Y == 2 || frameALLi1.Y > 2)
                        {
                            HIT2 = false;
                            TOMANDOHIT = false;
                        }
                    }
                    if (HIT3)//Pernas (cair)
                    {
                        individuo.Width = WidthTela / 10 + HeightTela / 9;//(+120)
                        individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                        frameALLi1.X++;
                        if (frameALLi1.X >= SpriteSheetHit3i1.X)
                        {
                            frameALLi1.X = 0;
                            frameALLi1.Y++;
                        }
                        if (frameALLi1.X >= 3 && frameALLi1.Y == 5 || frameALLi1.Y > 5)
                        {
                            HIT3 = false;
                            TOMANDOHIT = false;
                            CAIDO = true;
                        }
                    }
                }

                //OUTROS MOVIMENTOS
                //OUTROS MOVIMENTOS
                //OUTROS MOVIMENTOS
                //OUTROS MOVIMENTOS
                //OUTROS MOVIMENTOS
                //ñ agachar e defender
                if (DEFENDENDO && !AGACHADO)
                {
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                    individuo.Width = WidthTela / 12;
                    
                    if (frameALLi1.X >= SpriteSheetDEFi1.X)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y++;
                    }
                    if (frameALLi1.Y < 2)
                    {
                        frameALLi1.X++;
                    }
                    if (frameALLi1.Y >= 2)
                        opçluta = 0; 
                }
                //agachando e defedendo
                if (DEFENDENDO && AGACHADO)
                {
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                    individuo.Width = WidthTela / 10;
                    if (frameALLi1.X >= SpriteSheetAgacharDEFi1.X)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y++;
                    }
                    if (frameALLi1.Y < 2)
                    {
                        frameALLi1.X++;
                    }
                    if (frameALLi1.Y >= 2)
                        opçluta = 0; 
                }

                //agachando e sem defeder
                if (!DEFENDENDO && AGACHADO)
                {
                    individuo.Width = WidthTela / 12;
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                    if (frameALLi1.X >= SpriteSheetAgachari1.X)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y++;
                    }
                    if (frameALLi1.Y < 2)
                    {
                        frameALLi1.X++;
                    }
                    if (frameALLi1.Y >= 2)
                        opçluta = 0; 
                }

                //ATACANDOoooooooooooooooo
                if (ATACANDO)
                {
                    if (Jogar_Faca)
                    {
                        individuo.Width = WidthTela / 8;
                        individuo.Height = HeightTela / 4 + (3 * HeightTela / 70);
                        frameALLi1.X++;
                        if (frameALLi1.X >= SpriteSheetJogarFacai1.X)
                        {
                            frameALLi1.X = 0;
                            frameALLi1.Y++;
                        }
                        if (frameALLi1.X >= 6 && frameALLi1.Y == 7 || frameALLi1.Y > 7)
                        {
                            Jogar_Faca = false;
                            ATACANDO = false;
                            opçluta = 0;
                            opç_Atk = 0;
                        }
                        if (frameALLi1.X == 2 && frameALLi1.Y == 5 )
                        {
                            faca_voando = true;
                            GerarFacas(WidthTela, HeightTela);
                        }
                    }//fim do jogar faca

                    if (ATACK1)
                    {
                        individuo.Width = WidthTela / 10 - HeightTela / 200;
                        individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                        frameALLi1.X++;
                        if (frameALLi1.X >= SpriteSheetATK1i1.X)
                        {
                            frameALLi1.X = 0;
                            frameALLi1.Y++;
                        }
                        if (frameALLi1.X >= 7 && frameALLi1.Y == 3 || frameALLi1.Y > 3)
                        {
                            ATACK1 = false;
                            ATACANDO = false;
                            opçluta = 0;
                            opç_Atk = 0;
                        }
                        //SE ENCOSTAR NO INIMIGO ELE TOMA HIT
                        if (frameALLi1.X == 7 && frameALLi1.Y == 2 && (!P1.DEFENDENDO && P1.DIREITA || P1.ESQUERDA) && P1.meio.Intersects(individuo))
                        {
                            P1.vida -= 10;
                            P1.Vx -= HeightTela / 100;
                        }
                    }//fim atack1
                }

                //APOS LEVAR HIT3
                if (CAIDO)
                {
                    individuo.Height = HeightTela / 4 + (3 * HeightTela / 70) - HeightTela / 10;
                    individuo.Width = WidthTela / 6 + HeightTela / 70;
                    frameALLi1.X++;
                    if (frameALLi1.X >= SpriteSheetCaidoi1.X)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y++;
                    }
                    if (frameALLi1.X >= 3 && frameALLi1.Y == 7)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                    }
                }

                //levantar do chao
                if (LEVANTANDO)
                {
                    individuo.Width = WidthTela / 6 + HeightTela / 70;
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                    frameALLi1.X++;
                    if (frameALLi1.X >= SpriteSheetLevantari1.X)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y++;
                    }
                    if (frameALLi1.X >= 2 && frameALLi1.Y == 6 || frameALLi1.Y > 6)
                    {
                        LEVANTANDO = false;
                        opçluta = 0;
                    }
                }

                //PODERRRR
                if (PODER)
                {
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                    individuo.Width = WidthTela / 10 - HeightTela / 200;
                    frameALLi1.X++;
                    if (frameALLi1.X >= SpriteSheetPODERi1.X)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y++;
                    }
                    //criando facas
                    if (frameALLi1.X == 9 && frameALLi1.Y == 7)
                    {
                        GerarFacasPoder(WidthTela, HeightTela);
                        faca_voando = true;
                    }
                    //fim do mov poder
                    if (frameALLi1.X >= 5 && frameALLi1.Y == 12 || frameALLi1.Y > 12)
                    {
                        PODER = false;
                        opçluta = 0;
                    }
                }

                //RASTEIRAAAAAA!
                if (RASTEIRA)
                {
                    individuo.Width = WidthTela / 10 - HeightTela / 200 + HeightTela / 14;
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70) + HeightTela / 100;
                    frameALLi1.X++;
                    if (frameALLi1.X >= SpriteSheetRasteirai1.X)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y++;
                    }
                    //criando facas
                    if (frameALLi1.X >= 6 && frameALLi1.Y == 7 || frameALLi1.Y > 7)
                    {
                        RASTEIRA = false;
                        opçluta = 0;
                    }
                    if (frameALLi1.X >= 1 && frameALLi1.Y < 7)
                    {
                        Vx -= HeightTela / 150;
                    }
                    if (individuo.Intersects(P1.meio) && (!P1.DEFENDENDO && !P1.AGACHADO && P1.DIREITA) && P1.meio.X < individuo.X && frameALLi1.Y >= 2 && frameALLi1.Y <= 5)
                    {
                        P1.vida -= 1;
                    }
                    //falta fz P1 cair (hit)
                }

                //AGARRAR
                if (AGARRAR)
                {
                    individuo.Height = HeightTela / 4 + (2 * HeightTela / 70);
                    individuo.Width = WidthTela / 10 + HeightTela / 27;
                    frameALLi1.X++;
                    if (frameALLi1.X >= SpriteSheetAgarrari1.X)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y++;
                    }
                    //se agarrar
                    if (P1.meio.Intersects(individuo) && P1.meio.X < individuo.X && frameALLi1.Y >= 3 && frameALLi1.Y < 12)
                    {
                        P1.Vx = 0;
                        P1.Vy = 0;
                        P1.SENDOAGARRADO = true;
                    }
                    //TOMANDO HIT (qnd FOR PEGO e esteja em TAL FRAME)
                    if (frameALLi1.X == 2 && P1.meio.X < individuo.X && frameALLi1.Y == 5 && P1.meio.Intersects(individuo))
                    {
                        P1.vida -= 10;
                    }
                    if (frameALLi1.Y == 10 && P1.meio.X < individuo.X && P1.meio.Intersects(individuo))
                    {
                        P1.vida -= 2;
                    }
                    //fim do agarrar
                    if (frameALLi1.X >= 4 && frameALLi1.Y == 12 || frameALLi1.Y > 12)
                    {
                        AGARRAR = false;
                        opçluta = 0;
                        P1.SENDOAGARRADO = false;
                    }
                }
            }//fim da esquerda
            
            

            //SPRITESHEET DA FACA
            //SPRITESHEET DA FACA
            //SPRITESHEET DA FACA
            //SPRITESHEET DA FACA
            //SPRITESHEET DA FACA
            if (faca_voando)
            {
                for (int i = 0; i < listadefacas.Count; i++)
                {
                    if (listadefacas[i].esquerda)
                    {
                        listadefacas[i].frameFACA.X++;
                        if (listadefacas[i].frameFACA.X >= listadefacas[i].SpriteSheetFacai1.X)
                        {
                            listadefacas[i].frameFACA.X = 0;
                            listadefacas[i].frameFACA.Y++;
                        }
                        if ( listadefacas[i].frameFACA.X == 2 &&  listadefacas[i].frameFACA.Y == 2)
                        {
                            listadefacas[i].frameFACA.X = 0;
                            listadefacas[i].frameFACA.Y = 0;
                        }
                    }

                    if (listadefacas[i].direita)
                    {
                        listadefacas[i].frameFACA.X--;
                        if (listadefacas[i].frameFACA.X <= -1)
                        {
                            listadefacas[i].frameFACA.X = 7;
                            listadefacas[i].frameFACA.Y++;
                        }
                        if (listadefacas[i].frameFACA.X == 5 && listadefacas[i].frameFACA.Y == 2)
                        {
                            listadefacas[i].frameFACA.X = 7;
                            listadefacas[i].frameFACA.Y = 0;
                        }
                    }
                }

                //POSIÇÃO DA FACA // OUTRO OBJETO
                //POSIÇÃO DA FACA // OUTRO OBJETO
                //POSIÇÃO DA FACA // OUTRO OBJETO
                //POSIÇÃO DA FACA // OUTRO OBJETO
                PosiçãoOBJLançado(WidthTela, HeightTela, P1);
            }
        }//fim do MOV (que recebe o SLOW MOTION)




        //HP
        //HP
        //HP
        //HP
        //HP
        //HP
        //HP
        //HP
        //HP
        //HP
        public void HP(int WidthTela, int HeightTela, List<Inimigo> listai1, Personagem P1)
        {
            VIDA.Width = (int)(((float)(vida) / vidaT) * individuo.Width);

            VIDA.X = individuo.X;
            VIDA.Height = HeightTela / 30;
            VIDA.Y = individuo.Y - HeightTela / 30;

            MANA.Width = (int)(((float)(mana) / manaT) * individuo.Width);

            MANA.X = individuo.X;
            MANA.Height = HeightTela / 30;
            MANA.Y = individuo.Y - HeightTela / 30;

            ENERGIA.Width = (int)(((float)(energia) / energiaT) * individuo.Width);

            ENERGIA.X = individuo.X;
            ENERGIA.Height = HeightTela / 30;
            ENERGIA.Y = individuo.Y - HeightTela / 30;

            
            if (mana < manaT)
            {
                mana++;
            }
            if (energia < energiaT)
            {
                energia++;
            }

            for (int i = 0; i < listai1.Count; i++)
            {
                if (listai1[i].vida <= 0)
                {
                    listai1.Remove(listai1[i]);
                    P1.XP += 10;
                }
            }
        }

        //FACA CAINDO DO CEU = > PODER
        //FACA CAINDO DO CEU = > PODER
        //FACA CAINDO DO CEU = > PODER
        //FACA CAINDO DO CEU = > PODER
        //FACA CAINDO DO CEU = > PODER
        public void GerarFacasPoder(int WidthTela, int HeightTela)
        {
            for (int i = 0; i < 4; i++)
            {
                ObjLançado O1 = new ObjLançado();

                //tamanho
                O1.OBJ.Width = HeightTela / 8;
                O1.OBJ.Height = HeightTela / 8;
                if (DIREITA)
                {
                    O1.OBJ.X = individuo.X + individuo.Width + (i * HeightTela / 8); //para que elas estejam uma do lado da outra
                    O1.PosX = individuo.X + individuo.Width + (i * HeightTela / 8) + (-Contexto.Fundo.fase.X); // posiçao do jogar + a posição mapa = posição universal
                    O1.direita = true;

                    //frames da faca
                    O1.frameFACA.X = 7;
                    O1.Vx = 0;//velocidade inicial
                }
                if (ESQUERDA)
                {
                    O1.OBJ.X = individuo.X - (i * HeightTela / 8); //para que estejam uma atras da outra
                    O1.PosX = individuo.X + (-Contexto.Fundo.fase.X) - O1.OBJ.Width - (i * HeightTela / 8); // posiçao do jogar + a posição mapa = posição universal
                    O1.esquerda = true;

                    //frames da faca
                    O1.frameFACA.X = 0;
                    O1.Vx = 0;//velocidade inicial
                }

                O1.Vy = 0;

                O1.PosY = 0 - HeightTela / 8 +(-Contexto.Fundo.fase.Y); // elas começam dentro do ceu e vai caindo

                O1.CAINDO = true;

                //colocar na lista de faca, caso seja faca.
                listadefacas.Add(O1);
            }

        }


        //NOVA FACA
        //NOVA FACA
        //NOVA FACA
        //NOVA FACA
        //NOVA FACA
        //NOVA FACA
        public void GerarFacas(int WidthTela, int HeightTela)
        {
            ObjLançado O1 = new ObjLançado();
            
            //tamanho
            O1.OBJ.Width = HeightTela / 10;
            O1.OBJ.Height = HeightTela / 10;
            if (DIREITA)
            {
                O1.OBJ.X = individuo.X + individuo.Width;
                O1.PosX = individuo.X + individuo.Width + (-Contexto.Fundo.fase.X); // posiçao do jogar + a posição mapa = posição universal
                O1.direita = true;

                //frames da faca
                O1.frameFACA.X = 7;
                O1.Vx = 0;//velocidade inicial
            }
            if (ESQUERDA)
            {
                O1.OBJ.X = individuo.X;
                O1.PosX = individuo.X + (-Contexto.Fundo.fase.X) - O1.OBJ.Width; // posiçao do jogar + a posição mapa = posição universal
                O1.esquerda = true;

                //frames da faca
                O1.frameFACA.X = 0;
                O1.Vx = 0;//velocidade inicial
            }

            O1.Vy = 0;
            
            O1.PosY = individuo.Y + individuo.Height / 2 - O1.OBJ.Height + (-Contexto.Fundo.fase.Y);

            

            //colocar na lista de faca, caso seja faca.
            listadefacas.Add(O1);

            
        }
        //posição da faca
        //posição da faca
        //posição da faca
        //posição da faca
        //posição da faca

        //posição da faca
        public void PosiçãoOBJLançado(int WidthTela, int HeightTela, Personagem P1)
        {
            //posição da faca
            if (listadefacas.Count > 0)
            {

                for (int i = 0; i < listadefacas.Count; i++)
                {
                    if (!listadefacas[i].CAINDO)
                    {
                        listadefacas[i].OBJ.X = listadefacas[i].PosX + Contexto.Fundo.fase.X + listadefacas[i].Vx; // posição definida (não variável)
                        listadefacas[i].OBJ.Y = listadefacas[i].PosY + Contexto.Fundo.fase.Y + listadefacas[i].Vy;

                        if (listadefacas[i].esquerda)
                        {
                            listadefacas[i].Vx -= HeightTela / 120;
                        }
                        if (listadefacas[i].direita)
                        {
                            listadefacas[i].Vx += HeightTela / 120;
                        }
                        listadefacas[i].Vy += HeightTela / 200;

                        if (P1.meio.Intersects(listadefacas[i].OBJ))
                        {
                            P1.vida -= HeightTela / 70; //(15 de vida)
                            listadefacas.Remove(listadefacas[i]);
                        }
                    }
                }


                for (int i = 0; i < listadefacas.Count; i++)
                {
                    if (listadefacas[i].CAINDO)
                    {
                        listadefacas[i].OBJ.X = listadefacas[i].PosX + Contexto.Fundo.fase.X + listadefacas[i].Vx; // posição definida (não variável)
                        listadefacas[i].OBJ.Y = listadefacas[i].PosY + Contexto.Fundo.fase.Y + listadefacas[i].Vy;

                        listadefacas[i].Vy += HeightTela / 100;

                        if (P1.meio.Intersects(listadefacas[i].OBJ))
                        {
                            P1.vida -= HeightTela / 70; //(15 de vida)
                            listadefacas.Remove(listadefacas[i]);
                        }
                    }

                }
                
            }
            if (listadefacas.Count == 0)
            {
                faca_voando = false;
            }
        }
        
        //AGUA]
        //AGUA
        //AGUA
        //AGUA
        //AGUA
        //AGUA
        //AGUA
        //AGUA
        public void SubirAgua(int WidthTela, int HeightTela, Random aleatório, bool fase1)
        {
            if (fase1)
            {
                if ((ANDANDO || CORRENDO || ATACANDO))
                {
                    Agua A1 = new Agua();


                    A1.AguaR.Width = HeightTela / 70;
                    A1.AguaR.Height = HeightTela / 70;
                    if (DIREITA)
                    {
                        A1.AguaR.X = individuo.X + individuo.Width;
                        A1.Px = individuo.X + individuo.Width + (-Contexto.Fundo.fase.X); // posiçao do jogar + a posição mapa = posição universal
                        A1.direita = true;
                    }
                    if (ESQUERDA)
                    {
                        A1.AguaR.X = individuo.X ;
                        A1.Px = individuo.X + (-Contexto.Fundo.fase.X); // posiçao do jogar + a posição mapa = posição universal
                        A1.esquerda = true;
                    }
                    A1.Py = individuo.Y + individuo.Height - HeightTela / 70 + (-Contexto.Fundo.fase.Y);
                    A1.g = 0;

                    listadeagua.Add(A1);
                }//fim da criação

                if (listadeagua.Count >= 0)
                {
                    for (int i = 0; i < listadeagua.Count; i++)
                    {
                        listadeagua[i].AguaR.X = listadeagua[i].Px + Contexto.Fundo.fase.X + listadeagua[i].Vx; // posição definida (não variável)
                        listadeagua[i].AguaR.Y = listadeagua[i].Py + Contexto.Fundo.fase.Y + listadeagua[i].g + listadeagua[i].Vy;

                        //velocidade gravidade
                        listadeagua[i].g += HeightTela / 300; // pra baixo

                        if (listadeagua[i].Vy == 0)
                        {
                            listadeagua[i].Vy = aleatório.Next(-HeightTela / 20, -HeightTela / 100); // pra cima
                        }
                        if (listadeagua[i].esquerda)
                        {
                            listadeagua[i].Vx += aleatório.Next(HeightTela / 200, HeightTela / 150); // para os lados
                        }
                        if (listadeagua[i].direita)
                        {
                            listadeagua[i].Vx -= aleatório.Next(HeightTela / 200, HeightTela / 150);
                        }

                        if (listadeagua[i].AguaR.Intersects(Contexto.Fundo.chao))
                        {
                            listadeagua.Remove(listadeagua[i]);
                        }
                    }//fim do array

                }//fim da mov
            }//fim da fase 1
        }//fim





        //SANGRAR
        //SANGRAR
        //SANGRAR
        //SANGRAR
        //SANGRAR
        //SANGRAR
        //SANGRAR
        //SANGRAR
        public void Sangrar(int WidthTela, int HeightTela,Personagem P1, Random aleatório)
        {
            //sangra apenas se acertar no inimigo E quando acertar, se nao defender
            if (P1.individuo.Intersects(meio) && P1.ATACANDO && (P1.individuo.X < individuo.X && P1.DIREITA || P1.individuo.X > individuo.X && P1.ESQUERDA) && !DEFENDENDO)
            {
                if ((P1.DIREITA && ((P1.PARTE1 && P1.frameLUTA.Y >= 1) || (P1.PARTE2 && (P1.frameLUTA.X >= 5 && P1.frameLUTA.Y == 2) || P1.frameLUTA.Y >= 2) || (P1.PARTE3 && (P1.frameLUTA.X >= 4 && P1.frameLUTA.Y == 3) || P1.frameLUTA.Y == 4) || (P1.PARTE4 && P1.frameLUTA.Y >= 3))) || (P1.ESQUERDA && ((P1.PARTE1 && P1.frameLUTA.Y >= 1) || (P1.PARTE2 && (P1.frameLUTA.X <= 2 && P1.frameLUTA.Y == 2) || P1.frameLUTA.Y >= 2) || (P1.PARTE3 && (P1.frameLUTA.X <= 3 && P1.frameLUTA.Y == 3) || P1.frameLUTA.Y == 4) || (P1.PARTE4 && P1.frameLUTA.Y >= 3))))
                {//para sangrar / tomar dano apenas qnd estiver em tal parte do ataque
                    Sangue S1 = new Sangue();



                    S1.sangueR.Width = HeightTela / 100;
                    S1.sangueR.Height = HeightTela / 100;
                    if (P1.PARTE4 && P1.COMBO1)
                    {
                        S1.Vx = individuo.X + individuo.Width / 2 + (-Contexto.Fundo.fase.X); // posiçao do jogar + a posição mapa = posição universal
                        S1.Vy = P1.individuo.Y + P1.individuo.Height / 2 + (-Contexto.Fundo.fase.Y);
                    }
                    if ((P1.PARTE2 || P1.PARTE3) && P1.COMBO1)
                    {
                        S1.Vx = individuo.X + individuo.Width / 2 + (-Contexto.Fundo.fase.X); // posiçao do jogar + a posição mapa = posição universal
                        S1.Vy = P1.individuo.Y + P1.individuo.Height / 3 + (-Contexto.Fundo.fase.Y);
                    }
                    if (P1.PARTE1)
                    {
                        S1.Vx = individuo.X + individuo.Width / 2 + (-Contexto.Fundo.fase.X); // posiçao do jogar + a posição mapa = posição universal
                        S1.Vy = P1.individuo.Y + P1.individuo.Height / 3 + (-Contexto.Fundo.fase.Y);
                    }
                    S1.g = 0;

                    listadesangue.Add(S1);
                }
            }//fim da criação de sangue (SANGRAR)

            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            //RECEBENDO ATAQUE
            if (P1.individuo.Intersects(meio) && P1.ATACANDO && (P1.individuo.X < individuo.X && P1.DIREITA || P1.individuo.X > individuo.X && P1.ESQUERDA) && !CAIDO)
            {
                //COMBO1
                //COMBO1
                //COMBO1
                //COMBO1
                if (((P1.DIREITA && (P1.PARTE1 && P1.frameLUTA.Y == 1 && P1.frameLUTA.X == 1) && (!DEFENDENDO && ESQUERDA)) || (P1.ESQUERDA && (P1.PARTE1 && P1.frameLUTA.Y >= 1 && P1.frameLUTA.X == 6) && (!DEFENDENDO && DIREITA))) && !P1.INVERSO && !AGACHADO && !RASTEIRA)
                {//para sangrar / tomar dano apenas qnd estiver em tal parte do ataque
                    vida-= 10;
                    HIT1 = true;
                    TOMANDOHIT = true;
                    PARADO = false;
                    ANDANDO = false;
                    ATACANDO = false;
                    ATACK1 = false;
                    AGARRAR = false;
                    PODER = false;
                    if (P1.DIREITA)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                        ESQUERDA = true;
                    }
                    if (P1.ESQUERDA)
                    {
                        frameALLi1.X = 8;
                        frameALLi1.Y = 0;
                        DIREITA = true;
                    }
                }
                if (((P1.DIREITA && (P1.PARTE2 && P1.frameLUTA.X == 4 && P1.frameLUTA.Y == 2) && (!DEFENDENDO && ESQUERDA)) || P1.ESQUERDA && (P1.PARTE2 && P1.frameLUTA.X == 2 && P1.frameLUTA.Y == 2) && (!DEFENDENDO && DIREITA)) && P1.COMBO1 && !AGACHADO && !RASTEIRA)
                {
                    vida -= 20;
                    HIT1 = true;
                    TOMANDOHIT = true;

                    PARADO = false;
                    ANDANDO = false;
                    ATACANDO = false;
                    Jogar_Faca = false;
                    ATACK1 = false;
                    AGARRAR = false;
                    PODER = false;
                    if (P1.DIREITA)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                        ESQUERDA = true;
                    }
                    if (P1.ESQUERDA)
                    {
                        frameALLi1.X = 8;
                        frameALLi1.Y = 0;
                        DIREITA = true;
                    }

                }
                if ((P1.DIREITA && (P1.PARTE3 && P1.frameLUTA.X == 4 && P1.frameLUTA.Y == 3) && (!DEFENDENDO && ESQUERDA) || P1.ESQUERDA && (P1.PARTE3 && (P1.frameLUTA.X == 3 && P1.frameLUTA.Y == 3) && (!DEFENDENDO && DIREITA))) && P1.COMBO1 && !RASTEIRA)
                {
                    vida -= 30;
                    HIT2 = true;
                    TOMANDOHIT = true;

                    PARADO = false;
                    ANDANDO = false;
                    ATACANDO = false;
                    AGACHADO = false;
                    ATACK1 = false;
                    AGARRAR = false;
                    PODER = false;
                    if (P1.DIREITA)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                        ESQUERDA = true;
                    }
                    if (P1.ESQUERDA)
                    {
                        frameALLi1.X = 8;
                        frameALLi1.Y = 0;
                        DIREITA = true;
                    }
                }
                if ((P1.DIREITA && P1.PARTE4 && P1.frameLUTA.Y == 4 && P1.frameLUTA.X == 0 && (!DEFENDENDO && ESQUERDA) || P1.ESQUERDA && P1.PARTE4 && P1.frameLUTA.Y == 4 && P1.frameLUTA.X == 7 && (!DEFENDENDO && DIREITA)) && P1.COMBO1 && !RASTEIRA)
                {
                    vida -= 30;
                    HIT2 = true;
                    TOMANDOHIT = true;

                    PARADO = false;
                    ANDANDO = false;
                    ATACANDO = false;
                    AGACHADO = false;
                    ATACK1 = false;
                    AGARRAR = false;
                    PODER = false;
                    if (P1.DIREITA)
                    {
                        frameALLi1.X = 0;
                        frameALLi1.Y = 0;
                        ESQUERDA = true;
                    }
                    if (P1.ESQUERDA)
                    {
                        frameALLi1.X = 8;
                        frameALLi1.Y = 0;
                        DIREITA = true;
                    }
                }
                //
            }

            if (listadesangue.Count > 0) // se nao for nulo a qntdd
            {
                for (int i = 0; i < listadesangue.Count; i++)
                {
                    
                    listadesangue[i].sangueR.X = listadesangue[i].Vx + Contexto.Fundo.fase.X + listadesangue[i].VariavelX; // posição definida (não variável)
                    listadesangue[i].sangueR.Y = listadesangue[i].Vy + Contexto.Fundo.fase.Y + listadesangue[i].g;
                    //velocidade gravidade
                    listadesangue[i].g += aleatório.Next(HeightTela / 250, HeightTela / 100);
                    
                        //direita ou esquerda
                        if (P1.individuo.Intersects(meio)  && P1.individuo.X < individuo.X && P1.DIREITA)
                        {
                            listadesangue[i].VariavelX += aleatório.Next(HeightTela / 300, HeightTela / 50);
                        }
                        if (P1.individuo.Intersects(meio) && P1.individuo.X > individuo.X && P1.ESQUERDA)
                        {
                            listadesangue[i].VariavelX -= aleatório.Next(HeightTela / 300, HeightTela / 50);
                        }

                        if (listadesangue[i].sangueR.Intersects(Contexto.Fundo.chao) || listadesangue[i].sangueR.Y > Contexto.Fundo.chao.Y + Contexto.Fundo.chao.Height)
                        {
                            listadesangue.Remove(listadesangue[i]);
                        }
                   
                }
            }
        }


    }

   
}
