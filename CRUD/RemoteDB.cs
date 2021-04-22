using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ProjetoAluno.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoAluno.Database
{
    public abstract class RemoteDB<T> : ICrud<T>, IDB where T : class, new()
    {
        public AlunoDB db {get;}
        public DbSet<T> tableDB;
        public RemoteDB()
        {
            db = new AlunoDB();
            tableDB = db.Set<T>();
        }
        public int Commit()
        {
            return db.SaveChanges();
        }
        public T Salvar(T record)
        {
            tableDB.Add(record);
            Commit();
            return record;
        }
        public void Alterar(T record)
        {
            tableDB.Update(record);
            Commit();
        }
        public List<T> Listar()
        {
            return tableDB.ToList();
        }
        public T Consultar(int id)
        {
            return tableDB.Find(id);
        }
        public List<T> Consultar(Func<T, bool> func)
        {
            return tableDB.Where(func).ToList();
        }
        public void Remover(int id)
        {
            T record = Consultar(id);
            tableDB.Remove(record);
            Commit();
        }
    }
}