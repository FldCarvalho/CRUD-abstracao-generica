using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace ProjetoAluno.Database
{
    public interface ICrud<T>
    {
        T Salvar (T record);
        void Alterar (T record  );
        void Remover (int id);
        List<T> Listar ();
        T Consultar (int id);
        List<T> Consultar (Func<T, bool> filter);
    }
}