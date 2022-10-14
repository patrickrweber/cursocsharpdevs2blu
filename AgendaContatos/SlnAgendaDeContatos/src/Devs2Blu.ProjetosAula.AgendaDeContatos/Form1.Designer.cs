
namespace Devs2Blu.ProjetosAula.AgendaDeContatos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvCadastro = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgvBtnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvBtnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvCompromisso = new System.Windows.Forms.DataGridView();
            this.dgvBtnExcluirCompromisso = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvBtnEditarCompromisso = new System.Windows.Forms.DataGridViewImageColumn();
            this.cboDiaSemana = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromisso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCadastro
            // 
            this.dgvCadastro.AllowUserToOrderColumns = true;
            this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBtnExcluir,
            this.dgvBtnEditar});
            this.dgvCadastro.Location = new System.Drawing.Point(12, 204);
            this.dgvCadastro.Name = "dgvCadastro";
            this.dgvCadastro.Size = new System.Drawing.Size(920, 231);
            this.dgvCadastro.TabIndex = 0;
            this.dgvCadastro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastro_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cboUF);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtRua);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.mskCep);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.mskCelular);
            this.groupBox1.Controls.Add(this.mskTelefone);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro Contato";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(64, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "E-mail:";
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(447, 22);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(39, 21);
            this.cboUF.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "UF:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(317, 49);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(169, 20);
            this.txtRua.TabIndex = 14;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(330, 102);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(156, 20);
            this.txtCidade.TabIndex = 13;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(435, 77);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(51, 20);
            this.txtNumero.TabIndex = 12;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(317, 76);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(67, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(317, 22);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(94, 20);
            this.mskCep.TabIndex = 10;
            this.mskCep.TextChanged += new System.EventHandler(this.mskCep_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(198, 20);
            this.txtNome.TabIndex = 9;
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(64, 80);
            this.mskCelular.Mask = "00 00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(100, 20);
            this.mskCelular.TabIndex = 8;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(65, 54);
            this.mskTelefone.Mask = "00 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(100, 20);
            this.mskTelefone.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bairro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rua:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cep:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Celular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboDiaSemana);
            this.groupBox2.Controls.Add(this.txtTitulo);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtDescricao);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.dtpData);
            this.groupBox2.Controls.Add(this.txtLocal);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(628, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 159);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro Compromisso";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(64, 130);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(198, 20);
            this.txtTitulo.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Título:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(64, 104);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(198, 20);
            this.txtDescricao.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "Descrição:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Dia da Semana:";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(63, 28);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(102, 20);
            this.dtpData.TabIndex = 19;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(64, 54);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(198, 20);
            this.txtLocal.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Local:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Data:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 175);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(93, 175);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(174, 175);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgvBtnExcluir
            // 
            this.dgvBtnExcluir.HeaderText = "Excluir";
            this.dgvBtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("dgvBtnExcluir.Image")));
            this.dgvBtnExcluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dgvBtnExcluir.Name = "dgvBtnExcluir";
            this.dgvBtnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBtnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvBtnExcluir.ToolTipText = "Clique aqui para excluir";
            // 
            // dgvBtnEditar
            // 
            this.dgvBtnEditar.HeaderText = "Editar";
            this.dgvBtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("dgvBtnEditar.Image")));
            this.dgvBtnEditar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dgvBtnEditar.Name = "dgvBtnEditar";
            // 
            // dgvCompromisso
            // 
            this.dgvCompromisso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompromisso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBtnExcluirCompromisso,
            this.dgvBtnEditarCompromisso});
            this.dgvCompromisso.Location = new System.Drawing.Point(12, 453);
            this.dgvCompromisso.Name = "dgvCompromisso";
            this.dgvCompromisso.Size = new System.Drawing.Size(920, 231);
            this.dgvCompromisso.TabIndex = 23;
            this.dgvCompromisso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompromisso_CellContentClick);
            // 
            // dgvBtnExcluirCompromisso
            // 
            this.dgvBtnExcluirCompromisso.HeaderText = "Excluir";
            this.dgvBtnExcluirCompromisso.Image = ((System.Drawing.Image)(resources.GetObject("dgvBtnExcluirCompromisso.Image")));
            this.dgvBtnExcluirCompromisso.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dgvBtnExcluirCompromisso.Name = "dgvBtnExcluirCompromisso";
            this.dgvBtnExcluirCompromisso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBtnExcluirCompromisso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvBtnExcluirCompromisso.ToolTipText = "Clique aqui para excluir";
            // 
            // dgvBtnEditarCompromisso
            // 
            this.dgvBtnEditarCompromisso.HeaderText = "Editar";
            this.dgvBtnEditarCompromisso.Image = ((System.Drawing.Image)(resources.GetObject("dgvBtnEditarCompromisso.Image")));
            this.dgvBtnEditarCompromisso.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dgvBtnEditarCompromisso.Name = "dgvBtnEditarCompromisso";
            // 
            // cboDiaSemana
            // 
            this.cboDiaSemana.FormattingEnabled = true;
            this.cboDiaSemana.Items.AddRange(new object[] {
            "DOMINGO",
            "SEGUNDA",
            "TERCA",
            "QUARTA",
            "QUINTA",
            "SEXTA",
            "SABADO"});
            this.cboDiaSemana.Location = new System.Drawing.Point(91, 78);
            this.cboDiaSemana.Name = "cboDiaSemana";
            this.cboDiaSemana.Size = new System.Drawing.Size(171, 21);
            this.cboDiaSemana.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 715);
            this.Controls.Add(this.dgvCompromisso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCadastro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromisso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCadastro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridViewImageColumn dgvBtnExcluir;
        private System.Windows.Forms.DataGridViewImageColumn dgvBtnEditar;
        private System.Windows.Forms.DataGridView dgvCompromisso;
        private System.Windows.Forms.DataGridViewImageColumn dgvBtnExcluirCompromisso;
        private System.Windows.Forms.DataGridViewImageColumn dgvBtnEditarCompromisso;
        private System.Windows.Forms.ComboBox cboDiaSemana;
    }
}

