using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padroes_c2
{
    internal abstract class Adicional : Bebida
    {
        protected Bebida bebida;

        public Adicional(Bebida bebida)
        {
            this.bebida = bebida;
        }
    }
}
