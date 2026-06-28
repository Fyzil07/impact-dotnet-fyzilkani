using Week01.Day02;
using Week01.Day03;

Console.WriteLine("=== Week 1: C# Language & Object Foundations ===");
Console.WriteLine();

Console.WriteLine("1. Day 2 - Namespaces, Identifiers, Preprocessor");
Console.WriteLine("2. Day 3 - Memory Model, Enums, Nullable, Conversion");
Console.WriteLine("3. Day 4 - Modern Syntax + Class Anatomy");
Console.WriteLine("4. Day 5 - Records, Indexers, Mini Projects");

Console.Write("\nEnter your choice: ");

string? choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Day02Runner.Run();
        break;

    case "2":
        Day03Runner.Run();
        break;

    case "3":
        Console.WriteLine("Day 4 not implemented yet.");
        break;

    case "4":
        Console.WriteLine("Day 5 not implemented yet.");
        break;

    default:
        Console.WriteLine("Invalid choice.");
        break;
}