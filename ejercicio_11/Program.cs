using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,x;
            Console.WriteLine("dame un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("dame otro numero");
            b = int.Parse(Console.ReadLine());

            if(a > b){
                x = a - b;
                Console.WriteLine("el resultado de la resta es: " + x);
            }
            else if(a == b){
                x = a + b;
                Console.WriteLine("el resultado de la suma es: " + x);
            }     
            else if(a < b){
                x = a * b;
                Console.WriteLine("el resultado de la multiplicacion es: " + x);
            }
            
            
        }
    }
}

//  Hacer un programa que solicite el ingreso de dos números y luego calcular:
//  La resta si el primero es mayor que el segundo.
//  La suma si son iguales.
//  El producto si el primero es menor.
//  Se deberá emitir un cartel por pantalla con el resultado correspondiente.