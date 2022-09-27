using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Utils
{
    public class Mocks
    {
        public List<Paciente> ListaPacientes { get; set; }
        public List<Medico> ListaMedicos { get; set; }
        public List<Recepcionista> ListaRecepcionistas { get; set; }
        public List<Fornecedor> ListaFornecedores { get; set; }

        public Mocks()
        {
            ListaPacientes = new List<Paciente>();
            ListaMedicos = new List<Medico>();
            ListaRecepcionistas = new List<Recepcionista>();
            ListaFornecedores = new List<Fornecedor>();

            CargaMock();
        }
        public  void CargaMock()
        {
            CargaPaciente();
            CargaMedico();
            CargaRecepcionista();
        }

        public  void CargaPaciente()
        {
            for (int i = 0; i < 10; i++)
            {
                Paciente paciente = new Paciente(i, $"Paciente {i}", $"{i}23{4}56{i}891{i}", "Unimed");
                ListaPacientes.Add(paciente);
            }
        } 
        public  void CargaMedico()
        {
            string[] especialidade = new string[]
            {
                "Cirurgião",
                "Ortopedista",
                "Neurologista",
                "Oftamologista",
                "Otorrinolaringologista",
                "Neurocirurgião",
                "Médico do trabalho",
                "Dermatologista",
                "Ginecologista",
                "Urologista",
            };
            Random rd = new Random();

            for (int i = 0; i < 10; i++)
            {
                
                Medico medico = new Medico(i, $"Medico {i}", $"{i}23{4}56{i}891{i}", 
                    rd.Next(1,99999), especialidade[rd.Next(0, especialidade.Length)]);
                ListaMedicos.Add(medico);
            }
        } 
        public  void CargaRecepcionista()
        {
            string[] setor = new string[]
            {
                "Ala pediátrica",
                "Ala ortopédica",
                "Ala de cirurgia"
            };
            Random rd = new Random();

            for (int i = 0; i < 10; i++)
            {
                
                Recepcionista recepcionista = new Recepcionista(i, $"Recepcionista {i}", 
                    $"{i}23{4}56{i}891{i}", setor[rd.Next(0, setor.Length)]);
                ListaRecepcionistas.Add(recepcionista);
            }
        }
    }
}