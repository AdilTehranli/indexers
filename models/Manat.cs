namespace learn3.models;

public class Manat
{
    public decimal Cash { get; set; }
    public Manat(decimal cash)
    {
        
    Cash = cash;
    }
    public static implicit operator Manat(Dollar dollar)
    {
        return new Manat(dollar.Usd * 1.7m);
    }
}

