using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAulas.AgendaDeContatos.Models.Models
{
    public class Contato
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Celular { get; set; }
        public String Rua { get; set; }
        public Int32 Numero { get; set; }
        public String Bairro{ get; set; }
        public String CEP{ get; set; }
        public String Cidade{ get; set; }
        public String UF{ get; set; }
        public String Email { get; set; }

        public Contato()
        {

        }

        public Contato(int id, string nome, string telefone, string celular, string rua, int numero, string bairro, string cEP, string cidade, string uF, string email)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Celular = celular;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            CEP = cEP;
            Cidade = cidade;
            UF = uF;
            Email = email;
        }
    }
}
