using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antonio.zarrilli.Ville
{
    class Alloggio
    {
        public int id;
        public int numPersone;
        public double metriQuadri;
        public double costoUnitarioAcqua;
        public Alloggio(int id, int numPersone, double metriQuadri, double costoUnitarioAcqua)
        {
            this.id = id;
            this.numPersone = numPersone;
            this.metriQuadri = metriQuadri;
            this.costoUnitarioAcqua = costoUnitarioAcqua;
        }
        public double costoAcqua(double q)
        {
            return q * numPersone;
        }
    }
    class Villa : Alloggio
    {
        public double giardino;
        public Villa(int codice, int numPersone, double metriQuadri, double costoUnitarioAcqua, double giardino)
            :base(codice, numPersone, metriQuadri, costoUnitarioAcqua)
        {
            this.giardino = giardino;
        }
    }
}
