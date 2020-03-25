using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaLab3
{
    class Automobile
    {
        string marca;
        string culoare;
        long pret;

        public string getmarca()
        {
            return marca;
        }

        public string getculoare()
        {
            return culoare;
        }

        public long getpret()
        {
            return pret;
        }

        public Automobile()
        {
            marca = string.Empty;
            culoare = string.Empty;
            pret = 0;
        }
        public Automobile(string _marca, string _culoare, long _pret)
        {
            marca = _marca;
            culoare = _culoare;
            pret = _pret;
        }

        public Automobile(string sir)
        {
            int i = 0;
            string[] date = sir.Split(',');
            foreach (var cuvant in date)
            {
                if (i == 0)
                    marca = cuvant;
                if (i == 1)
                    culoare = cuvant;
                if (i == 2)
                    pret = Convert.ToInt64(cuvant);
                i++;
            }

        }

        public int Preferinte(string optiune, string opcul, long buget)
        {

            if (optiune.Equals(marca))
            {
                if (opcul.Equals(culoare))
                {
                    if (buget >= pret)
                        return 1;
                    else
                        return 2;
                }
            }
            return 0;
        }

        public int verifCuloare(string _culoare)
        {
            if (_culoare.Equals(culoare))
                return 1;
            else
                return 0;
        }

        public int verifMarca(string _marca)
        {
            if (_marca.Equals(marca))
                return 1;
            else
                return 0;
        }

        public int verifPret(long buget)
        {
            if (buget >= pret)
                return 1;
            else
                return 0;
        }

        public string afisare()
        {
            return string.Format(" {0}, de culoare {1}, la pretul de {2} euro \n", marca, culoare, pret);
        }



    }
}