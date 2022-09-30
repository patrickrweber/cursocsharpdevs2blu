using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroPaciente : IMenuCadastro
    {
        public CadastroPaciente()
        {

        }
        public Int32 MenuCadastro()
        {
            Console.Clear();
            Int32 opcao;
            Console.WriteLine("---- Cadastro de Pacientes ----");
            Console.WriteLine("---- 1- Lista de Pacientes ----");
            Console.WriteLine("---- 2- Cadastro de Pacientes ----");
            Console.WriteLine("---- 3- Alterar Pacientes ----");
            Console.WriteLine("---- 4- Excluir Pacientes ----");
            Console.WriteLine("---- 0- Retornar ----");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            ListarPaciente();
        }

        public void Cadastrar()
        {
            CadastrarPaciente();
        }

        public void Alterar()
        {
            AlterarPaciente();
        }

        public void Excluir()
        {
            Paciente paciente = new Paciente();
            ExcluirPaciente(paciente);
        }


        #region FACADE
        private void ListarPacienteByCodeAndName()
        {
            Console.Clear();

            foreach (Paciente paciente in Program.mock.ListaPacientes)
            {
                Console.Write($" | {paciente.CodigoPaciente} - Nome: { paciente.Nome}\n");
            }
            Console.WriteLine("Informe o código do paciente que deseja alterar: ");
        }
        private void ListarPaciente()
        {
            Console.Clear();

            foreach (Paciente paciente in Program.mock.ListaPacientes)
            {
                Console.WriteLine("************************************");
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.CGCCPF}");
                Console.WriteLine($"Endereço: {paciente.Endereco}");
                Console.WriteLine($"Convênio: {paciente.Convenio}");
                Console.WriteLine("************************************\n");
            }
        }
        private void CadastrarPaciente()
        {
            Paciente paciente = new Paciente();
            Console.Clear();

            Console.Write("Código do paciente: ");
            Int32.TryParse(Console.ReadLine(), out Int32 codigo);
            paciente.Codigo = codigo;
            Console.Write("Nome do paciente: ");
            paciente.Nome = Console.ReadLine();
            Console.Write("CPF do paciente: ");
            paciente.CGCCPF = Console.ReadLine();
            Console.Write("Convenio do paciente: ");
            paciente.Convenio = Console.ReadLine();
            Program.mock.ListaPacientes.Add(paciente);
        }
        private void AlterarPaciente()
        {
            Paciente paciente;
            int codigoPaciente;
            ListarPacienteByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoPaciente);

            paciente = Program.mock.ListaPacientes.Find(p => p.CodigoPaciente == codigoPaciente);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.Clear();
                Console.WriteLine($"Paciente:{paciente.CodigoPaciente}, " +
                  $"Nome: {paciente.Nome}, CPF: {paciente.CGCCPF}, Convênio: {paciente.Convenio}");
                Console.WriteLine("Qual campo deseja alterar? ");
                Console.WriteLine("1 - Nome | 2 - CPF | 3 - Convênio");
                opcaoAlterar = Console.ReadLine();
                switch (opcaoAlterar)
                {
                    case "1":
                        Console.WriteLine("Informe um novo nome:");
                        paciente.Nome = Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Informe um novo CPF:");
                        paciente.CGCCPF = Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Informe um novo convênio:");
                        paciente.Convenio = Console.ReadLine();
                        break;
                    default:
                        alterar = false;
                        break;
                }

                if (alterar)
                {
                    Console.Clear();
                    Console.WriteLine("Dado alterado com sucesso!");
                }
            } while (alterar);
        }
        private void ExcluirPaciente(Paciente paciente)
        {
        }
        #endregion
        public void RetornarTela()
        {
            Console.WriteLine("Pressione qualquer tecla para retornar...");
            Console.ReadKey();
            MenuCadastro();
        }

        
    }
}
