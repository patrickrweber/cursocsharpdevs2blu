using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros;
using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros.Interfaces;
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
            int opcao = 0, opcaoMenuCadastros = 0;
            mock = new Mocks();
            IMenuCadastro menuCadastro;
            do
            {             
                if (opcaoMenuCadastros.Equals((int)MenuEnums.SAIR))
                {
                    if (opcao.Equals((int)MenuEnums.SAIR))
                    {
                        Console.Clear();
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
                    } 
                    
                    switch (opcao)
                    {
                        case (int)MenuEnums.CAD_PAC:
                            menuCadastro = new CadastroPaciente();
                            opcaoMenuCadastros = menuCadastro.MenuCadastro();
                            break;
                        case (int)MenuEnums.CAD_MED:
                            menuCadastro = new CadastroMedico();
                            opcaoMenuCadastros = menuCadastro.MenuCadastro();
                            break;
                        case (int)MenuEnums.CAD_REC:
                            menuCadastro = new CadastroRecepcionista();
                            opcaoMenuCadastros = menuCadastro.MenuCadastro();
                            break;
                        default:
                            menuCadastro = new CadastroPadrao();
                            opcaoMenuCadastros = (int)MenuEnums.SAIR;
                            break;
                    }
                    switch (opcaoMenuCadastros)
                    {
                        case (int)MenuEnums.LISTAR:
                            menuCadastro.Listar();
                            menuCadastro.RetornarTela();
                            break;
                        case (int)MenuEnums.CADASTRAR:
                            menuCadastro.Cadastrar();
                            menuCadastro.RetornarTela();
                            break;
                        case (int)MenuEnums.ALTERAR:
                            menuCadastro.Alterar();
                            menuCadastro.RetornarTela();
                            break;
                        case (int)MenuEnums.EXCLUIR:
                            menuCadastro.Excluir();
                            menuCadastro.RetornarTela();
                            break;
                        default:
                            TelaInicial();
                            break;
                    }
                }                
            } while (opcao.Equals(MenuEnums.SAIR));
        }
    }
}
