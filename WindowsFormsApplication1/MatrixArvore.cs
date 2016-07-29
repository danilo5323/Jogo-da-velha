using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class MatrixArvore
    {
        Matrix raiz = null;

        Matrix[,] jogo;
        /// <summary>
        /// Construtor da raiz sem parametros
        /// </summary>
        public MatrixArvore() {
            raiz = new Matrix();
        }

        String player1, player2;
        public MatrixArvore(String player1, String player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            raiz = new Matrix();
        }

        /// <summary>
        /// Construtor da arvore para processamento
        /// </summary>
        /// <param name="raiz"></param>
        public MatrixArvore(Matrix raiz) {
            this.raiz = raiz;
        }

        /// <summary>
        /// deve retornar uma pontuação quanto a cada opção a ser jogada
        /// </summary>
        /// <returns></returns>
        public int processar() {
            return new Int32();
        }

        /// <summary>
        /// Busca recursiva para trazer a pontuação da jogada
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int pontuacao(Matrix node) {

            return new Int32();
        }


        public int[] pense(Matrix matrix, String ps) {
            int [] n = new calculaMatrix().procura(matrix, player1, player2);
            return n;

        }
    }



    class calculaMatrix{
        private Matrix raiz;
        private Matrix dados;

        private calculaMatrix[] node;

        public calculaMatrix() {
            raiz = new Matrix();
            node = new calculaMatrix[9];
        }

        public calculaMatrix(Matrix input)
        {
            raiz = new Matrix();
        }

        public Matrix add(Matrix matrix) {

            
            return matrix;
        }


        private int ProcCol = 0;
        private int ProcLin = 0;

        public Int32[] calcularJogada(Matrix input)
        {

            Int32[] tmp = null;
            IList<Int32[]> retorno = new List<Int32[]>();

            Matrix tmpMatrix = new Matrix();
            tmpMatrix.config(input.clone());


            Random rnd = new Random();
            int tmpRandom = rnd.Next(1, 1000);
            int count = 0;

            //verifica a jogada no centro
            if (!tmpMatrix.estapreenchido(1, 1) && Jogo.player1.Equals("O"))
            {
                tmp = new Int32[] { 1, 1 };
                return tmp;
            }

            //busca jogada nos cantos das diagonais
            for (int i = 0; i <= 2; i += 2)
            {
                for (int j = 0; j <= 2; j += 2)
                {
                    if (!tmpMatrix.estapreenchido(i, j))
                    {
                        tmp = new Int32[]{ i, j };
                        retorno.Add(tmp);
                        count++;
                    }
                }
            }

            if(count>0)
                return retorno[tmpRandom % count];

            /*

            //verifica a jogada no centro
            if (!tmpMatrix.estapreenchido(1, 1))
            {
                tmp = new Int32[] { 1, 1 };
                return tmp;
            }
            */
            

            //verifica a jogada nos cantos
            for (int i = 1; i <= 2; i ++)
            {
                for (int j = 1; j <= 2; j ++)
                {
                    if (!tmpMatrix.estapreenchido(i, j))
                    {
                        tmp = new Int32[] { i, j };
                        retorno.Add(tmp);
                        count++;
                        
                    }
                }
            }

            
            return retorno[tmpRandom % count];
            //0,1 - 2,1 - 1,0 - 1,2
            
            //return n;

                /*
            
                 */
        }

    public int[] procura(Matrix input, String player1, String player2) {


        int cColuna = 3;
        int cLinha = 3;

        Matrix matrix = new Matrix();

        int[] lista;    

        for (int i = 0; i < cColuna; i++)
        {
            for (int j = 0; j < cLinha; j++)
            {
                int[] v = { i, j };
                matrix = new Matrix();
                //matrix.Equals(input);
                matrix.config(input.clone());

                if (!matrix.estapreenchido(i, j))
                {
                    matrix.setMatrix(v, player2);
                    if (matrix.verificao())
                    {
                        int[] retorno = { i, j };
                        return retorno;
                    }
                }
                else
                {
                }
                matrix = null;
            }
        }

        for (int i = 0; i < cColuna; i++)
            {
                for (int j = 0; j < cLinha; j++)
                {
                    int[] v = { i, j };
                    matrix = new Matrix();
                    //matrix.Equals(input);
                    matrix.config(input.clone());

                    if (!matrix.estapreenchido(i, j))
                    {
                        matrix.setMatrix(v, player1);
                        if (matrix.verificao())
                        {
                            int[] retorno = { i, j };
                            return retorno;
                        }
                    }
                    else
                    {
                    }
                    matrix = null;
                }
            }

            while (true)
            {
                int[] n = calcularJogada(input);
                ///funcao recursiva para encontrar a melhor posição
                ///int[] n = verificarProximaJogada();
                if (!input.estapreenchido(n[0], n[1]))
                {
                    //MessageBox.Show("jogada aleatoria");
                    return n;
                }
            }
            
        }


        
        //public int getPontuacao() { }
    }
}
