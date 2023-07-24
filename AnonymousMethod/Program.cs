
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте анонимный метод, который принимает в качестве аргумента массив
//делегатов и возвращает среднее арифметическое возвращаемых  значений методов
//сообщенных с делегатами в массиве. Методы, сообщенные с делегатами из массива,
//возвращают случайное значение типа int.



partial class Program
{
    static Random random = new Random();

    static void Main(string[] args)
	{

        Func<int>[] a = new Func<int>[5];
        a[0] = Method;
        a[1] = Method;
        a[2] = Method;
        a[3] = Method;
        a[4] = Method;

        var array = (Func<int>[] x) =>
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i]();
            }
            return sum / x.Length;
        };

        Console.WriteLine(array.Invoke(a));

        Console.ReadLine();
    }


    static int Method()
    {
        return random.Next(1, 10);
    }
}

