using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.Loja
{
    public class Cerveja : ItemComTaxa
    {
        public Cerveja(string descricao, decimal valor) : base("Cerveja", descricao, valor)
        {
        }

        public override decimal ObterTaxa(DateTime data)
        {
            return 0.2M;
        }
    }
}
