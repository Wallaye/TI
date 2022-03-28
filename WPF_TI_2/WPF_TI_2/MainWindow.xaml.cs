using Microsoft.Win32;
using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_TI_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StreamCipher obj = new StreamCipher();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            obj.reg.Append(txtEnterStringReg.Text);
            obj.reg_bit = obj.MakeBitReg(obj.reg);
            if (obj.reg.Length != 37) MessageBox.Show("Введён неправильный ключ");
            else
            {
                try
                {
                    obj.key_bit = obj.MakeKeyBit(obj.reg_bit, obj.plain_bit.Length);
                    txtBitKey.Text = obj.BitArrayToStr(obj.key_bit).ToString();
                    obj.cipher_bit = StreamCipher.Cipher(obj.plain_bit, obj.key_bit);
                    txtBitCipher.Text = obj.BitArrayToStr(obj.cipher_bit).ToString();
                }
                catch (NullReferenceException exc)
                {
                    MessageBox.Show("Какое-то из полей не инициализировано");
                }
            }
            obj.reg.Remove(0, obj.reg.Length);
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            obj.MakePlainBit();
            txtBitPlain.Text = obj.BitArrayToStr(obj.plain_bit).ToString();
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "";
            byte[] res = new byte[obj.cipher_bit.Count / 8];
            obj.cipher_bit.CopyTo(res, 0);
            if (saveFileDialog.ShowDialog() == true)
            {
                FileStream file = new FileStream(saveFileDialog.FileName, FileMode.Create);
                file.Write(res);
                file.Dispose();
            }
        }
    }
}
