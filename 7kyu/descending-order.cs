//problem
// Your task is to make a function that can take any non-negative integer as an argument and return 
// it with its digits in descending order. Essentially, rearrange the digits to create the highest possible number.

//My solution
using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
        var n = 0;
        List<int> nums = new List<int>();

        while (num > 0){
            n = num % 10;
            num = (num - n) / 10;
            nums.Add(n);
        }

        var desc = nums.OrderByDescending(x => x).ToArray();

        for(int i = 0; i < desc.Length; i++){
            num += desc[i] * (int)(Math.Pow(10, desc.Length - 1 - i));
        }
        
        return num;
  }
}