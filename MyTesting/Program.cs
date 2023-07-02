








class Counetr
{
    int value;
    public static Counetr operator +(Counetr a, Counetr b)
    {        
        return new Counetr() { value = a.value + b.value };
    }
    public static Counetr operator -(Counetr a, Counetr b)
    {
        return new Counetr() { value = a.value - b.value };
    }
}




