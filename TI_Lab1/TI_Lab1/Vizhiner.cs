using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Lab1
{
    internal class Vizhiner
    {
        public const int count_alphabet = 33;
        public static string Encipher(string arg, string key)
        {
            if (arg == String.Empty)
            {
                return arg;
            }
            if (key == String.Empty)
            {
                return arg;
            }
            StringBuilder sbkey = new StringBuilder();
            StringBuilder sbarg = new StringBuilder();
            StringBuilder sbresult = new StringBuilder();
            sbkey.Append(key);
            sbarg.Append(arg);
            char[,] matrix = new char[key.Length + 1, count_alphabet];
            int k = 0;
            for (char i = 'А'; i <= 'Я'; i++)
            {
                if (k == 6) matrix[0, k++] = 'Ё';
                matrix[0, k++] = i;
            }
            int offset = 0;
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < count_alphabet; j++)
                    if (sbkey[i] == matrix[0, j])
                        offset = j;
                for (k = 0; k < count_alphabet; k++)
                {
                    matrix[i + 1, k] = matrix[0, (k + offset) % 33];
                }
            }
            int index = 0;
            k = 1;
            for (int i = 0; i < sbarg.Length; i++)
            {
                for (int j = 0; j < count_alphabet; j++)
                    if (sbarg[i] == matrix[0, j])
                        index = j;
                sbresult.Append(matrix[(i % (key.Length) + 1), index]);
                if (k++ % 5 == 0)
                    sbresult.Append(' ');
            }

            return sbresult.ToString();
        }
        public static string Decipher(string arg, string key)
        {
            if (arg == String.Empty)
            {
                return arg;
            }
            if (key == String.Empty)
            {
                return arg;
            }
            StringBuilder sbkey = new StringBuilder();
            StringBuilder sbarg = new StringBuilder();
            StringBuilder sbresult = new StringBuilder();
            sbkey.Append(key);
            sbarg.Append(arg);
            char[,] matrix = new char[key.Length + 1, count_alphabet];
            int k = 0;
            for (char i = 'А'; i <= 'Я'; i++)
            {
                if (k == 6) matrix[0, k++] = 'Ё';
                matrix[0, k++] = i;
            }
            int offset = 0;
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < count_alphabet; j++)
                    if (sbkey[i] == matrix[0, j])
                        offset = j;
                for (k = 0; k < count_alphabet; k++)
                {
                    matrix[i + 1, k] = matrix[0, (k + offset) % 33];
                }
            }

            int index = 0;
            for (int i = 0; i < sbarg.Length; i++)
            {
                for (int j = 0; j < count_alphabet; j++)
                    if (sbarg[i] == matrix[(i % (key.Length) + 1), j])
                        index = j;
                sbresult.Append(matrix[0, index]);
            }
            return sbresult.ToString();
        }
        public static string ReadKey(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in str)
            {
                if (Char.ToUpper(ch) <= 'Я' && Char.ToUpper(ch) >= 'А' || Char.ToUpper(ch) == 'Ё')
                {
                    sb.Append(Char.ToUpper(ch));
                }
            }
            return sb.ToString();
        }
        public static string ReadPlainText(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in str)
            {
                if (Char.ToUpper(ch) <= 'Я' && Char.ToUpper(ch) >= 'А' || Char.ToUpper(ch) == 'Ё')
                {
                    sb.Append(Char.ToUpper(ch));
                }
            }
            return sb.ToString();
        }
    }
}
