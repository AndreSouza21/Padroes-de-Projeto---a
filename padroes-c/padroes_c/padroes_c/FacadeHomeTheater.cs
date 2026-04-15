using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padroes_c
{
    internal class FacadeHomeTheater
    {
        private Tv Tv;
        private Projetor Projetor;
        private Reciver Reciver;
        private PlayerMidia PlayerMidia;
        private SistemaDeSom SistemaDeSom; 
        private LuzAmbiente LuzAmbiente;

        public FacadeHomeTheater(Tv tv, Projetor projetor, Reciver reciver, PlayerMidia playerMidia, SistemaDeSom sistemaDeSom, LuzAmbiente luzAmbiente)
        {
            this.Tv = tv;
            this.Projetor = projetor;
            this.Reciver = reciver;
            this.PlayerMidia = playerMidia;
            this.SistemaDeSom = sistemaDeSom;
            this.LuzAmbiente = luzAmbiente;
        }

        public void AssistirFilme()
        {
            Console.WriteLine("\nPreparando para assistir filme...");

            LuzAmbiente.Diminuir();
            Projetor.Liga();
            Tv.Liga();
            Reciver.Liga();
            SistemaDeSom.Liga();
            PlayerMidia.Liga();
            SistemaDeSom.Reproduzir();
            PlayerMidia.Reproduzir();
        }

        public void OuvirMusica()
        {
            Console.WriteLine("\nPreparando para ouvir música...");

            LuzAmbiente.Diminuir();
            Reciver.Liga();
            SistemaDeSom.Liga();
            SistemaDeSom.Reproduzir();
        }

        public void DesligarTudo()
        {
            Console.WriteLine("\nDesligando tudo...");

            PlayerMidia.Desliga();
            SistemaDeSom.Desliga();
            Reciver.Desliga();
            Projetor.Desliga();
            Tv.Desliga();
            LuzAmbiente.Aumentar();
            
        }

    }
}
