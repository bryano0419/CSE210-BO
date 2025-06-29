public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _numerator = numerator;
        _denominator = denominator;
    }

    public int GetTop() => _numerator;
    public int GetBottom() => _denominator;

    public void SetTop(int numerator) => _numerator = numerator;

    public void SetBottom(int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _denominator = denominator;
    }

    public string GetFractionString() => $"{_numerator}/{_denominator}";

    public double GetDecimalValue() => (double)_numerator / _denominator;
}




