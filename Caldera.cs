using Ejercicios_Capitulo_4__WinForms_POO_.ClasesEjs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ejercicios_Capitulo_4__WinForms_POO_.ClasesEjs.LogicaCaldera;

namespace Ejercicios_Capitulo_4__WinForms_POO_
{
    public partial class Caldera : Form
    {
        private CalderaLogica logica;

        public Caldera()
        {
            InitializeComponent();
            logica = new CalderaLogica();
            logica.InicializarTemperatura();
            ActualizarTemperatura();
        }

        private void button1_Click(object sender, EventArgs e) //Temperatura aceptable
        {
            logica.VerificarTemperatura(true);
            ActualizarTemperatura();
        }

        private void button2_Click(object sender, EventArgs e) //Temperatura no aceptable
        {
            logica.VerificarTemperatura(false);
            ActualizarTemperatura();
        }

        private void ActualizarTemperatura()
        {
            textBox1.Text = logica.ObtenerTemperaturaActual() + "°C";
        }

        private void button7_Click(object sender, EventArgs e) //regresar al main
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e) //Cerrar programa
        {
            this.Close();
        }
    }
}

