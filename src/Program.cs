namespace MultipleEventSubscriptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nbSubscriptions = 1;
            if(args.Length >= 1)
            {
                if(!Int32.TryParse(args[0], out nbSubscriptions))
                {
                    nbSubscriptions = 1;
                }
            }

            ConsoleReader reader = new ConsoleReader();

            for(int i=0; i<nbSubscriptions; i++)
            {
                reader.consoleInput += Console.WriteLine;
            }

            reader.Start();
            Console.WriteLine();
        }
    }
}
