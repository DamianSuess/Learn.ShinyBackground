using System;

namespace Learn.ShinyBackground.Services
{
  public class LogService
  {
    public void Debug(string message)
    {
      Console.WriteLine($"{DateTime.Now.ToString("G")}] [{message}]");
    }
  }
}
