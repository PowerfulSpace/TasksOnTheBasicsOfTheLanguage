//Создайте коллекцию, в которую можно добавлять покупателей  и категорию приобретенной ими 
//продукции. Из коллекции можно получать категории товаров, которые купил покупатель или по 
//категории определить покупателей. 


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
