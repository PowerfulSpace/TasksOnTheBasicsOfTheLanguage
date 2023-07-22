

using System.Text;

//FileInfo file = new FileInfo(@"D:\Testing\Text.txt");
//StreamWriter writer = file.CreateText();

StreamWriter writer = new StreamWriter(@"D:\Testing\Text.txt", true, Encoding.Default);
writer.WriteLine("Первая строка текста...");
writer.WriteLine("Вторая строка текста...");

writer.Write(writer.NewLine);

writer.WriteLine("Третья строка чисел:");

for (int i = 0; i < 10; i++)
{
    writer.Write(i + " ");
}

writer.Write(writer.NewLine);

writer.Close();

Console.WriteLine("Файл Text.txt создан и в него записан текст.");

Console.WriteLine("Содержимое файла Text.txt:\n");

StreamReader reader = File.OpenText(@"D:\Testing\Text.txt");
string input;

while ((input = reader.ReadLine()) != null)
{
    Console.WriteLine(input);
}
// или Console.WriteLine(reader.ReadToEnd());

reader.Close();


Console.ReadLine();