using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }
    public void HideRandomWords(int numberToHide)
    {
        for(int i=0; i<numberToHide; i++)
        {
            _words[new Random().Next(0, _words.Count)].Hide();
        }
    }
    public string GetDisplayText()
    {
        string textToDisplay = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            textToDisplay += " " + word.GetDisplayText();
        }
        return textToDisplay;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
