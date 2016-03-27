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
        // AMACI : Nearest Node Search algoritmasında seçilen node'un çevresine pen ile daha geniş bir daire çizilmesi.
        
        public SelectedNode(Point location) : base(location)
        {
            this.Height = location.Y;
            this.Width = location.X;
        }

     
        public SelectedNode(Point location, Color color) : base(location, color)
        {
            this.Height = location.Y;
            this.Width = location.X;
            
        }

        public override void Draw(Graphics graphics)
        {
            //burada çizdirme işlemi bu şekle özel olarak yazılacak. 
            // height ve width değerlerini kullanın.
            // -height/2 ve -width/2 olayını unutmayın. (tam tıklanan yeri merkez alması için.)
            throw new NotImplementedException();
        }
    }
}
