using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padroes_c2
{
    internal class Chantilly : Adicional
    {
        public Chantilly(Bebida bebida) : base(bebida) { }

        public override string Descricao()
        {
            return bebida.Descricao() + " + Chantilly";
        }

        public override double Custo()
        {
            return bebida.Custo() + 2.5;
        }
    }
}
