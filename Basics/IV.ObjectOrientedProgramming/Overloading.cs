namespace IV.ObjectOrientedProgramming
{
    public class ConsoleErrorWriter
    {
        public void WriteToConsole(string msg)
        {
            Console.WriteLine(msg);

        }

        public void WriteToConsole(string msg, int errorLevel)
        {
            if (errorLevel == 2)
            {
                Console.WriteLine("This is warning");
            }
            else
            {
                Console.WriteLine("This is general error");
            }
        }
    }
}