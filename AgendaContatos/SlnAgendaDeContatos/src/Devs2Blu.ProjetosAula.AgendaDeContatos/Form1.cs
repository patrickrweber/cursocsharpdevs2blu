﻿using Correios;
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
        public Contato ContatoForm = new Contato();
        public Compromisso CompromissoForm = new Compromisso();
        private Int32 Id { get; set; }
        private Int32 IdCompromisso { get; set; }
        public Compromisso Compromisso { get; set; }
        ContatoRepository ContatoRepository = new ContatoRepository();
        CompromissoRepository CompromissoRepository = new CompromissoRepository();
        public Form1()
        {
            InitializeComponent();
        }              
       
        private void LimpaTela()
        {
            mskCep.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtNumero.Clear();
            txtRua.Clear();
            mskCelular.Clear();
            mskTelefone.Clear();
            cboUF.Text = "";
        }

        #region Metodos Compromisso
        private void PopulaGridCompromisso()
        {
            var listCompromisso = CompromissoRepository.GetCompromissos();
            dgvCompromisso.DataSource = new BindingSource(listCompromisso, null);
        }

        #endregion

        #region Metodos Contato
        private void BuscaCep(string cep)
        {
            CorreiosApi correio = new CorreiosApi();
            try
            {
                var result = correio.consultaCEP(cep);
                txtRua.Text = result.end;
                txtBairro.Text = result.bairro;
                txtCidade.Text = result.cidade;
                cboUF.Text = result.uf;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mskCep.Focus();
            }
        }
        private Contato PopulaContatoForm()
        {
            ContatoForm.Bairro = txtBairro.Text;
            ContatoForm.Celular = mskCelular.Text;
            ContatoForm.CEP = mskCep.Text;
            ContatoForm.Cidade = txtCidade.Text;
            ContatoForm.Email = txtEmail.Text;
            ContatoForm.Nome = txtNome.Text;
            ContatoForm.Numero = Int32.Parse(txtNumero.Text);
            ContatoForm.Rua = txtRua.Text;
            ContatoForm.Telefone = mskTelefone.Text;
            ContatoForm.UF = cboUF.Text;

            return ContatoForm;
        }        
        private void CarregaCamposContato(DataGridViewCellEventArgs e)
        {
            mskCep.Text = dgvCadastro.Rows[e.RowIndex].Cells["cep"].Value.ToString();
            txtBairro.Text = dgvCadastro.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
            txtCidade.Text = dgvCadastro.Rows[e.RowIndex].Cells["cidade"].Value.ToString();
            txtEmail.Text = dgvCadastro.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtNome.Text = dgvCadastro.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtNumero.Text = dgvCadastro.Rows[e.RowIndex].Cells["numero"].Value.ToString();
            txtRua.Text = dgvCadastro.Rows[e.RowIndex].Cells["rua"].Value.ToString();
            mskCelular.Text = dgvCadastro.Rows[e.RowIndex].Cells["celular"].Value.ToString();
            mskTelefone.Text = dgvCadastro.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            cboUF.Text = dgvCadastro.Rows[e.RowIndex].Cells["uf"].Value.ToString();
        }
        private void PopulaGrid()
        {
            var listContato = ContatoRepository.GetContatos();
            dgvCadastro.DataSource = new BindingSource(listContato, null);
        }
        #endregion
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
            PopulaGridCompromisso();
        }


        private void dgvCadastro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Int32.Parse(dgvCadastro.Rows[e.RowIndex].Cells["id"].Value.ToString());
            if(dgvCadastro.Columns[e.ColumnIndex] == dgvCadastro.Columns["dgvBtnExcluir"])
            {
                ContatoRepository.ExcluirContato(Id);
            }
            if(dgvCadastro.Columns[e.ColumnIndex] == dgvCadastro.Columns["dgvBtnEditar"])
            {
                CarregaCamposContato(e);     
            }
            PopulaGrid();
        }

        private void dgvCompromisso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdCompromisso = Int32.Parse(dgvCompromisso.Rows[e.RowIndex].Cells["id"].Value.ToString());
            if (dgvCompromisso.Columns[e.ColumnIndex] == dgvCompromisso.Columns["dgvBtnExcluirCompromisso"])
            {
                CompromissoRepository.ExcluirCompromissos(IdCompromisso);
            }
            if (dgvCompromisso.Columns[e.ColumnIndex] == dgvCompromisso.Columns["dgvBtnEditarCompromisso"])
            {
                Compromisso compromisso = new Compromisso();
                compromisso.Data = DateTime.Parse(dgvCompromisso.Rows[e.RowIndex].Cells["datacompromisso"].Value.ToString());
                compromisso.DiaSemana = dgvCompromisso.Rows[e.RowIndex].Cells["diassemana"].Value.ToString();
                compromisso.Descricao = dgvCompromisso.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
                compromisso.Local = dgvCompromisso.Rows[e.RowIndex].Cells["localCompromisso"].Value.ToString();
                compromisso.Titulo = dgvCompromisso.Rows[e.RowIndex].Cells["titulo"].Value.ToString();
                String nome = dgvCompromisso.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                FormCompromisso formCompromisso = new FormCompromisso(nome, compromisso, IdCompromisso);
                formCompromisso.ShowDialog();
            }
            PopulaGridCompromisso();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ContatoRepository.InserirContato(PopulaContatoForm());
            PopulaGrid();
            PopulaGridCompromisso();
            LimpaTela();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ContatoForm = PopulaContatoForm();
            ContatoForm.Id = Id;
            ContatoRepository.AlterarContato(ContatoForm);
            PopulaGrid();
            PopulaGridCompromisso();
        }

        private void btncCompromisso_Click(object sender, EventArgs e)
        {
            if(Id == 0)
            {
                MessageBox.Show("Selecione um contato para inserir " +
                    "o compromisso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormCompromisso formCompromisso = new FormCompromisso(txtNome.Text, Id);
                formCompromisso.ShowDialog();
            }
            

        }
    }
}
