using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Integradora_Periodo_3_Delgado_Ramírez
{
    public partial class Form2 : Form
    {
        public Form2(int k)
        {
            presupuesto = k;
            
            InitializeComponent();
            label3.Text = Convert.ToString(presupuesto);
        }
        int presupuesto;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (presupuesto > 0)
            {
                Form3 b = new Form3(presupuesto);
                b.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("No tienes fondos suficientes para seguir jugando");
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (presupuesto > 0)
            {
                Form4 c = new Form4(presupuesto);
                c.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No tienes fondos suficientes para seguir jugando");
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        int color=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (color == 0)
            {
                label1.ForeColor = Color.MediumAquamarine;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Yellow;
                button1.ForeColor = Color.Red;
                button1.BackColor = Color.Green;
                button2.ForeColor = Color.MediumSeaGreen;
                button2.BackColor = Color.LightGray;
                button3.ForeColor = Color.DarkBlue;
                button3.BackColor = Color.White;
                
                //
                label5.ForeColor = Color.DeepPink;
                label5.BackColor = Color.Black;
                //
                label6.ForeColor = Color.DeepPink;
                label6.BackColor = Color.Black;






                color++;

            }
            else
            {
                label1.ForeColor = Color.MediumVioletRed;
                label2.ForeColor = Color.Orange;
                label3.ForeColor = Color.Orange;
                button1.ForeColor = Color.Green;
                button1.BackColor = Color.Red;
                button2.ForeColor = Color.LightGray;
                button2.BackColor = Color.MediumSeaGreen;
                button3.ForeColor = Color.White;
                button3.BackColor = Color.DarkBlue;
                label5.ForeColor = Color.Black;
                label5.BackColor = Color.DeepPink;
                //
                label6.ForeColor = Color.Black;
                label6.BackColor = Color.DeepPink;
                //

                color--;
            }


            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
