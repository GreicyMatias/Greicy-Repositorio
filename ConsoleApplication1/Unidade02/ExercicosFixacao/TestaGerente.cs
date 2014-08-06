using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade02.ExercicosFixacao
{
    class TestaGerente
    {
        static void Main1()
        {
            Gerente g = new Gerente();
            g.salario = 1000;
            Console.WriteLine("Salário: " + g.salario);
            Console.WriteLine("Aumentando o salário em 10%");
            g.AumentoSalario();
            Console.WriteLine("Salário: " + g.salario);
            Console.WriteLine("Aumentando o salário em 30%");
            g.AumentoSalario(0.3);
            Console.WriteLine("Salário: " + g.salario);
            Console.ReadKey();
        }
    }
}
