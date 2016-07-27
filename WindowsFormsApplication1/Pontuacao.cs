using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Pontuacao
    {
        public static Jogador jogador1 = new Jogador("x");
        public static Jogador jogador2 = new Jogador("o");

        public void addPontuacao(String name) {
            if (name == jogador1.nome){
                jogador1.pontuacao ++;
            }
            else if(name == jogador2.nome){
                jogador2.pontuacao++;
            }
            else if (name == "e") { 
                
            }
        }

        public override string ToString()
        {
            return jogador1.nome + ": " + jogador1.pontuacao + "   " 
                  + jogador2.nome + ": " + jogador2.pontuacao;
        }

       
    }

    
    
}
