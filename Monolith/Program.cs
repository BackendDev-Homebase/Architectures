namespace Monolith
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            if (!File.Exists(args[0]))
            {
                await File.Create(args[0]).DisposeAsync();
            }
            var userCounts = (await File.ReadAllLinesAsync(args[0])).ToDictionary(line => line.Split(' ')[0], line => int.Parse(line.Split(' ')[1]));
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
            await File.WriteAllLinesAsync(args[0], userCounts.Select(entry => $"{entry.Key} {entry.Value}"));
        }
    }
}