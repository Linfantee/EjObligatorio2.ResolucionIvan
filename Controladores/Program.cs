using EjObligatorio2.ResolucionIvan.Servicios;

namespace EjObligatorio2.ResolucionIvan;

class Program
{

    public static void Main(string[] args)
    {
        MenuInterfaz mi = new MenuImplementacion();
        OperacionInterfaz oi = new OperacionImplementacion();

        int venta = 0;
        bool cerrarMenu = false;
        int opcionSeleccionada;


        while (!cerrarMenu)
        {
            opcionSeleccionada = mi.mostrarMenuYSeleccion();

            switch (opcionSeleccionada)
            {
                case 0:
                    Console.WriteLine("-Añadir dinero:");
                    oi.añadirVenta(venta);
                    break;
                case 1:
                    Console.WriteLine("-Retirar dinero:");
                    oi.retirarDinero(venta);
                    break;
                case 2:
                    Console.WriteLine("");
                    oi.mostrarTotal(venta);
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("Se ha cerrado Menú.");
                    cerrarMenu = true;
                    break;
                default:
                    Console.WriteLine("La opción seleccionada no existe, escoja otra por favor:");
                    break;

            }
        }



    }



}
