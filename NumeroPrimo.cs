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
    public partial class NumeroPrimo : Form
    {
        public NumeroPrimo()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e) //Regressar al Main
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e) //Cerrar el programa
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //Botón
        {
            LogicaNumeroPrimo logicaNumeroPrimo = new LogicaNumeroPrimo();
            logicaNumeroPrimo.EncontrarPrimosYMostrarEnListBox(textBox1.Text, listBox1);
        }
    }
}