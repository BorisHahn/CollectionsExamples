using System.Collections;
using System.Collections.Specialized;

namespace RegularCustomer;

public interface ICustomerObserver
{
    void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e);
}

public class Customer : ICustomerObserver
{
    public string Name { get; set; }
    public string SecondName { get; set; }

    public Customer(string name, string secondName)
    {
        Name = name;
        SecondName = secondName;
    }

    public void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        Console.WriteLine("Рассылка для подписчиков магазина:");
        Console.WriteLine($"Уважаемый, {Name} {SecondName}");

        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                var addItem = (Item)e.NewItems[0];
                Console.WriteLine(
                    $"В ассортимент магазина добавлен товар - Наименование: {addItem!.Name}, Id: {addItem.Id}");
                break;
            case NotifyCollectionChangedAction.Remove:
                var removedItem = (Item)e.OldItems[0];
                Console.WriteLine(
                    $"Из ассортимента магазина был удален товар - Наименование: {removedItem!.Name}, Id: {removedItem.Id}");
                break;
        }
    }
}