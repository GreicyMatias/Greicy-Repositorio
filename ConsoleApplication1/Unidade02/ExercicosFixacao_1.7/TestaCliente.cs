using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade02.ExercicosFixacao_1._7
{
    class TestaCliente
    {
        public static void Main()
        {
            Cliente cliente01 = new Cliente();
            cliente01.nome = "Greicy Matias";
            cliente01.codigo = 01;
            Cliente cliente02 = new Cliente();
            cliente02.nome = "Mateus Coutinho";
            cliente02.codigo = 02;
            Console.WriteLine(cliente01.nome);
            Console.WriteLine(cliente01.codigo);
            Console.WriteLine(cliente02.nome);
            Console.WriteLine(cliente02.codigo);
            Console.ReadKey();

        }
    }
}
