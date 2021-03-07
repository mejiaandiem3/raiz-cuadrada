using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raiz_cuadrada
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double raiz;

            Console.WriteLine("La raiz cuadrada de un numero. ");
            Console.WriteLine(" ");
            Console.WriteLine("Escribe el numero: ");
            numero = Convert.ToDouble(Console.ReadLine ());

            raiz = Math.Sqrt(numero);

            Console.WriteLine("Esta es la raiz cuadrada del numero: " + raiz);

            Console.ReadKey();

        }
    }
}
