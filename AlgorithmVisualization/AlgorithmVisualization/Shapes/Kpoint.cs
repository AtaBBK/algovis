using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace AlgorithmVisualization.Shapes
{
    class Kpoint : Shape
    {
        // AMACI : Veri noktalarımızı belirtmek için dairesel, içi dolu şekil.
        string cat;
        Font myFont;
        public Kpoint(Point location) : base(location)
        {
            cat = "X";
            myFont = new Font("Arial", 10, FontStyle.Bold);
        }
        public Kpoint(Point location, Color color) : base(location, color)
        {
            cat = "X";
            myFont = new Font("Arial", 10, FontStyle.Bold);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawString(cat, myFont, Brush, this.Location);
        }
    }
}
