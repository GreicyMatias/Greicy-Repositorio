using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade02.ExerciciosComplementares
{
    public class TestaFuncionario
    {
        //exercicio 4
        static void Main1()
        {
            Funcionario funcionario01 = new Funcionario();
            Funcionario funcionario02 = new Funcionario();
            funcionario01.nome = "Greicy";
            funcionario02.nome = "Mateus";
            funcionario01.area = "Desenvolvimento";
            funcionario01.cargo = "Arquiteto";
            funcionario02.area = "Desenvolvimento";
            funcionario02.cargo = "Projetista";
            funcionario01.consultaDados();
            funcionario01.aumentaSalario(1000);
            funcionario01.consultaDados();
            funcionario02.consultaDados();
            funcionario02.aumentaSalario(1300);
            funcionario02.consultaDados();
            //Console.WriteLine("Funcionario: {0}\tArea: {1}\tCarggo: {2}",funcionario01.nome,funcionario01.area,funcionario01.cargo);
            //Console.WriteLine("Funcionario: {0}\tArea: {1}\tCarggo: {2}", funcionario02.nome, funcionario02.area, funcionario02.cargo);
            Console.ReadKey();
        }
    }
}
