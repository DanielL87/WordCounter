
using System;
using System.Linq;

namespace WordCounter
{
  public class WordCount
  {
    public string wordInput(string word)
    {
      string userWord = word;
      return userWord;
    }
    public string[] sentenceInput(string sentence)
    {
      string [] userSentenceSplit = sentence.Split(' ').ToArray();
      return userSentenceSplit;
    }
    public int countWords(string userWord, string userSentenceSplit)
    {
      int counter = 0;
      for (int x = 0; x <= userSentenceSplit.Length; x++)
      {
        if(userSentenceSplit[x].ToString() == userWord)
        {
          counter++;
        }
          return counter;
      }
      return counter;
    }
  }
}  
