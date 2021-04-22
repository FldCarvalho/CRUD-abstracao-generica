using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ProjetoAluno.Models;

namespace ProjetoAluno.Database
{
    public class AlunoDatabase : RemoteDB<TbAluno>
    {
        public List<IGrouping<string, TbAluno>> AgruparPorTurma()
        {
            List<TbAluno> list = base.Listar();
            List<IGrouping<string, TbAluno>> groups = list.GroupBy(x => x.NmTurma).ToList();
            return groups;
        }
    }
}