using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pradroes_c
{
    internal class LuzAmbiente
    {
        public LuzAmbiente() { }
        public void Liga()
        {
            Console.WriteLine("Luz ambiente ligada.");
        }

        public void Desliga()
        {
            Console.WriteLine("Luz ambiente desligada.");
        }

        public void Diminuir()
        {
            Console.WriteLine("Luz ambiente reduzida.");
        }
        public void Aumentar()
        {
            Console.WriteLine("Luz ambiente aumentada.");
        }
    }
}
