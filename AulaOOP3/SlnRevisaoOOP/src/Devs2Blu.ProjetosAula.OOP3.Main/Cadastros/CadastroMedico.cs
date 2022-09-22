﻿using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroMedico
    {
        public CadastroMedico()
        {

        }
        public void MenuCadastro()
        {
            Console.Clear();
            Int32 opcao;

            do
            {
                Console.WriteLine("---- Cadastro de Médicos ----");
                Console.WriteLine("---- 1- Lista de Médicos ----");
                Console.WriteLine("---- 2- Cadastro de Médicos ----");
                Console.WriteLine("---- 3- Alterar Médicos ----");
                Console.WriteLine("---- 4- Excluir Médicos ----");
                Console.WriteLine("---- 0- Retornar ----");

                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarMedico();
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

        }
        public void AlterarMedico()
        {

        }
        public void ExcluirMedico()
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
