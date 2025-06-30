using System;

class Program
{
    static void Main(string[] args)
    {
        string reference = "John 3:16";
        string text = "For God so loved the world that he gave his only begotten Son";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.Display());
            Console.WriteLine("\nPress enter to hide more or type 'quit'.");

            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }

            scripture.HideWords();
        }
    }
}
