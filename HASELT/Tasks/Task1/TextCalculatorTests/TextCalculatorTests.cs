using System;
using Xunit;
using Task1;

namespace TextCalculatorTests
{
    public class TextCalculatorTests
    {
        [Fact]
        public void Finishes_On_Comma()
        {
            TextCalculator t = new TextCalculator();

            Assert.Equal("Missing number in last position", t.Add("1,2,"));
        }

        [Fact]
        public void Too_Many_Elements()
        {
            TextCalculator t = new TextCalculator();

            Assert.Equal("Too many elements!", t.Add("1,2,3,4,-5"));
        }

        [Fact]
        public void Add_With_Chars()
        {
            TextCalculator t = new TextCalculator();

            Assert.Equal("Characters not allowed!", t.Add("1, 3, a"));
        }

        [Fact]
        public void Negative_One_Element()
        {
            TextCalculator t = new TextCalculator();

            Assert.Equal("Negative not allowed: -5", t.Add("1, 3, -5"));
        }

        [Fact]
        public void Negative_Two_Elements()
        {
            TextCalculator t = new TextCalculator();

            Assert.Equal("Negative not allowed: -3, -5", t.Add("1, -3, -5"));
        }

        [Fact]
        public void Add_Two_Elements()
        {
            TextCalculator t = new TextCalculator();

            Assert.Equal("4", t.Add("1, 3"));
        }

        [Fact]
        public void Add_Three_Elements()
        {
            TextCalculator t = new TextCalculator();

            Assert.Equal("12", t.Add("1, 3, 8"));
        }
    }
}
