using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main
{
    class Program
    {
        public static Mocks mock { get; set; }

        
        static void Main(string[] args)
        {
            TelaInicial();        
        }
        public static void TelaInicial()
        {
            Console.Clear();
            int opcao;
            mock = new Mocks();
            do
            {
                Console.WriteLine("---- Sistema de Gerenciamento de Clinicas ----");
                Console.WriteLine("---- 10- Cadastro de Pacientes ----");
                Console.WriteLine("---- 20- Cadastro de Médicos ----");
                Console.WriteLine("---- 30- Cadastro de Recepcionistas ----"); ;
                Console.WriteLine("---- 40- Cadastro de Fornecedores ----"); ;
                Console.WriteLine("---- 50- Agenda ----"); ;
                Console.WriteLine("---- 60- Prontuario ----"); ;
                Console.WriteLine("---- 70- Financeiro ----"); ;
                Console.WriteLine("-----------------------"); ;
                Console.WriteLine("---- 0- Sair ----"); ;
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.CAD_PAC:
                        CadastroPaciente ModuloCadastroPaciente = new CadastroPaciente();
                        ModuloCadastroPaciente.CadastrarPaciente();
                        ModuloCadastroPaciente.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_MED:
                        CadastroMedico ModuloCadastroMedico = new CadastroMedico();
                        ModuloCadastroMedico.CadastrarMedico();
                        ModuloCadastroMedico.MenuCadastro();
                        break;
                    default:
                        break;
                }

            } while (opcao.Equals(MenuEnums.SAIR));
        }
    }
}
