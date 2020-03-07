using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Graphical_Programming_Language_Application
{
    public class Triangle : Shape
    {
      public  int xi1, yi1, xi2, yi2, xii1, yii1, xii2, yii2, xiii1, yiii1, xiii2, yiii2;
        Color c1;
        int texturestyle;
        Brush bb;
        public override void draw(Graphics g)
        {
            Pen p = new Pen(c1, 5);

            //----------------------------------------------------------------------------------------------------------------------
            g.DrawLine(p, xi1, yi1, xi2, yi2);
            g.DrawLine(p, xii1, yii1, xii2, yii2);
            g.DrawLine(p, xiii1, yiii1, xiii2, yiii2);
            //---------------------------------------------------------------------------------------------------------------------

            
        }
        
    }
}
