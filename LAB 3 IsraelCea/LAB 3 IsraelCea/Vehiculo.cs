﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_IsraelCea
{
    public class Vehiculo
    {
        public string marca, licenciaRequerida, patente;
        public int precioDiario;
        public bool disponible; //indica estado actual del vehiculo, true=arrendado, false=disponible

        public Vehiculo(string miMarca, string miPatente, string miLicencia, int miPrecio, bool estaDisponible)
        {
            marca = miMarca;
            patente = miPatente;
            licenciaRequerida = miLicencia;
            precioDiario = miPrecio;
            disponible = estaDisponible;
        }
        
        
    }
}
