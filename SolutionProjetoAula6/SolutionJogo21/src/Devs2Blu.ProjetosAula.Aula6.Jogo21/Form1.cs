using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.Aula6.Jogo21
{
    public partial class Form1 : Form
    {
        Player player1 = new Player();
        Player player2 = new Player();
        private int numAleatorio { get; set; }
        private int countUser { get; set; }
        private int countPc { get; set; }
        private int countRounds { get; set; }
        private int scoreAcumuladoPlayer = 0;
        private int scoreAcumuladoPc = 0;
        
        public Form1()
        {
            InitializeComponent();
            EstadoInicial();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            richTxtGeral.Text = "Escolha um número de 1 a 20";
            txtNumUser.Focus();
            txtNumUser.Enabled = true;
            txtNumPc.Enabled = false;
            btnInsertUser.Enabled = true;
            btnInsertPc.Enabled = true;
            groupBoxUser.Visible = true;
            groupBoxPc.Visible = true;
            btnStart.Text = "Próximo";
            btnStart.Enabled = false;
        }
        private void btnInsertUser_Click(object sender, EventArgs e)
        {
            
            int numUser, numPc;
            Int32.TryParse(txtNumUser.Text, out numUser);

            if (numUser >= 1 && numUser <= 20)
            {
                Random rd = new Random();
                numPc = rd.Next(1, 20);

                player1.Number = numUser;
                player2.Number = numPc;

                richTxtGeral.Text = $"Jogador escolheu o número {numUser}";
                richTxtGeral.Text += $"\nComputador está escolhendo seu número...";
                Thread.Sleep(2000);
                txtNumPc.Text = numPc.ToString();

                btnInsertUser.Enabled = false;
                txtNumUser.Enabled = false;
            }
            else
            {
                richTxtGeral.Text = "Digite um número no intervalo correto";
            }            
        }
        private void btnInsertPc_Click(object sender, EventArgs e)
        {
            txtNumUser.Text = "";
            txtNumPc.Text = "";
            richTxtGeral.Text += $"\nComputador escolheu o número {player2.Number}";
            richTxtGeral.Text += $"\n\nAperte Resultado para continuar.";
            btnNext.Visible = true;

            btnInsertPc.Enabled = false;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            btnNext.Visible = false;
            btnStart.Enabled = true;

            Random rd = new Random();
            numAleatorio = rd.Next(1, 20);

            richTxtGeral.Text = $"Número Aleatório: {numAleatorio}";
            
            player1.Score = player1.CalcularPontos(player1.Number, numAleatorio);
            player2.Score = player2.CalcularPontos(player2.Number, numAleatorio);
                        
            scoreAcumuladoPlayer += player1.Score;
            scoreAcumuladoPc += player2.Score;

            richTxtGeral.Text += $"\n\nPontos jogador: {player1.Score}";
            richTxtGeral.Text += $"\nPontos computador: {player2.Score}";

            VerificarRodada();

            if(countRounds == 3)
            {
                MensagemResultado();
                EstadoInicial();                
            }
        }
        private void VerificarRodada()
        {
            if (player1.Score > player2.Score)
            {
                richTxtGeral.Text += "\n\nParabéns, você ganhou essa rodada!";
                countUser++;
            }
            else if (player2.Score > player1.Score)
            {
                richTxtGeral.Text += "\n\nQue pena, você perdeu essa rodada!";
                countPc++;
            }
            else
            {
                richTxtGeral.Text += "\n\nEmpate!";
            }
            richTxtUser.Text = $"Pontos totais: {scoreAcumuladoPlayer}";
            richTxtUser.Text += $"\nRodadas ganhas: {countUser}";

            richTxtPc.Text = $"Pontos totais: {scoreAcumuladoPc}";
            richTxtPc.Text += $"\nRodadas ganhas: {countPc}";

            countRounds++;
        }
        private void MensagemResultado()
        {
            if (scoreAcumuladoPlayer > scoreAcumuladoPc)
            {
                MessageBox.Show("Você ganhou o jogo!", "Resultado");
            }
            else if (scoreAcumuladoPc > scoreAcumuladoPlayer)
            {
                MessageBox.Show("Você perdeu!", "Resultado", MessageBoxButtons.OK);
            }
        }
        private void EstadoInicial()
        {
            countPc = 0;
            countUser = 0;
            countRounds = 0;
            richTxtPc.Text = "";
            richTxtUser.Text = "";
            richTxtGeral.Text = "Pressione Iniciar para começar o Jogo 21!";
            btnStart.Text = "Iniciar";
            groupBoxPc.Visible = false;
            groupBoxUser.Visible = false;
            btnNext.Visible = false;
        }
        
    }
}
