// problem

// A pangram is a sentence that contains every single letter of the alphabet at least once. For example, the sentence 
// "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once (case is irrelevant).

// Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.

//My solution
using System;
using System.Collections.Generic;

public static class Kata
{
  public static bool IsPangram(string str)
  {
    //Break string into array of chars
    var chararray = str.ToLower().ToCharArray();
    
    //Create a list of all letters
    var charlist = new List<char>(){'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
    //Loop through array
    foreach(var letter in chararray)
    {
      if(charlist.Contains(letter))
      {
        //Check if character is a letter and remove from list if so
        charlist.Remove(letter);
      }
    }
    
    //Check if list is empty and return true if it is or false if not
    if(charlist.Count == 0)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}