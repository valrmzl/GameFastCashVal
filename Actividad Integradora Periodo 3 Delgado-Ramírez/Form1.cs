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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.textBox1.Text == "delgado") && (this.textBox2.Text == "ramirez"))
            {
                Form2 a = new Form2(6000);
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña son incorrectos.");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int color = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (color == 0)
            {
                label1.ForeColor = Color.Black;
                label1.BackColor = Color.PeachPuff;
                //
                label2.ForeColor = Color.Purple;
                label2.BackColor = Color.Turquoise;
                //
                label3.ForeColor = Color.Yellow;
                label3.BackColor = Color.Black;
                //
                label4.ForeColor = Color.DeepPink;
                label4.BackColor = Color.Black;
                //
                label5.ForeColor = Color.DeepPink;
                label5.BackColor = Color.Black;
                //
                button1.ForeColor = Color.DarkOliveGreen;
                button1.BackColor = Color.DarkSalmon;
                //

                button2.ForeColor = Color.DarkOliveGreen;
                button2.BackColor = Color.DarkSalmon;
                color++;
            }
            else
            {
                label1.ForeColor = Color.Purple;
                label1.BackColor = Color.Turquoise;
                
                //
                label2.ForeColor = Color.Green;
                label2.BackColor = Color.PeachPuff;
                //
                label3.ForeColor = Color.Black;
                label3.BackColor = Color.Yellow;

                label4.ForeColor = Color.Black;
                label4.BackColor = Color.DeepPink;
                //
                label5.ForeColor = Color.Black;
                label5.BackColor = Color.DeepPink;

                //
                button1.ForeColor = Color.Black;
                button1.BackColor = Color.White;
                //

                button2.ForeColor = Color.Black;
                button2.BackColor = Color.White;
                color--;

            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
