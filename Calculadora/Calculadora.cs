using System;
namespace Calculadora
{
      public class Calculadora
      {
            static void Main(string[] args)
            {
                  int n1;
                  int n2;
                  float suma,resta,multiplicacion,division;
                  Boolean repetir = true;
                  Console.WriteLine("Ingrese numero 1");
                  n1 = int.Parse( Console.ReadLine()); 
                  Console.WriteLine("Ingrese numero 2");
                  n2 = int.Parse(Console.ReadLine()); 
                  while(repetir == true){
                        Console.WriteLine("Ingrese el numero segun lo que desea hacer: \n1. Suma + \n2. Resta - \n3. Multipliacacion * \n4. Division /\n5. Salir ");
                        string opc = Console.ReadLine();
                        switch (opc)
                        {
                              case "1":
                                    suma = n1 + n2;
                                    Console.WriteLine("La suma es: " + suma);
                              break;
                              case "2":
                                    resta = n1 - n2;
                                    Console.WriteLine("La resta es: " + resta);
                              break;
                              case "3":
                                    multiplicacion = n1 * n2;
                                    Console.WriteLine("La multiplicacion es: " + multiplicacion);
                              break;
                              case "4":
                                    division = n1 / n2;
                                    Console.WriteLine("La division es: " + division);
                              break;
                              case "5":
                                    repetir = false;
                              break;
                              default:
                              Console.WriteLine("Caracter u operacion no válida ");
                              break;
                        }
                  }
                  }

            }

}