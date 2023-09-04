using Layered.DataAcess;

namespace Layered.BusinesLogic
{
    internal class BusinessLogicLayer
    {
        internal async Task<string> GetGreetingMessage(string name)
        {
            var dal = new DataAcessLayer();
            var userCounts = await dal.LoadUserCounts();

            string greetingMessage;
            if (!userCounts.ContainsKey(name))
            {
                userCounts[name] = 1;
                greetingMessage = "Hello, {name}!";
            }
            else
            {
                userCounts[name]++;
                int count = userCounts[name];
                if (count <= 3)
                {
                    greetingMessage = $"Welcome back, {name}!";
                }
                else
                {
                    greetingMessage = $"Hello, my good friend {name}!";
                }
            }

            await dal.StoreUserCounts(userCounts);

            return greetingMessage;
        }
    }
}
