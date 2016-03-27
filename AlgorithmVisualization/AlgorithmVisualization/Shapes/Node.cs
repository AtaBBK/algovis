using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualization.Shapes
{
    class Node : Shape
    {
        //AMACI : Veri noktalarımızı belirtmek için dairesel, içi dolu şekil.
         
        public Node(Point location) : base(location)
        {
            this.Height = 10;
            this.Width = 10;
        }
   
        public Node(Point location, Color color) : base(location, color)
        {
            this.Height = 10;
            this.Width = 10;
          
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(Brush, new Rectangle(this.Location.X - this.Width/2, this.Location.Y - this.Height/2, this.Height, this.Width));
        }
    }
}
