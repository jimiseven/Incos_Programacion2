using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRegistroEmpleado
{
    class Program
    {
        static void Main(string[] args)
        {


            Empleado empleado = new Empleado(12234, 9998763, "gino anibal", "torrico", "peredo", 5000, "empleado");

            int opcion = 1;
            while (opcion != -1)
            {

                empleado.VisualizarEmpleado();
                Console.WriteLine("##################################################");
                Console.WriteLine("PRESIONE 1 PARA ACTUALIZAR CODIGO EMPLEADO ");
                Console.WriteLine("PRESIONE 2 PARA ACTUALIZAR CI");
                Console.WriteLine("PRESIONE 3 PARA ACTUALIZAR NOMBRES");
                Console.WriteLine("PRESIONE 4 PARA ACTUALIZAR PRIMER APELLIDO");
                Console.WriteLine("PRESIONE 5 PARA ACTUALIZAR SEGUNDO APELLIDO");
                Console.WriteLine("PRESIONE 6 PARA ACTUALIZAR SALARIO");
                Console.WriteLine("PRESIONE 7 PARA ACTUALIZAR CARGO");
                Console.WriteLine("PRESIONE 8 PARA SALIR DEL PROGRAMA ");
                Console.WriteLine("######################################################");

                Console.WriteLine("ingrese la opcion que requiera");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("INGRESA EL NUEVO CODIGO DEL EMPLEADO:");
                        int codigo = int.Parse(Console.ReadLine());
                        empleado.CodEmpleado = codigo;
                        Console.WriteLine("el codigo actual es : " + empleado.CodEmpleado);
                        break;
                    case 2:
                        Console.WriteLine("INGRESA EL NUEVO CI DEL EMPLEADO:");
                        int carnet = int.Parse(Console.ReadLine());
                        empleado.Ci = carnet;
                        Console.WriteLine("el ci actual es : " + empleado.Ci);
                        break;
                    case 3:
                        Console.WriteLine("INGRESA EL NUEVO NOMBRE DEL EMPLEADO:");
                        string nombre = Console.ReadLine();
                        empleado.Nombres = nombre;
                        Console.WriteLine("el nombre actual es : " + empleado.Nombres);
                        break;
                    case 4:
                        Console.WriteLine("INGRESA EL NUEVO PRIMER APELLIDO DEL EMPLEADO:");
                         string pApellido = Console.ReadLine();
                        empleado.PrimerApellido = pApellido;
                        Console.WriteLine("el primer apellido actual es : " + empleado.PrimerApellido);
                        break;
                    case 5:
                        Console.WriteLine("INGRESA EL NUEVO SEGUNDO APELLIDO DEL EMPLEADO:");
                         string sApellido = Console.ReadLine();
                        empleado.SegundoApellido = sApellido;
                        Console.WriteLine("el segundo apellido actual es : " + empleado.SegundoApellido);
                        break;
                    case 6:
                        Console.WriteLine("INGRESA EL NUEVO SALARIO DEL EMPLEADO:");
                        int sal = int.Parse(Console.ReadLine());
                        empleado.Salario = sal;
                        Console.WriteLine("el salario actual es : " + empleado.Salario);
                        break;
                    case 7:
                        Console.WriteLine("INGRESA EL NUEVO CARGO DEL EMPLEADO:");
                         string carg = Console.ReadLine();
                        empleado.Cargo = carg;
                        Console.WriteLine("el cargo actual es : " + empleado.Cargo);
                        break;
                    case 8:
                        opcion = -1;
                        break;
                    default:
                        Console.WriteLine("INGRESE UNA OPCION DEL 1 AL 8");
                        break;

                }
            }
        }
    }
}
