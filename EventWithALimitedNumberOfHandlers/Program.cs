
MyEvent evt = new MyEvent();
W wOb = new W();
X xOb = new X();
Y yOb = new Y();
Z zOb = new Z();

Console.WriteLine("Добавление обработчиков событий.");
evt.SomeEvent += new MyEventHandler(wOb.Whandler);
evt.SomeEvent += new MyEventHandler(xOb.Xhandler);
evt.SomeEvent += new MyEventHandler(yOb.Yhandler);

evt.SomeEvent += new MyEventHandler(zOb.Zhandler);
Console.WriteLine();

evt.OnSomeEvent();
Console.WriteLine();

Console.WriteLine("Удаляем обработчик xOb.Xhandler.");
evt.SomeEvent -= new MyEventHandler(xOb.Xhandler);
evt.OnSomeEvent();

Console.WriteLine();

Console.WriteLine(
"Попытка повторно удалить обработчик xOb.Xhandler.");
evt.SomeEvent -= new MyEventHandler(xOb.Xhandler);
evt.OnSomeEvent();

Console.WriteLine();

Console.WriteLine("Добавляем обработчик zOb.Zhandler.");
evt.SomeEvent += new MyEventHandler(zOb.Zhandler);
evt.OnSomeEvent();

Console.ReadLine();




delegate void MyEventHandler();



class MyEvent
{
    MyEventHandler[] evnt = new MyEventHandler[3];

    public event MyEventHandler SomeEvent
    {
        add
        {
            int i;

            for (i = 0; i < 3; i++)
                if (evnt[i] == null)
                {
                    evnt[i] = value;
                    break;
                }
            if (i == 3)
                Console.WriteLine("Список обработчиков событий полон.");
        }

        remove
        {
            int i;

            for (i = 0; i < 3; i++)
                if (evnt[i] == value)
                {
                    evnt[i] = null;
                    break;
                }
            if (i == 3)
                Console.WriteLine("Обработчик события не найден.");
        }
    }

    public void OnSomeEvent()
    {
        for (int i = 0; i < 3; i++)
            if (evnt[i] != null)
                evnt[i]();
    }
}

class W
{
    public void Whandler()
    {
        Console.WriteLine("Событие получено объектом W.");
    }
}

class X
{
    public void Xhandler()
    {
        Console.WriteLine("Событие получено объектом X.");
    }
}

class Y
{
    public void Yhandler()
    {
        Console.WriteLine("Событие получено объектом Y.");
    }
}

class Z
{
    public void Zhandler()
    {
        Console.WriteLine("Событие получено объектом Z.");
    }
}
