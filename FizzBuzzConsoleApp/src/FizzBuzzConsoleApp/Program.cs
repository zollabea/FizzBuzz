using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FizzBuzzConsoleApp
{

  public class Program
  {
    public static void Main(string[] args)
    {
          string strUserInput = "";
          System.Text.StringBuilder sbOutput = new System.Text.StringBuilder();
          string[] araUserInput;

      try {

        Console.WriteLine("*************************");
        Console.WriteLine("**    FizzBuzz App     **");
        Console.WriteLine("*************************");
        Console.WriteLine("");
        Console.WriteLine("INSTRUCTIONS:");
        Console.WriteLine("Type a list of integers, divided by commas, then Enter.");
        Console.WriteLine("");
        Console.WriteLine("RESULTS KEY: Fizz = Divisible by 3, Buzz = Divisible by 5, FizzBuzz = Divisible by 3 and 5");
        Console.WriteLine("");
        strUserInput = Console.ReadLine();

        araUserInput = strUserInput.Split(',');

        foreach (string strUserListItem in araUserInput)
        {
          bool boolFizz = false;
          bool boolBuzz = false;
          int userInputConvertedToInt;

          //If Input is an Integer
          if (int.TryParse(strUserListItem, out userInputConvertedToInt))
          {
            boolFizz = tryFizz(userInputConvertedToInt);
            if (boolFizz)
            {
              sbOutput.Append("Fizz");
            }

            boolBuzz = tryBuzz(userInputConvertedToInt);
            if (boolBuzz)
            {
              sbOutput.Append("Buzz");
            }

            if (boolFizz || boolBuzz)
            {
              sbOutput.AppendLine();
            }

            if (!boolFizz && !boolBuzz)
            {
              sbOutput.AppendLine("Divided " + strUserListItem + " by 3");
              sbOutput.AppendLine("Divided " + strUserListItem + " by 5");
            }
          }

          //Else not an Integer
          else
          {
            sbOutput.AppendLine("Invalid Item");
          }

        }

        Console.WriteLine(sbOutput);
        Console.ReadLine();

      } catch (Exception e) {
        Console.WriteLine("An error occurred: " + e);
      }
    }

    private static bool tryFizz(int userInputConvertedToInt)
    {
      if ((Convert.ToDecimal(userInputConvertedToInt) / 3) % 1 == 0)
      {
        return true;
      }
      else return false;
    }

    private static bool tryBuzz(int userInputConvertedToInt)
    {
      if ((Convert.ToDecimal(userInputConvertedToInt) / 5) % 1 == 0)
      {
        return true;
      }
      else return false;
    }

  }
}
