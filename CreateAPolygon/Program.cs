
//Создать классы Point и Figure. 
//Класс Point должен содержать два целочисленных поля и одно строковое поле,
//  а также пользовательский конструктор, в теле которого  проинициализируйте поля значениями аргументов.  
//
//Класс  Figure  должен содержать конструкторы, которые принимают от 3-х  до 5-ти аргументов типа Point.
//  Также должен содержать два  метода:  
//double LengthSide(Point A, Point B),  который рассчитывает длину стороны многоугольника;
//void PerimeterCalculator(),  который рассчитывает периметр многоугольника. 
//
//Написать программу, которая выводит на экран название и периметр многоугольника


Point pointA = new Point(2, 3);
Point pointB = new Point(6, 5);
Point pointC = new Point(8, 2);
Figure figure = new Figure(pointA, pointB, pointC);


figure.LengthSide(pointA, pointB);
figure.PerimeterCalculator();
figure.Show();

Console.ReadLine();

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public string AngleName { get; set; }

    public Point(int x, int y, string angleName = null)
    {
        X = x;
        Y = y;
        AngleName = angleName;
    }
}

class Figure
{
    Point A { get; set; }
    Point B { get; set; }
    Point C { get; set; }
    Point D { get; set; }
    Point I { get; set; }
    string name;
    double p;
    public Figure(Point a, Point b, Point c) { A = a; B = b; C = c; name = "Треугольник"; }
    public Figure(Point a, Point b, Point c, Point d) { A = a; B = b; C = c; D = d; name = "Четвероугольник"; }
    public Figure(Point a, Point b, Point c, Point d, Point i) { A = a; B = b; C = c; D = d; I = i; name = "Пятиугольник"; }

    public double LengthSide(Point A, Point B)
    {
        double x = Math.Pow(B.X - A.X, 2);
        double y = Math.Pow(B.Y - A.Y,2);
        double result = Math.Sqrt(x + y);
        return result;
    }

    public void PerimeterCalculator()
    {
        switch (name)
        {
            case "Четвероугольник":
                p = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, A);
                break;
            case "Пятиугольник":
                p = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, I) + LengthSide(I, A);
                break;
            default:
                p = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A);
                break;
        }
    }

    public void Show()
    {
        Console.WriteLine($"Фигура: {name}, периметр: {p}");
    }
}