using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlgorithmVisualization.Shapes
{
    class SelectedNode : Shape
    {
        // Default constructor implement ediliyor. (Javadaki super gibi)
        public SelectedNode(Point location) : base(location) { }

        // İkinci constructor implement ediliyor. (Javadaki super gibi)
        public SelectedNode(Point location, Color color) : base(location, color) { }

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
