using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace LiveProgam
{
  class Program
  {
    static void Main()
    {
      Loop();
    }

    static void Loop()
    {
      Console.WriteLine("Please enter a word to evaluate:");
      string word = Console.ReadLine();
      ScrabbleCalc scrabbleCalc = new ScrabbleCalc(word);
      int value = scrabbleCalc.WordValue();

      if (scrabbleCalc.Warn == false)
      {
      Console.WriteLine("This word is worth " + value + " points in scrabble.");
      }
      else
      {
      Console.WriteLine("Your word contained characters that are not worth any points in scrabble. Without those characters, your word is worth " + value + " points.");
      }
      
      Console.WriteLine("Do you want to try again? [y/n]");
      string userAnswer = Console.ReadLine();
      if (userAnswer == "y")
      {
        Loop();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }

    }
  }
}