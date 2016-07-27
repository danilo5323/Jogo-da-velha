using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int processar(){
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
    }
}
