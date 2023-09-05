using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            //llamaremos a este objeto
            //tipo de arreglo con los numero de datos insertados
            //las propiedades aparecen con llavecitas
            int[] arregloTelefonos = {7654765,45674567,4567456,45674567, 23423352};

            for (int i = 0; i < arregloTelefonos.Length; i++)
            {
                Console.WriteLine("Elemento en el índice " + i + ": " + arregloTelefonos[i]);
            }

        }
    }
}
