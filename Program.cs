using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ProjetoAluno.Models;
using ProjetoAluno.Database;

namespace ProjetoAluno
{
    class Program
    {
        static void Main(string[] args)
        {

            //TESTE
            AlunoDatabase db = new AlunoDatabase();
            
            List<IGrouping<string, TbAluno>> groups = db.AgruparPorTurma();

            foreach(IGrouping<string, TbAluno> group in groups)
            {
                Console.WriteLine(group.Key);
                foreach(TbAluno aluno in group)
                {
                    Console.WriteLine("ID: " + aluno.IdAluno + " ALUNO: " + aluno.NmAluno +
                     " TURMA: " + aluno.NmTurma + " CHAMADA: " + aluno.NrChamada);

                }
            }

        }
    }
}
