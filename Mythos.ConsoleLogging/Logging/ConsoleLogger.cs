using Mythos.Core.Logging;

namespace Mythos.ConsoleLogging
{
	public class ConsoleLogger : ILog
	{
		private readonly LoggerFactory _logger;

		public ConsoleLogger(LoggerFactory logger)
		{
			_logger = logger;
		}

		public void LogInfo(string message) => _logger.Log(message, LogLevel.Info);
		public void LogWarning(string message) => _logger.Log(message, LogLevel.Warning);
		public void LogError(string message, Exception? exception = null) => _logger.Log(message, LogLevel.Error, exception);
		public void LogFatal(string message, Exception exception) => _logger.Log(message, LogLevel.Fatal, exception);
	}
}
