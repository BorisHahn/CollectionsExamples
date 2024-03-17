using System.Collections.ObjectModel;

namespace RegularCustomer;

public class Shop
{
    public ObservableCollection<Item> storage = new();
    private readonly List<ICustomerObserver> _customersList = new();

    public Shop(params Item[] products)
    {
        foreach (var product in products)
        {
            storage.Add(product);
        }
    }

    public void SubscribeCustomer(Customer subscriber)
    {
        if (!_customersList.Contains(subscriber))
        {
            _customersList.Add(subscriber);
        }
    }

    public void Add()
    {
        var newProduct = new Item(Guid.NewGuid().ToString("N"), $"Товар от {DateTime.Now}");
        storage.Add(newProduct);
    }

    public void Remove(string productId)
    {
        var removedProduct = storage.Where(pr => pr.Id == productId).ToList();
        if (removedProduct != null)
        {
            storage.Remove(removedProduct[0]);
        }
        else
        {
            Console.WriteLine($"С указанным id: {productId} товара не существует");
        }
    }
}