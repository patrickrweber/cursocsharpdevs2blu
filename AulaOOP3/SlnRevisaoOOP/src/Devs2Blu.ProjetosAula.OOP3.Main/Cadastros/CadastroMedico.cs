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
    public class CadastroMedico : IMenuCadastro
    {
        public CadastroMedico()
        {

        }
        public Int32 MenuCadastro()
        {
            Console.Clear();
            Int32 opcao;
                Console.WriteLine("---- Cadastro de Médicos ----");
                Console.WriteLine("---- 1- Lista de Médicos ----");
                Console.WriteLine("---- 2- Cadastro de Médicos ----");
                Console.WriteLine("---- 3- Alterar Médicos ----");
                Console.WriteLine("---- 4- Excluir Médicos ----");
                Console.WriteLine("---- 0- Retornar ----");

                Int32.TryParse(Console.ReadLine(), out opcao);
                return opcao;
        }
        #region FACADE
        public void ListarMedico()
        {
            Console.Clear();

            foreach (Medico medico in Program.mock.ListaMedicos)
            {
                Console.WriteLine("************************************");
                Console.WriteLine($"Médico: {medico.Codigo}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"CPF: {medico.CGCCPF}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine("************************************\n");
            }
        }
        public void CadastrarMedico()
        {
            Console.Clear();
            Medico medico = new Medico();

            Console.Write("Código do médico: ");
            Int32.TryParse(Console.ReadLine(), out Int32 codigo);
            medico.Codigo = codigo;
            Console.Write("Nome do médico: ");
            medico.Nome = Console.ReadLine(); 
            Console.Write("CPF do médico: ");
            medico.CGCCPF = Console.ReadLine();
            Console.Write("CRM do médico: ");
            medico.CRM = Int32.Parse(Console.ReadLine());
            Console.Write("Especialidade do médico: ");
            medico.Especialidade = Console.ReadLine();

            Program.mock.ListaMedicos.Add(medico);
        }
        public void AlterarMedico(Medico medico)
        {

        }
        public void ExcluirMedico(Medico medico)
        {

        }
        #endregion
        public void RetornarTela()
        {
            Console.WriteLine("Pressione qualquer tecla para retornar...");
            Console.ReadKey();
            MenuCadastro();
        }

        public void  Listar()
        {
            ListarMedico();
        }

        public void  Cadastrar()
        {
            CadastrarMedico();
        }

        public void  Alterar()
        {
            Medico medico = new Medico();
            AlterarMedico(medico);
        }

        public void  Excluir()
        {
            Medico medico = new Medico();
            ExcluirMedico(medico);
        }
    }
}
