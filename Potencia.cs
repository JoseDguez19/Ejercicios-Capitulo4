using Ejercicios_Capitulo_4__WinForms_POO_.ClasesEjs;
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
    public partial class Potencia : Form
    {
        public Potencia()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LogicaPotencia logicaPotencia = new LogicaPotencia();
            logicaPotencia.CalcularPotenciaYMostrarResultado(textBox1.Text, textBox2.Text, textBox3);
        }
    }
}