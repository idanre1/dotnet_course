/*
Implement a WithTimeoutExtension method
TaskWithTimeout(thisTasktask,TimeSpantimeout)
•
If the task takes more than the given timeout timespan to complete
•
Throw a TimeoutException
•
Use CancellationTokenwhen/if necessary
 */
await Main();

async Task Main()
{
    var task  = Task.Delay(TimeSpan.FromSeconds(5));
    await task.WithTimeout(TimeSpan.FromSeconds(3));
}
public static class WithTimeoutExtension
{
    public static async Task WithTimeout(this Task task, TimeSpan timeout)
    {
        var result = await Task.WhenAny(task, Task.Delay(timeout));
        if (result != task)
        {
            throw new TimeoutException();
        }
        
        // Because its a async that returns Task the syntax sugar auto return task
    }
}
