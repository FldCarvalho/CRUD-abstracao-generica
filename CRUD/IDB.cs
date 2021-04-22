using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ProjetoAluno.Models;

namespace ProjetoAluno.Database
{
    public interface IDB
    {
         AlunoDB db {get;}
         int Commit();
    }
}