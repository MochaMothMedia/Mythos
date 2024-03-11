using System.Diagnostics;

namespace Mythos.ConsoleLogging.Loggers
{
    internal class ErrorLogger : ILogger
    {
        public bool MatchesLogLevel(LogLevel level)
        {
            return level == LogLevel.Error;
        }

        public void Log(string message, Exception? exception)
		{
			Debug.WriteLine($"{DateTime.Now.ToLocalTime()} [ERROR] {message}@@@EVENT ERROR");
			if (exception != null)
			{
				Debug.WriteLine($"\t{exception.Message}@@@EVENT ERROR");
				Debug.WriteLine($"\t\t{exception.StackTrace}@@@EVENT ERROR");
			}
		}
    }
}
