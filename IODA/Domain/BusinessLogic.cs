using IODA.Data;

namespace IODA.Domain
{
    internal static class BusinessLogic
    {
        internal static string GetGreetingMessage(UserCounts userCounts, string name)
        {
            // Integration
            if (!userCounts.ExistsUser(name))
            {
                userCounts.Add(name);
                return GetGreetingMessage(0, name);
            }
            else
            {
                userCounts.Increase(name);
                int count = userCounts.GetCount(name);
                return GetGreetingMessage(count, name);
            }
        }

        private static string GetGreetingMessage(int count, string name)
        {
            // Operation
            return count switch
            {
                0 => $"Hello, {name}!",
                < 4 => $"Welcome back, {name}!",
                _ => $"Hello, my good friend {name}!"
            };
        }
    }
}
