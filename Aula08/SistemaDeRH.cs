using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
    public class SistemaDeRH
    {
        public List<Funcionario> funcionarios = new List<Funcionario>();

        public double calculaUmFuncionario(Funcionario funcionario)
        {
            return funcionario.salario * 1.05;
        }

        public void calculaBonus()
        {
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine($"{funcionario.nome}: {this.calculaUmFuncionario(funcionario)}");
            }
        }

    }
}
