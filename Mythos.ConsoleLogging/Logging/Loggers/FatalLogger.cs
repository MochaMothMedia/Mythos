using System.Diagnostics;

namespace Mythos.ConsoleLogging.Loggers
{
    internal class FatalLogger : ILogger
    {
        public bool MatchesLogLevel(LogLevel level)
        {
            return level == LogLevel.Fatal;
        }

        public void Log(string message, Exception? exception)
		{
			Debug.WriteLine($"{DateTime.Now.ToLocalTime()} [FATAL] {message}@@@EVENT CRITICAL @@@BACKGROUND BLACK");

            if (exception != null)
            {
			    Debug.WriteLine($"\t{exception!.Message}@@@EVENT CRITICAL @@@BACKGROUND BLACK");
			    Debug.WriteLine($"\t\t{exception.StackTrace}@@@EVENT CRITICAL @@@BACKGROUND BLACK");
            }
		}
    }
}
