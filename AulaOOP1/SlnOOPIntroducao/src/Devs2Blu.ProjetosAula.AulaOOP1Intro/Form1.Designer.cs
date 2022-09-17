
namespace Devs2Blu.ProjetosAula.AulaOOP1Intro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.groupBoxControles = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelNascimento = new System.Windows.Forms.Label();
            this.labelEndereço = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobreNome = new System.Windows.Forms.TextBox();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTipoFunc = new System.Windows.Forms.GroupBox();
            this.radioButtonDiretor = new System.Windows.Forms.RadioButton();
            this.radioButtonRecep = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            this.groupBoxControles.SuspendLayout();
            this.groupBoxTipoFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.groupBoxTipoFunc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtNascimento);
            this.groupBox1.Controls.Add(this.txtSobreNome);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.labelEndereço);
            this.groupBox1.Controls.Add(this.labelNascimento);
            this.groupBox1.Controls.Add(this.labelNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Funcionários";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.BackColor = System.Drawing.Color.White;
            this.groupBoxStatus.Controls.Add(this.textBox1);
            this.groupBoxStatus.Location = new System.Drawing.Point(577, 12);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(211, 249);
            this.groupBoxStatus.TabIndex = 1;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status";
            // 
            // groupBoxControles
            // 
            this.groupBoxControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBoxControles.Controls.Add(this.btnLimpar);
            this.groupBoxControles.Controls.Add(this.btnSalvar);
            this.groupBoxControles.Location = new System.Drawing.Point(577, 278);
            this.groupBoxControles.Name = "groupBoxControles";
            this.groupBoxControles.Size = new System.Drawing.Size(211, 160);
            this.groupBoxControles.TabIndex = 2;
            this.groupBoxControles.TabStop = false;
            this.groupBoxControles.Text = "Controles";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(17, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 191);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Cadastrando Funcionários";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(6, 28);
            this.labelNome.Name = "labelNome";
            this.labelNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNome.Size = new System.Drawing.Size(55, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // labelNascimento
            // 
            this.labelNascimento.AutoSize = true;
            this.labelNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNascimento.Location = new System.Drawing.Point(6, 76);
            this.labelNascimento.Name = "labelNascimento";
            this.labelNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNascimento.Size = new System.Drawing.Size(97, 20);
            this.labelNascimento.TabIndex = 1;
            this.labelNascimento.Text = "Nascimento:";
            // 
            // labelEndereço
            // 
            this.labelEndereço.AutoSize = true;
            this.labelEndereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereço.Location = new System.Drawing.Point(6, 124);
            this.labelEndereço.Name = "labelEndereço";
            this.labelEndereço.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEndereço.Size = new System.Drawing.Size(82, 20);
            this.labelEndereço.TabIndex = 2;
            this.labelEndereço.Text = "Endereço:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(183, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtSobreNome
            // 
            this.txtSobreNome.Location = new System.Drawing.Point(349, 28);
            this.txtSobreNome.Name = "txtSobreNome";
            this.txtSobreNome.Size = new System.Drawing.Size(132, 20);
            this.txtSobreNome.TabIndex = 5;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(183, 76);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtNascimento.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.Location = new System.Drawing.Point(327, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(59, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Anos";
            // 
            // groupBoxTipoFunc
            // 
            this.groupBoxTipoFunc.Controls.Add(this.radioButtonRecep);
            this.groupBoxTipoFunc.Controls.Add(this.radioButtonDiretor);
            this.groupBoxTipoFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTipoFunc.Location = new System.Drawing.Point(19, 171);
            this.groupBoxTipoFunc.Name = "groupBoxTipoFunc";
            this.groupBoxTipoFunc.Size = new System.Drawing.Size(233, 104);
            this.groupBoxTipoFunc.TabIndex = 10;
            this.groupBoxTipoFunc.TabStop = false;
            this.groupBoxTipoFunc.Text = "Tipo Funcionário";
            // 
            // radioButtonDiretor
            // 
            this.radioButtonDiretor.AutoSize = true;
            this.radioButtonDiretor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDiretor.Location = new System.Drawing.Point(15, 45);
            this.radioButtonDiretor.Name = "radioButtonDiretor";
            this.radioButtonDiretor.Size = new System.Drawing.Size(75, 24);
            this.radioButtonDiretor.TabIndex = 0;
            this.radioButtonDiretor.TabStop = true;
            this.radioButtonDiretor.Text = "Diretor";
            this.radioButtonDiretor.UseVisualStyleBackColor = true;
            // 
            // radioButtonRecep
            // 
            this.radioButtonRecep.AutoSize = true;
            this.radioButtonRecep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRecep.Location = new System.Drawing.Point(96, 45);
            this.radioButtonRecep.Name = "radioButtonRecep";
            this.radioButtonRecep.Size = new System.Drawing.Size(128, 24);
            this.radioButtonRecep.TabIndex = 1;
            this.radioButtonRecep.TabStop = true;
            this.radioButtonRecep.Text = "Recepcionista";
            this.radioButtonRecep.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalvar.Location = new System.Drawing.Point(17, 20);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(177, 33);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpar.Location = new System.Drawing.Point(17, 71);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(177, 33);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxControles);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aula OOP1 - Sistema de Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.groupBoxControles.ResumeLayout(false);
            this.groupBoxTipoFunc.ResumeLayout(false);
            this.groupBoxTipoFunc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSobreNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelEndereço;
        private System.Windows.Forms.Label labelNascimento;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxControles;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.GroupBox groupBoxTipoFunc;
        private System.Windows.Forms.RadioButton radioButtonRecep;
        private System.Windows.Forms.RadioButton radioButtonDiretor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
    }
}

