using edu.Ejercicio2_Prog.servicios;

namespace edu.Ejercicio2_Prog.controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// rbr - 131023
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada de la aplicación
        /// rbr - 131023
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Instancio la interfaz y el menu implementacion
            MenuInterfaz mi = new menuImplementacion();

            //Declaro las variables
            bool cerrarMenu = false;
            int opcion;

            while (!cerrarMenu)
            {
                //Muestro el menú por consola
                opcion = mi.mostrarMenu();
                switch(opcion)
                {
                    case 1:
                        cerrarMenu = true;
                        break;
                    case 2:
                        mi.suma();
                        break;
                    case 3: 
                        mi.resta();
                        break;
                    case 4:
                        mi.multiplicacion();
                        break;
                    case 5:
                        mi.division();
                        break;
                    default:
                        Console.WriteLine("No has seleccionado una opcion correcta");
                        break;
                }
            }
        }
    }
}