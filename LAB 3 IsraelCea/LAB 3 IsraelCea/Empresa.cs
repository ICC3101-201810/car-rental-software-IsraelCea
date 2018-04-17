using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_IsraelCea
{
    class Empresa: Cliente
    {
        string nombre, idCliente;
        int RUT;
        bool permisoMaqP;//63%
        bool permisoBus;//80%
        public Empresa(string miNombre, string miID, int miRUT)
            : base(miID)
        {
            nombre = miNombre;
            idCliente = miID;
            RUT = miRUT;
            
        }


        public override bool DarPermisoMaqP()
        {
            Random rnd = new Random();
            int probabilidad = rnd.Next(1, 100); // creates a number between 1 and 100
            if (0 <= probabilidad && probabilidad >= 63)
            {
                permisoMaqP = true;
            }
            else
            {
                permisoMaqP = false;
            }

            throw new NotImplementedException();
        }

        public override bool DarPermisoBus()
        {
            Random rnd = new Random();
            int probabilidad = rnd.Next(1, 100); // creates a number between 1 and 100
            if (0 <= probabilidad && probabilidad >= 80)
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
