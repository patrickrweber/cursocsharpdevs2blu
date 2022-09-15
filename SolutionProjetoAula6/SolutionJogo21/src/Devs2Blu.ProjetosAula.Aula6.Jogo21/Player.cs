using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Aula6.Jogo21
{
    public class Player
    {
        public int Number { get; set; }
        public int Score { get; set; }

        public Player()
        {

        }
        public Player(int number, int score)
        {
            Number = number;
            Score = score;
        }
        public int CalcularPontos(int numero, int numAleatorio)
        {
            numero += numAleatorio;
            int pontos = 0;

            switch (numero)
            {
                case 7:
                    pontos = 10;
                    break;
                case 14:
                    pontos = 10;
                    break;
                case 21:
                    pontos = 30;
                    break;
            }
            if (numero >= 1 && numero <= 6)
            {
                pontos = 1;
            }
            else if (numero >= 8 && numero <= 13)
            {
                pontos = 5;
            }
            else if (numero >= 15 && numero <= 20)
            {
                pontos = 6;
            }
            else if (numero > 21)
            {
                pontos = 0;
            }
            return pontos;
        }
    }
}
