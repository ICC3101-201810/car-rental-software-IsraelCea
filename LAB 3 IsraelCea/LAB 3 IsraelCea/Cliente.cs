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
        abstract public string getTipoCliente();
        abstract public bool otorgarLicenciaBus();//otorga licencia de bus
        abstract public bool otorgarLicenciaMaqP();//otorga licencia maquinaria pesada
    }

    


}
