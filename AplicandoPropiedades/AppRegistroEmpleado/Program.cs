using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRegistroEmpleado
{
    class Program{
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado(1233, 5218800, "Dani", "Grovver", "Milena", 6777, "Jefe");
            int opcion = 1;
            while (opcion != -1)
            {
                empleado.VisualizarEmpleado();
                Console.WriteLine("##################################################");
                Console.WriteLine("App de registro de un empleado");
                Console.WriteLine("PRESIONE 1 PARA ACTUALIZAR COD DE EMPLEADO");
                Console.WriteLine("PRESIONE 2 PARA ACTUALIZAR CI DE EMPLEADO");
                Console.WriteLine("PRESIONE 3 PARA ACTUALIZAR NOMBRES DE EMPLEADO");
                Console.WriteLine("PRESIONE 4 PARA ACTUALIZAR 1ER APELLIDO DE EMPLEADO");
                Console.WriteLine("PRESIONE 5 PARA ACTUALIZAR 2DO APELLIDO DE EMPLEADO");
                Console.WriteLine("PRESIONE 6 PARA ACTUALIZAR SALARIO DE EMPLEADO");
                Console.WriteLine("PRESIONE 7 PARA ACTUALIZAR CARGO DE EMPLEADO");
                Console.WriteLine("PRESIONE 8 PARA SALIR");
                Console.WriteLine("######################################################");

                Console.WriteLine("ingrese la opcion que requiera");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese nuevo cod de empleado");
                        int codigo = int.Parse(Console.ReadLine());
                        //seteando llave = propiedad cubo = medoto
                        empleado.CodEmpleado = codigo;
                        Console.WriteLine("Nuevo cod:" + empleado.CodEmpleado);
                        Console.WriteLine("##################################");
                        break;
                    case 2:
                        Console.WriteLine("Ingrese nuevo Ci de empleado");
                        int cii = int.Parse(Console.ReadLine());
                        empleado.Ci = cii;
                        Console.WriteLine("Nuevo CI:" + empleado.Ci);
                        Console.WriteLine("##################################");
                        break;
                    case 3:
                        Console.WriteLine("Ingrese nuevo Nombre de empleado");
                        string name = Console.ReadLine();
                        empleado.Nombres = name;
                        Console.WriteLine("Nuevo Nombre:" + empleado.Nombres);
                        Console.WriteLine("##################################");
                        break;
                    case 4:
                        Console.WriteLine("Ingrese nuevo Primer Apellido de empleado");
                        string pa = Console.ReadLine();
                        empleado.PrimerApellido = pa;
                        Console.WriteLine("Nuevo 1er Apellido:" + empleado.PrimerApellido);
                        Console.WriteLine("##################################");
                        break;
                    case 5:
                        Console.WriteLine("Ingrese nuevo Segundo Apellido de empleado");
                        string sa = Console.ReadLine();
                        empleado.PrimerApellido = sa;
                        Console.WriteLine("Nuevo 2do Apellido:" + empleado.SegundoApellido);
                        Console.WriteLine("##################################");
                        break;
                    case 6:
                        Console.WriteLine("Ingrese nuevo Primer Apellido de empleado");
                        int sal = int.Parse(Console.ReadLine());
                        empleado.Salario = sal;
                        Console.WriteLine("Nuevo Salario Apellido:" + empleado.Salario);
                        Console.WriteLine("##################################");
                        break;
                    case 7:
                        Console.WriteLine("Ingrese nuevo Cargo de empleado");
                        string car = Console.ReadLine();
                        empleado.Cargo= car;
                        Console.WriteLine("Nuevo Cargo:" + empleado.Cargo);
                        Console.WriteLine("##################################");
                        break;
                    case 8:
                        opcion = -1;
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion correcta por favor");
                        Console.WriteLine("#####################################");
                        break;
                }
            }
        }
    }
}
