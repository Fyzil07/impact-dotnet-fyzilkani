namespace SchoolManagement;

public class Student
{
    public string Name { get; set; } = string.Empty;

    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student: {Name}, Age: {Age}");
    }
}