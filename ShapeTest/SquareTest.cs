using NUnit.Framework;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Shape.Tests
{
    [TestClass]
    public class SquareTests
    {

        [TestMethod]
        public void CheckArea()
        {
            //arrange
            int x = 10;
            int expected = 100;

            //act
            Square c = new Square(x);
            double actual = c.CalculateArea();

            //assert
            NUnit.Framework.Assert.AreEqual(expected, actual);

        }
        public void CheckPerimeter()
        {
            int x = 10;
            double expected = 40;

            Square c = new Square(x);
            double actual = c.CalculatePerimeter();

            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

    }
}
