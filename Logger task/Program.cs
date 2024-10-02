using LoggerLibrary;

class Program
{
    static void Main()
    {
        ILogger consoleLogger = new Logger();
        ILogger dbLogger = new Logger(LoggerDestination.Database);
        ILogger textFileLogger = new Logger(LoggerDestination.TextFile);

        ILogger[] arr = new ILogger[] {
            dbLogger,
            consoleLogger,
        };

        foreach (var item in arr)
        {
            item.Info("info test");
            item.Error("error test");
            item.Warning("warning test");
            item.Error(new Exception("test error"));
        }

        Console.ReadKey();
    }
}
