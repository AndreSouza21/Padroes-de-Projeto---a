using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padroes_c
{
    internal class SistemaDeSom
    {
        public SistemaDeSom() { }

        public void Liga()
        {
            Console.WriteLine("Sistema de som ligado.");
        }

        public void Desliga()
        {
            Console.WriteLine("Sistema de som desligado.");
        }

        public void Reproduzir()
        {
            Console.WriteLine("Reproduzindo som.");
        }
    }
}
