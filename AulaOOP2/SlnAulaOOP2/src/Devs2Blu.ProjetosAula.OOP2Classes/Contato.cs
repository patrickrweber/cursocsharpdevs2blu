using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP2Classes
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public Int32 Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Texto { get; set; }

        public Contato() { }

        public Contato(string nome, string telefone, string email, string cep,
            string rua, Int32 numero, string bairro, string cidade, string estado, string texto)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Texto = texto;
        }
    }
}
