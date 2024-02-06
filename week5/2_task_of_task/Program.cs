using Dumpify;

Main();

void Main()
{
    var task = Task.Factory.StartNew(() =>
    {
        "Before outer".Dump();
        Thread.Sleep(3000);
        "After outer".Dump();
        return Task.Run(() =>
        {
            "Before inner".Dump();
            Thread.Sleep(2000);
            "After inner".Dump();
        });
    //});
    }).Unwrap();

"Started waiting".Dump();
    task.Wait();
    "Finished waiting".Dump();

}