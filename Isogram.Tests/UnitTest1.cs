using System;
using Xunit;
using Isogram;

namespace Isogram.Tests
{
    public class isogramTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(isogram.isIsogram(""));
        }

        [Fact]
        public void Test2()
        {
            Assert.True(isogram.isIsogram("isogram"));
        }

        [Fact]
        public void Test3()
        {
            Assert.False(isogram.isIsogram("eleven"));
        }

        [Fact]
        public void Test4()
        {
            Assert.True(isogram.isIsogram("subdermatoglyphic"));
        }

        [Fact]
        public void Test5()
        {
            Assert.True(isogram.isIsogram("Alphabet"));
        }

        [Fact]
        public void Test6()
        {
            Assert.True(isogram.isIsogram("thumbscrew-japingly"));
        }

        [Fact]
        public void Test7()
        {
            Assert.True(isogram.isIsogram("six-year-old"));
        }

        [Fact]
        public void Test8()
        {
            Assert.True(isogram.isIsogram("Old Monk"));
        }
    }
}
