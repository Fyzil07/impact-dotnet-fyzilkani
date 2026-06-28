#define TRIAL_VERSION

using SchoolManagement;

Console.WriteLine("=== Task 1.5 ===");

// Using directive
Student student1 = new Student
{
    Name = "Alice",
    Age = 20
};

student1.DisplayInfo();

// Fully qualified name
SchoolManagement.Student student2 =
    new SchoolManagement.Student
    {
        Name = "Bob",
        Age = 22
    };

student2.DisplayInfo();

/*
using SchoolManagement allows us to use Student directly.

Without using, we must write SchoolManagement.Student.
*/


Console.WriteLine("\n=== Task 1.6 ===");

// No using ModuleA or ModuleB because Helper exists in both namespaces

ModuleA.Helper.Greet();
ModuleB.Helper.Greet();

/*
If we wrote:

using ModuleA;
using ModuleB;

Helper.Greet();

the compiler would not know which Helper class to use.
*/


Console.WriteLine("\n=== Task 1.7 ===");

// camelCase local variables

int studentAge = 20;
string firstName = "Alice";

void PrintStudentInfo()
{
    Console.WriteLine($"{firstName}, Age: {studentAge}");
}

// PascalCase method name

PrintStudentInfo();

// int class = 5; // Compile error because class is a keyword

int @class = 5;

Console.WriteLine($"Class number: {@class}");

/*
@class works because @ tells the compiler
to treat class as an identifier instead of a keyword.

In real applications, prefer classNumber.
*/


Console.WriteLine("\n=== Task 1.8 ===");

#if TRIAL_VERSION
Console.WriteLine("You are using the TRIAL version.");
#else
Console.WriteLine("You are using the FULL version.");
#endif


Employee employee = new Employee("Ravi", 30);

employee.Display();