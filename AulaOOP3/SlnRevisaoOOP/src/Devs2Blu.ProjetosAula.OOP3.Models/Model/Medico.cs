﻿using Devs2Blu.ProjetosAula.SistemaCadastro.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Medico
    {
        public Int32 Id  { get; set; }
        public Int32 CRM { get; set; }
        public String Especialidade { get; set; }
    }
}
