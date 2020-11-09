namespace esercizioStudenti
{
    class Studente
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public string classe { get; set; }

        public Studente(string nomeStudente, string cognomeStudente, string classeStudente)
        {
            nome = nomeStudente;
            cognome = cognomeStudente;
            classe = classeStudente;
        }
    }
}