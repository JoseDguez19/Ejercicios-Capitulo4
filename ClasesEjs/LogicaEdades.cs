using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Capitulo_4__WinForms_POO_.ClasesEjs
{
    internal class LogicaEdades
    {
        private int[] edades;

        public LogicaEdades()
        {
            // Constructor de la clase lógica
        }

        public void ProcesarEdades(string input)
        {
            // Obtener el número de personas
            int numeroPersonas;
            if (!int.TryParse(input, out numeroPersonas) || numeroPersonas <= 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido de personas.", "Error");
                return;
            }

            // Inicializar el array de edades
            edades = new int[numeroPersonas];

            // Leer las edades ingresadas por el usuario y almacenarlas en el array
            for (int i = 0; i < numeroPersonas; i++)
            {
                string edadString = PedirEdad($"Ingrese la edad de la persona {i + 1}:");
                if (!int.TryParse(edadString, out int edad) || edad < 0)
                {
                    MessageBox.Show("Por favor, ingrese una edad válida.", "Error");
                    return;
                }
                edades[i] = edad;
            }
        }

        private string PedirEdad(string mensaje)
        {
            Form prompt = new Form()
            {
                Width = 200,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = mensaje,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 20, Top = 20, Text = "Edad:" };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 150 };
            Button confirmation = new Button() { Text = "Ok", Left = 50, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "0";
        }

        public string ObtenerResultado1()
        {
            // Calcular la mayor y menor edad
            int mayorEdad = CalcularMayorEdad();
            int menorEdad = CalcularMenorEdad();
            return $"La edad mayor es: {mayorEdad} años\nLa edad menor es: {menorEdad} años";
        }

        public string ObtenerResultado2()
        {
            // Calcular el promedio de edades
            int promedioEdades = CalcularPromedioEdades();
            return $"El promedio de edades es: {promedioEdades} años";
        }

        private int CalcularMayorEdad()
        {
            int mayorEdad = int.MinValue;
            foreach (int edad in edades)
            {
                if (edad > mayorEdad)
                {
                    mayorEdad = edad;
                }
            }
            return mayorEdad;
        }

        private int CalcularMenorEdad()
        {
            int menorEdad = int.MaxValue;
            foreach (int edad in edades)
            {
                if (edad < menorEdad)
                {
                    menorEdad = edad;
                }
            }
            return menorEdad;
        }

        private int CalcularPromedioEdades()
        {
            int sumaEdades = 0;
            foreach (int edad in edades)
            {
                sumaEdades += edad;
            }
            return sumaEdades / edades.Length;
        }
    }
}
