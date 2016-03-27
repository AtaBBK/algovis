using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmVisualization.Shapes;

namespace AlgorithmVisualization.Algorithms
{
    interface Algorithm
    {
        void Start(List<Shape> Shapes, List<Shape> Nodes, List<Shape> AlgoSpecific);
    }
}
