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
        // Default constructor implement ediliyor. (Javadaki super gibi)
        public Node(Point location) : base(location) { }

        // İkinci constructor implement ediliyor. (Javadaki super gibi)
        public Node(Point location, Color color) : base(location, color) { }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
