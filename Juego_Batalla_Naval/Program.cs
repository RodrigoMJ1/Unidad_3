using System;
namespace Programa
{
      public class Programa
      {
            static void Main(string[] args)
            {
                MenuJuego();
            }
            static void MenuJuego(){
                Boolean r = true;
                while(r == true){
                Console.WriteLine("Bienvenido a batalla naval: \n1.Jugar \n2.Salir");
                string opc = Console.ReadLine();
                switch (opc){
                    case "1":
                        Juego();
                        r = false;
                    break;
                    case "2":
                        Console.WriteLine("Saliendo del juego...");
                        r = false;
                    break;
                    default:
                        Console.WriteLine("Opción no válida");
                    break;
                }
                }
            }
            static void Juego(){
                List<int> jugador1 = new List<int>();
                List<int> jugador2 = new List<int>();
            
                Console.WriteLine("La dimension en la que se jugara es de 1*10 (Puedes elegir de la posición 1 a la 10)");

                Console.WriteLine("Jugador 1");
                Console.WriteLine("Jugador 1: Ingresa la posición de tu primer barco (1-10)");
                string posicion1 = Console.ReadLine();
                int posicion11;
                posicion11 = Convert.ToInt32(posicion1);
                jugador1.Add(posicion11);

                Console.WriteLine("Jugador 1: Ingresa la posición de tu segundo barco (1-10)");
                string posicion2 = Console.ReadLine();
                int posicion22;
                posicion22 = Convert.ToInt32(posicion2);
                jugador1.Add(posicion22);

                Console.WriteLine("Jugador 1: Ingresa la posición de tu tercer barco (1-10)");
                string posicion3 = Console.ReadLine();
                int posicion33;
                posicion33 = Convert.ToInt32(posicion3);
                jugador1.Add(posicion33);

                Console.WriteLine("Jugador 2");
                Console.WriteLine("Jugador 2: Ingresa la posición de tu primer barco (1-10)");
                string posicion4 = Console.ReadLine();
                int posicion44;
                posicion44 = Convert.ToInt32(posicion4);
                jugador2.Add(posicion44);

                Console.WriteLine("Jugador 2: Ingresa la posición de tu segundo barco (1-10)");
                string posicion5 = Console.ReadLine();
                int posicion55;
                posicion55 = Convert.ToInt32(posicion5);
                jugador2.Add(posicion55);

                Console.WriteLine("Jugador 2: Ingresa la posición de tu tercer barco (1-10)");
                string posicion6 = Console.ReadLine();
                int posicion66;
                posicion66 = Convert.ToInt32(posicion6);
                jugador2.Add(posicion66);
                Batalla(jugador1 , jugador2);
                Console.WriteLine("Juego finalizado...");
                MenuJuego();
            }
             static void Batalla(List<int> jugador1 , List<int> jugador2){
                Console.WriteLine("El juego ha empezado...");
                Boolean juego = true;
                while(juego == true){
                    Console.WriteLine("Jugador 1: Ingresa la posible posición del barco de tu oponente (1-10)");
                    string intento1 = Console.ReadLine();
                    int intento11;
                    intento11 = Convert.ToInt32(intento1);
                    if(intento11 == jugador2[0]){
                         jugador2.Remove(intento11);
                         Console.WriteLine("Barco del enemigo eliminado \nQuedan " + jugador2.Count() + " barcos");
                    }
                    else if(intento11 == jugador2[1]){
                         jugador2.Remove(intento11);
                         Console.WriteLine("Barco del enemigo eliminado \nQuedan " + jugador2.Count() + " barcos");
                    }
                    else if(intento11 == jugador2[2]){
                        jugador2.Remove(intento11);
                        Console.WriteLine("Barco del enemigo eliminado \nQuedan " + jugador2.Count() + " barcos");
                    }
                    if(jugador2.Count() == 0){
                        Console.WriteLine("---------------------Jugador 1 haz ganado---------------------");
                        juego = false;
                        return;
                    }
                    Console.WriteLine("Sigue intentandolo Jugador 1!!");
                    Console.WriteLine("Jugador 2: Ingresa la posible posición del barco de tu oponente (1-10)");
                    string intento2 = Console.ReadLine();
                    int intento22;
                    intento22 = Convert.ToInt32(intento2);
                    if(intento22 == jugador1[0]){
                         jugador1.Remove(intento22);
                         Console.WriteLine("Barco del enemigo eliminado \nQuedan " + jugador1.Count() + " barcos");
                    }
                    else if(intento22 == jugador1[1]){
                         jugador2.Remove(intento22);
                         Console.WriteLine("Barco del enemigo eliminado \nQuedan " + jugador1.Count() + " barcos");
                    }
                    else if(intento22 == jugador1[2]){
                        jugador2.Remove(intento22);
                        Console.WriteLine("Barco del enemigo eliminado \nQuedan " + jugador1.Count() + " barcos");
                    }
                    if(jugador1.Count() == 0){
                        Console.WriteLine("---------------------Jugador 2 haz ganado---------------------");
                        juego = false;
                        return;
                    }
                    Console.WriteLine("Sigue intentandolo Jugador 2!");
                } 
            }
    }
}

