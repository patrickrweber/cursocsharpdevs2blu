
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
            this.dgvBtnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvBtnEditar = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgvCompromisso = new System.Windows.Forms.DataGridView();
            this.dgvBtnExcluirCompromisso = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvBtnEditarCompromisso = new System.Windows.Forms.DataGridViewImageColumn();
            this.btncCompromisso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dgvCadastro.Location = new System.Drawing.Point(12, 160);
            this.dgvCadastro.Name = "dgvCadastro";
            this.dgvCadastro.Size = new System.Drawing.Size(920, 253);
            this.dgvCadastro.TabIndex = 0;
            this.dgvCadastro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastro_CellContentClick);
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
            this.groupBox1.Size = new System.Drawing.Size(852, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro Contato";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(64, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "E-mail:";
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(568, 25);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(39, 21);
            this.cboUF.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(538, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "UF:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(665, 26);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(169, 20);
            this.txtRua.TabIndex = 14;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(665, 54);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(169, 20);
            this.txtCidade.TabIndex = 13;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(556, 55);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(51, 20);
            this.txtNumero.TabIndex = 12;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(438, 54);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(67, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(438, 25);
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
            this.mskCelular.Location = new System.Drawing.Point(243, 55);
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
            this.label8.Location = new System.Drawing.Point(617, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bairro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(630, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rua:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cep:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 55);
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
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 131);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(93, 131);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(174, 131);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgvCompromisso
            // 
            this.dgvCompromisso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompromisso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBtnExcluirCompromisso,
            this.dgvBtnEditarCompromisso});
            this.dgvCompromisso.Location = new System.Drawing.Point(12, 419);
            this.dgvCompromisso.Name = "dgvCompromisso";
            this.dgvCompromisso.Size = new System.Drawing.Size(920, 265);
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
            // btncCompromisso
            // 
            this.btncCompromisso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncCompromisso.Location = new System.Drawing.Point(255, 131);
            this.btncCompromisso.Name = "btncCompromisso";
            this.btncCompromisso.Size = new System.Drawing.Size(122, 23);
            this.btncCompromisso.TabIndex = 24;
            this.btncCompromisso.Text = "Inserir Compromisso";
            this.btncCompromisso.UseVisualStyleBackColor = false;
            this.btncCompromisso.Click += new System.EventHandler(this.btncCompromisso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 715);
            this.Controls.Add(this.btncCompromisso);
            this.Controls.Add(this.dgvCompromisso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCadastro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridViewImageColumn dgvBtnExcluir;
        private System.Windows.Forms.DataGridViewImageColumn dgvBtnEditar;
        private System.Windows.Forms.DataGridView dgvCompromisso;
        private System.Windows.Forms.DataGridViewImageColumn dgvBtnExcluirCompromisso;
        private System.Windows.Forms.DataGridViewImageColumn dgvBtnEditarCompromisso;
        private System.Windows.Forms.Button btncCompromisso;
    }
}

