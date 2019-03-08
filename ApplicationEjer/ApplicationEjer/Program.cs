using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationEjer
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            do
            {
                int opc;
                Console.WriteLine("Ingrese el numero del ejercicio del 1 al 3");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        ejer01 obj = new ejer01();
                        Console.WriteLine("Ingrese el color de la luz del semaforo");
                        String color = Console.ReadLine();
                        Console.WriteLine(obj.Estados(color));
                        break;
                    case 2:
                        ejer02 obj2 = new ejer02();
                        String nombre1 = "Carlos";
                        String nombre2 = "Maria";
                        String nombre3 = "Luis";
                        String nombre4 = "Fernando";
                        Console.WriteLine("Seleccione un color dela luz del semaforo ");
                        String color2 = Console.ReadLine();
                        Console.WriteLine(obj2.Estados(color2, nombre1));
                        Console.WriteLine(obj2.Estados(color2, nombre2));
                        Console.WriteLine(obj2.Estados(color2, nombre3));
                        Console.WriteLine(obj2.Estados(color2, nombre4));
                        break;
                    case 3:
                        ejer03 obj3 = new ejer03();

                        Console.WriteLine("Ingrese el nombre");
                        obj3.Nombre = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Ingrese apellido");
                        obj3.Apellido = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Ingrese su direccion");
                        obj3.Direccion = Convert.ToString(Console.ReadLine());
                        Console.WriteLine(" Buenas noches " + obj3.Nombre + " " + obj3.Apellido + ", Tu vives en : " + obj3.Direccion);                   
                        break;
                    default:
                        break;
                }             
                Console.WriteLine("Desea continuar ? si(1) / no(2)");
                valor = int.Parse(Console.ReadLine());

            } while (valor == 1);
        }
    }
}
