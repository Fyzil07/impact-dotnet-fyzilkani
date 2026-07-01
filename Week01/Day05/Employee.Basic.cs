namespace Week01.Day05;

public partial class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;

        OnEmployeeCreated();
    }

    partial void OnEmployeeCreated();
}