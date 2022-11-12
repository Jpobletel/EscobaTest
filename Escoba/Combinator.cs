namespace T2;

public class Combinator
{
    public List<List<Card>> GetCombination(List<Card> list, LocalView view)
    {
        List<List<Card>> optionList = new List<List<Card>>();
        double count = Math.Pow(2, list.Count);
        for (int i = 1; i <= count - 1; i++)
        {
            List<Card> availablePlays = new List<Card>();
            string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
            
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] == '1') { availablePlays.Add(list[j]); }
            }
            if (GetSum(availablePlays)) { optionList.Add(availablePlays); }
        }

        int index = 0;
        foreach (var cardList in optionList)
        {
            view.Option(index);
            foreach (var card in cardList) { view.PlainText("    " + card.GetFace() + " de " + card.GetSuit()); }
            index++;
        }

        return optionList;
    }
    public bool GetSum(List<Card> cards)
    {
        int totalValue = 0;
        foreach (var card in cards)
        { totalValue = totalValue + card.GetValue(); }
        Console.WriteLine(totalValue);
        if (totalValue == 15) { return true; }
        return false;
    }
}