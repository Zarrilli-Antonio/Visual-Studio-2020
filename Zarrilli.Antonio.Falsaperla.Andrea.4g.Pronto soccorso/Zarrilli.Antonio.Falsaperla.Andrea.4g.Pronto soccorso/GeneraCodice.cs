using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarrilli.Antonio.Falsaperla.Andrea._4g.Pronto_soccorso
{
    
    public class GeneraCodice
    {
        int gravita { get; set; }
        string orario { get; set; }
        public string codice { get; set; }

        public GeneraCodice(int gravita, string orario)
        {
            this.gravita = gravita;
            this.orario = orario;
            codice = gravita + orario;
        }
    }
}
