#define TRIAL_VERSION

using SchoolManagement;

namespace Week01.Day02;

public static class Day02Runner
{
    public static void Run()
    {
        Console.WriteLine("\n=== Task 1.5 ===");
        Task15();

        Console.WriteLine("\n=== Task 1.6 ===");
        Task16();

        Console.WriteLine("\n=== Task 1.7 ===");
        Task17();

        Console.WriteLine("\n=== Task 1.8 ===");
        Task18();
    }

    private static void Task15()
    {
        // Using directive
        Student student1 = new()
        {
            Name = "Alice",
            Age = 20
        };

        student1.DisplayInfo();

        // Fully qualified name
        SchoolManagement.Student student2 = new()
        {
            Name = "Bob",
            Age = 22
        };

        student2.DisplayInfo();

        /*
         * using SchoolManagement allows us to use Student directly.
         * Without using, we must write SchoolManagement.Student.
         */
    }

    private static void Task16()
    {
        ModuleA.Helper.Greet();
        ModuleB.Helper.Greet();

        /*
         * We do not use:
         * using ModuleA;
         * using ModuleB;
         *
         * because Helper would become ambiguous.
         */
    }

    private static void Task17()
    {
        int studentAge = 20;
        string firstName = "Alice";

        void PrintStudentInfo()
        {
            Console.WriteLine($"{firstName}, Age: {studentAge}");
        }

        PrintStudentInfo();

        // int class = 5; // Compile-time error

        int @class = 5;

        Console.WriteLine($"Class number: {@class}");

        /*
         * @ tells the compiler to treat 'class'
         * as an identifier instead of a keyword.
         *
         * In real projects, prefer classNumber.
         */
    }

    private static void Task18()
    {
#if TRIAL_VERSION
        Console.WriteLine("You are using the TRIAL version.");
#else
        Console.WriteLine("You are using the FULL version.");
#endif

        Employee employee = new("Ravi", 30);

        employee.Display();
    }
}