using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.Loja
{
    public class Agua : Item
    {
        public Agua(string descricao, decimal valor) : base("Agua", descricao, valor)
        {
        }
    }
}
