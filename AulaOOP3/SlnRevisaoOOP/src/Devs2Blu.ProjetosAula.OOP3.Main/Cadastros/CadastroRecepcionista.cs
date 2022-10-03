using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    class CadastroRecepcionista : IMenuCadastro
    {
        public CadastroRecepcionista()
        {

        }
        public Int32 MenuCadastro()
        {
            Console.Clear();
            Int32 opcao;
            Console.WriteLine("---- Cadastro de Recepcionistas ----");
            Console.WriteLine("---- 1- Lista de Recepcionistas ----");
            Console.WriteLine("---- 2- Cadastro de Recepcionistas ----");
            Console.WriteLine("---- 3- Alterar Recepcionistas ----");
            Console.WriteLine("---- 4- Excluir Recepcionistas ----");
            Console.WriteLine("---- 0- Retornar ----");

            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void ListarRecepcionista()
        {
            Console.Clear();

            foreach (Recepcionista recepcionista in Program.mock.ListaRecepcionistas)
            {
                Console.WriteLine("************************************");
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"CPF: {recepcionista.CGCCPF}");
                Console.WriteLine($"Setor: {recepcionista.Setor}");
                Console.WriteLine("************************************\n");
            }
        }
        public void CadastrarRecepcionista()
        {
            Console.Clear();
            Recepcionista recepcionista = new Recepcionista();

            Console.Write("Código da recepcionista: ");
            Int32.TryParse(Console.ReadLine(), out Int32 codigo);
            recepcionista.Codigo = codigo;
            Console.Write("Nome da recepcionista: ");
            recepcionista.Nome = Console.ReadLine();
            Console.Write("CPF da recepcionista: ");
            recepcionista.CGCCPF = Console.ReadLine();
            Console.Write("Setor da recepcionista: ");
            recepcionista.Setor = Console.ReadLine();

            Program.mock.ListaRecepcionistas.Add(recepcionista);
        }
        public void AlterarRecepcionista(Recepcionista recepcionista)
        {

        }
        public void ExcluirRecepcionista(Recepcionista recepcionista)
        {

        }
        public void RetornarTela()
        {
            Console.WriteLine("Pressione qualquer tecla para retornar...");
            Console.ReadKey();
            MenuCadastro();
        }

        public void  Listar()
        {
            ListarRecepcionista();
        }

        public void  Cadastrar()
        {
            CadastrarRecepcionista();
        }

        public void  Alterar()
        {
            Recepcionista recepcionista = new Recepcionista();
            AlterarRecepcionista(recepcionista);
        }

        public void  Excluir()
        {
            Recepcionista recepcionista = new Recepcionista();
            ExcluirRecepcionista(recepcionista);
        }
    }
}
