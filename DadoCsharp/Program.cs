using System;

namespace DadoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                if (Console.ReadKey().Key == ConsoleKey.Backspace)
                {
                    Console.WriteLine("Limpiado");
                }
            } while (true);
        }
    }
}
