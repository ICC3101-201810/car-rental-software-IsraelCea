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
        bool permisoBus;//35%
        bool permisoMaqP;//NO
        public Organizacion(string miNombre, string miID)
            : base(miID)
        {
            nombre = miNombre;
            idCliente = miID;

        }


        public override bool DarPermisoBus()
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

        public override bool DarPermisoMaqP()
        {
            permisoMaqP = false;
            throw new NotImplementedException();
        }
    }
}

 