namespace CurrencyConvertor;

public class Currency
{
    public Currency(string name, string abbreviation, decimal value)
    {
        Name = name;
        Value = value;
        Abbreviation = abbreviation;
    }

    public string Name { get; set; }

    public decimal Value { get; set; }

    public string Abbreviation { get; set; }
}
