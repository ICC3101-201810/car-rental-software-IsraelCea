using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_IsraelCea
{
    class Vehiculo
    {
        string tipo, licenciaRequerida;
        int precioDiario;
        public Vehiculo(string miTipo, string miLicencia, int miPrecio)
        {
            tipo = miTipo;
            licenciaRequerida = miLicencia;
            precioDiario = miPrecio;
        }
        
        
    }
}
