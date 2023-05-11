using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
    public class Estagiario : Funcionario
    {
        public Estagiario(string nome, double salario) : base(nome, salario)
        {

        }

        public override void seApresentar()
        {
            Console.WriteLine("Souuuuu, o ..... esta... giario, olá!");
        }
    }
}
