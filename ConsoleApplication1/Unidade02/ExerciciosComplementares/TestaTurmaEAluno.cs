using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade02.ExerciciosComplementares
{
    public class TestaTurmaEAluno
    {
        static void Main1()
        {
            Turma turma1 = new Turma();
            turma1.serie = 4;
            turma1.periodo = 5;
            turma1.sigla = "A";
            turma1.tipoDeEnsino = "Ensino Superior";

            Aluno aluno1 = new Aluno();
            aluno1.nome = "Greicy";
            aluno1.RG = "123456789";
            aluno1.dataDeNascimento = "02/10/1994";

            aluno1.turma = turma1;

            Console.WriteLine(aluno1.nome);
            Console.WriteLine(aluno1.RG);
            Console.WriteLine(aluno1.dataDeNascimento);
            Console.WriteLine(aluno1.turma.periodo);
            Console.WriteLine(aluno1.turma.serie);
            Console.WriteLine(aluno1.turma.sigla);
            Console.WriteLine(aluno1.turma.tipoDeEnsino);
            Console.ReadKey();
        }
    }
}
