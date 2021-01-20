using System;
using System.Security.Principal;

namespace antonio.zarrilli.zoo
{
    class Zoo 
    {
        string nome;
        string citta;
        string indirizzi;
        string telefono;
        AreaTerra areaFelini;
        AreaTerra areaErbivori;
        AreaAcqua areaAquatici;

        public Zoo(string nome, AreaTerra af, AreaTerra ae, AreaAcqua aa) 
        {
            this.nome = nome;
            areaAquatici = aa;
            areaErbivori = ae;
            areaFelini = af;
        }
    }
    class AreaTerra
    {
        string nome;
        double estensione;
        Recinto[] recinti;
        public AreaTerra(string nome, double dimansione)
        {
            this.nome = nome;
            this.dimensione = dimansione;
        }
    }
    class AreaAcqua
    {
        string nome;
        double capacita;
        Vasca[] vasche;
        public AreaAcqua(string nome, double capacita)
        {
            this.nome = nome;
            this.capacita = capacita;
        }
    }
    class AnimaleTerra: Animale
    {
        int numZampe;
        Recinto recinto;
    }
    class AnimaleAcqua: Animale
    {
        int numPinne;
        Vasca vasca;
    }
    class Recinto
    {
        string nome;
        string posizioneGPS;
        double dimensione;
        AnimaleTerra[] animali;
        Custode custode;
    }
    class Vasca
    {
        string nome;
        string posizioneGPS;
        double capacita;
        AnimaleAcqua[] animali;
        Sub custode;
    }
    class Specie
    {
        string nomeScientifico;
        string nomeComune;
    }
    class Animale
    {
        float eta;
        string nome;
        float peso;
        string tipoDiNutrizione;
        Specie specie;
    }
    class Custode
    {
        string nome;
        string cognome;
        DateTime dataNascita;
        int altezza;
        string cf;
        Recinto[] recinti;
    }
    class Sub: Custode
    {
        int oreImmersione;
        Vasca[] vasche;
    }
}
