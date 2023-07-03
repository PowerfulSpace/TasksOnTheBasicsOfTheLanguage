
//Создайте класс, который будет содержать информацию о дате (день, месяц, год).
//С помощью механизма перегрузки операторов, определите операцию разности двух дат
//(результат в виде количества дней между датами),
//а также операцию увеличения даты на определенное количество дней (результат в виде новой даты).  



MyDate date1 = new MyDate(2010,1,10);
MyDate date2 = new MyDate(2001,6,5);

int countDays = date1 - date2;


Console.ReadLine();


class MyDate
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public readonly DateTime date;

    public MyDate()
    {
        date = DateTime.UtcNow;

        Year = date.Year;
        Month = date.Month;
        Day = date.Day;
    }
    public MyDate(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;

        date = new DateTime(Year, Month, Day);
    }

    public MyDate DateIncrement(int days)
    {
        DateTime newDate = date.AddDays(days);
        MyDate newMyDate =  new MyDate(newDate.Year, newDate.Month, newDate.Day);

        Year = newDate.Year;
        Month = newDate.Month;
        Day = newDate.Day;

        return newMyDate;
    }
    public MyDate DateDecrement(int days)
    {
        DateTime newDate = date.AddDays(-days);
        MyDate newMyDate = new MyDate(newDate.Year, newDate.Month, newDate.Day);

        Year = newDate.Year;
        Month = newDate.Month;
        Day = newDate.Day;

        return newMyDate;
    }

    public static int operator -(MyDate a, MyDate b)
    {
        var dateTime = a.date.Subtract(b.date).Days;

        return dateTime;
    }

}