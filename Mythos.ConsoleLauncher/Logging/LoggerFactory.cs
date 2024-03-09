namespace Mythos.ConsoleLauncher.Logging
{
	public class LoggerFactory
	{
		private readonly IEnumerable<ILogger> _loggers;

		public LoggerFactory(IEnumerable<ILogger> loggers)
		{
			_loggers = loggers;
		}

		public void Log(string message, LogLevel logLevel, Exception? exception = null)
		{
			_loggers.First(logger => logger.MatchesLogLevel(logLevel)).Log(message, exception);
		}
	}
}
