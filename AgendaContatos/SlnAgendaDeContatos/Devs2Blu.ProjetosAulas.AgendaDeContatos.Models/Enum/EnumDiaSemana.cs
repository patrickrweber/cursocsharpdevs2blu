using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAulas.AgendaDeContatos.Models.Enum
{
    public enum EnumDiaSemana
    {
        [Description("Domingo")]
        DOMINGO = 1,
        [Description("Segunda")]
        SEGUNDA = 2,
        [Description("Terça")]
        TERCA = 3,
        [Description("Quarta")]
        QUARTA = 4,
        [Description("Quinta")]
        QUINTA = 5,
        [Description("Sexta")]
        SEXTA = 6,
        [Description("Sábado")]
        SABADO = 7
    }
}
