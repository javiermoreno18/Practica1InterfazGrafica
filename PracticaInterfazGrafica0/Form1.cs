using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaInterfazGrafica0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Titulo 
            this.Text = "Francisco Javier Moreno Martinez";
            //Centrar Forms 
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            MessageBox.Show("Hola, bienvenido al programa "  +  texto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ROJO");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VERDE");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MORADO");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ROSA");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NARANJA");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AMARILLO");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AZUL");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
