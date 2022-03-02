using System;
using System.Collections.Generic;
using System.Text;

namespace TI_Lab1
{
    internal class Columns
    {
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
            if (arg == String.Empty)
            {
                return arg;
            }
            if (key == String.Empty)
            {
                return arg;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(key);
            int[] order = new int[key.Length];
            int j = 0;
            int big_col = arg.Length % key.Length;
            List<int> big_ind = new List<int>();
            for (char k = 'A'; k <= 'Z' && sb.Length != 0; k++)
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (sb[i] == k)
                    {
                        if (i < big_col)
                        {
                            big_ind.Add(j);
                        }
                        order[i] = j++;
                    }
                }
            };
            sb.Remove(0, sb.Length);

            sb.Append(arg);
            int rows = (int)Math.Ceiling((double)arg.Length / key.Length);
            char[,] arr = new char[rows, key.Length];
            j = 0;
            for (int k = 0; k < key.Length; k++)
            {
                if (big_col == 0 || big_ind.Contains(k))
                {
                    for (int i = 0; i < rows; i++)
                    {
                        arr[i, k] = sb[j++];
                    }
                }
                else
                {
                    for (int i = 0; i < rows - 1; i++)
                    {
                        arr[i, k] = sb[j++];
                    }
                }
            }
            sb.Remove(0, sb.Length);
            for (int i = 0; i < rows; i++)
            {
                for (j = 0; j < key.Length; j++)
                {
                    if (Char.IsLetter(arr[i, order[j]]))
                    {
                        sb.Append(arr[i, order[j]]);
                    }
                }
            }
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
