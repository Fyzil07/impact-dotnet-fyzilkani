namespace Week01.MiniProjects.TemperatureConverter;

public static class TemperatureConverterRunner
{
    public static void Run()
    {
        Console.Write("Enter temperature value: ");

        bool isValid =
            double.TryParse(
                Console.ReadLine(),
                out double value);

        if (!isValid)
        {
            Console.WriteLine("Invalid temperature value.");

            return;
        }

        Console.Write("Enter unit (C/F/K): ");

        string unit =
            Console.ReadLine()!
                .Trim()
                .ToUpper();

        switch (unit)
        {
            case "C":

                Convert(value, new Celsius());

                break;

            case "F":

                Convert(value, new Fahrenheit());

                break;

            case "K":

                Convert(value, new Kelvin());

                break;

            default:

                Console.WriteLine("Invalid unit.");

                break;
        }
    }

    // Method Overload 1

    private static void Convert(
        double value,
        Celsius unit)
    {
        double fahrenheit =
            (value * 9 / 5) + 32;

        double kelvin =
            value + 273.15;

        Console.WriteLine($"\nCelsius: {value:F2}°C");
        Console.WriteLine($"Fahrenheit: {fahrenheit:F2}°F");
        Console.WriteLine($"Kelvin: {kelvin:F2}K");
    }

    // Method Overload 2

    private static void Convert(
        double value,
        Fahrenheit unit)
    {
        double celsius =
            (value - 32) * 5 / 9;

        double kelvin =
            celsius + 273.15;

        Console.WriteLine($"\nFahrenheit: {value:F2}°F");
        Console.WriteLine($"Celsius: {celsius:F2}°C");
        Console.WriteLine($"Kelvin: {kelvin:F2}K");
    }

    // Method Overload 3

    private static void Convert(
        double value,
        Kelvin unit)
    {
        double celsius =
            value - 273.15;

        double fahrenheit =
            (celsius * 9 / 5) + 32;

        Console.WriteLine($"\nKelvin: {value:F2}K");
        Console.WriteLine($"Celsius: {celsius:F2}°C");
        Console.WriteLine($"Fahrenheit: {fahrenheit:F2}°F");
    }
}