

//Создайте коллекцию, в которую можно добавлять покупателей  и категорию приобретенной ими 
//продукции. Из коллекции можно получать категории товаров, которые купил покупатель или по 
//категории определить покупателей. 


using System.Collections;

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