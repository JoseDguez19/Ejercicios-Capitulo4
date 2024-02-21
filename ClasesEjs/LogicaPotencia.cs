using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Capitulo_4__WinForms_POO_.ClasesEjs
{
    public class LogicaPotencia
    {
        public void CalcularPotenciaYMostrarResultado(string numeroText, string potenciaText, TextBox textBoxResultado)
        {
            double numero;
            int potencia;

            if (double.TryParse(numeroText, out numero) && int.TryParse(potenciaText, out potencia))
            {
                // Calcular el resultado de la potencia
                double resultado = Math.Pow(numero, potencia);

                // Mostrar el resultado en el cuadro de texto de resultado
                textBoxResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos para el cálculo de la potencia.");
            }
        }
    }
}
