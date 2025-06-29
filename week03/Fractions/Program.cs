// Program.cs (Step 1 - BAD)
class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction(3, 0); // ❌ Division by zero error later
        Console.WriteLine(f.numerator + "/" + f.denominator);
        Console.WriteLine((double)f.numerator / f.denominator); // 💥 CRASH
    }
}

