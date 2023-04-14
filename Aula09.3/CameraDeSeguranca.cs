using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula08;

namespace Aula09._3
{
    public interface IAcesso
    {
        Diretor diretor { get; set; }
        //public Estagiario estagiario { get; set; }
        Analista analista { get; set; }

        void show();
    }
    public class CameraDeSeguranca:IAcesso<Diretor,Analista>
    {
        Diretor diretor { get; set; }
        Analista analista { get; set; }

        public void show()
        {
            Console.WriteLine($"{acesso}Esteve aqui");
        }

    }
}
