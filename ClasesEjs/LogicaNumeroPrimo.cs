using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Capitulo_4__WinForms_POO_.ClasesEjs
{
  
        public class LogicaNumeroPrimo
        {
            public void EncontrarPrimosYMostrarEnListBox(string cantidadText, ListBox listBox)
            {
                int CAM, CM, n, i;
                bool primo;

                if (int.TryParse(cantidadText, out CAM))
                {
                    listBox.Items.Clear();
                    listBox.Items.Add("");
                    CM = 1;
                    n = 3;
                    string row = ""; // Variable para almacenar los primos de cada fila
                    while (CM < CAM)
                    {
                        primo = true;
                        for (i = 3; i <= Math.Sqrt(n); i += 2)
                        {
                            if (n % i == 0)
                            {
                                primo = false;
                            }
                        }
                        if (primo)
                        {
                            CM++;
                            row += " " + n;
                            if (CM % 10 == 0) // Si hemos alcanzado 10 números primos en la fila
                            {
                                row += Environment.NewLine; // Agregamos un salto de línea al final de la fila
                                listBox.Items.Add(row); // Agregamos la fila al ListBox
                                row = ""; // Reiniciamos la fila para la próxima serie de primos
                            }
                        }
                        n += 2; // Incrementamos en 2 para evitar números pares
                    }
                    // Añadimos la última fila si quedan números primos
                    if (!string.IsNullOrEmpty(row))
                    {
                        listBox.Items.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido para la cantidad de números primos a mostrar.");
                }
            }
        }
    
}
