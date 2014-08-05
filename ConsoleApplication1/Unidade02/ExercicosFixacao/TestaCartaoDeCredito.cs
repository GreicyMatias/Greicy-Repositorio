using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade02.ExercicosFixacao
{
    public class TestaCartaoDeCredito
    {
        static void Main1()
        {
            //exercicio 5
            CartaoDeCredito cartaoDeCredito01 = new CartaoDeCredito();
            cartaoDeCredito01.numero = 114532543;
            cartaoDeCredito01.dataDeValidade = "12/17";

            Cliente c = new Cliente();
            c.codigo = 234324;
            c.nome = "Greicy";

            Cliente d = new Cliente();
            d.codigo = 454634;
            d.nome = "Mateus";

            CartaoDeCredito cartaoDeCredito02 = new CartaoDeCredito();
            cartaoDeCredito02.numero = 098765676;
            cartaoDeCredito02.dataDeValidade = "12/18";

            cartaoDeCredito01.cliente = c;
            cartaoDeCredito02.cliente = d;

            Console.WriteLine(cartaoDeCredito01.numero);
            Console.WriteLine(cartaoDeCredito01.dataDeValidade);
            Console.WriteLine(cartaoDeCredito01.cliente.nome);
            Console.WriteLine(cartaoDeCredito01.cliente.codigo);
            Console.WriteLine(cartaoDeCredito02.numero);
            Console.WriteLine(cartaoDeCredito02.dataDeValidade);
            Console.WriteLine(cartaoDeCredito02.cliente.nome);
            Console.WriteLine(cartaoDeCredito02.cliente.codigo);
            Console.ReadKey();
        }
    }
}
