using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TI_Lab1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKey.Text = string.Empty;
            txtPlainText.Text = string.Empty;
            textBox1.Text = string.Empty;
        }

        private void btnEnterPlainText_Click(object sender, EventArgs e)
        {
            string PlainText, Cipher;
            int Key;
            string key;
            if (rbdRailway.Checked)
            {
                Key = RailwayFence.ReadKey(txtKey.Text);
                if (Key == -1)
                {
                    textBox1.Text = String.Empty;
                    MessageBox.Show("ВВЕДЁН НЕПРАВИЛЬНЫЙ КЛЮЧ", "Invalid Key");
                }
                else
                {
                    txtKey.Text = Key.ToString();
                    PlainText = RailwayFence.ReadPlainText(txtPlainText.Text);
                    Cipher = RailwayFence.Encipher(PlainText, Key);
                    textBox1.Text = Cipher;
                }
            } else if (rdbColums.Checked)
            {
                key = Columns.ReadKey(txtKey.Text);
                if (key == String.Empty)
                {
                    textBox1.Text = String.Empty;
                    MessageBox.Show("НЕ ВВЕДЁНО АНГЛИЙСКИХ БУКВ", "Invalid Key");
                }
                else
                {
                    txtKey.Text = key;
                    PlainText = Columns.ReadPlainText(txtPlainText.Text);
                    Cipher = Columns.Encipher(PlainText, key);
                    textBox1.Text = Cipher;
                }
            } else
            {
                key = Vizhiner.ReadKey(txtKey.Text);
                if (key == String.Empty)
                {
                    textBox1.Text = String.Empty;
                    MessageBox.Show("НЕ ВВЕДЁНО РУССКИХ БУКВ", "Invalid Key");
                }
                else
                {
                    txtKey.Text = key;
                    PlainText = Vizhiner.ReadPlainText(txtPlainText.Text);
                    Cipher = Vizhiner.Encipher(PlainText, key);
                    textBox1.Text = Cipher;
                }
            }
        }

        private void btnEncipher_Click(object sender, EventArgs e)
        {
            string PlainText, Decipher;
            int Key;
            string key;
            if (rbdRailway.Checked)
            {
                Key = RailwayFence.ReadKey(txtKey.Text);
                if (Key == -1)
                {
                    textBox1.Text = String.Empty;
                    MessageBox.Show("ВВЕДЁН НЕПРАВИЛЬНЫЙ КЛЮЧ", "Invalid Key");
                }
                else
                {
                    txtKey.Text = Key.ToString();
                    PlainText = RailwayFence.ReadPlainText(txtPlainText.Text);
                    Decipher = RailwayFence.Decipher(PlainText, Key);
                    textBox1.Text = Decipher;
                }
            }
            else if (rdbColums.Checked)
            {
                key = Columns.ReadKey(txtKey.Text);
                if (key == String.Empty)
                {
                    textBox1.Text = String.Empty;
                    MessageBox.Show("НЕ ВВЕДЁНО АНГЛИЙСКИХ БУКВ", "Invalid Key");
                }
                else
                {
                    txtKey.Text = key;
                    PlainText = Columns.ReadPlainText(txtPlainText.Text);
                    Decipher = Columns.Decipher(PlainText, key);
                    textBox1.Text = Decipher;
                }
            }
            else
            {
                key = Vizhiner.ReadKey(txtKey.Text);
                if (key == String.Empty)
                {
                    textBox1.Text = String.Empty;
                    MessageBox.Show("НЕ ВВЕДЁНО АНГЛИЙСКИХ БУКВ", "Invalid Key");
                }
                else
                {
                    txtKey.Text = key;
                    PlainText = Vizhiner.ReadPlainText(txtPlainText.Text);
                    Decipher = Vizhiner.Decipher(PlainText, key);
                    textBox1.Text = Decipher;
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.Cancel) return;
            if (dialogResult == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                var fileStream = openFileDialog1.OpenFile();
                StringBuilder sb = new StringBuilder();
                string str;
                using (StreamReader file = new StreamReader(fileStream))
                {
                    do
                    {
                        str = file.ReadLine();
                        sb.Append(str);
                    } while (str != null);
                }
                txtPlainText.Text = sb.ToString();
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = saveFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.Cancel) return;
            if (dialogResult == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                var fileStream = saveFileDialog1.OpenFile();

                using (StreamWriter file = new StreamWriter(fileStream))
                {
                    file.WriteLine(textBox1.Text);
                    file.WriteLine(txtKey.Text);
                }
            }
        }
    }
}
