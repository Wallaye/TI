using System.Text;

namespace TI_4
{
    class Program
    {
        public static void Main()
        {
            var h = new Hash(433, Encoding.UTF8.GetBytes("BSUIR"));
            //long c = h.hash();
            //DSA.Sign(729, 23, 3559, 593, 17, c, out long r, out long s);
            //var h = new Hash(593, new byte[] { });
            long c = h.hash();
            Console.WriteLine(h.hash());
            DSA.Sign(8489, 17, 19919, 433, 11, c, out long r, out long s);
            Console.WriteLine($"{r} : {s}");
            //Console.WriteLine($"{DSA.validateSigning(593, 3559, r, s, 729, DSA.computeY(729, 17, 3559), c)}");
        }
    }
}