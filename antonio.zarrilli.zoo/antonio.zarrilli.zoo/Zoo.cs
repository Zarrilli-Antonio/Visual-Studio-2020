using System;
using System.Collections.Generic;
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
        List<Recinto> recinti = new List<Recinto>();
        public AreaTerra(string nome, double dimansione, Recinto recinto)
        {
            this.nome = nome;
            this.estensione = dimansione;
            recinti.Add(recinto);
        }
        public void StampaAnimali() 
        {
            foreach (var recinto in recinti) 
            {
                foreach (var animale in recinto.animali) 
                {
                    Console.WriteLine(animale.nome);
                }
            }
        }
        public void StampaCustode()
        {
            foreach (var recinto in recinti)
            {
                Console.WriteLine(recinto.custode.nome);
            }
        }
    }
    class AreaAcqua
    {
        string nome;
        double capacita;
        List<Vasca> vasche = new List<Vasca>();
        public AreaAcqua(string nome, double capacita, Vasca vasca)
        {
            this.nome = nome;
            this.capacita = capacita;
            vasche.Add(vasca);
        }
        public void StampaAnimali()
        {
            foreach (var vasca in vasche)
            {
                foreach (var animale in vasca.animali)
                {
                    Console.WriteLine(animale.nome);
                }
            }
        }
        public void StampaSub()
        {
            foreach (var vasca in vasche)
            {
                Console.WriteLine(vasca.custode.nome);
            }
        }
    }
    class AnimaleTerra: Animale
    {
        int numZampe;
        public AnimaleTerra(float eta, string nome, float peso, string tipoDiNutrizione, Specie specie, int numZampe)
            :base(eta, nome, peso, tipoDiNutrizione, specie)
        {
            this.numZampe = numZampe;
        }
    }
    class AnimaleAcqua: Animale
    {
        int numPinne;
        public AnimaleAcqua(float eta, string nome, float peso, string tipoDiNutrizione, Specie specie, int numPinne)
            : base(eta, nome, peso, tipoDiNutrizione, specie)
        {
            this.numPinne = numPinne;
        }
    }
    class Recinto
    {
        string nome;
        string posizioneGPS;
        double dimensione;
        public List<AnimaleTerra> animali = new List<AnimaleTerra>();
        public Custode custode;
        public Recinto(string nome, string posizioneGPS, double dimensione, Custode custode, AnimaleTerra animaleTerra)
        {
            this.nome = nome;
            this.posizioneGPS = posizioneGPS;
            this.dimensione = dimensione;
            this.custode = custode;
            animali.Add(animaleTerra);
        }
    }
    class Vasca
    {
        string nome;
        string posizioneGPS;
        double capacita;
        public List<AnimaleAcqua> animali = new List<AnimaleAcqua>();
        public Sub custode;
        public Vasca(string nome, string posizioneGPS, double capacita, Sub custode, AnimaleAcqua animaleAcqua)
        {
            this.nome = nome;
            this.posizioneGPS = posizioneGPS;
            this.capacita = capacita;
            this.custode = custode;
            animali.Add(animaleAcqua);
        }
    }
    class Specie
    {
        string nomeScientifico;
        string nomeComune;
        public Specie(string nomeScientifico, string nomeComune)
        {
            this.nomeScientifico = nomeScientifico;
            this.nomeComune = nomeComune;
        }
    }
    class Animale
    {
        float eta;
        public string nome;
        float peso;
        string tipoDiNutrizione;
        Specie specie;
        public Animale(float eta, string nome, float peso, string tipoDiNutrizione, Specie specie) 
        {
            this.eta = eta;
            this.nome = nome;
            this.peso = peso;
            this.tipoDiNutrizione = tipoDiNutrizione;
            this.specie = specie;
        }
    }
    class Custode
    {
        public string nome;
        string cognome;
        DateTime dataNascita;
        float altezza;
        string cf;
        public Custode(string nome, string cognome, DateTime dataNascita, float altezza, string cf) 
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataNascita = dataNascita;
            this.altezza = altezza;
            this.cf = cf;
        }
    }
    class Sub: Custode
    {
        int oreImmersione;
        public Sub(string nome, string cognome, DateTime dataNascita, float altezza, string cf, int oreImmersione)
            :base(nome, cognome, dataNascita, altezza, cf)
        {
            this.oreImmersione = oreImmersione;
        }
    }
}
