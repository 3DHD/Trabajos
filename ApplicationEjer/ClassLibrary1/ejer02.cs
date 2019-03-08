using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer02
    {
        public String Estados(String estado)
        {
            if (estado == "verde")
            {
                return "Adelante";
            }
            else if (estado == "amarillo")
            {
                return "Precaucion";
            }
            else if (estado == "rojo")
            {
                return "Deterner";
            }
            return "Color Invalido";
        }
        public String Estados(String estado, String nombre)
        {
            if (estado == "verde")
            {
                return nombre + " " + "Adelante";
            }
            else if (estado == "amarillo")
            {
                return nombre + " " + "Precaucion";
            }
            else if (estado == "rojo")
            {
                return nombre + " " + "Deterner";
            }
            return nombre + " " + "Color Invalido";
        }
    }
}
