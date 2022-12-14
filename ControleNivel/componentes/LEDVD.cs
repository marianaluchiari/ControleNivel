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
    public partial class LEDVD : UserControl
    {
        private Boolean status = false;
        public Boolean Status
        {
            get { return status; }
            set { status = value; }
        }
        public LEDVD()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (status == false)
            {
                pictureBox1.Image = ControleNivel.Properties.Resources.LEDVDoff;
            }
            else
                pictureBox1.Image = ControleNivel.Properties.Resources.LEDVDon;
        }
    }
}
