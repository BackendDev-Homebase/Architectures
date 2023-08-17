using Layered.BusinesLogic;
using Layered.DataAcess;
using Layered2.Presentation;

namespace Layered2
{
    internal class Program
    {
        static async Task Main()
        {
            var ui = new PresentationLayer(new BusinessLogicLayer(new DataAcessLayer()));
            await ui.Greet();
        }
    }
}