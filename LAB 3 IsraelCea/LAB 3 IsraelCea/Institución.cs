using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_IsraelCea
{
    class Institucion: Cliente
    { string nombre,idCliente;
        bool permisoBus;
        bool permisoMaqP = false;
        public Institucion(string miNombre, string miID, bool permisoB)
            :base(miID)
        {
            nombre = miNombre;
            idCliente = miID;
            permisoBus = permisoB;//58%
        }
        public bool getPermisoMaquinaria()
        {
            return permisoMaqP;
        }

        public bool getPermisoBus()
        {
            return permisoBus;
        }

        public override bool DarPermisoBus()
        {
            Random rnd = new Random();
            int probabilidad = rnd.Next(1, 100); // creates a number between 1 and 100
            if (0 <= probabilidad && probabilidad >= 58)
            {
                permisoBus = true;
            }
            else
            {
                permisoBus = false;
            }

            throw new NotImplementedException();
        }


        public override bool DarPermisoMaqP()
        {
            permisoMaqP = false;
            throw new NotImplementedException();
        }
    }
}
