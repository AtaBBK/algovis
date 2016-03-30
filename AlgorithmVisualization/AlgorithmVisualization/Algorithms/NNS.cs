using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using AlgorithmVisualization.Shapes;

namespace AlgorithmVisualization.Algorithms
{
    class NNS : Algorithm
    {
        static int xCoordinate, yCoordinate;
        List<Distance> Distances = new List<Distance>();

        public void Start(List<Shape> Shapes, List<Shape> Nodes, List<Shape> AlgoSpecific)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            xCoordinate = e.X;
            yCoordinate = e.Y;
        }

        public int findNode(List<Shape> Nodes, List<Shape> SelectedNodes, int x, int y)
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                if (Nodes[i].Location.X == x && Nodes[i].Location.Y == y)
                {
                    SelectedNodes.Add(Nodes[i]);
                    return i;
                }
            }
            return -1;
        }

        public int controlNode(List<Shape> SelectedNodes, int x, int y)
        {
            for (int i = 0; i < SelectedNodes.Count; i++)
            {
                if (SelectedNodes[i].Location.X == x && SelectedNodes[i].Location.Y == y)
                {
                    return i;
                }
            }
            return -1;
        }

        public void calculateDistance(List<Shape> Nodes, List<Shape> SelectedNodes, List<Distance> Distances, int x, int y)
        {
            int index = findNode(Nodes, SelectedNodes, x, y);
            double distance = 0;
            Distance use = null;

            for (int i = 0; i < Nodes.Count; i++)
            {
                if (controlNode(SelectedNodes, Nodes[index].Location.X, Nodes[index].Location.Y) == -1)
                {
                    double X1 = (x - Nodes[i].Location.X) * (x - Nodes[i].Location.X);
                    double Y1 = (y - Nodes[i].Location.Y) * (y - Nodes[i].Location.Y);
                    double XY = X1 + Y1;

                    distance = Math.Sqrt(XY);

                    use.firstX = x;
                    use.firstY = y;
                    use.endX = Nodes[i].Location.X;
                    use.endY = Nodes[i].Location.Y;
                    use.distance = distance;

                    Distances.Add(use);
                }
            }
            //Distances.Sort(distance);
        }

        public void shortestDistance(PaintEventArgs paintEvent, List<Shape> Nodes, List<Distance> Distances, List<Shape> Vertices, List<Shape> SelectedNodes)
        {
            Graphics vertices = paintEvent.Graphics;
            Pen pen = new Pen(Color.Red);
            int i = 1;

            while (Nodes[i] != null)
            {
                vertices.DrawLine(pen, Distances[0].firstX, Distances[0].firstY, Distances[0].endX, Distances[0].endY);
                calculateDistance(Nodes, SelectedNodes, Distances, Distances[0].endX, Distances[0].endY);
                i++;
            }
        }
    }

    class Distance
    {
        public int firstX { get; set; }
        public int firstY { get; set; }
        public int endX { get; set; }
        public int endY { get; set; }
        public double distance { get; set; }
    }
}
