using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Exercicios
{
    class Unidade01_Logica
    {
        static void Main1(string[] args)
        {
            //Imprime Nome
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Greicy Matias");
            }
            Console.ReadKey();
        }
        static void Main2(string[] args)
        {
            //Imprime Numeros
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        static void Main3(string[] args)
        {
            //Imprime Padrão 01
            Console.WriteLine("Legenda: * = ímpar / ** = par\n");                  
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i+"\t");
                int resto = i % 2;
                if (resto == 1)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.WriteLine("**");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
        static void Main4(string[] args)
        {
            //Imprime Padrão 02
            for (int i = 1; i <= 100; i++)
            {
                int resto = i % 4;
                if (resto == 0)
                {
                    Console.WriteLine("PI");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }      
    }
}
