using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int litros;
            float importe = 10; 
            Console.WriteLine("Cuantos litros desea llevar?");
            litros = int.Parse(Console.ReadLine());
            if(litros > 0 && litros < 100){
                importe = litros * importe;
                Console.WriteLine("usted llevo " + litros + " litros y con el precio es de: " + importe);
            }

            if(litros > 101 && litros <= 300){
                importe = litros * importe * 0.90F;
                Console.WriteLine("usted llevo " + litros + " litros y con el precio es de: " + importe);
            }
            if(litros > 301 && litros <= 500){
                importe = litros * importe * 0.85F;
                Console.WriteLine("usted llevo " + litros + " litros y con el precio es de: " + importe);
            }
            if(litros > 500) {
                importe = litros * importe * 0.75F;
                Console.WriteLine("usted llevo " + litros + " litros y con el precio es de: " + importe);
            }
        }
    }
}

// Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
// Si vende menos de 100 litros, no hay descuento.
// Si vende entre 101 y 300 litros, el descuento es del 10%.
// Si vende entre 301 y 500 litros, el descuento es del 15%.
// Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
// Hacer un programa que solicite el ingreso del importe total de la venta 
// y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..