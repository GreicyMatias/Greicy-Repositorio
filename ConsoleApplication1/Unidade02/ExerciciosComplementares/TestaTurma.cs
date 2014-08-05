using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade02.ExerciciosComplementares
{
    public class TestaTurma
    {
        static void Main1()
        {
            Turma turma01 = new Turma();
            turma01.periodo = 1;
            turma01.serie = 4;
            turma01.sigla = "A";
            turma01.tipoDeEnsino = "Programacao";
            Turma turma02 = new Turma();
            turma02.periodo = 3;
            turma02.serie = 4;
            turma02.sigla = "B";
            turma02.tipoDeEnsino = "Banco de Dados"; 
            Console.WriteLine("Periodo: {0}\tSerie: {1}\tSigla: {2}\tTipo de Ensino: {3}",turma01.periodo,turma01.serie,turma01.sigla,turma01.tipoDeEnsino);
            Console.WriteLine("Periodo: {0}\tSerie: {1}\tSigla: {2}\tTipo de Ensino: {3}", turma02.periodo, turma02.serie, turma02.sigla, turma02.tipoDeEnsino);
            Console.ReadKey();
        }
    }
}
