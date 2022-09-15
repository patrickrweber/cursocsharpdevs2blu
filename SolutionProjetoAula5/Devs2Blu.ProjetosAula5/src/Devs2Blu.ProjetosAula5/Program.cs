using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula5
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio5();
            Console.ReadLine();
        }

        static void ExemploSwitchCase() 
        {
            string codigo;

            Console.WriteLine("Escolha um código para ver a descrição");
            Console.WriteLine("- A21");
            Console.WriteLine("- A22");
            Console.WriteLine("- A23");
            Console.WriteLine("- A24");
            Console.WriteLine("- A35");
            Console.WriteLine("- Z16");

            codigo = Console.ReadLine();

            switch (codigo.ToUpper())
            {
                case "A21":
                case "A22":
                case "A23":
                case "A24":
                    Console.WriteLine("A23: Materiais.");
                    break;
                case "A35":
                    Console.WriteLine("A35: Produtos Perecíveis.");
                    break;
                case "Z16":
                    Console.WriteLine("Z16: Produtos Químicos.");
                    break;

                default:
                    Console.WriteLine("Produto Não Cadastrado.");
                    break;
            }
        }
        static void Exercicio1()
        {
            /*1.Crie uma variável chamada “fruta”. Esta variável deve receber uma 
             * string com o nome de uma fruta.Após, crie uma estrutura condicional 
             * switch que receba esta variável e que possua três casos: caso maçã, 
             * retorne no console: “Não vendemos esta fruta aqui”. Caso kiwi, 
             * retorne: “Estamos com escassez de kiwis” e caso melancia, retorne: 
             * “Aqui está, são 3 reais o quilo”.*/

            string fruta;

            Console.Write("Informe a fruta desejada: ");
            fruta = Console.ReadLine();

            switch (fruta.ToUpper())
            {

                case "KIWI":
                    Console.WriteLine("Estamos com escassez de kiwis");
                    break;

                case "MELANCIA":
                    Console.WriteLine("Aqui está, são 3 reais o quilo");
                    break;

                default:
                    Console.WriteLine("Não vendemos esta fruta aqui.");
                    break;
            }

        }
        static void Exercicio2()
        {
            /* 2.	Um homem decidiu ir à uma revenda comprar um carro. Ele deseja 
            * comprar um carro hatch, e a revenda possui, além de carros hatch, 
            * sedans, motocicletas e caminhonetes. Utilizando uma estrutura 
            * switch/case, caso o comprador queira o hatch, retorne: 
            * “Compra efetuada com sucesso”. Nas outras opções, retorne: 
            * “Tem certeza que não prefere este modelo?”. Caso seja especificado 
            * um modelo que não está disponível, retorne no console: 
            * “Não trabalhamos com este tipo de automóvel aqui”.*/

            string modelo;
            Console.WriteLine("**** Informe o modelo do veículo: *****");
            Console.WriteLine("** Hatch **");
            Console.WriteLine("** Sedan **");
            Console.WriteLine("** Motocicleta **");
            Console.WriteLine("** Caminhonete **");
            modelo = Console.ReadLine();

            switch (modelo.ToUpper()) 
            {
                case "HATCH":
                    Console.WriteLine("Compra efetuada com sucesso");
                    break;
                case "SEDAN":
                case "MOTOCICLETA":
                case "CAMINHONETE":
                    Console.WriteLine("Tem certeza que não prefere este modelo?");
                    break;
                default:
                    Console.WriteLine("Não trabalhamos com este tipo de automóvel aqui");
                    break;
            }

        }
        static void Exercicio3()
        {
            /**3.	Faça um programa que simule uma calculadora, onde informa as 
             * opções pro usuário escolher qual operação deseja realizar, e em 
             * seguida informe dois números para realizar a operação. Use o case 
             * para programar as operações específicas. (soma, subtração, 
             * multiplicação e divisão)*/

            double numero1, numero2;
            string opcao;

            Random rd = new Random();

            numero1 = rd.Next(1,20);
            numero2 = rd.Next(1,20);

            Console.WriteLine($"Número 1: {numero1}");
            Console.WriteLine($"Número 2: {numero2}\n");
            Console.WriteLine("Escolha a operação desejada: \n");
            Console.WriteLine("Soma;");
            Console.WriteLine("Subtração; ");
            Console.WriteLine("Multiplicação: ");
            Console.WriteLine("Divisão: \n");
            opcao = Console.ReadLine();

            switch (opcao.ToUpper())
            {
                case "SOMA":
                    Console.WriteLine(numero1 + numero2);
                    break;
                case "SUBTRAÇÃO":
                    Console.WriteLine(numero1 - numero2);
                    break;
                case "MULTIPLICAÇÃO":
                    Console.WriteLine(numero1 * numero2);
                    break;
                case "DIVISÃO":
                    Console.WriteLine(numero1 / numero2);
                    break;
                default:
                    Console.WriteLine("Escolha uma operação válida!");
                    break;
            }

        }
        static void Exercicio4()
        {
            string opcao;

            Console.WriteLine("Digite o tipo de produto que deseja: \n");
            Console.WriteLine("Produtos não perecíveis;");
            Console.WriteLine("Frutas;");
            Console.WriteLine("Bebidas;\n");
            opcao = Console.ReadLine();

            switch (opcao.ToUpper()) 
            {
                case "PRODUTOS NÃO PERECÍVEIS":
                    Console.WriteLine("Arroz;");
                    Console.WriteLine("Feijão;");
                    Console.WriteLine("Café.");
                    break;
                case "FRUTAS":
                    Console.WriteLine("Manga;");
                    Console.WriteLine("Banana;");
                    Console.WriteLine("Maçã.");
                    break;
                case "BEBIDAS":
                    Console.WriteLine("Leite;");
                    Console.WriteLine("Sucos;");
                    Console.WriteLine("Refrigerantes.");
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida!");
                    break;
            }
        }
        static void Exercicio5()
        {
            int numeroUsuario, numeroPC, numeroAleatório,
                pontosUsuario = 0, pontosPC = 0;
            Random rd = new Random();

            /*Entrada de números do PC*/
            numeroPC = rd.Next(1, 20);
           
            /*Entrada de números do usuário*/
            Console.WriteLine("**** Primeira Rodada ****");
            Console.Write("Informe um número entre 1 e 20: ");
            Int32.TryParse(Console.ReadLine(), out numeroUsuario); 

            /*Verificação de se o usuário escreveu o número entre o intervalo correto*/
            if (numeroUsuario >= 1 && numeroUsuario <= 20)
            {
                /*Chamada da função calcular pontos*/
                pontosUsuario += CalcularPontos(numeroUsuario);
            }
            pontosPC += CalcularPontos(numeroPC);

            /*Demonstração de pontos do usuário e do PC*/
            Console.WriteLine($"\nPontos Usuário: {pontosUsuario}");
            Console.WriteLine($"Pontos PC: {pontosPC}");

            /*Verificação de qual pontuação é maior*/
            if (pontosUsuario > pontosPC)
            {
                Console.WriteLine("\n*** Parabéns, você ganhou! ***");
            }
            else if(pontosPC > pontosUsuario)
            {
                Console.WriteLine("\n*** Não foi dessa vez! ***");
            }
            else
            {
                Console.WriteLine("*** Empate! ***");
            }      
            
            /*Função para calcular os pontos*/
            int CalcularPontos(int numero)
            {
                numeroAleatório = rd.Next(1, 20);
                numero += numeroAleatório;
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
                else if(numero > 21)
                {
                    pontos = 0;
                }
                return pontos;
            }
        }
    }
}
