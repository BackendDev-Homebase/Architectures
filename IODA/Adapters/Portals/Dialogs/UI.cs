namespace IODA.Adapters.Portals.Dialogs
{
    internal class UI
    {
        internal string GetName()
        {
            // Operation
            Display("Please enter your name:");
            var name = Console.ReadLine() ?? string.Empty;
            return name;
        }

        internal void Display(string message)
        {
            // Operation
            Console.WriteLine(message);
        }
    }
}
