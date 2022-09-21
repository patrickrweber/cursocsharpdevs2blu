using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Models.Model
{
    public class AgendaPaciente
    {
        public Int32 Codigo { get; set; }
        public Int32 CodigoAgenda { get; set; }
        public Paciente CodigoPaciente { get; set; }
        public String StatusAgendamento{ get; set; }
        public DateTime HoraAgenda{ get; set; }
        public DateTime HoraAtendInicio{ get; set; }
        public DateTime HoraAtendFim{ get; set; }
    }
}
