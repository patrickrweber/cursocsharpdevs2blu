using Devs2Blu.ProjetosAulas.AgendaDeContatos.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAulas.AgendaDeContatos.Models.Models
{
    public class Compromisso
    {
        public Int32 Id { get; set; }
        public DateTime Data { get; set; }
        public String Local{ get; set; }
        public String DiaSemana{ get; set; }
        public EnumStatus Status{ get; set; }
        public String Descricao{ get; set; }
        public String Titulo{ get; set; }
        public Contato Contato { get; set; }
        public Compromisso()
        {

        }
        public Compromisso(int id, DateTime data, string local, String diaSemana, EnumStatus status, string descricao, string titulo, Contato contato)
        {
            Id = id;
            Data = data;
            Local = local;
            DiaSemana = diaSemana;
            Status = status;
            Descricao = descricao;
            Titulo = titulo;
            Contato = contato;
        }
    }
}
