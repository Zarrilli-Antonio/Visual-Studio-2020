using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antonio.zarrilli.zoo
{
    
    class Program
    {
        static void Main(string[] args)
        {
            AreaTerra areaTerra = new AreaTerra("Ciao", 69.0, new Recinto("Rec21", "12:23:23", 69.0, new Custode("Dario", "Moccia", DateTime.Today, 1.50f, "cf"), new AnimaleTerra(12.5f, "pietra", 120.5f, "mangia quello che c'è", new Specie("PietroniusSassonius", "Sasso"), 0)));
            Console.WriteLine("Anomali nell'area di terra:");
            areaTerra.StampaAnimali();
            Console.WriteLine("Custodi nell'area di terra:");
            areaTerra.StampaCustode();
            AreaAcqua areaAcqua = new AreaAcqua("Vasca123", 421.12, new Vasca("Vasc21", "12:23:23", 421.10, new Sub("Mario", "Rossi", DateTime.Today, 1234.56789f, "cf", 123), new AnimaleAcqua(12.34f, "alghetta", 16.22f, "non mangia", new Specie("Algus", "Alga"), 0)));
            Console.WriteLine("Anomali nell'area di acqua:");
            areaAcqua.StampaAnimali();
            Console.WriteLine("Custodi nell'area di acqua:");
            areaAcqua.StampaSub();
            Console.ReadKey();
        }
    }
}
