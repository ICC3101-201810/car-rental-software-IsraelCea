using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_IsraelCea
{
    class Organizacion : Cliente
    {
        string nombre, idCliente;
        bool permisoBus;
        bool permisoMaqP=false;
        string tipoCliente="ORG";
        public Organizacion(string miNombre, string miID, bool permisoB)
            : base(miID)
        {
            nombre = miNombre;
            idCliente = miID;
            permisoBus = permisoB;//35%

        }

        public bool getPermisoMaquinaria()
        {
            return permisoMaqP;
        }

        public bool getPermisoBus()
        {
            return permisoBus;
        }
        public override string getTipoCliente()
        {
            return tipoCliente;
        }

        public override bool otorgarLicenciaBus()
        {
            Random rnd = new Random();
            int probabilidad = rnd.Next(1, 100); // creates a number between 1 and 100
            if (0 <= probabilidad && probabilidad >= 35)
            {
                permisoBus = true;
            }
            else
            {
                permisoBus = false;
            }

            throw new NotImplementedException();
        }
    }
}

