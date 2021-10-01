using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Actividad_Integradora_Periodo_3_Delgado_Ramírez
{
    public partial class Form4 : Form
    {
        public Form4(int j)
        {
            res = j;
            InitializeComponent();
            label5.Text = Convert.ToString(res);
        }
        int num, dinero, apuesta, res;
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2 (res);
            a.Show();
            this.Hide();
        }

        Random v = new Random();
        SoundPlayer sonido = new SoundPlayer();
        private void button2_Click(object sender, EventArgs e)
        {

            if (numericUpDown1.Value <= res)
            {
                sonido.SoundLocation = "dados1.wav";
                sonido.Play();
                num = v.Next(1, 7);
                //imagen
                if (num == 1)
                {
                    pictureBox1.ImageLocation = "1.PNG";
                }
                if (num == 2)
                {
                    pictureBox1.ImageLocation = "2.PNG";
                }
                if (num == 3)
                {
                    pictureBox1.ImageLocation = "3.PNG";
                }
                if (num == 4)
                {
                    pictureBox1.ImageLocation = "4.PNG";
                }
                if (num == 5)
                {
                    pictureBox1.ImageLocation = "5.PNG";
                }
                if (num == 6)
                {
                    pictureBox1.ImageLocation = "6.PNG";
                }
                if (num == numericUpDown2.Value)
                {
                    dinero = Convert.ToInt32(label5.Text);
                    apuesta = Convert.ToInt32(numericUpDown1.Value);
                    res = dinero + apuesta;
                    label5.Text = Convert.ToString(res);
                    MessageBox.Show("ADIVINASTE  el número correcto , has GANADO la apuesta");
                }
                else
                {
                    dinero = Convert.ToInt32(label5.Text);
                    apuesta = Convert.ToInt32(numericUpDown1.Value);
                    res = dinero - apuesta;
                    label5.Text = Convert.ToString(res);
                    MessageBox.Show("NO Adivinaste el número correcto , has PERDIDO la apuesta.");
                    if(res<=0)
                    {
                        MessageBox.Show("Ya no tienes fondos para jugar.");
                        Form2 a = new Form2(res);
                        a.Show();
                        this.Hide();
                    }

                }

            }
            else
            {
                MessageBox.Show("No tienes dinero suficiente para apostar esa cantidad.");
            }




            //si le atinas
            //si le atinas
            

           // if (dinero > res)
            //{
              //  MessageBox.Show("No tienes la cantidad necesaria para apostar esa cantidad.");
                //Form2 a = new Form2(res);
                //a.Show();
                //this.Hide();
           // }
           // if (res == 0)
            //{
              //  MessageBox.Show("Ya no tienes dinero para jugar.");
                //Form2 a = new Form2(res);
                //a.Show();
                //this.Hide();
            //}
            
           

        }
        int color = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (color == 0)
            {
                numericUpDown1.BackColor = Color.Lime;
                numericUpDown2.BackColor = Color.CornflowerBlue;

                label3.ForeColor = Color.Brown;
                label3.BackColor = Color.LightGreen;
                label4.ForeColor = Color.Brown;
                label4.BackColor = Color.LightGreen;


                label2.ForeColor = Color.Black;
                label2.BackColor = Color.Blue;
                label6.ForeColor = Color.Black;
                label6.BackColor = Color.Blue;
                label5.ForeColor = Color.Black;
                label5.BackColor = Color.Blue;
                //
                label1.ForeColor = Color.Yellow;
                label1.BackColor = Color.Black;

                button2.ForeColor = Color.MediumPurple;
                button2.BackColor = Color.Maroon;
                //
                label7.ForeColor = Color.DeepPink;
                label7.BackColor = Color.Black;
                //
                label8.ForeColor = Color.DeepPink;
                label8.BackColor = Color.Black;

                button1.ForeColor = Color.DarkBlue;
                button1.BackColor = Color.White;
                color++;
            }
            else
            {
                numericUpDown1.BackColor = Color.CornflowerBlue;
                numericUpDown2.BackColor = Color.LightYellow;

                label3.ForeColor = Color.LightGreen;
                label3.BackColor = Color.Brown;
                label4.ForeColor = Color.LightGreen;
                label4.BackColor = Color.Brown;

                label2.ForeColor = Color.DarkTurquoise;
                label2.BackColor = Color.White;
                label6.ForeColor = Color.DarkTurquoise;
                label6.BackColor = Color.White;
                label5.ForeColor = Color.DarkTurquoise;
                label5.BackColor = Color.White;
                //


                button1.ForeColor = Color.White;
                button1.BackColor = Color.DarkBlue;
                //
                label1.ForeColor = Color.Black;
                label1.BackColor = Color.Yellow;

                label7.ForeColor = Color.Black;
                label7.BackColor = Color.DeepPink;
                //
                label8.ForeColor = Color.Black;
                label8.BackColor = Color.DeepPink;

                button2.ForeColor = Color.Red;
                button2.BackColor = Color.DarkBlue;
                color--;

            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
