using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class perimetro
    {
        private double lado1;
        private double lado2;

        public double Lado1
        {
            set { this.lado1 = value; }
            get { return this.lado1; }
        }

        public double Lado2
        {
            set { this.lado2= value; }
            get { return this.lado2; }
        }

        public void impti()
        {
            Console.WriteLine("ingrese los lados del cuadrado");
            Console.ReadKey();
        }

    }
}
