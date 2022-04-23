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
using TI_3;
using Microsoft.Win32;

namespace WPF_TI3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtInputP_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
                e.Handled = true;
            else txtInputP.Background = Brushes.White;
        }

        private void txtInputQ_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
                e.Handled = true;
            else txtInputQ.Background = Brushes.White;
        }

        private void txtInputB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
                e.Handled = true;
            else txtInputB.Background = Brushes.White;
        }

        private void btnCalcN_Click(object sender, RoutedEventArgs e)
        {
            int p, q, n, b;
            p = 0; q = 0; n = 0; b = 0;
            if (txtInputP.Text != "")
                p = int.Parse(txtInputP.Text);
            else txtInputP.Background = Brushes.Red;
            if (txtInputQ.Text != "")
                q = int.Parse(txtInputQ.Text);
            else txtInputQ.Background = Brushes.Red;
            if (!Rabin.checkIsPrime(p)) txtInputP.Background = Brushes.Red;
            if (!Rabin.checkIsPrime(q)) txtInputQ.Background = Brushes.Red;
            if (Rabin.checkIsPrime(p) && Rabin.checkIsPrime(q) && txtInputQ.Text != "" && txtInputP.Text != "")
            {
                
                if (!p.Equals(q))
                {
                    n = p * q;
                    if (txtInputB.Text != "")
                        b = int.Parse(txtInputB.Text);
                    if (b > n)
                    {
                        txtInputB.Background = Brushes.Red;
                    }
                    else lblN.Content = n.ToString();
                }
                else txtInputQ.Background = Brushes.Red;
            }
        }
    }
}