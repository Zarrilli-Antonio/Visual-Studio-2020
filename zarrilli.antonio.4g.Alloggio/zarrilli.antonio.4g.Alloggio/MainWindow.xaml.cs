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

namespace zarrilli.antonio._4g.Alloggio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const double costo = 15.5;
        public const double val1 = 2000;
        public const double val2 = 700;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        class Alloggio
        {
            int codice;
            int numPersone;
            double metriQuadri;
            public Alloggio(int codice, int numPersone, double metriQuadri)
            {
                this.codice = codice;
                this.numPersone = numPersone;
                this.metriQuadri = metriQuadri;
            }
            public int getNumPersone()
            {
                return numPersone;
            }
            public double getMetriQuadri()
            {
                return metriQuadri;
            }
            public int getCodice()
            {
                return codice;
            }
            public double costoAcqua(double q)
            {
                return q * numPersone;
            }
            public double valore(double v)
            {
                return v * metriQuadri;
            }
            public virtual double densità()
            {
                return metriQuadri / numPersone;
            }
        }
        class Villa : Alloggio
        {
            double giardino;
            public Villa(int codice, int numPersone, int metriQuadri, double giardino) :
            base(codice, numPersone, metriQuadri)
            {
                this.giardino = giardino;
            }
            public double getGiardino()
            {
                return giardino;
            }
            public double valore(double v1, double v2)
            {
                // esegue l'overloading del metodo: riscrive il metodo modifcando il numero di parametri
                double r1;
                r1 = valore(v1) + v2 * giardino;
                return r1;
            }
            public override double densità()
            {
                // esegue l'overriding del metodo: riscrive il metodo mantenendo gli stessi parametri
                return ((getMetriQuadri() + giardino)) / getNumPersone();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Alloggio a1;
            int c = int.Parse(tbxCodiceAlloggio.Text);
            int nump = int.Parse(tbxPersoneAlloggio.Text);
            int mq = int.Parse(tbxMetriAlloggio.Text);
            a1 = new Alloggio(c, nump, mq);
            lblDatiAlloggio.Text = "Codice: " + a1.getCodice() + " " + " Numero persone : " + a1.getNumPersone() + " " + "Metri quadri : " + a1.getMetriQuadri();
            lblAcquaAlloggio.Text = "Costo totale acqua = " + a1.costoAcqua(costo);
            lblDensitaAlloggio.Text = "Densità in alloggio = " + a1.densità();
            lblValoreAlloggio.Text ="Valore = " + a1.valore(val1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Villa v1;
            int c = int.Parse(tbxCodiceVilla.Text);
            int nump = int.Parse(tbxPersoneVilla.Text);
            int mq = int.Parse(tbxMetriVilla.Text);
            int g = int.Parse(tbxMetriGiardinoVilla.Text);
            v1 = new Villa(c, nump, mq, g);
            lblDatiVilla.Text = "Codice: " + v1.getCodice() + " " + " Numero persone : " + v1.getNumPersone() + " " + "Metri quadri : " + v1.getMetriQuadri() + " " + "Giardino : " + v1.getGiardino();
            lblAcquaVilla.Text = "Costo totale acqua = " + v1.costoAcqua(costo);
            lblDensitaVilla.Text = "Densità in villa = " + v1.densità();
            lblValoreVilla.Text = "Valore = " + v1.valore(val1, val2);
        }
    }
}
