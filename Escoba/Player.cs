namespace T2;

public class Player
{
    private string _name { get; }
    private int _puntaje = 0;
    private List<Card> _hand = new List<Card>();
    private List<Card> _graveyard = new List<Card>();
    private int _escobas = 0;
    private int _sevens = 0;
    private int _cardNumber  = 0;
    private int _goldNumber  = 0;
    private Dictionary<string, int> _summary = new Dictionary<string, int>();
    
    public Player(string name) { _name = name; }

    public string GetName() { return _name; }
    
    public List<Card> GetHand() { return _hand; }
    
    public int GetPuntaje() { return _puntaje; }
    
    public void AddToGraveyard(Card card) { _graveyard.Add(card); }
    
    public void AddPoint() { _puntaje++; }
    
    public void AddToHand(Card card) { _hand.Add(card); }
    
    public void RemoveFromHand(Card card) { _hand.Remove(card); }
    
    public void AddEscoba() { _escobas++; }
    
    public void PointCalculator()
    {
        _puntaje += _escobas;
        bool SevenGold = false;
        foreach (var card in _graveyard)
        {
            _cardNumber++;
            if (card.GetFace()=="7" && card.GetSuit()=="Oros") { SevenGold = true; }
            if (card.GetFace()=="7") { _sevens++; }
            if (card.GetSuit()=="Oros") { _goldNumber++; }
        }
        if (SevenGold) { _puntaje++; }
    }

    public Dictionary<string, int> GetSummary()
    {
        PointCalculator();
        _summary.Add("Escobas", _escobas);
        _summary.Add("Sietes", _sevens);
        _summary.Add("TotalCartas", _cardNumber);
        _summary.Add("Oros", _goldNumber);
        return _summary;
    }
}