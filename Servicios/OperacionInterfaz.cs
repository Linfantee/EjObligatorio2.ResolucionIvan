using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjObligatorio2.ResolucionIvan.Servicios
{
    internal interface OperacionInterfaz
    {
        public int añadirVenta(int valor);

        public int retirarDinero(int nuevaVenta);

        public int mostrarTotal(int valorAntiguo);
    }
}
