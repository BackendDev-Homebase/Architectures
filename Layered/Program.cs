using Layered.Presentation;

namespace Layered
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var ui = new PresentationLayer();
            ui.Greet();
        }
    }
}