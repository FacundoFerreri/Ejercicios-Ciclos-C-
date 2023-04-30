using System;

namespace ciclodowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;
            
            do{
               Console.WriteLine("Ingrese un número: ");
               n = int.Parse(Console.ReadLine());
               con++;

            }while (n != 0);
            
            Console.WriteLine("Ingresaste " + con + "nros.");

        }
    }
}
