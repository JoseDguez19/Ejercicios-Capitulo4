using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Capitulo_4__WinForms_POO_.ClasesEjs
{
    internal class LogicaCaldera
    {
        public class CalderaLogica
        {
            private const int TemperaturaMaxima = 180;
            private const int TemperaturaMinima = 32;
            private int temperaturaActual;
            private bool temperaturaAceptable = false;
            private Random random = new Random();
            private int resta;

            public void InicializarTemperatura()
            {
                resta = random.Next(1, 11);
                temperaturaActual = random.Next(TemperaturaMinima, TemperaturaMaxima + 1);
            }

            public int ObtenerTemperaturaActual()
            {
                return temperaturaActual;
            }

            public void VerificarTemperatura(bool aceptable)
            {
                temperaturaAceptable = aceptable;

                if (temperaturaAceptable)
                {
                    MessageBox.Show("La temperatura actual es aceptable.", "Temperatura Aceptable");
                }
                else
                {
                    temperaturaActual -= resta;
                    if (temperaturaActual <= TemperaturaMinima || temperaturaActual < 28)
                    {
                        temperaturaActual = TemperaturaMinima;
                        MessageBox.Show("Esta es la temperatura mínima aceptable.", "Temperatura Mínima Aceptable");
                        temperaturaAceptable = true;
                    }
                }
            }
        }
    }
}
