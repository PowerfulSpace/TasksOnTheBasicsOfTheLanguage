

//Создайте коллекцию, в которую можно добавлять покупателей  и категорию приобретенной ими 
//продукции. Из коллекции можно получать категории товаров, которые купил покупатель или по 
//категории определить покупателей. 


using System.Collections;


Product product1 = new Product{ Name = "Чайник" };
Product product2 = new Product{ Name = "Варенье" };
Product product3 = new Product{ Name = "Телевизор" }; ;
Product product4 = new Product{ Name = "Пульт" }; ;

Client client1 = new Client();
client1.Name = "Вася";
client1.Cart.AddProduct(product1);
client1.Cart.AddProduct(product2);
product1.clients.AddClinet(client1);
product2.clients.AddClinet(client1);

Client client2 = new Client();
client2.Name = "Петя";
client2.Cart.AddProduct(product1);
client2.Cart.AddProduct(product2);
client2.Cart.AddProduct(product3);
product1.clients.AddClinet(client2);
product2.clients.AddClinet(client2);
product3.clients.AddClinet(client2);

Client client3 = new Client();
client3.Name = "Митя";
client3.Cart.AddProduct(product1);
client3.Cart.AddProduct(product2);
client3.Cart.AddProduct(product3);
client3.Cart.AddProduct(product4);
product1.clients.AddClinet(client3);
product2.clients.AddClinet(client3);
product3.clients.AddClinet(client3);
product4.clients.AddClinet(client3);


ClientCollections clients = new ClientCollections();
clients.AddClinet(client1);
clients.AddClinet(client2);
clients.AddClinet(client3);

Console.WriteLine("\n\n\n" + new string('-', 30) + "Покупатели" + new string('-', 30));
ShowClient(clients);

ProductCollections products = new ProductCollections();
products.AddProduct(product1);
products.AddProduct(product2);
products.AddProduct(product3);
products.AddProduct(product4);

Console.WriteLine("\n\n\n" +new string('-', 30) + "Товары" + new string('-', 30));
ShowProduct(products);

Console.ReadLine();


static void ShowClient(IEnumerable clients)
{
    foreach (Client item in clients)
    {
        Console.WriteLine(new string(' ',10) + " " + item.Name);
        foreach (Product product in item.Cart)
        {
            Console.WriteLine(product.Name);
        }
        Console.WriteLine(new string('-',20));
    }
}

static void ShowProduct(IEnumerable products)
{
    foreach (Product product in products)
    {
        Console.WriteLine(new string(' ', 10) + " " + product.Name);
        foreach (Client client in product.clients)
        {
            Console.WriteLine(client.Name);
        }
        Console.WriteLine(new string('-', 20));
    }
}

struct Client
{
    public string Name { get; set; }
    public ProductCollections Cart { get; set; }

    public Client()
    {
        Name = String.Empty;
        Cart = new ProductCollections();
    }
}

struct Product
{
    public string Name { get; set; }
    public ClientCollections clients { get; set; }
    public Product()
    {
        Name = String.Empty;
        clients = new ClientCollections();
    }
}

class ClientCollections : IEnumerable<Client>
{
    List<Client> clients;

    public ClientCollections()
    {
        clients = new List<Client>();
    }

    public void AddClinet(Client client)
    {
        clients.Add(client);
    }
    public ProductCollections GetProducts(Client client)
    {
        return client.Cart;
    }

    public IEnumerator<Client> GetEnumerator()
    {
        foreach (var client in clients)
        {
            yield return client;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        foreach (var client in clients)
        {
            yield return client;
        }
    }
}

class ProductCollections : IEnumerable<Product>
{
    List<Product> products;

    public ProductCollections()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public IEnumerator<Product> GetEnumerator()
    {
        foreach (var product in products)
        {
            yield return product;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        foreach (var product in products)
        {
            yield return product;
        }
    }
}