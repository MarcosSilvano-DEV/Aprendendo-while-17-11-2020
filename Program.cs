using System;

namespace Aprendendo_while_17_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo WHILE");
            
            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());

            int contador = 0;

            while (contador <= numero)
            {
                Console.WriteLine(contador);
                contador = contador +1;
            };
        }
    }
}
