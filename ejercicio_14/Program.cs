using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            Console.WriteLine("dame un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("dame el segundo numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("dame el tercer numero");
            c = int.Parse(Console.ReadLine());
            d = a + b;
            e = b * c;
            if(d > e)
                Console.WriteLine("Es mayor");
        }
    }
}

// 4. Hacer un programa para ingresar tres números y emitir un cartel 
// aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

