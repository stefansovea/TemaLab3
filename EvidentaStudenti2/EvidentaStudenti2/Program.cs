using LibrarieEntitati;
using System;


namespace ManagementStudenti
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[,] _note = new int[4, 15];
            Student s = new Student("Ionescu");
           // s.SetNote("1 2 3 4 5 6 7");      
            char c;
            do
            {
                Console.Clear();
                Console.WriteLine("     MENIU    ");
                Console.WriteLine("S: Citire note de la tastatura ca un sir de caractere");
                Console.WriteLine("T: Citire note de la tastatura (câte o nota pe rand)");
                Console.WriteLine("C: Citire note din linia de comanda ");
                Console.WriteLine("A: Afisare note ");
                Console.WriteLine("I: Info autor ");
                Console.WriteLine("X: Iesire ");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (c)
                {
                    case 'i':
                        Console.WriteLine("Sovea Stefan, grupa 3121A");
                        Console.ReadKey();
                        break;
                    case 'x':
                        Environment.Exit(1);
                        break;
                    case 's':
                        Console.WriteLine("Introduceti notele:");
                        string note_ = s.CitireSirCaractere();
                        s.SetNote(note_);
                        Console.ReadKey();
                        break;
                    case 'a':
                        Console.WriteLine(s.ConversieLaSir());
                        int sub, peste;
                        s.NumarareNote(out sub, out peste);
                        Console.WriteLine("Are {0} note sub nota 5",sub);
                        Console.WriteLine("Are {0} note peste nota 5",peste);
                        Console.ReadKey();
                        break;
                    case 't':
                        for (int i=0;i<4;i++)
                        {
                            Console.WriteLine("Introduceti numarul de note:");
                            n = Convert.ToInt32(Console.ReadLine());
                            for (int j = 0; j < n; j++)
                            {
                                _note[i,j] = Convert.ToInt32(Console.ReadLine());
                            }                             
                        }
                        s.SetNote(_note);
                        Console.ReadKey();
                        break;
                    case 'c':
                        string str = String.Join(" ", args);
                        s.SetNote(str);
                        Console.ReadKey();
                        break;

                }

            } while (1 != 0);
            Console.ReadKey();
        }
    }
}
