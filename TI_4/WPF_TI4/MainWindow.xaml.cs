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
using Microsoft.Win32;
using System.IO;

namespace WPF_TI4
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

        #region InputDigitsOnly
        private void txtEnterP_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0) && e.Text.Length <= 6)
                e.Handled = true;
        }

        private void txtrEnterQ_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0) && e.Text.Length <= 6)
                e.Handled = true;
        }

        private void txtEnterH_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0) && e.Text.Length <= 6)
                e.Handled = true;
        }

        private void txtEnterX_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0) && e.Text.Length <= 6)
                e.Handled = true;
        }

        private void txtEnterK_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0) && e.Text.Length <= 6)
                e.Handled = true;
        }
        #endregion InputDigitsOnly

        private bool myCheck()
        {
            long p, q, h, x, k, g;
            if (!long.TryParse(txtrEnterQ.Text, out q))
            {
                MessageBox.Show("Введите Q");
                return false;
            }
            else if (!DSA.checkIsPrime(q))
            {
                MessageBox.Show("Введите простое Q");
                return false;
            }

            if (!long.TryParse(txtEnterP.Text, out p))
            {
                MessageBox.Show("Введите P");
                return false;
            }
            else if (!DSA.checkIsPrime(p))
            {
                MessageBox.Show("Введите простое P");
                return false;
            }

            if (!DSA.checkQdivsP(p, q))
            {
                MessageBox.Show("Введите Q являющееся делителем (P-1)");
                return false;
            }


            if (!long.TryParse(txtEnterH.Text, out h))
            {
                MessageBox.Show("Введите H");
                return false;
            }
            else if (!DSA.checkNumberForInterval(h, 2, p - 2))
            {
                MessageBox.Show("Введите H в интервале (1, р - 1)");
                return false;
            }

            if (!long.TryParse(txtEnterX.Text, out x))
            {
                MessageBox.Show("Введите X");
                return false;
            }
            else if (!DSA.checkNumberForInterval(x, 1, q - 1))
            {
                MessageBox.Show("Введите X в интервале (0, q)");
                return false;
            }

            if (!long.TryParse(txtEnterK.Text, out k))
            {
                MessageBox.Show("Введите K");
                return false;
            }
            else if (!DSA.checkNumberForInterval(k, 1, q - 1))
            {
                MessageBox.Show("Введите K в интервале (0, q)");
                return false;
            }

            g = DSA.computeG(h, p, q);
            if (g == 1)
            {
                MessageBox.Show("G == 1, введите другое значение H");
                return false;
            }
            return true;
        }
        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                FileStream f = new(ofd.FileName, FileMode.Open);
                if (f != null)
                {
                    using (StreamReader sr = new(f))
                    {
                        StringBuilder sb = new();
                        sb.Append(sr.ReadToEnd());
                        txtFileOutput.Text = "";
                        txtFileOutput.Text = sb.ToString();
                    }
                }
                f?.Dispose();
            }
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            var sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == true)
            {
                using (var f = new FileStream(sfd.FileName, FileMode.Create))
                {
                    using (var sw = new StreamWriter(f))
                    {
                        sw.WriteLine(txtFileOutput.Text);
                        sw.Write(txtOutputR.Text + " " + txtOutputS.Text);
                    }
                }
            }
        }

        private void btnSign_Click(object sender, RoutedEventArgs e)
        {
            if (!myCheck()) return;
            long p, q, h, x, k, g, y;
            p = long.Parse(txtEnterP.Text);
            q = long.Parse(txtrEnterQ.Text);
            h = long.Parse(txtEnterH.Text);
            x = long.Parse(txtEnterX.Text);
            k = long.Parse(txtEnterK.Text);
            g = DSA.computeG(h, p, q);
            var _hash = new Hash(q, Encoding.UTF8.GetBytes(txtFileOutput.Text));
            long hash = _hash.hash();
            DSA.Sign(g, k, p, q, x, hash, out long r, out long s);
            if (r == 0)
            {
                MessageBox.Show("r = 0, Введите другие значения");
                return;
            }
            if (s == 0)
            {
                MessageBox.Show("s = 0, Введите другие значения");
                return;
            }
            txtOutputR.Text = r.ToString();
            txtOutputS.Text = s.ToString();
            txtOutputHash.Text = hash.ToString();
        }

        private void btnValidateSign_Click(object sender, RoutedEventArgs e)
        {
            if (!myCheck()) return;
            
            var str = txtFileOutput.Text.Split("\n");
            if (str.Length < 1) { 
                MessageBox.Show("Файл не подписан");
                return;
            }
            long r, s;
            var str_validate = str[^1].Split(" ");
            if (str_validate.Length < 2)
            {
                MessageBox.Show("Файл не подписан");
                return;
            }
            if (!long.TryParse(str_validate[0], out r))
            {
                MessageBox.Show("Файл не подписан");
                return;
            }
            if (!long.TryParse(str_validate[1], out s))
            {
                MessageBox.Show("Файл не подписан");
                return;
            }
            long p, q, g, y, h, x;
            p = long.Parse(txtEnterP.Text);
            q = long.Parse(txtrEnterQ.Text);
            h = long.Parse(txtEnterH.Text);
            x = long.Parse(txtEnterX.Text);
            g = DSA.computeG(h, p, q);
            y = DSA.computeY(g, x, p);
            StringBuilder _s = new();
            for (int i = 0; i <= str.Length - 2; i++)
            {
                _s.Append(str[i] + "\n");
            }
            _s.Remove(_s.Length - 2, 2);
            var _hash = new Hash(q, Encoding.UTF8.GetBytes(_s.ToString()));
            long hash = _hash.hash();
            long v;
            if (DSA.validateSigning(q, p, r, s, g, y, hash, out v))
            {
                MessageBox.Show($"Файл подписан верно\n{v} == {r}\n{hash}");
            } 
            else
            {
                MessageBox.Show($"Невалидная подпись файла!\nv - {v} != {r} - r\nHash = {hash}");
            }
        }
    }
}
