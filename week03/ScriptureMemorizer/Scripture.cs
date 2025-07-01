using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        var unhiddenWords = _words.FindAll(w => !w.IsHidden());
        for (int i = 0; i < count && unhiddenWords.Count > 0; i++)
        {
            int index = _random.Next(unhiddenWords.Count);
            unhiddenWords[index].Hide();
            unhiddenWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";
        foreach (var word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        return _words.TrueForAll(w => w.IsHidden());
    }
}


