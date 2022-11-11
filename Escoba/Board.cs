namespace T2;

public class Board
{
    private List<Card> _board = new List<Card>();
    
    public void AddCardToBoard(Card card)
    {
        _board.Add(card);
    }
    
    public void RemoveCardFromBoard(Card card)
    {
        _board.Remove(card);
    }
    
    public List<Card> GetBoard()
    {
        return _board;
    }

}