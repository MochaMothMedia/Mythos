namespace Mythos.Core.Logging
{
	public interface ILog
	{
		void LogInfo(string message);
		void LogWarning(string message);
		void LogError(string message, Exception? exception = null);
		void LogFatal(string message, Exception exception);
	}
}
