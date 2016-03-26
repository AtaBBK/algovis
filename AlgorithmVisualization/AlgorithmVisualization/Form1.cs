using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgorithmVisualization.Shapes;
using AlgorithmVisualization.Algorithms;

namespace AlgorithmVisualization
{
    public partial class Form1 : Form
    {
        /* YAPILMASI GEREKENLER:
         * - Tıklanan yerde şekli çizdirmek
         * - Tıklanan yerdeki şekli silmek.
         * - Yer değiştirme işlemini uygulamak.
         * - Silme ve yer değiştirme işlemleri sonrası ekranın güncellenmesi işlemlerini yapmak.
         */

        ShapeContainer container;
        string[] algorithmNames = new string[]
        {
            "Kmeans",
            "Nearest Neighbor Search"
        };
        List<ToolStripButton> algoSpecificBtns;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Görüntüde titreşmeyi engellemek için.
            this.DoubleBuffered = true;

            //Shape container oluşturuluyor.
            this.container = new ShapeContainer();

            //Algoritma isimleri comboboxa yazdırılıyor.
            foreach(string s in algorithmNames)
            {
                this.selectAlgorithm.Items.Add(s);
            }
            
            //Butonlar enable işlemleri için bir listede tutuluyor.
            this.algoSpecificBtns = new List<ToolStripButton>();
            this.algoSpecificBtns.Add(this.kmeansBtn);
            this.algoSpecificBtns.Add(this.nearestNeighborSearchBtn);
            //Buraya daha sonra başka algoritmaların da butonları eklenecek.

            this.selectAlgorithm.SelectedIndex = 0; //listedeki ilk algoritma seçiliyor.

            this.AlgoSelect(this.selectAlgorithm.Text); //seçilen algoritmaya göre butonlar değiştiriliyor ve containerın
            // stratejisi değiştiriliyor. Diğer algoritmadan kalan şekil varsa onlar siliniyor.
        }
        
        //invalidate ya da refresh de ekran temizlenip tekrar paint fonksiyonu çağırılıyor.
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //bütün şekiller çizdiriliyor.
            this.container.DrawAll(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                // sol tıklanırsa şekil çizdirilecek.
                //Container ın create shape metodunu kullanın.
            }
            else if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                // sağ tıklanırsa şekil silinecek.
                // Containerın delete shape metodunu kullanıdıktan sonra ekrana tekrar çizdirilme işlemi yapılacak.
            }
        }

        // Node butonuna basıldğında, Container'ın CreationType ını Node olarak değiştirir. Böylece, tekrar değiştirilene
        //kadar node şekli oluşturmaya devam eder.
        private void drawNodeBtn_Click(object sender, EventArgs e)
        {
            this.container.CreationType = "Node";
        }

        // Seçilen şekli hem butonun arkaplanı olarak atar, hem de containerın CreationColor unu o renk yapar. Böylece
        //bundan sonra oluşturulacak şekiller o renkte oluşturulur.
        private void selectColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectColorBtn.BackColor = colorDialog1.Color;
                this.container.CreationColor = colorDialog1.Color;
            }
        }

        //Seçilen algoritmanın ismine göre işlemleri uyguluyor. Gerekli butonlar enable ediliyor. Strateji değişiyor.
        //önceki algoritmadan kalan şekiller siliniyor.
        public void AlgoSelect(string algoName)
        {
            //gönderilen stringden boşlukları siliyor ve lowercase e alıyor.
            string temp = algoName.Replace(" ", "").ToLower(); // Örnek: Nearest Neighbor Search = nearestneighborsearch
            foreach (ToolStripButton btn in this.algoSpecificBtns) // Bütün butonlar dolaşılıyor.
            {
                if (btn.Name.ToLower().Equals(temp + "btn")) // buton ismi ile algoritma ismi uyuşursa enable ediyor.
                {
                    btn.Enabled = true;
                }
                else
                {
                    btn.Enabled = false; //diğerlerini enable = false ediyor.
                }
            }

            //Bu kısımda uygulanacak strateji belirleniyor. 
            if (temp.Equals("kmeans")) this.container.Algorithm = new Kmeans();
            else if (temp.Equals("nearestneighborsearch")) this.container.Algorithm = new NNS();

            //son olarak önceki algoritmadan kalan şekiller siliniyor.
            this.container.ClearAlgoLists();
            //burda ekran tekrar çizdirilecek.
        }

        //Algoritma seçimi değişirse AlgoSelect fonksiyonunu çağırıyor.
        private void selectAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AlgoSelect(this.selectAlgorithm.Text);
        }

        //K butonuna basıldığında container ın bundan sonra üreteceği şekli kpoint yapıyor.
        private void drawKpointBtn_Click(object sender, EventArgs e)
        {
            this.container.CreationType = "Kpoint";
        }

        //N butonuna basıldığında container ın bundan sonra üreteceği şekli selected node yapıyor.
        private void drawSelectedNBtn_Click(object sender, EventArgs e)
        {
            this.container.CreationType = "SelectedNode";
        }

        //Start butonuna basıldığında containerdaki algoritma başlatılıyor.
        private void startBtn_Click(object sender, EventArgs e)
        {
            this.container.Algorithm.Start();
        }

        //Reset butonuna basıldığında ekranı sıfırlıyor.
        private void resetBtn_Click(object sender, EventArgs e)
        {            
            this.container.Shapes.Clear();
            this.container.Nodes.Clear();
            this.container.Kpoints.Clear();
            this.container.SelectedNodes.Clear();
            this.container.Vertices.Clear();
            //burada ekran tekrar çizdirilecek.
        }
    }
}
