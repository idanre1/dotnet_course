// See https://aka.ms/new-console-template for more information

// Read param n from cmd line
int n = int.Parse(args[0]);

// loop from 1 to n
for (int i = 1; i <= n; i++)
{
    // if i is divisible by 3 and 7, print FizzBuzz
    if (i % 3 == 0 && i % 7 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    // if i is divisible by 3, print Fizz
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    // if i is divisible by 7, print Buzz
    else if (i % 7 == 0)
    {
        Console.WriteLine("Buzz");
    }
    // else print i
    else
    {
        Console.WriteLine(i);
    }
}

