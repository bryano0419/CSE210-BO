class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        Display(f1);
        Display(f2);
        Display(f3);
        Display(f4);

        f1.SetTop(7);
        f1.SetBottom(8);
        Console.WriteLine("Updated f1:");
        Display(f1);
    }

    static void Display(Fraction f)
    {
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());
    }
}






