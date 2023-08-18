namespace IODA.Adapters.Dialogs
{
    internal class UI
    {
        internal string GetName()
        {
            // Integration
            Display("Please enter your name:");
            var name = Console.ReadLine() ?? string.Empty;
            return name;
        }

        internal void Display(string message)
        {
            // Integration
            Console.WriteLine(message);
        }
    }
}
