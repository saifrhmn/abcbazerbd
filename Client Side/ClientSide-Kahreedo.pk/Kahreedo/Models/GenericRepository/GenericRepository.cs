using Khareedo.Models.GenericInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Khareedo.Models.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private KhareedoEntities _context = null;
        private DbSet<T> table = null;

        public GenericRepository()
        {
            this._context = new KhareedoEntities();
            table = _context.Set<T>();
        }

        public GenericRepository(KhareedoEntities _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T Obj)
        {
            table.Add(Obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

       
    }
}