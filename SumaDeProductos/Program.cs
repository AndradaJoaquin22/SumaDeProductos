using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDeProductos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,suma,producto;
            string linea;
            Console.Write("Escriba el primer valor a sumar:");
            linea = Console.ReadLine();
            num1=int.Parse(linea);
            Console.Write("Escriba el segundo numero:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            suma = num1 + num2;
            producto = num1 * num2;
            Console.Write("La suma de los numeros es:");
            Console.Write(suma);
            Console.Write("Y el producto es:");
            Console.Write(producto);
            Console.ReadKey();
        }
    }
}
