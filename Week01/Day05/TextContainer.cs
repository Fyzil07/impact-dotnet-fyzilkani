namespace Week01.Day05;

public class TextContainer
{
    private readonly Dictionary<string, string> _data = new();

    public string this[string key]
    {
        get
        {
            if (_data.ContainsKey(key))
            {
                return _data[key];
            }

            return "Key not found";
        }

        set
        {
            _data[key] = value;
        }
    }
}