


X ob1 = new X();
Y ob2 = new Y();
MyEvent evt = new MyEvent();

evt.SomeEvent += new MyEventHandler(ob1.handler);
evt.SomeEvent += new MyEventHandler(ob2.handler);

evt.OnSomeEvent();
evt.OnSomeEvent();

Console.ReadLine();





class MyEventArgs : EventArgs
{
    public int eventnum;
}

delegate void MyEventHandler(object source, MyEventArgs arg);



class MyEvent
{
    static int count = 0;
    public event MyEventHandler SomeEvent;

    public void OnSomeEvent()
    {
        MyEventArgs arg = new MyEventArgs();
        if (SomeEvent != null)
        {
            arg.eventnum = count++;
            SomeEvent(this, arg);
        }
    }
}

class X
{
    public void handler(object source, MyEventArgs arg)
    {
        Console.WriteLine("Событие " + arg.eventnum +
                                           " получено объектом X.");
        Console.WriteLine("Источником является класс " +
                                            source + ".");
        Console.WriteLine();
    }
}

class Y
{
    public void handler(object source, MyEventArgs arg)
    {
        Console.WriteLine("Событие " + arg.eventnum +
                                        " получено объектом Y.");
        Console.WriteLine("Источником является класс " +
                                            source + ".");
        Console.WriteLine();
    }
}
