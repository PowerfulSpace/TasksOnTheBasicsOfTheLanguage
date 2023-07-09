enum EnumType
{
    Zero,  // = 0 
    One = 1,
    one = One,
    Two = 2,
    Three, // = 3
    Four,  // = 4
    Five = 5,
    //Six,
    Seven,
    Eight = 8,
    Nine,
    Ten = 10,
    Infinite = 255
}
class Program
{
    static void Main()
    {
        // Enum.GetValues() - возвращает экземпляр System.Array, при этом каждому элементу массива 
        // будет соответствовать член указанного перечисления.

        // Помещаем в массив элементы перечисления.
        Array array = Enum.GetValues(typeof(EnumType));

        // Получаем информацию о количестве элементов в массиве.
        Console.WriteLine("Это перечисление содержит {0} членов \n", array.Length);

        // Вывод на экран всех элементов перечисления
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Имя константы: {0}, значение {0:D}", array.GetValue(i));
        }

        Console.ReadKey();
    }
}
