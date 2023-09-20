using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d;
            Console.WriteLine("Dame un numero?");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame un numero?");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame un numero?");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame un numero?");
            d = int.Parse(Console.ReadLine());
            if(a > 100)
                Console.WriteLine(a);
            if(b > 100)
                Console.WriteLine(b);
            if(c > 100)
                Console.WriteLine(c);
            if(d > 100)
                Console.WriteLine(d);
        }
    }
}

// Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

