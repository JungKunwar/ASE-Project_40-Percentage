using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using Graphical_Programming_Language_Application;

namespace Graphical_Design_Software.UnitTest
{
    [TestClass]
    public class LineTestforPart2
    {

        int texturestyle;
        Brush bb;
        Color c1 = Color.Black;
        [TestMethod]
        public void setParameterTest()
        {
            var l = new Line();
            int x = 200, y = 200, size = 200, size1 = 200;
            l.set(texturestyle, bb, c1, x, y, size, size1);
            Assert.AreEqual(200, l.x);

        }
    }
}

