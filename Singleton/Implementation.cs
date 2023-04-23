// ReSharper disable MemberCanBeMadeStatic.Global
namespace Singleton;

public class Logger
{
    // Ensures thread safety
    private static readonly Lazy<Logger> LazyLogger = new(() => new Logger());
    
    public static Logger Instance => LazyLogger.Value;

    public void Log(string message)
    {
        Console.WriteLine($"Message to log: {message}");
    }
}