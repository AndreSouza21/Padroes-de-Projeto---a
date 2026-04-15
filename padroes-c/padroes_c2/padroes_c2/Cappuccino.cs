using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padroes_c2
{
    internal class Cappuccino : Bebida
    {
        public override string Descricao()
        {
            return "Cappuccino";
        }

        public override double Custo()
        {
            return 10.0;
        }
    }
}
