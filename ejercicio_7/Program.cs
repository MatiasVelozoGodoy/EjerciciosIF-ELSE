using System;

namespace ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("dame un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("dame un numero");
            b = int.Parse(Console.ReadLine());

            if(a == b)
                Console.WriteLine("Son iguales");
                else if(a > b)
                Console.WriteLine("el mayor es: " + a);
                else 
                Console.WriteLine("El mayor es: " + b);
        }
    }
}

// Hacer un programa para ingresar dos números y que luego emita por pantalla
// el mayor de ellos o un cartel aclaratorio “Son iguales” en el caso de que así sea.
// Nota: los números pueden ser iguales.