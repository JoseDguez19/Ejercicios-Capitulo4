using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Capitulo_4__WinForms_POO_.ClasesEjs
{
    public class LogicaTablasMultiplicar
    {
        private readonly TablasDeMultiplicar formulario;

        public LogicaTablasMultiplicar(TablasDeMultiplicar formulario)
        {
            this.formulario = formulario;
        }

        internal void CalcularTablaMultiplicar(int numero, Action<string> agregarItem)
        {
            throw new NotImplementedException();
        }
    }
    public void CalcularTablaMultiplicar(int numero, Action<string> agregarItem)
    {
        for (int i = 1; i <= 10; i++)
        {
            agregarItem($"{numero} x {i} = {numero * i}");
        }
    }
}
