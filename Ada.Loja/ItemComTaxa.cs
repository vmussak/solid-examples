using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.Loja
{
    public abstract class ItemComTaxa : Item
    {
        public ItemComTaxa(string categoria, string descricao, decimal valor) : base(categoria, descricao, valor)
        {
        }

        public abstract decimal ObterTaxa(DateTime data);

        public decimal ObterValorTotalTaxa(DateTime data)
        {
            return this.ObterTaxa(data) * this.Valor;
        }
    }
}
