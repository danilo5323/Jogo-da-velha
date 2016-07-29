using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

        }

        public void atualizarLabel(object sender, EventArgs e) {
            
        }

        private String player1 = "", player2 = "";


        private void buttonJogar_Click(object sender, EventArgs e)
        {
            //labelPontuacao.Text = "Jogador A" + Pontuacao.jogador1.getPontuacao() +
              //                    "Jogador B" + Pontuacao.jogador2.getPontuacao();


            //Jogo form = new Jogo();
            Jogo form = new Jogo(player1, player2);
            //Thread.CurrentThread.Suspend();
            form.Show();
            //Thread.CurrentThread.Start();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonX_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonX.Checked)
            {
                player2 = "O";
                player1 = "X";
            }
        }

        private void radioButtonO_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonO.Checked)
            {
                player2 = "X";
                player1 = "O";
            }
        }
    }
}
