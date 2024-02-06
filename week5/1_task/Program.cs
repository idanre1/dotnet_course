using Dumpify;

// read text files
string[] files = [
    @"../../../file.txt", // @ is used to escape the backslash. (used in paths strings)
    @"../../../file.txt",
    @"../../../file.txt",
];

// Simple way
var tasks = files.Select(file => Task.Run(() => File.ReadAllTextAsync(file)))
    .ToArray();

var doneTask = Task.WhenAll(tasks);
doneTask.Wait();

var result = tasks.Aggregate("", (str, current) => $"{str}{current.Result}");
result.Dump();

// Linq way
var tasks2 = files.Select(file => File.ReadAllTextAsync(file))
    .Whenall()
    .Result
    .Aggregate("", (str, current) => $"{str}{current}")
    .Dump();

// Add conbine WhenAll and Result (WaitAll extension)
var tasks3 = files.Select(file => File.ReadAllTextAsync(file))
    .Waitall()
    .Aggregate("", (str, current) => $"{str}{current}")
    .Dump();

public static class Extensions
{
    public static Task<T[]> Whenall<T>(this IEnumerable<Task<T>> sources)
        => Task.WhenAll(sources);

    public static T[] Waitall<T>(this IEnumerable<Task<T>> sources)
        => sources.Whenall().Result;
}