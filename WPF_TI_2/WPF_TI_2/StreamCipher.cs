using System.Collections;
using System.Text;
using System.IO;
using System;
using Microsoft.Win32;

namespace WPF_TI_2
{
    public class StreamCipher
    {
        public StringBuilder reg;
        public BitArray reg_bit;
        public BitArray key_bit;
        public BitArray plain_bit;
        public BitArray cipher_bit;

        public StreamCipher()
        {
            reg = new StringBuilder();
        }

        public StringBuilder Read_reg(StringBuilder reg)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= reg.Length; i++)
            {
                if (reg[^i] == '1' || reg[^i] == '0') result.Append(reg[^i]);
            }

            return result;
        }

        public BitArray MakeBitReg(StringBuilder reg)
        {
            BitArray reg_bit = new BitArray(reg.Length);
            for (int i = 0; i < reg.Length; i++)
            {
                if (reg[i] == '1') reg_bit[i] = true;
            }

            return reg_bit;
        }

        public BitArray MakeKeyBit(BitArray reg, int length)
        {
            BitArray key = new BitArray(length);
            for (int i = 0; i < length; i++)
            {
                bool nextVal = reg[36] ^ reg[11];
                nextVal ^= reg[9];
                nextVal ^= reg[1];
                key[i] = reg[36];
                reg = reg.LeftShift(1);
                reg[0] = nextVal;
            }
            return key;
        }

        public void MakePlainBit()
        {
            var openFileDialog1 = new OpenFileDialog();
            StringBuilder plain = new StringBuilder();
            if (openFileDialog1.ShowDialog() == true)
            {
                FileStream file = new FileStream(openFileDialog1.FileName, FileMode.Open);
                byte[] arr = new byte[file.Length];
                file.Read(arr, 0, (int)file.Length);
                foreach (var b in arr)
                {
                    byte[] help_arr = new byte[1];
                    help_arr[0] = b;
                    BitArray help = new BitArray(help_arr);
                    foreach (bool b1 in help)
                    {
                        plain.Append(Convert.ToInt32(b1));
                    }
                }
                plain_bit = new BitArray(plain.Length);
                for (int i = 0; i < plain_bit.Length; i++)
                {
                    if (plain[i] == '1') plain_bit[i] = true;
                }
                file.Dispose();
            }
        }

        public static BitArray Cipher(BitArray key, BitArray source)
        {
            return source.Xor(key);
        }

        public StringBuilder BitArrayToStr(BitArray temp)
        {
            StringBuilder res = new StringBuilder();
            if (temp != null)
                if (temp.Length <= 336)
                    foreach (var b in temp)
                    {
                        res.Append(Convert.ToInt32(b));
                    }
                else
                {
                    res.Append("Первые 10 байт:\n");
                    for (int i = 0; i < 80; i++)
                        res.Append(Convert.ToInt32(temp[i]));
                    res.Append("\nПоследние 10 байт: \n");
                    for (int i = 80; i > 0; i--)
                        res.Append(Convert.ToInt32(temp[^i]));
                }
            return res;
        }

    }
}