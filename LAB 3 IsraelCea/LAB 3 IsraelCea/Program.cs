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
            List<Sucursal> listaSucursales = new List<Sucursal>();
            /*List<Vehiculo> vehiculosBase = new List<Vehiculo>();
            Vehiculo vehiculoBase = new Vehiculo("Vehiculo base", "base", "base", 0);// Se agrega un vehículo base para no generar error al recorrer la lista por primera vez si no exite vehículos
            List<Accesorio> accesoriosBase = new List<Accesorio>();
            Accesorio accesorioBase = new Accesorio("Accesorio base", 0);
            accesoriosBase.Add(accesorioBase);
            vehiculosBase.Add(vehiculoBase);
            Sucursal sucursalBase = new Sucursal("Sucursal base", vehiculosBase, accesoriosBase);
            listaSucursales.Add(sucursalBase);*/
            string irAinicio = "si";
            while (irAinicio == "si")
            {
                Console.WriteLine("Seleccione una opción:" + "\n" + "1.Crear nueva sucursal" + "\n" + "2.Arrendar" + "\n" + "3.Correr simulación" + "\n" + "4.Salir");
                string opcionInicio = Console.ReadLine();

                if (opcionInicio == "1")
                {
                    /*Cliente cliente1 = new Cliente();
                    Cliente cliente2 = new Cliente();
                    List<Cliente> lista = new List<Cliente> { cliente1, cliente2 }*/
                    Console.WriteLine("Indique Nombre de la Nueva Sucursal:");
                    String nSucursal = Console.ReadLine();
                    List<Vehiculo> vehiculos = new List<Vehiculo>();
                    //vehiculos.Add(vehiculoBase);
                    List<Accesorio> accesorios = new List<Accesorio>();

                    //AGREGAR VEHICULO
                    Console.WriteLine("Agregar Vehículo?(responder si o no):");
                    string agregarV = Console.ReadLine();
                    while (agregarV == "si")
                    {
                        Console.WriteLine("Tipo de Vehiculo:");
                        string tV = Console.ReadLine();
                        Console.WriteLine("Patente:");
                        string patV = Console.ReadLine();
                        Console.WriteLine("Licencia Requerida:");
                        string lV = Console.ReadLine();
                        Console.WriteLine("Precio Diario Arriendo(CLP):");
                        string pV = Console.ReadLine();
                        int intpV = Convert.ToInt32(pV);
                        bool disponible= false;
    
                        Vehiculo Vehic = new Vehiculo(tV, patV, lV, intpV,disponible);
                        vehiculos.Add(Vehic);
                        Console.WriteLine("Agregar Nuevo Vehículo?(responder si o no):");
                        agregarV = Console.ReadLine();
                    }

                    //AGREGAR ACCESORIO
                    Console.WriteLine("Agregar Accesorio?(responder si o no):");
                    string agregarA = Console.ReadLine();
                    while (agregarA == "si")
                    {
                        Console.WriteLine("Tipo de Accesorio:");
                        string tA = Console.ReadLine();
                        Console.WriteLine("Precio Accesorio(CLP):");
                        string pA = Console.ReadLine();
                        int intpA = Convert.ToInt32(pA);
                        bool disponible = false;
                        Accesorio acces = new Accesorio(tA, intpA,disponible);
                        accesorios.Add(acces);
                        Console.WriteLine("Agregar Accesorio?(responder si o no):");
                        agregarA = Console.ReadLine();
                    }

                    Sucursal sucursal1 = new Sucursal(nSucursal, vehiculos, accesorios);
                    listaSucursales.Add(sucursal1);
                    Console.WriteLine("¿Volver a inicio?(si o no):");
                    irAinicio = Console.ReadLine();//Volver a inicio?
                }
                if (opcionInicio == "2")//Crear arriendo
                {
                    List<Arriendo> Arriendos = new List<Arriendo>();
                    Console.WriteLine("Seleccione Sucursal:"); //Se muestran sucursales disponibles
                    int i = 1;
                    foreach (Sucursal sucursal in listaSucursales)
                    {
                        Console.WriteLine(i+"."+sucursal.nombre);
                        i+=1;
                    }
                    string sucString = Console.ReadLine();
                    int indiceSucursal = Convert.ToInt32(sucString);//Indice en la lista de la sucursal elegida
                    Sucursal sucursalLocal = listaSucursales[indiceSucursal-1];
                    Console.WriteLine("Arrendará un vehículo en la sucursal '"+sucursalLocal.nombre+"'");
                    List<Vehiculo> vehiculos = sucursalLocal.vehiculosDisponibles;
                    List<Accesorio> accesorios = sucursalLocal.accesoriosDisponibles;
                    Console.WriteLine("Tenemos estos vehiculos disponibles en la sucursal" + sucursalLocal.nombre + "'");
                    int ii=1;
                    foreach (Vehiculo v in vehiculos)
                    {
                        Console.WriteLine(ii+". Vehículo:" + v.marca + "----Patente:" + v.patente);
                        ii += 1;
                    }

                }
                if (opcionInicio == "3")//Correr simulación
                {

                }

                if (opcionInicio == "4")
                {
                    Console.WriteLine("Programa Finalizado");
                }

                //Console.ReadKey();
            }
            Console.WriteLine("Programa Finalizado");
        }
    }
}
