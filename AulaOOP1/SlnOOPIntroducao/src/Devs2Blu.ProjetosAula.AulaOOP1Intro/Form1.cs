using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devs2Blu.ProjetosAula.Classes;


namespace Devs2Blu.ProjetosAula.AulaOOP1Intro
{
    public partial class Form1 : Form
    {
        public List<Recepcionista> RecepcionistasList { get; set; }
        public List<Diretor> DiretoresList { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RecepcionistasList = new List<Recepcionista>();
            DiretoresList = new List<Diretor>();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {         
            if (radioButtonDiretor.Checked)
            {
                Diretor diretor = new Diretor();
                diretor.Nome = txtNome.Text;
                diretor.SobreNome = txtSobreNome.Text;
                SalvarDiretor(diretor);
            }else if (radioButtonRecep.Checked)
            {
                Recepcionista recepcionista = new Recepcionista();
                recepcionista.Nome = txtNome.Text;
                recepcionista.SobreNome = txtSobreNome.Text;
                SalvarRecepcionista(recepcionista);
                LimparFormulario();
            }
        }
        #region Metodos
        private void SalvarRecepcionista(Recepcionista recepcionista)
        {
            RecepcionistasList.Add(recepcionista);
        }
        private void SalvarDiretor(Diretor diretor)
        {
            DiretoresList.Add(diretor);
        }
        private void LimparFormulario()
        {
            txtNome.Text = "";
            txtSobreNome.Text = "";
        }
        #endregion

        
    }
}
