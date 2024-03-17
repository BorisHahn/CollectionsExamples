namespace Librarian;

class Program
{
    static void Main()
    {
        var menu = new Menu();
        var library = new Library();
        var command = "";
        menu.PrintMenu();
        while (command != "3")
        {
            var myThread = new Thread(CheckLibraryStorage);
            myThread.Start();
            command = Console.ReadLine();
            switch (command)
            {
                case "1":
                    library.AddBook();
                    break;
                case "2":
                    library.ShowUnreaded();
                    break;
                case "3":
                    Console.WriteLine("Пока!");
                    break;
                default:
                    Console.WriteLine("Не знаю такой команды. Вот доступные команды:\n");
                    menu.PrintMenu();
                    break;
            }
        }

        void CheckLibraryStorage()
        {
            while (library.storage.IsEmpty == false)
            {
                library.updStatusBook();
                Thread.Sleep(1000);
            }
        }
    }
}