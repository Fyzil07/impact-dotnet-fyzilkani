namespace Week01.Day05;

public class Playlist
{
    private readonly List<string> _songs = new();

    public void AddSong(string song)
    {
        _songs.Add(song);
    }

    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= _songs.Count)
            {
                return "Invalid index";
            }

            return _songs[index];
        }

        set
        {
            if (index >= 0 && index < _songs.Count)
            {
                _songs[index] = value;
            }
        }
    }
}