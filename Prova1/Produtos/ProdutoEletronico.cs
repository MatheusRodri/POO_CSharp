using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTurmaA.Produtos
{
    public class ProdutoEletronico:Produto
    {
        

        public ProdutoEletronico(string nome,string marca,float preco,float peso,DateTime? garantia,DateTime? validade):base(nome, marca, preco, peso,garantia, null)
        {
            
        }

    }
}
