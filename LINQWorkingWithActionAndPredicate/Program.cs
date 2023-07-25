


var spisok = new List<string>(5);

for (int i = 0; i < 5; i++)
{
    spisok.Add("number " + (i + 1));
}

spisok.ForEach(Console.WriteLine);
Console.WriteLine();

foreach (var item in spisok.FindAll(new Predicate<string>(x => x[x.Length - 1] == '5' || x[x.Length - 1] == '3')))
{
    Console.WriteLine(item);
}

Console.ReadKey();




//Выбор из 100 только number 3 и number 5

//var spisok = new List<string>(100);

//for (int i = 0; i < 100; i++)
//{
//    spisok.Add("number " + (i + 1));
//}

//spisok.ForEach(Console.WriteLine);
//Console.WriteLine();

//foreach (var item in spisok.FindAll(new Predicate<string>(x => x.Contains(" 5") && x[x.Length - 1] == '5' && x[x.Length - 2] != '5' || x.Contains(" 3") && x[x.Length - 1] == '3' && x[x.Length - 2] != '3')))
//{
//    Console.WriteLine(item);
//}