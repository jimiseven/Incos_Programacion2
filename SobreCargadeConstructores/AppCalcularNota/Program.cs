using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcularNota
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante(5218822,"JIMI","TORRICO","PEREDO","PROGRAMACION 2",0,0,0,0,0);

            Console.WriteLine("PARA SABER LA NOTA DEL 1er BIMESTRE INGRESAR LOS SIGUIENTES DATOS : ");
            Console.WriteLine("ASISTENCIA: ");
            int asistencia = int.Parse(Console.ReadLine());
            Console.WriteLine("PRACTICAS: ");
            int practica = int.Parse(Console.ReadLine());
            Console.WriteLine("EXAMEN: ");
            int examen = int.Parse(Console.ReadLine());

            int nota1erBimestre = estudiante.CalcularNota(asistencia, practica, examen);
            estudiante.notaPrimerB = nota1erBimestre;
            estudiante.VisualizarEstudiante();

            Console.WriteLine("###############################################################");
            Console.WriteLine("PARA SABER LA NOTA DEL 2do BIMESTRE INGRESAR LOS SIGUIENTES DATOS : ");
            Console.WriteLine("ASISTENCIA: ");
            int asistencia2 = int.Parse(Console.ReadLine());
            Console.WriteLine("PRACTICAS: ");
            int practica2 = int.Parse(Console.ReadLine());
            Console.WriteLine("EXAMEN: ");
            int examen2 = int.Parse(Console.ReadLine());
            Console.WriteLine("PARTICIPACION: ");
            int participacion = int.Parse(Console.ReadLine());

            int nota2doBimestre = estudiante.CalcularNota(asistencia2, practica2, examen2, participacion);
            estudiante.notaSegundoB = nota2doBimestre;
            estudiante.VisualizarEstudiante();

            Console.WriteLine("###############################################################");
            Console.WriteLine("PARA SABER LA NOTA DEL 3er BIMESTRE INGRESAR LOS SIGUIENTES DATOS : ");
            Console.WriteLine("ASISTENCIA: ");
            int asistencia3 = int.Parse(Console.ReadLine());
            Console.WriteLine("PRACTICAS: ");
            int practica3 = int.Parse(Console.ReadLine());
            Console.WriteLine("EXAMEN: ");
            int examen3 = int.Parse(Console.ReadLine());

            int nota3erBimestre = estudiante.CalcularNota(asistencia3, practica3, examen3);
            estudiante.notaTercerB = nota3erBimestre;
            estudiante.VisualizarEstudiante();

            Console.WriteLine("###############################################################");
            Console.WriteLine("PARA SABER LA NOTA DEL 4to BIMESTRE INGRESAR LOS SIGUIENTES DATOS : ");
            Console.WriteLine("ASISTENCIA: ");
            int asistencia4 = int.Parse(Console.ReadLine());
            Console.WriteLine("PRACTICAS: ");
            int practica4 = int.Parse(Console.ReadLine());
            Console.WriteLine("EXAMEN: ");
            int examen4 = int.Parse(Console.ReadLine());

            int nota4toBimestre = estudiante.CalcularNota(asistencia4, practica4, examen4);
            estudiante.notaCuartoB = nota4toBimestre;
            estudiante.VisualizarEstudiante();

            Console.WriteLine("###############################################################");
            int notaFinal = estudiante.CalcularNota(nota1erBimestre,nota2doBimestre,nota3erBimestre,nota4toBimestre)/4;
            estudiante.notaAnual = notaFinal;
            estudiante.VisualizarEstudiante();

            Console.ReadLine();
        
        }
    }
}
