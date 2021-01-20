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
using System.Windows.Shapes;

namespace Antonio.Zarrilli.Andrea.Falsaperla._4g.Alloggi_Modali
{
    /// <summary>
    /// Logica di interazione per Window1.xaml
    /// </summary>
    public partial class ModificaDati : Window
    {
        public MainWindow windows;
        public ModificaDati(MainWindow window)
        {
            InitializeComponent();
            windows = window;
        }
        private void Button_Click_Annulla(object sender, RoutedEventArgs e)
        {
            Annulla annulla = new Annulla();
            annulla.Owner = this;
            annulla.ShowDialog();

        }
        private void Button_Click_Conferma(object sender, RoutedEventArgs e)
        {
            string line1;
            string line2 = "";
            using (StreamReader sr = new StreamReader("ElencoAlloggi.csv"))
            {
                
                while ((line1 = sr.ReadLine()) != null)
                {
                    line2 =line2 + line1 + "\n";
                }
            }
            string line = (line2 + Giardino.Text + ";" + Id.Text + ";" + Numero_Persone.Text + ";" + Metri_Quadri.Text + ";" + Costo_Unitario_Dell_Acqua.Text);
            using (StreamWriter sw = new StreamWriter("ElencoAlloggi.csv"))
            {
                sw.WriteLine(line);
            }
            windows.pinco = 10;
            this.Close();
        }
        public static void Chiudi() 
        {
            
            //trovare un modo per chiudere la finestra corrente. da qui
        }

    }
}
