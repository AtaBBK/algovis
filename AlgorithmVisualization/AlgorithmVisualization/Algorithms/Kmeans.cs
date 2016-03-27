using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AlgorithmVisualization.Shapes;


namespace AlgorithmVisualization.Algorithms
{
    class Kmeans : Algorithm
    {
        List<Point> LastCoordinates = new List<Point>();

        private void UpdateLastCoordinates(List<Shape> Kpoints)
        {
            this.LastCoordinates.Clear();
            foreach (Shape s in Kpoints)
            {
                this.LastCoordinates.Add(s.Location);
            }
        }

        private bool Convergence(List<Shape> Kpoints)
        {
            foreach(Shape kpoint in Kpoints)
            {
                if (kpoint.Location.X != LastCoordinates[Kpoints.IndexOf(kpoint)].X ||
                    kpoint.Location.Y != LastCoordinates[Kpoints.IndexOf(kpoint)].Y)
                    return false;
            }
            Logger.Log("Convergence! Ending algorithm...");
            return true;
        }

        private double FindDistance(Point firstLocation, Point secondLocation)
        {
            return Math.Sqrt(Math.Pow((secondLocation.X - firstLocation.X), 2)
                + Math.Pow((secondLocation.Y - firstLocation.Y), 2));
        }

        private void Cluster(List<Shape> Shapes, List<Shape> Nodes, List<Shape> Kpoints)
        {
            double distance;
            double temp;
            int index;
            Color color;
            foreach (Shape node in Nodes)
            {
                distance = 10000000;
                temp = 10000000;
                index = -1;
                color = node.Color;
                foreach (Shape kpoint in Kpoints)
                {
                    temp = FindDistance(node.Location, kpoint.Location);
                    if (temp < distance)
                    {
                        distance = temp;
                        index = Kpoints.IndexOf(kpoint);
                        color = kpoint.Color;
                    }
                }
                Logger.Log("Changed color of the node. Location : X = " + node.Location.X.ToString() +
                    ", Y = " + node.Location.Y.ToString() + 
                    " Old Color = " + node.Color.ToString() + 
                    " New Color = " + color.ToString() + ".");
                Shapes[Shapes.IndexOf(node)].Color = color;
                Nodes[Nodes.IndexOf(node)].Color = color;
                Logger.Animate();
            }
        }

        private Point CalculateCenterOfGravity(List<Shape> Nodes, Color clusterColor)
        {
            int totalX = 0;
            int totalY = 0;
            int n = 0;
            foreach(Shape node in Nodes)
            {
                if(node.Color == clusterColor)
                {
                    totalX += node.Location.X;
                    totalY += node.Location.Y;
                    n += 1;
                }
            }
            Logger.Log("Number of nodes in " + clusterColor.ToString() +" cluster : " + n.ToString() + ".");
            Point newCenter = new Point(totalX / n, totalY / n);
            Logger.Log("Center of Gravity for the " + clusterColor.ToString() + " colored cluster : " +
                "X = " + newCenter.X.ToString() + ", Y = " + newCenter.Y.ToString() + ".");
            return newCenter;
        }

        private void ChangeLocOfKpoints(List<Shape> Shapes, List<Shape> Nodes, List<Shape> Kpoints)
        {
            Point newLocation;
            foreach(Shape kpoint in Kpoints)
            {
                newLocation = CalculateCenterOfGravity(Nodes, kpoint.Color);
                Logger.Log("Changed location of the K point. Color = " + kpoint.Color.ToString() + 
                    " Old location : X = " + kpoint.Location.X.ToString() +
                    ", Y = " + kpoint.Location.Y.ToString() +
                    " New Location : X = " + newLocation.X.ToString() +
                    ", Y = " + newLocation.Y.ToString() + ".");
                Shapes[Shapes.IndexOf(kpoint)].Location = newLocation;
                Kpoints[Kpoints.IndexOf(kpoint)].Location = newLocation;
                Logger.Animate();
            }
        }

        public void Start(List<Shape> Shapes, List<Shape> Nodes, List<Shape> Kpoints)
        {
            Logger.Log("Starting the Kmeans Algorithm : ...");
            do
            {
                UpdateLastCoordinates(Kpoints);
                Logger.Log("Clustering ...");
                Cluster(Shapes, Nodes, Kpoints);
                Logger.Log("Changing the locations of the K points ...");
                ChangeLocOfKpoints(Shapes, Nodes, Kpoints);
            } while (Convergence(Kpoints) == false);
        }
    }
}
