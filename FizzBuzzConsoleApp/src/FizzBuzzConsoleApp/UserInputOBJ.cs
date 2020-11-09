using System;

namespace FizzBuzzConsoleApp
{
  public class UserInputOBJ
  {
    public string strUserInput;
    public string[] araUserInput {
      get { return strUserInput.Split(','); }
    }
  }
}
