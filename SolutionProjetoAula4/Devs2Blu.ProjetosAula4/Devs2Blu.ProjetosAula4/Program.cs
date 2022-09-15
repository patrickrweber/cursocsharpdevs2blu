using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula4
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio8();
            Console.ReadLine();
        }

        static void Exercicio3()
        {
            int numero;

            Random rd = new Random();
            numero = rd.Next(1, 1000);

            if (!(numero - numero / 2 * 2 == 0))
            {
                Console.WriteLine($"O número {numero} é ímpar!");
            }
            else
            {
                Console.WriteLine($"O número {numero} é par!");
            }

        }

        static void Exercicio4()
        {
            int opcao;

            string[] lista = new string[3];

            lista[0] = "Arroz";
            lista[1] = "Feijão";
            lista[2] = "Farinha";

            Console.WriteLine("Escolha o código do produto: \n");
            Console.WriteLine("001 - Arroz; ");
            Console.WriteLine("002 - Feijão; ");
            Console.WriteLine("003 - Farinha; \n");
            string optSTR = Console.ReadLine();
            Int32.TryParse(optSTR, out opcao);
            if (opcao <= lista.Length && opcao >= 0)
            {
                Console.WriteLine(lista[opcao - 1]);
            }
            else
            {
                Console.WriteLine("\nDiversos");
            }

        }

        static void Exemplo3()
        {
            int idade;
            bool permissao;
            string nome;

            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade");
            string idadeSTR = Console.ReadLine();
            Int32.TryParse(idadeSTR, out idade);

            permissao = (idade >= 18) ? true : false;


        }

        static void Exercicio5()
        {
            int anoAtual = DateTimeOffset.Now.Year;
            int anoNascimento;
            bool votar;

            Console.WriteLine("Informe seu ano de nascimento: ");
            string anoSTR = Console.ReadLine();
            Int32.TryParse(anoSTR, out anoNascimento);

            votar = (anoAtual - anoNascimento >= 16) ? true : false;

            if (votar)
            {
                Console.WriteLine("Você tem permissão para votar");
            }
            else
            {
                Console.WriteLine("Você não tem permissão para votar");
            }

        }

        static void Exemplo5()
        {
            int idade, tempoTrabalho;

            Random rd = new Random();

            idade = rd.Next(50, 80);
            tempoTrabalho = rd.Next(15, 40);

            if ((idade > 65) ||
                (tempoTrabalho > 25))
            {
                Console.WriteLine("Pessoa pode se aposentar!");
            }
            else
            {
                Console.WriteLine("Lamentamos, mas ainda não pode se aposentar.");
            }
        }

        static void Exercicio6()
        {
            const string senha = "1234";
            string senhaDigitada;

            Console.Write("Informe a senha: ");
            senhaDigitada = Console.ReadLine();

            if (senhaDigitada.Equals(senha))
            {
                Console.WriteLine("Acesso permitido!");
            }
            else
            {
                Console.WriteLine("Acesso negado!");
            }
        }

        static void Exercicio7()
        {
            int macas;
            double preco;
            Random rdMacas = new Random();

            macas = rdMacas.Next(1, 24);

            preco = (macas < 12) ? 0.30 : 0.25;

            preco *= macas;

            Console.WriteLine($"Foram compradas {macas} maçãs, pagando um total de R$: {preco}");

        }

        static void Exercicio8()
        {
            List<int> valores = new List<int>();
            Random rd = new Random();
            for (int i = 0; i < 3; i++)
            {
                valores.Add(rd.Next(1, 100));
            }
            valores.Sort();
            
            foreach(int valor in valores)
            {
                Console.WriteLine(valor);
            }
        }
    }
}
