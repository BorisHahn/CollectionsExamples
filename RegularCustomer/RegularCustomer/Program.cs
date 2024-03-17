using System.Collections.Specialized;

namespace RegularCustomer;

class Program
{
    static void Main()
    {
        var shop = new Shop();
        var customer = new Customer("Tom", "Hanks");
        shop.storage.CollectionChanged += customer.OnItemChanged;
        shop.SubscribeCustomer(customer);

        Console.WriteLine("Команды для взаимодействия c программой: \nA - добавить товар\nD - удалить товар\nX - выйти из программы");
        var command = "";

        while (command != "X")
        {
            command = Console.ReadLine();
            switch (command)
            {
                case "A":
                    shop.Add();
                    break;
                case "D":
                    Console.WriteLine("Какой товар хотите удалить?");
                    foreach (var item in shop.storage)
                    {
                        Console.WriteLine($"{item.Id} : {item.Name}");
                    }

                    Console.WriteLine("Введите идентификатор товара для удаления");
                    var removeId = Console.ReadLine();
                    if (removeId != null)
                    {
                        shop.Remove(removeId);
                    }

                    break;
                default:
                    Console.WriteLine("Команды для взаимодействия c программой: \nA - добавить товар\nD - удалить товар\nX - выйти из программы");
                    break;
            }
        }
    }
}