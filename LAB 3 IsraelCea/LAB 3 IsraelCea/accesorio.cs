using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_IsraelCea
{
    class Accesorio
    {
        string nombre;
        int precio;
        bool arrendado;//indica estado actual del accesorio, true=arrendado, false=disponible
        public Accesorio(string miN, int miP, bool estaArrendado)
        {
            nombre = miN;
            precio = miP;
            arrendado = estaArrendado;
        }
    }
}
