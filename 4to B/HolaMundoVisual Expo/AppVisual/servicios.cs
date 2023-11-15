using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVisual
{
    class servicios
    {
        private int idServicio;
        private string nombreServicio;
        private string correoPadre;
        private string contraseñaPadre;
        private DateTime fechaCreacioServicio;

        public servicios(int idServicio, string nombreServicio, string correoPadre, string contraseñaPadre, DateTime fechaCreacioServicio)
        {
            this.idServicio = idServicio;
            this.nombreServicio = nombreServicio;
            this.correoPadre = correoPadre;
            this.contraseñaPadre = contraseñaPadre;
            this.fechaCreacioServicio = fechaCreacioServicio;
        }
        public int IdServicio
        {
            get { return idServicio; }
            set { idServicio = value; }
        }

        public string NombreServicio
        {
            get { return nombreServicio; }
            set { nombreServicio = value; }
        }

        public string CorreoPadre
        {
            get { return correoPadre; }
            set { correoPadre = value; }
        }


        public string ContraseñaPadre
        {
            get { return contraseñaPadre; }
            set { contraseñaPadre = value; }
        }

        public DateTime FechaCreacioServicio
        {
            get { return fechaCreacioServicio; }
            set { fechaCreacioServicio = value; }
        }

        public void VisualizarServicio()
        {
            Console.WriteLine("Estos son los datos del Servicio");
            Console.WriteLine("id del servicio : " + idServicio);
            Console.WriteLine("Nombre del servicio : " + nombreServicio);
            Console.WriteLine("Correo Padre : " + correoPadre);
            Console.WriteLine("Contraseña Padre : " + contraseñaPadre);
            Console.WriteLine("Fecha de creacion del servicio : " + fechaCreacioServicio);
            
        }

    }
}
