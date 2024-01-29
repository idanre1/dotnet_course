using System.Collections;

foreach (var i in GenerateEvenNumbers(10))
{
    Console.WriteLine(i);
}

// The => syntax is called the lambda operator in C#. It is used to define a lambda expression
// The expression => $"{FirstName} {LastName}" is equivalent to the following method definition:
// public string FullName
// {
//     get
//     {
//         return $"{FirstName} {LastName}";
//     }
// }

// IEnumerable is an interface that defines one method GetEnumerator which returns an IEnumerator interface.
// IEnumerator interface allows readonly access to a collection.
//
//  A collection that implements IEnumerable can be used with a foreach statement.

IEnumerable<int> GenerateEvenNumbers(int limit)
    => new EvenNumberEnumerable(limit);

// IEnumerable is a generic interface
// IEnumerable<int> means that the GetEnumerator method returns IEnumerator<int>
public struct EvenNumberEnumerable : IEnumerable<int>
{
    private readonly int _limit;

    // The constructor
    public EvenNumberEnumerable(int limit)
      =>  _limit = limit;

    // The GetEnumerator method
    // This method is required by the IEnumerable interface
    // Generic implementation
    public IEnumerator<int> GetEnumerator()
    {
        return new EvenNumberEnumerator(_limit);
    }

    // The IEnumerable.GetEnumerator method
    // Non-generic implementation
    // 
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

// IEnumerator is a generic interface
// IEnumerator<int> means that the Current property returns int
public struct EvenNumberEnumerator : IEnumerator<int>
{
    private readonly int _limit;
    private int _current;

    // The constructor
    public EvenNumberEnumerator(int limit)
    // Same as:  => (_limit, _current) = (limit, -2);
    {
        _limit = limit;
        _current = -2;
    }

    // The Current property
    // This property is required by the IEnumerator interface
    public int Current
    {
        get
        {
            return _current;
        }
    }

    // The IEnumerator.Current property
    // This property is required by the IEnumerator interface
    // IEnumerator.Current is a non-generic property
    // IEnumerator.Current returns object
    // IEnumerator.Current is a non-generic property because IEnumerator is a non-generic interface
    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    // The MoveNext method
    // This method is required by the IEnumerator interface
    public bool MoveNext()
    {
        _current += 2;
        return _current <= _limit;
    }

    // The Reset method
    // This method is optional by the IEnumerator interface
    public void Reset()
    {
        _current = -2;
    }

    public void Dispose()
    {
        
    }

}