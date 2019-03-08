using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer03
    {
        private string nombre;
        private string apellido;
        private string direccion;

        public String Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public String Apellido
        {
            set { this.apellido = value; }
            get { return this.apellido; }
        }

        public String Direccion
        {
            set { this.direccion = value; }
            get { return this.direccion; }
        }
    }
}
