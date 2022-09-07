using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleNivel.componentes
{
    public partial class Tanque : UserControl
    {
        private double nivel = 0;
        public double Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
        private string nometanque = "Nome Tanque";
        public string NomeTanque
        {
            get { return nometanque; }
            set { nometanque = value; }
        }
        private double nivelmin = 0;
        public double NivelMin
        {
            get { return nivelmin; }
            set { nivelmin = value; }
        }
        private double nivelmax = 100;
        public double NivelMax
        {
            get { return nivelmax; }
            set { nivelmax = value; }
        }
        private Color cornivel = Color.BlueViolet;
        public Color CorNivel
        {
            get { return cornivel; }
            set { cornivel = value; }
        }
        public Tanque()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Start();

            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Size = pictureBox2.Size;
            pictureBox2.Image = ControleNivel.Properties.Resources.TanqueVTransp1;
            int dx = pictureBox1.Width;
            int dy = pictureBox1.Height;
            Bitmap bmp = new Bitmap(dx, dy);

            Graphics gp = Graphics.FromImage(bmp);

            SolidBrush sb = new SolidBrush(CorNivel);

            int alt = (int)(((nivel - nivelmin) / (NivelMax - nivelmin)) * dy);
            gp.FillRectangle(sb, 0, dy - alt, dx, dy);

            pictureBox1.Image = bmp;

            label1.Text = nivel.ToString("#0.00");
            label2.Text = nometanque;
        }
    }
}
