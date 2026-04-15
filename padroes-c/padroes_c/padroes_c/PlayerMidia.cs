using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padroes_c
{
    internal class PlayerMidia
    {

        public PlayerMidia() { }

            public void Liga()
            {
                Console.WriteLine("Player de mídia ligado.");
            }

            public void Reproduzir()
            {
                Console.WriteLine("Reproduzindo mídia.");
            }

            public void Desliga()
            {
                Console.WriteLine("Player de mídia desligado.");
            }
        
    }
}
