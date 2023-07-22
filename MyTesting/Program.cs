

FileStream file = File.Open(@"D:\Testing\text.txt", FileMode.Open);

BinaryReader reader = new BinaryReader(file);

long number = reader.ReadInt64();
byte[] bytes = reader.ReadBytes(4);
string s = reader.ReadString();

reader.Close();

Console.WriteLine(number);
foreach (byte b in bytes)
{
    Console.Write("[{0}]", b);
}

Console.WriteLine();
Console.WriteLine(s);



Console.ReadLine();