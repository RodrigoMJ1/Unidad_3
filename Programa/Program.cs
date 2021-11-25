using System;
namespace Programa
{
      public class Programa
      {
            static void Main(string[] args)
            {
                Menu();
            }
            static void Menu(){
                Boolean r = true;
                while(r == true){
                Console.WriteLine("Ingrese la opción que desea: \n1.Comprar Laptop \n2.Comprar PC \n3.Salir");
                string opc = Console.ReadLine();
                switch (opc){
                    case "1":
                        Laptop();
                        r = false;
                    break;
                    case "2":
                        PC();
                        r = false;
                    break;
                    case "3":
                        Console.WriteLine("Saliendo del programa...");
                        r = false;
                    break;
                    default:
                        Console.WriteLine("Opción no válida");
                    break;
                }
                }
            }
            static void Laptop(){
                Boolean s = true;
                while(s == true){
                Console.WriteLine("Ingrese el monto con el que cuenta actualmente:");
                string monto1 = Console.ReadLine();
                int monto12;
                monto12 = Convert.ToInt32(monto1);
                if(monto12 <= 7000){
                    Console.WriteLine("Tiene muy poco dinero, ahorrele pa'");
                    Menu();
                    s = false;
                } 
                else if (monto12 <= 15000){
                Console.WriteLine("La laptop que le recomendamos es la Asus VivoBook 15 Portátil la cual tiene un precio de $13799 \nPara mas informacion entrar al link: https://www.amazon.com.mx/Asus-VivoBook-Port%C3%A1til-pizarr%C3%B3n-generaci%C3%B3n/dp/B0869L1326/ref=as_li_ss_tl?__mk_es_MX=%C3%85M%C3%85%C5%BD%C3%95%C3%91&dchild=1&keywords=ASUS+VIVOBOOK+15&qid=1594763321&sr=8-1&linkCode=sl1&tag=laptopsbaratasoc-20&linkId=ab6b8a9b07bc6374fc5c7cce81e71fb4&language=es_MX");
                Console.WriteLine("Escriba 1 para regresar al menu");
                string n = Console.ReadLine();
                int n2;
                n2 = Convert.ToInt32(n);
                    if(n2 == 1){
                        Menu();
                        s = false;
                    }   
                }
                else if(monto12 > 15000){
                    Console.WriteLine("La laptop que le recomendamos es la Apple Macbook Air la cual tiene un precio de $24149 \nPara mas informacion entrar al link: https://www.mercadolibre.com.mx/apple-macbook-air-13-pulgadas-2020-chip-m1-256-gb-de-ssd-8-gb-de-ram-gris-espacial/p/MLM17828518?pdp_filters=category:MLM1652#searchVariation=MLM17828518&position=2&search_layout=stack&type=product&tracking_id=52a80fef-dad8-4b87-8448-d34e316e638e");
                    Console.WriteLine("Escriba 1 para regresar al menu");
                    string n1 = Console.ReadLine();
                    int n3;
                    n3 = Convert.ToInt32(n1);
                    if(n3 == 1){
                        Menu();
                        s = false;
                    }               
                }
            }
            }
            static void PC(){
                Boolean s = true;
                while(s == true){
                Console.WriteLine("Ingrese el monto con el que cuenta actualmente:");
                string monto1 = Console.ReadLine();
                int monto12;
                monto12 = Convert.ToInt32(monto1);
                if(monto12 <= 8000){
                    Console.WriteLine("Tiene muy poco dinero, ahorrele pa'");
                    Menu();
                    s = false;
                }
                else if (monto12 <= 20000){
                Console.WriteLine("La PC que le recomendamos es la Acer Aspire Desktop la cual tiene un precio de $9709 \nPara mas informacion entrar al link: https://www.amazon.com.mx/dp/B01N5SXZY8?tag=qorecom-20&linkCode=ogi&th=1&psc=1 ");
                Console.WriteLine("Escriba 1 para regresar al menu");
                string n = Console.ReadLine();
                int n2;
                n2 = Convert.ToInt32(n);
                    if(n2 == 1){
                        Menu();
                        s = false;
                    }   
                }
                else if(monto12 > 20000){
                    Console.WriteLine("La PC que le recomendamos es la Xtreme Pc Gamer Geforce Gtx 1050 la cual tiene un precio de $21899 \nPara mas informacion entrar al link: https://articulo.mercadolibre.com.mx/MLM-915175667-xtreme-pc-gamer-geforce-gtx-1050-ti-i5-16gb-ssd-monitor-24-_JM#position=17&search_layout=stack&type=item&tracking_id=85ffd867-6ba7-4919-ae77-43af3cf3e655");
                    Console.WriteLine("Escriba 1 para regresar al menu");
                    string n1 = Console.ReadLine();
                    int n3;
                    n3 = Convert.ToInt32(n1);
                    if(n3 == 1){
                        Menu();
                        s = false;
                    }               
                }
                } 
            }

      }

}
