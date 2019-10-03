using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class SrabbleCalc
  {
    [TestMethod]
    public void CharValue_ReturnsValueOfAGivenCharacter_Int1()
    {
        // Arrange
        ScrabbleCalc scrabbleCalc = new ScrabbleCalc("a");
        // Act
        int actual = scrabbleCalc.CharValue('a');

        // Assert
        Assert.AreEqual(1, actual);
    }

    [TestMethod]
    public void CharValue_ReturnsValueOfAGivenCharacter_Int10()
    {
        // Arrange
        ScrabbleCalc scrabbleCalc = new ScrabbleCalc("z");
        // Act
        int actual = scrabbleCalc.CharValue('z');

        // Assert
        Assert.AreEqual(10, actual);
    }

    [TestMethod]
    public void WordValue_ReturnsValueOfAGivenWord_Int4()
    {
        // Arrange
        ScrabbleCalc scrabbleCalc = new ScrabbleCalc("Ab");
        // Act
        int actual = scrabbleCalc.WordValue();

        // Assert
        Assert.AreEqual(4, actual);
    }

    [TestMethod]
    public void WordValue_ReturnsValueOfAGivenWord_Int59()
    {
        // Arrange
        ScrabbleCalc scrabbleCalc = new ScrabbleCalc("tenable");
        // Act
        int actual = scrabbleCalc.WordValue();

        // Assert
        Assert.AreEqual(59, actual);
    }

    [TestMethod]
    public void WordValue_IgnoresNonLetterChars_Int2()
    {
        // Arrange
        ScrabbleCalc scrabbleCalc = new ScrabbleCalc("D2");
        // Act
        int actual = scrabbleCalc.WordValue();

        // Assert
        Assert.AreEqual(2, actual);
    }
  }
}