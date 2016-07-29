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


        public int[] pense(Matrix matrix) {
            int [] n = new calculaMatrix().procura(matrix);



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

        public int[] returnRandom()
        {
            Random rnd = new Random();
        int month = rnd.Next(1, 13);


        int columnRandom = rnd.Next(0, 1000) % 3;
        int lineRandom = rnd.Next(0, 1000) % 3;
        int[] n = { columnRandom, lineRandom };

            return n;
        }

    public int[] procura(Matrix input) {
            ///codigo para busca da melhor jogada.
            ///
            //int[] n = { 23, 2 };
            int cColuna = 3;
            int cLinha = 3;

            Matrix matrix = new Matrix();

            String[,] k = input.clone();



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
                        matrix.setMatrix(v, "o");
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

            k = input.clone();
        
        
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
                        matrix.setMatrix(v, "x");
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
                int[] n = returnRandom();
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
