using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade02.ExercicosFixacao
{
    public class TestaAgencia
    {
        //exercicio 7
        static void Main1()
        {
            Agencia agencia01 = new Agencia();
            agencia01.numero = 1234;
            Agencia agencia02 = new Agencia();
            agencia02.numero = 5678;
            Console.WriteLine(agencia01.numero);
            Console.WriteLine(agencia02.numero);
            Console.ReadKey();
        }
    }
}
