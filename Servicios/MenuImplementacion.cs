using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjObligatorio2.ResolucionIvan.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int mostrarMenuYSeleccion()
        {
            int seleccion;

            Console.WriteLine("#########################################");
            Console.WriteLine("0. -Añadir dinero: ");
            Console.WriteLine("1. -Retirar dinero: ");
            Console.WriteLine("2. -Dinero restante en la cuenta: ");
            Console.WriteLine("3. -Cerrar menú: ");
            Console.WriteLine("#########################################");
            seleccion = Console.ReadKey(true).KeyChar - ('0');

            return seleccion;




        }


    }
}
