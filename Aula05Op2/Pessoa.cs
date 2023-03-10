using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Op2
{
    public class Pessoa
    {
        public string nome;
        public float peso;
        public int andarAtual;
        public int andarDesejado;

        public Pessoa(string nome,float peso,int andarAtual,int andarDesejado)
        {
            this.nome = nome;
            this.peso = peso;
            this.andarAtual = andarAtual;
            this.andarDesejado = andarDesejado;
        }
    }
}
