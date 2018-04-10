using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_IsraelCea
{
    class Empresa
    {
        string nombre;
        int RUT;
        List<Vehiculo> vehiculosAutorizados;
        public Empresa(string miNombre, int miRUT, List<Vehiculo> misVehiculos)
        {
            nombre = miNombre;
            RUT = miRUT;
            vehiculosAutorizados = misVehiculos;
        }
    }
}
