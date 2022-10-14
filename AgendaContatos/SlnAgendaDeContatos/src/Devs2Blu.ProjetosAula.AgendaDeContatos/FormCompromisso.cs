using Devs2Blu.ProjetosAula.AgendaDeContatos.Data;
using Devs2Blu.ProjetosAulas.AgendaDeContatos.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.AgendaDeContatos
{

    public partial class FormCompromisso : Form
    {
        public Int32 IdContato { get; set; }
        CompromissoRepository CompromissoRepository = new CompromissoRepository();
        Compromisso CompromissoForm = new Compromisso();
        public FormCompromisso()
        {
            InitializeComponent();
        }

        private void FormCompromisso_Load(object sender, EventArgs e)
        {

        }
        public FormCompromisso(String nome, Int32 id)
        {
            InitializeComponent();
            lblNome.Text = nome;
            IdContato = id;
        }
        public FormCompromisso(String nome, Compromisso compromisso, Int32 id)
        {
            InitializeComponent();
            lblNome.Text = nome;
            btnAlterar.Visible = true;
            txtDescricao.Text = compromisso.Descricao;
            txtLocal.Text = compromisso.Local;
            txtTitulo.Text = compromisso.Titulo;
            cboDiaSemana.Text = compromisso.DiaSemana;
            dtpData.Value = compromisso.Data;            
            IdContato = id;
        }
        private Compromisso PopulaCompromissoForm()
        {
            CompromissoForm.DiaSemana = cboDiaSemana.Text;
            CompromissoForm.Descricao = txtDescricao.Text;
            CompromissoForm.Titulo = txtTitulo.Text;
            CompromissoForm.Local = txtLocal.Text;
            CompromissoForm.Data = dtpData.Value;

            return CompromissoForm;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CompromissoRepository.InserirCompromisso(PopulaCompromissoForm(), IdContato);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CompromissoRepository.AlterarCompromissos(PopulaCompromissoForm(), IdContato);
            Close();
        }
    }
}
