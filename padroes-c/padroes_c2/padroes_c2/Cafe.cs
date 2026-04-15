using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padroes_c2
{
    internal class Cafe : Bebida
    {
        public override string Descricao()
        {
            return "Café Expresso";
        }

        public override double Custo()
        {
            return 5.0;
        }
    }
}
