using System;

namespace CALCULADORA
{
    class Program
    {
        ///<sumary>
        ///Muestra el menu
        ///</sumary>

        static void MostrarMenu()
        {
            Console.WriteLine("Que queres hacer?");
            Console.WriteLine();
            Console.WriteLine("1 - Sumar dos numeros");
            Console.WriteLine("2 - Multiplicar dos numeros");
            Console.WriteLine("0 - Salir");
        }
        
        static void Main(string[] args)

        {
            Console.WriteLine("Bienvenido a la calculadora");
            MostrarMenu();

            int opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    //sumar TODO
                    Console.WriteLine ("vamos a sumar");
                    int resultado= sumar(4,3)
                    Console.WriteLine("el resultado es" + resultado);
                      
                    break;
                case 2:         
                    //multiplicar TODO 
                    Console.WriteLine ("vamos a multiplicar");
                    int resultado= multiplicar(4,3)
                    Console.WriteLine("el resultado es" + resultado);

                case 3:
                    //dividir 
                              
                    break;
                default:
                    Console.WriteLine("Opción inválida");                    
                    MostrarMenu();
                    break; 
            }

        }
    }
}
