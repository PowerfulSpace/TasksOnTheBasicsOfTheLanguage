


int[] MyArray = { 10, 21, 12, 85, 45, 20 };
var queryRes = from a in MyArray where a > 10 select a;
Console.WriteLine("Количество чисел > 10");
Console.WriteLine(queryRes.Count());
Console.WriteLine("Максимальное из чисел > 10");
Console.WriteLine(queryRes.Max());
Console.WriteLine("Минимальное из чисел > 10");
Console.WriteLine(queryRes.Min());
Console.WriteLine("Среднее из чисел > 10");
Console.WriteLine(queryRes.Average());
Console.WriteLine("Сумма чисел > 10");
Console.WriteLine(queryRes.Sum());

Console.ReadKey();

