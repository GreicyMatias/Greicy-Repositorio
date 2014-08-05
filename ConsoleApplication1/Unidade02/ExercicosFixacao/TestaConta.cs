using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade02.ExercicosFixacao
{
    public class TestaConta
    {
        //exercicio 9
        static void Main1()
        {
            Conta conta01 = new Conta();
            conta01.numero = 1234;
            conta01.saldo = 1000;
            //conta01.limite = 500;
            Conta conta02 = new Conta();
            conta02.numero = 5678;
            conta02.saldo = 2000;
            //conta02.limite = 250;
            Console.WriteLine(conta01.numero);
            Console.WriteLine(conta01.saldo);
            Console.WriteLine(conta01.limite);
            Console.WriteLine(conta02.numero);
            Console.WriteLine(conta02.saldo);
            Console.WriteLine(conta02.limite);
            Console.ReadKey();

        }
    }
}
