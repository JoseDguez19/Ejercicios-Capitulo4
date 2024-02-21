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
    
    public partial class TablasDeMultiplicar : Form
    {
        private readonly LogicaTablasMultiplicar logica;

        public TablasDeMultiplicar(LogicaTablasMultiplicar logica)
        {
            InitializeComponent();
            this.logica = logica;
        }

        private void button1_Click(object sender, EventArgs e) //Boton calcular tabla de multiplicar
        {
            int numero;
            if (int.TryParse(textBox1.Text, out numero))
            {
                listBox1.Items.Clear();
                logica.CalcularTablaMultiplicar(numero, AgregarItem);
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido.");
            }
        }

        private void AgregarItem(string item)
        {
            listBox1.Items.Add(item);
        }

        private void button7_Click(object sender, EventArgs e) //Regresar al main
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e) // Cerrar el programa
        {
            this.Close();
        }
    }
}