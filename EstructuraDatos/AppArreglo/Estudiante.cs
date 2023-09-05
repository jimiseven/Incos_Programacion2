using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArreglo
{
    class Estudiante
    {
        private int idEstudiante;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string carrera;

        // Getter y setters
        public int IdEstudiante
        {
            get { return idEstudiante; }
            set { idEstudiante = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }

        public string ApellidoMaterno
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
   
        public Estudiante(int idEstudiante, string nombre, string apellidoPaterno, string apellidoMaterno, string carrera)
        {
            IdEstudiante = idEstudiante;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Carrera = carrera;
        }

        public Estudiante()
        {
            // TODO: Complete member initialization
        }

        public void VisualizarEstudiante()
        {
            Console.WriteLine("El ID del Estudiante es : " + idEstudiante);
            Console.WriteLine("El Nombre es : " + nombre);
            Console.WriteLine("El Apellido Paterno : " + apellidoPaterno);
            Console.WriteLine("Apellido Materno : " + apellidoMaterno);
            Console.WriteLine("La carrera es : " + carrera);
        }
        }
}
