using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.Loja
{
    public class Destilado : ItemComTaxa
    {
        private const int DEZEMBRO = 12;
        public Destilado(string descricao, decimal valor) : base("Destilado", descricao, valor)
        {
        }

        public override decimal ObterTaxa(DateTime data)
        {
            if(data.Month == DEZEMBRO)
            {
                return 0.1M;
            }

            return 0.5M;
        }
    }
}
