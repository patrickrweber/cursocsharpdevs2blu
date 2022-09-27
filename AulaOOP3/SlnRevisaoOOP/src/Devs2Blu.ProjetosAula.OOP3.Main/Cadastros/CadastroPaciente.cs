using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroPaciente
    {
        public CadastroPaciente()
        {

        }
        public void MenuCadastro()
        {
            Console.Clear();
            Int32 opcao;
            do
            {
                Console.WriteLine("---- Cadastro de Pacientes ----");
                Console.WriteLine("---- 1- Lista de Pacientes ----");
                Console.WriteLine("---- 2- Cadastro de Pacientes ----");
                Console.WriteLine("---- 3- Alterar Pacientes ----");
                Console.WriteLine("---- 4- Excluir Pacientes ----");
                Console.WriteLine("---- 0- Retornar ----");

                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarPaciente();
                        RetornarTela();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarPaciente();
                        RetornarTela();
                        break;
                    case (int)MenuEnums.SAIR:
                        Program.TelaInicial();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals(MenuEnums.SAIR));
        }

        public void ListarPaciente()
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
        public void CadastrarPaciente()
        {
            Console.Clear();
            Paciente paciente = new Paciente();

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
        public void AlterarPaciente()
        {

        }
        public void ExcluirPaciente(Paciente paciente)
        {
        }
        public void RetornarTela()
        {
            Console.WriteLine("Pressione qualquer tecla para retornar...");
            Console.ReadKey();
            MenuCadastro();
        }
    }
}
