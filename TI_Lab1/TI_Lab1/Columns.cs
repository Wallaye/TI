using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Lab1
{
    internal class Columns
    {
        public static string Encipher(string arg, string key)
        {
            if (key == String.Empty)
            {
                return arg;
            }
            int rows = (int)Math.Ceiling((double)arg.Length / key.Length) + 1;
            char[,] arr = new char[rows, key.Length];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < key.Length; j++)
                    arr[i, j] = ' ';
            StringBuilder sb = new StringBuilder();
            sb.Append(key);
            for (int i = 0; i < key.Length; i++)
                arr[0, i] = sb[i];
            sb.Remove(0, sb.Length);
            sb.Append(arg);
            int k = 0;
            for (int i = 1; i < rows - 1; i++)
                for (int j = 0; j < key.Length; j++)
                    arr[i, j] = sb[k++];
            int z = 0;
            while (k < sb.Length) arr[rows - 1, z++] = sb[k++];
            #region сортировка
            for (int i = 0; i < key.Length - 1; i++)
            {
                for (int j = i; j < key.Length; j++)
                {
                    if (arr[0, i] > arr[0, j])
                    {
                        for (k = 0; k < rows; k++)
                        {
                            char temp = arr[k, i];
                            arr[k, i] = arr[k, j];
                            arr[k, j] = temp;
                        }
                    }
                }
            }
            #endregion сортировка
            sb.Remove(0, sb.Length);
            k = 0;
            for (int j = 0; j < key.Length; j++)
            {
                for (int i = 1; i < rows; i++)
                {
                    if (arr[i, j] != ' ')
                    {
                        sb.Append(arr[i, j]);
                        k++;
                        k %= 5;
                        if (k == 0) sb.Append(' ');
                    }
                }
            }
            return sb.ToString();
        }
        public static string Decipher(string arg, string key)
        {
            if (key == String.Empty)
            {
                return arg;
            }
            int rows = (int)Math.Ceiling((double)arg.Length / key.Length) + 1;
            char[,] arr = new char[rows, key.Length];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < key.Length; j++)
                    arr[i, j] = ' ';
            StringBuilder sb = new StringBuilder();
            sb.Append(key);
            for (int i = 0; i < key.Length; i++)
                arr[0, i] = sb[i];
            sb.Remove(0, sb.Length);
            for (int i = 0; i < key.Length - 1; i++)
            {
                for (int j = i; j < key.Length; j++)
                {
                    if (arr[0, i] > arr[0, j])
                    {
                        char temp = arr[0, i];
                        arr[0, i] = arr[0, j];
                        arr[0, j] = temp;
                    }
                }
            }
            sb.Append(arg);
            int k = 0;
            for (int i = 0; i < key.Length; i++)
                for (int j = 1; j < rows - 1; j++)
                    arr[j, i] = sb[k++];
            return sb.ToString();
        }
        public static string ReadKey(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in str)
            {
                if (Char.ToUpper(ch) <= 'Z' && Char.ToUpper(ch) >= 'A')
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
                if (Char.ToUpper(ch) <= 'Z' && Char.ToUpper(ch) >= 'A')
                {
                    sb.Append(Char.ToUpper(ch));
                }
            }
            return sb.ToString();
        }
    }
}
