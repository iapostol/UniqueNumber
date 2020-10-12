using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueNumber
{
    public class Unique
    {
        public static int From(IEnumerable<int> numbers)
        {
            if (numbers.Count() < 3)
                throw new ArgumentOutOfRangeException();

            return 0;
        }
    }
}