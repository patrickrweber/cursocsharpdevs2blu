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
        public String Email { get; set; }
        public Estado Estado { get; set; }

        public Contato()
        {

        }
        public Contato(int id, string nome, string telefone, string email, Estado estado)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Estado = estado;
        }
    }
}
