using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade02.ExerciciosComplementares
{
    public class TestaAluno
    {
        //exercicio 2
        static void Main1()
        {
            Aluno aluno01 = new Aluno();
            Aluno aluno02 = new Aluno();
            aluno01.nome = "Greicy";
            aluno01.RG = "123456789";
            aluno01.dataDeNascimento = "02/10/1994";
            aluno02.nome = "Mateus";
            aluno02.RG = "123456789";
            aluno02.dataDeNascimento = "20/11/1991";
            Console.WriteLine("Aluno: {0}\tRG: {1}\tData de Nascimento: {2}", aluno01.nome, aluno01.RG, aluno01.dataDeNascimento);
            Console.WriteLine("Aluno: {0}\tRG: {1}\tData de Nascimento: {2}", aluno02.nome, aluno02.RG, aluno02.dataDeNascimento);
            Console.ReadKey();
        }
    }
}
