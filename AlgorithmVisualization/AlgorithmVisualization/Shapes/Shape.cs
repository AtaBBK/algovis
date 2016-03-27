using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualization.Shapes
{
    abstract class Shape
    {
        // Point sınıfından bir nesne tutuluyor. X ve Y kordinatlarını tutmak için.
        public Point Location { get; set; }
        public Point SecondLocation { get; set; }

        // Şeklin genişlik ve uzunluk değerlerini tutmak için.
        public int Height { get; set; }
        public int Width { get; set; }

        // Şeklin rengini tutmak için.
        public Color Color
        {
            get
            {
                return this.Color;
            }
            set
            {
                this.Color = value;
                this.Pen = new Pen(value);
                this.Brush = new SolidBrush(value);
            }
        }

        // Brush tipini ve rengini tutmak için.
        public Brush Brush;

        // Pen tipini ve rengini tutmak için.
        public Pen Pen;

        // Default constructor. İnput olarak kordinat alıyor. Pen için siyah, Brush için siyah bir solidbrush oluşturuluyor.
        public Shape(Point location) 
        {
            this.Location = location;
            this.Color = Color.Black;
            Logger.Log(this.GetType().Name + " created." +
                        "Location : X = " + this.Location.X.ToString() + 
                        ", Y = " + this.Location.Y.ToString() + 
                        " Color : " + this.Color.ToString() + ".");
        }

        // İkinci constructor. Verilen kordinatlarda ve verilen renkteki pen ile brush a sahip bir shape oluşturuluyor.
        public Shape(Point point, Color color) 
        {
            this.Location = point;
            this.Color = color;
            Logger.Log(this.GetType().Name + " created." +
                        "Location : X = " + this.Location.X.ToString() +
                        ", Y = " + this.Location.Y.ToString() +
                        " Color : " + this.Color.ToString() + ".");
        }

        // Vertice için constructor.
        public Shape(Point firstLoc, Point secondLoc, Color color)
        {
            this.Location = firstLoc;
            this.SecondLocation = secondLoc;
            this.Color = color;
            Logger.Log(this.GetType().Name + " created." +
                        "Location : Between X = " + this.Location.X.ToString() +
                        ", Y = " + this.Location.Y.ToString() + " and " +
                        "X = " + this.SecondLocation.X.ToString() + 
                        ", Y = " + this.SecondLocation.Y.ToString() + 
                        " Color : " + this.Color.ToString() + ".");
        }
        public abstract void Draw(Graphics graphics);
    }
}
