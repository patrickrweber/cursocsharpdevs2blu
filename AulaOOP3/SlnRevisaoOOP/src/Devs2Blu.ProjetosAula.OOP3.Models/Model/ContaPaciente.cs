using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class ContaPaciente
    {
        public Int32 Codigo { get; set; }
        public Paciente CodigoPaciente { get; set; }
        public Prontuario CodigoProntuario { get; set; }
        public Agenda CodigoAgenda { get; set; }
        public double ValorTotal{ get; set; }
        public String StatusConta{ get; set; }

    }
}
