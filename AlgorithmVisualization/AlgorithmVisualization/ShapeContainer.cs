using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmVisualization.Shapes;
using System.Drawing;
using AlgorithmVisualization.Algorithms;

namespace AlgorithmVisualization
{
    class ShapeContainer
    {
        /* YAPILMASI GEREKENLER:
         *  - DrawAll fonksiyonu için gerekli input değerleri yazılması gerekiyor.
         *  - Gerekli input değerleri yazıldıktan sonra bütün şekiller için draw fonksiyonuna gereken parametreler gönderilmeli.
         */


        //Bütün shapelerin tutulduğu, hepsini çizdirmek için liste.
        public List<Shape> Shapes { get; set; }

        // Sadece noktaları tutan liste.
        public List<Shape> Nodes { get; set; }

        //Sadece K noktalarını tutan liste.
        public List<Shape> Kpoints { get; set; }

        //Sadece SelectedNode ları tutan liste.
        public List<Shape> SelectedNodes { get; set; }

        //Sadece vertice leri tutan liste.
        public List<Shape> Vertices { get; set; }

        //Çizilmek istenen şekillerin ismini tutan string. Butonlarla değiştiriliyor.
        public string CreationType { get; set; }

        //Çizilmek istenen şekillerin rengini tutan nesne. Renk değiştirme butonu ile değiştiriliyor.
        public Color CreationColor { get; set; }

        //Şekilleri üreten fabrika.
        ShapeFactory Factory { get; }

        //Algoritmalar için strateji pattern.
        public Algorithm Algorithm { get; set; }

        // Default constructor. Listeleri oluşturuyor. Default renk olarak siyah ve default şekil tipi olarak noktayı seçiyor.
        public ShapeContainer()
        {
            this.Shapes = new List<Shape>();
            this.Nodes = new List<Shape>();
            this.Kpoints = new List<Shape>();
            this.SelectedNodes = new List<Shape>();
            this.Vertices = new List<Shape>();
            this.CreationType = "Node";
            this.CreationColor = Color.Black;
            this.Factory = new ShapeFactory();
        }

        // Verilen lokasyonda şekil oluşturuyor ve listelere ekliyor.
        public Shape CreateShape(Point location)
        {
            if(this.CreationType != null && this.CreationColor != null)
            {
                Shape shape = this.Factory.CreateShape(this.CreationType, location, this.CreationColor);
                this.Shapes.Add(shape); //önce şekil, tipine ve regine göre oluşturulup genel listeye ekleniyor.
                if (this.CreationType.Equals("NODE", StringComparison.OrdinalIgnoreCase))
                    this.Nodes.Add(shape); //eğer şekil nokta ise noktalar listesine ekleniyor.
                else if (this.CreationType.Equals("KPOINT", StringComparison.OrdinalIgnoreCase))
                    this.Kpoints.Add(shape); //eğer şekil k noktası ise k noktalar listesine ekleniyor.
                else if (this.CreationType.Equals("SELECTEDNODE", StringComparison.OrdinalIgnoreCase))
                    this.SelectedNodes.Add(shape); //eğer şekil selected node ise o listeye ekleniyor.

                return shape;
            }
            return null;
        }

        // Verilen şekli listelerden siliyor.
        public void DeleteShape(Shape shape)
        {
            if(shape != null)
            {
                if (shape.GetType().Name == "Node") //şekil nokta ise noktalar listesinden siliyor.
                    this.Nodes.Remove(shape);
                if (shape.GetType().Name == "Kpoint") //şekil K noktası ise k noktaları listesinden siliyor.
                    this.Kpoints.Remove(shape);
                if (shape.GetType().Name == "SelectedNode") //şekil selected node ise o listeden siliyor.
                    this.SelectedNodes.Remove(shape);

                this.Shapes.Remove(shape); // genel listeden siliyor.
            }
        }

        // Verilen lokasyondaki şekli bulup döndüren method.
        public Shape FindShape(Point location)
        {
            foreach(Shape shape in Shapes) //bütün liste dolaşılıyor.
            {
                //önce genişlik yani x kordinatı kontrol ediliyor. Verlilen lokasyonun x'i şeklin genişliğinin içerisinde ise.
                if(shape.Location.X + shape.Width/2 - 1 >= location.X && shape.Location.X - shape.Width/2 + 1 <= location.X)
                {
                    //önce genişlik yani y kordinatı kontrol ediliyor. Verlilen lokasyonun y'si şeklin uzunluğu içerisinde ise.
                    if (shape.Location.Y + shape.Height/2 - 1 >= location.Y && shape.Location.Y - shape.Height/2 + 1 <= location.Y)
                    {
                        return shape;
                    }
                }
                //not: +-1 olmasının sebebi, şekli çizdirirken belirlenen dikdörtgensel şekilden daha küçük bir dikdörtgensel
                //bölgeye tıklandığında şekli çizmesi için. Detaylı açıklama için muroya danışın.
            }
            return null;//bulunamazsa null döndür.
        }
        
        //bütün şekiller çizdiriliyor.
        public void DrawAll(Graphics g)
        {
            //bu fonksiyon için gereken input parametrelerini ekleyin.
            foreach(Shape shape in Shapes)
            {
                shape.Draw();
            }
        }

        //Verilen listeyi temizliyor. Ve genel listeden siliyor.
        //hataya neden olabilir. ilerde değişecek.
        public void ClearList(List<Shape> list)
        {
            foreach(Shape shape in list)
            {
                this.Shapes.Remove(shape);
            }
            list.Clear();
        }
    }
}
