namespace Singleton;

public class Logger
{
    private static readonly Lazy<Logger> _LazyLogger = new(() => new Logger());
    
    public static Logger Instance => _LazyLogger.Value;

    public void Log(string message)
    {
        Console.WriteLine($"Mesage to log: {message}");
    }
}