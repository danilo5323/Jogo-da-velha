using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Matrix
    {
        //private static String[,] matrix = new String[2, 2];
        private String[,] matrix = { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };


        public Matrix() { }

        public Matrix(Matrix input) {
            this.matrix = input.clone();
        }

        public Matrix(String [,] input)
        {
            this.matrix = input;
        }

        public bool estapreenchido(int coluna, int linha){
            if (matrix[coluna, linha] != " ") {
                return true;
            }else 
                return false;
        }
      /*  public String[,] clone() {
            return this.matrix;
        }
        */

        public String[,] clone()
        {
            String[,] str = new String[3,3];
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    str[i, j] = this.matrix[i, j];
                }
            }
            return str;
        }

        public void config(String[,] input) {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                  this.matrix[i, j] = input[i, j] ;
                }
            }
        }

        /// <summary>
        /// Configuraçao das linhas
        /// </summary>
        int[] linha0 = { 0, 0, 0, 1, 0, 2 };
        int[] linha1 = { 1, 0, 1, 1, 1, 2 };
        int[] linha2 = { 2, 0, 2, 1, 2, 2 };
        int[] coluna0 = { 0, 0, 1, 0, 2, 0 };
        int[] coluna1 = { 0, 1, 1, 1, 2, 1 };
        int[] coluna2 = { 0, 2, 1, 2, 2, 2 };
        int[] diagonall = { 0, 0, 1, 1, 2, 2 };
        int[] diagonalr = { 0, 2, 1, 1, 2, 0 };

        /// <summary>
        /// Verifica se há vencedor
        /// </summary>
        /// <returns>Retorna true se o jogo acabou</returns>
        public  bool verificao(){
            return(
            verifica(linha0) ||
            verifica(linha1) ||
            verifica(linha2) ||
            verifica(coluna0) ||
            verifica(coluna1) ||
            verifica(coluna2) ||
            verifica(diagonall) ||
            verifica(diagonalr)
            );
        }

        /// <summary>
        /// Realiza a jogada em determinado ponto da matrix
        /// </summary>
        /// <param name="c">coluna</param>
        /// <param name="l">linha</param>
        /// <param name="ch">valor do quadro</param>
        public void setMatrix(int c, int l, String ch){
            this.matrix[c,l] = ch;
        }

        /// <summary>
        /// Realiza a jogada em determinado ponto da matrix
        /// </summary>
        /// <param name="input">esquerda = coluna, direita = linha</param>
        /// <param name="ch"></param>
        public void setMatrix(int[] input, String ch)
        {
            int c = input[0], l = input[1];
            this.matrix[c, l] = ch;
        }

        /// <summary>
        /// valida se resultou em empate
        /// </summary>
        /// <returns></returns>
        public  Boolean validaEmpate() {

            int count = 0;

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (matrix[i, j] != " ")
                        count++;
                }
            }

            if (count == 9)
                return true;
            else
                return false;
        }


        /// <summary>
        /// valida se o jogador ganhou o jogo, entra uma linha
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public Boolean verifica(int n1, int n2, int m1,int m2,int p1,int p2){
            if (matrix[n1, n2].Equals(matrix[m1, m2]) && 
                matrix[m1, m2].Equals(matrix[p1, p2]) &&
                ! matrix[m1, m2].Equals(" ") && 
                ! matrix[p1, p2].Equals(" ") && 
                ! matrix[n1, n2].Equals(" "))
                return true;
            return false;
      
        }


        /// <summary>
        /// Verifica se existe ganhador na partida
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Boolean verifica(int []input)
        {
            int n1 = input[0],
                n2 = input[1],
                m1 = input[2],
                m2 = input[3],
                p1 = input[4],
                p2 = input[5];
            if (matrix[n1, n2].Equals(matrix[m1, m2]) &&
                matrix[m1, m2].Equals(matrix[p1, p2]) &&
                !matrix[m1, m2].Equals(" ") &&
                !matrix[p1, p2].Equals(" ") &&
                !matrix[n1, n2].Equals(" "))
                return true;
            return false;

        }

    }
    }


