using Correios;
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
    public partial class Form1 : Form
    {
        public Contato Contato = new Contato();
        public Compromisso Compromisso { get; set; }
        ContatoRepository ContatoRepository = new ContatoRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void BuscaCep(string cep)
        {
                CorreiosApi correio = new CorreiosApi();
                var result = correio.consultaCEP(cep);
                txtRua.Text = result.end;
                txtBairro.Text = result.bairro;
                txtCidade.Text = result.cidade;
                cboUF.Text = result.uf;
        }

        private void PopulaGrid()
        {
            var listContato = ContatoRepository.GetContatos();
            dgvCadastro.DataSource = new BindingSource(listContato, null);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato.Bairro = txtBairro.Text;
            Contato.Celular = mskCelular.Text;
            Contato.CEP = mskCep.Text;
            Contato.Cidade = txtCidade.Text;
            Contato.Email = txtEmail.Text;
            Contato.Nome = txtNome.Text;
            Contato.Numero = Int32.Parse(txtNumero.Text);
            Contato.Rua = txtRua.Text;
            Contato.Telefone = mskTelefone.Text;
            Contato.UF = cboUF.Text;

            ContatoRepository.InserirContato(Contato);
            PopulaGrid();
        }

        private void mskCep_TextChanged(object sender, EventArgs e)
        {
            if (mskCep.Text.Length == 9)
            {
                BuscaCep(mskCep.Text);
            }
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            PopulaGrid();
        }
    }
}
