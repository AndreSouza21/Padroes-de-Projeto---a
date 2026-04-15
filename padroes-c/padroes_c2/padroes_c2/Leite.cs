using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padroes_c2
{
    internal class Leite : Adicional
    {
        public Leite(Bebida bebida) : base(bebida) { }

        public override string Descricao()
        {
            return bebida.Descricao() + " + Leite";
        }

        public override double Custo()
        {
            return bebida.Custo() + 2.0;
        }
    }
}
