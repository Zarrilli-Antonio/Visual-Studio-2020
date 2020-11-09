using System;

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
    }
    class AreaTerra
    {
        string nome;
        double estensione;
        Recinto[] recinti;
    }
    class AreaAcqua
    {
        string nome;
        double capacita;
        Vasca[] vasche;
    }
    class AnimaleTerra
    {

    }
    class AnimaleAcqua
    {

    }
    class Recinto
    {
        string nome;
        string posizioneGPS;
        double dimensione;
    }
    class Vasca
    {
        string nome;
        string posizioneGPS;
        double capacita;
    }
    class Specie
    {

    }
    class Animale
    {
        public float eta
    }
    class Custode
    {

    }
    class Sub
    {

    }
}
