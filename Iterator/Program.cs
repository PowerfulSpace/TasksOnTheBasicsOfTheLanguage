
Aggregate aggregate = new ConcreteAggregate(3);

aggregate[0] = "Element A";
aggregate[1] = "Element B";
aggregate[2] = "Element C";
aggregate[3] = "Element D";

Iterator iterator = aggregate.CreateIterator();


Console.WriteLine("Первый элемент коллекции:");

object element = iterator.First();
Console.WriteLine(element);

Console.WriteLine(new string('-', 25));

Console.WriteLine("Итерация по коллекции:");
while (!iterator.IsDone())
{
    element = iterator.Next();
    Console.WriteLine(element);

}

Console.ReadKey();







abstract class Aggregate
{
    public abstract Iterator CreateIterator();

    public abstract object this[int index] { get; set; }
}

abstract class Iterator
{
    public abstract object First();
    public abstract object Next();
    public abstract bool IsDone();
    public abstract object CurrentItem();
}

class ConcreteAggregate : Aggregate
{
    private object[] elements;
    private Iterator iterator;
    public int Count { get; private set; }

    public ConcreteAggregate(int size)
    {
        elements = new object[size];
    }

    public override Iterator CreateIterator()
    {
        iterator = new ConcreteIterator(this);
        return iterator;
    }

    public override object this[int index]
    {
        get { return elements[index]; }
        set
        {
            if (Count == elements.Length)
            {
                object[] temp = new object[elements.Length << 1];
                elements.CopyTo(temp, 0);
                elements = temp;
                elements[index] = value;
            }
            else
            {
                elements[index] = value;
            }

            Count++;
        }
    }
}

class ConcreteIterator : Iterator
{
    private readonly ConcreteAggregate aggregate;
    private int current = -1;//указатель на текущий елемент

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this.aggregate = aggregate;
    }

    public override object First()
    {
        return aggregate[0];
    }

    public override object Next()
    {
        object element = null;

        if (current < aggregate.Count - 1)
            element = aggregate[++current];

        return element;
    }

    public override object CurrentItem()
    {
        return aggregate[current];
    }

    public override bool IsDone()
    {
        return current >= aggregate.Count - 1;
    }
}

