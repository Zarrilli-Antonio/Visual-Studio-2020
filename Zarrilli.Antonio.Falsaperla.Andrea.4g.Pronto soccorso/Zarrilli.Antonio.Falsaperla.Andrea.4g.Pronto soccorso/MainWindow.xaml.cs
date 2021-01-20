using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zarrilli.Antonio.Falsaperla.Andrea._4g.Pronto_soccorso
{
    public partial class MainWindow : Window
    {
        List<Paziente> Pazienti = new List<Paziente>();
        public string nome = null;
        public string cognome = null;
        public string codiceFiscale = null;
        public string gravita = null;
        public string orario = null;
        public string codiceEliminazione = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Aggiungi_Click(object sender, RoutedEventArgs e)
        {
            Aggiungi aggiungi = new Aggiungi(this);
            aggiungi.Owner = this;
            aggiungi.ShowDialog();
            Paziente paziente = new Paziente(nome, cognome, codiceFiscale, Convert.ToInt32(gravita), orario);
            Pazienti.Add(paziente);
        }

        private void Rimuovi_Click(object sender, RoutedEventArgs e)
        {
            Rimuovi rimuovi = new Rimuovi(this);
            rimuovi.Owner = this;
            rimuovi.ShowDialog();
            int i = 0;
            foreach(var paziente in Pazienti)
            {
                if (paziente.codice == codiceEliminazione)
                {
                    Pazienti.RemoveAt(i);
                    return;
                }
                i++;
            }
        }

        private void Aggiorna_Click(object sender, RoutedEventArgs e)
        {
            DGPazienti.ItemsSource = Pazienti;
            DGPazienti.Items.Refresh();
        }
    }
}
