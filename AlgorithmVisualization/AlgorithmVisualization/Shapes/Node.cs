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
        /* AMACI : Veri noktalarımızı belirtmek için dairesel, içi dolu şekil.
         * YAPILMASI GEREKENLER : 
         * - Width(x) ve Height(y) değerlerinin constructor'larda tanımlanması.
         * - Şeklin çizdirilme metodunun yazılması.
         */

        // Default constructor implement ediliyor. 
        public Node(Point location) : base(location)
        {
            this.Height = location.X;
            this.Width = location.Y;
        }

        // İkinci constructor implement ediliyor. 
        public Node(Point location, Color color) : base(location, color)
        {
            this.Height = location.X;
            this.Width = location.Y;
            this.Color = color;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(Brush, new Rectangle(this.Location.X - 5, this.Location.Y - 5, 10, 10));
        }
    }
}
