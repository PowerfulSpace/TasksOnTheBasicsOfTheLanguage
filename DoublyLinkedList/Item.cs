class Item<T>
{
    public T Value { get; set; }
    public Item<T> Next { get; set; }
    public Item<T> Prev { get; set; }

    public Item(T data)
    {
        Value = data;
        Next = null!;
        Prev = null!;
    }

    public override string ToString()
    {
        return Value!.ToString()!;
    }
}
