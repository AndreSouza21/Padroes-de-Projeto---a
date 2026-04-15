using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padroes_c2
{
    internal class Canela : Adicional
    {
        public Canela(Bebida bebida) : base(bebida) { }

        public override string Descricao()
        {
            return bebida.Descricao() + " + Canela";
        }

        public override double Custo()
        {
            return bebida.Custo() + 1.5;
        }
    }
}
