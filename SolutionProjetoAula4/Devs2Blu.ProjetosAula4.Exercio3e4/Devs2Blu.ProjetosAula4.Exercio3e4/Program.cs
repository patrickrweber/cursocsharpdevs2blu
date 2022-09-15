using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula4.Exercio3e4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Random rd = new Random();
            numero = rd.Next(1, 1000);

            Console.WriteLine($"*** Número sorteado: {numero} ***");

            if(numero % 2 != 0)
            {
                Console.WriteLine($"O número {numero} é ímpar!");
            }
            else
            {
                Console.WriteLine($"O número {numero} é par!");
            }

            Console.ReadLine();
        }
    }
}
