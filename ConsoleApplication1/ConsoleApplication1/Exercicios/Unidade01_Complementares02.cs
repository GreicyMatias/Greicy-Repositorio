using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Exercicios
{
    class Unidade01_Complementares02
    {
        static void Main1(string[] args)
        {
            Random gerador = new Random();
            int horaInicial = gerador.Next(1, 25);            
            int horaFinal = gerador.Next(1, 25);
            Console.WriteLine("Hora  de Inicio: {0}", horaInicial);
            Console.WriteLine("Hora do Fim: {0}", horaFinal);
            int totalDeHoras;
            totalDeHoras = (horaInicial > horaFinal) ? ((24 - horaInicial) + horaFinal) : (horaFinal - horaInicial);           
            Console.WriteLine("A partida foi de {0} horas.", totalDeHoras);
            Console.ReadKey();

        }
        static void Main2(string[] args)
        {
            //Programa 2
            int horas = 0;
            int horasSemana;
            double valorHora = 5.50;
            Random gerador = new Random();
            double total = 0;
            for (int i = 0; i < 4; i++)
            {
                horasSemana = gerador.Next(35, 50);
                if (horasSemana > 40)
                {
                    total += horasSemana * valorHora + ((horasSemana - 40) * (valorHora / 2));
                }
                else
                {
                    total += horasSemana * valorHora;
                }
                horas += horasSemana;
            }
            Console.WriteLine("Trabalhou {0} horas e recebeu R$ {1}. ", horas, total);
            Console.ReadKey();
        }
        static void Main3(string[] args)
        {
            //Programa 3

            int contaCliente = 123;
            Console.WriteLine("Conta: " + contaCliente);
            double saldoConta = 1;
            Console.WriteLine("Saldo: " + saldoConta);
            double debitoConta = 10;
            Console.WriteLine("Débito: " + debitoConta);
            double creditoConta = 100;
            Console.WriteLine("Crédito: " + creditoConta);
            double saldoAtual = saldoConta - debitoConta + creditoConta;
            Console.WriteLine("\n\nSaldo Atual: {0}", saldoAtual);
            if (saldoAtual >= 0)
            {
                Console.WriteLine("Saldo Positivo.");
            }
            else
            {
                Console.WriteLine("Saldo Negativo");
            }
            Console.ReadKey();
        }
        static void Main4(string[] args)
        {
            //Programa 4
            int quantidadeAtual = 10;
            int quantidadeMaxima = 30;
            int quantidadeMinima = 2;
            int quantidadeMedia = (quantidadeMaxima + quantidadeMinima) / 2;
            if (quantidadeAtual >= quantidadeMedia)
            {
                Console.WriteLine("Não efetuar compra.");
            }
            else
            {
                Console.WriteLine("Efetuar compra.");
            }
            Console.ReadKey();
        }
        static void Main5(string[] args)
        {
            //Programa 5
            int opcao = 1;
            double precoG = 3.30;
            double precoA = 2.90;
            double total = 0;
            do
            {
                Console.WriteLine("1 - Gasolina");
                Console.WriteLine("2 - Álcool");
            } while (opcao != 1 && opcao != 2);
            int combustivel = 25;
            if (combustivel > 20 && opcao == 1)
            {
                total = (precoG * combustivel) * 0.94;
            }
            else if (combustivel > 20 && opcao == 2)
            {
                total = (precoA * combustivel) * 0.95;
            }
            else if (combustivel <= 20 && opcao == 1)
            {
                total = (precoG * combustivel) * 0.96;
            }
            else
            {
                total = (precoA * combustivel) * 0.97;
            }
            Console.WriteLine("R$ " + total);
            Console.ReadKey();

        }
    }
}
