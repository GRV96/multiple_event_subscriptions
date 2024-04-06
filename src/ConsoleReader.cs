namespace MultipleEventSubscriptions
{
    internal class ConsoleReader
    {
        private const string PROMPT = "> ";
        private const string STR_LOWER_Q = "q";
        private const string STR_UPPER_Q = "Q";

        public delegate void EventConsoleInput(string pInput);
        public event EventConsoleInput? consoleInput;

        private bool _isActive = false;

        public void Start()
        {
            if(_isActive)
            {
                return;
            }

            _isActive = true;

            while(_isActive)
            {
                Console.Write(PROMPT);
                string? input = Console.ReadLine();

                if (input == null)
                {
                    Stop();
                    break;
                }

                if (input == STR_LOWER_Q || input == STR_UPPER_Q)
                {
                    Stop();
                }

                TriggerConsoleInput(input);
                Console.WriteLine();
            }
        }

        public void Stop()
        {
            _isActive = false;
        }

        private void TriggerConsoleInput(string pInput)
        {
            if (consoleInput != null)
            {
                consoleInput(pInput);
            }
        }
    }
}
