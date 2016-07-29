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
    public partial class Jogo : Form
    {
        public Jogo()
        {
            InitializeComponent();
        }
        public Jogo(String playerA, String playerB)
        {
            player1 = playerA;
            player2 = playerB;
            InitializeComponent();
        }

        public static String player1 = "x";
        public static String player2 = "o"; 
        
        private void Form1_Load(object sender, EventArgs e)
        {
            if (player1 == "X")
            {
                start = false;
                JogadaMaquina();
            }
        }
        Matrix jogo = new Matrix();
        


        bool start = true;

        private void general_Click(object sender, EventArgs e) {
            
            Button botao = (Button)sender;

            botao.Font.Size.Equals( 16 );
            //botao.Font.sets = 8.25;
            //botao.Text = valor();
            botao.Text = player1;

            Int32 p1 = Int32.Parse(botao.Name.Substring(6,1));
            Int32 p2 = Int32.Parse(botao.Name.Substring(7,1));
        
            botao.Enabled = false;
            jogo.setMatrix(p1, p2, botao.Text);
            
            if (jogo.verificao())
            {
                MessageBox.Show(botao.Text + " ganhou!");
                
                
                reseta();
                return;
            }

             if (jogo.validaEmpate())
             {
                 
                MessageBox.Show("Empate");
                reseta();
                return;
            }

            //JogadaMaquina();
             JogadaMaquina();
        }


        private void JogadaMaquina() {
            

            int[] posicao  = new MatrixArvore(player1, player2).pense(jogo, player1 );

            Button botao = getButton(posicao); //= (Button) t.GetMethod();//= (Button) ("button00");
            //String p1 = "p1";
            //String p2 = "p2";

            //botao.Text = valor();



            botao.Text = player2;
            botao.Enabled = false;

            jogo.setMatrix(posicao, botao.Text);

            if (jogo.verificao())
            {
                MessageBox.Show(botao.Text + " ganhou!");
                reseta();
                return;
            }

            if (jogo.validaEmpate())
            {
                
                MessageBox.Show("Empate");
                reseta();
                return;
            }
        }

        public Button getButton(int [] input) {
            String n = input[0] + input[1].ToString();

            switch (n)
            {
                case ("00"):
                    return button00;
                case ("01"):
                    return button01;
                case ("02"):
                    return button02;

                case ("10"):
                    return button10;
                case ("11"):
                    return button11;
                case ("12"):
                    return button12;

                case ("20"):
                    return button20;
                case ("21"):
                    return button21;
                case ("22"):
                    return button22;
            }
            return new Button();
        }

        private int[] getPosicaoMaquina() {
            ///codigo para realizar o processamento das jogadas aleatoriamente.
            ///
            Random rnd = new Random();
            int month = rnd.Next(1, 13);

            
            int columnRandom = rnd.Next(0, 1000) % 3;
            int lineRandom   = rnd.Next(0, 1000) % 3;
            int[] n = { columnRandom, lineRandom };
            


            return n;
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
