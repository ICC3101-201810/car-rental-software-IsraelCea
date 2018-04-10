using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_IsraelCea
{
    class Vehiculo
    {
        string tipo, licenciaRequerida, patente;
        int precioDiario;
        bool arrendado; //indica estado actual del vehiculo, true=arrendado, false=disponible
        public Vehiculo(string miTipo, string miPatente, string miLicencia, int miPrecio, bool estaArrendado)
        {
            tipo = miTipo;
            patente = miPatente;
            licenciaRequerida = miLicencia;
            precioDiario = miPrecio;
            arrendado = estaArrendado;
        }
        
        
    }
}
