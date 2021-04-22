using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ProjetoAluno.Models;

namespace ProjetoAluno.Database
{
    public interface ICrudAluno : ICrud<TbAluno>
    {
         List<IGrouping<string, TbAluno>> AgruparPorTurma();
    }
}