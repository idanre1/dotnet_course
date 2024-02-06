using System.Diagnostics;
using System.Threading;
using Dumpify;

Foo();

void Foo()
{
    /*
    using (new TimerContext())
    {
        Thread.Sleep(TimeSpan.FromSeconds(3));
        Bar();
    }
    */
    using var watch = new TimerContext();
    Thread.Sleep(TimeSpan.FromSeconds(3));
    Bar();
}

void Bar()
{
    Console.WriteLine("Bar");
}

class TimerContext : IDisposable
{
    private readonly Stopwatch _stopwatch = Stopwatch.StartNew();

    /*
     * Not needed, since we can use Stopwatch.StartNew() to start
    public TimerContext()
    {
        _stopwatch = new Stopwatch();
        _stopwatch.Start();
    }
    */

    public void Dispose()
    {
        _stopwatch.Stop();
        //Console.WriteLine($"Elapsed time: {_stopwatch.Elapsed}");
        _stopwatch.Elapsed.Dump();
    }
}
