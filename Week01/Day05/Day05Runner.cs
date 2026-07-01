namespace Week01.Day05;

public static class Day05Runner
{
    public static void Run()
    {
        Console.WriteLine("\n=== Task 1.17 ===");

        PartialClassDemo();

        AccessModifierDemoTask();

        RecordDemo();

        PlaylistIndexerDemo();

        StringIndexerDemo();
    }

    private static void PartialClassDemo()
    {
        Console.WriteLine("\n--- Partial Class & Partial Method ---");

        Console.Write("Enter employee name: ");
        string name = Console.ReadLine()!;

        Console.Write("Enter employee age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Employee employee = new(name)
        {
            Age = age
        };

        employee.Display();
    }

    private static void AccessModifierDemoTask()
    {
        Console.WriteLine("\n--- Access Modifiers ---");

        AccessModifierDemo demo = new();

        demo.DisplayMessages();
    }

    private static void RecordDemo()
    {
        Console.WriteLine("\n--- Records & with Expression ---");

        Address address1 =
            new("MG Road", "Kochi", "682001");

        Address address2 =
            new("MG Road", "Kochi", "682001");

        Console.WriteLine($"address1 == address2 : {address1 == address2}");

        // Required output:
        // True

        Address address3 =
            address1 with
            {
                City = "Calicut"
            };

        Console.WriteLine("\nOriginal Address:");
        Console.WriteLine(address1);

        Console.WriteLine("\nCopied Address:");
        Console.WriteLine(address3);

        // Required:
        // with creates a modified copy
    }

    private static void PlaylistIndexerDemo()
    {
        Console.WriteLine("\n--- Playlist Indexer ---");

        Playlist playlist = new();

        playlist.AddSong("Believer");
        playlist.AddSong("Perfect");
        playlist.AddSong("Shape of You");

        Console.Write("Enter playlist index: ");

        int index =
            Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(
            $"Song: {playlist[index]}");

        // Bounds checking implemented
    }

    private static void StringIndexerDemo()
    {
        Console.WriteLine("\n--- String Indexer ---");

        TextContainer container = new();

        container["Language"] = "C#";
        container["Framework"] = ".NET";

        Console.Write("Enter key (Language/Framework): ");

        string key =
            Console.ReadLine()!;

        Console.WriteLine(
            $"Value: {container[key]}");
    }
}