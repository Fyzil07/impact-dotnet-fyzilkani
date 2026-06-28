namespace Week01.Day03;

public static class Day03Runner
{
    public static void Run()
    {
        Console.WriteLine("\n=== Task 1.9: Value Types vs Reference Types ===");
        Task19();

        Console.WriteLine("\n=== Task 1.10: Enums and Flags ===");
        Task110();

        Console.WriteLine("\n=== Task 1.11: Nullable Types ===");
        Task111();

        Console.WriteLine("\n=== Task 1.12: Type Conversion ===");
        Task112();
    }

    private static void Task19()
    {
        Console.WriteLine("\n--- int (Value Type) ---");

        int firstNumber = 10;
        int secondNumber = firstNumber;

        secondNumber = 20;

        Console.WriteLine($"firstNumber = {firstNumber}");
        Console.WriteLine($"secondNumber = {secondNumber}");

        // Explanation:
        // int is a value type. Assigning firstNumber to secondNumber
        // creates a copy, so changing secondNumber does not affect firstNumber.


        Console.WriteLine("\n--- int[] (Reference Type) ---");

        int[] firstArray = { 1, 2, 3 };
        int[] secondArray = firstArray;

        secondArray[0] = 100;

        Console.WriteLine($"firstArray[0] = {firstArray[0]}");
        Console.WriteLine($"secondArray[0] = {secondArray[0]}");

        // Explanation:
        // Arrays are reference types. Both variables point to the same object,
        // so modifying secondArray also changes firstArray.


        Console.WriteLine("\n--- Struct (Value Type) ---");

        CoordinateStruct firstPoint = new()
        {
            X = 10,
            Y = 20
        };

        CoordinateStruct secondPoint = firstPoint;

        secondPoint.X = 999;

        Console.WriteLine($"firstPoint.X = {firstPoint.X}");
        Console.WriteLine($"secondPoint.X = {secondPoint.X}");

        // Explanation:
        // Structs are value types. Assigning firstPoint to secondPoint
        // creates a separate copy, so changing secondPoint does not affect firstPoint.


        Console.WriteLine("\n--- Class (Reference Type) ---");

        CoordinateClass firstLocation = new()
        {
            X = 10,
            Y = 20
        };

        CoordinateClass secondLocation = firstLocation;

        secondLocation.X = 999;

        Console.WriteLine($"firstLocation.X = {firstLocation.X}");
        Console.WriteLine($"secondLocation.X = {secondLocation.X}");

        // Explanation:
        // Classes are reference types. Both variables refer to the same object,
        // so changing secondLocation also changes firstLocation.
    }

    private static void Task110()
    {
        Console.Write("Enter a number (0-6): ");

        bool isValid =
            int.TryParse(Console.ReadLine(), out int dayNumber);

        if (isValid && dayNumber >= 0 && dayNumber <= 6)
        {
            DaysOfWeek day = (DaysOfWeek)dayNumber;

            Console.WriteLine($"Day {dayNumber} is {day}");
        }
        else
        {
            Console.WriteLine("Invalid day number.");
        }


        Console.WriteLine("\n--- File Permissions ---");

        FilePermission permissions =
            FilePermission.Read | FilePermission.Write;

        Console.WriteLine($"Combined Permissions: {permissions}");

        bool hasWritePermission =
            (permissions & FilePermission.Write)
            == FilePermission.Write;

        Console.WriteLine($"Has Write Permission: {hasWritePermission}");
    }

    private static void Task111()
    {
        Console.Write("Enter age (leave blank for null): ");

        string? ageInput = Console.ReadLine();

        int? age =
            string.IsNullOrWhiteSpace(ageInput)
                ? null
                : Convert.ToInt32(ageInput);

        if (age.HasValue)
        {
            Console.WriteLine($"Age: {age.Value}");
        }
        else
        {
            Console.WriteLine("Age is null.");
        }


        Console.Write("\nEnter discount percentage (leave blank for default 5%): ");

        string? discountInput = Console.ReadLine();

        double? discount =
            string.IsNullOrWhiteSpace(discountInput)
                ? null
                : Convert.ToDouble(discountInput);

        ApplyDiscount(discount);
    }

    private static void ApplyDiscount(double? discount)
    {
        double finalDiscount = discount ?? 5;

        Console.WriteLine($"Discount Applied: {finalDiscount}%");
    }

    private static void Task112()
    {
        Console.WriteLine("\n--- Implicit Conversions ---");

        int number = 100;

        long longNumber = number;
        float floatNumber = longNumber;
        double doubleNumber = floatNumber;

        Console.WriteLine($"int -> long -> float -> double = {doubleNumber}");


        Console.WriteLine("\n--- Explicit Conversion ---");

        Console.Write("Enter a decimal number: ");

        double decimalNumber =
            Convert.ToDouble(Console.ReadLine());

        int wholeNumber = (int)decimalNumber;

        Console.WriteLine($"Original Value: {decimalNumber}");
        Console.WriteLine($"Converted Value: {wholeNumber}");

        // Explanation:
        // Converting double to int removes the decimal part,
        // causing precision loss.


        Console.WriteLine("\n--- String Conversion Methods ---");

        Console.Write("Enter a value: ");

        object userInput = Console.ReadLine()!;


        // is operator

        if (userInput is string text)
        {
            Console.WriteLine($"Using 'is': {text}");
        }

        // Use 'is' when checking the type and safely using it.


        // as operator

        string? asResult = userInput as string;

        Console.WriteLine($"Using 'as': {asResult}");

        // Use 'as' when converting reference types
        // without throwing exceptions.


        // Convert.ToInt32

        try
        {
            int convertedValue =
                Convert.ToInt32(userInput);

            Console.WriteLine($"Using Convert.ToInt32: {convertedValue}");
        }
        catch
        {
            Console.WriteLine("Convert.ToInt32 failed.");

            // Use Convert.ToInt32 when you expect
            // a valid numeric value.
        }


        // TryParse

        bool success =
            int.TryParse(
                userInput.ToString(),
                out int parsedNumber);

        if (success)
        {
            Console.WriteLine($"Using TryParse: {parsedNumber}");
        }
        else
        {
            Console.WriteLine("TryParse failed.");

            // Use TryParse for user input because
            // it avoids exceptions.
        }
    }
}