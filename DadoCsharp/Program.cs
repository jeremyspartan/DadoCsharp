using System;

namespace DadoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                if (Console.ReadKey().Key == ConsoleKey.S)
                {
                    Console.WriteLine("Limpiado");
                }
            } while (true);
        }
    }
}
