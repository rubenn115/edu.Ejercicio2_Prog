using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Ejercicio2_Prog.servicios
{
    internal class menuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Método que mostrará el menú por consola
        /// rbr - 131023
        /// </summary>
        /// <returns></returns>
        public int mostrarMenu()
        {
            int opcion;
            Console.WriteLine("###########################");
            Console.WriteLine("           MENU            ");
            Console.WriteLine("###########################");
            Console.WriteLine("1. Cerrar");
            Console.WriteLine("2. Suma");
            Console.WriteLine("3. Resta");
            Console.WriteLine("4. Multiplicacion");
            Console.WriteLine("5. Division");
            Console.WriteLine("###########################");
            Console.WriteLine("                           ");
            Console.WriteLine("Seleccione la opción que desee");

            opcion = Console.ReadKey(true).KeyChar - '0';
            return opcion;
        }

        /// <summary>
        /// Método para realizar una suma
        /// rbr - 131023
        /// </summary>
        public void suma()
        {
            int operando1, operando2;
            Console.WriteLine("Has seleccionado la opcion para sumar.");
            Console.WriteLine("Introduce el primer operando:");
            operando1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo operando: ");
            operando2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado la suma es: " + (operando1+operando2));
        }

        /// <summary>
        /// Método para realizar una resta
        /// rbr - 131023
        /// </summary>
        public void resta()
        {
            int operando1, operando2;
            Console.WriteLine("Has seleccionado la opcion para restar.");
            Console.WriteLine("Introduce el primer operando:");
            operando1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo operando: ");
            operando2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado la resta es: " + (operando1 - operando2));
        }

        /// <summary>
        /// Método para realizar una multiplicacion
        /// rbr - 131023
        /// </summary>
        public void multiplicacion()
        {
            int operando1, operando2;
            Console.WriteLine("Has seleccionado la opcion para multiplicar.");
            Console.WriteLine("Introduce el primer operando:");
            operando1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo operando: ");
            operando2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado la multiplicacion es: " + (operando1 * operando2));
        }

        /// <summary>
        /// Método para realizar una division
        /// rbr - 131023
        /// </summary>
        public void division()
        {
            int operando1, operando2;
            Console.WriteLine("Has seleccionado la opcion para dividir.");
            Console.WriteLine("Introduce el primer operando:");
            operando1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo operando: ");
            operando2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado la division es: " + (operando1 / operando2));
        }
    }
}
