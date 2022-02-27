using Xunit;

using FibonacciSeries;
using System.Collections.Generic;

namespace Tests;
public class UnitTest1
{
    [Theory]
    [InlineData(2, new long[] { 0, 1 })]
    [InlineData(4, new long[] { 0, 1, 1, 2 })]
    [InlineData(10, new long[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 })]
    public void TestingForRanges(int x, long[] series)
    {
        var expected = new List<long>(series);

        var theUnitTest = new Class1();

        var actual = theUnitTest.printFibonacciNumber(x);
        // Assert
        Assert.Equal(expected, actual);
    }
}