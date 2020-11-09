using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace esercizioStudenti
{
    public partial class MainWindow : Window
    {
        List<Studente> Studenti = new List<Studente>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int erroriRilevati = 0;
            using (StreamReader sr = new StreamReader("ElencoStudenti.csv"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dati = line.Split(',');
                    bool errore = false;
                    foreach (var dato in dati)
                    {
                        if (string.IsNullOrEmpty(dato))
                        {
                            errore = true;
                        }
                    }
                    if (errore == false)
                    {
                        Studente studente = new Studente(dati[0], dati[1], dati[2]);
                        Studenti.Add(studente);
                    }
                    else
                    {
                        erroriRilevati += 1;
                    }
                }
            }
            grigliaDati.ItemsSource = Studenti;
            alert.Content = ("Sono stati rilevati " + erroriRilevati + " errori");
        }
    }
}
