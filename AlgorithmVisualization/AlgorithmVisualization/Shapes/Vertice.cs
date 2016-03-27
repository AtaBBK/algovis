using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlgorithmVisualization.Shapes
{
    class Vertice : Shape
    {
        // AMACI : NNS algoritmasında seçilen node lar arasına bir çizgi çizmek.
        
        public Vertice(Point firstLoc, Point secondLoc, Color color) : base(firstLoc, secondLoc, color) {
            this.Location = firstLoc;
            this.SecondLocation = secondLoc;
            this.Color = color;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(Pen, this.Location, this.SecondLocation);
        }
    }
}
