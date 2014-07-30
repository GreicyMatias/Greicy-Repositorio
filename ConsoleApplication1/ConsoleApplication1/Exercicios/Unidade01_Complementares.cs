﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Exercicios
{
    class Unidade01_Complementares
    {
        static void exercicio1()
        {
            char asterisco = '*';
            char espaco = ' ';
            int contador = 0;
            for (int i = 0; i < 5; i++)
            {
                contador = 0;
                Console.WriteLine(espaco);
                do
                {
                    Console.Write(asterisco);
                    contador++;
                } while (contador <= i);
            }
            Console.ReadKey();
        }
        static void exercicio2()
        {
            char asterisco = '*';
            char espaco = ' ';
            int contador = 0;
            for (int y = 0; y < 3; y++)
            {
                for (int i = 0; i < 5; i++)
                {
                    contador = 0;
                    Console.WriteLine(espaco);
                    do
                    {
                        Console.Write(asterisco);
                        contador++;
                    } while (contador <= i);
                }
            }
            Console.ReadKey();
        }
        static void exercicio3(string[] args)
        {
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int proximoNumero = 1;
            Console.WriteLine(numeroAnterior);
            Console.WriteLine(numeroAtual);
            for (int contador = 0; contador < 27; contador++)
            {
                Console.WriteLine(proximoNumero);
                numeroAnterior = numeroAtual;
                numeroAtual = proximoNumero;
                proximoNumero = numeroAtual + numeroAnterior;
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int opcao = 0;
            do{
                Console.WriteLine("------------- MENU --------------");
                Console.WriteLine("1 - Exercicio 1;");
                Console.WriteLine("2 - Exercicio 2;");
                Console.WriteLine("3 - Exercicio 3;");
                Console.WriteLine("0 - Sair;");

            }while(opcao != 0);
        }
    }
}

