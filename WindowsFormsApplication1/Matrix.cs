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
        /// <summary>
        /// Verifica se ganhou
        /// </summary>
        /// <returns></returns>
        public  bool verificao(){
            return(
            verifica(0,0,  0,1, 0,2) ||
            verifica(1,0,  1,1, 1,2) ||
            verifica(2,0,  2,1, 2,2) ||
            verifica(0,0,  1,0,  2,0) ||
            verifica(0,1,  1,1,  2,1) ||
            verifica(0,2,  1,2,  2,2) ||
            verifica(0,0,  1,1,  2,2)||
            verifica(0,2,  1,1,  2,0)
            );
        }

        public void setMatrix(int c, int l, String ch){
            this.matrix[c,l] = ch;
        }

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

        public Boolean verifica(int n1, int n2, int m1,int m2,int p1,int p2){
            if (matrix[n1, n2].Equals(matrix[m1, m2]) && 
                matrix[m1, m2].Equals(matrix[p1, p2]) &&
                ! matrix[m1, m2].Equals(" ") && 
                ! matrix[p1, p2].Equals(" ") && 
                ! matrix[n1, n2].Equals(" "))
                return true;


            return false;
        
        }
/* 
0,0  0,1  0,2
1,0  1,1  1,2
2,0  2,1  2,2

0,0  1,0  2,0
0,1  1,1  2,1
0,2  1,2  2,2

0,0  1,1  2,2
0,2  1,1  2,0
            * */
            
        }
    }

