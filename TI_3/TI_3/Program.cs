using static TI_3.Rabin;

int p = 3511;
int q = 3;
int n = p * q;
int b = 1;
Console.WriteLine($"p-{p}  q-{q}  n-{n} b-{b}");
FileStream file = new FileStream(@"D:\test.txt", FileMode.OpenOrCreate);
byte[] data = new byte[file.Length];
file.Read(data, 0, (int)file.Length);
int[] cipher = Cipher(data, n, b);
byte[] _cipher = new byte[cipher.Length * 4];
for (int i = 0; i < cipher.Length; i++)
{
    var help = BitConverter.GetBytes(cipher[i]);
    for (int k = 0; k < 4; k++)
    {
        _cipher[i * 4 + k] = help[k];
    }
}

using (var fs = new FileStream(@"D:\test1.txt", FileMode.Create))
{
    fs.Write(_cipher, 0, _cipher.Length);
    Console.WriteLine("Записано в файл");
}

byte[] __cipher;

using (var fs = new FileStream(@"D:\test1.txt", FileMode.Open))
{
    __cipher = new byte[fs.Length];
    fs.Read(__cipher, 0, __cipher.Length);
    Console.WriteLine("Записано в файл");
}

int[] icipher = new int[__cipher.Length / 4];
for (int i = 0; i < icipher.Length; i++)
{
    var help = new byte[4];
    for (int k = 0; k < 4; k++)
    {
        help[k] = __cipher[i * 4 + k];
    }

    icipher[i] = BitConverter.ToInt32(help);
}
foreach (var item in data)
{
    Console.Write(item + " ");
}
Console.WriteLine();
byte[] arr = Decipher(icipher, n, b, p, q);
foreach (var item in arr)
{
    Console.Write(item + " ");
}