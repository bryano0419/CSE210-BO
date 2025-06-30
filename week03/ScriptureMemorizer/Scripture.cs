using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference reference;
    public List<Word> words;

    public Scripture(string referenceText, string scriptureText)
    {
        reference = new Reference(referenceText, 1, 1);
        string[] parts = scriptureText.Split(' ');
        words = new List<Word>();
        foreach (string part in parts)
        {
            words.Add(new Word(part));
        }
    }

    public void HideWords()
    {
        Random rnd = new Random();
        int index = rnd.Next(words.Count);
        words[index].hidden = true;
    }

    public string Display()
    {
        string result = reference.GetReference() + " ";
        foreach (var word in words)
        {
            result += word.Display() + " ";
        }
        return result;
    }
}
