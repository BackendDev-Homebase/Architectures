using IODA.Adapters.Portals.Controllers;
using IODA.Adapters.Portals.Dialogs;
using IODA.Adapters.Providers;

namespace IODA
{
    internal class Program
    {
        static async Task Main()
        {
            var ui = new UI();
            var da = new DataAccess();
            var app = new Controller(ui, da);

            await app.Run();
        }
    }
}
