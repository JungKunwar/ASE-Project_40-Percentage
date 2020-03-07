using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using Graphical_Programming_Language_Application;

namespace Graphical_Design_Software.UnitTest
{
    [TestClass]
    public class CircleTest
    {
        int texturestyle;
        Brush bb;
        Color c1 = Color.Black;

        [TestMethod]
        public void TestMethod1()
        {
            var c = new Graphical_Programming_Language_Application.Circle();
            int x = 100, y = 100, size = 150, size1 = 150;
            c.set(texturestyle, bb, c1, x, y, size, size1);
            Assert.AreEqual(100, c.x);
        }
    } 
}
