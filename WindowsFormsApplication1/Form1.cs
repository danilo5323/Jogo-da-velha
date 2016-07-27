using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Matrix jogo = new Matrix();
        Pontuacao pontuacao = new Pontuacao();

        private void general_Click(object sender, EventArgs e) {
            Button botao = (Button)sender;
            botao.Text = valor();
            Int32 p1 = Int32.Parse(botao.Name.Substring(6,1));
            Int32 p2 = Int32.Parse(botao.Name.Substring(7,1));
        
            botao.Enabled = false;
            jogo.setMatrix(p1, p2, botao.Text);
            
            if (jogo.verificao())
            {
                MessageBox.Show(botao.Text + " ganhou!");
                
                pontuacao.addPontuacao(botao.Text);
                reseta();
            }

             if (jogo.validaEmpate())
             {
                 pontuacao.addPontuacao("e");
                MessageBox.Show("Empate");
                reseta();
            }
        }

        public void reseta() {
            //jogo.setMatrix(0, 0, " ");
            this.Close();
            
        }

        bool chave = true;

        String valor() { 
            if (chave ){
                chave = false;
                return "x";
            }else {
                chave = true;
                return "o";
            }
        }

        private void buttonReseta_Click(object sender, EventArgs e)
        {
            reseta();
        }

        
    }
}
