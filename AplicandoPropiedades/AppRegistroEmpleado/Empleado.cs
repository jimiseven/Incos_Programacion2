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


        //contructor (mismo nombre de clase)

        public Empleado(int codEmpleado, int ci, string nombres, string primerApellido, string segundoApellido, int salario, string cargo) {
            this.codEmpleado = codEmpleado;
            this.ci = ci;
            this.nombres = nombres;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.salario = salario;
            this.cargo = cargo;
        }

        //propiedades

        public int CodEmpleado {
            get {
                return codEmpleado;
            }
            set { 
                if(value > 0 && value <= 99999999){
                    codEmpleado = value;
                }
                else{
                    codEmpleado = 0;
                }
            }
        }//prop codEmpleado

        public int Ci {
            get
            {
                return ci;
            }
            set
            {
                if (value > 999 && value <= 9999999)
                {
                    ci= value;
                }
                else
                {
                    ci= 0;
                }
            }
        }//prop Ci

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string PrimerApellido
        {
            get { return primerApellido; }
            set { primerApellido = value; }
        }

        public string SegundoApellido
        {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }

        public int Salario
        {
            get { return salario; }
            set
            {
                if (value >= 2350 && value <= 7000)
                {
                    salario= value;
                }
                else
                {
                    salario= 0;
                }
            }


        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }


        public void VisualizarEmpleado() {
            Console.WriteLine("Codigo empleado : " + codEmpleado);
            Console.WriteLine("Ci empleado : " + ci);
            Console.WriteLine("Nombre empleado : " + nombres);
            Console.WriteLine("1er apellido empleado : " + primerApellido);
            Console.WriteLine("2do apellido empleado : " + segundoApellido);
            Console.WriteLine("Salario empleado : " + salario);
            Console.WriteLine("Cargo empleado : " + cargo);
        }
    }
}
