using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace UniqueNumber
{
    public class UniqueTest
    {

        [Fact]
        public void TestOneNumber()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Unique.From(new int[] { 1 }));
        }

        [Fact]
        public void TestTwoNumbers()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Unique.From(new int[] { 1, 1 }));
        }

        [Theory]
        [InlineData(1, new int[] { 0, 0, 1 })]
        public void TestMoreThanTwoNumbers(int unique, IEnumerable<int> numbers)
        {
            Assert.Equal(unique, Unique.From(numbers));
        }
    }
}
