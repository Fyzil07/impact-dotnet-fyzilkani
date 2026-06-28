namespace Week01.Day02;

public class Employee
{
    #region Fields

    private string _name;
    private int _age;

    #endregion

    #region Properties

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public int Age
    {
        get => _age;
        set => _age = value;
    }

    #endregion

    #region Constructors

    public Employee(string name, int age)
    {
        _name = name;
        _age = age;
    }

    #endregion

    #region Methods

    public void Display()
    {
        Console.WriteLine($"Employee: {_name}, Age: {_age}");
    }

    #endregion
}