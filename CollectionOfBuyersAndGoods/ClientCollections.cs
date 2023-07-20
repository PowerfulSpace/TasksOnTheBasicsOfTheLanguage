

//Создайте коллекцию, в которую можно добавлять покупателей  и категорию приобретенной ими 
//продукции. Из коллекции можно получать категории товаров, которые купил покупатель или по 
//категории определить покупателей. 


using System.Collections;

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
