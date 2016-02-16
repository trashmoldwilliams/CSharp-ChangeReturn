using System.Collections.Generic;
using System;

namespace AnagramNS.Objects
{
  public class Word
  {
    private static List<string> _wordList = new List<string>(){"beard", "dog"};


    public Word()
    {

    }

    public static List<string> CompareWord(string word)
    {
      char[] primaryArray = word.ToCharArray();
      Array.Sort(primaryArray);
      Console.WriteLine("Primary" + primaryArray);
      List<string> anagramList = new List<string>();

      for(var i = 0; i < _wordList.Count; i++)
      {
        char[] currentWordArray = _wordList[i].ToCharArray();
        Array.Sort(currentWordArray);
        Console.WriteLine(currentWordArray);
        // char [] sortedWordArray = Array.Sort(currentWordArray)
        if (primaryArray == currentWordArray)
        {
          Console.WriteLine("matched");
          anagramList.Add(_wordList[i]);
        }
      }

      return anagramList;
    }


  } // end class
} // end namespace
