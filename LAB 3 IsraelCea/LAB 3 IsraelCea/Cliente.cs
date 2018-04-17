using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_IsraelCea
{
    abstract class Cliente
    {
        string idCliente;
        public Cliente(string miId)
        {
            idCliente = miId;
        }
        abstract public bool DarPermisoBus();//otorga licencia de bus
        abstract public bool DarPermisoMaqP();//otorga licencia maquinaria pesada
    }

    


}
