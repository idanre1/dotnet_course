namespace _02_covariance;

// Define the contravariant interface.
interface IStackPopper<out T>
{
    T Pop();
}

// Define the covariant interface.
interface IStackPusher<in T>
{
    void Push(T item);
}

// Define a Stack class with two interfaces.
public class Stack2<T> : IStackPopper<T>, IStackPusher<T>
{
    private readonly T[] _array;
    private int _index = 0;

    public Stack2(int ctor)
    {
        _array = new T[ctor];
    }

    public void Push(T item)
    {
        if (_index == _array.Length)
        {
            throw new InvalidOperationException("Stack is full");
        }

        _array[_index] = item;
        _index++;
    }

    public T Pop()
    {
        if (0 == _index)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        _index--;
        return _array[_index];
    }
}

