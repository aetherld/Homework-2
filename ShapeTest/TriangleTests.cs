using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;


namespace Shape.Tests
{
    public class TriangleTests
    {
        [TestMethod]
        public void CheckArea()
        {
            int x = 10;
            int y = 5;
            int z = 10;
            int f = 5; // height
            double expected = 25;

            Triangle c = new Triangle(x, y, z, f);
            double actual = c.CalculateArea();

            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
        public void CheckPerimeter()
        {
            int x = 10;
            int y = 10;
            int z = 10;
            int f = 5; // height
            double expected = 30;

            Triangle c = new Triangle(x, y, z, f);
            double actual = c.CalculatePerimeter();

            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
    }
}
