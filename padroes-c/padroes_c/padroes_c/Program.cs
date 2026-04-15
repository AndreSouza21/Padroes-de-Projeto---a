using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padroes_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tv LG = new Tv();
            Projetor ProLG = new Projetor();
            Reciver Reci = new Reciver();
            PlayerMidia PlayerMidia = new PlayerMidia();
            LuzAmbiente LuzAmbiente = new LuzAmbiente();
            SistemaDeSom SistemaDeSom = new SistemaDeSom();

            FacadeHomeTheater HTheater = new FacadeHomeTheater(LG,ProLG,Reci,PlayerMidia,SistemaDeSom,LuzAmbiente);

            HTheater.AssistirFilme();
            HTheater.DesligarTudo();
            HTheater.OuvirMusica();
            HTheater.DesligarTudo();
        }
    }
}
