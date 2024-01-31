using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjObligatorio2.ResolucionIvan.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        int valorAntiguo;

        public int añadirVenta(int valorAntiguo)
        {
            int valorNuevo = 0;

            Console.WriteLine("¿Cuanto dinero quiere añadir?");
            int nuevaVenta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Se añadió " + nuevaVenta + " euros a la cuenta.");
            nuevaVenta = valorNuevo + valorAntiguo;
          
            return valorNuevo;

        }

        public int retirarDinero(int valorAntiguo)
        {

            int valorNuevo = 0;

            Console.WriteLine("¿Cuanto dinero quiere retirar?");
            int eliminarDinero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Se retiró " + eliminarDinero + " euros de la cuenta.");
            eliminarDinero = valorNuevo - valorAntiguo;
           
            return valorNuevo;

        }

        public int mostrarTotal(int valorAntiguo)
        {
           
            Console.WriteLine("-Dinero restante en la cuenta: " + valorAntiguo);

            return valorAntiguo;
        }

    }
}
