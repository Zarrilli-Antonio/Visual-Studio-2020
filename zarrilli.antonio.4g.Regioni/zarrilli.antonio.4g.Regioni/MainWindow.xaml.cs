using System;
using System.Collections.Generic;
using System.IO;
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

namespace zarrilli.antonio._4g.Regioni
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] regioniItaliane = { "Abruzzo", "Basilicata", "Calabria", "Campania", "Emilia-Romagna", "Friuli Venezia Giulia", "Lazio", "Liguria", "Lombardia", "Marche", "Molise", "Piemonte", "Puglia", "Sardegna", "Sicilia", "Toscana", "Trentino Alto Adige", "Umbria", "Valle d'Aosta", "Veneto" };
            int regione = Regione.SelectedIndex;
            string capoluogo = null;
            string provincie = null;
            using (StreamReader sr = new StreamReader("Regioni.csv"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dati = line.Split(';');
                    if (dati[0] == regioniItaliane[regione])
                    {
                        provincie = dati[1];
                        capoluogo = dati[2];
                        break;
                    }
                }
            }
            Capoluoghi.Text = capoluogo;
            string[] provincia = provincie.Split(':');
            provincie = null;
            foreach (var item in provincia)
            {
                provincie = provincie + ", " + item;
            }
            provincie = provincie.Trim(',', ' ');
            Provincie.Text = provincie;
        }
    }
}
