using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antonio.zarrilli.scuola
{
    class Program
    {
        static void Main(string[] args)
        {
            Classe c = new Classe("4G", "Informatica");
            Studente s = new Studente("Mario", "Rossi");
            c.addStudente(s);
            s = new Studente("Filippo", "Verdi");
            c.addStudente(s);
            Console.WriteLine($"nella classe ci sono {c.numStudenti()} studenti");
            int num = 1;
            foreach (Studente stud in c.studenti) 
            {
                Console.WriteLine($"{num}) {stud.Cognome} {stud.Nome}");
                num++;
            }
            Console.ReadKey();
        }
    }
}
