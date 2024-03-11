namespace Mythos.ConsoleLogging
{
	public interface ILogger
	{
		bool MatchesLogLevel(LogLevel level);
		void Log(string message, Exception? exception);
	}
}
