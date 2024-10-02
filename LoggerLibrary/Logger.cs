namespace LoggerLibrary
{
    public class Logger : ILogger
    {
        private readonly LoggerDestination _destination = LoggerDestination.Console;

        public LoggerDestination Destination
        {
            get
            {
                return _destination;
            }
        }

        private readonly string textFileName = "some text file name";

        private readonly string dbName = "some db name as well";

        public Logger() { }

        public Logger(LoggerDestination destination)
        {
            this._destination = destination;
        }

        public void Error(string message)
        {
            this.WriteLogs(message);
        }

        public void Error(Exception ex)
        {
            this.WriteLogs(ex.Message);
        }

        public void Info(string message)
        {
            this.WriteLogs(message);
        }

        public void Warning(string message)
        {
            this.WriteLogs(message);
        }

        private void WriteLogs(string message)
        {
            switch (this._destination)
            {
                case LoggerDestination.Console:
                {
                    Console.WriteLine($"Writing to {_destination}");
                    Console.WriteLine(message);

                    break;
                }
                case LoggerDestination.TextFile:
                {
                    Console.WriteLine($"Writing to {_destination}: {textFileName}");
                    Console.WriteLine(message);

                    break;
                }
                case LoggerDestination.Database:
                {
                    Console.WriteLine($"Writing to {_destination}: {dbName}");
                    Console.WriteLine(message);

                    break;
                }
            }
        }
    }
}
