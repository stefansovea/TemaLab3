using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {   // afisarea numarului de argumente
            Console.WriteLine("Numarul de argumente este: {0}", args.Length);
            string[][] mat = new string[30][];
            for (int i = 0; i <= 29; i++)
            {
                mat[i] = new string[30];
            }
            int m = 0;
            int n;
            //Alcatuirea matricei de elemente
            if (args.Length == 0)
                Console.Write("Linia de comanda nu contine argumente");
            else
            {
                for (int i = 97; i <= 122; i++)
                {
                    n = 0;
                    foreach (string param in args)
                    {

                        if (param.ToLower()[0] == i)
                        {
                            mat[m][n] = param;
                            n++;
                        }
                        else
                        {
                            mat[m][n] = "*";
                        }

                    }
                    m++;
                }
              //Afisarea matricei
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < mat[i].Length; j++)
                    {
                        Console.Write("{0} ", mat[i][j]);
                    }
                    Console.Write("\n");

                }

            }
        }
    }
}
