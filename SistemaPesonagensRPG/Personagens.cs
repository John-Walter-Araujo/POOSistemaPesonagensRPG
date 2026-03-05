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
                if (value < 0)
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
        public void Curar(int quantidade)
        {
            if(PontosVida == 0)
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
        #endregion
    }
}