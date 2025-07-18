class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            BreathingActivity breath = new BreathingActivity();
            breath.Run();
        }
        else if (choice == 2)
        {
            ReflectionActivity reflect = new ReflectionActivity();
            reflect.Run();
        }
        else if (choice == 3)
        {
            ListingActivity list = new ListingActivity();
            list.Run();
        }
    }
}
