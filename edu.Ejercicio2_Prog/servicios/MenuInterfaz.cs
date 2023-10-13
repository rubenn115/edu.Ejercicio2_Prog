using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Ejercicio2_Prog.servicios
{
    /// <summary>
    /// Esta es la interfaz donde estarán los métodos enunciados
    /// rbr - 131023
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Llamada al método que mostrará el menú por consola
        /// rbr - 131023
        /// </summary>
        /// <returns></returns>
        public int mostrarMenu();

        /// <summary>
        /// Llamada al método para sumar
        /// rbr - 131023
        /// </summary>
        public void suma();

        /// <summary>
        /// Llamada al método para restar
        /// rbr - 131023
        /// </summary>
        public void resta();

        /// <summary>
        /// Llamada al método para multiplicar
        /// rbr - 131023
        /// </summary>
        public void multiplicacion();

        /// <summary>
        /// Llamada al método para dividir
        /// rbr - 131023
        /// </summary>
        public void division();
    }
}
