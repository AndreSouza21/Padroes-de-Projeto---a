using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padroes_c2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bebida Cafe = new Cafe();
            Cafe = new Chantilly(Cafe);
            Cafe = new Canela(Cafe);
            Cafe = new CaldaChocolate(Cafe);

            Console.WriteLine(Cafe.Descricao());
            Console.WriteLine(Cafe.Custo());

            Bebida Cappuccino = new Cappuccino();
            Cappuccino = new Leite(Cappuccino);
            Cappuccino = new CaldaChocolate(Cappuccino);

            Console.WriteLine(Cappuccino.Descricao());
            Console.WriteLine(Cappuccino.Custo());



        }
    }
}
