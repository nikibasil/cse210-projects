using System;
// using System.IO;
// using System.Text;

public class Scripture
{
    string[] stringarr;

    // Step 2:Array Initialization
    stringarr = new string[3] {"Element 1", "Element 2", "Element 3"};

// Step 3:Accessing Array Elements
    // Console.WriteLine(stringarr[0]);
    // Console.WriteLine(stringarr[1]);
    // Console.WriteLine(stringarr[2]); 
    


}



// public class Fraction{

//     private int _top;
//     private int _bottom;
    
//     public Fraction(){
//         _top = 1;
//         _bottom = 1;
//     }

//     public Fraction(int wholeNumber){
      
//         _top = wholeNumber;
//         _bottom = 1;
    
//     }

//     public Fraction(int top, int bottom){
//         _top = top;
//         _bottom = bottom;
//     }

//    public string GetFractionString(){

//        // Notice that this is not stored as a member variable.
//         // Is is just a temporary, local variable that will be recomputed each time this is called.
//         string text = $"{_top}/{_bottom}";
//         return text;
 //    }

//     public double GetDecimalValue(){
//         // Notice that this is not stored as a member variable.
//         // Is will be recomputed each time this is called.
//         return (double)_top / (double)_bottom; 
//     }
// }

// public class Scripture
// {
//     private List<Word> _listOfWords = new List<Word>();
//     private Reference _reference = null;


//     public Scripture(string book, string chapter, string verse1, string verse2, string scripture)
//     {
//         _reference = new Reference(book, chapter, verse1, verse2);

//         string[] splitText = scripture.Split(" ");
//         foreach (string word in splitText)
//         {
//             Word newWord = new Word(word);
//             _listOfWords.Add(newWord);
//         }
//     }

//     // METHODS
//     public void DisplayWords()
//     {
//         foreach (Word word in _listOfWords)
//         {
//             // It prints words or _, depending on what _isHidden takes as a bool value.
//             word.ShowWord();

//             // Add white spaces between words.
//             Console.Write(" ");
//         }
//         Console.WriteLine();
//     }

//     public void HideWords()
//     {
//         // Create an instance of the Random class
//         Random rnd = new Random();

//         // This loop is executed until the CheckFullyHidden changes the state variable to true, which means that the list is totally hidden.
//         while (true)
//         {
//             DisplayWords();
//             Console.WriteLine();
//             // This method allows me to work only with the words that are still shown and NOT hidden. 
//             List<Word> words = new List<Word>();
//             foreach (Word word in _listOfWords)
//             {
//                 if (word.IsHidden() == false)
//                 {
//                     words.Add(word);
//                 }
//             }
//             if (words.Count() == 0)
//                 break;

//             Console.WriteLine("Press Enter to continue or Quit to finish.");
//             string userInput = Console.ReadLine();

//             if (userInput.ToLower() == "quit")
//             {
//                 break; // Ends executing the method.
//             }

//             Console.Clear();

//             // It's executed three times, in order to hide three words: 
//             for (int c = 0; c < 3; c++)
//             {
//                 // Select three random words to hide 
//                 int index = rnd.Next(words.Count() - 1); // I substract 1 unit because the index  
//                                                          // is a number less than the length of the array.
//                                                          // Get a Word object from the Word list 
//                 words[index].IsHidden(true); // Changes the isHidden to true to indicate a hidden word.
//                 words.RemoveAt(index);
//                 if (words.Count() == 0)
//                     break;
//             }
//             Console.Clear();
//         }
//     }
// }