using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRegistroEmpleado
{
    class Empleado
    {
        private int codEmpleado;
        private int ci;
        private string nombres;
        private string primerApellido;
        private string segundoApellido;
        private int salario;
        private string cargo;

        public Empleado(int codEmpleado, int ci, string nombres, string primerApellido, string segundoApellido, int salario, string cargo)
        {
            this.codEmpleado = codEmpleado;
            this.ci = ci;
            this.nombres = nombres;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.salario = salario;
            this.cargo = cargo;
        }
        public void VisualizarEmpleado() {
            Console.WriteLine("#############################");
            Console.WriteLine("LOS DATOS DEL EMPLEADO SON");
            Console.WriteLine("El codigo de empleado es : "+ codEmpleado);
            Console.WriteLine("ci : "+ ci);
            Console.WriteLine("nombres : "+ nombres);
            Console.WriteLine("primer apellido : " + primerApellido);
            Console.WriteLine("segundo apellido : " + segundoApellido);
            Console.WriteLine("salario : "+ salario);
            Console.WriteLine("cargo : "+ cargo);
            Console.WriteLine("###############################");
        }

        //propiedades

        public int CodEmpleado
        {
            get
            {
                return codEmpleado;
            }

            set
            {
                if (value > 0 && value <= 99999999)
                {
                    codEmpleado = value;
                }
                else codEmpleado = 0;
                //para string = null
            }
        }//cod empleado

        public int Ci
        {
            get
            {
                return ci;
            }

            set
            {
                if (value > 999 && value <= 999999999)
                {
                    ci = value;
                }
                else ci = 0;
            }
        }//ci

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value;  }
        }//nombres

        public string PrimerApellido
        {
            get { return primerApellido; }
            set { primerApellido = value; }
        }//primer apellido

        public string SegundoApellido
        {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }//segundoApellido

        public int Salario
        {
            get
            {
                return salario;
            }

            set
            {
                if (value >= 2350 && value <= 7000)
                {
                    salario = value;
                }
                else salario = 0;
            }
        }//salario

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
    }
}
