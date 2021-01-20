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
using System.Windows.Shapes;

namespace Zarrilli.Antonio.Falsaperla.Andrea._4g.Pronto_soccorso
{
    public partial class Aggiungi : Window
    {
        public MainWindow dati;
        public Aggiungi(MainWindow dati)
        {
            InitializeComponent();
            this.dati = dati;
        }

        private void Aggiungi_Click(object sender, RoutedEventArgs e)
        {
            dati.nome = TxbNome.Text;
            dati.cognome = TxbCognome.Text;
            dati.codiceFiscale = TxbFiscale.Text;
            dati.gravita = TxbCodice.Text;
            dati.orario = TxbOrario.Text;
            this.Close();
        }

        private void Elimina_Click(object sender, RoutedEventArgs e)
        {
            TxbNome.Text = null;
            TxbFiscale.Text = null;
            TxbCodice.Text = null;
            TxbOrario.Text = null;
            TxbCognome.Text = null;
        }
    }
}
