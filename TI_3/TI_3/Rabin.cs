namespace TI_3
{
    internal static class Rabin
    {
        /// <summary>
        /// Checks if value is prime number
        /// </summary>
        /// <returns>True if prime</returns>
        public static bool checkIsPrime(int value)
        {
            for (int i = 2; i <= value / 2; i++)
            {
                if (value % i == 0) return false;
            }
            return true;
        }
        /// <summary>
        /// Checks if value mod 4 gives 3
        /// </summary>
        public static bool checkModule4(int value)
        {
            if (value % 4 == 3) return true;
            return false;
        }
        /// <summary>
        /// Main ciphering alogorithm 
        /// result[i] = arr[i] * (arr[i] + b) mod n
        /// </summary>
        /// <returns>Array of int with ciphered values</returns>
        public static int[] Cipher(byte[] arr, int n, int b)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = (arr[i] * (arr[i] + b)) % n;
            }
            return result;
        }
        /// <summary>
        /// Deciphering algorithm
        /// </summary>
        /// <returns>deciphered byte[] array</returns>
        public static byte[] Decipher(int[] arr, int n, int b, int p, int q)
        {
            byte[] result = new byte[arr.Length];
            int Discr;
            int[] d = new int[4];
            int[] data = new int[4];
            int mp, mq, yp, yq;
            Euclide(p, q, out yp, out yq);
            for (int i = 0; i < arr.Length; i++)
            {
                Discr = (b * b + 4 * arr[i]) % n;
                mp = QuickPow(Discr, (p + 1) / 4, p);
                mq = QuickPow(Discr, (q + 1) / 4, q);
                d[0] = (yp * p * mq + yq * q * mp) % n;
                d[1] = n - d[0];
                d[2] = (yp * p * mq - yq * q * mp) % n;
                d[3] = n - d[2];
                for (int k = 0; k < 4; k++)
                {
                    if ((d[k] - b) % 2 == 0) data[k] = ((d[k] - b) / 2 % n);
                    else data[k] = (d[k] - b + n) / 2 % n;
                    if (data[k] < 0)
                    {
                        data[k] = Math.Abs(data[k]);
                        data[k]--;
                    }
                    if (data[k] is (>= 0 and <= 255))
                    {
                        result[i] = (byte)data[k];
                        break;
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Extended Euclide algorithm
        /// </summary>
        public static void Euclidix(int a, int b, out int x1, out int y1, out int d1)
        {
            int d0 = a;
            d1 = b;
            int x0 = 1;
            x1 = 0;
            int y0 = 0;
            y1 = 1;
            while (d1 > 1)
            {
                int q = d0 % d1;
                int d2 = d0 / d1;
                int x2 = x0 - q * x1;
                int y2 = y0 - q * x1;
                d0 = d1;
                d1 = d2;
                x0 = x1;
                y0 = y1;
                x1 = x2;
                y1 = y2;
            }
        }
        /// <summary>
        /// Quick pow algorithm
        /// </summary>
        /// <returns>The result of modular multiplication</returns>
        public static int QuickPow(int num, int pow, int mod)
        {
            int x = num;
            int z = pow;
            int result = 1;
            while (z != 0)
            {
                while (z % 2 == 0)
                {
                    z = z / 2;
                    x = (x * x) % mod;
                }
                z--;
                result = (result * x) % mod;
            }
            return result;
        }

        /// <summary>
        /// Extended Euclide algorithm
        /// </summary>
        /// <remarks>
        /// It is recursive algorithm of Euclide, x and y are passed like out parametrs and they are
        /// coefficients yp yq
        /// </remarks>
        public static int Euclide(int a, int b, out int x, out int y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }
            int gcd = Euclide(b % a, a, out x, out y);
            int newY = x;
            int newX = y - b / a * x;
            x = newX;
            y = newY;
            return gcd;
        }
    }
}
