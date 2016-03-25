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
        private Point Location; // Point sınıfından bir nesne tutuluyor. X ve Y kordinatlarını tutmak için.
        private Brush Brush; // Brush tipini ve rengini tutmak için.
        private Pen Pen; // Pen tipini ve rengini tutmak için.

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

        // Kordinatları point sınıf şeklinde geri döndürüyor.
        public Point GetLocation()
        {
            return this.Location;
        }

        //Yer değiştirme yapılacağı zaman yeni lokasyon atanır.
        public void SetLocation(Point newLocation)
        {
            this.Location = newLocation;
        }

        // Objenin Brushını göndürüyor.
        public Brush GetBrush()
        {
            return this.Brush;
        }

        // Objenin Brush ını, farklı tip veya renk ile değiştirmek için.
        public void SetBrush(Brush newBrush)
        {
            this.Brush = newBrush;
        }

        //Objenin Penini döndürüyor.
        public Pen GetPen()
        {
            return this.Pen;
        }

        //Objenin Penini, farklı tip veya renkte bir brush ile değiştirmek için.
        public void SetPen(Pen newPen)
        {
            this.Pen = newPen;
        }

        //Objenin ekrana çizdirilmesi. Her sınıf ayrı tanımlar. İnputların sonra değiştirilmesi gerekecek. (Graphics gelecek vs)
        public abstract void Draw();

        //Objenin yer değiştirmesi için. Her sınıf ayrı işleyecek. İnputlar sonra değiştirilecek.
        public abstract void Move();
    }
}
