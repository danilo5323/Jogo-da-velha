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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pontuacao = new Pontuacao();
        }
        Pontuacao pontuacao ;


        public void atualizarLabel(object sender, EventArgs e) {
            labelPontuacao.Text = pontuacao.ToString();
        }

        private void buttonJogar_Click(object sender, EventArgs e)
        {
            //labelPontuacao.Text = "Jogador A" + Pontuacao.jogador1.getPontuacao() +
              //                    "Jogador B" + Pontuacao.jogador2.getPontuacao();


            Form1 form = new Form1();
            Thread.CurrentThread.Suspend();
            form.Show();
            Thread.CurrentThread.Start();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
