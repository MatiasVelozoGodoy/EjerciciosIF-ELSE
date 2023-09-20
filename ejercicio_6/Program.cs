using System;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b, menor;
            Console.WriteLine("dame un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("dame un numero");
            b = int.Parse(Console.ReadLine());

            if(a>b)
                menor = b;
            else 
                menor = a;
                Console.WriteLine("el menor es: " + menor);
        }
    }
}

//Hacer un programa para ingresar dos números distintos y luego se muestre por
//pantalla el menor de ellos.