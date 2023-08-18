namespace IODA.Data
{
    internal class UserCounts
    {
        private Dictionary<string, int> _userCounts;

        private UserCounts()
        {
            // Operation
            _userCounts = new Dictionary<string, int>();
        }

        internal static UserCounts Create(string[] lines)
        {
            // Integration
            var result = new UserCounts();
            result.Initialize(lines);
            return result;
        }

        private void Initialize(string[] lines)
        {
            // Operation
            _userCounts = lines.ToDictionary(line => line.Split(' ')[0], line => int.Parse(line.Split(' ')[1]));
        }

        internal string[] ToLines()
        {
            // Operation
            return _userCounts.Select(entry => $"{entry.Key} {entry.Value}")
                .ToArray();
        }

        internal bool ExistsUser(string user)
        {
            // Operation
            return _userCounts.ContainsKey(user);
        }

        internal int GetCount(string user)
        {
            // Operation
            return _userCounts[user];
        }

        internal void Increase(string user)
        {
            // Operation
            _userCounts[user] += 1;
        }

        internal void Add(string name)
        {
            // Operation
            _userCounts.Add(name, 1);
        }
    }
}
