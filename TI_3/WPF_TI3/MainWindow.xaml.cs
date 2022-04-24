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
using System.IO;

namespace WPF_TI3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool canCompute = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtInputP_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            canCompute = false;
            if (!Char.IsDigit(e.Text, 0))
                e.Handled = true;
            else txtInputP.Background = Brushes.White;
        }

        private void txtInputQ_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            canCompute = false;
            if (!Char.IsDigit(e.Text, 0))
                e.Handled = true;
            else txtInputQ.Background = Brushes.White;
        }

        private void txtInputB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            canCompute = false;
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
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
            bool flag1 = Rabin.checkIsPrime(p) && Rabin.checkModule4(p);
            bool flag2 = Rabin.checkIsPrime(q) && Rabin.checkModule4(q);
            if (!flag1) txtInputP.Background = Brushes.Red;
            if (!flag2) txtInputQ.Background = Brushes.Red;
            if (flag1 && flag2 && txtInputQ.Text != "" && txtInputP.Text != "")
            {
                if (!p.Equals(q))
                {
                    n = p * q;
                    lblN.Content = n.ToString();
                    if (txtInputB.Text != "")
                    {
                        b = int.Parse(txtInputB.Text);
                        if (b < n)
                        {
                            canCompute = true;
                        }
                        else txtInputB.Background = Brushes.Red;
                    }
                    else txtInputB.Background = Brushes.Red;
                }
                else txtInputQ.Background = Brushes.Red;
            }
        }

        private void btnOpenSrcFile_Click(object sender, RoutedEventArgs e)
        {
            MyOpenFile(txtPlain);
        }

        private void btnOpenCipheredFile_Click(object sender, RoutedEventArgs e)
        {
            MyOpenFile(txtCipher);
        }

        private void MyOpenFile(TextBox arg)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                FileStream f = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                if (f != null)
                {
                    byte[] arr = new byte[(int)f.Length];
                    f.Read(arr, 0, (int)f.Length);
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        sb.Append(arr[i] + " ");
                    }
                    arg.Text = sb.ToString().Trim();
                    f.Dispose();
                }
            }
        }

        private void btnCipher_Click(object sender, RoutedEventArgs e)
        {
            if (txtPlain.Text != "" && canCompute)
            {
                txtCipher.Text = string.Empty;
                txtPlain.Text = txtPlain.Text.Trim();
                string[] str = txtPlain.Text.Split();
                byte[] plain = new byte[str.Length];
                for (int i = 0; i < plain.Length; i++)
                    plain[i] = Convert.ToByte(str[i]);
                int b = Convert.ToInt32(txtInputB.Text);
                int n = Convert.ToInt32(lblN.Content);
                int[] cipher = Rabin.Cipher(plain, n, b);
                StringBuilder sb = new StringBuilder();
                foreach (int i in cipher) sb.Append(i.ToString() + " ");
                txtCipher.Text = sb.ToString().Trim();
            }
            else if (txtPlain.Text == string.Empty)
                MessageBox.Show("Не выбран файл");
            else if (!canCompute) MessageBox.Show("Пересчитайте N");
        }

        private void btnDecipher_Click(object sender, RoutedEventArgs e)
        {
            if (txtCipher.Text != "" && canCompute)
            {
                txtPlain.Text = string.Empty;
                txtCipher.Text = txtCipher.Text.Trim();
                string[] str = txtCipher.Text.Split();
                int[] plain = new int[str.Length / 4];
                StringBuilder sb = new StringBuilder();
                byte[] help = new byte[4];
                for (int i = 0; i < str.Length / 4; i++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        help[k] = Convert.ToByte(str[i * 4 + k]);
                    }
                    plain[i] = BitConverter.ToInt32(help, 0);
                }
                int p = Convert.ToInt32(txtInputP.Text);
                int q = Convert.ToInt32(txtInputQ.Text);
                int b = Convert.ToInt32(txtInputB.Text);
                int n = Convert.ToInt32(lblN.Content);
                byte[] decipher = Rabin.Decipher(plain, n, b, p, q);
                sb = sb.Clear();
                foreach (int i in decipher) sb.Append(i.ToString() + " ");
                txtPlain.Text = sb.ToString().Trim();
            }
            else if (txtCipher.Text == string.Empty)
                MessageBox.Show("Не выбран файл");
            else if (!canCompute) MessageBox.Show("Пересчитайте N");
        }

        private void btnSavePlainFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == true)
            {
                FileStream f = new FileStream(sfd.FileName, FileMode.Create);
                if (f != null)
                {
                    txtPlain.Text = txtPlain.Text.Trim();
                    string[] str = txtPlain.Text.Split();
                    byte[] plain = new byte[str.Length];
                    for (int i = 0; i < str.Length; i++)
                        plain[i] = Convert.ToByte(str[i]);
                    f.Write(plain, 0, plain.Length);
                    f.Dispose();
                }
            }
        }

        private void btnSaveCipheredFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == true)
            {
                FileStream f = new FileStream(sfd.FileName, FileMode.Create);
                if (f != null)
                {
                    txtCipher.Text = txtCipher.Text.Trim();
                    string[] str = txtCipher.Text.Split();
                    int[] cipher = new int[str.Length];
                    for (int i = 0; i < str.Length; i++)
                        cipher[i] = Convert.ToInt32(str[i]);
                    byte[] plain = new byte[cipher.Length * 4];
                    for (int i = 0; i < cipher.Length; i++)
                    {
                        var help = BitConverter.GetBytes(cipher[i]);
                        for (int k = 0; k < 4; k++)
                        {
                            plain[i * 4 + k] = help[k];
                        }
                    }
                    f.Write(plain, 0, plain.Length);
                    f.Dispose();
                }
            }
        }
    }
}