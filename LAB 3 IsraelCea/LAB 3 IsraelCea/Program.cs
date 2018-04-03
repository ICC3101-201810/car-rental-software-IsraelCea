using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_IsraelCea
{
    class Program
    {
        static void Main(string[] args)
        {
            Sucursales sucursales = new Sucursales();
            List<string> Columns = new List<string>();
            Console.WriteLine("Indique Nombre de la Nueva Sucursal:");
            String nSucursal = Console.ReadLine();
            List<Vehiculo> vehiculos = new List<Vehiculo>();


            //AGREGAR VEHICULO
            Console.WriteLine("Agregar Vehículo?(responder si o no):");
            string agregarV = Console.ReadLine();
            while (agregarV == "si")
            {
                Console.WriteLine("Tipo de Vehiculo:");
                string tV = Console.ReadLine();
                Console.WriteLine("Licencia Requerida:");
                string lV = Console.ReadLine();
                Console.WriteLine("Precio Diario Arriendo(CLP):");
                string pV = Console.ReadLine();
                int intpV = Convert.ToInt32(pV);
                Vehiculo Vehic = new Vehiculo(tV,lV,intpV);
                vehiculos.Add(Vehic);
                Console.WriteLine("Agregar Nuevo Vehículo?(responder si o no):");
                agregar = Console.ReadLine();
            }


            //AGREGAR ACCESORIO
            Console.WriteLine("Agregar Vehículo?(responder si o no):");
            string agregarA = Console.ReadLine();
            while (agregarA == "si")
            {
                Console.WriteLine("Tipo de Vehiculo:");
                string tV = Console.ReadLine();
                Console.WriteLine("Licencia Requerida:");
                string lV = Console.ReadLine();
                Console.WriteLine("Precio Diario Arriendo(CLP):");
                string pV = Console.ReadLine();
                int intpV = Convert.ToInt32(pV);
                Vehiculo Vehic = new Vehiculo(tV, lV, intpV);
                vehiculos.Add(Vehic);
                Console.WriteLine("Agregar Nuevo Vehículo?(responder si o no):");
                agregarA = Console.ReadLine();
            }

            Sucursal sucursal1 = new Sucursal(nSucursal);
            sucursales.sucursalesTodas.add(sucursal1);

            Console.ReadKey();
        }
    }
}
