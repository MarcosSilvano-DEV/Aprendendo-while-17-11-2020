﻿using System;

namespace Aprendendo_while_17_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine("Aprendendo WHILE");
        //  
        //    Console.WriteLine("Digite um número");
        //    int numero = int.Parse(Console.ReadLine());

        //    int contador = 0;

        //    while (contador <= numero)
        //    {
        //        Console.WriteLine(contador);
        //        contador = contador +1;
        //    };

        //    string resposta = "";
        //    do{
        //        Console.WriteLine("Digite seu e-mail");
        //        resposta = Console.ReadLine();

        //    }while(resposta != "exgorfo@gmail.com");

        //    Console.WriteLine("E-mail confirmado");
              
              Console.WriteLine("Digite a idade do ator");
              int idade = int.Parse(Console.ReadLine());

              while(idade != 47)
              {
                  Console.WriteLine("Errou!");
                  Console.WriteLine("Digite a idade do ator");
                  int idade = int.Parse(Console.ReadLine());
              }
        }
    }
}
