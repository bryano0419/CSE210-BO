public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction(int top, int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        _numerator = top;
        _denominator = bottom;
    }

    public int GetTop()
    {
        return _numerator;
    }

    public int GetBottom()
    {
        return _denominator;
    }
}



