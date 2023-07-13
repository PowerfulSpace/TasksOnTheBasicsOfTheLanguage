
//Cоздайте метод, который в качестве аргумента принимает массив целых чисел и возвращает 
//коллекцию квадратов всех нечетных чисел массива. Для формирования коллекции 
//используйте оператор yield.  





int[] array = FillingArray(10);

Show(array);

var collectionOfOddNumbers = ReturnACollectionOfSquaredIntegers(array);
var collectionOfOddNumbers2 = ReturnACollectionOfSquaredIntegers2(array);

Show(collectionOfOddNumbers);
Show(collectionOfOddNumbers2);




Console.ReadLine();


static IEnumerable<int> ReturnACollectionOfSquaredIntegers(int[] array)
{
    List<int> result = new List<int>();

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            var elementInASquare = (int)Math.Pow(array[i], 2);
            result.Add(elementInASquare);
        }
    }

    return result;
}

static IEnumerable<int> ReturnACollectionOfSquaredIntegers2(int[] array)
{
    List<int> result = new List<int>();

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            var elementInASquare = (int)Math.Pow(array[i], 2);
            yield return elementInASquare;
        }
    }
}


static int[] FillingArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100);

    }
    return array;
}

static void Show(IEnumerable<int> array)
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}