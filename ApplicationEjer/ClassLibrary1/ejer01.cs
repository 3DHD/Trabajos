using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer01
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
    }
}
