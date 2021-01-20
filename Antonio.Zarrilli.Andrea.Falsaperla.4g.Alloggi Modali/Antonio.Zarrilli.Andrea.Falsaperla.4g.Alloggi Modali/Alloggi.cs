using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antonio.Zarrilli.Andrea.Falsaperla._4g.Alloggi_Modali
{
    class Alloggio
    {
        public int Id { get; set; }
        public int NumPersone { get; set; }
        public double MetriQuadri { get; set; }
        public double CostoUnitarioAcqua { get; set; }
        public Alloggio(int id, int numPersone, double metriQuadri, double costoUnitarioAcqua)
        {
            this.Id = id;
            this.NumPersone = numPersone;
            this.MetriQuadri = metriQuadri;
            this.CostoUnitarioAcqua = costoUnitarioAcqua;
        }
        public double costoAcqua(double q)
        {
            return q * NumPersone;
        }
    }
    class Villa : Alloggio
    {
        public double Giardino { get; set; }
        public Villa(int codice, int numPersone, double metriQuadri, double costoUnitarioAcqua, double giardino)
            : base(codice, numPersone, metriQuadri, costoUnitarioAcqua)
        {
            this.Giardino = giardino;
        }
    }
}
