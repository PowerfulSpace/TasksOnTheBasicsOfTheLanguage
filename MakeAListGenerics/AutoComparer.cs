
//Список должен быть обобщённый



using System.Collections;

class AutoComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        if (x is null || y is null)
        {
            throw new ArgumentException("Некоректное значение параметров");
        }

        return ((Auto)x).Cost.CompareTo(((Auto)y).Cost);
    }
}
