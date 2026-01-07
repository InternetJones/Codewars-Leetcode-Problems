//problem
// Welcome. In this kata, you are asked to square every digit of a number and concatenate them.

// For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1. (81-1-1-81)

// Example #2: An input of 765 will/should return 493625 because 72 is 49, 62 is 36, and 52 is 25. (49-36-25)

//My solution
using System;

public class Kata
{
  public static int SquareDigits(int n)
  {
    //convert n to string
    string nstring = "";
    nstring += n;
    string resultstr = "";
    //split string to an array of chars
    string[] narray = nstring.Split("");
    //for each value convert back into an integer
    foreach(var number in nstring)
    {
      var numstr = number.ToString();
      //square each value
      var result = int.Parse(numstr) * int.Parse(numstr);
      //convert back into string
      //concatenate result
      resultstr += result;
    }
    return int.Parse(resultstr);
    
    //convert back to int
    //return int
  }
}