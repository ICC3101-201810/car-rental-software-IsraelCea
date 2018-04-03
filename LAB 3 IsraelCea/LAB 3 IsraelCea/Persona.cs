using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_IsraelCea
{
    class Persona: Cliente
    {
        String nombre, apellido, tipoLicencia;
        int RUT;
        public Persona(string miNombre, string miApellido, int miRUT, string miTipoLicencia)
        {
            nombre = miNombre;
            apellido = miApellido;
            RUT = miRUT;
            tipoLicencia = miTipoLicencia;
        }
    }
}
