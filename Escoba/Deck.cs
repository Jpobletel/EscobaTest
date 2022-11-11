namespace T2;

public class Deck
{
    public List<string> suitList = new List<string> { "Oros", "Espadas", "Copas", "Bastos" };
    public List<string> faceList = new List<string> { "1", "2", "3", "4", "5", "6", "7", "Sota", "Caballo", "Rey" };
    private List<Card> _deck = new List<Card>();

    public Deck()
    {
        GenerateDeck();
        Console.WriteLine("Mazo Creado :D");
    }
    public List<Card> deckList
    {
        get { return _deck; }
    }
    public void GenerateDeck()
    {
        int id = 0;
        foreach (var suit in suitList)
        {
            foreach (var face in faceList)
            {
                _deck.Add(new Card(id, face, suit));
                id++;
            }
        }
    }

    public Card GetRandomCard()
    {
        var random = new Random();
        int index = random.Next(_deck.Count);
        Card randomCard = _deck[index];
        _deck.RemoveAt(index);
        return randomCard;
    }
    
    
}