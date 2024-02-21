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
using System.Windows.Forms.VisualStyles;

namespace Ejercicios_Capitulo_4__WinForms_POO_
{
    public partial class Edades : Form
    {
      
        public Edades()
        {
            InitializeComponent();
        }
        private void button7_Click(object sender, EventArgs e)//Regresar
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void button8_Click(object sender, EventArgs e)//Salir
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase de lógica
            LogicaEdades logicaEdades = new LogicaEdades();

            // Llamar al método de la clase de lógica para procesar las edades
            logicaEdades.ProcesarEdades(textBox1.Text);

            // Obtener y mostrar los resultados utilizando métodos de la clase de lógica
            label2.Text = logicaEdades.ObtenerResultado1();
            textBox2.Text = logicaEdades.ObtenerResultado2();
        }

    

    }
}
