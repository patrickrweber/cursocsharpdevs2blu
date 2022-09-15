
namespace Devs2Blu.ProjetosAula.Aula6.Jogo21
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
            this.txtNumUser = new System.Windows.Forms.TextBox();
            this.btnInsertUser = new System.Windows.Forms.Button();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.richTxtUser = new System.Windows.Forms.RichTextBox();
            this.groupBoxPc = new System.Windows.Forms.GroupBox();
            this.richTxtPc = new System.Windows.Forms.RichTextBox();
            this.txtNumPc = new System.Windows.Forms.TextBox();
            this.btnInsertPc = new System.Windows.Forms.Button();
            this.groupBoxConsole = new System.Windows.Forms.GroupBox();
            this.richTxtGeral = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxPc.SuspendLayout();
            this.groupBoxConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumUser
            // 
            this.txtNumUser.BackColor = System.Drawing.Color.Salmon;
            this.txtNumUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumUser.Location = new System.Drawing.Point(6, 185);
            this.txtNumUser.Name = "txtNumUser";
            this.txtNumUser.Size = new System.Drawing.Size(100, 29);
            this.txtNumUser.TabIndex = 4;
            // 
            // btnInsertUser
            // 
            this.btnInsertUser.BackColor = System.Drawing.Color.LightGreen;
            this.btnInsertUser.Location = new System.Drawing.Point(112, 185);
            this.btnInsertUser.Name = "btnInsertUser";
            this.btnInsertUser.Size = new System.Drawing.Size(102, 29);
            this.btnInsertUser.TabIndex = 5;
            this.btnInsertUser.Text = "OK!";
            this.btnInsertUser.UseVisualStyleBackColor = false;
            this.btnInsertUser.Click += new System.EventHandler(this.btnInsertUser_Click);
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBoxUser.Controls.Add(this.richTxtUser);
            this.groupBoxUser.Controls.Add(this.txtNumUser);
            this.groupBoxUser.Controls.Add(this.btnInsertUser);
            this.groupBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUser.Location = new System.Drawing.Point(18, 210);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(220, 227);
            this.groupBoxUser.TabIndex = 6;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "Jogador";
            // 
            // richTxtUser
            // 
            this.richTxtUser.BackColor = System.Drawing.Color.Salmon;
            this.richTxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtUser.Location = new System.Drawing.Point(6, 40);
            this.richTxtUser.Name = "richTxtUser";
            this.richTxtUser.ReadOnly = true;
            this.richTxtUser.Size = new System.Drawing.Size(208, 126);
            this.richTxtUser.TabIndex = 6;
            this.richTxtUser.Text = "";
            // 
            // groupBoxPc
            // 
            this.groupBoxPc.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBoxPc.Controls.Add(this.richTxtPc);
            this.groupBoxPc.Controls.Add(this.txtNumPc);
            this.groupBoxPc.Controls.Add(this.btnInsertPc);
            this.groupBoxPc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPc.Location = new System.Drawing.Point(588, 210);
            this.groupBoxPc.Name = "groupBoxPc";
            this.groupBoxPc.Size = new System.Drawing.Size(220, 227);
            this.groupBoxPc.TabIndex = 7;
            this.groupBoxPc.TabStop = false;
            this.groupBoxPc.Text = "Computador";
            // 
            // richTxtPc
            // 
            this.richTxtPc.BackColor = System.Drawing.Color.Salmon;
            this.richTxtPc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtPc.Location = new System.Drawing.Point(6, 40);
            this.richTxtPc.Name = "richTxtPc";
            this.richTxtPc.ReadOnly = true;
            this.richTxtPc.Size = new System.Drawing.Size(208, 126);
            this.richTxtPc.TabIndex = 6;
            this.richTxtPc.Text = "";
            // 
            // txtNumPc
            // 
            this.txtNumPc.BackColor = System.Drawing.Color.Salmon;
            this.txtNumPc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPc.Location = new System.Drawing.Point(6, 185);
            this.txtNumPc.Name = "txtNumPc";
            this.txtNumPc.Size = new System.Drawing.Size(100, 29);
            this.txtNumPc.TabIndex = 4;
            // 
            // btnInsertPc
            // 
            this.btnInsertPc.BackColor = System.Drawing.Color.LightGreen;
            this.btnInsertPc.Location = new System.Drawing.Point(112, 185);
            this.btnInsertPc.Name = "btnInsertPc";
            this.btnInsertPc.Size = new System.Drawing.Size(102, 29);
            this.btnInsertPc.TabIndex = 5;
            this.btnInsertPc.Text = "OK!";
            this.btnInsertPc.UseVisualStyleBackColor = false;
            this.btnInsertPc.Click += new System.EventHandler(this.btnInsertPc_Click);
            // 
            // groupBoxConsole
            // 
            this.groupBoxConsole.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBoxConsole.Controls.Add(this.btnNext);
            this.groupBoxConsole.Controls.Add(this.richTxtGeral);
            this.groupBoxConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxConsole.Location = new System.Drawing.Point(18, 12);
            this.groupBoxConsole.Name = "groupBoxConsole";
            this.groupBoxConsole.Size = new System.Drawing.Size(784, 177);
            this.groupBoxConsole.TabIndex = 7;
            this.groupBoxConsole.TabStop = false;
            this.groupBoxConsole.Text = "Resultados";
            // 
            // richTxtGeral
            // 
            this.richTxtGeral.BackColor = System.Drawing.Color.Salmon;
            this.richTxtGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtGeral.Location = new System.Drawing.Point(6, 28);
            this.richTxtGeral.Name = "richTxtGeral";
            this.richTxtGeral.ReadOnly = true;
            this.richTxtGeral.Size = new System.Drawing.Size(772, 143);
            this.richTxtGeral.TabIndex = 6;
            this.richTxtGeral.Text = "Pressione \"Iniciar\" para começar o Jogo 21!";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(334, 250);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 41);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightGreen;
            this.btnNext.Location = new System.Drawing.Point(673, 137);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 34);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Resultado";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(820, 444);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBoxConsole);
            this.Controls.Add(this.groupBoxPc);
            this.Controls.Add(this.groupBoxUser);
            this.Name = "Form1";
            this.Text = "Jogo21";
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.groupBoxPc.ResumeLayout(false);
            this.groupBoxPc.PerformLayout();
            this.groupBoxConsole.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumUser;
        private System.Windows.Forms.Button btnInsertUser;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.RichTextBox richTxtUser;
        private System.Windows.Forms.GroupBox groupBoxPc;
        private System.Windows.Forms.RichTextBox richTxtPc;
        private System.Windows.Forms.TextBox txtNumPc;
        private System.Windows.Forms.Button btnInsertPc;
        private System.Windows.Forms.GroupBox groupBoxConsole;
        private System.Windows.Forms.RichTextBox richTxtGeral;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnNext;
    }
}

