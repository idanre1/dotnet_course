/*
Part 1

Implement Stack<T>
•
Allocate an array in the constructor (length is a ctorparameter)
•
Implement the following methods
•
void Push(Titem);
•
T Pop();
•
Test your implementation

Part 2

Implement Covariance and Contravariance
•
Create an interface called `IStackPopper` for Covariance
•
Create an interface called `IStackPusher` for ContraVariance
*/
using _02_covariance;

// Part 1
var stack = new Stack1<int>(10);
stack.Push(1);
stack.Push(2);

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

// Part 2
// Define two stacks
// B inherited from A
var stack_b = new Stack2<B>(10);
var stack_a = new Stack2<A>(10);

// Instatiate Covariance and Contravariance
IStackPopper<A> ib = stack_b;
IStackPusher<B> ia = stack_a;

// Example of Covariance
// Pushing B into A
stack_a.Push(new A());
stack_a.Push(new B());
stack_a.Push(new B());

A a1 = stack_a.Pop();
Console.WriteLine(a1.GetType());
A a2 = stack_a.Pop();
Console.WriteLine(a2.GetType());
A a3 = stack_a.Pop();
Console.WriteLine(a3.GetType());

// Example of Contravariance
// Poping A from B
stack_b.Push(new B()); // compilation error: stack_b.Push(new A());
stack_b.Push(new B());
stack_b.Push(new B());
A b1 = stack_b.Pop();
Console.WriteLine(b1.GetType());


// Inheritance
public class A;
public class B : A;
