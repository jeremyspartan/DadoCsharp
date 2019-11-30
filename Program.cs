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
            } while (true);
        }
    }
}
