using Fabrikam.Logging;
using System;

namespace Fabrikam.Console
{
    class Program
    {
        static void Main()
        {
            var logEntry = new
            {
                StartTime = DateTime.Now,
                Purpose = "Demo",
                State = "Started"
            };
            MyLogger.Instance.WriteLine(logEntry);
        }
    }
}
