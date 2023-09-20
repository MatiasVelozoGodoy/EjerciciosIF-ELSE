using System;

namespace ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("dame el tamaño de un lado");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("dame el tamaño de otro lado");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("dame el tamaño de otro lado");
            c = int.Parse(Console.ReadLine());

            if (a != b && b != c)
                Console.WriteLine("escaleno");
            else if (a == b && b == c)
                Console.WriteLine("equilatero");
            else 
                Console.WriteLine("isoseles");

        }
    }
}

// Hacer un programa para ingresar por teclado la longitud de los tres lados de un
// triángulo y que luego determine e informe con un cartel aclaratorio a qué tipo
// de triángulo corresponde:
// a. Equilátero: cuando los tres lados sean iguales.
// b. Isósceles: cuando dos de los tres lados sean iguales.
// c. Escaleno: cuando todos los lados sean distintos.