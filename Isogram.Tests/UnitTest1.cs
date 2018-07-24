using System;
using Xunit;

namespace Isogram.Tests
{
    public class isogramTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Isogram.isIsogram(""));
        }

        [Fact]
        public void Test2()
        {
            Assert.True(Isogram.isIsogram("isogram"));
        }

        [Fact]
        public void Test3()
        {
            Assert.False(Isogram.isIsogram("eleven"));
        }

        [Fact]
        public void Test4()
        {
            Assert.True(Isogram.isIsogram("subdermatoglyphic"));
        }

        [Fact]
        public void Test5()
        {
            Assert.True(Isogram.isIsogram("Alphabet"));
        }

        [Fact]
        public void Test6()
        {
            Assert.True(Isogram.isIsogram("thumbscrew-japingly"));
        }

        [Fact]
        public void Test7()
        {
            Assert.True(Isogram.isIsogram("six-year-old"));
        }

        [Fact]
        public void Test8()
        {
            Assert.True(Isogram.isIsogram("Old Monk"));
        }
    }
}
