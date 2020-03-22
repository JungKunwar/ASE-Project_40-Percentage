using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphical_Programming_Language_Application
{  
    class Polygon : Shape
    {
        int size1, size2, size3, size4, size5, size6, size7, size8, size9, size10;
        Color c1;
        int texturestyle;
        Brush bb;
        public override void draw(Graphics g)
        {
            Pen p = new Pen(c1, 5);
            Point[] points = { new Point(size1, size2), new Point(size3, size4), new Point(size5, size6), new Point(size7, size8), new Point(size9, size10) };

            if (texturestyle == 0)
            {
                g.DrawPolygon(p, points);
            }
            else
            {
                g.FillPolygon(bb, points);
            }
        }

     
    }
}
