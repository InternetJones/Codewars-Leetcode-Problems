//Problem
// You live in the city of Cartesia where all roads are laid out in a perfect grid. You arrived ten minutes too early to an appointment, 
// so you decided to take the opportunity to go for a short walk. The city provides its citizens with a Walk Generating App on their phones 
// -- everytime you press the button it sends you an array of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']). 
// You always walk only a single block for each letter (direction) and you know it takes you one minute to traverse one city block, 
// so create a function that will return true if the walk the app gives you will take you exactly ten minutes (you don't want to be early or late!) 
// and will, of course, return you to your starting point. Return false otherwise.

//My solution
public class Kata
{
  public static bool IsValidWalk(string[] walk)
  {
        int time = 0;
        int x = 0;
        int y = 0;
        for (int i = 0; i < walk.Length; i++)
        {
            if (walk[i] == "n")
            {
                time++;
                x++;
            }
            else if (walk[i] == "s")
            {
                time++;
                x--;
            }
            else if (walk[i] == "e")
            {
                time++;
                y++;
            }
            else if (walk[i] == "w")
            {
                time++;
                y--;
            }
        }
        if (time == 10 && x == 0 && y == 0)
        {
            return true;
        }
        return false;
    }
}