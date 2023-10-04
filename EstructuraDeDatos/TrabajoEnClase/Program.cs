using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoEnClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la cantidad de elementos a insertar en el arreglo de sueldos");
            int cantSuel = int.Parse(Console.ReadLine());
            double[] arregloSueldo = new double[cantSuel];
            //se inserta los elementos al arreglo
            for (int k = 0; k < arregloSueldo.Length; k++)
            {
                Console.WriteLine("inserte un sueldo ");
                double sueldo = double.Parse(Console.ReadLine());
                arregloSueldo[k] = sueldo;
            }
            //visualizar Arreglos
            for (int x = 0; x < arregloSueldo.Length; x++)
            {
                Console.WriteLine("El sueldo en la posicion " + x + " es " + arregloSueldo[x]);
            }
            //Console.ReadLine();

            Console.WriteLine(".........................");
            Console.WriteLine("ingrese la cantidad de celulares a insertar en el arreglo de celulares");
            int cantCel = int.Parse(Console.ReadLine());
            Celular[] arregloCelular = new Celular[cantCel];
            for (int i = 0; i < arregloCelular.Length; i++ )
            {
                Console.WriteLine("ingrese los siguientes datos del celular " + (i+1));
                Console.WriteLine("INGRESE EL IMEI");
                int imeiC = int.Parse(Console.ReadLine());
                Console.WriteLine("INGRESE EL NUMERO");
                int numC = int.Parse(Console.ReadLine());
                Console.WriteLine("INGRESE LA MARCA");
                string marC = Console.ReadLine();
                Console.WriteLine("INGRESE EL MODELO");
                string modC = Console.ReadLine();
                Console.WriteLine("INGRESE EL COSTO");
                int costC = int.Parse(Console.ReadLine());

                arregloCelular[i] = new Celular(imeiC, numC, marC, modC, costC);
            }

            for (int k = 0; k < arregloCelular.Length; k++)
            {
                Console.WriteLine("El Celular : " + (k + 1) + "°");
                arregloCelular[k].VisualizarCelular();
            }

            Console.ReadLine();


        }
    }
}
