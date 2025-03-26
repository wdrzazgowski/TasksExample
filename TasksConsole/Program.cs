// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;

IList<int> intNums = Enumerable.Range(1, 2000000).ToList();

var stopWatch = Stopwatch.StartNew();
var primesForEach = GetPrimeNumbersForEach(intNums);
stopWatch.Stop();

var stopWatchParallel = Stopwatch.StartNew();
var primesForEachParallel = GetPrimeNumbersForEachParallel(intNums);
stopWatchParallel.Stop();

Console.WriteLine($"Time taken for ForEach: {stopWatch.ElapsedMilliseconds} ms");
Console.WriteLine($"Time taken for ForEach Parallel: {stopWatchParallel.ElapsedMilliseconds} ms");

Console.WriteLine($"Press Enter to exit");
Console.ReadLine();

static IList<int> GetPrimeNumbersForEach(IList<int> numbers) => numbers.Where(IsPrime).ToList();

static IList<int> GetPrimeNumbersForEachParallel(IList<int> numbers)
{
    var primeNumbers = new ConcurrentBag<int>();

    Parallel.ForEach(numbers, number =>
    {
        if (IsPrime(number))
        {
            primeNumbers.Add(number);
        }
    });

    return primeNumbers.ToList();
}

static bool IsPrime(int number)
{
    if(number < 2)
        return true;

    for(var divisor = 2; divisor <= Math.Sqrt(number); divisor++)
    {
        if(number % divisor == 0)
            return false;
    }

    return true;
}
