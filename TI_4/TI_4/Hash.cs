using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_4
{
    internal class Hash
    {
        public long n { get; set; }
        public long h0 { get; set; }
        public byte[] source { get; set; }
        public Hash(long n, byte[] source, long h0 = 100)
        {
            this.n = n;
            this.h0 = h0;
            this.source = source;
        }
        /// <summary>
        /// Hashing method
        /// </summary>
        /// <returns>Hashed source</returns>
        public long hash()
        {
            long h = h0;
            foreach (byte b in source)
            {
                h = DSA.QuickPow(h + b, 2, n);
            }
            return h;
        }
    }
}
