class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction(3, 0); // ❌ Still broken: zero denominator!
        Console.WriteLine(f.GetTop() + "/" + f.GetBottom());
        Console.WriteLine((double)f.GetTop() / f.GetBottom()); // 💥 Still crashes
    }
}


