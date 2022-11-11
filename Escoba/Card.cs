namespace T2;

public class Card
{
    private int _id { get; }
    private string _face { get; }
    private string _suit { get; }
    private int _value { get; set; }

    public Card(int id, string face, string suit)
    {
        _id = id;
        _face = face;
        _suit = suit;
        SetValue();
    }

    public void SetValue()
    {
        int value;
        bool isNumeric = int.TryParse(_face, out value);
        if (isNumeric)
        {
            _value = value;
        }
        else
        {
            if (_face == "Sota")
            {
                _value = 8;
            }
            else if (_face == "Caballo")
            {
                _value = 9;
            }
            else if (_face == "Rey")
            {
                _value = 10;
            }
        }
    }

    public int GetId()
    {
        return _id;
    }
    public string GetFace()
    {
        return _face;
    }
    public string GetSuit()
    {
        return _suit;
    }
    public int GetValue()
    {
        return _value;
    }

    public string GetSummary(int i)
    {
        return ("[" + i + "]: " + _face + " de " + _suit);
        
    }

}