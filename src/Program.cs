namespace MultipleEventSubscriptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nbSubscriptions = 1;
            if(args.Length >= 1)
            {
                Int32.TryParse(args[0], out nbSubscriptions);
            }

            ConsoleReader reader = new ConsoleReader();

            for(int i=0; i<nbSubscriptions; i++)
            {
                reader.consoleInput += ProcessConsoleInput;
            }

            reader.Start();
        }

        private static void ProcessConsoleInput(string pInput)
        {
            Console.WriteLine(pInput);
        }
    }
}
