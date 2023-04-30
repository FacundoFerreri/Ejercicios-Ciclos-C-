using System;

namespace ciclofor
{
    class Program
    {
        static void Main(string[] args)
        {     
           // CICLO FOR
            
           // for (int x = 0; x < 5; x++){
           //     Console.WriteLine("Hello World!" + (x + 1));
           // }
               
           int n = 0, promedio, suma = 0, con = 0;

           for (int x = 0; x < 5; x++)
           {
             Console.WriteLine("Ingrese la nota");
             n = int.Parse(Console.ReadLine());
             suma += n;
             con++;

           }
        
           promedio = suma / con;
           
           Console.WriteLine("El promedio del alumx es: " + promedio);


        }
    }
}
