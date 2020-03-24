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
        {   //afisarea numarului de argumente
            Console.WriteLine("Numarul de argumente este: {0}", args.Length);
            string[][] mat = new string[30][];
            for (int i = 0; i <= 29; i++)
            {
                mat[i] = new string[30];
            }
            int m = 0;
            int n,q;
            int k = args.Length;
            //Alcatuirea matricei de elemente
            if (args.Length == 0)
                Console.Write("Linia de comanda nu contine argumente");
            else
            {
                for (int i = 97; i <= 122; i++)
                {
                    n = 0;
                    q = 0;
                    foreach (string param in args)
                    {
                        q++; 
                        if (param.ToLower()[0] == i)
                        {
                            mat[m][n] = param;
                            n++;
                        }
                        //Se verifica daca am parcurs toate argumentele din linia de comanda
                        if (q == k && n>0)
                            m++;
                    }
                }
              //Afisarea matricei
                for (int i = 0; i < m; i++)
                {   
                    Console.Write("{0}:", mat[i][0].Substring(0, 1));
                    for (int j = 0; j < mat[i].Length; j++)
                    {
                        Console.Write("{0} ", mat[i][j]);
                    }
                    Console.Write("\n");
                }
                Console.ReadKey();

            }
        }
    }
}
