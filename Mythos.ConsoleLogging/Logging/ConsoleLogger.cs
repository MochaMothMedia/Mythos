using Mythos.Core.Logging;
using Mythos.Core.RequestMetadata;

namespace Mythos.ConsoleLogging
{
	public class ConsoleLogger : ILog
	{
		private readonly LoggerFactory _logger;
		private readonly IManageRequestMetadata _metadataManager;

		public ConsoleLogger(LoggerFactory logger, IManageRequestMetadata metadataManager)
		{
			_logger = logger;
			_metadataManager = metadataManager;

			_logger.Log($"New request received with Request ID: '{_metadataManager.RequestId}'", LogLevel.Info);
		}

		public void LogInfo(string message) => _logger.Log($"{_metadataManager.RequestId} - {message}", LogLevel.Info);
		public void LogWarning(string message) => _logger.Log($"{_metadataManager.RequestId} - {message}", LogLevel.Warning);
		public void LogError(string message, Exception? exception = null) => _logger.Log($"{_metadataManager.RequestId} - {message}", LogLevel.Error, exception);
		public void LogFatal(string message, Exception exception) => _logger.Log($"{_metadataManager.RequestId} - {message}", LogLevel.Fatal, exception);
	}
}
