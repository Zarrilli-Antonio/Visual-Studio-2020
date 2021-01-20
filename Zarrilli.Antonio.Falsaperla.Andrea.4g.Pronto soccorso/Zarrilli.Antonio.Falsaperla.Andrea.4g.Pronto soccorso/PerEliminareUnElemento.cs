using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarrilli.Antonio.Falsaperla.Andrea._4g.Pronto_soccorso
{
    public class EmployeeSearch
    {
        String _s;

        public EmployeeSearch(String s)
        {
            _s = s;
        }

        public bool StartsWith(Paziente e)
        {
            return e.codice.StartsWith(_s, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
