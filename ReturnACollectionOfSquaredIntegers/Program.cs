
//Cоздайте метод, который в качестве аргумента принимает массив целых чисел и возвращает 
//коллекцию квадратов всех нечетных чисел массива. Для формирования коллекции 
//используйте оператор yield.  





double[] array = FillingArray(10);

Show(array);

var collectionOfOddNumbers = ReturnACollectionOfSquaredIntegers(array);
var collectionOfOddNumbers2 = ReturnACollectionOfSquaredIntegers2(array);

Show(collectionOfOddNumbers);
Show(collectionOfOddNumbers2);




Console.ReadLine();


static IEnumerable<double> ReturnACollectionOfSquaredIntegers(double[] array)
{
    List<double> result = new List<double>();

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            var elementInASquare = Math.Pow(array[i], 2);
            result.Add(elementInASquare);
        }
    }

    return result;
}

static IEnumerable<double> ReturnACollectionOfSquaredIntegers2(double[] array)
{
    List<double> result = new List<double>();

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            var elementInASquare = Math.Pow(array[i], 2);
            yield return elementInASquare;
        }
    }
}


static double[] FillingArray(int size)
{
    double[] array = new double[size];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100);

    }
    return array;
}

static void Show(IEnumerable<double> array)
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}