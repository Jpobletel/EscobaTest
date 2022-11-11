namespace T2;

public abstract class View
{
    protected abstract void Write(string message);
    
    protected abstract string ReadLine();
    
    public virtual void Close() {}
    
    protected void WriteLine(string message) => Write(message + "\n");
    
    protected void WriteLine() => WriteLine("");
    
    public void Pause() => ReadLine();

    public void ShowBoard(Board board)
    {
        List<Card> boardList = board.GetBoard();
        if (boardList.Count > 0)
        {
            int i = 0;
            WriteLine("### MESA ###");
            foreach (var card in boardList)
            {
                WriteLine("###########");
                WriteLine(card.GetSummary(i));
                i++;
            }
            WriteLine("###########");
            WriteLine("-----------------------------------");
        }
        else
        {
            WriteLine("############");
            WriteLine("### MESA ###");
            WriteLine("### VACIA ###");
            WriteLine("############");
            WriteLine("-----------------------------------");
        }
    }

    public void HandView(Player player)
    {
        List<Card> hand = player.GetHand();
        if (hand.Count > 0)
        {
            int i = 0;
            foreach (var card in hand)
            {
                WriteLine("###########");
                WriteLine(card.GetSummary(i));
                i++;
            }
            WriteLine("###########");
        }
    }
    
    public void Escoba() { WriteLine("ESCOBAAA WOAAAAAAAAA!"); }

    public void NoCombinations(){ WriteLine("No hay combinaciones :/"); }
    
    public int GetInput(int supLimit)
    {
        int inputInt;
        var inputUsuario = ReadLine();
        bool success = int.TryParse(inputUsuario, out inputInt);
        while (!success || inputInt < 0 || inputInt >= supLimit)
        {
            inputUsuario  = ReadLine();
            success = int.TryParse(inputUsuario, out inputInt);
        }

        return inputInt;
    }

    public void EngGameSummary(Dictionary<string, int> p1, Dictionary<string, int> p2, List<Player> players)
    {
        WriteLine("Jugador 1:");
        WriteLine("    Puntos:" + players[0].GetPuntaje());
        WriteLine("--------------------------------------------");
        WriteLine("Jugador 2:");
        WriteLine("    Puntos:" + players[1].GetPuntaje());
        WriteLine("--------------------------------------------");
        WriteLine("GANADOR:"); 
        if (players[0].GetPuntaje() > players[1].GetPuntaje())
        {
            WriteLine("JUGADOR 1");
        }
        else
        {
            WriteLine("JUGADOR 2");
        }
    }

    public void Option(int index)
    {
        WriteLine("[" + index + "]");
    }

    public void PlainText(string text)
    {
        WriteLine(text);
    }
}