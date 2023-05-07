namespace TradeMark;

public class Register
{
    private readonly HashSet<string> _tradeMarks = new ();
    public int Count => _tradeMarks.Count;
    public bool Registration(string trademark)
    {
        var normalizeTrade = NormalizeTrademark(trademark);
        return _tradeMarks.Add(normalizeTrade);
    }
    

    private static string NormalizeTrademark(string trademark)
    {
        var chars = trademark.Where((chr, i) =>
        {
            if (i < 2) return true;
            var prevTwoCharsEqualToCurrent = chr == trademark[i - 1] && chr == trademark[i - 2];
            return !prevTwoCharsEqualToCurrent;
        });
        return new string(chars.ToArray());
    }

    public void ListMarks()
    {
        foreach (var i in _tradeMarks)
            Console.WriteLine(i);
         
    }

}