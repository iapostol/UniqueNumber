using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueNumber
{
    public class Unique
    {
        public static int From(IEnumerable<int> numbers)
        {
            var list = numbers.ToList();

            int count = numbers.Count();

            if (count < 3)
                throw new ArgumentOutOfRangeException();

            double sum = 0;

            for (int i = 0; i < count - 1; i++)
            {
                sum += list[i];

                if (list[i] == sum / (i + 1))
                    continue;

                return list[i] == list[i + 1] ? list[i - 1] : list[i];
            }

            return list[count - 1];
        }
    }
}