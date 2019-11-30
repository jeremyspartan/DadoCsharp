using System;

namespace DadoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                if(Console.ReadKey().Key==ConsoleKey.Enter)
                {
                    Console.WriteLine("Nueva Visualizacion");
                }
                DibujarDado(4, 8, 2);
            } while (true);


            static void DibujarDado(int CaraSuperior,int CaraFrontal,int CaraIzquierda)
            {
                //cara superior
                Console.WriteLine("             ########################");
                Console.WriteLine("             #                      #");
                Console.WriteLine("             #            {0}         #",CaraSuperior);
                Console.WriteLine("             #                      #");
                //cara frontal
                Console.WriteLine("#################################################");
                Console.WriteLine("#          #              #            #          #");
                Console.WriteLine("#    {0}   #    {1}       #     {2}         #     {3}    #",7-CaraFrontal,7-CaraIzquierda,CaraFrontal,CaraIzquierda);
                Console.WriteLine("#          #              #            #          #");
                Console.WriteLine("##################################################");
                //cara ziquierda
                Console.WriteLine("            #                      #");
                Console.WriteLine("            #            {0}         #", CaraSuperior);
                Console.WriteLine("            #                      #");
                Console.WriteLine("            ########################");
            }
        }
    }
}
