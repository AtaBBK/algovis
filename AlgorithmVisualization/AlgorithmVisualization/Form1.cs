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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Görüntüde titreşmeyi engellemek için.
            this.DoubleBuffered = true;
        }

        //invalidate ya da refresh de ekran temizlenip tekrar paint fonksiyonu çağırılıyor.
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                // sol tıklanırsa şekil çizdirilecek.
            }
            else if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                // sağ tıklanırsa şekil silinecek.
            }
        }

        private void selectColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectColorBtn.BackColor = colorDialog1.Color;
            }
        }
    }
}
