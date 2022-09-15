using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula3.ProjetoCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio2e2();
            
        }

        static void Exercicio2e2()
        {
            int valor1, valor2, valor3, valor4;
            int menorValor = 99999999;

            Console.Write("Informe o valor 1: ");
            string vl1STR = Console.ReadLine();
            Int32.TryParse(vl1STR, out valor1);

            Console.Write("Informe o valor 2: ");
            string vl2STR = Console.ReadLine();
            Int32.TryParse(vl2STR, out valor2);

            Console.Write("Informe o valor 3: ");
            string vl3STR = Console.ReadLine();
            Int32.TryParse(vl3STR, out valor3);

            Console.Write("Informe o valor 4: ");
            string vl4STR = Console.ReadLine();
            Int32.TryParse(vl4STR, out valor4);

            if(valor1 < menorValor)
            {
                menorValor = valor1;
            }
            if(valor2 < menorValor)
            {
                menorValor = valor2;
            }
            if(valor3 < menorValor)
            {
                menorValor = valor3;
            }
            if(valor4 < menorValor)
            {
                menorValor = valor4;
            }

            Console.WriteLine(menorValor);
            Console.ReadLine();
        }

        static void Exercicio2()
        {
            int valor1, valor2, valor3, valor4;


            Console.Write("Informe o valor 1: ");
            string vl1STR = Console.ReadLine();
            Int32.TryParse(vl1STR, out valor1);

            Console.Write("Informe o valor 2: ");
            string vl2STR = Console.ReadLine();
            Int32.TryParse(vl2STR, out valor2);

            Console.Write("Informe o valor 3: ");
            string vl3STR = Console.ReadLine();
            Int32.TryParse(vl3STR, out valor3);

            Console.Write("Informe o valor 4: ");
            string vl4STR = Console.ReadLine();
            Int32.TryParse(vl4STR, out valor4);

            if (valor1 < valor2 &&
                valor1 < valor3 &&
                valor1 < valor4)
            {
                Console.WriteLine($"Menor número: {valor1}");
            }
            else if (valor2 < valor3 &&
               valor2 < valor4)
            {
                Console.WriteLine($"Menor número: {valor2}");
            } 
            else if (valor3 < valor4)
            {
                Console.WriteLine($"Menor número: {valor3}");
            }
            else
            {
                Console.WriteLine($"Menor número: {valor4}");
            }

            Console.ReadLine();

            }
        static void Exercicio1()
        {
            int valor1, valor2;

            Console.Write("Informe o primeiro valor: ");
            string valor1STR = Console.ReadLine();

            Console.Write("Informe o segundo valor: ");
            string valor2STR = Console.ReadLine();

            Int32.TryParse(valor1STR, out valor1);
            Int32.TryParse(valor2STR, out valor2);

            if (valor1 > valor2)
            {
                Console.WriteLine($"Maior valor: {valor1}");
            }
            else if (valor2 > valor1)
            {
                Console.WriteLine($"Maior valor: {valor2}");
            }
            else
            {
                Console.WriteLine("Valores iguais.");
            }

            Console.ReadLine();
        }
        static void Exemplo1()
        {
            string textoSaida;
            string nomeCandidato;
            int idadeCandidato, notaCandidato;

            Console.WriteLine("|**** Bem vindo ao Programa SysSchool ****|\n\n");

            Console.Write("Informe o nome do candidato: ");
            nomeCandidato = Console.ReadLine();

            Console.Write("Informe a idade do candidato: ");
            string idadeSTR = Console.ReadLine();

            if (idadeSTR.Equals(""))
            {
                Console.WriteLine("Valor inválido para Idade!");
                return;
            }
            else
            {
                idadeCandidato = Int16.Parse(idadeSTR);
            }

            Console.Write("Informe a nota do candidato: ");
            string notaSTR = Console.ReadLine();

            if (notaSTR.Equals(""))
            {
                Console.WriteLine("Valor inválido para nota!");
                return;
            }
            else
            {
                notaCandidato = Int16.Parse(notaSTR);
            }

            textoSaida = $"\nCandidato: {nomeCandidato} \n";
            textoSaida += $"Idade: {idadeCandidato}";

            if (idadeCandidato < 18)
            {
                textoSaida += "(Menor de idade)\n";
            }
            else
            {
                textoSaida += " (Maior de idade)\n";
            }

            textoSaida += $"Nota Final: {notaCandidato}";

            if (notaCandidato > 5)
            {
                textoSaida += "\n|**** Aprovado ****|\n";
            }
            else
            {
                textoSaida += "\n|**** Reprovado ****|";
            }

            Console.WriteLine(textoSaida);
            Console.ReadLine();
        }
    }
}
