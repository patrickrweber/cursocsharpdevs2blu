using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.IfeElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio7();
            Console.ReadLine();
        }

        static void Exercicio6()
        {
            double altura;
            double pesoIdeal;
            string sexo;

            Console.Write("Informe sua altura: ");
            double.TryParse(Console.ReadLine(), out altura);

            Console.WriteLine("Informe seu sexo: ");
            Console.WriteLine("1: Feminino;");
            Console.WriteLine("2: Masculino;");
            sexo = Console.ReadLine();

            if (sexo.Equals("1"))
            {
                Console.WriteLine("Sexo feminino.");
                Console.WriteLine("Peso ideal = " + (pesoIdeal = (62.1 * altura) - 44.7));
            }
            else if (sexo.Equals("2"))
            {
                Console.WriteLine("Sexo masculino.");
                Console.WriteLine("Peso ideal = " + (pesoIdeal = (72.7 * altura) - 44.7));
            }
            else
            {
                Console.WriteLine("Selecione uma opção de sexo correta!");
            }
        }

        static void Exercicio7()
        {
            int lados, tamanhoLado;
            double area;

            Random rd = new Random();
            lados = rd.Next(3, 5);
            tamanhoLado = rd.Next(1, 10);

            Console.WriteLine($"Tamanho lados: {tamanhoLado} ");
            Console.WriteLine($"Quantidade lados: {lados} ");

            if (lados == 3)
            {
                Console.WriteLine("*** Triângulo ***");
                Console.WriteLine("Área: " + (area = (tamanhoLado * tamanhoLado) / 2));
                
            }
            else if (lados == 4)
            {
                Console.WriteLine("*** Quadrado ***");
                Console.WriteLine("Área: " + (area = (tamanhoLado * tamanhoLado)));
            }
            else if (lados == 5)
            {
                Console.WriteLine("*** Pentagono ***");
                Console.WriteLine("Área: " + (area = (lados * tamanhoLado) / 2));
            }
            else if (lados < 3)
            {
                Console.WriteLine("Não é polígono!");
            }
            else
            {
                Console.WriteLine("Poligono não identificado!");
            }
        }
    }
}
