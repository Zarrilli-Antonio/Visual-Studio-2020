using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antonio.zarrilli._4g.CentroRicerca
{
    class CentroRicerca
    {
        string nome;
        string cognome;
        string posizione;
        int nAree;

        public CentroRicerca(string nome, string cognome, string posizione, int nAree)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.posizione = posizione;
            this.nAree = nAree;
        }
    }

    class Area 
    {
        string nome;
        float grandezza;
        int nRicercatori;

        public Area(string nome, float grandezza, int nRicercatori)
        {
            this.nome = nome;
            this.grandezza = grandezza;
            this.nRicercatori = nRicercatori;
        }
    }

    class Progetto 
    {
        string nome;
        string codice;
        int oreLavoro;

        public Progetto(string nome, string codice, int oreLavoro)
        {
            this.nome = nome;
            this.codice = codice;
            this.oreLavoro = oreLavoro;
        }
    }

    class Team 
    {
        string nome;
        string codice;

        public Team(string nome, string codice)
        {
            this.nome = nome;
            this.codice = codice;
        }
    }

    public class Ricercatore 
    {
        string nome;
        string cognome;
        DateTime dataDiNascita;
        string codiceFiscale;
        double stipendio;
        string grado;

        public Ricercatore(string nome, string cognome, DateTime dataDiNascita, string codiceFiscale, double stipendio, string grado)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataDiNascita = dataDiNascita;
            this.codiceFiscale = codiceFiscale;
            this.stipendio = stipendio;
            this.grado = grado;
        }
    }

    class RicercatoreSenior : Ricercatore 
    {
        List<string> pubblicazioni = new List<string>();
        double bonusStipendio;

        public RicercatoreSenior(List<string> pubblicazioni, double bonusStipendio, string nome, string cognome, DateTime dataDiNascita, string codiceFiscale, double stipendio, string grado)
            :base(nome, cognome, dataDiNascita, codiceFiscale, stipendio, grado)
        {

            this.pubblicazioni = pubblicazioni;
            this.bonusStipendio = bonusStipendio;
        }
    }

    class RicercatoreJunior : Ricercatore
    {
        int anniTirocinio;

        public RicercatoreJunior(int anniTirocinio, string nome, string cognome, DateTime dataDiNascita, string codiceFiscale, double stipendio, string grado)
            : base(nome, cognome, dataDiNascita, codiceFiscale, stipendio, grado)
        {
            this.anniTirocinio = anniTirocinio;
        }
    }
}
