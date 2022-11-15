using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Convenio
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public FlConvenStatus Status { get; set; }
        public Convenio()
        {
            Status = FlConvenStatus.A;
        }
        public Convenio(string nome)
        {
            Nome = nome;
            Status = FlConvenStatus.A;
        }
        public Convenio(int id, string nome, FlConvenStatus status)
        {
            Id = id;
            Nome = nome;
            Status = status;
        }
    }
    public enum FlConvenStatus 
    {
        [Description("Inativo")]
        I = 0,
        [Description("Ativo")]
        A = 1
    }

}
