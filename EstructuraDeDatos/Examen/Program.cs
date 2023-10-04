using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar el numero de Productos a ingresar");
            int cantPro = int.Parse(Console.ReadLine());
            Producto[] arregloPro = new Producto[cantPro];

            for (int i = 0; i < arregloPro.Length; i++)
            {
                Console.WriteLine("Ingresar los siguientes datos" + (i + 1));
                Console.WriteLine("Ingrese el CodProducto : ");
                int codProducto = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Nombre : ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el tipo : ");
                string tipo = Console.ReadLine();
                Console.WriteLine("Ingrese el precio : ");
                int precio = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la marca : ");
                string marca = Console.ReadLine();



                arregloPro[i] = new Producto(codProducto, nombre, tipo, precio, marca);

                arregloPro[i].CodProducto = codProducto;
                arregloPro[i].Precio = precio;
            }

            for (int k = 0; k < arregloPro.Length; k++)
            {
                Console.WriteLine("El producto : " + (k + 1) + "°");
                arregloPro[k].VisualizarProducto();
            }

            Console.ReadLine();
        }
    }
}
