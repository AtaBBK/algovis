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
        /* AMACI : Nearest Node Search algoritmasında seçilen node'un çevresine pen ile daha geniş bir daire çizilmesi.
         * YAPILMASI GEREKENLER : 
         * - Width(x) ve Height(y) değerlerinin constructor'larda tanımlanması.
         * - Şeklin çizdirilme metodunun yazılması.
         */

        // Default constructor implement ediliyor. (Javadaki super gibi)
        public SelectedNode(Point location) : base(location)
        {
            //burada şeklin uzunluk ve genişlik değerleri tanımlanacak. (Dikdörtgensel şekil olarak düşünüldüğü için)
            //this.Height = 5 gibi bi atama işlemi gerekiyor.
        }

        // İkinci constructor implement ediliyor. (Javadaki super gibi)
        public SelectedNode(Point location, Color color) : base(location, color)
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
