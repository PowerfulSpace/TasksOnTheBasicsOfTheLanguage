using System.Collections;

class MyLinkedList<T> : IEnumerable<T>
{
    public Item<T> First { get; set; }
    public Item<T> Last { get; set; }
    private int count;
    public int Count => count;

    public MyLinkedList()
    {
        First = null!;
        Last = null!;
        count = 0;
    }

    public void AddLast(T data)
    {
        if (count == 0)
        {
            QuantityIsZero(data);
        }
        else
        {
            var item = new Item<T>(data);
            Last.Next = item;
            item.Prev = Last;
            Last = item;

            count++;
        }
    }

    public void AddAfter(T after,T data)
    {
        var item = new Item<T>(data);
        var current = First;

        while (current != null)
        {
            if (current.Value!.Equals(after))
            {
                if (current.Next == null)
                {
                    Last = item;
                    item.Prev = current;
                    item.Next = current.Next!;
                    current.Next = item;
                }
                else
                {
                    current.Next.Prev = item;
                    item.Prev = current;
                    item.Next = current.Next;
                    current.Next = item;
                }

                count++;
                return;
            }

            current = current.Next;
        }
    }

    public IEnumerator GetEnumerator()
    {
        var current = First;

        while (current != null)
        {
            yield return current.Value;

            current = current.Next;
        }
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        return (IEnumerator<T>)GetEnumerator();
    }

    private void QuantityIsZero(T data)
    {
        var item = new Item<T>(data);
        First = item;
        Last = item;
        count = 1;
    }

    public override string ToString()
    {
        return $"Список содержит {count} Элементов";
    }
}
