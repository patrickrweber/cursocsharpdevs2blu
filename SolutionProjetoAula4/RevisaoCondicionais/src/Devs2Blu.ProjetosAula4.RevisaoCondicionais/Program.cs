using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula4.RevisaoCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao = 0;

            Console.WriteLine("**** Seja bem vindo ao programa! ****\n\n");
            Console.WriteLine("Escolha o programa desejado: ");
            Console.WriteLine("1 - Exemplo 1: ");
            Console.WriteLine("2 - Exemplo 2: ");
            string optSTR = Console.ReadLine();
            Int32.TryParse(optSTR, out opcao);

            if(opcao == 1)
            {
                Exemplo1();
            }
            else if(opcao == 2)
            {
                Exemplo2();
            }
            else
            {
                Console.WriteLine("**** Muito Obrigado, volte sempre! ****");
            }

            Console.ReadLine();
        }

        static void Exemplo1()
        {
            Console.Clear();

            Console.WriteLine("**** Seja bem vindo ao programa 1! ****");
            Console.WriteLine("**** Gerar 2 números aleatórios (0-100_ ****");
            Console.WriteLine("**** Mostrar o maior ****");

            int numero1, numero2;

            Random rd = new Random();

            numero1 = rd.Next(1, 100);
            numero2 = rd.Next(1, 100);

            if(numero1< numero2)
            {
                Console.WriteLine($"Número 1 é o maior. Numero1 = {numero1}");
            }
            else if(numero2 < numero1)
            {
                Console.WriteLine($"Número 2 é o maior. Numero1 = {numero2}");
            }
            else
            {
                Console.WriteLine($"Os dois número são iguais. {numero1} e {numero2}");
            }

        }

        static void Exemplo2()
        {
            Console.Clear();

            Console.WriteLine("**** Seja bem vindo ao programa 2! ****");
            Console.WriteLine("**** Gerar 3 números aleatórios (0-100_ ****");
            Console.WriteLine("**** Escrevê-los em ordem crescente ****");

            int numero1, numero2, numero3;
            string formataSaida = "";

            Random rd = new Random();
            numero1 = rd.Next(1, 100);
            numero2 = rd.Next(1, 100);
            numero3 = rd.Next(1, 100);

            if(numero1 < numero2 &&
                numero1 < numero3)
            {
                formataSaida += $"{numero1}, ";

                if(numero2 < numero3)
                {
                    formataSaida += $"{numero2}, {numero3}";
                }
                else
                {
                    formataSaida += $"{numero3}, {numero2}";
                }
            }
            else if(numero2 < numero1 &&
                numero2 < numero3)
            {
                formataSaida += $"{numero2}, ";

                if (numero1 < numero3)
                {
                    formataSaida += $"{numero1}, {numero3}";
                }
                else
                {
                    formataSaida += $"{numero3}, {numero2}";
                }
            }
            else
            {
                formataSaida += $"{numero3}, ";
                if (numero1 < numero2)
                {
                    formataSaida += $"{numero1}, {numero2}";
                }
                else
                {
                    formataSaida += $"{numero2}, {numero1}";
                }
            }

            Console.WriteLine($"Ordem crescente: {formataSaida}");
        }
    }
}
