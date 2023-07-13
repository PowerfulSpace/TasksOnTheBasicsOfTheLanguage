
//Создайте коллекцию, в которой бы хранились наименования 12 месяцев, порядковый номер и 
//количество дней в соответствующем месяце. Реализуйте возможность выбора месяцев, как по 
//порядковому номеру, так и количеству дней в месяце, при этом результатом может быть не 
//только один месяц.  


using System;
using System.Collections;
using System.Globalization;

class MonthsCollection : IEnumerable<Month>
{
    Month[] array = new Month[12];

    public MonthsCollection()
    {
        DateTime date = DateTime.Now;

        DateTimeFormatInfo dateInfo = DateTimeFormatInfo.CurrentInfo;

        for (int i = 0; i <= dateInfo.MonthNames.Length - 1; i++)
        {
            if (string.IsNullOrEmpty(dateInfo.MonthNames[i]))
                continue;

            array[i].Name = dateInfo.MonthNames[i];
            array[i].Number = i + 1;
            array[i].AmountOfDays = DateTime.DaysInMonth(date.Year, i + 1);
        }
    }

    public Month SelectMonthByNumber(int number)
    {
        Month month = array.FirstOrDefault(x => x.Number == number);
        return month;
    }
    public Month[] selectMonthsByNumberOfDays(int days)
    {
        Month[] months = array.Where(x => x.AmountOfDays <= days).ToArray();
        return months;
    }

    public IEnumerator GetEnumerator()
    {
        foreach (var item in array)
        {
            yield return item;
        }
    }

    IEnumerator<Month> IEnumerable<Month>.GetEnumerator()
    {
        foreach (var item in array)
        {
            yield return item;
        }
    }
}
