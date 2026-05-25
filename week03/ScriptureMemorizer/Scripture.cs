using System;

class Scripture
{
    // This class will hold the reference and the text of a scripture, as well as a list of Word objects that represent each word in the scripture.
    private Reference _reference;
    private List<Word> _words;

    // Constructor that takes a Reference object and a string of text, splits the text into words, and creates Word objects for each word in the scripture.
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

    // Constructor to randomly hide a specified number of words in the scripture. It will continue to hide words until the specified number is hidden or the scripture is completely hidden.
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }

            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }

    // Getter to specified number of words in the scripture. It will continue to hide words until the specified number is hidden or the scripture is completely hidden.
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText;
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
