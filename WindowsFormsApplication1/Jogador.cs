using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Jogador
    {

        public String nome;
        public Int32 pontuacao;

        public Jogador()
        {
            this.setNome("");
            this.pontuacao = 0;
        }

        public Jogador(String nome)
        {
            this.setNome(nome);
            this.pontuacao = 0;
        }

        public Jogador(String nome, Int32 pontuacao)
        {
            this.nome = nome;
            this.pontuacao = pontuacao;
        }

        public String getPontuacao()
        {
            return this.pontuacao.ToString();
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public void addPontuacao()
        {
            this.pontuacao++;
        }
    }
}
