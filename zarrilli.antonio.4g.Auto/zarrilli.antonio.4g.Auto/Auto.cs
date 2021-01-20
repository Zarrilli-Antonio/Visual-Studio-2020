using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zarrilli.antonio._4g.Auto
{
    class Auto
    {
        public string marca { get; set; }
        public string modello { get; set; }
        public int cilindrata { get; set; }
        public string colore { get; set; }
        public int prezzo { get; set; }

        public Auto(string marca, string modello, int cilindrata, string colore, int prezzo)
        {
            this.marca = marca;
            this.modello = modello;
            this.cilindrata = cilindrata;
            this.colore = colore;
            this.prezzo = prezzo;
        }
    }
    class AutoUsata:Auto
    {
        public int kilometri { get; set; }

        public AutoUsata(string marca, string modello, int cilindrata, string colore, int prezzo, int kilometri)
            : base(marca, modello, cilindrata, colore, prezzo)
        {
            this.kilometri = kilometri;
        }
    }
}
