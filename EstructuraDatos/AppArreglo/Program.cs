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

            Console.WriteLine("==================");
            Console.WriteLine("Arreglo de Enteros");
            Console.WriteLine("==================");
            for (int i = 0; i < arregloTelefonos.Length; i++)
            {
                Console.WriteLine("Elemento en el índice " + i + ": " + arregloTelefonos[i]);
            }

            //Arreglo de String

            string[] meses = {
                                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
                            };

            Console.WriteLine("==================");
            Console.WriteLine("Arreglo de Meses");
            Console.WriteLine("==================");
            for (int i = 0; i < meses.Length; i++)
            {
                Console.WriteLine("Elemento en el índice " + i + ": " + meses[i]);
            }
     

            //Arreglo de Salarios = Double

            double[] datos = { 2700.5, 2100.2, 3000.3, 4788.4, 5000.5, 6211.6, 7099.7 };
            Console.WriteLine("==================");
            Console.WriteLine("Arreglo de Salarios");
            Console.WriteLine("==================");
            // Recorrer el arreglo e imprimir cada elemento utilizando un for
            Console.WriteLine("Elementos del arreglo:");
            for (int i = 0; i < datos.Length; i++)
            {
                Console.WriteLine("Salario N° : " +i+ " es = "+ datos[i]);
            }

            //Arreglo de Estudiantes

            Estudiante[] estudiantes = new Estudiante[3];

            estudiantes[0] = new Estudiante
            {
                IdEstudiante = 1,
                Nombre = "Juan",
                ApellidoPaterno = "Perez",
                ApellidoMaterno = "Gomez",
                Carrera = "Ingenieria Informatica"
            };

            estudiantes[1] = new Estudiante
            {
                IdEstudiante = 2,
                Nombre = "Maria",
                ApellidoPaterno = "Gonzalez",
                ApellidoMaterno= "Lopez",
                Carrera = "Medicina"
            };

            estudiantes[2] = new Estudiante
            {
                IdEstudiante = 3,
                Nombre = "Carlos",
                ApellidoPaterno = "Rodriguez",
                ApellidoMaterno = "Fernandez",
                Carrera = "Arquitectura"
            };


            Console.WriteLine("==================");
            Console.WriteLine("Arreglo de Estudiantes");
            Console.WriteLine("==================");

            Console.WriteLine("Informacion de los estudiantes:");
            for (int i = 0; i < estudiantes.Length; i++)
            {
                estudiantes[i].VisualizarEstudiante();
                Console.WriteLine(); 
            }

            Console.ReadLine();



        }
    }
}
