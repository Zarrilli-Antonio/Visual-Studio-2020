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
using System.IO;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml;

namespace Diario
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        static string EncryptString(string data, string sKey)
        {
            MemoryStream msOutput = new MemoryStream();

            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            CryptoStream cryptostream = new CryptoStream(msOutput,
               desencrypt,
               CryptoStreamMode.Write);

            StreamWriter sw = new StreamWriter(cryptostream);
            sw.WriteLine(data);
            sw.Close();
            cryptostream.Close();

            return Convert.ToBase64String(msOutput.ToArray());
        }
        static string DecryptString(string data, string sKey)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);

            MemoryStream ms = new MemoryStream(Convert.FromBase64String(data));
            CryptoStream encStream = new CryptoStream(ms, DES.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(encStream);

            string val = sr.ReadLine();

            sr.Close();
            encStream.Close();
            ms.Close();

            return val;
        }

        private void btnLeggi_Click(object sender, RoutedEventArgs e)
        {
            string filename = "Segreti.txt";
            char[] result;
            StringBuilder builder = new StringBuilder();

            using (StreamReader reader = File.OpenText(filename))
            {
                result = new char[reader.BaseStream.Length];
                reader.ReadAsync(result, 0, (int)reader.BaseStream.Length);
            }

            foreach (char c in result)
            {
                if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
                {
                    builder.Append(c);
                }
            }
            tbxTesto.Text = builder.ToString();
        }

        private void btnScrivi_Click(object sender, RoutedEventArgs e)
        {
            string testo = tbxTesto.Text;
            string password = tbxPassword.Text;
            string segreti = null;
            string segretiCriptati = null;
            using (StreamReader sr = new StreamReader("Segreti.txt"))
            {
                string segreto;
                while ((segreto = sr.ReadLine()) != null)
                {
                   segreti += segreto + "\n\n";
                }
            }
            segretiCriptati = EncryptString(segreti, password);
            using (StreamWriter writer = new StreamWriter("Segreti.txt"))
            {
                writer.Write(segreti + testo);
            }
        }

        private void tbxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxTesto_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
