  
using System;
using System.Collections.Generic;

namespace Scrabble.Models 
{
  public class ScrabbleCalc
  {
    public string Word {get; set;}
    public int Value {get; set;}
    public bool Warn {get; set;}
    public Dictionary<char, int> CharacterValue {get; set;}

    public ScrabbleCalc(string word)
    {
      Word = word;
      Value = 0;
      Warn = false;
      CharacterValue = new Dictionary<char, int> { {'a', 1}, {'e', 1}, {'i', 1}, {'o', 1}, {'u', 1}, {'l', 1}, {'n', 1}, {'r', 1}, {'s', 1}, {'t', 1}, {'d', 2}, {'g', 2}, {'b', 3}, {'c', 3}, {'m', 3}, {'p', 3}, {'f', 4}, {'h', 4}, {'v', 4}, {'w', 4}, {'y', 4}, {'k', 5}, {'j', 8}, {'x', 8}, {'q', 10}, {'z', 10} };
    }

    public int CharValue(char letter)
    {
      int value = 0;
      try 
      {
        value = CharacterValue[letter];
      }
      catch
      {
        value = 0;
        Warn = true;
      }
      return value;
    }

    public int WordValue()
    {
      string word = Word.ToLower();
      char[] array = word.ToCharArray();
      foreach (char letter in array)
      {
        Value += CharValue(letter);
      }

      if (array.Length >= 7)
      {
        Value += 50;
      }
      return Value;
    }
  }
}