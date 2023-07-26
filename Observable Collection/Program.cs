
//1)	Создать свой класс наблюдаемой коллекции. Экземпляр коллекции
//должен реагировать на добавление и удаление элементов коллекции.
//Также экземпляр коллекции должен быть перечислимым, иметь индексатор,
//иметь возможность добавлять элементы (в том числе и с помощью блока инициализатора),
//вставлять элементы по индексу, получать индекс элемента,
//удалять элементы (в том числе и по индексу), копировать элементы в массив,
//а также иметь возможность проверить наличие в коллекции элемента и возможность
//очистить всю коллекцию. Экземпляр коллекции должен уметь
//сортировать свое внутреннее содержимое с возможность поддержки специальных интерфейсов
//для задания логики компаратора.



MyCollection<int> myClass = new MyCollection<int>();



class MyCollection<T>
{
    private List<T> list;
    event EventHandler myEvent;

    public MyCollection()
    {
        list = new List<T>();
    }
    public MyCollection(T item)
    {
        list = new List<T>();
        list.Add(item);
        TheListHasChanged();
    }
    public T this[int index]
    {
        get { return list[index]; }
        set
        {
            list[index] = value;
            TheListHasChanged();
        }
    }

    public void Add(T item)
    {
        list.Add(item);
        TheListHasChanged();
    }
    public void Remove(T item)
    {
        list.Remove(item);
        TheListHasChanged();
    }
    public void RemoveAt(int index)
    {
        list.RemoveAt(index);
        TheListHasChanged();
    }
    public int Insert(T item)
    {
        return list.IndexOf(item);
    }

    public T[] CopyTo()
    {
        T[] arr = new T[list.Count];
        arr.CopyTo(list.ToArray(),0);
        return arr;
    }
    public bool Contains(T item)
    {
        return list.Contains(item);
    }
    public void Clear()
    {
        list.Clear();
    }
    public void Sort()
    {
        list.Sort();
    }

    public void TheListHasChanged()
    {
        if (myEvent != null)
        {
            myEvent(this, new EventArgs());
        }
    }
}
