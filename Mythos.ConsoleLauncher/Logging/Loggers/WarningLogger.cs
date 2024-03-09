using System.Diagnostics;

namespace Mythos.ConsoleLauncher.Logging.Loggers
{
    internal class WarningLogger : ILogger
    {
        public bool MatchesLogLevel(LogLevel level)
        {
            return level == LogLevel.Warning;
        }

        public void Log(string message, Exception? exception)
        {
			Debug.WriteLine($"{DateTime.Now.ToLocalTime()} [WARN ] {message}@@@EVENT WARNING");
		}
    }
}
