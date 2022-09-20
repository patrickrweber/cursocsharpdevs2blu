using Devs2Blu.ProjetosAula.OOP2Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.AulaOOP2
{
    public partial class Form1 : Form
    {
        public List<Contato> listaContato { get; set; }
        public Form1()
        {
            InitializeComponent();
            listaContato = new List<Contato>();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!ValidaForm())
            {
                MessageBox.Show(this, "Preencha todos os campos!", "Erro - Formulário de contato",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BindClass();            
            LimparTela();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarContatos();
        }
        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if(txtCep.TextLength == 8)
            {
                txtRua.Text = "7 de Setembro";
                txtBairro.Text = "Centro";
                txtCidade.Text = "Blumenau";
                txtEstado.Text = "SC";
            }
            else
            {
                txtRua.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtEstado.Clear();
            }
            
        }

        private void LimparTela()
        {
            txtNome.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtCep.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();            
        }
        private void MostrarContatos()
        {
            foreach (Contato contato in listaContato)
            {
                rtxtConsole.Text += $"Nome: {contato.Nome}";
                rtxtConsole.Text += $"\nTelefone: {contato.Telefone}";
                rtxtConsole.Text += $"\nE-mail: {contato.Email}";
                rtxtConsole.Text += $"\nCep: {contato.Cep}";
                rtxtConsole.Text += $"\nRua: {contato.Rua}";
                rtxtConsole.Text += $"\nNúmero: {contato.Numero}";
                rtxtConsole.Text += $"\nBairro: {contato.Bairro}";
                rtxtConsole.Text += $"\nCidade: {contato.Cidade}";
                rtxtConsole.Text += $"\nEstado: {contato.Estado}";
                rtxtConsole.Text += $"\nMensagem: {contato.Texto}";
            }
        }
        private bool ValidaForm()
        {
            if (txtNome.Text.Equals("")) return false;
            if (txtTel.Text.Equals("")) return false;
            if (txtEmail.Text.Equals("")) return false;
            if (txtCep.Text.Equals("")) return false;
            if (txtRua.Text.Equals("")) return false;
            if (txtNumero.Text.Equals("")) return false;
            if (txtBairro.Text.Equals("")) return false;
            if (txtCidade.Text.Equals("")) return false;
            if (txtEstado.Text.Equals("")) return false;
            if (rTxtTexto.Text.Equals("")) return false;
            return true;
        }
        private void BindClass()
        {
            Int32.TryParse(txtNumero.Text, out Int32 numero);
            Contato contato = new Contato(txtNome.Text, txtTel.Text, txtEmail.Text,
                txtCep.Text, txtRua.Text, numero, txtBairro.Text, txtCidade.Text,
                txtEstado.Text, rTxtTexto.Text);
            listaContato.Add(contato);

            MessageBox.Show($"{contato.Nome}, Usuário cadastrado com sucesso!", "Confirmação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
