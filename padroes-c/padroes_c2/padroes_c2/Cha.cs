using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padroes_c2
{
    internal class Cha : Bebida
    {
        public override string Descricao()
        {
            return "Cha";
        }

        public override double Custo()
        {
            return 15.0;
        }
    }
}
