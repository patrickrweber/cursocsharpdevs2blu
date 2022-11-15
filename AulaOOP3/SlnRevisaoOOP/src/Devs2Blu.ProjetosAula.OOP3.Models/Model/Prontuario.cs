using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Prontuario
    {
        public Int32 Codigo { get; set; }
        public Paciente CodigoPaciente { get; set; }
        public Medico CodigoMedicoAtend { get; set; }
        public Recepcionista CodigoRecepAtend { get; set; }
        public Int32 SinaisVitais{ get; set; }
        public DateTime DataEntrada{ get; set; }
        public DateTime DataAlta{ get; set; }
        public String StatusPaciente{ get; set; }
    }
}
