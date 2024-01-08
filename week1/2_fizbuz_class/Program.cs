// read n from command line
int n = int.Parse(args[0]);
// init abc with values 2,3
var abc = new Abc { Fizz = 2, Buzz = 3 };
// run abc
abc.Run(n);

// print line seprator
Console.WriteLine("----------");

var abc2 = new Abc { Fizz = 3, Buzz = 5 };
// run abc
abc2.Run(2*n);


class Abc
{
    public required int Fizz { get; init; }
    public int Buzz { get; init; } = 7;

    public void Run(int n)
    {
        // loop from 1 to n
        for (int i = 1; i <= n; i++)
        {
            // Write i
            Console.Write(i);
            Console.Write(" ");

            // if i is divisible by 3, print Fizz
            if (i % Fizz == 0)
            {
                Console.Write("Fizz");
            }
            // if i is divisible by 7, print Buzz
            if (i % Buzz == 0)
            {
                Console.Write("Buzz");
            }

            Console.WriteLine(" ");
        }
    }
}

