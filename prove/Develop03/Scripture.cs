public class Scripture
{
    // Attributes
    private Reference _reference;
    private List<Word> _words;

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    // Behaviors
    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetDisplayText());
        Console.WriteLine(GetDisplayText());
    }

    public string GetDisplayText()
    {
        string result = "";
        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        return result.Trim();
    }

    public Reference GetReference()
    {
        return _reference;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);
            Word word = _words[index];

            if (word.IsHidden() == true)
            {
              
            }
            else
            {
                word.Hide();
                hiddenCount++;
            }

            if (IsCompletelyHidden() == true)
            {
                break;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}
