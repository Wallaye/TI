using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_TI1
{
    internal class RailwayFence
    {
        public static string Encipher(string arg, int key)
        {
            if (key > arg.Length || key == 1)
            {
                return arg;
            };
            StringBuilder sb = new StringBuilder();
            sb.Append(arg);
            char[,] arr = new char[key, arg.Length];
            int j = 0;
            bool flag = true;           // возрастает ли j или убывает
            for (int i = 0; i < key; i++)
            {
                for (int k = 0; k < arg.Length; k++)
                    arr[i, k] = ' ';
            }
            for (int i = 0; i < arg.Length; i++)
            {
                arr[j, i] = Char.ToUpper(sb[i]);
                if (flag) j++;
                else j--;
                if (j >= key - 1) flag = false;
                if (j == 0) flag = true;
            }
            sb.Remove(0, sb.Length);
            j = 0;
            for (int i = 0; i < key; i++)
            {
                for (int k = 0; k < arg.Length; k++)
                {
                    if (Char.IsLetter(arr[i, k]))
                    {
                        sb.Append(arr[i, k]);
                        j++;
                        j %= 5;
                        if (j == 0) sb.Append(' ');
                    }
                }
            }
            return sb.ToString();
        }
        public static string Decipher(string arg, int key)
        {
            if (key > arg.Length || key == 1)
            {
                return arg;
            };
            StringBuilder sb = new StringBuilder();
            sb.Append(arg);
            char[,] arr = new char[key, arg.Length];
            for (int i = 0; i < key; i++)
            {
                for (int k = 0; k < arg.Length; k++)
                    arr[i, k] = ' ';
            }
            int j = 0;
            bool flag = true;           // возрастает ли j или убывает
            for (int i = 0; i < arg.Length; i++)
            {
                arr[j, i] = '-';
                if (flag) j++;
                else j--;
                if (j >= key - 1) flag = false;
                if (j == 0) flag = true;
            }
            j = 0;
            for (int i = 0; i < key; i++)
            {
                for (int k = 0; k < arg.Length; k++)
                {
                    if (arr[i, k] == '-')
                    {
                        arr[i, k] = sb[j];
                        j++;
                    }
                }
            }
            sb.Remove(0, sb.Length);
            j = 0;
            flag = true;
            for (int i = 0; i < arg.Length; i++)
            {
                sb.Append(arr[j, i]);
                if (flag) j++;
                else j--;
                if (j >= key - 1) flag = false;
                if (j == 0) flag = true;
            }
            return sb.ToString();
        }
        public static int ReadKey(string str)
        {
            int value;
            if (int.TryParse(string.Join("", str.Where(c => char.IsDigit(c))), out value))
            {
                value = Math.Abs(value);
                if (value == 0) return -1;
                return value;
            }
            else return -1;
        }
        public static string ReadPlainText(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in str)
            {
                if (Char.ToUpper(ch) <= 'Z' && Char.ToUpper(ch) >= 'A')
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString();
        }
    }
}
