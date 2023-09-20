using System;

namespace ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, mayor = 0, menor = 0, mid = 0;
            Console.WriteLine("dame un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("dame otro numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("dame otro numero");
            c = int.Parse(Console.ReadLine());

            if (a > b){
                mayor = a;
                menor = b;
            } else {
                menor = a;
                mayor = b;
            }

            if (menor < c){
                if (mayor < c){
                    mid = mayor;
                    mayor = c;
                } else {
                    mid = c;
                }
            
            } else {
                mid = menor;
                menor = c;
            }
            
            
            Console.WriteLine("el menor es " + menor + " el del medio es " + mid + " el mayor es " + mayor);
        }
    }
}

// Hacer un programa para ingresar tres números y luego mostrarlos ordenados
// de menor a mayor.