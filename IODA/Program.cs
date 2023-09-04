using IODA.Adapters.Portals;
using IODA.Adapters.Providers;

namespace IODA
{
    internal class Program
    {
        static async Task Main()
        {
            // Entry Point
            var ui = new UI();
            var da = new DataAccess();
            var app = new Controller(ui, da);

            await app.Run();
        }
    }
}
