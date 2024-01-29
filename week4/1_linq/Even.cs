using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_linq;

class GenerateEvenNumbers(int limit) : IEnumerable<int>
{
    // The GetEnumerator method
    // Generic implementation
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < limit; i++)
        {
            if (i % 2 == 0)
            {
                yield return i;
            }
        }
    }

    // Non-generic implementation
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
