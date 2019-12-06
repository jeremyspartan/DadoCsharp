﻿using System;

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
                    Console.Clear();
                    Console.WriteLine("Nueva Visualizacion");
                }
                NumerosDado();
                NumerosDado();
            } while (true);


            static void DibujarDado(int CaraSuperior,int CaraFrontal,int CaraIzquierda)
            {
                //cara superior
                Console.WriteLine("                       ##############");
                Console.WriteLine("                       #            #");
                Console.WriteLine("                       #     {0}      #",CaraSuperior);
                Console.WriteLine("                       #            #");
                //cara frontal
                Console.WriteLine("################################################");
                Console.WriteLine("#            #         #            #          #");
                Console.WriteLine("#     {0}      #    {1}    #     {2}      #     {3}    #",7-CaraFrontal,7-CaraIzquierda,CaraFrontal,CaraIzquierda);
                Console.WriteLine("#            #         #            #          #");
                Console.WriteLine("################################################");
                //cara ziquierda
                Console.WriteLine("                       #            #");
                Console.WriteLine("                       #     {0}      #", 7-CaraSuperior);
                Console.WriteLine("                       #            #");
                Console.WriteLine("                       ##############");
                Console.WriteLine("La sumatoria los valores de las caras de los dados es "
                    +Sumatoria(CaraFrontal, CaraIzquierda, CaraSuperior).ToString());
            }
           
            static void NumerosDado()
            {
                Random r = new Random();
                int[] arreglo = new int[3];
                
                int num = r.Next(1, 7);
                arreglo[0] = num;

                num = r.Next(1, 7);
                while (arreglo[0] == num)
                {
                    num = r.Next(1, 7);
                }
                arreglo[1] = num;

                num = r.Next(1, 8);
                while (arreglo[0] == num || arreglo[1] == num)
                {
                    num = r.Next(1, 7);
                }
                arreglo[2] = num;

                DibujarDado(arreglo[0], arreglo[1], arreglo[2]);
            }

            static int Sumatoria(int CaraSuperior, int CaraFrontal, int CaraIzquierda)
            {
                int suma = CaraFrontal + CaraIzquierda + CaraSuperior + (7 - CaraFrontal) + (7 - CaraIzquierda) + (7 - CaraSuperior);
                    return suma;
            }
        }
    }
}
