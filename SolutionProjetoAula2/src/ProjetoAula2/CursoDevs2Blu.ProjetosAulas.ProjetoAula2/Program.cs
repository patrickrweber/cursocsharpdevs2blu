using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDevs2Blu.ProjetosAulas.ProjetoAula2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCandidato, saida;
            int idadeCandidato, notaCandidato;

            Console.Write("Informe seu nome: ");
            nomeCandidato = Console.ReadLine();

            Console.Write("\nInforme sua idade: ");
            string idadeInput = Console.ReadLine();

            Console.Write("\nInforme a nota obtida: ");
            string notaInput = Console.ReadLine();

            saida = $"\n{nomeCandidato} tirou nota {notaCandidato} e tem {idadeCandidato} anos, ";
            if (idadeCandidato >= 18)
            {
                saida += "sendo maior de idade. \n";
            }
            else
            {
                saida += "sendo menor de idade. \n";
            }
            if (notaCandidato >= 6)
            {
                saida += "Conceito: Aprovado. \n";
            }
            else
            {
                saida += "Conceito: Reprovado. \n";
            }

            Console.WriteLine(saida);
            Console.ReadLine();
        }
    }
}
