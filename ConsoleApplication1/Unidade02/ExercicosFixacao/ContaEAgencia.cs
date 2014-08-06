using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade02.ExercicosFixacao
{
    public class ContaEAgencia
    {
        public int numero;
        public double saldo;
        public double limite = 100;
        public Agencia agencia;
        
        //exercicio 16
        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
        public void Saca(double valor)
        {
            this.saldo -= valor; 
        }
        public void ImprimeExtrato()
        {
            Console.WriteLine("SALDO: " + this.saldo);
        }
        public double ConsultaSaldoDisponivel()
        {
            return this.saldo + this.limite;
        }
    }
}
