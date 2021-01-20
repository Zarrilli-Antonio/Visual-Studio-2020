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
    /// <summary>
    /// Logica di interazione per Rimuovi.xaml
    /// </summary>
    public partial class Rimuovi : Window
    {
        MainWindow codice;
        public Rimuovi(MainWindow codice)
        {
            InitializeComponent();
            this.codice = codice;
        }

        private void BtnConferma_Click(object sender, RoutedEventArgs e)
        {
            codice.codiceEliminazione = TxbCodice.Text;
            this.Close();
        }
    }
}
