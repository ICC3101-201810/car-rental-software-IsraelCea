using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_IsraelCea
{
    class Persona: Cliente
    {
        String nombre, apellido, tipoLicencia, idCliente;
        int RUT;
        bool permisoBus = false;
        bool permisoMaqP = false;
        public Persona(string miNombre, string miApellido, int miRUT, string miTipoLicencia, string miIDCliente)
            :base(miIDCliente)
        {
            nombre = miNombre;
            apellido = miApellido;
            RUT = miRUT;
            tipoLicencia = miTipoLicencia;
            idCliente = miIDCliente;
        }

        public override bool DarPermisoBus()
        {
            throw new NotImplementedException();
        }

        public override bool DarPermisoMaqP()
        {
            throw new NotImplementedException();
        }

    }
}
//persona.gettype.tostring() --------> guarda 'persona'