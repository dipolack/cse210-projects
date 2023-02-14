using System;
class Scripture
{
    private string reference;
    private string text;
    private List<string> hiddenWords;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
        this.hiddenWords = new List<string>();
    }

    public void DisplayScripture()
    {
        Console.WriteLine(reference);
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            if (hiddenWords.Contains(word))
            {
                Console.Write("_____ ");
            }
            else
            {
                Console.Write(word + " ");
            }
        }
        Console.WriteLine();
    }

    public void HideWord()
    {
        string[] words = text.Split(' ');
        Random rand = new Random();
        int index = rand.Next(words.Length);
        string wordToHide = words[index];

        hiddenWords.Add(wordToHide);
    }

    public bool AllWordsHidden()
    {
        string[] words = text.Split(' ');
        return hiddenWords.Count == words.Length;
    }
}