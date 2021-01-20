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

namespace zarrilli.antonio._4g.Auto
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Auto> AutoNuove = new List<Auto>();
        List<AutoUsata> AutoUsate = new List<AutoUsata>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string marca = ((ComboBoxItem)Marca.SelectedItem).Content.ToString();
            using (StreamReader sr = new StreamReader("Auto.csv"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dati = line.Split(';');
                    if (dati[0] == marca)
                    {
                        if (dati.Length == 5)
                        {
                            Auto auto = new Auto(dati[0], dati[1], Convert.ToInt32(dati[2]), dati[3], Convert.ToInt32(dati[4]));
                            AutoNuove.Add(auto);
                        }
                        else
                        {
                            AutoUsata autoUsata = new AutoUsata(dati[0], dati[1], Convert.ToInt32(dati[2]), dati[3], Convert.ToInt32(dati[4]), Convert.ToInt32(dati[5]));
                            AutoUsate.Add(autoUsata);
                        }
                    }
                }
            }
            Nuove.ItemsSource = AutoNuove;
            Usate.ItemsSource = AutoUsate;
        }
    }
}
