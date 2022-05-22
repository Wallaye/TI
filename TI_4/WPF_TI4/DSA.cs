using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_TI4
{
    internal class DSA
    {
        /// <summary>
        /// Checks if value is prime number
        /// </summary>
        /// <returns>True if prime</returns>
        public static bool checkIsPrime(long value)
        {
            if (value < 2) return false;
            for (int i = 2; i <= Math.Sqrt(value); i++)
            {
                if (value % i == 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if Q is a divider of P-1
        /// </summary>
        /// <param name="p">P value</param>
        /// <param name="q">Q value</param>
        public static bool checkQdivsP(long p, long q)
        {
            if ((p - 1) % q == 0) return true;
            return false;
        }

        /// <summary>
        /// Checks if number is in interval [bottom, upper]
        /// </summary>
        public static bool checkNumberForInterval(long val, long bottom, long upper)
        {
            if (val <= upper && val >= bottom) return true;
            return false;
        }
        /// <summary>
        /// Quick pow algorithm
        /// </summary>
        /// <returns>The result of modular multiplication</returns>
        public static long QuickPow(long num, long pow, long mod)
        {
            long x = num;
            long z = pow;
            long result = 1;
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

        ///<returns>g = h^((p-1)/q) mod p</returns>
        public static long computeG(long h, long p, long q) =>
            QuickPow(h, (p - 1) / q, p);


        /// <returns>y = g^x mod p</returns>
        public static long computeY(long g, long x, long p) =>
            QuickPow(g, x, p);

        /// <summary>
        /// Returns a multiplicative-inversional value of x mod q
        /// </summary>
        public static long computeInversionalValue(long x, long q) => 
            QuickPow(x, q - 2, q);
        
        /// <summary>
        /// Signing source with DSA
        /// </summary>
        /// <param name="source">sorce array of bytes</param>
        public static void Sign(long g, long k, long p, long q, long x, long h, out long r, out long s)
        {
            r = QuickPow(g, k, p) % q;
            k = computeInversionalValue(k, q);
            s = k * (h + x * r) % q;           
        }

        /// <summary>
        /// Validates the signing of DSA
        /// </summary>
        public static bool validateSigning(long q, long p, long r, long s, long g, long y, long h, out long v)
        {
            long w = computeInversionalValue(s, q);
            long u1 = (h * w) % q;
            long u2 = (r * w) % q;
            v = QuickPow(g, u1, p) * QuickPow(y, u2, p) % p % q;
            if (v == r) return true;
            return false;
        }
    }
}
