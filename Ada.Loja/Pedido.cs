using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.Loja
{
    public class Pedido
    {
        public Pedido()
        {
            Id = Guid.NewGuid();
            Itens = new List<Item>();
        }

        public Guid Id { get; set; }
        public List<Item> Itens { get; set; }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }

        public decimal CalculaValorSubtotal()
        {
            decimal total = 0;
            foreach (var item in Itens) 
            {
                total += item.Valor;
            }

            return total;
        }

        public decimal CalculaValorTaxas(DateTime data)
        {
            decimal taxas = 0;
            foreach (var item in Itens)
            {
                var itemComTaxa = item as ItemComTaxa;

                if (itemComTaxa != null)
                {
                    taxas += itemComTaxa.ObterValorTotalTaxa(data);
                }
            }

            return taxas;
        }

        public decimal CalculaValorTotal(DateTime data)
        {
            return this.CalculaValorSubtotal() + this.CalculaValorTaxas(data);
        }
    }
}
