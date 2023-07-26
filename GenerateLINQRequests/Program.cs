
//1) Сформировать LINQ-запрос на получение коллекции заказчиков (Customer) из региона “Азия”.
//2) Сформировать LINQ-запрос на получение коллекции городов, в которых проживают
//      заказчики (Customer) из региона “Азия”.
//3) Сформировать LINQ-запрос на получение общей суммы продаж конкретно по каждому
//      региону и отсортировать по убыванию.
//      (сумма, имя региона)
//      (сумма, имя региона)
//   …..(сумма, имя региона)



CIniCustomer cIniCustomer = new CIniCustomer();
List<Customer> custommers = CIniCustomer.IniCustomer();

custommers.ForEach(Console.WriteLine);
Console.WriteLine();
Console.WriteLine(new string('-',99));
//1)
var customersFromAzia = from x in custommers
                        where x.Region == "Азия"
                        select x;

foreach (var item in customersFromAzia)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine(new string('-', 99));

//2)
var CityCollection = from x in custommers
                     orderby x.City
                     select new
                     {
                         Id = x.ID,
                         City = x.City
                     };

foreach (var item in CityCollection)
{
    Console.WriteLine("Пользователь с ID: " + item.Id + " из города " + item.City);
}
Console.WriteLine();
Console.WriteLine(new string('-', 99));

//3)
var sumSales = from x in custommers
               group x by x.Region into reg
               select new
               {
                   Region = reg.Key,
                   Sum = reg.Sum(x => x.Sales),
                   Group = reg
               };

foreach (var item in sumSales)
{
    Console.WriteLine(item.Sum + " " + item.Region);
    foreach (var key in item.Group)
    {
        Console.WriteLine(key);
    }
    Console.WriteLine();
}


Console.ReadLine();



class CIniCustomer
{
    public static List<Customer> IniCustomer()
    {
        List<Customer> customers = new List<Customer>()
{ new Customer { ID="A", City="Нью Йорк", Country="США",Region="Америка", Sales=9999},
  new Customer { ID="B", City="Мумбаи",   Country="Индия",Region="Азия", Sales=8888 },
  new Customer { ID="C", City="Токио",    Country="Япония",Region="Азия", Sales=7777 },
  new Customer { ID="D", City="Дейли",    Country="Индия",Region="Азия", Sales=6666 },
  new Customer { ID="E", City="Сан-Пауло",Country="Бразилия",Region="Америка",Sales=55},
  new Customer { ID="F", City="Москва", Country="Россия",Region="Европа", Sales=4444 },
  new Customer { ID="G", City="Сеул",   Country="Корея", Region="Азия",Sales=2222 },
  new Customer { ID="H", City="Минск", Country="Беларусь", Region="Европа",Sales=9999 },
  new Customer { ID="I", City="Берлин", Country="Германия", Region="Европа",Sales=500 },
  new Customer { ID="J", City="Мадрид", Country="Испания", Region="Европа",Sales=3000 }
};
        return customers;
    }
}


class Customer
{
    public string ID { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Region { get; set; }
    public decimal Sales { get; set; }
    public override string ToString()
    {
        return "ID: " + ID + " Город: " + City + " Страна: " + Country +
            " Регион: " + Region + " Продажи: " + Sales;
    }
}
