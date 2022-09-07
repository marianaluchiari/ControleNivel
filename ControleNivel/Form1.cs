using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace ControleNivel
{
    public partial class Form1 : Form
    {
        public ModbusClient cliente = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cliente != null && cliente.Connected)
            {
                bool status = cliente.ReadCoils(0, 1)[0];

                if(status==false)
                {
                    pictureBox1.Image = ControleNivel.Properties.Resources.LEDVDoff;
                }
                else
                {
                    pictureBox1.Image = ControleNivel.Properties.Resources.LEDVDon;
                }

                int NT = cliente.ReadInputRegisters(0, 1)[0];
                label4.Text = NT.ToString();
                int nt = (NT/10)*3;
                tanque1.Nivel = nt;

                int NT2 = cliente.ReadInputRegisters(2, 1)[0];
                int nt2 = (NT2 / 10) * 3;
                tanque2.Nivel = nt2;

                int NT3 = cliente.ReadInputRegisters(4, 1)[0];
                int nt3 = (NT3 / 10) * 3;
                tanque3.Nivel = nt3;

                if(nt==295||nt2==295||nt3==295) //impede que encha o tanque demais
                {
                    ve.Value = 0;
                }

                int VE = (int)ve.Value;
                cliente.WriteSingleRegister(0,VE);
                cliente.WriteSingleRegister(2, VE);
                cliente.WriteSingleRegister(4, VE);

                if (VE == 0)
                {
                    valvulaA1.Status = false;
                }
                else
                    valvulaA1.Status = true;

                int VS = (int)vs.Value;
                cliente.WriteSingleRegister(1, VS);
                cliente.WriteSingleRegister(3, VS);
                cliente.WriteSingleRegister(5, VS);

                if (VS == 0)
                {
                    valvulaV1.Status = false;
                }
                else
                    valvulaV1.Status = true;

                int VZ = cliente.ReadInputRegisters(1, 1)[0];
                vz.Text = VZ.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool status = cliente.ReadCoils(0, 1)[0];

            if (button1.Text=="Ligar")
            {
                cliente.WriteSingleCoil(0,true);
                cliente.WriteSingleCoil(1, true);
                cliente.WriteSingleCoil(2, true);

                button1.Text = "Desligar";
            }
            else
            {
                cliente.WriteSingleCoil(0, false);
                cliente.WriteSingleCoil(1, false);
                cliente.WriteSingleCoil(2, false);

                ve.Value = 0;
                vs.Value = 0;
                button1.Text = "Ligar";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Ligar";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente == null)
                {
                    string IP = "192.168.0.139";
                    int Port = 502;
                    cliente = new ModbusClient(IP, Port);
                    cliente.Connect();
                }
                else
                {
                    cliente.Disconnect();
                    cliente = null;
                }
            }
            catch (Exception ex)
            {
                cliente = null;
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK);
            }
            if (cliente == null)
            {
                timer2.Stop();
                button2.Text = "Conectar";
            }
            else
            {
                timer2.Start();
                button2.Text = "Desconectar";
            }
        }
    }
}
