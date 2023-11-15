using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVisual
{
    class Cuenta
    {
        public int idCuenta;
        public string correoCuenta;
        public string contraseñaCuenta;
        public DateTime fechaCreacionCuenta;
        public DateTime fechaCargaCuenta;

        public Cuenta(int idCuenta, string correoCuenta, string contraseñaCuenta, DateTime fechaCreacionCuenta, DateTime fechaCargaCuenta)
        {
            this.idCuenta = idCuenta;
            this.correoCuenta = correoCuenta;
            this.contraseñaCuenta = contraseñaCuenta;
            this.fechaCreacionCuenta = fechaCreacionCuenta;
            this.fechaCargaCuenta = fechaCargaCuenta;
        }


        public int IdCuenta
        {
            get { return idCuenta; }
            set { idCuenta = value; }
        }


        public string CorreoCuenta
        {
            get { return correoCuenta; }
            set { correoCuenta = value; }
        }

        public string ContraseñaCuenta
        {
            get { return contraseñaCuenta; }
            set { contraseñaCuenta = value; }
        }

        public DateTime FechaCreacionCuenta
        {
            get { return fechaCreacionCuenta; }
            set { fechaCreacionCuenta = value; }
        }

        public DateTime FechaCargaCuenta
        {
            get { return fechaCargaCuenta; }
            set { fechaCargaCuenta = value; }
        }

        public void VisualizarCuenta()
        {
            Console.WriteLine("Estos son los datos de la Cuenta");
            Console.WriteLine("id de la cuenta : " + idCuenta);
            Console.WriteLine("Correo de la cuenta : " + correoCuenta);
            Console.WriteLine("Contraseña de la cuenta : " + contraseñaCuenta);
            Console.WriteLine("Fecha de creacion de la cuenta : " + fechaCreacionCuenta);
            Console.WriteLine("Fecha de carga de la cuenta : " + fechaCargaCuenta);

        }


    }
}
