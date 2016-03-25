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
        private Brush Brush;

        // Pen tipini ve rengini tutmak için.
        private Pen Pen;

        // Default constructor. İnput olarak kordinat alıyor. Pen için siyah, Brush için siyah bir solidbrush oluşturuluyor.
        public Shape(Point location) 
        {
            this.Location = location;
            this.Brush = new SolidBrush(Color.Black);
            this.Pen = new Pen(Color.Black);
        }

        // İkinci constructor. Verilen kordinatlarda ve verilen renkteki pen ile brush a sahip bir shape oluşturuluyor.
        public Shape(Point point, Color color) 
        {
            this.Location = point;
            this.Brush = new SolidBrush(color);
            this.Pen = new Pen(color);
        }

        //Objenin ekrana çizdirilmesi. Her sınıf ayrı tanımlar. İnputların sonra değiştirilmesi gerekecek. (Graphics gelecek vs)
        public abstract void Draw();
    }
}
