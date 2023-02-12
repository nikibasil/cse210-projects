using System;
// / Keeps track of the reference and the text of the scripture. 
// Can hide words and get the rendered display of the text.

public class Scripture
{
    private List<Word> _listOfWords = new List<Word>();
    private Reference _reference = null;


    public Scripture(string book, string chapter, string verse1, string verse2, string scripture)
    {
        _reference = new Reference(book, chapter, verse1, verse2);

        string[] splitText = scripture.Split(" ");
        foreach (string word in splitText)
        {
            Word newWord = new Word(word);
            _listOfWords.Add(newWord);
        }
    }

    // METHODS
    public void DisplayWords()
    {
        foreach (Word word in _listOfWords)
        {
            // It prints words or _, depending on what _isHidden takes as a bool value.
            word.ShowWord();

            // Add white spaces between words.
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    public void HideWords()
    {
        // Create an instance of the Random class
        Random rnd = new Random();

        // This loop is executed until the CheckFullyHidden changes the state variable to true, which means that the list is totally hidden.
        while (true)
        {
            DisplayWords();
            Console.WriteLine();
            // This method allows me to work only with the words that are still shown and NOT hidden. 
            List<Word> words = new List<Word>();
            foreach (Word word in _listOfWords)
            {
                if (word.IsHidden() == false)
                {
                    words.Add(word);
                }
            }
            if (words.Count() == 0)
                break;

            Console.WriteLine("Press Enter to continue or Quit to finish.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break; // Ends executing the method.
            }

            Console.Clear();

            // It's executed three times, in order to hide three words: 
            for (int c = 0; c < 3; c++)
            {
                // Select three random words to hide 
                int index = rnd.Next(words.Count() - 1); // I substract 1 unit because the index  
                                                         // is a number less than the length of the array.
                                                         // Get a Word object from the Word list 
                words[index].IsHidden(true); // Changes the isHidden to true to indicate a hidden word.
                words.RemoveAt(index);
                if (words.Count() == 0)
                    break;
            }
            Console.Clear();
        }
    }
}