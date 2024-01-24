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
ia.Push(new B());
stack_a.Push(new B());
A a = stack_a.Pop();

// Example of Contravariance
// Poping A from B
var b = (B)stack_a.Pop();

// Inheritance
public class A;
public class B : A;
