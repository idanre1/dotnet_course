/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/

namespace _02_covariance;

public class Stack1<T>(int ctor)
{
    private readonly T[] _array = new T[ctor];
    private int _index = 0;

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
