namespace Layered.DataAcess
{
    internal class DataAcessLayer
    {
        internal async Task StoreUserCountsAsync(Dictionary<string, int> userCounts)
        {
            await File.WriteAllLinesAsync("usercounts.txt", userCounts.Select(entry => $"{entry.Key} {entry.Value}"));
        }

        internal async Task<Dictionary<string, int>> LoadUserCounts()
        {
            return (await File.ReadAllLinesAsync("usercounts.txt")).ToDictionary(line => line.Split(' ')[0], line => int.Parse(line.Split(' ')[1]));
        }
    }
}
