using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shape.Tests
{
    public class CircleTests
    {
        [TestMethod]
        public void CheckArea()
        {
            int x = 10;
            double expected = 3.14 * x * x;

            Circle c = new Circle(x);
            double actual = c.CalculateArea();

            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
        public void CheckPerimeter()
        {
            int x = 10;
            double expected = 2 * 3.14 * x;

            Circle c = new Circle(x);
            double actual = c.CalculatePerimeter();

            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

    }
}
