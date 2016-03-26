using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlgorithmVisualization.Shapes
{
    class Vertice : Shape
    {
        /* AMACI : NNS algoritmasında seçilen node lar arasına bir çizgi çizmek.
         * YAPILMASI GEREKENLER :
         * - Draw Fonksiyonunu implement etmek.
         */

        //Vertice için constructor.
        public Vertice(Point firstLoc, Point secondLoc, Color color) : base(firstLoc, secondLoc, color) { }

        //Bu fonksiyon yazılacak.
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
