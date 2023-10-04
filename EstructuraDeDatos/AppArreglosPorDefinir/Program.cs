using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArreglosPorDefinir
{
    class Program
    {
        static void Main(string[] args)
        {
            //SE CREA EL ARREGLO

            int[] ArregloTelefono = new int[5];
            //SE INSERTA LOS ELEMENTOS DEL ARREGLO
            ArregloTelefono[0] = 1111111;
            ArregloTelefono[1] = 2222222;
            ArregloTelefono[2] = 3333333;
            ArregloTelefono[3] = 4444444;
            ArregloTelefono[4] = 5555555;

            for (int i = 0; i < ArregloTelefono.Length; i++)
            {
                Console.WriteLine("El telefono en la posicion " + i + " es " + ArregloTelefono[i]);
            }
            //Console.ReadLine();

            Console.WriteLine(".........................................");
            Console.WriteLine("ingrese la cantidad de elementos a insertar en el arreglo de paises");
            int cantidadP = int.Parse(Console.ReadLine());
            string[] arregloPaises = new string[cantidadP];
            //se inserta los elementos al arreglo
            for (int k = 0; k < arregloPaises.Length; k++)
            {
                Console.WriteLine("inserte un pais ");
                string pais = Console.ReadLine();
                arregloPaises[k] = pais;
            }
            //visualizar Arreglos
            for (int x = 0; x < arregloPaises.Length; x++)
            {
                Console.WriteLine("El pais en la posicion " + x + " es " + arregloPaises[x]);
            }
            Console.ReadLine();
        }
    }
}
