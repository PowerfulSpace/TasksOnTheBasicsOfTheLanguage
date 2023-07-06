class Program
{
    static void Main(string[] args)
    {
        ICipher ciphRef;
        BitCipher bit = new BitCipher(27);
        SimpleCipher sc = new SimpleCipher();

        string plain;
        string coded;

        ciphRef = sc;
        Console.WriteLine("Использование простого шифра.");

        plain = "testing";
        coded = ciphRef.encode(plain);
        Console.WriteLine("Зашифрованный текст: " + coded);

        plain = ciphRef.decode(coded);
        Console.WriteLine("Открытый текст: " + plain);

        ciphRef = bit;
        Console.WriteLine("\nИспользование поразрядного шифрования.");


        plain = "testing";
        coded = ciphRef.encode(plain);
        Console.WriteLine("Зашифрованный текст: " + coded);

        plain = ciphRef.decode(coded);
        Console.WriteLine("Открытый текст: " + plain);

        Console.ReadKey();

    }
}

public interface ICipher
{
    string encode(string str);
    string decode(string str);
}

class SimpleCipher : ICipher
{
    public string encode(string str)
    {
        string ciphertext = "";

        for (int i = 0; i < str.Length; i++)
            ciphertext = ciphertext + (char)(str[i] + 1);

        return ciphertext;
    }

    public string decode(string str)
    {
        string plaintext = "";

        for (int i = 0; i < str.Length; i++)
            plaintext = plaintext + (char)(str[i] - 1);

        return plaintext;
    }
}

class BitCipher : ICipher
{
    ushort key;

    public BitCipher(ushort k)
    {
        key = k;
    }

    public string encode(string str)
    {
        string ciphertext = "";

        for (int i = 0; i < str.Length; i++)
            ciphertext = ciphertext + (char)(str[i] ^ key);

        return ciphertext;
    }

    public string decode(string str)
    {
        string plaintext = "";

        for (int i = 0; i < str.Length; i++)
            plaintext = plaintext + (char)(str[i] ^ key);

        return plaintext;
    }
}

