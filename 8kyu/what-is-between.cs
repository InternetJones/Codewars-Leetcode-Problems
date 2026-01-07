//problem
//Complete the function that takes two integers (a, b, where a < b) and return an array of all integers between the input parameters, including them.

//My solution
using System;
using System.Collections.Generic;

public class Kata {
  public static int[] Between(int a, int b) {
    int i = 0;
    int j = (b - a) + 1;
    List<int> result = new List<int>();
    while (i < j)
    {
      result.Add(a + i);
      i++;
    }
    return result.ToArray();
  }
}