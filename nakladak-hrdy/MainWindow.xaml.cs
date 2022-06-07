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

namespace nakladak_hrdy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nakladak TeslaSemi;
        Nakladak Avia;

        public MainWindow()
        {
            InitializeComponent();
            TeslaSemi  = new Nakladak();
            TeslaSemi.název = "Tesla Semi";
            Zobraz(TeslaSemi, text1);

            Avia = new Nakladak();
            Avia.název = "Avia";
            Zobraz(Avia, text2);
        }

        public void Zobraz(Nakladak nákladak, TextBox textBox)
        {
            textBox.Text = nákladak.název + "\n";
            textBox.Text += "Nosnost " + nákladak.nosnost.ToString() + "kg" + "\n";
            textBox.Text += "Náklad " + nákladak.náklad.ToString() + "kg" + "\n";
            textBox.Text += "Spotřeba nádrže " + nákladak.Spotřeba_Nádrže.ToString() + "l/100km" + "\n";
            textBox.Text += "Objem nadrze " + nákladak.ObjemNadrze.ToString() + "l" + "\n";
            textBox.Text += "Celková vzdálenost " + nákladak.CelkováVzdalenost.ToString() + "km" + "\n";
        }

        private void JetN_Click(object sender, RoutedEventArgs e)
        {
            TeslaSemi.jet();
            Zobraz(TeslaSemi, text1);
        }

        private void JetA_Click(object sender, RoutedEventArgs e)
        {
            Avia.jet();
            Zobraz(Avia, text2);
        }

        private void NatankovatN_Click(object sender, RoutedEventArgs e)
        {
            TeslaSemi.natankovat();
            Zobraz(TeslaSemi, text1);
        }

        private void NatankovatA_Click(object sender, RoutedEventArgs e)
        {
            Avia.natankovat();
            Zobraz(Avia, text2);
        }

        private void NaložitN_Click(object sender, RoutedEventArgs e)
        {
            TeslaSemi.naložit();
            Zobraz(TeslaSemi, text1);
        }

        private void NaložitA_Click(object sender, RoutedEventArgs e)
        {
            Avia.naložit();
            Zobraz(Avia, text2);
        }

        private void vyložit1_Click(object sender, RoutedEventArgs e)
        {
            TeslaSemi.vyložit();
            Zobraz(TeslaSemi, text1);
        }

        private void vyložiz2_Click(object sender, RoutedEventArgs e)
        {
            Avia.vyložit();
            Zobraz(Avia, text2);
        }
    }
}

