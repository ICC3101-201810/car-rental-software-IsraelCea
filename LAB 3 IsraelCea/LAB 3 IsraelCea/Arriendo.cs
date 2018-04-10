using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_IsraelCea
{
    class Arriendo
    {
        Persona cliente;
        Vehiculo vehiculo;
        Sucursal sucursal;
        List<Accesorio> accesorios;
        DateTime fechaInicio;
        DateTime fechaFin;
        int total;
        public Arriendo(Persona elCl, Vehiculo elVe, Sucursal laSuc
                        ,List<Accesorio> losAcc, DateTime FI, DateTime FF
                        , int elTotal)
        {
            cliente = elCl;
            vehiculo = elVe;
            sucursal = laSuc;
            accesorios = losAcc;
            fechaInicio = FI;
            fechaFin = FF;
            total = elTotal;

        }
    }
}
