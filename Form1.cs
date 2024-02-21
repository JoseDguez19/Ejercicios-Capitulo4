using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Capitulo_4__WinForms_POO_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Tablas de multiplicar.
        {
            TablasDeMultiplicar tablasDeMultiplicar = new TablasDeMultiplicar();
            tablasDeMultiplicar.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumeroPrimo numeroPrimo = new NumeroPrimo();
            numeroPrimo.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Caldera caldera = new Caldera();
            caldera.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Edades edades = new Edades();
            edades.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Potencia potencia = new Potencia();
            potencia.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
