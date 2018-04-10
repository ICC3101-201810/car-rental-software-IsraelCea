using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_IsraelCea
{
    class Persona
    {
        String nombre, apellido, tipoLicencia;
        int RUT, IDCliente;
        public Persona(string miNombre, string miApellido, int miRUT, string miTipoLicencia, int miIDCliente)
        {
            nombre = miNombre;
            apellido = miApellido;
            RUT = miRUT;
            tipoLicencia = miTipoLicencia;
            IDCliente = miIDCliente;
        }
    }
}
