using System.Diagnostics;

namespace Mythos.ConsoleLauncher.Logging.Loggers
{
    internal class InfoLogger : ILogger
    {
        public bool MatchesLogLevel(LogLevel level)
        {
            return level == LogLevel.Info;
        }

        public void Log(string message, Exception? exception)
        {
            Debug.WriteLine($"{DateTime.Now.ToLocalTime()} [INFO ] {message}@@@EVENT INFO @@@FOREGROUND FOREST.GREEN");
        }
    }
}
