using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace AlgorithmVisualization.Shapes
{
    class Kpoint : Shape
    {
        /* AMACI : Veri noktalarımızı belirtmek için dairesel, içi dolu şekil.
         * YAPILMASI GEREKENLER : 
         * - Width(x) ve Height(y) değerlerinin constructor'larda tanımlanması.
         * - Şeklin çizdirilme metodunun yazılması.
         */

        // Default constructor implement ediliyor. (Javadaki super gibi)
        public Kpoint(Point location) : base(location)
        {
            this.Height = location.Y;
            this.Width = location.X;
        }

        // İkinci constructor implement ediliyor. (Javadaki super gibi)
        public Kpoint(Point location, Color color) : base(location, color)
        {
            this.Height = location.Y;
            this.Width = location.X;
            this.Color = color;
        }

        public override void Draw(Graphics graphics)
        {

            Font myFont = new Font("Arial", 10, FontStyle.Bold);
            string cat = "X";
            graphics.DrawString(cat, myFont, Brush, this.Location);

        }
    }
}
