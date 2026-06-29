namespace Week01.Day04;

public static class Day04Runner
{
    public static void Run()
    {
        Console.WriteLine("\n=== Task 1.13 ===");
        Task113();

        Console.WriteLine("\n=== Task 1.14 ===");
        Task114();

        Console.WriteLine("\n=== Task 1.15 ===");
        Task115();

        Console.WriteLine("\n=== Task 1.16 ===");
        Task116();
    }

    private static void Task113()
    {
        var name = "Alice";

        // name = 100;
        // Compile error:
        // Cannot implicitly convert int to string.

        dynamic value = "Hello";

        Console.WriteLine($"{value} : {value.GetType()}");

        value = 100;

        Console.WriteLine($"{value} : {value.GetType()}");

        value = true;

        Console.WriteLine($"{value} : {value.GetType()}");

        Console.WriteLine(Add(10, 20));

        Console.WriteLine(Add("Hello ", "World"));
    }

    private static dynamic Add(dynamic a, dynamic b)
    {
        return a + b;
    }

    private static void Task114()
    {
        int[] numbers = { 5, 1, 9, 3, 7 };

        var (min, max) = GetMinMax(numbers);

        Console.WriteLine($"Min: {min}");
        Console.WriteLine($"Max: {max}");

        var (name, age, department) =
            GetEmployee();

        Console.WriteLine(
            $"{name} - {age} - {department}");
    }

    private static (int Min, int Max)
        GetMinMax(int[] numbers)
    {
        return (numbers.Min(), numbers.Max());
    }

    private static
        (string Name, int Age, string Department)
        GetEmployee()
    {
        return ("John", 30, "IT");
    }

    private static void Task115()
    {
        Console.Write("Enter a value: ");

        string? input = Console.ReadLine();

        HandleValue(input);

        Console.Write("Enter marks: ");

        int marks =
            Convert.ToInt32(Console.ReadLine());

        string grade = marks switch
        {
            >= 90 => "A",
            >= 75 => "B",
            >= 50 => "C",
            _ => "Fail"
        };

        Console.WriteLine($"Grade: {grade}");

        Order order = new()
        {
            Status = "Active",
            Amount = 1500
        };

        decimal discount = order switch
        {
            { Status: "Active", Amount: > 1000 } => 20,
            { Status: "Active" } => 10,
            _ => 0
        };

        Console.WriteLine($"Discount: {discount}%");
    }

    private static void HandleValue(object? value)
    {
        switch (value)
        {
            case int number:
                Console.WriteLine($"Integer: {number}");
                break;

            case string text:
                Console.WriteLine($"String: {text}");
                break;

            case double decimalNumber:
                Console.WriteLine($"Double: {decimalNumber}");
                break;

            case null:
                Console.WriteLine("Null value");
                break;

            default:
                Console.WriteLine("Unknown type");
                break;
        }
    }

    private static void Task116()
    {
        try
        {
            Student student =
                new("Alice", 20);

            Console.WriteLine(
                $"{student.Name} - {student.Age}");

            Console.WriteLine(
                student.CalculateGrade(45));

            Console.WriteLine(
                student.CalculateGrade(45, 10));

            Console.WriteLine(
                $"Min Age: {Student.MinAge}");

            Console.WriteLine(
                $"Created: {student.CreatedDate}");

            // Student.MinAge = 10;
            // Compile error (const)

            // student.CreatedDate = DateTime.Now;
            // Compile error (readonly)
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}