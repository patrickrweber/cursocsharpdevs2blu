using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAulas.AgendaDeContatos.Models.Models
{
    public class Estado
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public Estado()
        {

        }
        public Estado(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
