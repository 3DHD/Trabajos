using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cuadrado
    {
        public  double bases;
        public  double alturas;

        public void  setbases(double valor)
        {
            bases = valor;
        }

        public double getbases()
        {
            return bases;
        }

        public void setalturas(double valor)
        {
            alturas = valor;
        }

        public double getalturas()
        {
            return alturas;
        }
        public void imprimir()
        {

            Console.WriteLine("El perimetro del cuadrado es : "+((bases *2)+(alturas*2)));

        }
    }
}
