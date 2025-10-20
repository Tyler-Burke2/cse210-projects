using System.Dynamic;

class Word
{
    // attributes
    private string _text;
    private bool _isHidden;

    // behaviors
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return "_______";
        }
        else
        {
            return _text;
        }
    }
}