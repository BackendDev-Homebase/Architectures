namespace IODA.Adapters.Providers
{
    internal class DataAccess
    {
        private static readonly string _path = Path.Combine(Environment.CurrentDirectory, "../../../../Data/usercounts.txt");

        internal async Task<string[]> Load()
        {
            // Operation
            var result = await File.ReadAllLinesAsync(_path);
            return result;
        }

        internal async Task Store(string[] lines)
        {
            // Operation
            await File.WriteAllLinesAsync(_path, lines);
        }
    }
}
