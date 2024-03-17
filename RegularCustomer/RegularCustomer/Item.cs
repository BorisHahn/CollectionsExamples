namespace RegularCustomer;

public class Item
{
    public string Id { get; set; }
    public string Name { get; set; }

    public Item(string id, string name)
    {
        Id = id;
        Name = name;
    }
}