

List<Customer> customers = CIniCustomer.IniCustomer();

var queryRes = from a in customers
               orderby a.Sales descending
               select new { a.ID, a.City, a.Country, a.Sales };

Console.WriteLine("Верхняя пятерка заказчиков по результатам продаж");
foreach (var item in queryRes.Take(5))
{ Console.WriteLine(item); }

Console.WriteLine("Заказчики, не вошедшие в верхнюю пятерку");
foreach (var item in queryRes.Skip(5))
{ Console.WriteLine(item); }

Console.ReadKey();







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


class CIniCustomer
{
    public static List<Customer> IniCustomer()
    {
        List<Customer> customers = new List<Customer>()
                                       {
                                            new Customer { ID="A", City="Нью Йорк", Country="США",Region="Америка", Sales=9999},
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
