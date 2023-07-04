


FailSoftArray fs = new FailSoftArray(5);
int x;

Console.WriteLine("Мягкое приземление.");
for (int i = 0; i < (fs.Length * 2); i++)
    fs[i] = i * 10;

for (int i = 0; i < (fs.Length * 2); i++)
{
    x = fs[i];

    Console.Write(x + " ");
}
Console.WriteLine();
Console.WriteLine("\nРабота с уведомлением об ошибках.");
for (int i = 0; i < (fs.Length * 2); i++)
{
    fs[i] = i * 10;
    if (fs.errflag)
        Console.WriteLine("fs[" + i + "] вне границ");
}

for (int i = 0; i < (fs.Length * 2); i++)
{
    x = fs[i];
    if (!fs.errflag)
        Console.Write(x + " ");
    else
        Console.Write("\n fs[" + i + "] вне границ");
}

Console.ReadKey();



class FailSoftArray
{
    int[] a;
    public int Length;
    public bool errflag;


    public FailSoftArray(int size)
    {
        a = new int[size];
        Length = size;
    }


    public int this[int index]
    {

        get
        {
            if (ok(index))
            {
                errflag = false;
                return a[index];
            }
            else
            {
                errflag = true;
                return 0;
            }
        }

        set
        {
            if (ok(index))
            {
                a[index] = value;
                errflag = false;
            }
            else
                errflag = true;
        }
    }


    private bool ok(int index)
    {
        if (index >= 0 & index < Length)
            return true;
        return false;
    }

}
