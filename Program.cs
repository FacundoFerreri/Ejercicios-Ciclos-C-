using System;

namespace ciclowhile
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, con = 0;

            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());   
            while (n != 0){
                con++;
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());                  
        }
              
            Console.WriteLine("Ingresaste: " + con + " números");
        }
    }
}
