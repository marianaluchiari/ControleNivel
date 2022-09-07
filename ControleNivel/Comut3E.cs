using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleNivel
{
    public partial class Comut3E : UserControl
    {
        private int posicao = 1;
        private Posicao pos;
        public enum Posicao
        {
            Automatico,
            Manual
        }
        public Posicao Estagio
        {
            get { return pos; }
            set { pos = value; }
        }
        public Comut3E()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (posicao)
            {
                case 0:
                    posicao = 2;
                    pictureBox1.Image = ControleNivel.Properties.Resources.Comut45d;
                    Estagio = Posicao.Automatico;
                    break;
                case 2:
                    posicao = 0;
                    pictureBox1.Image = ControleNivel.Properties.Resources.Comut45e;
                    Estagio = Posicao.Manual;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            switch (posicao)
            {
                case 0:
                    label1.Font = new Font(label1.Font, FontStyle.Bold);
                    label3.Font = new Font(label3.Font, FontStyle.Regular);
                    break;
                case 2:
                    label1.Font = new Font(label1.Font, FontStyle.Regular);
                    label3.Font = new Font(label3.Font, FontStyle.Bold);
                    break;
            }
        }

        private void Comut3E_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = ControleNivel.Properties.Resources.Comut45e;
            posicao = 0;
            Estagio = Posicao.Manual;
        }
    }
}
