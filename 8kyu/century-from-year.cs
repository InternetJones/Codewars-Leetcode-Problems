//problem
// The first century spans from the year 1 up to and including the year 100, the second century - from the year 101 up to and including the year 200, etc.

// Given a year, return the century it is in.

//My solution
public static class Kata
{
  public static int СenturyFromYear(int year)
  {
    return year%100==0 ? (year/100) : (year/100)+1;
  }
}