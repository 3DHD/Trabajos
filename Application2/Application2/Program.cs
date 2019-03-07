using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Application2
{
    class Program
    {
        static void Main(string[] args)
        {
            perimetro obj = new perimetro();
            Console.WriteLine("Ingrese un numero");
            obj.Lado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            obj.Lado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("el area es "+ (obj.Lado1*obj.Lado2));
            Console.ReadKey();


            Cuadrado obj1 = new Cuadrado();
            obj1.setbases(4);
            Console.WriteLine(obj1.getbases());

            obj1.setalturas(4);
            Console.WriteLine(obj1.getalturas());
            obj1.imprimir();
            Console.ReadKey();

        }
    }
}
