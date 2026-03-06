using SistemaPesonagensRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPesonagensRPG
{
    #region Atributos
    public class Personagens
    {
        private string _nome;
        private int _pontosVida;
        private int _nivel;
        private int _experiencia;
        private int _poderAtaque;


        #endregion

        #region Construtor
        public Personagens(string nome, int poderAtaque)
        {
            Nome = nome;
            PontosVida = 100;
            Nivel = 1;
            Experiencia = 0;
            PoderAtaque = poderAtaque;
        }


        #endregion

        #region Propriedades

        public string Nome { get; private set; }
        public int PontosVida
        {
            get { return _pontosVida; }
            private set
            {
                if (value <= 0)
                {
                    _pontosVida = 0;
                }
                if (value > 100)
                {
                    _pontosVida = 100;
                }
                else
                {
                    _pontosVida = value;
                }
            }
        }
        public int Experiencia { get; private set; }

        public int Nivel { get; private set; }
        public int PoderAtaque { get; private set; }


        #endregion

        #region Métodos

        public void Atacar(Personagens alvo)
        {
            if(PontosVida > 0)
            {
                alvo.ReceberDano(PoderAtaque);
            }
            else
            {
                Console.WriteLine("Ação Indisponível, o personagem alvo está morto.");
            }
        }




        public void Curar(int quantidade)
        {
            if (PontosVida == 0)
            {
                Console.WriteLine("O personagem já foi derrotado e não pode ser curado.");
                return;
            }
            else if (PontosVida > 0)
            {
                PontosVida += quantidade;
                Console.WriteLine($"O personagem {Nome} foi curado em {quantidade} pontos de vida. Pontos de vida atuais: {PontosVida}");
            }
        }

        public void ReceberDano(int dano)
        {
            if (PontosVida <= 0)
            {
                
                Console.WriteLine("Personagem foi derrotado!");
                return;
            }
            else if (PontosVida > 0)
            {
                PontosVida -= dano;
                if(PontosVida <= 0)
                {
                    PontosVida = 0;
                }
                Console.WriteLine($"{Nome} sofreu {dano} de dano! || Vida restante: {PontosVida}/100");
            }
        }

        public void GanharExperiencia(int xp)
        {
            if (xp < 0)
            {
                Console.WriteLine("Quantidade de XP inválida");
            }
                Experiencia += xp;
                Console.WriteLine($"{Nome} ganhou {xp} XP. Experiência atual: {Experiencia}");

              
            while (Experiencia >= 100)
            {
                Nivel++;
                Experiencia -= 100;
                PontosVida = 100;
                PoderAtaque += 5;

                Console.WriteLine($"PARABÉNS!!! O {Nome} SUBIU PARA O NÍVEL {Nivel}!");
       

            }
        }


    }
        #endregion
}
