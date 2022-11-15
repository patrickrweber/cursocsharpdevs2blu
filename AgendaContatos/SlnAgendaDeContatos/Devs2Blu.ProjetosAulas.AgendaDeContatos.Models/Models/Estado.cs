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
        public String Descricao { get; set; }
        public Estado()
        {

        }
        public Estado(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }
    }
}
