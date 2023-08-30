using IODA.Adapters.Providers;
using IODA.Data;
using IODA.Domain;

namespace IODA.Adapters.Portals
{
    internal class Controller
    {
        private readonly UI _ui;
        private readonly DataAccess _da;

        internal Controller(UI ui, DataAccess da)
        {
            // Operation
            _ui = ui;
            _da = da;
        }

        internal async Task Run()
        {
            // Integration
            var lines = await _da.Load();
            var userCounts = UserCounts.Create(lines);

            var name = _ui.GetName();
            string message = BusinessLogic.GetGreetingMessage(userCounts, name);
            _ui.Display(message);

            lines = userCounts.ToLines();
            await _da.Store(lines);
        }
    }
}
