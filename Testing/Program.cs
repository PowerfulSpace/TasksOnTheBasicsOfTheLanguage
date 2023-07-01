












Stack stk1 = new Stack(10);
Stack stk2 = new Stack(10);
Stack stk3 = new Stack(10);
char ch;
int i;
// Помещаем ряд символов в стек stk1.
Console.WriteLine("Помещаем символы от А до Z в стек stk1.");

for (i = 0; !stk1.full(); i++)
    stk1.push((char)('A' + i));

if (stk1.full()) Console.WriteLine("Стек stk1 полон.");

// Отображаем содержимое стека stkl.
Console.Write("Содержимое стека stk1: ");
while (!stk1.empty())
{
    ch = stk1.pop();
    Console.Write(ch);
}
Console.WriteLine();

if (stk1.empty()) Console.WriteLine("Стек stk1 пуст.\n");

// Помещаем еще символы в стек stk1.
Console.WriteLine("Снова помещаем символы от А до Z в стек stk1.");
for (i = 0; !stk1.full(); i++)
    stk1.push((char)('A' + i));

/* Теперь извлекаем элементы из стека stk1 и помещаем их в стек stk2.
В результате элементы стека stk2 должны быть расположены в обратном порядке. */

Console.WriteLine("Теперь извлекаем элементы из стека stkl и\n" +
                   " помещаем их в стек stk2.");
while (!stk1.empty())
{
    ch = stk1.pop();
    stk2.push(ch);
}

Console.Write("Содержимое стека stk2: ");
while (!stk2.empty())
{
    ch = stk2.pop();
    Console.Write(ch);
}

Console.WriteLine("\n");

// Помещаем 5 символов в стек stk3.
Console.WriteLine("Помещаем 5 символов в стек stk3.");
for (i = 0; i < 5; i++)
    stk3.push((char)('A' + i));

Console.WriteLine("Объем стека stk3: " + stk3.capacity());
Console.WriteLine("Количество объектов в стеке stk3: " + stk3.getNum());

Console.ReadKey();









class Stack
{
    // Эти члены закрытые.
    char[] stck; // Массив для хранения данных стека.
    int tos; // Индекс вершины стека.
             // Создаем пустой класс Stack заданного размера,
    public Stack(int size)
    {
        stck = new char[size]; // Выделяем память для стека.
        tos = 0;
    }
    // Помещаем символы в стек.
    public void push(char ch)
    {
        if (tos == stck.Length)
        {
            Console.WriteLine(" - Стек заполнен.");
            return;
        }
        stck[tos] = ch;
        tos++;
    }
    // Извлекаем символ из стека,
    public char pop()
    {
        if (tos == 0)
        {
            Console.WriteLine(" - Стек пуст.");
            return (char)0;
        }
        tos--;
        return stck[tos];
    }
    // Метод возвращает значение true, если стек полон,
    public bool full()
    {
        return tos == stck.Length;
    }
    // Метод возвращает значение true, если стек пуст,
    public bool empty()
    {
        return tos == 0;
    }
    // Возвращает общий объем стека,
    public int capacity()
    {
        return stck.Length;
    }
    // Возвращает текущее количество объектов в стеке,
    public int getNum()
    {
        return tos;
    }
}


























