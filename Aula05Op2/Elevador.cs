using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Op2
{
    public class Elevador
    {
        public int andarAtual = 0;
        public int totalAndares = 21;
        public float pesoMax = 100;
        public float pesoAtual = 0;
        public bool porta = true;
        List<Pessoa> pessoas = new List<Pessoa>();

        public void Movimento(int andar)
        {
            if (andar>this.andarAtual)
            {

            }else if (andar < this.andarAtual)
            {

            }
            if (this.porta)
            {
                this.porta = false;
                Console.WriteLine("Elevador abriu a porta");
            }
        }

        
    }
}
