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
    public partial class ValvulaV : UserControl
    {
        private Boolean status = false;
        public Boolean Status
        {
            get { return status; }
            set { status = value; }
        }

        private string nome = "Válvula";
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public ValvulaV()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = nome;

            if (status == false)
            {
                pictureBox1.Image = ControleNivel.Properties.Resources.Valve2_Red_Closed;
            }
            else
                pictureBox1.Image = ControleNivel.Properties.Resources.Valve2_Red_Opened;
        }

        private void ValvulaV_Click(object sender, EventArgs e)
        {
            if(status == false)
            {
                status = true;
                pictureBox1.Image=ControleNivel.Properties.Resources.Valve2_Red_Opened;
            }
            else
            {
                status = false;
                pictureBox1.Image=ControleNivel.Properties.Resources.Valve2_Red_Closed;
            }
        }
    }
}
