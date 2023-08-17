using Layered.Presentation;

namespace Layered
{
    internal class Program
    {
        static async Task Main()
        {
            var ui = new PresentationLayer();
            ui.Greet();
        }
    }
}