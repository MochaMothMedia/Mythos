namespace Mythos.ConsoleLauncher.Logging
{
	public interface ILogger
	{
		bool MatchesLogLevel(LogLevel level);
		void Log(string message, Exception? exception);
	}
}
