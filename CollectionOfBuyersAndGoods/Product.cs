//Создайте коллекцию, в которую можно добавлять покупателей  и категорию приобретенной ими 
//продукции. Из коллекции можно получать категории товаров, которые купил покупатель или по 
//категории определить покупателей. 


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
