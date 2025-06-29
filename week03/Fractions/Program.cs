class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction(3, 4);
        Console.WriteLine(f.GetTop() + "/" + f.GetBottom());
        Console.WriteLine((double)f.GetTop() / f.GetBottom()); 
    }
}



