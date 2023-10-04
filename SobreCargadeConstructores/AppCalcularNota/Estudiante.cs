using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcularNota
{
    class Estudiante
    {
        public int ci;
        public string nombre;
        public string primerAp;
        public string segundoAp;
        public string materia;
        public int notaPrimerB;
        public int notaSegundoB;
        public int notaTercerB;
        public int notaCuartoB;
        public int notaAnual;

        public Estudiante(int ci,string nombre,string primerAp,string segundoAp,string materia,int notaPrimerB,int notaSegundoB,int notaTercerB,
                          int notaCuartoB, int notaAnual) 
        {
            this.ci = ci;
            this.nombre = nombre;
            this.primerAp =primerAp;
            this.segundoAp = segundoAp;
            this.materia = materia;
            this.notaPrimerB = notaPrimerB;
            this.notaSegundoB = notaSegundoB;
            this.notaTercerB =notaTercerB;
            this.notaCuartoB = notaCuartoB;
            this.notaAnual = notaAnual;
        }

        public void VisualizarEstudiante()
        {
            Console.WriteLine("Los Datos del Estudiante son: ");
            Console.WriteLine("Carnet: " + ci);
            Console.WriteLine("Nombres: " + nombre);
            Console.WriteLine("Apellido Paterno: " + primerAp);
            Console.WriteLine("Apellido Materno: " + segundoAp);
            Console.WriteLine("La Materia: " + materia);
            Console.WriteLine("Nota del 1er Bimestre: " + notaPrimerB);
            Console.WriteLine("Nota del 2do Bimestre: " + notaSegundoB);
            Console.WriteLine("Nota del 3er Bimestre: " + notaTercerB);
            Console.WriteLine("Nota del 4to Bimestre: " + notaCuartoB);
            Console.WriteLine("Nota Anual: " + notaAnual);
        }

        public int CalcularNota(int asistencia,int practica,int examen)
        {
            int notaBimestral = asistencia + practica + examen;
            return notaBimestral;
        }

        public int CalcularNota(int asistencia, int practica, int examen,int participacion)
        {
            int notaBimestral = asistencia + practica + examen + participacion;
            return notaBimestral;
        }

        public int CalcularNota()
        {
            int notaAnual = (notaPrimerB + notaSegundoB + notaTercerB + notaCuartoB) / 4;
            return notaAnual;
        }
    }
}
