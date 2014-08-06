using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade02.ExerciciosComplementares
{
    public class Funcionario
    {
        //exercicio 3
        public string nome;
        public string cargo;
        public string area;
        public double salario;

        public void aumentaSalario(double valor)
        {
            this.salario += valor;
        }
        public void consultaDados()
        {
            Console.WriteLine("NOME: {0}    CARGO: {1}   ÁREA: {2}   SALÁRIO: {3}",this.nome,this.cargo,this.area,this.salario);            
        }
    }
}
