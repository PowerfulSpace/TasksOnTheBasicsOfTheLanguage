


IHomeCat vaska = new YardCat();
vaska.Name = "Васька";
CatInfoPrinter.PrintCatInfo(vaska);

IHomeCat pushok = new PedigreeCat();
pushok.Name = "Пушок";
CatInfoPrinter.PrintCatInfo(pushok);

IWildCat tiger = new Tiger();
//CatInfoPrinter.PrintCatInfo(tiger);// ошибка


IHomeCat testTiget = new Adapter(tiger);
CatInfoPrinter.PrintCatInfo(testTiget);

Console.ReadLine();


class Adapter : IHomeCat
{
    public IWildCat WildCat { get; set; }
    public string Name { get; set; }


    public Adapter(IWildCat wildCat)
    {
        WildCat = wildCat;
        Name = WildCat.Breed;
    }

    public void Meow()
    {
        WildCat.Growl();
    }
    public void Scratch()
    {
        WildCat.Scratch();
    }

}




interface IWildCat
{
    string Breed { get; } // порода дикой кошки
    void Growl();  // рычание
    void Scratch();
}

class Tiger : IWildCat
{
    public string Breed { get { return "Тигр обыкновенный"; } }

    public void Growl()
    {
        Console.WriteLine("Grrrrrrr");
    }

    public void Scratch()
    {
        Console.WriteLine("У меня очень острые когти, царапаюсь до смерти");
    }
}









interface IHomeCat
{
    string Name { get; set; }
    void Meow();
    void Scratch();// царапаться
}


class PedigreeCat : IHomeCat
{
    public string Name { get; set; }

    public void Meow()
    {
        Console.WriteLine("Урррррр уррррр");
    }

    public void Scratch()
    {
        Console.WriteLine("Я не царапаюсь");
    }
}

class YardCat : IHomeCat
{
    public string Name { get; set; }

    public void Meow()
    {
        Console.WriteLine("Мяу мяу!");
    }

    public void Scratch()
    {
        Console.WriteLine("Я царапаюсь, но не сильно");
    }
}

class CatInfoPrinter
{
    public static void PrintCatInfo(IHomeCat cat)
    {
        Console.WriteLine("Кошачье досье:");
        Console.WriteLine(string.Format("Имя кота: {0}", cat.Name));
        Console.Write("Вид мяуканья: ");
        cat.Meow();
        Console.Write("Вид царапанья: ");
        cat.Scratch();

        Console.WriteLine();
    }
}
