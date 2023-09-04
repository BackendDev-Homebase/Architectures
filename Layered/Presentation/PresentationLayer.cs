using Layered.BusinesLogic;

namespace Layered.Presentation
{
    internal class PresentationLayer
    {
        internal void Greet()
        {
            Console.WriteLine("Please enter your name:");
            var name = Console.ReadLine() ?? string.Empty;
            var bll = new BusinessLogicLayer();
            var greetingMessage = bll.GetGreetingMessage(name);
            Console.WriteLine(greetingMessage);
        }
    }
}
