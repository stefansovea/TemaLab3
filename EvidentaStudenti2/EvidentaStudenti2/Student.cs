namespace LibrarieEntitati
{
    public class Student
    {
        // date membre private
        string nume;
        int[,] note = new int [4,15];

        // contructor implicit
        public Student()
        {         
        }

        // constructor cu parametri
        public Student(string _nume)
        {
            nume = _nume;   
        }


        //citirea de la tastatura a unui string
        public string CitireSirCaractere()
        {
            string _note = System.Console.ReadLine();
            return _note;
        }

        //Separarea string-ului de note in note pe disciplina si pe ani
        public void SetNote(string sirNote)
        {   int k,intreg;
            string []_note = sirNote.Split(',');
            string []note_;
            for(int i=0;i<_note.Length;i++)
            {   k = 0;
                note_ = _note[i].Split(' '); 
                foreach (string arg in note_)
                {
                    if (int.TryParse(arg, out intreg))
                    {
                        note[i, k] = intreg;
                        k++;
                    }
                }
            }
        }

        //Metoda SetNote
        public void SetNote(int[,] _note)
        {         
            for(int i=0;i<4;i++)
            {
                for(int j=0;j<15;j++)
                {
                    note[i, j] = _note[i, j];
                }
            }
        }
        

         //Metoda de numarare a notelor peste 5 si sub 5, ignorand spatiile necompletate din matrice
        public void NumarareNote(out int valSub5, out int valPeste5)
        {
            valSub5 = valPeste5 = 0;
            int linie=4, coloana = 15;
            for (int i = 0; i < linie; i++)
            {  
                for(int j=0; j<coloana;j++)
                {
                if (note[i,j] >= 5 && note[i,j]!=0)
                    valPeste5++;
                if (note[i,j] < 5 && note[i,j]!=0)
                    valSub5++;
                }
            }

        }

        //Metoda de afisare
        public string ConversieLaSir()
            {
            string sNote = "";
            if (note != null)
            {
                for (int i = 0; i < 4; i++)
                {
                    sNote = sNote + "anul " + (i + 1) + ": ";
                    for (int j = 0; j < 15; j++)
                    {
                        sNote = sNote + " " + note[i,j];
                    }
                    sNote = sNote + "\n";
                }
            }
            string s = string.Format("Studentul {0} are notele: \n{1}", nume, sNote);
            return s;
        }
        }
    }
     