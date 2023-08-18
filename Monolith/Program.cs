namespace Monolith
{
    internal class Program
    {
        private const string FILE_NAME = "usercounts.txt";

        static async Task Main()
        {
            var userCounts = (await File.ReadAllLinesAsync(FILE_NAME))
                .ToDictionary(line => line.Split(' ')[0], line => int.Parse(line.Split(' ')[1]));
            Console.WriteLine("Please enter your name:");
            var name = Console.ReadLine() ?? string.Empty;
            if (!userCounts.ContainsKey(name))
            {
                userCounts[name] = 1;
                Console.WriteLine($"Hello, {name}!");
            }
            else
            {
                userCounts[name]++;
                int count = userCounts[name];
                if (count <= 3)
                {
                    Console.WriteLine($"Welcome back, {name}!");
                }
                else
                {
                    Console.WriteLine($"Hello, my good friend {name}!");
                }
            }
            await File.WriteAllLinesAsync(FILE_NAME, userCounts.Select(entry => $"{entry.Key} {entry.Value}"));
        }
    }
}