using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibShapes;

namespace UnitTestShapes
{
    [TestClass]
    public class UnitTestShape
    {
        [TestMethod]
        public void TestCircle()
        {
            Shape circle = new Shape(10);
            double check = 314;
            Assert.AreEqual(check, circle.getArea());
          
        }
        [TestMethod]
        public void TestErrorCircle()
        {         
            Shape errorcircle = new Shape();
            double check = 0;
            Assert.AreEqual(0, errorcircle.getArea());
        }
        [TestMethod]

        public void TestTriangle()
        {
            Shape triangle = new Shape(10,10,12);
            double check = 48;
            Assert.AreEqual(check, triangle.getArea());
        }
        [TestMethod]
        public void TestErrorTriangle()
        {
            Shape triangle = new Shape(2,3);
            double check = 0;
            Assert.AreEqual(check, triangle.getArea());
        }


    }
}
