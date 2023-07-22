
//Создайте файл, запишите в него произвольные данные и закройте файл. Затем снова откройте 
//этот файл, прочитайте из него данные и выведете их на консоль.

using System.Text;

string path = @"D:\Testing\Test.txt";
StreamWriter file = new StreamWriter(path,true,Encoding.UTF8);

file.WriteLine("Первоя строка");
file.WriteLine("Вторая строка");
file.WriteLine("Третья строка");

file.Close();


StreamReader streamReader = new StreamReader(path);

foreach (var item in streamReader.ReadToEnd())
{
    Console.Write(item);
}
streamReader.Close();

Console.ReadLine();