using System.Collections;

using _1_linq;

var enm = new GenerateEvenNumbers(30);

var result = enm.Where(x => x % 4 == 0)
    .Select(i => i.ToString())
    .Aggregate("",(result, i) => $"{result}, {i}");

Console.WriteLine(result);