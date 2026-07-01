using Week01.Day02;
using Week01.Day03;
using Week01.Day04;
using Week01.Day05;
using Week01.MiniProjects.ProductCatalog;
using Week01.MiniProjects.TemperatureConverter;
using Week01.MiniProjects.ContactCard;

Console.WriteLine("1. Run Day 2");
Console.WriteLine("2. Run Day 3");
Console.WriteLine("3. Run Day 4");
Console.WriteLine("4. Run Day 5");
Console.WriteLine("5. Mini Q1 - Product Catalog");
Console.WriteLine("6. Mini Q2 - Temperature Converter");
Console.WriteLine("7. Mini Q3 - Contact Card");

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
        Day04Runner.Run();
        break;

    case "4":
        Day05Runner.Run();
        break;

    case "5":
        ProductCatalogRunner.Run();
        break;

    case "6":
        TemperatureConverterRunner.Run();
        break;

    case "7":
        ContactCardRunner.Run();
        break;

    default:
        Console.WriteLine("Invalid choice.");
        break;
}