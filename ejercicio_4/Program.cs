using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d,menor = 0;
            Console.WriteLine("Dame un numero?");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame un numero?");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame un numero?");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame un numero?");
            d = int.Parse(Console.ReadLine());

            if(a < b)
                menor = a;
            
            else
                menor = b;
            if(c < menor)
                menor = c;
            if(d < menor)
                menor = d;
            
            Console.WriteLine("El numero mas grande es:" + menor);
        }
    }
}

// 4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
