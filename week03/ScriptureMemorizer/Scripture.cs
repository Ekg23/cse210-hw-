using System;

using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _word;
    private Random _random;

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _word = text.Split(' ')
                    .Select(w => new Word(w))
                    .ToList(); // Word objects
        _random = new Random();
    }

    public void HideRandomWords(int numberToHide)
    {
        var visibleWords = _word.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        var formattedWords = _word.Select(w => w.GetDisplayText());
        return $"{_reference.GetDisplayText()}\n{string.Join(" ", formattedWords)}";
    }

    public bool IsCompletelyHidden()
    {
        return _word.All(w => w.IsHidden());
    }
}