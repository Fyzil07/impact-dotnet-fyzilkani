namespace Week01.Day05;

public partial class Employee
{
    public int Age { get; set; }

    partial void OnEmployeeCreated()
    {
        Console.WriteLine($"Employee '{Name}' was created.");
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age : {Age}");
    }
}