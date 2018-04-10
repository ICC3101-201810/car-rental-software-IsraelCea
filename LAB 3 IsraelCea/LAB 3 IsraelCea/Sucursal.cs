using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_IsraelCea
{
    class Sucursal
    {
        public string nombre;
        List<Vehiculo> vehiculosDisponibles;
        List<Accesorio> accesoriosDisponibles;
        public Sucursal(string elNombre, List<Vehiculo> vehic, List<Accesorio> acces)
        {
            nombre=elNombre;
            vehiculosDisponibles = vehic;
            accesoriosDisponibles = acces;
        }
        public string getNombre(Sucursal sucursal)
        {
            return sucursal.nombre;
        }
        
    }
}
