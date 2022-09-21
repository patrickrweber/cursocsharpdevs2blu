using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Models.Model
{
    public class Agenda
    {
        public Int32 Codigo { get; set; }
        public String TipoAgenda { get; set; }
        public DateTime DiasAtendimento{ get; set; }
        public DateTime HoraAtendimento{ get; set; }
        public DateTime HoraAtendInicio{ get; set; }
        public DateTime HoraAtendFim{ get; set; }
        public Int32 CodigoMedicoAgenda{ get; set; }
        public Int32 CodigoRecepAgenda{ get; set; }
        public String StatusAgenda { get; set; }
    }
}
