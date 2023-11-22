using System;

public class Word {

    private string _text;// Using the encasuplation method 
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if(IsHidden()){
            string hiddenText = "";
            foreach(char character in _text)
            {
                hiddenText += "_";    
            }
            return hiddenText;
        }
        return _text;
    }
}