using System;

namespace FizzBuzzConsoleApp
{

  public class Program
  {
    public static void Main(string[] args)
    {
      UserInputOBJ objUI;
      UserInputBLL bllUI;

      try {

        Console.WriteLine("*************************");
        Console.WriteLine("**    FizzBuzz App     **");
        Console.WriteLine("*************************");
        Console.WriteLine("");
        Console.WriteLine("RESULTS KEY: Fizz = Divisible by 3, Buzz = Divisible by 5, FizzBuzz = Divisible by 3 and 5");
        Console.WriteLine("");
        Console.WriteLine("Please enter a list of integers, separated by commas, or 'q' to quit.");

        objUI = new UserInputOBJ();
        bllUI = new UserInputBLL();
        objUI.strUserInput = Console.ReadLine();
     
        while (objUI.strUserInput != "q")
        {
          bllUI.playFizzBuzz(objUI);
          Console.WriteLine("Please enter another list of integers, or 'q' to quit.");
          objUI = new UserInputOBJ();
          objUI.strUserInput = Console.ReadLine();
        }            
      } catch (Exception e) {
        Console.WriteLine("An error occurred: " + e);
      }
    }
  }
}
