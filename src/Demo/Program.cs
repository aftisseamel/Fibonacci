using System.Diagnostics;
using Leonardo;

var stopwatch = new Stopwatch();
stopwatch.Start();
var results = new List<Task<FibonacciResult>>();
foreach (var input in args)
{
    var int32 = Convert.ToInt32(input);
    var r = Task.Run(() =>
    {
        var result = Fibonacci.Run(int32);
        return new FibonacciResult(int32, result);
    });
    results.Add(r);
}

Task.WaitAll(results.ToArray());
stopwatch.Stop();
Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds}ms");
foreach (var result in results)
{
    Console.WriteLine($"Fibonacci of {result.Result.Input} is {result.Result}");
}