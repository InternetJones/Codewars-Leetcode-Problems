//problem
// Given a list of integers, determine whether the sum of its elements is odd or even.

// Give your answer as a string matching "odd" or "even".

// If the input array is empty consider it as: [0] (array with a zero).

//My solution
using System.Linq;
public class Kata
{
    public static string OddOrEven(int[] array) => array.Sum() % 2 == 0 ? "even" : "odd";
}