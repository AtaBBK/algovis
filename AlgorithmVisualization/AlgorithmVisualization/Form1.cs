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

        ShapeContainer Container;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Görüntüde titreşmeyi engellemek için.
            this.DoubleBuffered = true;

            //Shape container oluşturuluyor.
            this.Container = new ShapeContainer();
        }

        //invalidate ya da refresh de ekran temizlenip tekrar paint fonksiyonu çağırılıyor.
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //bütün şekiller çizdiriliyor.
            this.Container.DrawAll(e.Graphics);
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
            this.Container.CreationType = "Node";
        }

        // Seçilen şekli hem butonun arkaplanı olarak atar, hem de containerın CreationColor unu o renk yapar. Böylece
        //bundan sonra oluşturulacak şekiller o renkte oluşturulur.
        private void selectColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectColorBtn.BackColor = colorDialog1.Color;
                this.Container.CreationColor = colorDialog1.Color;
            }
        }

        // Kpoint butonuna basıldğında, Container'ın CreationType ını Kpoint olarak değiştirir. Böylece, tekrar değiştirilene
        //kadar Kpoint şekli oluşturmaya devam eder.
        // İLERDE BU FONKSİYON DEĞİŞECEK.
        private void drawAlgoSpecificBtn_Click(object sender, EventArgs e)
        {
            this.Container.CreationType = "Kpoint";
        }
    }
}
