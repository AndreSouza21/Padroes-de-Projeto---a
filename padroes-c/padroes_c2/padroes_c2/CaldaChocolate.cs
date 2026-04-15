using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padroes_c2
{
    internal class CaldaChocolate : Adicional
    {
        public CaldaChocolate(Bebida bebida) : base(bebida) { }
        public override string Descricao()
        {
            return bebida.Descricao() + " + Calda de Chocolate";
        }
        public override double Custo()
        {
            return bebida.Custo() + 3.0;
        }
    }
}
