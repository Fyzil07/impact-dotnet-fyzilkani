namespace Week01.Day05;

public class AccessModifierDemo
{
    public string PublicMessage => "Public: Accessible everywhere";

    private string PrivateMessage => "Private: Accessible only inside this class";

    protected string ProtectedMessage => "Protected: Accessible in derived classes";

    internal string InternalMessage => "Internal: Accessible within the same assembly";

    protected internal string ProtectedInternalMessage =>
        "Protected Internal: Derived classes or same assembly";

    public void DisplayMessages()
    {
        Console.WriteLine(PublicMessage);
        Console.WriteLine(PrivateMessage);
        Console.WriteLine(ProtectedMessage);
        Console.WriteLine(InternalMessage);
        Console.WriteLine(ProtectedInternalMessage);
    }
}