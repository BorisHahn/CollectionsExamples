using System.Collections.Concurrent;

namespace Librarian;

public class Library
{
    public ConcurrentDictionary<string, int> storage = new();

    public void AddBook()
    {
        Console.WriteLine("Введите название книги:");
        var success = false;
        var bookName = "";
        while (success == false)
        {
            bookName = Console.ReadLine();
            success = !string.IsNullOrWhiteSpace(bookName);
            if (success)
            {
                var isAlreadyAdded = storage.TryAdd(bookName, 0);
                if (isAlreadyAdded == false)
                {
                    Console.WriteLine("Книга с таким названием уже была добавлена ранее\n");
                    new Menu().PrintMenu();
                }
                else
                {
                    Console.WriteLine("Книга успешно добавлена!\n");
                    new Menu().PrintMenu();
                }
            }
            else
            {
                Console.WriteLine("Название не может быть пустым. Повторите ввод.");
            }
        }
    }

    private void RemoveBook(KeyValuePair<string, int> keyValuePair)
    {
        storage.TryRemove(keyValuePair);
    }

    public void updStatusBook()
    {
        foreach (var keyValuePair in storage)
        {
            if (keyValuePair.Value == 100)
            {
                RemoveBook(keyValuePair);
            }
            else
            {
                var oldValue = keyValuePair.Value;
                var newValue = oldValue + 1;
                storage.TryUpdate(keyValuePair.Key, newValue, oldValue);
            }
        }
    }

    public void ShowUnreaded()
    {
        Console.WriteLine("---------------------------------------------");
        if (storage.Count > 0)
        {
            foreach (var keyValuePair in storage)
            {
                Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}%");
            }
        }
        else
        {
            Console.WriteLine("В коллекции пока нет книг");
        }

        Console.WriteLine("---------------------------------------------");
        new Menu().PrintMenu();
    }
}