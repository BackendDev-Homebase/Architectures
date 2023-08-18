using Layered2.DataAcess;

namespace Layered.DataAcess
{
    internal class DataAccessLayer : IDataAccessLayer
    {
        private static readonly string _path = Path.Combine(Environment.CurrentDirectory, "../../../../Data/usercounts.txt");

        public async Task StoreUserCounts(Dictionary<string, int> userCounts)
        {
            await File.WriteAllLinesAsync(_path, userCounts.Select(entry => $"{entry.Key} {entry.Value}"));
        }

        public async Task<Dictionary<string, int>> LoadUserCounts()
        {
            return (await File.ReadAllLinesAsync(_path))
                .ToDictionary(line => line.Split(' ')[0], line => int.Parse(line.Split(' ')[1]));
        }
    }
}
