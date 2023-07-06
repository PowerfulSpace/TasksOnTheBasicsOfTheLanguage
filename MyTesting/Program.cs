class Program
{
    static void Main(string[] args)
    {
        UnlistedPhone phonel = new UnlistedPhone("Tом", "555-3456",
                                                new BitCipher(27));
        UnlistedPhone phone2 = new UnlistedPhone("Мэри", "555-8891",
                                                  new BitCipher(9));
        Console.WriteLine("Телефонный номер абонента по имени "
        + phonel.Name + " : "
        + phonel.Number);
        Console.WriteLine("Телефонный номер абонента по имени "
        + phone2.Name + " : "
        + phone2.Number);

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

        //for (int i = 0; i < str.Length; i++)
        //    ciphertext = ciphertext + (char)(str[i] ^ key);

        for (int i = 0; i < str.Length; i++)
        {
            int a = str[i];
            char b = (char)(a ^ key);
            ciphertext += b;
        }
        return ciphertext;
    }

    public string decode(string str)
    {
        string plaintext = "";

        //for (int i = 0; i < str.Length; i++)
        //    plaintext = plaintext + (char)(str[i] ^ key);

        for (int i = 0; i < str.Length; i++)
        {
            int a = str[i];
            char b = (char)(a ^ key);
            plaintext += b;
        }

        return plaintext;
    }
}

class UnlistedPhone
{
    string pri_name;
    string pri_number;

    ICipher crypt;

    public UnlistedPhone(string name, string number, ICipher c)
    {
        crypt = c;

        pri_name = crypt.encode(name);
        pri_number = crypt.encode(number);
    }

    public string Name
    {
        get
        {
            return crypt.decode(pri_name);
        }
        set
        {
            pri_name = crypt.encode(value);
        }
    }

    public string Number
    {
        get
        {
            return crypt.decode(pri_number);
        }
        set
        {
            pri_number = crypt.encode(value);
        }
    }
}










