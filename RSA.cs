public class RSA
{
    public void Encription(BigInteger p, BigInteger q,BigInteger e,BigInteger m)
    {
        BigInteger n = p * q;
        Console.WriteLine($"n = p* q ={n}");
        
        BigInteger phi = (p - 1) * (q - 1);
        Console.WriteLine($"φ(n) phi=> : {phi}");
        if (GCD(phi, e) == 1)
        {
            //اینجا کلیدمون خصوصیه بساز 😋
            BigInteger d = ModInverse(e, phi);
            Console.WriteLine($"d*e mod phi =>{(d*e)%phi}");

            Console.WriteLine($"private key: d=> {d}");
            BigInteger c = BigInteger.ModPow(m, e, n);
            Console.WriteLine($"cipher text= {c}");
            Console.WriteLine($"decrypte: {Decryption(c,d,n)}");
        }
        else
        {
            Console.WriteLine("phi and e gcd not equal to 1 !!!!");
        }
        
    }

    public BigInteger ModInverse(BigInteger a, BigInteger m)
    {
        BigInteger m0 = m, t, q;
        BigInteger x0 = 0, x1 = 1;

        if (m == 1)
            return 0;

        while (a > 1)
        {
            // q = a / m
            q = a / m;
            t = m;

            // m = a % m, a = t
            m = a % m;
            a = t;
            t = x0;

            // x0 = x1 - q * x0
            x0 = x1 - q * x0;
            x1 = t;
        }

        if (x1 < 0)
            x1 += m0;

        return x1;
    }
    BigInteger Decryption(BigInteger c, BigInteger d, BigInteger n)
    {
        BigInteger decrypt = BigInteger.ModPow(c, d, n);
        return decrypt;
    }
    public BigInteger GCD(BigInteger a, BigInteger b)
    {
        while (b != 0)
        {
            BigInteger temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    
    
}