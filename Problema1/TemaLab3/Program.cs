using System;
using System.Configuration;

namespace TemaLab3
{
    class Program
    {
        static void Main()
        {
            int x, q, b;
            long buget;
            Automobile[] masini = new Automobile[4];
            Automobile audi = new Automobile("audi", "rosu", 50000);
            Automobile bmw = new Automobile("bmw", "albastru", 70000);
            Automobile toyota = new Automobile("toyota", "alb", 20000);
            Automobile dacia = new Automobile("dacia,verde,10000");
            masini[0] = audi;
            masini[1] = bmw;
            masini[2] = toyota;
            masini[3] = dacia;
            do
            {
                Console.Clear();
                Console.WriteLine("     MENIU    ");
                Console.WriteLine("A: Afisati modelele disponibile:");
                Console.WriteLine("P: Verificare masina in functie de preferinte");
                Console.WriteLine("C: Optiuni in functie de Culoare  ");
                Console.WriteLine("M: Optiuni in functie de Marca ");
                Console.WriteLine("B: Optiuni in functie de Buget");
                Console.WriteLine("I: Info autor ");
                Console.WriteLine("X: Iesire ");
                x = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (x)
                {
                    case 'i':
                        Console.WriteLine("Sovea Stefan, grupa 3121A");
                        Console.ReadKey();
                        break;
                    case 'x':
                        Environment.Exit(1);
                        break;
                    case 'a':
                        Console.WriteLine("Optiuni disponibile:");
                        Console.WriteLine();
                        for (int j = 0; j < 4; j++)
                        {
                            string c = masini[j].afisare();
                            Console.Write(c);
                        }
                        Console.ReadKey();
                        break;
                    case 'p':
                        Console.WriteLine("Marca dorita:");
                        string optiune = Console.ReadLine();
                        Console.WriteLine("Culoarea dorita:");
                        string opcul = Console.ReadLine();
                        Console.WriteLine("Introduceti bugetul dumneavoastra:");
                        buget = Convert.ToInt64(Console.ReadLine());
                        q = 0;
                        for (int j = 0; j < 4; j++)
                        {
                            q = masini[j].Preferinte(optiune, opcul, buget);
                            if (q == 1)
                            {
                                Console.WriteLine("Optiunea exista si va permiteti sa o achizitionati");
                                break;
                            }
                            if (q == 2)
                            {
                                Console.WriteLine("Optiunea exista, dar nu va permiteti sa o achizitionati");
                                break;
                            }
                        }
                        if (q == 0)
                            Console.WriteLine("Optiunea nu exista ");
                        Console.ReadKey();
                        break;
                    case 'c':
                        Console.WriteLine("Introduceti culoarea cautata:");
                        string cul = Console.ReadLine();
                        b = 0;
                        for (int t = 0; t < 4; t++)
                        {
                            b = 0;
                            b = masini[t].verifCuloare(cul);
                            if (b == 1)
                            {
                                Console.WriteLine(masini[t].afisare());
                                break;
                            }
                        }
                        if (b == 0)
                            Console.WriteLine("Nu sunt optiuni disponibile");
                        Console.ReadKey();
                        break;
                    case 'm':
                        Console.WriteLine("Introduceti marca cautata:");
                        string mar = Console.ReadLine();
                        b = 0;
                        for (int t = 0; t < 4; t++)
                        {
                            b = 0;
                            b = masini[t].verifMarca(mar);
                            if (b == 1)
                            {
                                Console.WriteLine(masini[t].afisare());
                                break;
                            }

                        }
                        if (b == 0)
                            Console.WriteLine("Nu sunt optiuni disponibile");

                        Console.ReadKey();
                        break;
                    case 'b':
                        Console.WriteLine("Introduceti bugetul de care dispuneti:");
                        long bug = Convert.ToInt64(Console.ReadLine());
                        b = 0;
                        for (int t = 0; t < 4; t++)
                        {
                            b = 0;
                            b = masini[t].verifPret(bug);
                            if (b == 1)
                                Console.WriteLine(masini[t].afisare());
                        }
                        if (b == 0)
                            Console.WriteLine("Nu sunt optiuni disponibile");
                        Console.ReadKey();
                        break;

                }

            } while (1 != 0);
            Console.ReadKey();
        }
    }
}