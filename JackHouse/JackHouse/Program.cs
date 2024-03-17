namespace JackHouse;

class Program
{
    static void Main()
    {
        var myPart1 = new Part1(new List<string>() { "Вот дом,", "Который построил Джек.\n" });
        var myPart2 = new Part2(new List<string>()
            { "А это пшеница,", "Которая в темном чулане хранится", "В доме,", "Который построил Джек.\n" });
        var myPart3 = new Part3(new List<string>()
        {
            "А это веселая птица-синица,", "Которая часто ворует пшеницу,", "Которая в темном чулане хранится",
            "В доме,", "Который построил Джек.\n"
        });
        var myPart4 = new Part4(new List<string>()
        {
            "Вот кот,", "Который пугает и ловит синицу,", "Которая часто ворует пшеницу,",
            "Которая в темном чулане хранится", "В доме,", "Который построил Джек.\n"
        });
        var myPart5 = new Part5(new List<string>()
        {
            "Вот пес без хвоста", "Который за шиворот треплет кота,", "Который пугает и ловит синицу,",
            "Которая часто ворует пшеницу,", "Которая в темном чулане хранится", "В доме,", "Который построил Джек.\n"
        });
        var myPart6 = new Part6(new List<string>()
        {
            "А это корова безрогая,", "Лягнувшая старого пса без хвоста,", "Который за шиворот треплет кота,",
            "Который пугает и ловит синицу,", "Которая часто ворует пшеницу,", "Которая в темном чулане хранится",
            "В доме,", "Который построил Джек.\n"
        });
        var myPart7 = new Part7(new List<string>()
        {
            "А это старушка, седая и строгая,", "Которая доит корову безрогую,", "Лягнувшую старого пса без хвоста,",
            "Который за шиворот треплет кота,", "Который пугает и ловит синицу,", "Которая часто ворует пшеницу,",
            "Которая в темном чулане хранится", "В доме,", "Который построил Джек.\n"
        });
        var myPart8 = new Part8(new List<string>()
        {
            "А это ленивый и толстый пастух,", "Который бранится с коровницей строгою,",
            "Которая доит корову безрогую,",
            "Лягнувшую старого пса без хвоста,", "Который за шиворот треплет кота,", "Который пугает и ловит синицу,",
            "Которая часто ворует пшеницу,", "Которая в темном чулане хранится", "В доме,", "Который построил Джек.\n"
        });
        var myPart9 = new Part9(new List<string>()
        {
            "Вот два петуха,", "Которые будят того пастуха,",
            "Который бранится с коровницей строгою,",
            "Которая доит корову безрогую,", "Лягнувшую старого пса без хвоста,", "Который за шиворот треплет кота,",
            "Который пугает и ловит синицу,", "Которая часто ворует пшеницу,", "Которая в темном чулане хранится",
            "В доме,", "Который построил Джек.\n"
        });
        myPart2.AddPart(myPart1.Poem);
        myPart3.AddPart(myPart2.Poem);
        myPart4.AddPart(myPart3.Poem);
        myPart5.AddPart(myPart4.Poem);
        myPart6.AddPart(myPart5.Poem);
        myPart7.AddPart(myPart6.Poem);
        myPart8.AddPart(myPart7.Poem);
        myPart9.AddPart(myPart8.Poem);

        Console.WriteLine("Полный стих в итоговой Poem Part9");
        Console.WriteLine("---------------------------------------");
        foreach (var s in myPart9.Poem)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Poem Part1 \n");
        foreach (var s in myPart1.Poem)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("---------------------------------------");
        
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Poem Part2 \n");
        foreach (var s in myPart2.Poem)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("---------------------------------------");
        
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Poem Part3 \n");
        foreach (var s in myPart3.Poem)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("---------------------------------------");
        
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Poem Part4 \n");
        foreach (var s in myPart4.Poem)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("---------------------------------------");
        
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Poem Part5 \n");
        foreach (var s in myPart5.Poem)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("---------------------------------------");
        
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Poem Part6 \n");
        foreach (var s in myPart6.Poem)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("---------------------------------------");
        
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Poem Part7 \n");
        foreach (var s in myPart7.Poem)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("---------------------------------------");
        
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Poem Part8 \n");
        foreach (var s in myPart8.Poem)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("---------------------------------------");
        
    }
}