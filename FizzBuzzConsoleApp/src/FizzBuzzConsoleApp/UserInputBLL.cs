using System;

namespace FizzBuzzConsoleApp
{
  public class UserInputBLL
  {
    public void playFizzBuzz(UserInputOBJ objUI)
    {
      System.Text.StringBuilder sbOutput = new System.Text.StringBuilder();

      foreach (string strUserListItem in objUI.araUserInput)
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

