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
    public partial class Form3 : Form
    {
        int dinero;
        public Form3(int valor)
        {
            dinero=valor;
            total = valor;
            InitializeComponent();
            label7.Text = Convert.ToString(dinero);
        }
        SoundPlayer sonido = new SoundPlayer();
        SoundPlayer ganar = new SoundPlayer();
        SoundPlayer termino = new SoundPlayer();
        int contador = 240, ganadas = 0,apuesta,total;
         //label7.Text = Convert.ToString(dinero);
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2(total);
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                timer1.Enabled = true;
            }

            //sonido para cada clcick
            sonido.SoundLocation = "Depositar Moneda.wav";
            sonido.Play();
            Random numal = new Random();

            int f1, f2, f3;
            f1 = numal.Next(1, 8);
            f2 = numal.Next(1, 8);
            f3 = numal.Next(1, 8);


            if (f1 == 1)
            {
                pictureBox1.ImageLocation = "7.JPG";

            }
            if (f1 == 2)
            {
                pictureBox1.ImageLocation = "bar.jpg";

            }
            if (f1 == 3)
            {
                pictureBox1.ImageLocation = "cereza.jpg";

            }
            if (f1 == 4)
            {
                pictureBox1.ImageLocation = "Sandia.jpg";

            }
            if (f1 == 5)
            {
                pictureBox1.ImageLocation = "K.jpg";

            }
            if (f1 == 6)
            {
                pictureBox1.ImageLocation = "mora.jpg";

            }
            if (f1 == 7)
            {
                pictureBox1.ImageLocation = "Wild.jpg";

            }
            //imagen 2 
            if (f2 == 1)
            {
                pictureBox2.ImageLocation = "7.JPG";

            }
            if (f2 == 2)
            {
                pictureBox2.ImageLocation = "bar.jpg";

            }
            if (f2 == 3)
            {
                pictureBox2.ImageLocation = "cereza.jpg";

            }
            if (f2 == 4)
            {
                pictureBox2.ImageLocation = "Sandia.jpg";

            }
            if (f2 == 5)
            {
                pictureBox2.ImageLocation = "K.jpg";

            }
            if (f2 == 6)
            {
                pictureBox2.ImageLocation = "mora.jpg";

            }
            if (f2 == 7)
            {
                pictureBox2.ImageLocation = "Wild.jpg";

            }
            //iamgen 3 
            if (f3 == 1)
            {
                pictureBox3.ImageLocation = "7.JPG";

            }
            if (f3 == 2)
            {
                pictureBox3.ImageLocation = "bar.jpg";

            }
            if (f3 == 3)
            {
                pictureBox3.ImageLocation = "cereza.jpg";

            }
            if (f3 == 4)
            {
                pictureBox3.ImageLocation = "Sandia.jpg";

            }
            if (f3 == 5)
            {
                pictureBox3.ImageLocation = "K.jpg";

            }
            if (f3 == 6)
            {
                pictureBox3.ImageLocation = "mora.jpg";

            }
            if (f3 == 7)
            {
                pictureBox3.ImageLocation = "Wild.jpg";

            }
            //ganar
            if ((f1 == f2) && (f2 == f3))
            {
                sonido.SoundLocation = "Premio.wav";
                sonido.Play();
                MessageBox.Show("GANASTE!! RECOGE TU PREMIO");
                ganadas++;
                
                label4.Text = ":    " + ganadas.ToString();
            }
            //del dinerooooo
            if ((f1 == f2) && (f2 == f3))
            {
                dinero = Convert.ToInt32(label7.Text);
                apuesta = Convert.ToInt32(label5.Text);
                total = dinero + apuesta;
                label7.Text = Convert.ToString(total);

            }
            else
            {
                dinero = Convert.ToInt32(label7.Text);
                apuesta = Convert.ToInt32(label5.Text);
                total = dinero - apuesta;
                label7.Text = Convert.ToString(total);
            }
            if (total == 0)
            {
                MessageBox.Show("Te quedaste sin dinero , ya no puedes seguir jugando.");
                Form2 a = new Form2(total);
                a.Show();
                this.Hide();
            }
           


            

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
        //colores
            



            //
            contador--;
            textBox1.Text = contador.ToString();
            int a = contador / 60;
            int b = contador - (a * 60);
            if (b < 10)
            {
                label3.Text = (a.ToString() + ":0" + b.ToString());
            }
            else
            {
                label3.Text = (a.ToString() + ":" + b.ToString());
            }
            if (contador == 0)
            {

                timer1.Stop();
                termino.SoundLocation = "premio bajo.wav";
                termino.Play();
                MessageBox.Show("El tiempo se acabo :( ");
                Form2 z = new Form2(total);
                z.Show();
                this.Hide();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        int color = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (color == 0)
            {
                //
                label1.ForeColor = Color.Yellow;
                label1.BackColor = Color.Black;
                //
                label2.ForeColor = Color.BlueViolet;
                label2.BackColor = Color.Black;
                //
                label3.ForeColor = Color.Gold;
                label3.BackColor = Color.Black;
                //
                label4.ForeColor = Color.BlueViolet;
                label4.BackColor = Color.Black;
                //
                label5.ForeColor = Color.BlueViolet;
                label5.BackColor = Color.Black;
                //
                label6.ForeColor = Color.Black;
                label6.BackColor = Color.LightSkyBlue;
                //
                label7.ForeColor = Color.Black;
                label7.BackColor = Color.LightSkyBlue;
                //
                label8.ForeColor = Color.BlueViolet;
                label8.BackColor = Color.Black;
                //
                label9.ForeColor = Color.Gold;
                label9.BackColor = Color.Black;
                //
                label10.ForeColor = Color.Gold;
                label10.BackColor = Color.Black;
                //
                label11.ForeColor = Color.DeepPink;
                label11.BackColor = Color.Black;
                //
                label12.ForeColor = Color.DeepPink;
                label12.BackColor = Color.Black;
                //
                button1.ForeColor = Color.DarkBlue;
                button1.BackColor = Color.White;
                //
                button2.ForeColor = Color.MediumPurple; 
                button2.BackColor = Color.Maroon;
                
                color++;
            }
            else
            {
                //
                label1.ForeColor = Color.Black;
                label1.BackColor = Color.Yellow;
                //
                label2.ForeColor = Color.Coral;
                label2.BackColor = Color.Black;
                //
                label3.ForeColor = Color.DeepPink;
                label3.BackColor = Color.Black;
                //
                label4.ForeColor = Color.Coral;
                label4.BackColor = Color.Black;
                //
                label5.ForeColor = Color.DeepPink;
                label5.BackColor = Color.Black;
                //
                label6.ForeColor = Color.Orange;
                label6.BackColor = Color.White;
                //
                label7.ForeColor = Color.Orange;
                label7.BackColor = Color.White;
                //
                label8.ForeColor = Color.DeepPink;
                label8.BackColor = Color.Black;
                //
                label9.ForeColor = Color.DeepPink;
                label9.BackColor = Color.Black;
                //
                label10.ForeColor = Color.DeepPink;
                label10.BackColor = Color.Black;

                label11.ForeColor = Color.Black;
                label11.BackColor = Color.DeepPink;
                //
                label12.ForeColor = Color.Black;
                label12.BackColor = Color.DeepPink;
                //
                button1.ForeColor = Color.White;
                button1.BackColor = Color.DarkBlue;
                button2.ForeColor = Color.Red;
                button2.BackColor = Color.DarkBlue;
                color--;

            }

        }
    }
}
