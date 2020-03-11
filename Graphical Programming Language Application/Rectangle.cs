using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphical_Programming_Language_Application
{
   public class Rectangle: Shape
    {
       public int x, y, size, size1;
         int texturestyle;
        Brush bb;
        Color c1;
        /// <summary>
        /// getting value of Graphics g
        /// </summary>
        /// <param name="g"></param>
        public override void draw(Graphics g)
        {
            Pen p = new Pen(c1, 5);
            if (texturestyle == 0)
            {
                g.DrawRectangle(p, x, y, size, size1);
            }
            else
            {
                g.FillRectangle(bb, x, y, size, size1);
            }
            
        }



       
