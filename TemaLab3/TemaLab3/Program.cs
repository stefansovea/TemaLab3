using System;
using System.Configuration;

namespace TemaLab3
{
    //    Suma/diferenta a doua numere preluate de la tastatura
    class Program
    {
        static void Main()
        {
            long buget;
            Automobile audi = new Automobile("audi", "Rosu", 50000);
            string a = audi.afisare();
            Console.WriteLine(a);
            Automobile bmw = new Automobile("bmw", "Albastru", 70000);
            string b = bmw.afisare();
            Console.WriteLine(b);
            Automobile toyota = new Automobile("toyota", "Alb", 20000);
            string c = toyota.afisare();
            Automobile dacia = new Automobile("dacia,verde,10000");
            Console.WriteLine(c);
            string d = dacia.afisare();
            Console.WriteLine(d);
            Console.WriteLine("Optiunea dorita:");
            string optiune = Console.ReadLine();
            Console.WriteLine("Introduceti bugetul dumneavoastra:");
            buget = Convert.ToInt64(Console.ReadLine());
            if (optiune.Equals(audi.getmarca()))
                Console.WriteLine(audi.verifica(buget));
            if (optiune.Equals(bmw.getmarca()))
                Console.WriteLine(bmw.verifica(buget));
            if (optiune.Equals(toyota.getmarca()))
                Console.WriteLine(toyota.verifica(buget));


        }
    }
}