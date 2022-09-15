using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev2Blu.ProjetosAula.Aula6Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int controle;

            do
            {
                Console.WriteLine("Informe um dos códigos abaixo: \n");
                Console.WriteLine("1 - Exemplo 1;");
                Console.WriteLine("2 - Exemplo 2;");
                Console.WriteLine("3 - Exercício 1 e 2; ");
                Console.WriteLine("4 - Exercício 3;");
                Console.WriteLine("5 - Exercício 4;");
                Console.WriteLine("6 - Exercício 5;");
                Console.WriteLine("7 - Exercício 6;");
                Console.WriteLine("8 - Exercício 7; \n");
                Console.WriteLine("Digite 0 para sair.\n");
                Int32.TryParse(Console.ReadLine(), out controle);

                switch (controle)
                {
                    case 1:
                        Exemplo1();
                        break;
                    case 2:
                        Exemplo2();
                        break;
                    case 3:
                        Exercício1e2();
                        break;
                    case 4:
                        Exercicio3();
                        break;
                    case 5:
                        Exercicio4();
                        break;
                    case 6:
                        Exercicio5();
                        break;
                    case 7:
                        Exercicio6();
                        break;
                    case 8:
                        Exercicio7();
                        break;
                    default:
                        Console.WriteLine("Informe o código correto! \n");
                        break;
                }
                Console.Clear();
            } while (controle != 0);
        }

        static void Exemplo1()
        {
            Console.Clear();
            Console.WriteLine("**** Exemplo 1 ****");
            int controle = 1;

            while (controle > 0)
            {
                Console.WriteLine("Informe o código 0 para sair. \n");
                Int32.TryParse(Console.ReadLine(), out controle);
            }
        }
        static void Exemplo2()
        {
            Console.Clear();
            Console.WriteLine("**** Exemplo 2 ****");
            int controle = 0;

            do
            {
                Console.WriteLine("Informe o código 0 para sair \n");
                Int32.TryParse(Console.ReadLine(), out controle);
            } while (controle > 0);
        }
        static void Exercício1e2()
        {
            Console.Clear();
            Console.WriteLine("**** Exercício 1 e 2 ****\n");

            int numero = 0, controle, opcao;

            Console.WriteLine("Quais números você quer visualizar? ");
            Console.WriteLine("1 - Ímpar;");
            Console.WriteLine("2 - Par; \n");
            Int32.TryParse(Console.ReadLine(), out opcao);

            do
            {
                while (numero < 101)
                {
                    switch(opcao)
                    {
                        case 1:
                            if (numero % 2 != 0)
                            {
                                Console.WriteLine($"Número: {numero}");
                            }
                            break;

                        case 2:
                            if (numero % 2 == 0)
                            {
                                Console.WriteLine($"Número: {numero}");
                            }
                            break;
                        default:
                            Console.WriteLine("Escolha uma opção correta!");
                            break;
                    }
                    numero++;
                }
                Console.WriteLine("\nDigite 0 para retornar.");
                Int32.TryParse(Console.ReadLine(), out controle);
            } while (controle != 0);
        }
        static void Exercicio3()
        {
            Console.Clear();
            Console.WriteLine("**** Exercício 3 ****\n");

            int count = 1, numero, controle;

            Random rd = new Random();
            numero = rd.Next(1,30);

            do
            {
                Console.WriteLine($"Número: {numero}\n");
                while (count <= numero)
                {
                    if (count % 2 != 0)
                    {
                        Console.WriteLine(count);
                    }
                    count++;
                }

                count = 1;
                Console.WriteLine("\n");

                while (count <= numero)
                {
                    if (count % 2 == 0)
                    {
                        Console.WriteLine(count);
                    }
                    count++;
                }
                Console.WriteLine("\nDigite 0 para retornar.");
                Int32.TryParse(Console.ReadLine(), out controle);
            } while (controle != 0);

        }
        static void Exercicio4()
        {
            Console.Clear();
            Console.WriteLine("**** Exercício 4 ****\n");

            int numAlunos, count = 1, controle = 1;
            double media, nota, total = 0;

            Console.Write("Informe o número de alunos na turma: ");
            Int32.TryParse(Console.ReadLine(), out numAlunos);

            do
            {
                Console.WriteLine("\n");
                while (count <= numAlunos)
                {
                    
                    Console.Write($"Escreva a nota do {count}º aluno: ");
                    double.TryParse(Console.ReadLine(), out nota);
                    total += nota;

                    count++;
                }
                Console.WriteLine("\nMédia da turma: " + (media = total / numAlunos));

                Console.WriteLine("\nDigite 0 para retornar.");
                Int32.TryParse(Console.ReadLine(), out controle);
            } while (controle != 0);


        }
        static void Exercicio5()
        {
            Console.Clear();
            Console.WriteLine("**** Exercício 5 ****\n");

            int count = 1, controle;

            do
            {
                while(count <= 20)
                {
                    Console.WriteLine(count);
                    count++;
                }
                Console.WriteLine();
                count = 1;
                while(count <= 20)
                {
                    Console.Write(count+" ");
                    count++;
                }
                Console.WriteLine("\n\nDigite 0 para retornar.");
                Int32.TryParse(Console.ReadLine(), out controle);
            } while (controle != 0);
        }
        static void Exercicio6()
        {
            Console.Clear();
            Console.WriteLine("**** Exercício 6 ****\n");

            int count = 1000, controle;

            do
            {
               while(count <= 1999)
                {
                    if(count % 11 == 5)
                    {
                        Console.WriteLine(count);
                    }
                    count++;
                }
                Console.WriteLine("\n\nDigite 0 para retornar.");
                Int32.TryParse(Console.ReadLine(), out controle);
            } while (controle != 0);
        }
        static void Exercicio7()
        {
            Console.Clear();
            Console.WriteLine("**** Exercício 7 ****\n");

            int numAleatorio, numUser, count = 0, controle;
            bool acertou = false;
            Random rd = new Random();
            numAleatorio = rd.Next(1, 20);

            Console.WriteLine("Numero aleatório: " + numAleatorio + "\n");
            do
            {
                Console.Write("Adivinhe o número gerado: ");
                Int32.TryParse(Console.ReadLine(), out numUser);

                if (numUser == numAleatorio)
                {
                    acertou = true;
                }
                count++;

            } while ((acertou == false) && (count != 3));

            if (acertou)
            {
                Console.WriteLine("\nParabéns, você acertou!");
            }
            else
            {
                Console.WriteLine("\nQue pena, você errou!");
            }

            Console.WriteLine("\n\nDigite 0 para retornar.");
            Int32.TryParse(Console.ReadLine(), out controle);
        }
    }
}
