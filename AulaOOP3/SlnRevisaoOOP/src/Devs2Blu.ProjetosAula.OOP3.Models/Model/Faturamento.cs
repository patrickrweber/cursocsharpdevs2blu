using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Faturamento
    {
        public Int32 Codigo { get; set; }
        public Fornecedor CodigoFornecedor { get; set; }
        public Medico CodigoMedico { get; set; }
        public double ValorFatura { get; set; }
        public String StatusFatura { get; set; }
    }
}
