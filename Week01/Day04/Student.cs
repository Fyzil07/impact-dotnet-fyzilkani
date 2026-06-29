namespace Week01.Day04;

public class Student
{
    public const int MinAge = 5;

    public readonly DateTime CreatedDate;

    private int _age;

    public string Name { get; set; }

    public int Age
    {
        get => _age;

        set
        {
            if (value < 5 || value > 100)
            {
                throw new ArgumentException(
                    "Age must be between 5 and 100.");
            }

            _age = value;
        }
    }

    public Student()
        : this("Unknown", 18)
    {
    }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;

        CreatedDate = DateTime.Now;
    }

    public string CalculateGrade(int marks)
    {
        return marks >= 50 ? "Pass" : "Fail";
    }

    public string CalculateGrade(int marks, int bonus)
    {
        return CalculateGrade(marks + bonus);
    }
}