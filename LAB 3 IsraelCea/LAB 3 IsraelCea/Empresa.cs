﻿using System;
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
        bool licenciaMaqPesada,permisoBus;
        string tipoCliente = "EMP";
        public Empresa(string miNombre, string miID, int miRUT, bool lBus, bool lMaqP)
            : base(miID)
        {
            nombre = miNombre;
            idCliente = miID;
            RUT = miRUT;
            licenciaBus = lBus;//80%
            licenciaMaqPesada = lMaqP;//63%
            
        }
        public override string getTipoCliente()
        {
            return tipoCliente;
        }
        public override bool otorgarLicenciaBus()
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
