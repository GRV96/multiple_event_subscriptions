namespace MultipleEventSubscriptions
{
    internal class Program
    {
        private static string NEW_LINE = "\n";

        static void Main(string[] args)
        {
            ConsoleReader reader = new ConsoleReader();
            reader.consoleInput += ProcessConsoleInput;
            //reader.consoleInput += ProcessConsoleInput;
            reader.Start();
        }

        private static void ProcessConsoleInput(string pInput)
        {
            Console.WriteLine(pInput + NEW_LINE);
        }
    }
}
