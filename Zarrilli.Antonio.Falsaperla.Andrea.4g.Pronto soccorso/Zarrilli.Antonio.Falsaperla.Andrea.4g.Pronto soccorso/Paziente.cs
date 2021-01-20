using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarrilli.Antonio.Falsaperla.Andrea._4g.Pronto_soccorso
{
    public class Paziente : GeneraCodice
    {
        string nome { get; set; }
        string cognome { get; set; }
        string codicefiscale { get; set; }

        public Paziente(string nome, string cognome,string codicefiscale, int gravita, string orario)
            :base(gravita, orario)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.codicefiscale = codicefiscale;
        }
    }
}
