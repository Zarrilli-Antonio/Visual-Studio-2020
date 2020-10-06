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

namespace Quadrilatero
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OnBtnCalcolaClick(object sender, RoutedEventArgs e)
        {
            QuadrilateroClass quadrilatero = null;
            float lato1;
            float lato2;
            float.TryParse(tbxLato1.Text, out lato1);
            float.TryParse(tbxLato2.Text, out lato2);
            if (!string.IsNullOrEmpty(tbxLato1.Text) && !string.IsNullOrEmpty(tbxLato2.Text))
            {
                quadrilatero = new QuadrilateroClass(lato1, lato2);
            }
            else
            {
                if (!string.IsNullOrEmpty(tbxLato1.Text))
                {
                    quadrilatero = new QuadrilateroClass(lato1);
                }
                else if (!string.IsNullOrEmpty(tbxLato2.Text))
                {
                    quadrilatero = new QuadrilateroClass(lato2);
                }
                else
                {
                    MessageBox.Show("Inserire almeno un lato!");
                }
            }
            if (quadrilatero != null)
            {
                tbxPerimetro.Text = $"{quadrilatero.CalcolaPerimetro()}";
                tbxArea.Text = $"{quadrilatero.CalcolaArea()}";
            }
        }
        public class QuadrilateroClass
        {
            private float lato1;
            private float lato2;

            public QuadrilateroClass(float lato)
            {
                lato1 = lato2 = lato;
            }

            public QuadrilateroClass(float lato1, float lato2)
            {
                this.lato1 = lato1;
                this.lato2 = lato2;
            }

            public float CalcolaPerimetro()
            {
                return (lato1 + lato2) * 2.0f;
            }

            public float CalcolaArea()
            {
                return lato1 * lato2;
            }
        }
    }
}
