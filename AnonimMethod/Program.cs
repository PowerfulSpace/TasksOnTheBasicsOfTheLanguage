
MyDelegate myDelegate;

myDelegate = delegate (int x) { return x * 2; }; // Лямбда-Метод 

myDelegate = (x) => { return x * 2; };          // Лямбда-Оператор.

myDelegate = x => x * 2;                        // Лямбда-Выражение.

double result = myDelegate(4);
Console.WriteLine(result);


Console.ReadKey();




public delegate int MyDelegate(int a);


//Лямбда метод, Лямбда-Оператор, Лямбда- выражения базируются на анонимных метода
