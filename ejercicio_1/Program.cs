using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1;
        Console.WriteLine("Dame un numero");
        n1 = int.Parse(Console.ReadLine());

                if(n1 > 10)
            Console.WriteLine("es mayor de 10");        
        else
            Console.WriteLine("es menor a 10");
        
        
    }
}
}