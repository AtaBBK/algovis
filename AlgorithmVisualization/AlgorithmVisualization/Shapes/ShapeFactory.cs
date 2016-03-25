using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace AlgorithmVisualization.Shapes
{
    class ShapeFactory
    {
        public Shape CreateShape(string type, Point location, Color color)
        {
            if (type == null) return null;
            if (type.Equals("KPOINT", StringComparison.OrdinalIgnoreCase))
                return new Kpoint(location, color);
            else if (type.Equals("NODE", StringComparison.OrdinalIgnoreCase))
                return new Node(location, color);
            else if (type.Equals("SELECTEDNODE", StringComparison.OrdinalIgnoreCase))
                return new SelectedNode(location, color);
            return null;
        }
    }
}
