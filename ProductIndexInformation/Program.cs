
//Требуется:  
//Создать класс Article, содержащий следующие закрытые поля: 
//• название товара; 
//• название магазина, в котором продается товар; 
//• стоимость товара.
//Создать класс Store, содержащий закрытый массив элементов типа Article.  
//Обеспечить следующие возможности: 
//• вывод информации о товаре по номеру или по названию с помощью индекса (перегрузить индекс – типы int и string);
//• вывод на экран информации о товаре, название которого введено с клавиатуры,
//  если таких товаров нет, выдать соответствующее сообщение;
//Написать программу, вывода на экран информации о товарах.  



Store store = new Store(3);

for (int i = 0; i < store.length * 2; i++)
{
    store[i] = new Article($"Хлеб-{i}", $"Алми-{i}", (i+1) * 2);
}
for (int i = 0; i < store.length * 2; i++)
{
    Article article = store[i];
    if (!store.Errflag)
        Console.WriteLine("Название продукта - {0,-10} Название магазина - {1,-10}  Цена - {2} ", article.ProductName, article.NameOfShop, article.CostOfGoods);
    else
        Console.WriteLine("Элемент вне границ");

}

Console.WriteLine("Введите индекс товара");
int index = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите название товара");
string name = Console.ReadLine();

Article article1 = store[index];
Article article2 = store[name];

Console.WriteLine($"Товар по индексу: {index}");
Console.WriteLine("Название продукта - {0,-10} Название магазина - {1,-10}  Цена - {2} ", article1.ProductName, article1.NameOfShop, article1.CostOfGoods);
Console.WriteLine($"Товар по Имени продукта: {name}");
Console.WriteLine("Название продукта - {0,-10} Название магазина - {1,-10}  Цена - {2} ", article2.ProductName, article2.NameOfShop, article2.CostOfGoods);

Console.ReadLine();

class Article
{
    public string ProductName { get; set; }
    public string NameOfShop { get; set; }
    public double CostOfGoods { get; set; }

    public Article()
    {

    }
    public Article(string productName, string nameOfShop, double costOfGoods)
    {
        ProductName = productName;
        NameOfShop = nameOfShop;
        CostOfGoods = costOfGoods;
    }


}

class Store
{
    Article[] articles;
    public readonly int length;
    public bool Errflag;
    public Store(int size)
    {
        articles = new Article[size];
        length = size;
    }


    public Article this [int index]
    {
        get
        {
            if (index >= 0 && index < length)
            {
                Errflag = false;
                return articles[index];
            }
            else
            {
                Errflag = true;
                return null;
            }
        }
        set
        {
            if (index >= 0 && index < length)
            {
                Errflag = false;
                articles[index] = value;
            }
            else
            {
                Errflag = true;
            }
            
        }
    }

    public Article this[string index]
    {
        get
        {
            bool flag = false;
            Article article = new Article();
            for (int i = 0; i < articles.Length; i++)
            {
                if ((articles[i].ProductName).ToLower() == index.ToLower())
                {
                    article = articles[i];
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                Errflag = false;
                return article;
            }
            else
            {
                Errflag = true;
                return null;
            }

        }
    }
}


















