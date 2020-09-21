using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Khareedo.Models.GenericInterface
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T Obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}