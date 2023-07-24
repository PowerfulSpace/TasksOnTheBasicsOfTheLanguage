

using System.Collections.ObjectModel;
using System.Collections.Specialized;

ObservableCollection<string> data = new ObservableCollection<string>();
data.CollectionChanged += Data_CollectionChanged;
data.Add("One");
data.Add("Two");
data.Insert(1, "Three");
data.Remove("One");


Console.ReadKey();

static void Data_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
{
    Console.WriteLine("action: {0}", e.Action.ToString());
    if (e.OldItems != null)
    {
        Console.WriteLine("starting index for old item(s): {0}",
                          e.OldStartingIndex);  //	Начальный индекс для старых элементов
        Console.WriteLine("old item(s):"); // Старые элементы
        foreach (var item in e.OldItems)
        {
            Console.WriteLine(item);
        }
    }

    if (e.NewItems != null)
    {
        Console.WriteLine("starting index for new item(s): {0}",
                          e.NewStartingIndex);  //	Начальный индекс для новых элементов
        Console.WriteLine("new item(s): "); //	Новые элементы
        foreach (var item in e.NewItems)
        {
            Console.WriteLine(item);
        }
    }

    Console.WriteLine();
}