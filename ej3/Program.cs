using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, acu = 0, con = 0, promedio = 0;

            for (int x = 0; x < 20; x++){
             Console.WriteLine("Ingrese la edad de la persona");
             edad = int.Parse(Console.ReadLine());
              if (edad > 18){
                  acu+= edad;
                  con++;
                }  
            }   
            
            promedio = acu / con;
            Console.WriteLine("El promedio de edad de las personas mayores a 18 es " + promedio + " años");


                



        }
    }
}
