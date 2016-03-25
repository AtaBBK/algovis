using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualization.Shapes
{
    class Node : Shape
    {
        /* AMACI : Veri noktalarımızı belirtmek için dairesel, içi dolu şekil.
         * YAPILMASI GEREKENLER : 
         * - Width(x) ve Height(y) değerlerinin constructor'larda tanımlanması.
         * - Şeklin çizdirilme metodunun yazılması.
         */

        // Default constructor implement ediliyor. (Javadaki super gibi)
        public Node(Point location) : base(location)
        {
            //burada şeklin uzunluk ve genişlik değerleri tanımlanacak. (Dikdörtgensel şekil olarak düşünüldüğü için)
            //this.Height = 5 gibi bi atama işlemi gerekiyor.
        }

        // İkinci constructor implement ediliyor. (Javadaki super gibi)
        public Node(Point location, Color color) : base(location, color)
        {
            //burada şeklin uzunluk ve genişlik değerleri tanımlanacak. (Dikdörtgensel şekil olarak düşünüldüğü için)
            //this.Height = 5 gibi bi atama işlemi gerekiyor.
        }

        public override void Draw()
        {
            //burada çizdirme işlemi bu şekle özel olarak yazılacak. 
            // height ve width değerlerini kullanın.
            // -height/2 ve -width/2 olayını unutmayın. (tam tıklanan yeri merkez alması için.)
            throw new NotImplementedException();
        }
    }
}
