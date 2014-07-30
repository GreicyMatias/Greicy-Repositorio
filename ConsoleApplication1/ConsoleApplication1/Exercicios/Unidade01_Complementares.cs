using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Exercicios
{
    class Unidade01_Complementares
    {
        static void Main1(string[] args)
        {
            char asterisco = '*';
            char espaco = ' ';
            int contador = 0;
            for (int i = 0; i < 5; i++ )
            {
                contador = 0;
                Console.WriteLine(espaco);
                do{
                    Console.Write(asterisco);
                    contador++;
                }while(contador <= i);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
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
    }
}

