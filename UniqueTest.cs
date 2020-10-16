using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace UniqueNumber
{
    public class UniqueTest
    {

        [Theory]
        [InlineData(new int[] { 0 })]
        [InlineData(new int[] { 0, 0 })]
        public void OutOfRange(IEnumerable<int> numbers)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Unique.From(numbers));
        }

        [Theory]
        [InlineData(0, new int[] { 0, 0, 0 })]
        [InlineData(1, new int[] { 1, 1, 1 })]
        [InlineData(10, new int[] { 10, 10, 10, 10, 10, 10 })]
        public void AllEqual(int unique, IEnumerable<int> numbers)
        {
            Assert.Equal(unique, Unique.From(numbers));
        }

        [Theory]
        [InlineData(1, new int[] { 0, 0, 1 })]
        [InlineData(1, new int[] { 1, 2, 2 })]
        [InlineData(1, new int[] { 2, 1, 2 })]
        [InlineData(1, new int[] { 2, 2, 1 })]
        [InlineData(2, new int[] { 1, 1, 1, 2, 1, 1 })]
        [InlineData(9, new int[] { 10, 10, 10, 10, 9, 10, 10, 10 })]
        public void OneDistinct(int unique, IEnumerable<int> numbers)
        {
            Assert.Equal(unique, Unique.From(numbers));
        }
    }
}
