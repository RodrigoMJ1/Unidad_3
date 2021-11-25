using System;
namespace HolaMundo
{
      public class HolaMundo
      {
            static void Main(string[] args)
            {
                Console.WriteLine("Hola Mundo!");
                int n1,n2;
                float suma; 
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
                suma = n1 + n2;
                Console.WriteLine("La suma es:  " + suma);
            }
      }

}