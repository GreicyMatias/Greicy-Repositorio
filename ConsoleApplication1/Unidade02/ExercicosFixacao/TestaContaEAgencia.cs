using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade02.ExercicosFixacao
{
    public class TestaContaEAgencia
    {
        static void Main1()
        {
            Agencia a = new Agencia();
            a.numero = 2314324;

            ContaEAgencia c1 = new ContaEAgencia();
            c1.numero = 1234;
            c1.saldo = 1000;
            c1.limite = 500;

            c1.agencia = a;

            Console.WriteLine(c1.numero);
            Console.WriteLine(c1.saldo);
            Console.WriteLine(c1.limite);
            Console.WriteLine(c1.agencia.numero);
            Console.ReadKey();
        }        
    }
}
