using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using Graphical_Programming_Language_Application;

namespace Graphical_Design_Software.UnitTest
{
    [TestClass]
    public class RectangleTest
    {
        int texturestyle;
        Brush bb;
        Color c1 = Color.Black;

        [TestMethod]
        public void TestMethod1()
        {
            var r = new Graphical_Programming_Language_Application.Rectangle(); 
            int x = 200, y = 200, size = 100, size1 = 100;
            r.set(texturestyle, bb, c1, x, y, size, size1); 
            Assert.AreEqual(200, r.x); 
        }
    }
}
