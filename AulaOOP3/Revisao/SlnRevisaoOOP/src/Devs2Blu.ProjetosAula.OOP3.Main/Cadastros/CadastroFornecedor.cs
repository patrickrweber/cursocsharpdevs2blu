using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroFornecedor : IMenuCadastro
    {
        public Int32 MenuCadastro()
        {
            Int32 opcao;

            Console.Clear();
            Console.WriteLine("----- Cadastro de Fornecedores -----");
            Console.WriteLine("----- 1- Lista de Fornecedor -----");
            Console.WriteLine("----- 2- Cadastro de Fornecedor -----");
            Console.WriteLine("----- 3- Alterar Fornecedor -----");
            Console.WriteLine("----- 4- Excluir Fornecedor -----");
            Console.WriteLine("---------------------");
            Console.WriteLine("----- 0- Sair -----");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }
        public void Listar()
        {
            ListarFornecedor();
        }
        public void Cadastrar()
        {
            Console.Clear();
            Fornecedor fornecedor = new Fornecedor();
            Console.WriteLine("Informe o nome do fornecedor");
            fornecedor.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do fornecedor");
            fornecedor.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o tipo do fornecedor");
            fornecedor.TipoFornecedor = Console.ReadLine();

            Random rd = new Random();
            fornecedor.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            fornecedor.CodigoFornecedor = Int32.Parse($"{fornecedor.Codigo}{rd.Next(100, 999)}");

            CadastrarFornecedor(fornecedor);
        }
        public void Alterar()
        {
            Console.Clear();
            Fornecedor fornecedor;

            Console.WriteLine("Informe o fornecedor que deseja alterar:\n");
            ListarFornecedoresByCodeAndName();
            Int32.TryParse(Console.ReadLine(), out int codigoFornecedor);

            fornecedor = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == codigoFornecedor);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Fornecedor: {fornecedor.Codigo}/{fornecedor.CodigoFornecedor} | Nome: {fornecedor.Nome} | " +
                    $"CPF: {fornecedor.CGCCPF} | Tipo do Fornecedor: {fornecedor.TipoFornecedor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 Tipo Fornecedor | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        fornecedor.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        fornecedor.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo tipo:");
                        fornecedor.TipoFornecedor = Console.ReadLine();
                        break;
                    default:
                        alterar = false;
                        break;
                }
                if (alterar)
                {
                    Console.Clear();
                    Console.WriteLine("Dado Alterado com Sucesso!");
                }
            } while (alterar);

            AlterarFornecedor(fornecedor);
        }
        public void Excluir()
        {
            Console.Clear();
            Fornecedor fornecedor;

            Console.WriteLine("Informe o fornecedor que deseja excluir:\n");
            ListarFornecedoresByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out int codigoFornecedor);

            fornecedor = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == codigoFornecedor);

            ExcluirFornecedor(fornecedor);
        }
        private void ListarFornecedor()
        {
            Console.Clear();

            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Fornecedor: {fornecedor.CodigoFornecedor}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"CPF: {fornecedor.CGCCPF}");
                Console.WriteLine($"Tipo: {fornecedor.TipoFornecedor}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }
        private void CadastrarFornecedor(Fornecedor novoFornecedor)
        {
            Program.Mock.ListaFornecedores.Add(novoFornecedor);
        }
        private void AlterarFornecedor(Fornecedor fornecedor)
        {
            var pact = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == fornecedor.CodigoFornecedor);
            int index = Program.Mock.ListaFornecedores.IndexOf(pact);
            Program.Mock.ListaFornecedores[index] = fornecedor;
        }
        private void ExcluirFornecedor(Fornecedor fornecedor)
        {
            Program.Mock.ListaFornecedores.Remove(fornecedor);
        }
        private void ListarFornecedoresByCodeAndName()
        {
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.Write($"| {fornecedor.CodigoFornecedor} - {fornecedor.Nome} ");
            }
            Console.WriteLine("\n");
        }
    }
}
