//Создайте коллекцию, в которой бы хранились наименования 12 месяцев, порядковый номер и 
//количество дней в соответствующем месяце. Реализуйте возможность выбора месяцев, как по 
//порядковому номеру, так и количеству дней в месяце, при этом результатом может быть не 
//только один месяц.  

MonthsCollection array = new MonthsCollection();
Show(array);
Console.WriteLine();

Console.WriteLine("Выбор месца который идёт 5 по счёту");
Console.WriteLine(array.SelectMonthByNumber(5).Name);
Console.WriteLine();

Console.WriteLine("Выбор месцев в которых есть 30 дней");
var selectMonthsByNumberOfDays = array.selectMonthsByNumberOfDays(30);
Show(selectMonthsByNumberOfDays);

Console.ReadLine();


static void Show(IEnumerable<Month> array)
{
    foreach (Month item in array)
    {
        Console.WriteLine("{0,-10} Порядковый номер - {1,-10} Количество дней в месяце - {2}", item.Name, item.Number, item.AmountOfDays);
    }
}
